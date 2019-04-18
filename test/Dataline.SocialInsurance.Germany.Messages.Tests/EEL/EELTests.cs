using System.Collections.Generic;
using System.IO;
using BeanIO;
using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.EEL;
using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests.EEL
{
    public class EELTests : TestBasis2, IClassFixture<DefaultStreamFactoryFixture>
    {
        public EELTests(DefaultStreamFactoryFixture fixture, ITestOutputHelper output)
            : base(fixture.Factory, output)
        {
        }

        [Theory]
        [InlineData("TEEK0101_0166_122018")]
        [InlineData("TEEK0102_0161_122018")]
        [InlineData("TEEK0103_0166_042019")]
        [InlineData("TEEL_DSLW_AlleBausteine")]
        public void EELRueckmeldung(string filename)
        {
            var ds = GetDatensaetze(filename);
            AssertDatensatzCollection<DSLW09>(ds);
            TestRoundtripFile(filename, ds);
        }
    }
}
