using SocialInsurance.Germany.Messages.Pocos.KSK;
using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests.KSK
{
    public class KskDsmkTests : TestBasis2, IClassFixture<DefaultStreamFactoryFixture>
    {
        public KskDsmkTests(DefaultStreamFactoryFixture fixture, ITestOutputHelper output)
            : base(fixture.Factory, output)
        {
        }

        [Theory]
        [InlineData("KSK_DSMK_OK.txt")]
        [InlineData("KSK_DSMK_FE-DSMK020.txt")]
        public void TestKskMeldung(string filename)
        {
            var ds = GetDatensaetze(filename);
            AssertDatensatzCollection<DSMK>(ds);
        }
    }
}
