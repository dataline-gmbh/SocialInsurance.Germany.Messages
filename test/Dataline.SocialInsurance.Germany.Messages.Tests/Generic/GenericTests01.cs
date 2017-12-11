extern alias deuev18;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;
using Xunit.Abstractions;

using adapter = deuev18::de.drv.dsrv.kernpruefung.adapter;

namespace SocialInsurance.Germany.Messages.Tests.Generic
{
    public class GenericTests01 : TestBasis, IClassFixture<DefaultStreamFactoryFixture>
    {
        private readonly ITestOutputHelper _output;

        public GenericTests01(DefaultStreamFactoryFixture fixture, ITestOutputHelper output)
            : base(fixture.Factory)
        {
            _output = output;
        }

        /// <summary>
        /// Beginn der Versicherungs- und/oder Beitragspflicht
        /// wegen Aufnahme einer Beschäftigung (VSNR liegt vor)
        /// </summary>
        [Fact(DisplayName = "Deserialisierung einer Rückmeldung mit DBFE im VOSZ")]
        public void TestSagDskk01()
        {
            var deuevMessage = GetAndCheckMessageFromFile("error-response-01.txt", false);
            Assert.NotNull(deuevMessage);
        }

        /// <summary>
        /// Erstellt die Meldedatei anhand von <paramref name="data"/> neu.
        /// </summary>
        /// <param name="data">Die Daten die zur Erstellung der Meldedatei benutzt werden sollen</param>
        /// <param name="streamName">Der Name des Streams der für die Erstellung der Meldedatei benutzt werden soll</param>
        /// <returns>Die Meldedatei</returns>
        private string GetStringFromMessage(MessageData data, string streamName)
        {
            var output = new StringWriter();
            using (var writer = StreamFactory.CreateWriter(streamName, output))
            {
                foreach (var record in data.VOSZ)
                    writer.Write(record);
                writer.Write(data.DSKO);
                foreach (var record in data.NCSZ)
                    writer.Write(record);
            }
            return output.ToString();
        }

        private MessageData GetMessageFromString(string input, string streamName)
        {
            var reader = StreamFactory.CreateReader(streamName, new StringReader(input));
            var deuevMessage = new MessageData();
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

        /// <summary>
        /// Prüfung durch die Kernprüfung der DSRV
        /// </summary>
        /// <param name="fileContents">Text-Inhalt der Datei</param>
        private void ValidateContents(IEnumerable<string> lines)
        {
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
                else if (line.StartsWith("DSKO"))
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

        /// <summary>
        /// Ruft die Meldedatei mit einem bestimmten Dateinamen aus dem Deuev-Ordner ab
        /// </summary>
        /// <param name="fileName">Dateiname der Meldedatei</param>
        /// <returns>Meldedatei als DeuevMessageData-Objekt</returns>
        private MessageData GetAndCheckMessageFromFile(string fileName, bool validate = true)
        {
            var input = ReadData(string.Format("Data.{0}", fileName));

            var lines = input.Split(new[]
            {
                '\r', '\n'
            }, StringSplitOptions.RemoveEmptyEntries).AsEnumerable();

            if (validate)
                ValidateContents(lines);

            var deuevMessage = GetMessageFromString(input, "super-message");
            var output = GetStringFromMessage(deuevMessage, "super-message");

            var outputLines = output.Split(new[]
            {
                '\r', '\n'
            }, StringSplitOptions.RemoveEmptyEntries).AsEnumerable();

            Assert.Equal(lines, outputLines);
            return deuevMessage;
        }

        /// <summary>
        /// Hilfsklasse der Meldedatei, die eine Meldedatei im Deuev-Format
        /// mit den Datensätzen als Objekte enthält
        /// </summary>
        private class MessageData
        {
            public MessageData()
            {
                VOSZ = new List<VOSZ>();
                NCSZ = new List<NCSZ>();
            }

            public List<VOSZ> VOSZ { get; set; }

            public DSKO04 DSKO { get; set; }

            public List<NCSZ> NCSZ { get; set; }
        }
    }
}
