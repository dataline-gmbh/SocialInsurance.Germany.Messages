using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.EUBP;
using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests.EUBP
{
    public class EUBPTests : TestBasis2, IClassFixture<DefaultStreamFactoryFixture>
    {
        public EUBPTests(DefaultStreamFactoryFixture fixture, ITestOutputHelper output)
            : base(fixture.Factory, output)
        {
        }

        [Theory]
        [InlineData("tebe0099.dat")]
        public void TestEUBPV04(string filename)
        {
            TestFile<DSAG04>(filename);
        }

        private void TestFile<TDatensatz>(string filename)
            where TDatensatz : class, IDatensatz
        {
            var ds = GetDatensaetze(filename);
            TestRoundtripFile(filename, ds);
        }
    }
}
