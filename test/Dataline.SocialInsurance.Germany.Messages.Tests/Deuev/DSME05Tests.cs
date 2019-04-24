using System.Linq;
using BeanIO;
using SocialInsurance.Germany.Messages.Pocos;
using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class DSME05Tests : TestBasis2, IClassFixture<DefaultStreamFactoryFixture>
    {
        public DSME05Tests(DefaultStreamFactoryFixture fixture, ITestOutputHelper output)
            : base(fixture.Factory, output)
        {
        }

        [Theory]
        [InlineData("AlleBausteine.dat")]
        public void TestParseDSME05(string filename)
        {
            string semiQualifiedPath = $"DSME05.{filename}";
            var ds = GetDatensaetze(semiQualifiedPath);
            AssertDatensatzCollection<DSME05>(ds);
            TestRoundtripFile(semiQualifiedPath, ds);
        }
    }
}
