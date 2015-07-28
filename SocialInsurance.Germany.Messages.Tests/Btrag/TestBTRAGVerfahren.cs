using System;
using System.Collections.Generic;
using System.IO;
using SocialInsurance.Germany.Messages.Pocos;
using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Btrag
{
    public class TestBTRAGVerfahren : TestBasis
    {
        [Fact]
        public void TestBTRAG()
        {
            GetAndCheckBtragMessageFromFile("btrag.dat");
        }

        private BtragMessageData GetAndCheckBtragMessageFromFile(string fileName)
        {
            var input = LoadData(fileName).ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("btrag", output);
            var reader = StreamFactory.CreateReader("btrag", new StringReader(input));
            var deuevMessage = new BtragMessageData();
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
                var dsbd = Assert.IsType<DSBD>(streamObject);
                deuevMessage.DSBD = new List<DSBD> { dsbd };
                writer.Write(dsbd);
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
                        Assert.IsType<DSBD>(streamObject);
                        deuevMessage.DSBD.Add(streamObject as DSBD);
                    }

                    writer.Write(streamObject);
                }

                writer.Close();
                Assert.Equal(input, output.ToString());
                return deuevMessage;
            }
            finally
            {
                reader.Close();
            }
        }

        private class BtragMessageData
        {
            public List<VOSZ> VOSZ { get; set; }

            public DSKO DSKO { get; set; }

            public List<DSBD> DSBD { get; set; }

            public List<NCSZ> NCSZ { get; set; }
        }
    }
}
