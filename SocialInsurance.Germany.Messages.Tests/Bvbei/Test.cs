using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialInsurance.Germany.Messages.Pocos;
using Xunit;
using System.IO;

namespace SocialInsurance.Germany.Messages.Tests.Bvbei
{
    public class Test : TestBasis
    {


        [Fact(DisplayName = "TestXmlTotalFieldLength")]
        public void TestXmlTotalFieldLength()
        {
            var xmlTest = System.Xml.Linq.XDocument.Load(LoadData("test.xml"));
            int length = 0;
            int count = 0;
            foreach (var eleField in xmlTest.Root.Element(xmlTest.Root.GetDefaultNamespace() + "template").Elements(xmlTest.Root.GetDefaultNamespace() + "field"))
            {
                count++;
                length += Convert.ToInt32(eleField.Attribute("length").Value);
            }

        }

        /// <summary>
        /// DSBE
        /// </summary>
        [Fact(DisplayName = "TestDSBE")]
        public void TestDSBE()
        {
            var deuevMessage = GetMessageFromFile("ebea0023.a22", "dsbe-bvbei");
            Assert.True(deuevMessage.DSBE.Count() > 0);
        }

        /// <summary>
        /// Ruft die Meldedatei mit einem bestimmten Dateinamen aus dem Deuev-Ordner ab
        /// </summary>
        /// <param name="fileName">
        /// Dateiname der Meldedatei
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
                var vosz = Assert.IsType<VOSZ>(streamObject);
                deuevMessage.VOSZ = new List<VOSZ> { vosz };
                writer.Write(vosz);
                streamObject = reader.Read();
                if (streamObject is VOSZ)
                {
                    deuevMessage.VOSZ.Add(streamObject as VOSZ);
                    writer.Write(vosz);
                    streamObject = reader.Read();
                }

                var dsko = Assert.IsType<DSKO>(streamObject);
                deuevMessage.DSKO = dsko;
                writer.Write(dsko);
                streamObject = reader.Read();
                var DSBE = Assert.IsType<DSBE>(streamObject);
                deuevMessage.DSBE = new List<DSBE> { DSBE };
                writer.Write(DSBE);
                while (true)
                {
                    streamObject = reader.Read();
                    if (streamObject is NCSZ)
                    {
                        writer.Write(streamObject);
                        deuevMessage.NCSZ = new List<NCSZ> { streamObject as NCSZ };
                        streamObject = reader.Read();
                        if (streamObject is NCSZ)
                        {
                            deuevMessage.NCSZ.Add(streamObject as NCSZ);
                            writer.Write(streamObject);
                        }

                        break;
                    }
                    else
                    {
                        Assert.IsType<DSBE>(streamObject);
                        deuevMessage.DSBE.Add(streamObject as DSBE);
                    }

                    writer.Write(streamObject);
                }

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
            public List<VOSZ> VOSZ { get; set; }

            public DSKO DSKO { get; set; }

            public List<DSBE> DSBE { get; set; }

            public List<NCSZ> NCSZ { get; set; }
        }
    }
}
