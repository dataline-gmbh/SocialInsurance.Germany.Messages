using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

using BeanIO;

using ExtraStandard;
using ExtraStandard.Extra14;

using SocialInsurance.Germany.Messages.Pocos;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public class PackageInfo
    {
        private static readonly Lazy<StreamFactory> _streamFactory = new Lazy<StreamFactory>(() =>
        {
            var sf = StreamFactory.NewInstance();
            sf.Load(Mappings.Meldungen.LoadMeldungen());
            return sf;
        });

        public PackageInfo(PackageRequestType packageRequest, PackageResponseType packageResponse, ExtraDataTransformHandler extraDataTransformHandler)
        {
            RequestId = packageResponse.PackageHeader.RequestDetails.RequestID.Value;
            ResponseId = packageResponse.PackageHeader.ResponseDetails.ResponseID.Value;
            Flags = packageResponse.PackageHeader.ResponseDetails.GetReportFlags().Select(x => x.AsExtraFlag()).ToList();
            DataName = packageRequest.PackagePlugIns.Any.OfType<DataSourceType>().Single().DataContainer.name;
            var data = (Base64CharSequenceType) packageResponse.PackageBody.Items?.OfType<DataType1>().SingleOrDefault()?.Item;
            if (data != null)
            {
                var dataSource = packageResponse.PackagePlugIns?.Any.OfType<DataSourceType>().SingleOrDefault();
                var encoding = ExtraEncodingFactory.Standard.GetEncoding(dataSource?.DataContainer.encoding ?? "I1");

                var dataTransforms = packageResponse.PackagePlugIns?.Any.OfType<DataTransformsType>().SingleOrDefault();
                if (dataTransforms != null)
                {
                    var rawData = extraDataTransformHandler.ReverseTransform(data.Value, dataTransforms);
                    Data = encoding.GetString(rawData);
                }
                else
                {
                    Data = encoding.GetString(data.Value);
                }
            }
        }

        public PackageInfo(PackageResponseType packageResponse, AbsenderInformation absender, IReadOnlyDictionary<string, X509Certificate2> receiverCertificates)
        {
            RequestId = packageResponse.PackageHeader.RequestDetails.RequestID.Value;
            ResponseId = packageResponse.PackageHeader.ResponseDetails.ResponseID.Value;
            Flags = packageResponse.PackageHeader.ResponseDetails.GetReportFlags().Select(x => x.AsExtraFlag()).ToList();

            var dataSource = packageResponse.PackagePlugIns?.Any.OfType<DataSourceType>().SingleOrDefault();
            if (dataSource != null)
                DataName = dataSource.DataContainer.name;

            var data = (Base64CharSequenceType)packageResponse.PackageBody.Items?.OfType<DataType1>().SingleOrDefault()?.Item;
            if (data != null)
            {
                var encoding = ExtraEncodingFactory.Standard.GetEncoding(dataSource?.DataContainer.encoding ?? "I1");
                var dataTransforms = packageResponse.PackagePlugIns?.Any.OfType<DataTransformsType>().SingleOrDefault();
                if (dataTransforms != null)
                {
                    var receiverCert = receiverCertificates[packageResponse.PackageHeader.Receiver.ReceiverID.Value];
                    var extraDataTransformHandler = absender.CreateSupplyTransformHandler(receiverCert);
                    var rawData = extraDataTransformHandler.ReverseTransform(data.Value, dataTransforms);
                    Data = encoding.GetString(rawData);
                }
                else
                {
                    Data = encoding.GetString(data.Value);
                }
            }
        }

        public string RequestId { get; }
        public string ResponseId { get; }
        public string DataName { get; }
        public string Data { get; }
        public IReadOnlyCollection<ExtraFlag> Flags { get; }

        public IReadOnlyCollection<IDatensatz> Decode()
        {
            return LoadRecords(Data);
        }

        private static IReadOnlyCollection<IDatensatz> LoadRecords(string data)
        {
            // Aus String auslesen
            var result = new List<IDatensatz>();
            var input = new StringReader(data);
            using (var reader = _streamFactory.Value.CreateReader("super-message", input))
            {
                // Vorlaufsatz
                var record = (IDatensatz)reader.Read();
                do
                {
                    result.Add(record);
                    record = (IDatensatz)reader.Read();
                } while (reader.RecordName.StartsWith("VOSZ-"));

                // Kommunikationssatz
                if (reader.RecordName.StartsWith("DSKO-"))
                {
                    result.Add(record);
                    record = (IDatensatz)reader.Read();
                }

                // Nutzdaten
                while (!reader.RecordName.StartsWith("NCSZ-"))
                {
                    result.Add(record);
                    record = (IDatensatz)reader.Read();
                }

                // Nachlaufsatz
                do
                {
                    result.Add(record);
                    record = (IDatensatz)reader.Read();
                } while (reader.RecordName != null && reader.RecordName.StartsWith("NCSZ-"));
            }

            return result;
        }
    }
}
