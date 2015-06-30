using System;
using System.Collections.Generic;
using System.IO;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Meldung10
{
    public class TestSimpleMeldung10 : TestBasis
    {
        [Fact]
        public void TestMitSV()
        {
            var input = LoadData("m10mitSVok.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("meldung10", output);
            var reader = StreamFactory.CreateReader("meldung10", new StringReader(input));
            try
            {
                var dsme = Assert.IsType<DSME>(reader.Read());
                writer.Write(dsme);
                Assert.NotNull(dsme.Name);
                Assert.True(dsme.MMME);
                Assert.True(dsme.MMNA);
                Assert.True(dsme.MMAN);
                Assert.False(dsme.MMGB);
                Assert.False(dsme.MMEU);
                Assert.NotEqual(string.Empty, dsme.VSNR);
                Assert.DoesNotContain(dsme.PERSGR, new List<string> { "110", "103", "900", "901" });
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestOhneSV()
        {
            var input = LoadData("m10ohneSVok.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("meldung10", output);
            var reader = StreamFactory.CreateReader("meldung10", new StringReader(input));
            try
            {
                var dsme = Assert.IsType<DSME>(reader.Read());
                writer.Write(dsme);
                Assert.NotNull(dsme.Name);
                Assert.True(dsme.MMME);
                Assert.True(dsme.MMNA);
                Assert.True(dsme.MMAN);
                Assert.True(dsme.MMGB);
                Assert.True(dsme.MMEU);
                Assert.Equal(string.Empty, dsme.VSNR);
                Assert.DoesNotContain(dsme.PERSGR, new List<string> { "110", "103", "900", "901" });
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
