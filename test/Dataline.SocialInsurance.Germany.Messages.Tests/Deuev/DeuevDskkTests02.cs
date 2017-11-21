using System;
using System.Collections.Generic;
using System.IO;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class DeuevDskkTests02 : TestBasis, IClassFixture<DefaultStreamFactoryFixture>
    {
        public DeuevDskkTests02(DefaultStreamFactoryFixture fixture)
            : base(fixture.Factory)
        {
        }

        /// <summary>
        /// Beginn der Versicherungs- und/oder Beitragspflicht
        /// wegen Aufnahme einer Beschäftigung (VSNR liegt vor)
        /// </summary>
        [Fact(DisplayName = "(De-)serialisierung von DSKK v02")]
        public void TestSagDskk02()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("TSAG0417");
            foreach (var record in deuevMessage.DSKK)
            {
                Assert.Null(record.MG);
                Assert.True(string.IsNullOrEmpty(record.BBNRAS));
                Assert.NotNull(record.DBMM);
                Assert.Null(record.DBMM.KENNZMOME);
            }
        }

        /// <summary>
        /// Erstellt die Meldedatei anhand von <paramref name="data"/> neu.
        /// </summary>
        /// <param name="data">Die Daten die zur Erstellung der Meldedatei benutzt werden sollen</param>
        /// <param name="streamName">Der Name des Streams der für die Erstellung der Meldedatei benutzt werden soll</param>
        /// <returns>Die Meldedatei</returns>
        private string GetStringFromMessage(DeuevMessageData data, string streamName)
        {
            var output = new StringWriter();
            using (var writer = StreamFactory.CreateWriter(streamName, output))
            {
                foreach (var record in data.VOSZ)
                    writer.Write(record);
                foreach (var record in data.DSKK)
                    writer.Write(record);
                foreach (var record in data.NCSZ)
                    writer.Write(record);
            }
            return output.ToString();
        }

        private DeuevMessageData GetMessageFromString(string input, string streamName)
        {
            var reader = StreamFactory.CreateReader(streamName, new StringReader(input));
            var deuevMessage = new DeuevMessageData();
            try
            {
                var streamObject = reader.Read();

                do
                {
                    var vosz = Assert.IsType<VOSZ>(streamObject);
                    deuevMessage.VOSZ.Add(vosz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName == "VOSZ" || reader.RecordName == "VOSZ-v01");

                while (reader.RecordName == "DSKK" || reader.RecordName == "DSKK-v02")
                {
                    var record = Assert.IsType<DSKK02>(streamObject);
                    deuevMessage.DSKK.Add(record);
                    streamObject = reader.Read();
                }

                do
                {
                    var ncsz = Assert.IsType<NCSZ>(streamObject);
                    deuevMessage.NCSZ.Add(ncsz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName != null && (reader.RecordName == "NCSZ-v01" || reader.RecordName == "NCSZ"));

                Assert.Null(reader.RecordName);
                Assert.Equal(deuevMessage.VOSZ.Count, deuevMessage.NCSZ.Count);

                return deuevMessage;
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Ruft die Meldedatei mit einem bestimmten Dateinamen aus dem Deuev-Ordner ab
        /// </summary>
        /// <param name="fileName">Dateiname der Meldedatei</param>
        /// <returns>Meldedatei als DeuevMessageData-Objekt</returns>
        private DeuevMessageData GetAndCheckDeuevMessageFromFile(string fileName)
        {
            var input = ReadData($"DSKK02.{fileName}");
            var inputLines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var deuevMessage = GetMessageFromString(input, "super-message");
            var output = GetStringFromMessage(deuevMessage, "super-message");
            var outputLines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.Equal(inputLines, outputLines);
            return deuevMessage;
        }

        /// <summary>
        /// Hilfsklasse der Meldedatei, die eine Meldedatei im Deuev-Format
        /// mit den Datensätzen als Objekte enthält
        /// </summary>
        private class DeuevMessageData
        {
            public DeuevMessageData()
            {
                VOSZ = new List<VOSZ>();
                DSKK = new List<DSKK02>();
                NCSZ = new List<NCSZ>();
            }

            public List<VOSZ> VOSZ { get; }

            public List<DSKK02> DSKK { get; }

            public List<NCSZ> NCSZ { get; }
        }
    }
}
