using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSKK - Datensatz Krankenkassenmeldung
    /// </summary>
    public class DSKK : IDatensatz
    {
        private bool? _hatDbmm;

        private bool? _hatDbms;

        private bool? _hatDbgz;

        private bool? _hatDbbg;

        private bool? _hatDbna;

        private bool? _hatDbgb;

        private bool? _hatDban;

        private FehlerKennzeichen? _fekz;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSKK"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt
        /// </remarks>
        public DSKK()
        {
            KE = "DSME";
            VF = "DEUEV";
            VERNR = 1;
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5, Mussangabe
        /// DEUEV = DEÜV- Meldeverfahren
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers des Datensatzes
        /// </summary>
        /// <remarks>
        ///  Betriebsnummer des Erstellers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        public string BBNREP { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des übermittelten Datensatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des übermittelten Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public int VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Dateznsatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennzeichnung für fehlerhafte Datensätze
        /// </summary>
        /// <remarks>
        /// Kennzeichnung für fehlerhafte Datensätze, Länge 1, 0 = Datensatz fehlerfrei 1 = Datensatz fehlerhaft, Mussangabe
        /// </remarks>
        public FehlerKennzeichen FEKZ
        {
            get { return _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft); }
            set { _fekz = value; }
        }

        /// <summary>
        /// Holt die Anzahl der Fehler des Datensatzes
        /// </summary>
        /// <remarks>
        /// Anzahl der Fehler des Datensatzes, Länge 1, Mussangabe
        /// </remarks>
        public int FEAN
        {
            get { return DBFE == null ? 0 : DBFE.Count; }
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Versicherungsnummer in der Form: bbttmmjjassp, Länge 12, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string VSNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Meldegrund
        /// </summary>
        /// <remarks>
        /// Meldegrund, Länge 2, Mussangabe
        /// 10 = Beginn, 30 = Ende, 40 = Beginn und Ende
        /// </remarks>
        public int MG { get; set; }

        /// <summary>
        /// Holt oder setzt ein der Krankenkasse zur Verfügung stehendes Feld
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht der Krankenkasse zur Verfügung, Länge 20, Kannangabe
        /// </remarks>
        public string AZKK { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Beschäftigungsbetriebes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Beschäftigungsbetriebes (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// Entspricht der Betriebsnummer aus dem Feld BBNR-VU des DSME der Anmeldung oder der GKV-Monatsmeldung des Arbeitgebers
        /// </remarks>
        public string BBNRAG { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Aktenzeichen Arbeitgeber, Länge 20, Pflichtangabe, soweit bekannt
        /// Sofern der Arbeitgeber in einer GKVMonatsmeldung im DSME im Feld Aktenzeichen-Verursacher (AZ-VU) ein
        /// Aktenzeichen bzw. eine Personalnummer des / der Beschäftigten angegeben hat, ist diese hier zurück zu melden
        /// </remarks>
        public string AZAG { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Abrechnungsstelle (z
        /// B. Steuerberater - 8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt den Abgabegrund
        /// </summary>
        /// <remarks>
        /// Grund der Abgabe, Länge 2, Mussangabe
        /// 01 = Mitteilung über weitere beitragspflichtige Einnahmen, 02 = Prüfergebnis Sozialausgleich
        /// 03 = Prüfergebnis Gleitzone, 04 = Prüfergebnis Beitragsbemessungsgrenze
        /// </remarks>
        public int GD { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein GKV-Monatsmeldung vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBMM, Länge 1, Mussangabe
        /// Meldesachverhalt GKVMonatsmeldung vorhanden:
        /// N = keine Meldesachverhaltsdaten, J = Meldesachverhaltsdaten vorhanden
        /// </remarks>
        public bool MMMM
        {
            get { return _hatDbmm ?? DBMM != null; }
            set { _hatDbmm = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Sozialausgleich vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBMS, Länge 1, Mussangabe
        /// Meldesachverhalt Sozialausgleichvorhanden:
        /// N = keine Meldesachverhaltsdaten, J = Meldesachverhaltsdaten vorhanden
        /// </remarks>
        public bool MMMS
        {
            get { return _hatDbms ?? DBMS != null; }
            set { _hatDbms = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Gleitzone vorhanden
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBGZ, Länge 1, Mussangabe
        /// Meldesachverhalt Gleitzone vorhanden:
        /// N = keine Meldesachverhaltsdaten, J = Meldesachverhaltsdaten vorhanden
        /// </remarks>
        public bool MMMZ
        {
            get { return _hatDbgz ?? DBGZ != null; }
            set { _hatDbgz = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Beitragsbemessungsgrenze vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBBG, Länge 1, Mussangabe
        /// Meldesachverhalt Beitragsbemessungsgrenze vorhanden:
        /// N = keine Meldesachverhaltsdaten, J = Meldesachverhaltsdaten vorhanden
        /// </remarks>
        public bool MMMG
        {
            get { return _hatDbbg ?? DBBG != null; }
            set { _hatDbbg = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Name vorhanden ist
        /// </summary>
        /// <remarks>
        /// Name vorhanden, Länge 1, Mussangabe
        /// N = keine Namensdaten
        /// J = Namensdaten vorhanden
        /// </remarks>
        public bool MMNA
        {
            get { return _hatDbna ?? DBAN != null; }
            set { _hatDbna = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Geburtsangaben vorhanden ist
        /// </summary>
        /// <remarks>
        /// Geburtsangaben vorhanden, Länge 1, Mussangabe
        /// N = keine Geburtsangaben
        /// J = Geburtsangaben vorhanden
        /// </remarks>
        public bool MMGB
        {
            get { return _hatDbgb ?? DBGB != null; }
            set { _hatDbgb = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Anschrift vorhanden ist
        /// </summary>
        /// <remarks>
        /// Anschrift vorhanden:, Länge 1, Mussangabe
        /// N = keine Anschrift
        /// J = Anschrift vorhanden
        /// </remarks>
        public bool MMAN
        {
            get { return _hatDban ?? DBAN != null; }
            set { _hatDban = value; }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für GVK Monatsmeldung
        /// </summary>
        public DBMM DBMM
        {
            get
            {
                return ListeDBMM == null ? null : ListeDBMM.SingleOrDefault();
            }
            set
            {
                ListeDBMM = ListeDBMM.Set(value);
                _hatDbmm = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Sozialausgleich
        /// </summary>
        public DBMS DBMS
        {
            get
            {
                return ListeDBMS == null ? null : ListeDBMS.SingleOrDefault();
            }
            set
            {
                ListeDBMS = ListeDBMS.Set(value);
                _hatDbms = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Gleitzone
        /// </summary>
        public DBGZ DBGZ
        {
            get
            {
                return ListeDBGZ == null ? null : ListeDBGZ.SingleOrDefault();
            }
            set
            {
                ListeDBGZ = ListeDBGZ.Set(value);
                _hatDbgz = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Beitragsbemessungsgrenze
        /// </summary>
        public DBBG DBBG
        {
            get
            {
                return ListeDBBG == null ? null : ListeDBBG.SingleOrDefault();
            }
            set
            {
                ListeDBBG = ListeDBBG.Set(value);
                _hatDbbg = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Holt oder setzt den Datenbaustein für Name
        /// </summary>
        public DBNA DBNA
        {
            get
            {
                return ListeDBNA == null ? null : ListeDBNA.SingleOrDefault();
            }
            set
            {
                ListeDBNA = ListeDBNA.Set(value);
                _hatDbna = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Geburtsangaben
        /// </summary>
        public DBGB DBGB
        {
            get
            {
                return ListeDBGB == null ? null : ListeDBGB.SingleOrDefault();
            }
            set
            {
                ListeDBGB = ListeDBGB.Set(value);
                _hatDbgb = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Anschrift
        /// </summary>
        public DBAN DBAN
        {
            get
            {
                return ListeDBAN == null ? null : ListeDBAN.SingleOrDefault();
            }
            set
            {
                ListeDBAN = ListeDBAN.Set(value);
                _hatDban = null;
            }
        }

        /// <summary>
        /// Holt oder setzt eine Liste von Fehlern
        /// </summary>
        public IList<DBFE> DBFE { get; set; }

        private IList<DBMM> ListeDBMM { get; set; }

        private IList<DBMS> ListeDBMS { get; set; }

        private IList<DBGZ> ListeDBGZ { get; set; }

        private IList<DBBG> ListeDBBG { get; set; }

        private IList<DBNA> ListeDBNA { get; set; }

        private IList<DBGB> ListeDBGB { get; set; }

        private IList<DBAN> ListeDBAN { get; set; }
    }
}
