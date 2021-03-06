﻿using System.Collections.Generic;
using System.IO;
using BeanIO;
using SocialInsurance.Germany.Messages.Pocos;
using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests
{
    public abstract class TestBasis2 : TestBasis
    {
        protected TestBasis2(StreamFactory factory)
            : this(factory, null)
        { }

        protected TestBasis2(StreamFactory factory, ITestOutputHelper output)
            : base(factory)
        {
            TestOutput = output ?? new NullOutput();
        }

        protected ITestOutputHelper TestOutput { get; }

        /// <summary>
        /// Deserialisiert eine Meldung in ihre Datensätze.
        /// </summary>
        protected IReadOnlyCollection<IDatensatz> GetDatensaetze(string filename)
        {
            using (var reader = StreamFactory.CreateReader("super-message", LoadData(filename)))
            {
                var dsList = new List<IDatensatz>(3);
                try
                {
                    while (reader.Read() is IDatensatz datensatz)
                    {
                        dsList.Add(datensatz);
                    }
                }
                catch (BeanReaderException beanReaderEx)
                {
                    ReaderErrorHandler(beanReaderEx);
                    throw;
                }

                return dsList;
            }
        }

        private void ReaderErrorHandler(BeanReaderException exception)
        {
            TestOutput.WriteLine("Fehler beim Lesen der Meldung: {0}", exception.Message);
            var ctx = exception.RecordContext;
            TestOutput.WriteLine("Datensatzfehler vorhanden: {0}, Feldfehler vorhanden: {1}", ctx.HasRecordErrors, ctx.HasFieldErrors);
            if (ctx.HasRecordErrors)
            {
                TestOutput.WriteLine("  Datensatzfehler ({0}):", ctx.RecordErrors.Count);
                foreach (var error in ctx.RecordErrors)
                {
                    TestOutput.WriteLine("    {0}", error);
                }
            }
            if (ctx.HasFieldErrors)
            {
                var fieldErrors = ctx.GetFieldErrors();
                TestOutput.WriteLine("  Feldfehler ({0}):", fieldErrors.Count);
                foreach (var error in fieldErrors)
                {
                    TestOutput.WriteLine("    {0}:", error.Key);
                    foreach (var detail in error)
                    {
                        TestOutput.WriteLine("      {0}", detail);
                    }
                }
            }
        }

        /// <summary>
        /// Überprüft, ob alle Datensätze der Meldung vom korrekten Typ sind.
        /// </summary>
        protected void AssertDatensatzCollection<TDatensatz>(IReadOnlyCollection<IDatensatz> datensaetze)
            where TDatensatz : class, IDatensatz
        {
            Assert.NotEmpty(datensaetze);
            Assert.Equal(3, datensaetze.Count);
            Assert.Collection(datensaetze,
                o => Assert.IsType<VOSZ>(o),
                o => Assert.IsType<TDatensatz>(o),
                o => Assert.IsType<NCSZ>(o)
            );
        }

        /// <summary>
        /// Überprüft, ob die Meldung nach dem Deserialisieren und Serialisieren identisch zur Originalmeldung ist.
        /// </summary>
        protected void TestRoundtripFile(string filename, IReadOnlyCollection<IDatensatz> datensaetze)
        {
            using (var ms = new MemoryStream())
            using (var sw = new StreamWriter(ms))
            using (var writer = StreamFactory.CreateWriter("super-message", sw))
            {
                // Datensätze wieder serialisieren
                foreach (var datensatz in datensaetze)
                {
                    writer.Write(datensatz);
                }
                writer.Flush();

                // Serialisierten Datenstrom auslesen
                ms.Position = 0;
                using (var sr = new StreamReader(ms))
                using (var srOriginal = LoadData(filename))
                {
                    bool CanReadLine(TextReader reader, out string line) => (line = reader.ReadLine()) != null;

                    // Zeilenweise die Originalmeldung und die serialisierte Meldung vergleichen
                    while (CanReadLine(sr, out string serialisedLine)
                        && CanReadLine(srOriginal, out string originalLine))
                    {
                        Assert.Equal(originalLine, serialisedLine, ignoreLineEndingDifferences: true);
                    }
                }
            }
        }

        private sealed class NullOutput : ITestOutputHelper
        {
            internal NullOutput()
            { }

            void ITestOutputHelper.WriteLine(string message)
            { /* nichts */ }

            void ITestOutputHelper.WriteLine(string format, params object[] args)
            { /* nichts */ }
        }
    }
}
