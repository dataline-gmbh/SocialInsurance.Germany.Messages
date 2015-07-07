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

            var input = LoadData("btrag.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("btrag", output);
            var reader = StreamFactory.CreateReader("btrag", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                streamObject = reader.Read();
                var dsbd = Assert.IsType<DSBD>(streamObject);
                streamObject = reader.Read();
                var ncsz = Assert.IsType<NCSZ>(streamObject);
                writer.Close();
                //Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
