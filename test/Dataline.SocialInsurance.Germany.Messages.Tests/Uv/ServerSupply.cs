extern alias uv10;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

using BeanIO;

using de.werum.uvkp.plausi;

using ExtraStandard;
using ExtraStandard.Encryption;
using ExtraStandard.Extra14;
using ExtraStandard.GkvKomServer;
using ExtraStandard.GkvKomServer.Validation.Extra14;
using ExtraStandard.Validation;

using Org.BouncyCastle.Pkcs;

using RT;
using RT.CombByteOrder;

using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Tests.Support;

using ExtraDataType = ExtraStandard.GkvKomServer.ExtraDataType;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public class ServerSupply
    {
        private static readonly Uri UriMeldungExtra14 = new Uri("https://verarbeitung.gkv-kommunikationsserver.de/meldung/extra14.meldung");
        private static readonly Uri UriAnfrageExtra14 = new Uri("https://verarbeitung.gkv-kommunikationsserver.de/anfrage/extra14.anfrage");
        private static readonly Uri UriQuittungExtra14 = new Uri("https://verarbeitung.gkv-kommunikationsserver.de/quittung/extra14.quittung");

        private static readonly Lazy<StreamFactory> _streamFactory = new Lazy<StreamFactory>(() =>
        {
            var sf = StreamFactory.NewInstance();
            sf.Load(Mappings.Meldungen.LoadMeldungen());
            return sf;
        });

        private static StreamFactory StreamFactory => _streamFactory.Value;

        private static readonly ICombProvider _combProvider = new CombProvider();

        private static readonly ExtraStandard.GkvKomServer.Extra14.IGkvExtra14ValidatorFactory _validatorFactory = new GkvExtraValidatorFactory();

        public AbsenderInformation Absender { get; } = new AbsenderInformation();

        public Task<ResponseInfo> SupplyData(int fileNumber, IReadOnlyCollection<IDatensatz> records)
        {
            return SupplyData(fileNumber, records, _combProvider.Create());
        }

        public async Task<ResponseInfo> SupplyData(int fileNumber, IReadOnlyCollection<IDatensatz> records, Guid requestId)
        {
            var requestTimestamp = DateTime.Now;

            var packages = new List<PackageRequestType>
            {
                await CreatePackage(fileNumber, records, _combProvider.Create(), requestTimestamp)
            };

            var request = new TransportRequestType()
            {
                version = SupportedVersionsType.Item14,
                profile = ExtraProfile.DeuevGkv14,
                TransportHeader = new TransportRequestHeaderType()
                {
                    Sender = new SenderType()
                    {
                        SenderID = new ClassifiableIDType()
                        {
                            Value = Absender.Betriebsnummer,
                        },
                        Name = new TextType()
                        {
                            Value = Absender.Name,
                        }
                    },
                    Receiver = new ReceiverType()
                    {
                        ReceiverID = new ClassifiableIDType()
                        {
                            Value = "19878051"
                        },
                        Name = new TextType()
                        {
                            Value = "Kommunikationsserver",
                        }
                    },
                    RequestDetails = new RequestDetailsType()
                    {
                        RequestID = new ClassifiableIDType()
                        {
                            Value = requestId.ToString("N"),
                        },
                        TimeStamp = requestTimestamp,
                        TimeStampSpecified = true,
                        Application = new ApplicationType()
                        {
                            Product = new TextType()
                            {
                                Value = "Lohnabzug"
                            },
                            Manufacturer = "Dataline GmbH & Co. KG"
                        },
                        Scenario = ExtraScenario.RequestWithAcknowledgement
                    }
                },
                TransportBody = new TransportRequestBodyType()
                {
                    Items = packages.Cast<object>().ToArray(),
                }
            };

            var response = await Execute(request);
            var errors = string.Join(Environment.NewLine, response.GetErrors().Select(x => $"{x.Code} ({x.weight}): {x.Text}"));
            if (!string.IsNullOrEmpty(errors))
                throw new Exception(errors);

            var responseId = response.TransportHeader.ResponseDetails.ResponseID.Value;
            return new ResponseInfo(
                request.TransportHeader.RequestDetails.RequestID.Value,
                responseId,
                new PackageInfo[0]);
        }

        public async Task<TransportResponseType> Execute(TransportRequestType request)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("xreq", "http://www.extra-standard.de/namespace/request/1");
            ns.Add("xcpt", "http://www.extra-standard.de/namespace/components/1");
            ns.Add("xplg", "http://www.extra-standard.de/namespace/plugins/1");

            var requestEncoding = ExtraStandard.ExtraUtilities.DefaultExtraEncoding;
            var serialized = ExtraStandard.ExtraUtilities.Serialize(request, requestEncoding);
            var document = XDocument.Load(new MemoryStream(serialized));

            var validator = _validatorFactory.Create(ExtraMessageType.SupplyData, ExtraTransportDirection.Request, false);
            validator.Validate(document);

            var contentType = $"text/xml; charset={requestEncoding.WebName}";

#if USE_HTTPCLIENT
            var messageHandler = new WebRequestHandler()
            {
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ClientCertificates =
                {
                    new X509Certificate2(Absender.Zertifikat.RawData)
                },
            };

            var httpClient = new HttpClient(messageHandler)
            {
                DefaultRequestHeaders =
                {
                    UserAgent =
                    {
                        new ProductInfoHeaderValue("DatalineLohnabzug", "27.0.0")
                    }
                }
            };

            var requestContent = new ByteArrayContent(serialized)
            {
                Headers =
                {
                    ContentType = MediaTypeHeaderValue.Parse(contentType)
                }
            };
            using (var response = await httpClient.PostAsync(UriMeldungExtra14, requestContent))
            {
                var responseData = await response.EnsureSuccessStatusCode().Content.ReadAsByteArrayAsync();
                ExtraErrorType extraError;
                if (ExtraStandard.Extra14.ExtraUtilities.TryDeserializeError(responseData, out extraError))
                    throw new Exception(string.Join(Environment.NewLine, extraError.GetFlags().Select(x => x.AsExtraFlag()).Select(x => $"{x.Code} ({x.Weight}): {x.Text}")));

                return ExtraStandard.ExtraUtilities.Deserialize<TransportResponseType>(responseData);
            }
#else
            var userAgent = $"DatalineLohnabzug/27.0.0";
            var httpWebRequest = WebRequest.CreateHttp(UriMeldungExtra14);
            httpWebRequest.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            httpWebRequest.UserAgent = userAgent;
            httpWebRequest.ReadWriteTimeout = httpWebRequest.Timeout / 2;
            httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
            httpWebRequest.Method = WebRequestMethods.Http.Post;
            httpWebRequest.ContentType = contentType;
            httpWebRequest.PreAuthenticate = true;
            var clientCerts = new X509Certificate2Collection
            {
                new X509Certificate2(Absender.Zertifikat.RawData)
            };
            httpWebRequest.ClientCertificates = clientCerts;

            httpWebRequest.ContentLength = serialized.Length;
            using (var requestStream = httpWebRequest.GetRequestStream())
            {
                requestStream.Write(serialized, 0, serialized.Length);
            }

            using (var response = httpWebRequest.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    var temp = new MemoryStream();
                    Debug.Assert(responseStream != null, "responseStream != null");
                    responseStream.CopyTo(temp);

                    var responseData = temp.ToArray();
                    ExtraErrorType extraError;
                    if (ExtraStandard.Extra14.ExtraUtilities.TryDeserializeError(responseData, out extraError))
                        throw new Exception(string.Join(Environment.NewLine, extraError.GetFlags().Select(x => x.AsExtraFlag()).Select(x => $"{x.Code} ({x.Weight}): {x.Text}")));

                    return ExtraStandard.ExtraUtilities.Deserialize<TransportResponseType>(responseData);
                }
            }
