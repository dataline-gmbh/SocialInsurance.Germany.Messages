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
            var data = ReadData("ebna0091.a35");
            var deuevMessage = GetMessageFromString(data, "bw02-bwnac-v11");
            Assert.True(deuevMessage.BW02.Count > 0);
            Assert.Equal(data, GetStringFromMessage(deuevMessage, "bw02-bwnac-v11"));
        }

        [Fact]
        public void TestGenericEnvelopeRequest()
        {
            var data = ReadData("ebna0091.a35");
            var deuevMessage = GetMessageFromString(data, "envelope-request-generic");
            Assert.Equal(0, deuevMessage.BW02.Count);
            Assert.Equal(1, deuevMessage.VOSZ.Count);
            Assert.Equal(1, deuevMessage.NCSZ.Count);
        }

        [Fact(Skip = "Keine Kundenunabhängigen Testdaten vorhanden")]
        public void TestGenericEnvelopeResponse()
        {
            var data = File.ReadAllText(@"D:\temp\arbeit\meldungen\ebna02457-response.a18");
            var deuevMessage = GetMessageFromString(data, "super-message");
            Assert.Equal(0, deuevMessage.BW02.Count);
            Assert.Equal(2, deuevMessage.VOSZ.Count);
            Assert.Equal(2, deuevMessage.NCSZ.Count);
        }

        /// <summary>
        /// Erstellt die Meldedatei anhand von <paramref name="data"/> neu.
        /// </summary>
        /// <param name="data">Die Daten die zur Erstellung der Meldedatei benutzt werden sollen</param>
        /// <param name="streamName">Der Name des Streams der für die Erstellung der Meldedatei benutzt werden soll</param>
        /// <returns>Die Meldedatei</returns>
        private string GetStringFromMessage(BwnaMessageData data, string streamName)
        {
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter(streamName, output);
            foreach (var record in data.VOSZ)
                writer.Write(record);
            writer.Write(data.DSKO);
            foreach (var record in data.BW02)
                writer.Write(record);
            foreach (var record in data.NCSZ)
                writer.Write(record);
            writer.Close();
            return output.ToString();
        }

        /// <summary>
        /// Ruft die Meldedatei mit einem bestimmten Dateinamen aus dem Deuev-Ordner ab
        /// </summary>
        /// <param name="input">Die Meldedatei</param>
        /// <param name="name">Name in der Meldungen.xml</param>
        /// <returns>Meldedatei als DeuevMessageData-Objekt</returns>
        private BwnaMessageData GetMessageFromString(string input, string name)
        {
            var reader = StreamFactory.CreateReader(name, new StringReader(input));
            var deuevMessage = new BwnaMessageData();
            try
            {
                var streamObject = reader.Read();

                do
                {
                    var vosz = Assert.IsType<VOSZ06>(streamObject);
                    deuevMessage.VOSZ.Add(vosz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName == "VOSZ" || reader.RecordName == "VOSZ-BNA-v06");

                var dsko = Assert.IsType<DSKO02>(streamObject);
                deuevMessage.DSKO = dsko;
                streamObject = reader.Read();

                while (reader.RecordName == "BW02" || reader.RecordName == "BW02-v11")
                {
                    var record = Assert.IsType<BW0211>(streamObject);
                    deuevMessage.BW02.Add(record);
                    streamObject = reader.Read();
                }

                do
                {
                    var ncsz = Assert.IsType<NCSZ06>(streamObject);
                    deuevMessage.NCSZ.Add(ncsz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName != null && (reader.RecordName == "NCSZ" || reader.RecordName == "NCSZ-BNA-v06"));

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
