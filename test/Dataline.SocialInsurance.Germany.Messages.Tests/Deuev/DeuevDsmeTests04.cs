using SocialInsurance.Germany.Messages.Pocos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class DeuevDsmeTests04 : TestBasis, IClassFixture<DeuevStreamFactoryFixture>
    {
        public DeuevDsmeTests04(DeuevStreamFactoryFixture fixture) : base(fixture.Factory)
        {
        }

        [Fact]
        public void TestReadDSBD02()
        {
            string input = @"DSBDBTRAG87996713       05071449       02201712201213022573530077317300                  37611906       11     Test                                                                                      11011     Musterhausen                      Musterstrasse                    1                            A               NMax Mustermann                011899988199                                                                                                                                          31754826       123456712345678NN     ";

            using (var reader = new StringReader(input))
            {
                var sr = StreamFactory.CreateReader("dsbd-v02", reader);

                var obj = sr.Read();

                Assert.IsType<DSBD02>(obj);
                var dsbd = (DSBD02)obj;

                Assert.Equal("87996713", dsbd.ABSN);
                Assert.Equal("Max Mustermann", dsbd.NAMEAP);
            }
        }

        [Fact]
        public void TestDSBD03()
        {
            string input =
                "DSBDBTRAG02327996       49887904       03201907011200000000000063958351       20190701                         " +
                    "Test                                                                                      11011     Musterhausen                      " +
                    "Teststrasse                      1                                            MMax Mustermann                030" +
                    "1234567                                                                                                                        " +
                    "f168a156fa5342e9a07fef5b239f3a40NJN123456712345678JN     DBPAMax Mustermann                                                                            " +
                "12345     Musterhausen                      Teststrasse                      1                                    \r\n";

            DSBD03 dsbd;

            // Test Lesen
            using (var reader = new StringReader(input))
            {
                var sr = StreamFactory.CreateReader("dsbd-v03", reader);

                var obj = sr.Read();

                Assert.IsType<DSBD03>(obj);
                dsbd = (DSBD03)obj;

                Assert.Equal("DSBD", dsbd.KE);
                Assert.Equal("BTRAG", dsbd.VF);
                Assert.Equal("02327996", dsbd.ABSN);
                Assert.Equal("49887904", dsbd.EPNR);
                Assert.Equal(3, dsbd.VERNR);
                Assert.Equal(new DateTime(2019, 7, 1, 12, 0, 0), dsbd.ED);
                Assert.Equal(FehlerKennzeichen.Fehlerfrei, dsbd.FEKZ);
                Assert.Equal(0, dsbd.FEAN);
                Assert.Equal("63958351", dsbd.BBNRBB);
                Assert.Null(dsbd.BBNRAS);
                Assert.Null(dsbd.GD);
                Assert.Equal(new DateTime(2019, 7, 1), dsbd.DTEREIGNIS);
                Assert.Null(dsbd.WUKL);
                Assert.Equal("Test", dsbd.NAMEBB1);
                Assert.Null(dsbd.NAMEBB2);
                Assert.Null(dsbd.NAMEBB3);
                Assert.Equal("11011", dsbd.PLZBB);
                Assert.Equal("Musterhausen", dsbd.ORTBB);
                Assert.Equal("Teststrasse", dsbd.STRBB);
                Assert.Equal("1", dsbd.HNRBB);
                Assert.Null(dsbd.KENNZEND);
                Assert.Equal("M", dsbd.ANRAP);
                Assert.Equal("Max Mustermann", dsbd.NAMEAP);
                Assert.Equal("0301234567", dsbd.TELAP);
                Assert.Null(dsbd.FAXAP);
                Assert.Null(dsbd.EMAILAP);
                Assert.Null(dsbd.AZVU);
                Assert.Equal("f168a156fa5342e9a07fef5b239f3a40", dsbd.DATENSATZID);
                Assert.False(dsbd.KENNZNAME);
                Assert.True(dsbd.KENNZANSCHRIFT);
                Assert.False(dsbd.KENNZANSPRECH);
                Assert.Equal(1234567, dsbd.PRODID);
                Assert.Equal(12345678, dsbd.MODID);
                Assert.True(dsbd.MMPA);
                Assert.False(dsbd.MMTN);
                Assert.Null(dsbd.DBTN);
                Assert.NotNull(dsbd.DBPA);
                Assert.Equal("DBPA", dsbd.DBPA.KE);
                Assert.Equal("Max Mustermann", dsbd.DBPA.NAMEPA1);
                Assert.Null(dsbd.DBPA.NAMEPA2);
                Assert.Null(dsbd.DBPA.NAMEPA3);
                Assert.Equal("12345", dsbd.DBPA.PLZPA);
                Assert.Equal("Musterhausen", dsbd.DBPA.ORTPA);
                Assert.Equal("Teststrasse", dsbd.DBPA.STRPA);
                Assert.Equal("1", dsbd.DBPA.HNRPA);
                Assert.Null(dsbd.DBPA.PLZPO);
                Assert.Null(dsbd.DBPA.POSTFACH);
                Assert.Null(dsbd.DBPA.LDKZPA);
                Assert.Null(dsbd.DBPA.KENNZLPA);
            }

            // Test Schreiben
            using (var writer = new StringWriter())
            {
                var sw = StreamFactory.CreateWriter("dsbd-v03", writer);

                sw.Write(dsbd);

                writer.Flush();

                Assert.Equal(input, writer.GetStringBuilder().ToString());
            }
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
                } while (reader.RecordName == "VOSZ" || reader.RecordName == "VOSZ-v01");

                var dsko = Assert.IsType<DSKO04>(streamObject);
                deuevMessage.DSKO = dsko;
                streamObject = reader.Read();

                while (reader.RecordName == "DSME" || reader.RecordName == "DSME-v04")
                {
                    var record = Assert.IsType<DSME04>(streamObject);
                    deuevMessage.DSME.Add(record);
                    streamObject = reader.Read();
                }

                do
                {
                    var ncsz = Assert.IsType<NCSZ>(streamObject);
                    deuevMessage.NCSZ.Add(ncsz);
                    streamObject = reader.Read();
                } while (reader.RecordName != null && (reader.RecordName == "NCSZ-v01" || reader.RecordName == "NCSZ"));

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
        private class DeuevMessageData
        {
            public DeuevMessageData()
            {
                VOSZ = new List<VOSZ>();
                DSME = new List<DSME04>();
                NCSZ = new List<NCSZ>();
            }

            public List<VOSZ> VOSZ { get; }

            public DSKO04 DSKO { get; set; }

            public List<DSME04> DSME { get; }

            public List<NCSZ> NCSZ { get; }
        }
    }
}
