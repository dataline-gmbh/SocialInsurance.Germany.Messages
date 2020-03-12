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
        [InlineData("TEBExxx.dat")]
        public void TestEEUBPV04(string filename)
        {
            TestFile<DSAG04>(filename);
        }

        private void TestFile<TDatensatz>(string filename)
            where TDatensatz : class, IDatensatz
        {
            var ds = GetDatensaetze(filename);
            AssertDatensatzCollection<TDatensatz>(ds);
            TestRoundtripFile(filename, ds);
        }
    }
}
