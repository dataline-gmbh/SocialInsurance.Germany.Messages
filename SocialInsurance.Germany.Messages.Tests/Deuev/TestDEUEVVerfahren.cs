using System;
using System.Collections.Generic;
using System.IO;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class TestDEUEVVerfahren : TestBasis
    {
        [Fact]
        public void TestDEUEV()
        {
            var input = LoadData("deuev.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                writer.Write(dsme);
                streamObject = reader.Read();
                var ncsz = Assert.IsType<NCSZ>(streamObject);
                writer.Write(ncsz);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
