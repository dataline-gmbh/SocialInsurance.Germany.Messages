extern alias uv10;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using BeanIO;

using de.werum.uvkp.plausi;

using ExtraStandard;
using ExtraStandard.Extra14;
using ExtraStandard.GkvKomServer;
using ExtraStandard.GkvKomServer.Extra14;
using ExtraStandard.GkvKomServer.Validation.Extra14;
using ExtraStandard.Validation;

using RT;
using RT.CombByteOrder;

using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.UV;
using SocialInsurance.Germany.Messages.Tests.Support;

using ExtraDataType = ExtraStandard.GkvKomServer.ExtraDataType;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public class ServerSupply : ServerCommunication
    {
        private static readonly ICombProvider _combProvider = new CombProvider();

        private static readonly IGkvExtra14ValidatorFactory _validatorFactory = new GkvExtraValidatorFactory();

        private static readonly Lazy<StreamFactory> _streamFactory = new Lazy<StreamFactory>(() =>
        {
            var sf = StreamFactory.NewInstance();
            sf.Load(Mappings.Meldungen.LoadMeldungen());
            return sf;
        });

        protected override Uri RequestUrl { get; } = new Uri("https://verarbeitung.gkv-kommunikationsserver.de/meldung/extra14.meldung");

        private static StreamFactory StreamFactory => _streamFactory.Value;

        public Task<ResponseInfo> SupplyData(int fileNumber, IReadOnlyCollection<IDatensatz> records, IVerfahrenkennzeichen verfahrenkennzeichen)
        {
            return SupplyData(fileNumber, records, verfahrenkennzeichen, _combProvider.Create());
        }

        public async Task<ResponseInfo> SupplyData(int fileNumber, IReadOnlyCollection<IDatensatz> records, IVerfahrenkennzeichen verfahrenkennzeichen, Guid requestId)
        {
            var requestTimestamp = DateTime.Now;

            var dsko = records.OfType<DSKO04>().Single();
            var receiverCert = (await ReceiverCertificates.Certificates).Single(x =>
            {
                var bnrInfo = BnrInfo.Extract(x.Subject);
                return bnrInfo != null && bnrInfo.Betriebsnummer == dsko.BBNREP;
            });

            var packages = new List<PackageRequestType>
            {
                CreatePackage(fileNumber, records, _combProvider.Create(), requestTimestamp, receiverCert, verfahrenkennzeichen)
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

            var requestPackages = packages.ToDictionary(x => x.PackageHeader.RequestDetails.RequestID.Value);
            var extraDataTransformHandler = Absender.CreateSupplyTransformHandler(receiverCert);
            return new ResponseInfo(
                response,
                response.TransportBody.Items.Cast<PackageResponseType>().Select(x => new PackageInfo(requestPackages[x.PackageHeader.RequestDetails.RequestID.Value], x, extraDataTransformHandler)).ToArray());
        }

        protected override IGkvExtra14Validator CreateValidator()
        {
            return _validatorFactory.Create(ExtraMessageType.SupplyData, ExtraTransportDirection.Request, false);
        }

        private PackageRequestType CreatePackage(int fileNumber, IReadOnlyCollection<IDatensatz> records, Guid packageRequestId, DateTime requestTimestamp, X509Certificate2 receiverCert, IVerfahrenkennzeichen verfahrenkennzeichen)
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

            if (Info.DSAS.Merkmal == verfahrenkennzeichen.Merkmal)
            {
                var validatorData = new KernpruefungDSAS();
                foreach (var dataLine in lines.Skip(2).Take(lines.Count - 3))
                {
                    var dataResult = validatorData.pruefe(dataLine, voszLine);
                    if (dataResult.getReturnCode() >= 2)
                        throw new Exception(string.Join(Environment.NewLine, dataResult.getRueckgabeMeldungen()));
                }
            }
            else if (Info.DSLN.Merkmal == verfahrenkennzeichen.Merkmal)
            {
                var validatorData = new KernpruefungDSLN();
                foreach (var dataLine in lines.Skip(2).Take(lines.Count - 3))
                {
                    var dataResult = validatorData.pruefe(dataLine, voszLine);
                    if (dataResult.getReturnCode() >= 2)
                        throw new Exception(string.Join(Environment.NewLine, dataResult.getRueckgabeMeldungen()));
                }
            }
            else
            {
                throw new NotSupportedException();
            }

            var extraEncodingId = "I1";
            var encoding = ExtraEncodingFactory.Standard.GetEncoding(extraEncodingId);

            var fileId = verfahrenkennzeichen.Dateikennung;
            var dataName = $"T{fileId}0{fileNumber:D6}";

            var inputData = encoding.GetBytes(data);
            var dataTransformsHelper = Absender.CreateSupplyTransformHandler(receiverCert);
            var transformResult = dataTransformsHelper.Transform(inputData, dataName, requestTimestamp, ExtraCompression.None, ExtraEncryption.Pkcs7);
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
                        Procedure = verfahrenkennzeichen.Dateikennung,
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

