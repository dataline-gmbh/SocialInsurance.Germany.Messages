using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

using ExtraStandard;
using ExtraStandard.Extra14;
using ExtraStandard.GkvKomServer;
using ExtraStandard.GkvKomServer.Extra14;
using ExtraStandard.GkvKomServer.Validation.Extra14;
using ExtraStandard.Validation;

using RT;
using RT.CombByteOrder;

using SocialInsurance.Germany.Messages.Tests.Support;

using ExtraDataType = ExtraStandard.ExtraDataType;
using ExtraTransportProcedure = ExtraStandard.ExtraTransportProcedure;
using ExtraUtilities = ExtraStandard.ExtraUtilities;
using ValueType = ExtraStandard.Extra14.ValueType;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public class ServerConfirmation : ServerCommunication
    {
        private static readonly ICombProvider _combProvider = new CombProvider();

        private static readonly IGkvExtra14ValidatorFactory _validatorFactory = new GkvExtraValidatorFactory();

        protected override Uri RequestUrl { get; } = new Uri("https://verarbeitung.gkv-kommunikationsserver.de/quittung/extra14.quittung");


        public Task<ResponseInfo> Confirm(IReadOnlyCollection<string> packageIds)
        {
            return Confirm(packageIds, _combProvider.Create());
        }

        public async Task<ResponseInfo> Confirm(IReadOnlyCollection<string> packageIds, Guid requestId)
        {
            var query = CreateQuery(packageIds);
            var queryData = ExtraUtilities.Serialize(query);
            var queryValidator = _validatorFactory.Create(ExtraMessageType.AcknowledgeProcessingResultQuery, ExtraTransportDirection.Request, false);
            queryValidator.Validate(XDocument.Load(new MemoryStream(queryData)));

            var requestTimestamp = DateTime.Now;
            var handler = Absender.CreateConfirmTransformHandler();
            var transformResult = handler.Transform(queryData, "query.xml", requestTimestamp, ExtraCompression.None, ExtraEncryption.None);

            var request = new TransportRequestType()
            {
                version = SupportedVersionsType.Item14,
                profile = ExtraProfile.DeuevGkv14,
                TransportHeader = new TransportRequestHeaderType()
                {
                    TestIndicator = ExtraTestIndicator.NoTest,
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
                        Procedure = ExtraTransportProcedure.DeliveryServer,
                        DataType = ExtraStandard.GkvKomServer.ExtraDataType.Quittung,
                        Scenario = ExtraScenario.RequestWithAcknowledgement
                    }
                },
                TransportPlugIns = new AnyPlugInContainerType()
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
                        }
                    }
                },
                TransportBody = new TransportRequestBodyType()
                {
                    Items = new object[]
                    {
                        new DataType1()
                        {
                            Item = new Base64CharSequenceType()
                            {
                                Value = transformResult.Item1
                            }
                        }
                    }
                }
            };

            var response = await Execute(request);
            var errors = string.Join(Environment.NewLine, response.GetErrors().Select(x => $"{x.Code} ({x.weight}): {x.Text}"));
            if (!string.IsNullOrEmpty(errors))
                throw new Exception(errors);

            var receiverCertificates =
                (from cert in (await ReceiverCertificates.Certificates.Value)
                 let bnrInfo = BnrInfo.Extract(cert.Subject)
                 where bnrInfo != null
                 select new { bnrInfo.Betriebsnummer, Zertifikat = cert })
                    .ToDictionary(x => x.Betriebsnummer, x => x.Zertifikat);
            return new ResponseInfo(
                response,
                response.TransportBody.Items?.Cast<PackageResponseType>().Select(x => new PackageInfo(x, Absender, receiverCertificates)).ToArray() ?? new PackageInfo[0]);
        }

        protected override IGkvExtra14Validator CreateValidator()
        {
            return _validatorFactory.Create(ExtraMessageType.AcknowledgeProcessingResult, ExtraTransportDirection.Request, false);
        }

        private ConfirmationOfReceiptType CreateQuery(IReadOnlyCollection<string> packageIds)
        {
            return new ConfirmationOfReceiptType()
            {
                version = ConfirmationOfReceiptTypeVersion.Item13,
                PropertySet = new PropertySetType()
                {
                    name = ExtraPropertySetName.ResponseID,
                    Value = packageIds.Select(x => new ValueType() {Value = x}).ToArray(),
                },
            };
        }
    }
}
