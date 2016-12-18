using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialInsurance.Germany.Messages.Pocos;
using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Bvbei
{
    public class BeitragserhebungTests : TestBasis
    {
        /// <summary>
        /// DSBE
        /// </summary>
        [Theory(DisplayName = "TestDSBE")]
        [InlineData("dsbe-bvbei-v01")]
        [InlineData("super-message")]
        public void TestDSBE(string streamName)
        {
            var deuevMessage = GetMessageFromFile("ebea0023.a22", streamName);
            Assert.True(deuevMessage.DSBEv01.Count > 0);
            var dsbe = deuevMessage.DSBEv01.Single();
            Assert.Equal("Hauptstraße 23", dsbe.STR);
        }

        /// <summary>
        /// Ruft die Meldedatei mit einem bestimmten Dateinamen aus dem Deuev-Ordner ab
        /// </summary>
        /// <param name="input">Die Meldedatei</param>
        /// <param name="name">Name in der Meldungen.xml</param>
        /// <returns>Meldedatei als DeuevMessageData-Objekt</returns>
        private BwnaMessageData GetMessageFromString(string input, string name)
        {
            var output = new StringWriter() {NewLine = "\n"};
            var writer = StreamFactory.CreateWriter(name, output);
            var reader = StreamFactory.CreateReader(name, new StringReader(input));
            var deuevMessage = new BwnaMessageData();
            try
            {
                var streamObject = reader.Read();

                do
                {
                    var vosz = Assert.IsType<VOSZ>(streamObject);
                    deuevMessage.VOSZ.Add(vosz);
                    writer.Write(vosz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName == "VOSZ" || reader.RecordName == "VOSZ-v01");

                var dsko = Assert.IsType<DSKO02>(streamObject);
                deuevMessage.DSKO = dsko;
                writer.Write(dsko);
                streamObject = reader.Read();

                while (reader.RecordName == "DSBE" || reader.RecordName == "DSBE-v01")
                {
                    var record = Assert.IsType<DSBE01>(streamObject);
                    deuevMessage.DSBEv01.Add(record);
                    writer.Write(record);
                    streamObject = reader.Read();
                }

                do
                {
                    var ncsz = Assert.IsType<NCSZ>(streamObject);
                    writer.Write(streamObject);
                    deuevMessage.NCSZ.Add(ncsz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName != null && (reader.RecordName == "NCSZ" || reader.RecordName == "NCSZ-v01"));

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
            return GetMessageFromString(input, name);
        }

        /// <summary>
        /// Hilfsklasse der Meldedatei, die eine Meldedatei im Deuev-Format
        /// mit den Datensätzen als Objekte enthält
        /// </summary>
        private class BwnaMessageData
        {
            public BwnaMessageData()
            {
                VOSZ = new List<VOSZ>();
                DSBEv01 = new List<DSBE01>();
                NCSZ = new List<NCSZ>();
            }

            public List<VOSZ> VOSZ { get; set; }

            public DSKO02 DSKO { get; set; }

            public List<DSBE01> DSBEv01 { get; set; }

            public List<NCSZ> NCSZ { get; set; }
        }
    }
}
