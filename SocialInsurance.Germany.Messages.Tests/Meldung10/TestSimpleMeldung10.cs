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
        public void TestOhneSV()
        {
            var input = LoadData("m10ohneSVok.txt").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("meldung10", output);
            var reader = StreamFactory.CreateReader("meldung10", new StringReader(input));
            try
            {
                var dsme = Assert.IsType<DSME>(reader.Read());
                writer.Write(dsme);
                Assert.True(dsme.HatName);
                Assert.NotNull(dsme.Name);
                Assert.Equal("Tüngler", dsme.Name.Familienname);
                Assert.Equal(true, dsme.HatMeldesachverhalt);
                Assert.Equal(true, dsme.HatName);
                Assert.Equal(true, dsme.HatAnschrift);
                Assert.Equal(false, dsme.HatGeburtsangaben);
                Assert.Equal(false, dsme.HatEuropäischeVersicherungsnummer);
                Assert.Equal(string.Empty, dsme.Versicherungsnummer);
                Assert.DoesNotContain(dsme.Personengruppe, new List<string> { "110", "103", "900", "901" });
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
