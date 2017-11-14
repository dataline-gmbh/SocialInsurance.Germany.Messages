using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

using BeanIO;

using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.AAG;

using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests.aager
{
    public class AagTests : TestBasis, IClassFixture<DefaultStreamFactoryFixture>
    {
        private readonly ITestOutputHelper _output;

        public AagTests(DefaultStreamFactoryFixture fixture, ITestOutputHelper output)
            : base(fixture.Factory)
        {
            _output = output;
        }

        /// <summary>
        /// DSER
        /// </summary>
        [Fact(DisplayName = "TestDSER v02")]
        public void TestDSER02()
        {
            var deuevMessage = GetMessageFromFile("eaag0004.a15", "dser-agger-v02");
            Assert.True(deuevMessage.DSER02.Count > 0);
        }

        /// <summary>
        /// DSER
        /// </summary>
        [Theory(DisplayName = "TestDSER v03")]
        [InlineData("eaag0001.a15", "super-message")]
        [InlineData("eaag0007.a15", "dser-agger-v03")]
        [InlineData("eaag0007.a15", "super-message")]
        public void TestDSER03(string fileName, string streamName)
        {
            var deuevMessage = GetMessageFromFile(fileName, streamName);
            Assert.True(deuevMessage.DSER03.Count > 0);
        }

        /// <summary>
        /// Test mit Kundendaten
        /// </summary>
        [Theory(DisplayName = "(De-)serialisierung einer AAG-Rückmeldung (Kunden-Daten)")]
        [InlineData(@"d:\temp\EAAG0000026.txt", "super-message")]
        [InlineData(@"d:\temp\EAAG0000026.txt", "dser-agger-v04")]
        [InlineData(@"d:\temp\EAAG0000026.txt", "envelope-response-generic")]
        public void TestAagCustomerData(string fileName, string streamName)
        {
            if (!File.Exists(fileName))
            {
                _output.WriteLine($"Die Kunden-Datei {fileName} existiert nicht.");
                return;
            }
            var deuevMessage = GetMessageFromFile(fileName, streamName, true);
        }

        /// <summary>
        /// Ruft die Meldedatei mit einem bestimmten Dateinamen aus dem Deuev-Ordner ab
        /// </summary>
        /// <param name="fileName">
        /// Dateiname der Meldedatei
        /// </param>
        /// <param name="name">
        /// Name in der Meldungen.xml
        /// </param>
        /// <param name="isCustomerFile">Ist der Dateiname eine echte Kundendatei?</param>
        /// <returns>
        /// Meldedatei als DeuevMessageData-Objekt
        /// </returns>
        private AagMessageData GetMessageFromFile(string fileName, string name, bool isCustomerFile = false)
        {
            var input = isCustomerFile ? File.ReadAllText(fileName, Encoding.Default) : LoadData(fileName).ReadToEnd();
            try
            {
                return GetMessageFromString(input, name);
            }
            catch (InvalidRecordException ex) when (LogInvalidRecordException(ex))
            {
                Debug.Assert(false, "Darf hier niemals landen");
                throw;
            }
        }

        /// <summary>
        /// Erstellt ein Meldungsobjekt anhand eines Textes und Stream-Namens
        /// </summary>
        /// <param name="input">Der Text anhand dessen das Meldungsobjekt erstellt werden soll</param>
        /// <param name="streamName">Der Name des Streams, der für die Deserialisierung verwendet werden soll</param>
        /// <returns></returns>
        private AagMessageData GetMessageFromString(string input, string streamName)
        {
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter(streamName, output);
            var reader = StreamFactory.CreateReader(streamName, new StringReader(input));
            var deuevMessage = new AagMessageData();
            try
            {
                var streamObject = reader.Read();

                do
                {
                    var vosz = Assert.IsType<VOSZ>(streamObject);
                    deuevMessage.VOSZ.Add(vosz);
                    writer.Write(vosz);
                    streamObject = reader.Read();
                } while (reader.RecordName == "VOSZ" || reader.RecordName == "VOSZ-v01");

                if (reader.RecordName == "DSKO-v04" || streamName == "dser-agger-v04")
                {
                    var dsko = Assert.IsType<DSKO04>(streamObject);
                    deuevMessage.DSKO04 = dsko;
                    writer.Write(dsko);
                    streamObject = reader.Read();
                }
                else if (reader.RecordName == "DSKO" || reader.RecordName == "DSKO-v02")
                {
                    var dsko = Assert.IsType<DSKO02>(streamObject);
                    deuevMessage.DSKO02 = dsko;
                    writer.Write(dsko);
                    streamObject = reader.Read();
                }

                while (reader.RecordName == "DSER" || reader.RecordName == "DSER-v02" || reader.RecordName == "DSER-v03")
                {
                    switch (streamName)
                    {
                        case "dser-agger-v02":
                        {
                            var record = Assert.IsType<DSER02>(streamObject);
                            deuevMessage.DSER02.Add(record);
                            writer.Write(record);
                        }
                            break;
                        case "dser-agger-v03":
                        {
                            var record = Assert.IsType<DSER03>(streamObject);
                            deuevMessage.DSER03.Add(record);
                            writer.Write(record);
                        }
                            break;
                        case "super-message":
                            switch (reader.RecordName)
                            {
                                case "DSER-v02":
                                {
                                    var record = Assert.IsType<DSER02>(streamObject);
                                    deuevMessage.DSER02.Add(record);
                                    writer.Write(record);
                                }
                                    break;
                                case "DSER-v03":
                                {
                                    var record = Assert.IsType<DSER03>(streamObject);
                                    deuevMessage.DSER03.Add(record);
                                    writer.Write(record);
                                }
                                    break;
                                case "DSER-v04":
                                    {
                                        var record = Assert.IsType<DSER04>(streamObject);
                                        deuevMessage.DSER04.Add(record);
                                        writer.Write(record);
                                    }
                                    break;
                                case "DSER-v05":
                                    {
                                        var record = Assert.IsType<DSER05>(streamObject);
                                        deuevMessage.DSER05.Add(record);
                                        writer.Write(record);
                                    }
                                    break;
                                default:
                                    throw new InvalidOperationException($"Unsupported record {reader.RecordName}");
                            }
                            break;
                        default:
                            throw new InvalidOperationException($"Unsupported stream {streamName}");
                    }
                    streamObject = reader.Read();
                }

                do
                {
                    var ncsz = Assert.IsType<NCSZ>(streamObject);
                    writer.Write(streamObject);
                    deuevMessage.NCSZ.Add(ncsz);
                    streamObject = reader.Read();
                } while (reader.RecordName != null && (reader.RecordName == "NCSZ" || reader.RecordName == "NCSZ-v01"));

                Assert.Null(reader.RecordName);
                Assert.Equal(deuevMessage.VOSZ.Count, deuevMessage.NCSZ.Count);

                writer.Close();

                var isGenericEnvelopeStream = streamName.StartsWith("envelope-") && streamName.EndsWith("-generic");
                if (!isGenericEnvelopeStream)
                {
                    var inputLines = input.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).Select(x => x.TrimEnd());
                    string output2 = output.ToString();
                    var outputLines = output2.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).Select(x => x.TrimEnd());
                    Assert.Equal(inputLines, outputLines);
                }

                return deuevMessage;
            }
            finally
            {
                reader.Close();
            }
        }

        private bool LogInvalidRecordException(InvalidRecordException ex)
        {
            _output.WriteLine(ex.ToString());
            foreach (var recordError in ex.RecordContext.RecordErrors)
            {
                _output.WriteLine($"Record error: {recordError}");
            }
            foreach (var fieldErrors in ex.RecordContext.GetFieldErrors())
            {
                foreach (var fieldError in fieldErrors)
                {
                    _output.WriteLine($"Field error for field {fieldErrors.Key}: {fieldError}");
                }
            }
            return false;
        }

        /// <summary>
        /// Hilfsklasse der Meldedatei, die eine Meldedatei im Deuev-Format
        /// mit den Datensätzen als Objekte enthält
        /// </summary>
        [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
        [SuppressMessage("ReSharper", "MemberCanBePrivate.Local")]
        [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
        private class AagMessageData
        {
            public AagMessageData()
            {
                VOSZ = new List<VOSZ>();
                DSER02 = new List<DSER02>();
                DSER03 = new List<DSER03>();
                DSER04 = new List<DSER04>();
                DSER05 = new List<DSER05>();
                NCSZ = new List<NCSZ>();
            }

            public List<VOSZ> VOSZ { get; set; }

            public DSKO02 DSKO02 { get; set; }
            public DSKO04 DSKO04 { get; set; }

            public List<DSER02> DSER02 { get; set; }
            public List<DSER03> DSER03 { get; set; }
            public List<DSER04> DSER04 { get; set; }
            public List<DSER05> DSER05 { get; set; }

            public List<NCSZ> NCSZ { get; set; }
        }
    }
}
