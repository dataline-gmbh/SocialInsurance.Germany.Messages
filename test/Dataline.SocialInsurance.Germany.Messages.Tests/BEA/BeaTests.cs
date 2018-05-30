using BeanIO;
using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.BEA;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests.BEA
{
    public class BeaTests : TestBasis, IClassFixture<DefaultStreamFactoryFixture>
    {
        private readonly ITestOutputHelper output;

        public BeaTests(DefaultStreamFactoryFixture fixture, ITestOutputHelper output)
            : base(fixture.Factory)
        {
            this.output = output;
        }

        [InlineData("DSAB_FE-DSAB007.txt")]
        [InlineData("DSAB_OK.txt")]
        [Theory]
        public void TestBEA_DSAB(string filename)
        {
            using (var reader = GetReader(filename))
            {
                var ds = GetDatensaetze(reader);
                AssertDatensatzCollection<DSAB>(ds);
            }
        }

        [InlineData("DSEU_FE-DSEU044.txt")]
        [InlineData("DSEU_OK.txt")]
        [Theory]
        public void TestBEA_DSEU(string filename)
        {
            using (var reader = GetReader(filename))
            {
                var ds = GetDatensaetze(reader);
                AssertDatensatzCollection<DSEU>(ds);
            }
        }

        [InlineData("DSNE_FE-DSNE044.txt")]
        [InlineData("DSNE_OK.txt")]
        [Theory]
        public void TestBEA_DSNE(string filename)
        {
            using (var reader = GetReader(filename))
            {
                var ds = GetDatensaetze(reader);
                AssertDatensatzCollection<DSNE>(ds);
            }
        }

        private IBeanReader GetReader(string filename)
        {
            string fileContents = LoadData(filename).ReadToEnd();
            return StreamFactory.CreateReader("super-message", new StringReader(fileContents));
        }

        private IEnumerable<IDatensatz> GetDatensaetze(IBeanReader reader)
        {
            var dsList = new List<IDatensatz>(3);
            object ds;
            while ((ds = reader.Read()) != null)
            {
                dsList.Add(ds as IDatensatz);
            }
            return dsList;
        }

        private void AssertDatensatzCollection<TDatensatz>(IEnumerable<IDatensatz> datensaetze)
            where TDatensatz : class, IDatensatz
        {
            Assert.NotEmpty(datensaetze);
            Assert.Collection(datensaetze,
                o => Assert.IsType<VOSZ>(o),
                o => Assert.IsType<TDatensatz>(o),
                o => Assert.IsType<NCSZ>(o)
            );
        }
    }
}
