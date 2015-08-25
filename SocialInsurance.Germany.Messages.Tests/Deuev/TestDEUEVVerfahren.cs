using System;
using System.Collections.Generic;
using System.IO;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class TestDEUEVVerfahren : TestBasis
    {
        /// <summary>
        /// Beginn der Versicherungs- und/oder Beitragspflicht
        /// wegen Aufnahme einer Beschäftigung (VSNR liegt vor)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 10: Aufnahme einer Beschäftigung (VSNR liegt vor)")]
        public void TestDEUEVMeldung10_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev10_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "10"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "10")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 104, 105, 106, 107, 108, 109, 111,
                        112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotEqual(string.Empty, dsme.VSNR);
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn der Versicherungs- und/oder Beitragspflicht
        /// wegen Aufnahme einer Beschäftigung (VSNR wurde noch nicht vergeben
        /// oder liegt dem Arbeitgeber nicht vor)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 10: Aufnahme einer Beschäftigung (VSNR wurde noch nicht vergeben oder liegt dem Arbeitgeber nicht vor)")]
        public void TestDEUEVMeldung10_2()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev10_2.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "10"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "10")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 104, 105, 106, 107, 109, 111,
                        112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.Equal(string.Empty, dsme.VSNR);
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBGB);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn einer geringfügigen Beschäftigung nach
        /// § 8 Abs. 1 Nr. 2 SGB IV (kurzfristige Beschäftigung)
        /// -VSNR liegt vor-
        /// </summary>
        [Fact(DisplayName = "Anmeldung 10: kurzfristige Beschäftigung, VSNR liegt vor")]
        public void TestDEUEVMeldung10_3()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev10_3.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "10"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "10")
                {
                    Assert.Equal(dsme.PERSGR, 110);
                    Assert.NotEqual(string.Empty, dsme.VSNR);
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn einer geringfügigen Beschäftigung nach
        /// § 8 Abs. 1 Nr. 2 SGB IV (kurzfristige Beschäftigung)
        /// -VSNR wurde noch nicht vergeben oder liegt dem Arbeitgeber nicht vor-
        /// </summary>
        [Fact(DisplayName = "Anmeldung 10: kurzfristige Beschäftigung, VSNR liegt nicht vor")]
        public void TestDEUEVMeldung10_4()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev10_4.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "10"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "10")
                {
                    Assert.Equal(dsme.PERSGR, 110);
                    Assert.Equal(string.Empty, dsme.VSNR);
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBGB);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Aufnahme der Beschäftigung nach Ende einer vollständigen Freistellung
        /// von der Arbeitsleistung durch Inanspruchnahme einer Pflegezeit
        /// nach § 3 Pflegezeitgesetz (PflegeZG)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 10: Aufnahme nach Pflegezeit")]
        public void TestDEUEVMeldung10_5()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev10_5.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "10"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "10")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 111,
                        112, 113, 114, 119, 121, 122, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel der Krankenkasse bei fortbestehendem Beschäftigungsverhältnis
        /// </summary>
        [Fact(DisplayName = "Anmeldung 11: Wechsel der Krankenkasse bei fortbestehendem Beschäftigungsverhältnis")]
        public void TestDEUEVMeldung11_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev11_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "11"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "11")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 111,
                        112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel der Beitragsgruppe bei fortbestehendem Beschäftigungsverhältnis
        /// </summary>
        [Fact(DisplayName = "Anmeldung 12: Wechsel der Beitragsgruppe bei fortbestehendem Beschäftigungsverhältnis")]
        public void TestDEUEVMeldung12_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev12_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "12"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "12")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 108, 109,
                        112, 113, 114, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn einer Beschäftigung nach Beendigung einer
        /// Berufsausbildung (beim gleichen Arbeitgeber
        /// und/oder ggf. ohne Beitragsgruppenwechsel)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 13: Beschäftigung nach Ausbildung (beim gleichen Arbeitgeber und/oder ggf. ohne Beitragsgruppenwechsel)")]
        public void TestDEUEVMeldung13_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev13_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "13"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "13")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 104, 112, 113, 114, 118, 123, 124, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn einer geringfügigen Beschäftigung nach Beendigung
        /// einer Berufsausbildung(ohne Arbeitgeberwechsel)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 11: Beschäftigung nach Ausbildung (ohne Arbeitgeberwechsel)")]
        public void TestDEUEVMeldung11_2()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev11_2.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "11"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "11")
                {
                    Assert.Contains(dsme.PERSGR, new List<int> { 109, 110, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn einer Berufsausbildung nach Beendigung einer Beschäftigung
        /// (beim gleichen Arbeitgeber und/oder ggf. ohne Beitragsgruppenwechsel)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 13: Ausbildungsbeginn nach Beschäftigungsende (beim gleichen Arbeitgeber)")]
        public void TestDEUEVMeldung13_2()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev13_2.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "13"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "13")
                {
                    Assert.Contains(dsme.PERSGR, new List<int> { 102, 121, 122 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn einer Berufsausbildung nach Beendigung einer
        /// geringfügigen Beschäftigung (ohne Arbeitgeberwechsel)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 11: Ausbildungsbeginn nach Beschäftigungsende (ohne Arbeitgeberwechsel)")]
        public void TestDEUEVMeldung11_3()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev11_3.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "11"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "11")
                {
                    Assert.Contains(dsme.PERSGR, new List<int> { 102, 121, 122 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn einer versicherungspflichtigen Beschäftigung nach Beendigung
        /// einer geringfügigen Beschäftigung (ohne Arbeitgeberwechsel)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 11: Beschäftigunsbeginn nach Ende einer geringfügigen Beschäftigung (ohne Arbeitgeberwechsel)")]
        public void TestDEUEVMeldung11_4()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev11_4.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "11"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "11")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 104, 105, 106, 107, 111, 112, 113, 114, 116, 118, 119, 123, 124, 127 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn einer geringfügigen Beschäftigung nach Beendigung einer
        /// versicherungspflichtigen Beschäftigung (ohne Arbeitgeberwechsel)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 11: Beginn einer geringfügigen Beschäftigung nach Beschäftigungsende (ohne Arbeitgeberwechsel)")]
        public void TestDEUEVMeldung11_5()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev11_5.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "11"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "11")
                {
                    Assert.Contains(dsme.PERSGR, new List<int> { 109, 110, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel in der Art der geringfügigen Beschäftigung
        /// (§ 8 Abs. 1 Nr. 1 SGB IV nach § 8 Abs. 1 Nr. 2 SGB IV oder umgekehrt)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 12: Wechsel in der Art der geringfügigen Beschäftigung")]
        public void TestDEUEVMeldung12_2()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev12_2.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "12"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "12")
                {
                    Assert.Contains(dsme.PERSGR, new List<int> { 109, 110, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beginn der Versicherungs- und/oder Beitragspflicht nach Ende einer
        /// Unterbrechung der Beschäftigung ohne Fortzahlung des Arbeitsentgelts
        /// von länger als einem Monat
        /// </summary>
        [Fact(DisplayName = "Anmeldung 13: Beginn einer Versicherungspflicht nach Unterbrechung" +
        "der Beschäftigung ohne Fortzahlung des Arbeiterentgelts")]
        public void TestDEUEVMeldung13_3()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev13_3.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "13"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "13")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 110, 111, 112, 113, 114, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Aufnahme einer Beschäftigung nach Wechsel von
        /// einer Betriebsstätte im Beitrittsgebiet zu einer
        /// Betriebsstätte im übrigen Bundesgebiet bzw. umgekehrt
        /// (ohne Arbeitgeber-/Krankenkassenwechsel)
        /// </summary>
        [Fact(DisplayName = "Anmeldung 13: Beschäftigungsaufnahme nach Betriebsstättenwechsel" +
        "von Beitrittsgebiet zu Bundesgebiet bzw. umgekehrt (ohne Arbeitgeber-/Krankenkassenwechsel)")]
        public void TestDEUEVMeldung13_4()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev13_4.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "13"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "13")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 111, 112, 113, 114, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Verzicht eines geringfügig entlohnten Beschäftigten nach § 8 Abs. 1 Nr. 1 SGB IV
        /// auf die Rentenversicherungsfreiheit nach § 5 Abs. 2 Satz 2 SGB VI
        /// </summary>
        [Fact(DisplayName = "Anmeldung 12: Verzicht eines geringfügig entlohnten Beschäftigten auf die Rentenversicherungsfreiheit")]
        public void TestDEUEVMeldung12_3()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev12_3.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "12"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "12")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 109 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel des Entgeltabrechnungssystems
        /// </summary>
        [Fact(DisplayName = "Anmeldung 13: Wechsel des Entgeltabrechnungssystems")]
        public void TestDEUEVMeldung13_5()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev13_5.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "13"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "13")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 114, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wiederanmeldung einer sozialversicherungsrechtlichen Beschäftigung beim selben Arbeitgeber nach
        /// einer Aussteuerung (= Ende des Krankengeldbezuges nach Erreichen der Höchstbezugsdauer des
        /// Krankengeldes nach § 48 Abs. 1 SGB V) wegen Arbeitsfähigkeit des Arbeitnehmers
        /// </summary>
        [Fact(DisplayName = "Anmeldung 13: Wiederanmeldung einer Beschäftigung wegen Arbeitsfähigkeit des Arbeitnehmers")]
        public void TestDEUEVMeldung13_6()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev13_6.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "13"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "13")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 112, 113, 114, 118, 121, 122, 123, 124, 127 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel der berufsständischen Versorgungseinrichtung
        /// bei fortbestehendem Beschäftigungsverhältnis
        /// </summary>
        [Fact(DisplayName = "Anmeldung 13:  Wechsel der berufsständischen Versorgungseinrichtung bei fortbestehendem Beschäftigungsverhältnis")]
        public void TestDEUEVMeldung13_7()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev13_7.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "13"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "13")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 105, 106, 107, 108, 109, 111, 112, 113, 114, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende der versicherungs- und/oder beitragspflichtigen Beschäftigung,
        /// auch wenn das Arbeitsverhältnis fortbesteht
        /// </summary>
        [Fact(DisplayName = "Abmeldung 30: Ende der versicherungs- und/oder beitragspflichtigen Beschäftigung, auch wenn das Arbeitsverhältnis fortbesteht")]
        public void TestDEUEVMeldung30_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev30_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "30"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "30")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 111,
                            112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende einer geringfügigen Beschäftigung nach
        /// § 8 Abs. 1 Nr. 2 SGB IV (kurzfristige Beschäftigung)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 30: Ende einer geringfügigen Beschäftigung nach § 8 Abs. 1 Nr. 2 SGB IV (kurzfristige Beschäftigung)")]
        public void TestDEUEVMeldung30_2()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev30_2.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "30"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "30")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 110 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende der Beschäftigung wegen Tod
        /// </summary>
        [Fact(DisplayName = "Abmeldung 49: Ende der Beschäftigung wegen Tod")]
        public void TestDEUEVMeldung49_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev49_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "49"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "49")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109,
                            110, 111,  113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel der Krankenkasse bei fortbestehendem Beschäftigungsverhältnis
        /// </summary>
        [Fact(DisplayName = "Abmeldung 31: Wechsel der Krankenkasse bei fortbestehendem Beschäftigungsverhältnis")]
        public void TestDEUEVMeldung31_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev31_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "31"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "31")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel der Beitragsgruppe bei fortbestehendem Beschäftigungsverhältnis
        /// </summary>
        [Fact(DisplayName = "Abmeldung 32: Wechsel der Beitragsgruppe bei fortbestehendem Beschäftigungsverhältnis")]
        public void TestDEUEVMeldung32_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev32_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "32"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "32")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 114, 118, 119, 121, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende der Beschäftigung bei einer sich anschließenden Berufsausbildung
        /// (beim gleichen Arbeitgeber ohne Krankenkassenwechsel und/oder ggf. ohne Beitragsgruppenwechsel)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 33: Ende der Beschäftigung bei einer sich anschließenden Berufsausbildung (gleicher Arbeitgeber)")]
        public void TestDEUEVMeldung33_1()
        {
             var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev33_1.dat");
             Assert.True(deuevMessage.DSME.Exists(x => x.GD == "33"));
             foreach (var dsme in deuevMessage.DSME)
             {
                if (dsme.GD == "33")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 104, 105, 106, 107, 111, 112, 113, 114, 123, 114, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
             }
        }

        /// <summary>
        /// Ende der geringfügigen Beschäftigung bei einer sich anschließenden Berufsausbildung (ohne Arbeitgeberwechsel)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 31: Ende der geringfügigen Beschäftigung bei einer sich anschließenden Berufsausbildung (ohne Arbeitgeberwechsel)")]
        public void TestDEUEVMeldung31_2()
        {
             var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev31_2.dat");
             Assert.True(deuevMessage.DSME.Exists(x => x.GD == "31"));
             foreach (var dsme in deuevMessage.DSME)
             {
                if (dsme.GD == "31")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 109, 110, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
             }
        }

        /// <summary>
        /// Ende der Berufsausbildung bei einer sich anschließenden Beschäftigung
        /// (beim gleichen Arbeitgeber ohne Krankenkassenwechsel und/oder ohne Beitragsgruppenwechsel)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 33: Ende der Berufsausbildung bei einer sich anschließenden Beschäftigung" +
            "(beim gleichen Arbeitgeber ohne Krankenkassenwechsel und/oder ohne Beitragsgruppenwechsel)")]
        public void TestDEUEVMeldung33_2()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev33_2.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "33"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "33")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 102, 121, 122 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende der Berufsausbildung bei einer sich anschließenden
        /// geringfügigen Beschäftigung (ohne Arbeitgeberwechsel)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 31: Ende der Berufsausbildung bei einer sich anschließenden geringfügigen Beschäftigung (ohne Arbeitgeberwechsel)")]
        public void TestDEUEVMeldung31_3()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev31_3.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "31"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "31")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 102, 121, 122 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende einer geringfügigen Beschäftigung bei einer sich anschließenden
        /// versicherungspflichtigen Beschäftigung (ohne Arbeitgeberwechsel)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 31: Ende einer geringfügigen Beschäftigung bei einer sich anschließenden versicherungspflichtigen Beschäftigung (ohne Arbeitgeberwechsel)")]
        public void TestDEUEVMeldung31_4()
        {
             var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev31_4.dat");
             Assert.True(deuevMessage.DSME.Exists(x => x.GD == "31"));
             foreach (var dsme in deuevMessage.DSME)
             {
                if (dsme.GD == "31")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 109, 110, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
             }
        }

        /// <summary>
        /// Ende einer versicherungspflichtigen Beschäftigung bei einer sich anschließenden
        /// geringfügigen Beschäftigung (ohne Arbeitgeber-/Krankenkassenwechsel)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 31: Ende einer versicherungspflichtigen Beschäftigung bei einer sich anschließenden geringfügigen Beschäftigung (ohne Arbeitgeber-/Krankenkassenwechsel)")]
        public void TestDEUEVMeldung31_5()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev31_5.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "31"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "31")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 103, 104, 105, 106, 107, 111, 112, 113, 114, 116, 118, 119, 123, 124, 127 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel in der Art der geringfügigen Beschäftigung
        /// (§ 8 Abs. 1 Nr. 1 SGB IV nach § 8 Abs. 1 Nr. 2 SGB IV oder umgekehrt)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 32: Wechsel in der Art der geringfügigen Beschäftigung (§ 8 Abs. 1 Nr. 1 SGB IV nach § 8 Abs. 1 Nr. 2 SGB IV oder umgekehrt)")]
        public void TestDEUEVMeldung32_2()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev32_2.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "32"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "32")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 109, 110, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beendigung einer Beschäftigung bei Wechsel von einer Betriebsstätte
        /// im Beitrittsgebiet zu einer Betriebsstätte im übrigen Bundesgebiet
        /// oder umgekehrt (ohne Arbeitgeber-/Krankenkassenwechsel)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 33: Beendigung einer Beschäftigung bei Wechsel von einer Betriebsstätte im Beitrittsgebiet" +
        "zu einer Betriebsstätte im übrigen Bundesgebiet oder umgekehrt (ohne Arbeitgeber-/Krankenkassenwechsel)")]
        public void TestDEUEVMeldung33_3()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev33_3.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "33"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "33")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 111, 112, 113, 114, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Verzicht eines geringfügig entlohnten Beschäftigten nach § 8 Abs. 1 Nr. 1 SGB IV
        /// auf die Rentenversicherungsfreiheit nach § 5 Abs. 2 Satz 2 SGB VI
        /// </summary>
        [Fact(DisplayName = "Abmeldung 32: Verzicht eines geringfügig entlohnten Beschäftigten nach § 8 Abs. 1 Nr. 1 SGB IV auf die Rentenversicherungsfreiheit nach § 5 Abs. 2 Satz 2 SGB VI")]
        public void TestDEUEVMeldung32_3()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev32_3.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "32"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "32")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 109 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel des Entgeltabrechnungssystems
        /// </summary>
        [Fact(DisplayName = "Abmeldung 36: Wechsel des Entgeltabrechnungssystems")]
        public void TestDEUEVMeldung36_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev36_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "36"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "36")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 111,
                            112, 113, 114, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende einer sozialversicherungsrechtlichen Beschäftigung beim
        /// selben Arbeitgeber auf Grund einer Aussteuerung (= Ende des
        /// Krankengeldbezuges wegen Erreichens der Höchstbezugsdauer des
        /// Krankengeldes nach § 48 Abs. 1 SGB V) Arbeitsverhältnis beim
        /// Arbeitgeber wurde noch nicht beendet; in diesem Fall endet das
        /// Versicherungsverhältnis nach Ablauf eines Monats nach dem Ende des
        /// Krankengeldbezuges (vgl. § 7 Abs. 3 SGB IV)
        /// </summary>
        [Fact(DisplayName = "Abmeldung 34: Ende einer sozialversicherungsrechtlichen Beschäftigung beim" +
        "selben Arbeitgeber auf Grund einer Aussteuerung, Arbeitsverhältnis wurde noch nicht beendet")]
        public void TestDEUEVMeldung34_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev34_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "34"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "34")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 107, 112, 113, 114, 118, 121, 122, 123, 124, 127 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende einer sozialversicherungsrechtlichen Beschäftigung
        /// beim selben Arbeitgeber auf Grund einer Zubilligung einer
        /// Rente wegen verminderter Erwerbstätigkeit
        /// Arbeitsverhältnis beim Arbeitgeber wurde während
        /// der Monatsfrist nach § 7 Abs. 3 SGB IV nach dem Eingang
        /// des Bescheides über die Rentenbewilligung beendet
        /// In diesem Fall endet das Versicherungsverhältnis mit dem Tag der
        /// Beendigung des Beschäftigungsverhältnisses.
        /// </summary>
        [Fact(DisplayName = "Anmeldung 34: Ende einer sozialversicherungsrechtlichen Beschäftigung" +
        "beim selben Arbeitgeber auf Grund einer Zubilligung einer" +
        "Rente wegen verminderter Erwerbstätigkeit")]
        public void TestDEUEVMeldung34_2()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev34_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "34"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "34")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 107, 112, 113, 114, 118, 121, 122, 123, 124, 127 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende einer sozialversicherungsrechtlichen Beschäftigung
        /// beim selben Arbeitgeber auf Grund einer Aussteuerung
        /// (= Ende des Krankengeldbezuges wegen Erreichens der
        /// Höchstbezugsdauer des Krankengeldes nach § 48 Abs. 1 SGB V)
        /// Beschäftigungsverhältnis wird sozialversicherungsrechtlich
        /// durch den Bezug von Arbeitslosengeld nach § 145 Abs. 1 SGB III
        /// nach dem Ende des Krankengeldbezuges beendet.
        /// </summary>
        [Fact(DisplayName = "Abmeldung 30: Ende einer sozialversicherungsrechtlichen Beschäftigung beim" +
        "selben Arbeitgeber auf Grund einer Aussteuerung")]
        public void TestDEUEVMeldung30_3()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev30_3.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "30"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "30")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 107, 112, 113, 114, 118, 121, 122, 123, 124, 127 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Wechsel der berufsständischen Versorgungseinrichtung
        /// bei fortbestehendem Beschäftigungsverhältnis
        /// </summary>
        [Fact(DisplayName = "Abmeldung 33: Wechsel der berufsständischen Versorgungseinrichtung bei fortbestehendem Beschäftigungsverhältnis")]
        public void TestDEUEVMeldung33_4()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev33_4.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "33"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "33")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 111,
                            112, 113, 114, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Beschäftigungszeit und Arbeitsentgelt im vorangegangenen Kalenderjahr
        /// </summary>
        [Fact(DisplayName = "Jahresmeldung 50: Beschäftigungszeit und Arbeitsentgelt im vorangegangenen Kalenderjahr")]
        public void TestDEUEVMeldung50_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev50_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "50"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "50")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111,
                            113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Einmalig gezahltes, nicht ausschließlich in der Unfallversicherung beitragspflichtiges
        /// Arbeitsentgelt als Sondermeldung (z.B. in beitragsfreien Zeiten)
        /// </summary>
        [Fact(DisplayName = "Sondermeldung 54: Einmalig gezahltes, nicht ausschließlich in der Unfallversicherung" +
        "beitragspflichtiges Arbeitsentgelt als Sondermeldung (z.B. in beitragsfreien Zeiten)")]
        public void TestDEUEVMeldung54_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev54_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "54"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "54")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 111,
                            112, 113, 114, 118, 119, 121, 122, 123, 124, 127 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Einmalig gezahltes, ausschließlich in der Unfallversicherung
        /// beitragspflichtiges Arbeitsentgelt als Sondermeldung
        /// </summary>
        [Fact(DisplayName = "Sondermeldung 91:  Einmalig gezahltes, ausschließlich in der Unfallversicherung" +
        "beitragspflichtiges Arbeitsentgelt als Sondermeldung")]
        public void TestDEUEVMeldung91_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev91_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "91"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "91")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 110,
                            112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// "Gesonderte Meldung über die beitragspflichtigen Einnahmen vor Rentenbeginn nach § 194 Abs. 1 SGB VI
        /// Auf Verlangen des Rentenantragsstellers ist eine ""Gesonderte Meldung"" über die beitragspflichtigen
        /// Einnahmen frühestens drei Monate vor Rentenbeginn zu erstatten"
        /// </summary>
        [Fact(DisplayName = "Sondermeldung 57: Gesonderte Meldung über die beitragspflichtigen Einnahmen vor Rentenbeginn nach § 194 Abs. 1 SGB VI")]
        public void TestDEUEVMeldung57_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev57_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "57"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "57")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 111, 112,
                            113, 114, 116, 118, 119, 121, 122, 123, 124, 127 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Unterbrechung der Beschäftigung ohne Fortzahlung des Arbeitsentgelts
        /// von länger als einem Monat; z.B. wegen unbezahltem Urlaub
        /// </summary>
        [Fact(DisplayName = "Abmeldung 34: Unterbrechung der Beschäftigung ohne Fortzahlung des Arbeitsentgelts" +
        "von länger als einem Monat; z.B. wegen unbezahltem Urlaub")]
        public void TestDEUEVMeldung34_3()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev34_3.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "34"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "34")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 110, 112,
                            113, 114, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Unterbrechung der Beschäftigung ohne Fortzahlung des
        /// Arbeitsentgelts wegen Arbeitskampf von länger als einem Monat
        /// </summary>
        [Fact(DisplayName = "Abmeldung 35: Unterbrechung der Beschäftigung ohne Fortzahlung des" +
        "Arbeitsentgelts wegen Arbeitskampf von länger als einem Monat")]
        public void TestDEUEVMeldung35_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev35_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "35"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "35")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 105, 106, 107, 109, 112, 113,
                            114, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Unterbrechung einer geringfügig entlohnten Beschäftigung oder einer kurzfristigen
        /// Beschäftigung auf der Basis eines Rahmenarbeitsvertrages ohne Fortzahlung des
        /// Arbeitsentgelts von länger als einem Monat wegen Arbeitsunfähigkeit
        /// </summary>
        [Fact(DisplayName = "Abmeldung 34: Unterbrechung einer geringfügig entlohnten Beschäftigung oder einer kurzfristigen" +
        "Beschäftigung auf der Basis eines Rahmenarbeitsvertrages ohne Fortzahlung des" +
        "Arbeitsentgelts von länger als einem Monat wegen Arbeitsunfähigkeit")]
        public void TestDEUEVMeldung34_4()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev34_4.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "34"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "34")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 109, 110, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Unterbrechung der Beschäftigung ohne Fortzahlung des Arbeitsentgelts
        /// für mindestens einen Kalendermonat aufgrund eines Tatbestandes
        /// nach § 7 Abs. 3 Satz 3 SGB IV (außer Elternzeit oder gesetzl. Dienstpflicht).
        /// </summary>
        [Fact(DisplayName = "Unterbrechungsmeldung 51: Unterbrechung der Beschäftigung ohne Fortzahlung des Arbeitsentgelts" +
        "für mindestens einen Kalendermonat aufgrund eines Tatbestandes" +
        "nach § 7 Abs. 3 Satz 3 SGB IV (außer Elternzeit oder gesetzl. Dienstpflicht).")]
        public void TestDEUEVMeldung51_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev51_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "51"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "51")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 112, 113,
                            114, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Unterbrechung der Beschäftigung ohne Fortzahlung des Arbeitsentgelts
        /// für mindestens einen Kalendermonat aufgrund eines Tatbestandes
        /// nach § 7 Abs. 3 Satz 3 SGB IV (außer Elternzeit oder gesetzl. Dienstpflicht).
        /// </summary>
        [Fact(DisplayName = "Unterbrechungsmeldung 52: Unterbrechung der Beschäftigung ohne Fortzahlung des Arbeitsentgelts" +
        "für mindestens einen Kalendermonat aufgrund eines Tatbestandes" +
        "nach § 7 Abs. 3 Satz 3 SGB IV (außer Elternzeit oder gesetzl. Dienstpflicht).")]
        public void TestDEUEVMeldung52_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev52_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "52"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "52")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 112,
                            113, 114, 119, 121, 122, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ende des Arbeitsverhältnisses während einer gemeldeten Unterbrechung
        /// </summary>
        [Fact(DisplayName = "Abmeldung 30: Ende des Arbeitsverhältnisses während einer gemeldeten Unterbrechung")]
        public void TestDEUEVMeldung30_4()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev30_4.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "30"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "30")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 109, 112,
                            113, 114, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Weiterbeschäftigung/Anmeldung nach Eröffnung des Insolvenzverfahrens oder Abweisung mangels Masse
        /// mit Verwendung einer neuen Betriebsnummer
        /// </summary>
        [Fact(DisplayName = "Abmeldung 10: Weiterbeschäftigung/Anmeldung nach Eröffnung des Insolvenzverfahrens" +
        "oder Abweisung mangels Masse mit Verwendung einer neuen Betriebsnummer")]
        public void TestDEUEVMeldung10_6()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev10_6.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "10"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "10")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 105, 106, 109, 112, 113, 114,
                            118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Weiterbeschäftigung/Abmeldung nach Eröffnung des Insolvenzverfahrens oder Abweisung mangels Masse
        /// wenn neue Betriebsnummer verwendet wird
        /// </summary>
        [Fact(DisplayName = "Abmeldung 30: Weiterbeschäftigung/Abmeldung nach Eröffnung des Insolvenzverfahrens" +
        "oder Abweisung mangels Masse wenn neue Betriebsnummer verwendet wird")]
        public void TestDEUEVMeldung30_5()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev30_5.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "30"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "30")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 105, 106, 109, 112, 113, 114,
                            118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Weiterbeschäftigung/Abmeldung nach Eröffnung des Insolvenzverfahrens oder Abweisung mangels Masse
        /// wenn bisherige Betriebsnummer weiter verwendet wird
        /// </summary>
        [Fact(DisplayName = "Abmeldung 33: Weiterbeschäftigung/Abmeldung nach Eröffnung des Insolvenzverfahrens" +
        "oder Abweisung mangels Masse wenn bisherige Betriebsnummer weiter verwendet wird")]
        public void TestDEUEVMeldung33_5()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev33_5.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "33"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "33")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 105, 106, 109, 112, 113, 114,
                            118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.NotNull(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Änderung des Namens eines Beschäftigten
        /// </summary>
        [Fact(DisplayName = "Änderungsmeldung 60: Änderung des Namens eines Beschäftigten")]
        public void TestDEUEVMeldung60_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev60_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "60"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "60")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111,
                            113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.Null(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.Null(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Änderung der Anschrift eines Beschäftigten
        /// </summary>
        [Fact(DisplayName = "Änderungsmeldung 61: Änderung der Anschrift eines Beschäftigten")]
        public void TestDEUEVMeldung61_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev61_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "61"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "61")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112,
                            113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.Null(dsme.DBME);
                    Assert.Null(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Änderung der Staatsangehörigkeit
        /// </summary>
        [Fact(DisplayName = "Änderungsmeldung 63: Änderung der Staatsangehörigkeit")]
        public void TestDEUEVMeldung63_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev63_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "63"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "63")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112,
                            113, 114, 116, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.Null(dsme.DBME);
                    Assert.Null(dsme.DBNA);
                    Assert.Null(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Sofortmeldung für Beschäftigte, VSNR ist bekannt
        /// </summary>
        [Fact(DisplayName = "Sofortmeldung 20: Sofortmeldung für Beschäftigte, VSNR ist bekannt")]
        public void TestDEUEVMeldung20_1()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev20_1.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "20"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "20")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 105, 106, 109, 110, 112, 113,
                            114, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.Null(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.Null(dsme.DBAN);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.NotNull(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Sofortmeldung für Beschäftigte, VSNR ist bekannt
        /// </summary>
        [Fact(DisplayName = "Sofortmeldung 20: Sofortmeldung für Beschäftigte, VSNR ist nicht bekannt")]
        public void TestDEUEVMeldung20_2()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev20_2.dat");
            Assert.True(deuevMessage.DSME.Exists(x => x.GD == "20"));
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "20")
                {
                    Assert.Contains(
                        dsme.PERSGR,
                        new List<int> { 101, 102, 103, 105, 106, 109, 110, 112, 113,
                            114, 118, 119, 121, 122, 123, 124, 127, 190 });
                    Assert.Null(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.NotNull(dsme.DBGB);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.NotNull(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    Assert.Null(dsme.DBEU);
                }
            }
        }

        /// <summary>
        /// Ruft die Meldedatei mit einem bestimmten Dateinamen aus dem Deuev-Ordner ab
        /// </summary>
        /// <param name="fileName">
        /// Dateiname der Meldedatei
        /// </param>
        /// <returns>
        /// Meldedatei als DeuevMessageData-Objekt
        /// </returns>
        private DeuevMessageData GetAndCheckDeuevMessageFromFile(string fileName)
        {
            var input = LoadData(fileName).ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("dsme-deuev", output);
            var reader = StreamFactory.CreateReader("dsme-deuev", new StringReader(input));
            var deuevMessage = new DeuevMessageData();
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                deuevMessage.VOSZ = new List<VOSZ> { vosz };
                writer.Write(vosz);
                streamObject = reader.Read();
                if (streamObject is VOSZ)
                {
                    deuevMessage.VOSZ.Add(streamObject as VOSZ);
                    writer.Write(vosz);
                    streamObject = reader.Read();
                }

                var dsko = Assert.IsType<DSKO>(streamObject);
                deuevMessage.DSKO = dsko;
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                deuevMessage.DSME = new List<DSME> { dsme };
                writer.Write(dsme);
                while (true)
                {
                    streamObject = reader.Read();
                    if (streamObject is NCSZ)
                    {
                        writer.Write(streamObject);
                        deuevMessage.NCSZ = new List<NCSZ> { streamObject as NCSZ };
                        streamObject = reader.Read();
                        if (streamObject is NCSZ)
                        {
                            deuevMessage.NCSZ.Add(streamObject as NCSZ);
                            writer.Write(streamObject);
                        }

                        break;
                    }
                    else
                    {
                        Assert.IsType<DSME>(streamObject);
                        deuevMessage.DSME.Add(streamObject as DSME);
                    }

                    writer.Write(streamObject);
                }

                writer.Close();
                Assert.Equal(input, output.ToString());
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
        private class DeuevMessageData
        {
            public List<VOSZ> VOSZ { get; set; }

            public DSKO DSKO { get; set; }

            public List<DSME> DSME { get; set; }

            public List<NCSZ> NCSZ { get; set; }
        }
    }
}
