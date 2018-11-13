using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using NodaTime;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Bvbei
{
    public class BeitragserhebungTests : TestBasis, IClassFixture<BvbeiStreamFactoryFixture>
    {
        public BeitragserhebungTests(BvbeiStreamFactoryFixture fixture)
            : base(fixture.Factory)
        {
        }

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

        [Fact]
        public void TestDSBE04()
        {
            string input =
                "DSBE04  01BVBEI11111110       31593956       2019070112300100000000 1      1       1                               " +
                    "00000000000000000000Fleischereifachbetrieb        Hans Wurst                                                  " +
                    "Mettstraße                       1        12345Fleischwolfingen                  1                   11111110" +
                    "                      31593956       123123123        201907201907G+31+000010000+000001000+000010001+00001000JJ" +
                    "  DBMI1                   Mustermann                    Max                                                    " +
                    "                                   M19900101DBHB+00010000";

            DSBE04 dsbe;

            // Test Lesen
            using (var inputReader = new StringReader(input))
            using (var reader = StreamFactory.CreateReader("DSBE-v04", inputReader))
            {
                dsbe = (DSBE04)reader.Read();
            }

            Assert.NotNull(dsbe);
            Assert.Equal("DSBE", dsbe.KE);
            Assert.Equal(4, dsbe.VERNRDS);
            Assert.Equal(1, dsbe.VERNRKP);
            Assert.Equal("BVBEI", dsbe.VF);
            Assert.Equal("11111110", dsbe.ABSN);
            Assert.Equal("31593956", dsbe.EPNR);
            Assert.Equal(new DateTime(2019, 7, 1, 12, 30, 1), dsbe.ED);
            Assert.Equal("1", dsbe.PRODID);
            Assert.Equal("1", dsbe.MODID);
            Assert.Equal("1", dsbe.DSID);
            Assert.Equal("Fleischereifachbetrieb", dsbe.NA1);
            Assert.Equal("Hans Wurst", dsbe.NA2);
            Assert.Equal("Mettstraße", dsbe.STR);
            Assert.Equal("1", dsbe.HNR);
            Assert.Equal(12345, dsbe.PLZ);
            Assert.Equal("Fleischwolfingen", dsbe.ORT);
            Assert.Equal("1", dsbe.AZVU);
            Assert.Equal("11111110", dsbe.BBNRVU);
            Assert.Equal("31593956", dsbe.BBNRBV);
            Assert.Equal("123123123", dsbe.MNRBV);
            Assert.Equal(new DateTime(2019, 7, 1), dsbe.ABMO);
            Assert.Equal(new DateTime(2019, 7, 1), dsbe.VEMO);
            Assert.Equal("G", dsbe.MEVO);
            Assert.Equal("+", dsbe.VZSVTG);
            Assert.Equal(31, dsbe.SVTG);
            Assert.Equal("+", dsbe.VZLGA);
            Assert.Equal(1000, dsbe.LGA);
            Assert.False(dsbe.LGAF);
            Assert.Equal("+", dsbe.VZEGA);
            Assert.Equal(1000, dsbe.EGA);
            Assert.Equal("+", dsbe.VZEGAB);
            Assert.Equal(1000, dsbe.EGAB);
            Assert.Equal(1, dsbe.BZ);
            Assert.Equal("+", dsbe.VZPB);
            Assert.Equal(1000, dsbe.PB);
            Assert.NotNull(dsbe.DBMI);
            Assert.Equal("DBMI", dsbe.DBMI.KE);
            Assert.Equal("1", dsbe.DBMI.KEAN);
            Assert.Equal("Mustermann", dsbe.DBMI.FMNA);
            Assert.Equal("Max", dsbe.DBMI.VONA);
            Assert.Equal("M", dsbe.DBMI.GE);
            Assert.Equal(new LocalDate(1990, 1, 1), dsbe.DBMI.GBDT);
            Assert.NotNull(dsbe.DBHB);
            Assert.Equal("DBHB", dsbe.DBHB.KE);
            Assert.Equal("+", dsbe.DBHB.VZHB);
            Assert.Equal(10000, dsbe.DBHB.HB);

            // Test Schreiben
            using (var writer = new StringWriter())
            {
                var sw = StreamFactory.CreateWriter("super-message", writer);

                sw.Write(dsbe);

                writer.Flush();

                Assert.Equal(input, writer.GetStringBuilder().ToString().Trim());
            }
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

            public List<VOSZ> VOSZ { get; }

            public DSKO02 DSKO { get; set; }

            public List<DSBE01> DSBEv01 { get; }

            public List<NCSZ> NCSZ { get; }
        }
    }
}
