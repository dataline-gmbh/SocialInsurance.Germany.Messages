using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSME - Meldung
    /// </summary>
    public class DSME : IDatensatz
    {
        private bool? _hatDbme;

        private bool? _hatDbna;

        private bool? _hatDbgb;

        private bool? _hatDban;

        private bool? _hatDbeu;

        private bool? _hatDbuv;

        private bool? _hatDbks;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSME"/> Klasse.
        /// </summary>
        public DSME()
        {
            KE = "DSME";
        }

        /// <summary>
        /// KENNUNG KE, Kennung, Stellen 001-004, Mussangabe
        /// </summary>
        public string KE { get; set; }

        /// <summary>
        /// VERFAHREN VF, Verfahren, für das der Datensatz bestimmt ist, Stellen 005-009, DEUEV = DEÜV- Meldeverfahren RVSNR = Rückmeldung der Versicherungsnummer an den Arbeitgeber, Mussangabe
        /// </summary>
        public string Verfahren { get; set; }

        /// <summary>
        /// BBNR-ABSENDER BBNRAB, Betriebsnummer des Erstellers des Datensatzes, Stellen 010-024, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </summary>
        public string BetriebsnummerAbsender { get; set; }

        /// <summary>
        /// BBNR-EMPFAENGER BBNRAB, Betriebsnummer des Empfängers des Datensatzes, Stellen 025-039, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </summary>
        public string BetriebsnummerEmpfänger { get; set; }

        /// <summary>
        /// VERSIONS-NR VERNR, Versionsnummer des übermittelten Datensatzes, Stellen 040-041, Mussangabe
        /// </summary>
        public string Versionsnummer { get; set; }

        /// <summary>
        /// DATUM-ERSTELLUNG ED, Zeitpunkt der Erstellung des Datensatzes, Stellen 042-061, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </summary>
        public DateTime Datumerstellung { get; set; }

        /// <summary>
        /// FEHLER-KENNZ FEKZ, Kennzeichnung für fehlerhafte Datensätze, Stellen 062-062, 0 = Datensatz fehlerfrei 1 = Datensatz fehlerhaft, Mussangabe
        /// </summary>
        public string Fehlerkennzeichnung { get; set; }

        /// <summary>
        /// FEHLER-ANZAHL FEAN, Anzahl der Fehler des Datensatzes, Stellen 063-063, Mussangabe
        /// </summary>
        public string Fehleranzahl { get; set; }

        // Daten zur Identifikation

        /// <summary>
        /// VSNR VSNR, Versicherungsnummer in der Form: bbttmmjjassp, Stellen 064-075, Pflichtangabe, soweit bekannt
        /// </summary>
        public string Versicherungsnummer { get; set; }

        /// <summary>
        /// RESERVE, Reservefeld, Stellen 076-077, Mussangabe
        /// </summary>
        public string Reservefeld { get; set; }

        /// <summary>
        /// BBNR-VU BBNRVU, Betriebsnummer des Verursachers des Datensatzes, Stellen 078-092, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// Bei der Datenübermittlung zwischen dem Arbeitgeber
        /// und der Datenannahmestelle ist hier die Betriebsnummer
        /// des Beschäftigungsbetriebes anzugeben. 
        /// </summary>
        public string BetriebsnummerVerursacher { get; set; }

        /// <summary>
        /// AKTENZEICHEN-VERURSACHER AZ-VU, Dieses Feld steht dem Verursacher zur Verfügung, Stellen 093-112, Kannangabe
        /// Bei der Datenübermittlung zwischen dem Arbeitgeber
        /// und der Datenannahmestelle: z. B. Aktenzeichen / Personalnummer
        /// des Beschäftigten 
        /// </summary>
        public string AktenzeichenVerursacher { get; set; }

        /// <summary>
        /// BBNR-KK BBNRKK, Betriebsnummer, Stellen 113-127, Mussangabe
        /// Betriebsnummer der für den Beschäftigten zuständigen
        /// Einzugsstelle oder der berufsständischen Versorgungseinrichtung.
        /// Bei Sofortmeldungen ist die Betriebsnummer
        /// der Datenstelle der Träger der Rentenversicherung
        /// anzugeben. (8 Stellen linksbündig mit nachfolgenden Leerzeichen) 
        /// </summary>
        public string BetriebsnummerKK { get; set; }

        /// <summary>
        /// AKTENZEICHEN-KK AZ-KK, Dieses Feld steht der Einzugsstelle zur Verfügung, Stellen 128-147, Kannangabe
        /// Bei Meldungen nach § 28a Abs. 10 SGB IV an die Datenannahmestelle
        /// der berufsständischen Versorgungseinrichtungen
        /// ist hier die Mitgliedsnummer des Beschäftigten
        /// bei der Versorgungseinrichtung anzugeben. 
        /// </summary>
        public string AktenzeichenKK { get; set; }

        /// <summary>
        /// BBNR-ABRECHNUNGSSTELLE BBNRAS, Betriebsnummer der Abrechnungsstelle, Stellen 148-162, Pflichtangabe, soweit bekannt
        ///  (z.B. Steuerberater - 8 Stellen linksbündig mit nachfolgenden Leerzeichen)
        /// </summary>
        public string BetriebsnummerAbrechnungsstelle { get; set; }

        /// <summary>
        /// PERSONENGRUPPE PERSGR, Personengruppe, Stellen 163-165, Mussangabe
        /// </summary>
        public string Personengruppe { get; set; }

        /// <summary>
        /// ABGABEGRUND GD, Grund der Abgabe, Stellen 166-167, Mussangabe
        /// </summary>
        public string Abgabegrund { get; set; }

        /// <summary>
        /// STAATSANGEHOERIGKEITS-SC SASC, Staatsangehörigkeitsschlüssel des statistischen Bundesamtes, Stellen 168-170, Mussangabe unter Bedingungen
        /// </summary>
        public string Staatsangehörigkeitsschlüssel { get; set; }

        // Kennzeichen, ob Datenbausteine für den Arbeitgeber und die Sozialversicherung vorhanden sind 

        /// <summary>
        /// MM-MELDEDATEN MMME, Datenbaustein DBME, Stellen 171-171, Mussangabe
        /// Meldesachverhalt vorhanden:
        /// N = keine Meldesachverhaltsdaten
        /// J = Meldesachverhaltsdaten vorhanden
        /// </summary>
        public bool HatMeldesachverhalt
        {
            get { return _hatDbme ?? Meldesachverhalt != null; }
            set { _hatDbme = value; }
        }

        /// <summary>
        /// MM-NAME MMNA, Datenbaustein DBNA, Stellen 172-172, Mussangabe
        /// Name vorhanden:
        /// N = keine Namensdaten
        /// J = Namensdaten vorhanden
        /// </summary>
        public bool HatName
        {
            get { return _hatDbna ?? Name != null; }
            set { _hatDbna = value; }
        }

        /// <summary>
        /// MM-GBNA MMGB, Datenbaustein DBGB, Stellen 173-173, Mussangabe
        /// Geburtsangaben vorhanden:
        /// N = keine Geburtsangaben
        /// J = Geburtsangaben vorhanden
        /// </summary>
        public bool HatGeburtsangaben
        {
            get { return _hatDbgb ?? Geburtsangaben != null; }
            set { _hatDbgb = value; }
        }

        /// <summary>
        /// MM-ANSCHRIFT MMAN, Datenbaustein DBAN, Stellen 174-174, Mussangabe
        /// Anschrift vorhanden:
        /// N = keine Anschrift
        /// J = Anschrift vorhanden
        /// </summary>
        public bool HatAnschrift
        {
            get { return _hatDban ?? Anschrift != null; }
            set { _hatDban = value; }
        }

        /// <summary>
        /// MM-EUDATEN MMEU, Datenbaustein DBEU, Stellen 175-175, Mussangabe
        /// Europäische VSNR vorhanden vorhanden:
        /// N = keine europäische VSNR
        /// J = europäische VSNR vorhanden
        /// </summary>
        public bool HatEuropäischeVersicherungsnummer
        {
            get { return _hatDbeu ?? EuropäischeVersicherungsnummer != null; }
            set { _hatDbeu = value; }
        }

        /// <summary>
        /// MM-UVDATEN MMUV, Datenbaustein DBUV, Stellen 176-176, Mussangabe
        /// Unfallversicherung vorhanden:
        /// N = keine Angaben zur Unfallversicherung
        /// J = Angaben zur Unfallversicherung
        /// </summary>
        public bool HatUnfallversicherung
        {
            get { return _hatDbuv ?? Unfallversicherung != null; }
            set { _hatDbuv = value; }
        }

        /// <summary>
        /// MM-KNV-SEE MMKS, Datenbaustein DBKS, Stellen 177-177, Mussangabe
        /// Knappschaft/See vorhanden:
        /// N = keine Knappschaft-/See-Daten
        /// J = Knappschafts-/See-Daten vorhanden
        /// </summary>
        public bool HatKnappschaftSee
        {
            get { return _hatDbks ?? KnappschaftSee != null; }
            set { _hatDbks = value; }
        }

        // Kennzeichen, ob zusätzliche Datenbausteine für die Sozialversicherung vorhanden sind
        // (bei der Datenübermittlung zwischen Arbeitgeber und Einzugsstelle ist hier jeweils nur „N“ zulässig) 

        /// <summary>
        /// MM-SVA MMSV, Datenbaustein DBSV, Stellen 178-178
        /// Sozialversicherungsausweis vorhanden:
        /// N = keine SVA-Daten
        /// J = SVA-Daten vorhanden
        /// </summary>
        public string MMSVA { get; set; }

        /// <summary>
        /// MM-VERGABE-RUECKMELDUNG MMVR, Datenbaustein DBVR, Stellen 179-179
        /// Vergabe/Rückmeldung vorhanden:
        /// N = keine Vergabe/Rückmeldedaten
        /// J = Vergabe/Rückmeldedaten vorhanden
        /// </summary>
        public string MMVergabeRückmeldung { get; set; }

        /// <summary>
        /// MM-RUECKMELDUNG-GERINGFUEGIG MMRG, Datenbaustein DBRG, Stellen 180-180
        /// Rückmeldung geringfügig Beschäftigte vorhanden:
        /// N = keine Rückmeldedaten
        /// J = Rückmeldedaten vorhanden
        /// </summary>
        public string MMRückmeldungGeringfügig { get; set; }

        // Sonstige Kennzeichen

        /// <summary>
        /// INTERN, Interne Kennzeichen der Sozialversicherungsträger, Stellen 181-183
        /// </summary>
        public string Intern1 { get; set; }

        /// <summary>
        /// MM-SOFORT MMSO, Datenbaustein DBSO, Stellen 184-184
        /// Sofortmeldung vorhanden:
        /// N = keine Sofortmeldung
        /// J = Sofortmeldung vorhanden
        /// </summary>
        public string MMSofort { get; set; }

        /// <summary>
        /// KENNZ-STATUS KENNZSTA, Statuskennzeichen für Ehegatte/Lebenspartner/ Abkömmling, Stellen 185-185
        /// 1 = Ehegatte/Lebenspartner/Abkömmling
        /// 2 = geschäftsführender Gesellschafter einer GmbH
        /// </summary>
        public string KennzeichenStatus { get; set; }

        /// <summary>
        /// RESERVE, Reservefelder für die Rentenversicherung, Stellen 186-186
        /// </summary>
        public string Reserve1 { get; set; }

        /// <summary>
        /// VERSIONS-NR-KP VERNRKP, Versionsnummer des Kernprüfungsprogramms, Stellen 187-188
        /// </summary>
        public string KPVersionsnummer { get; set; }

        /// <summary>
        /// MM-KVDATEN MMKV, Datenbaustein DBKV, Stellen 189-189
        /// Krankenversicherung vorhanden:
        /// N = keine Krankenversicherungsdaten vorhanden
        /// J = Krankenversicherungsdaten vorhanden
        /// </summary>
        public string MMKVDaten { get; set; }

        /// <summary>
        /// RESERVE, Reservefelder für die Rentenversicherung, Stellen 190-190, Mussangabe
        /// </summary>
        public string Reserve2 { get; set; }

        /// <summary>
        /// INTERN, Interne Kennzeichen der Sozialversicherungsträger, Stellen 191-210
        /// </summary>
        public string Intern2 { get; set; }

        /// <summary>
        /// NEBENVERSIONS-NR NEVERNR, Nebenversionsnummer des übermittelten Datensatzes, Stellen 211-212, Mussangabe
        /// </summary>
        public string Nebenversionsnummer { get; set; }

        /// <summary>
        /// PRODUKT-IDENTIFIER PROD-ID, Produkt-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird, Stellen 213-219, Mussangabe
        /// </summary>
        public string ProduktIdentifier { get; set; }

        /// <summary>
        /// MODIFIKATIONS-IDENTIFIER MOD-ID, Modifikations-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird, Stellen 220-227, Mussangabe
        /// Sie wird je geprüfter Produktversion von der ITSG vergeben
        /// </summary>
        public string ModifikationsIdentifier { get; set; }

        /// <summary>
        /// DATENSATZ-ID DS-ID, Datensatz-ID des übermittelten Datensatzes, Stellen 228-259, Pflichtangabe, soweit bekannt
        /// </summary>
        public string DatensatzID { get; set; }

        /// <summary>
        /// RESERVE, Reservefelder, Stellen 260-359, Mussangabe
        /// </summary>
        public string Reserve3 { get; set; }

        // Kennzeichen, ob Datenbausteine für den Arbeitgeber und die Sozialversicherung vorhanden sind

        /// <summary>
        /// RESERVE, Reservefelder, Stellen 360-459, Mussangabe
        /// </summary>
        public string Reserve4 { get; set; }

        /// <summary>
        /// RESERVE, Reservefelder, Stellen 360-459, Mussangabe
        /// </summary>
        public string Reserve5 { get; set; }

        /// <summary>
        /// Liste von DBNA (nur von BeanIO verwendet)
        /// </summary>
        private IList<DBME> ListeDBME { get; set; }

        public DBME Meldesachverhalt
        {
            get { return ListeDBME == null ? null : ListeDBME.SingleOrDefault(); }
            set
            {
                if (ListeDBME == null)
                {
                    ListeDBME = new List<DBME>();
                }
                else
                {
                    ListeDBME.Clear();
                }
                if (value != null)
                    ListeDBME.Add(value);
                _hatDban = null;
            }
        }

        private IList<DBNA> ListeDBNA { get; set; }

        public DBNA Name
        {
            get { return ListeDBNA == null ? null : ListeDBNA.SingleOrDefault(); }
            set
            {
                if (ListeDBNA == null)
                {
                    ListeDBNA = new List<DBNA>();
                }
                else
                {
                    ListeDBNA.Clear();
                }
                if (value != null)
                    ListeDBNA.Add(value);
                _hatDbna = null;
            }
        }

        private IList<DBGB> ListeDBGB { get; set; }

        public DBGB Geburtsangaben
        {
            get { return ListeDBGB == null ? null : ListeDBGB.SingleOrDefault(); }
            set
            {
                if (ListeDBGB == null)
                {
                    ListeDBGB = new List<DBGB>();
                }
                else
                {
                    ListeDBGB.Clear();
                }
                if (value != null)
                    ListeDBGB.Add(value);
                _hatDbgb = null;
            }
        }

        private IList<DBAN> ListeDBAN { get; set; }

        public DBAN Anschrift
        {
            get { return ListeDBAN == null ? null : ListeDBAN.SingleOrDefault(); }
            set
            {
                if (ListeDBAN == null)
                {
                    ListeDBAN = new List<DBAN>();
                }
                else
                {
                    ListeDBAN.Clear();
                }
                if (value != null)
                    ListeDBAN.Add(value);
                _hatDban = null;
            }
        }

        private IList<DBEU> ListeDBEU { get; set; }

        public DBEU EuropäischeVersicherungsnummer
        {
            get { return ListeDBEU == null ? null : ListeDBEU.SingleOrDefault(); }
            set
            {
                if (ListeDBEU == null)
                {
                    ListeDBEU = new List<DBEU>();
                }
                else
                {
                    ListeDBEU.Clear();
                }
                if (value != null)
                    ListeDBEU.Add(value);
                _hatDbeu = null;
            }
        }

        private IList<DBUV> ListeDBUV { get; set; }

        public DBUV Unfallversicherung
        {
            get { return ListeDBUV == null ? null : ListeDBUV.SingleOrDefault(); }
            set
            {
                if (ListeDBUV == null)
                {
                    ListeDBUV = new List<DBUV>();
                }
                else
                {
                    ListeDBUV.Clear();
                }
                if (value != null)
                    ListeDBUV.Add(value);
                _hatDbuv = null;
            }
        }

        private IList<DBKS> ListeDBKS { get; set; }

        public DBKS KnappschaftSee
        {
            get
            {
                return ListeDBKS == null ? null : ListeDBKS.SingleOrDefault();
            }
            set
            {
                ListeDBKS = ListeDBKS.Set(value);
                _hatDbks = null;
            }
        }
    }
}
