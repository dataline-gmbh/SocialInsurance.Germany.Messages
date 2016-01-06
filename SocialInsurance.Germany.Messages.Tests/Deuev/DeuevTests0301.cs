using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class DeuevTests0301 : TestBasis
    {
        /// <summary>
        /// Beginn der Versicherungs- und/oder Beitragspflicht
        /// wegen Aufnahme einer Beschäftigung (VSNR liegt vor)
        /// </summary>
        [Theory(DisplayName = "Validierung")]
        [InlineData("edua00000.dat")]
        public void Validate(string fileName)
        {
            var input = ReadData(string.Format("DSME0301.{0}", fileName));
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

        /// <summary>
        /// Erstellt die Meldedatei anhand von <paramref name="data"/> neu.
        /// </summary>
        /// <param name="data">Die Daten die zur Erstellung der Meldedatei benutzt werden sollen</param>
        /// <param name="streamName">Der Name des Streams der für die Erstellung der Meldedatei benutzt werden soll</param>
        /// <returns>Die Meldedatei</returns>
        private string GetStringFromMessage(DeuevMessageData data, string streamName)
        {
            var output = new StringWriter();
            using (var writer = StreamFactory.CreateWriter(streamName, output))
            {
                foreach (var record in data.VOSZ)
                    writer.Write(record);
                writer.Write(data.DSKO);
                foreach (var record in data.DSME)
                    writer.Write(record);
                foreach (var record in data.DSBD)
                    writer.Write(record);
                foreach (var record in data.NCSZ)
                    writer.Write(record);
            }
            return output.ToString();
        }

        private DeuevMessageData GetMessageFromString(string input, string streamName)
        {
            var reader = StreamFactory.CreateReader(streamName, new StringReader(input));
            var deuevMessage = new DeuevMessageData();
            try
            {
                var streamObject = reader.Read();

                do
                {
                    var vosz = Assert.IsType<VOSZ>(streamObject);
                    deuevMessage.VOSZ.Add(vosz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName == "VOSZ" || reader.RecordName == "VOSZ-v01");

                var dsko = Assert.IsType<DSKO04>(streamObject);
                deuevMessage.DSKO = dsko;
                streamObject = reader.Read();

                while (reader.RecordName == "DSME" || reader.RecordName == "DSME-v0301")
                {
                    var record = Assert.IsType<DSME0301>(streamObject);
                    deuevMessage.DSME.Add(record);
                    streamObject = reader.Read();
                }

                while (reader.RecordName == "DSBD" || reader.RecordName == "DSBD-v01")
                {
                    var record = Assert.IsType<DSBD>(streamObject);
                    deuevMessage.DSBD.Add(record);
                    streamObject = reader.Read();
                }

                do
                {
                    var ncsz = Assert.IsType<NCSZ>(streamObject);
                    deuevMessage.NCSZ.Add(ncsz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName != null && (reader.RecordName == "NCSZ-v01" || reader.RecordName == "NCSZ"));

                Assert.Null(reader.RecordName);
                Assert.Equal(deuevMessage.VOSZ.Count, deuevMessage.NCSZ.Count);

                return deuevMessage;
            }
            finally
            {
                reader.Close();
            }
        }

        private void ValidateContents(string fileContents)
        {
            var lines = fileContents.Split(new[]
            {
                '\r', '\n'
            }, StringSplitOptions.RemoveEmptyEntries);

            var errorMessages = new List<ErrorInfo>();
            var validator = new de.drv.dsrv.kernpruefung.adapter.impl.KernpruefungAufrufImpl();
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
                    if (result.getReturnCode() != de.drv.dsrv.kernpruefung.adapter.Returncodes.RC_OK.getReturnCode()
                        && result.getReturnCode() != de.drv.dsrv.kernpruefung.adapter.Returncodes.RC_HINWEIS.getReturnCode())
                    {
                        errorMessages.AddRange(result.getRueckgabeMeldungen().Select(x => new ErrorInfo(x)));
                    }
                }
            }

            if (errorMessages.Count != 0)
                throw new ErrorInfoValidationException(errorMessages);
        }

        /// <summary>
        /// Ruft die Meldedatei mit einem bestimmten Dateinamen aus dem Deuev-Ordner ab
        /// </summary>
        /// <param name="fileName">Dateiname der Meldedatei</param>
        /// <returns>Meldedatei als DeuevMessageData-Objekt</returns>
        private DeuevMessageData GetAndCheckDeuevMessageFromFile(string fileName)
        {
            var input = ReadData(string.Format("DSME0301.{0}", fileName));
            ValidateContents(input);

            var deuevMessage = GetMessageFromString(input, "dsme-deuev-v0301");
            var output = GetStringFromMessage(deuevMessage, "dsme-deuev-v0301");
            Assert.Equal(input, output);
            return deuevMessage;
        }

        /// <summary>
        /// Hilfsklasse der Meldedatei, die eine Meldedatei im Deuev-Format
        /// mit den Datensätzen als Objekte enthält
        /// </summary>
        private class DeuevMessageData
        {
            public DeuevMessageData()
            {
                VOSZ = new List<VOSZ>();
                DSME = new List<DSME0301>();
                DSBD = new List<DSBD>();
                NCSZ = new List<NCSZ>();
            }

            public List<VOSZ> VOSZ { get; set; }

            public DSKO04 DSKO { get; set; }

            public List<DSME0301> DSME { get; set; }

            public List<DSBD> DSBD { get; set; }

            public List<NCSZ> NCSZ { get; set; }
        }
    }
}
