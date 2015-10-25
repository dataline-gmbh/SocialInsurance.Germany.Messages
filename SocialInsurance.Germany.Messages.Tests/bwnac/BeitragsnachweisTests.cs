using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.BNA;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.bwnac
{
    public class BeitragsnachweisTests : TestBasis
    {
        /// <summary>
        /// BW02
        /// </summary>
        [Fact(DisplayName = "TestBW02")]
        public void TestBW02()
        {
            var deuevMessage = GetMessageFromFile("ebna0091.a35", "bw02-bwnac-v11");
            Assert.True(deuevMessage.BW02.Count > 0);
        }

        /// <summary>
        /// Ruft die Meldedatei mit einem bestimmten Dateinamen aus dem Deuev-Ordner ab
        /// </summary>
        /// <param name="fileName">
        /// Dateiname der Meldedatei
        /// </param>
        /// <param name="name">
        /// Name in der Meldungen.xml
        /// </param>
        /// <returns>
        /// Meldedatei als DeuevMessageData-Objekt
        /// </returns>
        private BwnaMessageData GetMessageFromFile(string fileName, string name)
        {
            var input = ReadData(fileName);
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter(name, output);
            var reader = StreamFactory.CreateReader(name, new StringReader(input));
            var deuevMessage = new BwnaMessageData();
            try
            {
                var streamObject = reader.Read();

                do
                {
                    var vosz = Assert.IsType<VOSZ06>(streamObject);
                    deuevMessage.VOSZ.Add(vosz);
                    writer.Write(vosz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName == "VOSZ");

                var dsko = Assert.IsType<DSKO02>(streamObject);
                deuevMessage.DSKO = dsko;
                writer.Write(dsko);
                streamObject = reader.Read();

                while (reader.RecordName == "BW02")
                {
                    var record = Assert.IsType<BW0211>(streamObject);
                    deuevMessage.BW02.Add(record);
                    writer.Write(record);
                    streamObject = reader.Read();
                }

                do
                {
                    var ncsz = Assert.IsType<NCSZ06>(streamObject);
                    writer.Write(streamObject);
                    deuevMessage.NCSZ.Add(ncsz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName != null && reader.RecordName == "NCSZ");

                Assert.Null(reader.RecordName);
                Assert.Equal(deuevMessage.VOSZ.Count, deuevMessage.NCSZ.Count);

                writer.Close();
                string output2 = output.ToString();
                Assert.Equal(input, output2);
                return deuevMessage;
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Hilfsklasse der Meldedatei, die eine Meldedatei im Deuev-Format
        /// mit den Datensätzen als Objekte enthält
        /// </summary>
        private class BwnaMessageData
        {
            public BwnaMessageData()
            {
                VOSZ = new List<VOSZ06>();
                BW02 = new List<BW0211>();
                NCSZ = new List<NCSZ06>();
            }

            public List<VOSZ06> VOSZ { get; set; }

            public DSKO02 DSKO { get; set; }

            public List<BW0211> BW02 { get; set; }

            public List<NCSZ06> NCSZ { get; set; }
        }
    }
}