#endif
        }

        private async Task<PackageRequestType> CreatePackage(int fileNumber, IReadOnlyCollection<IDatensatz> records, Guid packageRequestId, DateTime requestTimestamp)
        {
            var data = CreateData(records);
            var vosz = (VOSZ)records.First();
            var dsko = (DSKO04)records.Skip(1).First();

            var lines = data.Split('\n').Select(x => x.TrimEnd('\r')).Where(x => !string.IsNullOrEmpty(x)).ToList();
            var voszLine = lines.First();
            var dskoLine = lines.Skip(1).First();
            
            var validatorDsko = new KernpruefungDSKO();
            var dskoResult = validatorDsko.pruefe(dskoLine, voszLine);
            if (dskoResult.getReturnCode() >= 2)
                throw new Exception(string.Join(Environment.NewLine, dskoResult.getRueckgabeMeldungen()));

            var validatorData = new KernpruefungDSAS();
            foreach (var dataLine in lines.Skip(2).Take(lines.Count - 3))
            {
                var dataResult = validatorData.pruefe(dataLine, voszLine);
                if (dataResult.getReturnCode() >= 2)
                    throw new Exception(string.Join(Environment.NewLine, dataResult.getRueckgabeMeldungen()));
            }

            var receiverCert = (await ReceiverCertificates.Certificates).Single(x =>
            {
                var bnr = BnrExtractor.Extract(x.Subject);
                return bnr != null && bnr == dsko.BBNREP;
            });

            var extraEncodingId = "I1";
            var encoding = ExtraEncodingFactory.Standard.GetEncoding(extraEncodingId);

            var fileId = Pocos.UV.Info.DSAS.Dateikennung;
            var dataName = $"T{fileId}0{fileNumber:D6}";

            var inputData = encoding.GetBytes(data);
            var compression = new ExtraStandard.Compression.NoneCompressionHandler();

            var senderPkcsStore = new Pkcs12Store(new MemoryStream(Absender.Zertifikat.Export(X509ContentType.Pkcs12)), new char[0]);
            var receiverCertBc = new Org.BouncyCastle.X509.X509CertificateParser().ReadCertificate(receiverCert.RawData);
            var encryption = new Pkcs7EncryptionHandler(senderPkcsStore, receiverCertBc);

            var dataTransformsHelper = new ExtraDataTransformHandler(new[] { compression }, new[] { encryption });
            var transformResult = dataTransformsHelper.Transform(inputData, dataName, requestTimestamp, compression.AlgorithmId, encryption.AlgorithmId);
            var outputData = transformResult.Item1;

            var result = new PackageRequestType()
            {
                PackageHeader = new PackageRequestHeaderType()
                {
                    TestIndicator = ExtraTestIndicator.Process,
                    Sender = new SenderType()
                    {
                        SenderID = new ClassifiableIDType()
                        {
                            Value = vosz.BBNRAB
                        }
                    },
                    Receiver = new ReceiverType()
                    {
                        ReceiverID = new ClassifiableIDType()
                        {
                            Value = dsko.BBNREP,
                        }
                    },
                    RequestDetails = new RequestDetailsType()
                    {
                        RequestID = new ClassifiableIDType()
                        {
                            Value = packageRequestId.ToString("N")
                        },
                        TimeStamp = requestTimestamp,
                        TimeStampSpecified = true,
                        Procedure = Pocos.UV.Info.DSAS.Dateikennung,
                        DataType = ExtraDataType.Meldung,
                        Scenario = ExtraScenario.RequestWithAcknowledgement,
                    }
                },
                PackagePlugIns = new AnyPlugInContainerType()
                {
                    Any = new object[]
                    {
                        new ContactsType()
                        {
                            SenderContact = new[]
                            {
                                new ContactType()
                                {
                                    Endpoint = new[]
                                    {
                                        new EndpointType()
                                        {
                                            type = EndpointTypeType.SMTP,
                                            Value = Absender.Email
                                        }
                                    }
                                }
                            }
                        },
                        new DataTransformsType()
                        {
                            Compression = transformResult.Item2.OfType<CompressionType>().ToArray(),
                            Encryption = transformResult.Item2.OfType<EncryptionType>().ToArray()
                        },
                        new DataSourceType()
                        {
                            DataContainer = new DataContainerType()
                            {
                                created = requestTimestamp,
                                createdSpecified = true,
                                encoding = extraEncodingId,
                                name = dataName,
                                type = ExtraContainerType.File,
                            }
                        }
                    }
                },
                PackageBody = new PackageRequestBodyType()
                {
                    Items = new object[]
                    {
                        new DataType1()
                        {
                            Item = new Base64CharSequenceType()
                            {
                                Value = outputData
                            }
                        }
                    }
                }
            };

            return result;
        }

        private string CreateData(IEnumerable<IDatensatz> records)
        {
            var data = new StringWriter()
            {
                NewLine = "\r\n"
            };

            using (var writer = StreamFactory.CreateWriter("super-message", data))
            {
                foreach (var record in records)
                {
                    writer.Write(record);
                }
            }

            return data.ToString();
        }
    }
}
