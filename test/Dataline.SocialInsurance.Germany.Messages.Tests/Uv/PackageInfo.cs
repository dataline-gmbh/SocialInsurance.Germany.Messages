using System;
using System.Collections.Generic;
using System.IO;

using BeanIO;

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

        public PackageInfo(string packageId, string data)
        {
            PackageId = packageId;
            Data = data;
        }

        public string PackageId { get; }
        public string Data { get; }

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
