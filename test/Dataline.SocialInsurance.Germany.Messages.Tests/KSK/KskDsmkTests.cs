using BeanIO;
using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.KSK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests.KSK
{
    public class KskDsmkTests : TestBasis, IClassFixture<DefaultStreamFactoryFixture>
    {
        private readonly ITestOutputHelper output;

        public KskDsmkTests(DefaultStreamFactoryFixture fixture, ITestOutputHelper output)
            : base(fixture.Factory)
        {
            this.output = output;
        }

        [Fact]
        public void TestKskMeldungOK()
        {
            using (var reader = GetReader("KSK_DSMK_OK.txt"))
            {
                var ds = GetDatensaetze(reader);
                AssertDatensatzCollection(ds);
            }
        }

        [Fact]
        public void TestKskMeldungFehler()
        {
            using (var reader = GetReader("KSK_DSMK_FE-DSMK020.txt"))
            {
                var ds = GetDatensaetze(reader);
                AssertDatensatzCollection(ds);
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

        private void AssertDatensatzCollection(IEnumerable<IDatensatz> datensaetze)
        {
            Assert.NotEmpty(datensaetze);
            Assert.Collection(datensaetze,
                o => Assert.IsType<VOSZ>(o),
                o => Assert.IsType<DSMK>(o),
                o => Assert.IsType<NCSZ>(o)
            );
        }
    }
}
