using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

using BeanIO;

using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.AAG;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.aager
{
    public class AakTests02 : TestBasis, IClassFixture<DefaultStreamFactoryFixture>
    {
        public AakTests02(DefaultStreamFactoryFixture fixture)
            : base(fixture.Factory)
        {
        }

        /// <summary>
        /// DSRA
        /// </summary>
        [Theory(DisplayName = "TestDSRA v2", Skip = "Keine Kundenunabhängigen Testdaten vorhanden")]
        [InlineData(@"d:\temp\aak-test-01.txt", "super-message")]
        [InlineData(@"d:\temp\aak-test-01.txt", "dsra-agger-v02")]
        public void TestDSRA02(string fileName, string streamName)
        {
            try
            {
                var deuevMessage = GetMessageFromFile(fileName, streamName);
                Assert.True(deuevMessage.DSRA02.Count > 0);
            }
            catch (BeanReaderException ex) when(DumpFieldExceptions(ex))
            {
                
            }
        }

        private bool DumpFieldExceptions(BeanReaderException exception)
        {
            foreach (var fieldErrors in exception.RecordContext.GetFieldErrors())
            {
                Debug.WriteLine($"Error(s) for field {fieldErrors.Key}");
                foreach (var fieldError in fieldErrors)
                    Debug.WriteLine($"\t{fieldError}");
            }
            return false;
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
        /// <returns>
        /// Meldedatei als DeuevMessageData-Objekt
        /// </returns>
        private DsraMessageData GetMessageFromFile(string fileName, string name)
        {
            var input = string.Join(string.Empty, File.ReadAllLines(fileName).Select(x => x + Environment.NewLine));

            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter(name, output);
            var reader = StreamFactory.CreateReader(name, new StringReader(input));
            var deuevMessage = new DsraMessageData();
            try
            {
                var streamObject = reader.Read();

                do
                {
                    var vosz = Assert.IsType<VOSZ>(streamObject);
                    deuevMessage.VOSZ.Add(vosz);
                    writer.Write(vosz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName == "VOSZ" || reader.RecordName == "VOSZ-v01");

                if (reader.RecordName == "DSKO" || reader.RecordName == "DSKO-v04")
                {
                    var dsko = Assert.IsType<DSKO04>(streamObject);
                    writer.Write(dsko);
                    streamObject = reader.Read();
                }

                while (reader.RecordName == "DSRA" || reader.RecordName == "DSRA-v02")
                {
                    var record = Assert.IsType<DSRA02>(streamObject);
                    deuevMessage.DSRA02.Add(record);
                    writer.Write(record);
                    streamObject = reader.Read();
                }

                do
                {
                    var ncsz = Assert.IsType<NCSZ>(streamObject);
                    writer.Write(streamObject);
                    deuevMessage.NCSZ.Add(ncsz);
                    streamObject = reader.Read();
                }
                while (reader.RecordName != null && (reader.RecordName == "NCSZ" || reader.RecordName == "NCSZ-v01"));

                Assert.Null(reader.RecordName);
                Assert.Equal(deuevMessage.VOSZ.Count, deuevMessage.NCSZ.Count);

                writer.Close();
                string output2 = output.ToString();
                Assert.Equal(input, output2);
                return deuevMessage;
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Hilfsklasse der Meldedatei, die eine Meldedatei im Deuev-Format
        /// mit den Datensätzen als Objekte enthält
        /// </summary>
        private class DsraMessageData
        {
            public DsraMessageData()
            {
                VOSZ = new List<VOSZ>();
                DSRA02 = new List<DSRA02>();
                NCSZ = new List<NCSZ>();
            }

            public List<VOSZ> VOSZ { get; }

            public List<DSRA02> DSRA02 { get; }

            public List<NCSZ> NCSZ { get; }
        }
    }
}
