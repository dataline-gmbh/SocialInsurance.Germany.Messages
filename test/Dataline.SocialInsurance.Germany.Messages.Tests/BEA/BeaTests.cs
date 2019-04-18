using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.BEA;
using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests.BEA
{
    public class BeaTests : TestBasis2, IClassFixture<DefaultStreamFactoryFixture>
    {
        public BeaTests(DefaultStreamFactoryFixture fixture, ITestOutputHelper output)
            : base(fixture.Factory, output)
        {
        }

        [InlineData("DSAB_FE-DSAB007.txt")]
        [InlineData("DSAB_OK.txt")]
        [Theory]
        public void TestBEA_DSAB(string filename)
        {
            ReadFileAndAssert<DSAB>(filename);
        }

        [InlineData("DSEU_FE-DSEU044.txt")]
        [InlineData("DSEU_OK.txt")]
        [Theory]
        public void TestBEA_DSEU(string filename)
        {
            ReadFileAndAssert<DSEU>(filename);
        }

        [InlineData("DSNE_FE-DSNE044.txt")]
        [InlineData("DSNE_OK.txt")]
        [Theory]
        public void TestBEA_DSNE(string filename)
        {
            ReadFileAndAssert<DSNE>(filename);
        }

        private void ReadFileAndAssert<TDatensatz>(string filename)
            where TDatensatz : BasisDatensatzBEA, new()
        {
            var ds = GetDatensaetze(filename);
            AssertDatensatzCollection<TDatensatz>(ds);
            TestRoundtripFile(filename, ds);
        }
    }
}
