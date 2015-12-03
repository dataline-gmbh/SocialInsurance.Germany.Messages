using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.AAG;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.aager
{
    public class AagTests : TestBasis
    {
        /// <summary>
        /// DSER
        /// </summary>
        [Fact(DisplayName = "TestDSER v02")]
        public void TestDSER02()
        {
            var deuevMessage = GetMessageFromFile("eaag0004.a15", "dser-agger-v02");
            Assert.True(deuevMessage.DSER02.Count > 0);
        }

        /// <summary>
        /// DSER
        /// </summary>
        [Theory(DisplayName = "TestDSER v03")]
        [InlineData("eaag0001.a15", "super-message")]
        [InlineData("eaag0007.a15", "dser-aager-v02")]
        [InlineData("eaag0007.a15", "super-message")]
        public void TestDSER03(string fileName, string streamName)
        {
            var deuevMessage = GetMessageFromFile(fileName, streamName);
            Assert.True(deuevMessage.DSER03.Count > 0);
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
            var input = LoadData(fileName).ReadToEnd();
            var output = new StringWriter();
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

                while (reader.RecordName == "DSER" || reader.RecordName == "DSER-v02" || reader.RecordName == "DSER-v03")
                {
                    switch (name)
                    {
                        case "dser-agger-v02":
                            {
                                var record = Assert.IsType<DSER02>(streamObject);
                                deuevMessage.DSER02.Add(record);
                                writer.Write(record);
                            }
                            break;
                        case "dser-agger-v03":
                            {
                                var record = Assert.IsType<DSER03>(streamObject);
                                deuevMessage.DSER03.Add(record);
                                writer.Write(record);
                            }
                            break;
                        case "super-message":
                            switch (reader.RecordName)
                            {
                                case "DSER-v02":
                                    {
                                        var record = Assert.IsType<DSER02>(streamObject);
                                        deuevMessage.DSER02.Add(record);
                                        writer.Write(record);
                                    }
                                    break;
                                case "DSER-v03":
                                    {
                                        var record = Assert.IsType<DSER03>(streamObject);
                                        deuevMessage.DSER03.Add(record);
                                        writer.Write(record);
                                    }
                                    break;
                                default:
                                    throw new InvalidOperationException(string.Format("Unsupported record {0}", reader.RecordName));
                            }
                            break;
                        default:
                            throw new InvalidOperationException(string.Format("Unsupported stream {0}", name));
                    }
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
        /// Hilfsklasse der Meldedatei, die eine Meldedatei im Deuev-Format
        /// mit den Datensätzen als Objekte enthält
        /// </summary>
        private class BwnaMessageData
        {
            public BwnaMessageData()
            {
                VOSZ = new List<VOSZ>();
                DSER02 = new List<DSER02>();
                DSER03 = new List<DSER03>();
                NCSZ = new List<NCSZ>();
            }

            public List<VOSZ> VOSZ { get; set; }

            public DSKO02 DSKO { get; set; }

            public List<DSER02> DSER02 { get; set; }

            public List<DSER03> DSER03 { get; set; }

            public List<NCSZ> NCSZ { get; set; }
        }
    }
}
