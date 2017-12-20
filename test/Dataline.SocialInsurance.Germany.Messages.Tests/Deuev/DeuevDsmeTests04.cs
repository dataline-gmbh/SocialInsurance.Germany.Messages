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
