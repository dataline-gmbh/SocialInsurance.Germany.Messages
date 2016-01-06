extern alias deuev17;

using System;
using System.Collections.Generic;
using System.Linq;

using Xunit;

using adapter = deuev17::de.drv.dsrv.kernpruefung.adapter;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class DeuevTests0301 : TestBasis
    {
        public DeuevTests0301()
        {
            StreamFactory.Load(new Uri("resource:SocialInsurance.Germany.Messages.Tests.Deuev.DeuevMappings.xml, SocialInsurance.Germany.Messages.Tests"));
        }

        /// <summary>
        /// Beginn der Versicherungs- und/oder Beitragspflicht
        /// wegen Aufnahme einer Beschäftigung (VSNR liegt vor)
        /// </summary>
        [Theory(DisplayName = "Validierung")]
        [InlineData("edua00000.dat")]
        public void Validate(string fileName)
        {
            var input = ReadData($"DSME0301.{fileName}");
            var exception = Assert.Throws<ErrorInfoValidationException>(() => ValidateContents(input));
            Assert.Collection(
                exception.Errors,
                ei =>
                {
                    Assert.Equal("DSKO042", ei.Code);
                    Assert.Equal("VERSIONS-NR nicht zugelassen", ei.Message);
                },
                ei =>
                {
                    Assert.Equal("DSKO900", ei.Code);
                    Assert.Equal("RESERVE ungleich Grundstellung (Leerzeichen)", ei.Message);
                },
                ei =>
                {
                    Assert.Equal("DSME252", ei.Code);
                    Assert.Equal("STAATSANGEHOERIGKEITS-SC unzulässig (Anl. 8 Gem. Rundschreiben)", ei.Message);
                },
                ei =>
                {
                    Assert.Equal("DSME620", ei.Code);
                    Assert.Equal("DATUM-VERARBEITUNG nicht Nullen oder logisch falsch", ei.Message);
                },
                ei =>
                {
                    Assert.Equal("DSME630", ei.Code);
                    Assert.Equal("NEBENVERSIONS-NR nicht zugelassen", ei.Message);
                },
                ei =>
                {
                    Assert.Equal("DSME635", ei.Code);
                    Assert.Equal("PRODUKT-IDENTIFIER Grundstellung unzulässig", ei.Message);
                },
                ei =>
                {
                    Assert.Equal("DSME640", ei.Code);
                    Assert.Equal("MODIFIKATIONS-IDENTIFIER Grundstellung unzulässig", ei.Message);
                },
                ei =>
                {
                    Assert.Equal("DBME050", ei.Code);
                    Assert.Equal("ZEITRAUM-ENDE nicht numerisch", ei.Message);
                },
                ei =>
                {
                    Assert.Equal("DBME175", ei.Code);
                    Assert.Equal("KENNZAP ungleich 0 oder 2 bis 9", ei.Message);
                });
        }

        [Fact(DisplayName = "Serialisierung für DSME 03.01")]
        public void TestSerializeDsme0301()
        {
            const string input =
                "DSMEDEUEV19278293       29720865       032016010511175200000000              57212313       55                  29720865                           57212313       10110000JJJJNNNNNN   N    N                     0013569492074400073339                                                                                                                               N                                                                                                                                                                                                       DBMEN0201601080000000000E0000001111722133211WN0                                                                                                    DBNAZiegel                        Nadja                                                                                      DBGBStein                                                                 19980120WHannover                          DBAN   30429     Hannover                          Bergstraße 14                                                                     ";
            const string expected =
                "DSMEDEUEV19278293       29720865       032016010511175200000000              57212313       55                  29720865                           57212313       10110000JJJJNNNNNN   N    N 000000000000000000000013569492074400073339                                                                                                                               N                                                                                                                                                                                                       DBMEN0201601080000000000E0000001111722133211WN0                                                                                                    DBNAZiegel                        Nadja                                                                                      DBGBStein                                                                 19980120WHannover                          DBAN   30429     Hannover                          Bergstraße 14                                                                     ";
            var unmarshaller = StreamFactory.CreateUnmarshaller("DSME-v0301");
            var record = unmarshaller.Unmarshal(input);
            var marshaller = StreamFactory.CreateMarshaller("DSME-v0301");
            var result = marshaller.Marshal(record).ToString();
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Prüfung durch die Kernprüfung der DSRV
        /// </summary>
        /// <param name="fileContents">Text-Inhalt der Datei</param>
        private void ValidateContents(string fileContents)
        {
            var lines = fileContents.Split(new[]
            {
                '\r', '\n'
            }, StringSplitOptions.RemoveEmptyEntries);

            var errorMessages = new List<ErrorInfo>();
            var validator = new adapter.impl.KernpruefungAufrufImpl();
            string voszLine = null;
            foreach (var line in lines)
            {
                string testLine = null;
                if (line.StartsWith("VOSZ"))
                {
                    voszLine = line;
                }
                else if (line.StartsWith("DSKO") || line.StartsWith("DSME") || line.StartsWith("DSBD"))
                {
                    testLine = line;
                }

                if (testLine != null)
                {
                    var result = validator.pruefe(line, voszLine);
                    if (result.getReturnCode() != adapter.Returncodes.RC_OK.getReturnCode()
                        && result.getReturnCode() != adapter.Returncodes.RC_HINWEIS.getReturnCode())
                    {
                        errorMessages.AddRange(result.getRueckgabeMeldungen().Select(x => new ErrorInfo(x)));
                    }
                }
            }

            if (errorMessages.Count != 0)
                throw new ErrorInfoValidationException(errorMessages);
        }
    }
}
