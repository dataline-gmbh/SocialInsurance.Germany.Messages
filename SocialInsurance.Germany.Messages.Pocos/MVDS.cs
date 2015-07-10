using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: MVDS - Datensatz Kommunikation
    /// </summary>    
    public class MVDS : IDatensatz
    {
        private bool? _hatDben;

        private bool? _hatDbna;

        private bool? _hatDbgb;

        private bool? _hatDban;

        private bool? _hatDbag;

        private bool? _hatDbab;

        private bool? _hatDbfz;

        private bool? _hatDbse;

        private bool? _hatDbsb;

        private bool? _hatDbas;

        private bool? _hatDbzd;

        private bool? _hatDbnb;

        private bool? _hatDbha;

        private bool? _hatDbke;

        private FehlerKennzeichen? _fekz;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSKO"/> Klasse.
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt.
        /// </remarks>
        public MVDS()
        {
            KE = "MVDS";
            VF = "ELENA";
            VERNR = 1;
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5, Mussangabe
        /// ELENA = Elektronischer Entgeltnachweis
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
        /// Holt oder setzt die Anzahl der Fehler des Datensatzes
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
        /// Holt oder setzt die Versicherungsnummer/Verfahrensnummer
        /// </summary>
        /// <remarks>
        /// Versicherungsnummer/Verfahrensnummer, Länge 12, Mussangabe
        /// </remarks>
        public string VSNRVFNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld 1
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 2, Mussangab
        /// </remarks>
        public string RESERVE1 { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Verursachers
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Verursachers des Datensatzes, Länge 15, Mussangabe 
        /// (8 Stellen linksbündig mit nachfolgenden Leerzeichen)
        /// Bei Meldungen zwischen dem Arbeitgeber und der ZSS ist hier
        /// die Betriebsnummer des Beschäftigungsbetriebes anzugeben.
        /// </remarks>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Dieses Feld steht dem Verursacher zur Verfügung
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht dem Verursacher zur Verfügung. Länge 20, Kannangabe
        /// Bei Meldungen zwischen dem Arbeitgeber und der ZSS:
        /// z. B. Aktenzeichen / Personalnummer des / der Beschäftigten
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der für den/die Beschäftigte(n) zuständigen Krankenkasse
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der für den / die Beschäftigte(n) zuständigen Krankenkasse, Länge 15, Mussangabe unter Bedingungen
        /// (8 Stellen linksbündig mit nachfolgenden Leerzeichen)
        /// </remarks>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen KK
        /// </summary>
        /// <remarks>
        /// entgällt hier, Grundstellung liefern, Länge 20, Mussangabe
        /// </remarks>
        public string AZKK { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Abrechnungsstelle (z.B. Steuerberater), Länge 15, Pflichtangabe, soweit bekannt
        /// 8 Stellen linksbündig mit nachfolgenden Leerzeichen 
        /// </remarks>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt die Personengruppe
        /// </summary>
        /// <remarks>
        /// Personengruppe gemäß Anlage 3 der Gemeinsamen Grundsätze, Länge 3, Mussangabe
        /// für die Datenerfassung und Datenübermittlung zur Sozialversicherung nach § 28b Abs. 2 SGB IV 
        /// </remarks>
        public int PERSGR { get; set; }

        /// <summary>
        /// Holt oder setzt den Abgabegrund
        /// </summary>
        /// <remarks>
        /// Grund der Abgabe, Länge 2, Mussangabe
        /// 00 = laufende Beschäftigung, 10 = Beginn der Beschäftigung
        /// 30 = Ende der Beschäftigung, 40 = Beginn und Ende der Beschäftigung in einem Monat
        /// 48 = Ausscheiden bei Eintritt in den Ruhestand  oder Altersrentenbezug, 49 = Tod 
        /// </remarks>
        public int GD { get; set; }

        /// <summary>
        /// Holt oder setzt den Angehörigkeitsschlüssel
        /// </summary>
        /// <remarks>
        /// entgällt hier, Grundstellung liefern, Länge 3, Mussangabe
        /// </remarks>
        public string SASC { get; set; }

        /// <summary>
        /// Holt oder setzt, ob diese Person als Beamter/Richter/Soldat tätig ist
        /// </summary>
        /// <remarks>
        /// Ist diese Person als Beamter/Richter/Soldat tätig? Länge 1, Mussangabe
        /// J = ja, N = nein
        /// </remarks>
        public bool BEAM { get; set; }

        /// <summary>
        /// Holt oder setzt das Anfangsdatum des Zeitraums innerhalb des Meldemonats, der durch diese Meldung abgedeckt wird
        /// </summary>
        /// <remarks>
        /// Anfangsdatum des Zeitraumes innerhalb des Meldemonats, Länge 8, Mussangabe
        /// der durch diese Meldung abgedeckt wird (in der Regel der 1. des Monats) 
        /// </remarks>
        public DateTime MONATBEG { get; set; }

        /// <summary>
        /// Holt oder setzt das Enddatum des Zeitraums innerhalb des Meldemonats, der durch diese Meldung abgedeckt wird
        /// </summary>
        /// <remarks>
        /// Enddatum des Zeitraumes innerhalb des Meldemonats, Länge 2, Mussangabe
        /// der durch diese Meldung abgedeckt wird (in der Regel der 1. des Monats) 
        /// </remarks>
        public DateTime MONATEND { get; set; }

        /// <summary>
        /// Holt oder setzt die abweichende Betriebsnummer des Unternehmens, mit der die Meldung des Vormonats gemeldet wurde
        /// </summary>
        /// <remarks>
        /// Abweichende Betriebsnummer des Unternehmens, mit der die Meldung des Vormonats gemeldet wurde, Länge 15, Pflichtangabe, soweit bekannt
        /// Diese Nummer ist nur dann zu melden, wenn ein innerbetrieblicher 
        /// Wechsel stattgefunden hat und der Teilnehmer mit einer neuen Betriebsnummer 
        /// gemeldet wird (8 Stellen linksbündig mit nachfolgenden Leerzeichen)
        /// </remarks>
        public string BBNRALT { get; set; }

        /// <summary>
        /// Dieses Feld steht dem Verursacher zur Verfügung
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht dem Verursacher zur Verfügung, Länge 20, Kannangabe
        /// Bei Meldungen zwischen dem Arbeitgeber und der ZSS, 
        /// z. B. Aktenzeichen / Personalnummer des / der Beschäftigten
        /// </remarks>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzecihen der Stornierung einer bereits abgegebenen Meldung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, Stornierung einer bereits abgegebenen Meldung, länge 1, Mussangabe
        /// N = nein, J = ja
        /// </remarks>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von ELENA Grunddaten
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBEN, Länge 1, Mussangabe
        /// N = keine Grunddaten, J = Grunddaten vorhanden
        /// </remarks>
        public bool MMEN 
        {
            get { return _hatDben ?? DBEN != null; }
            set { _hatDben = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Name
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBNA, Länge 1, Mussangabe
        /// N = keine Namensdaten, J = Namensdaten vorhanden
        /// </remarks>
        public bool MMNA
        {
            get { return _hatDbna ?? DBNA != null; }
            set { _hatDbna = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Geburtsangaben
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBGB, Länge 1, Mussangabe
        /// N = keine Geburtsangaben, J = Geburtsangaben vorhanden
        /// </remarks>
        public bool MMGB
        {
            get { return _hatDbgb ?? DBGB != null; }
            set { _hatDbgb = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Anschrift
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAN, Länge 1, 
        /// N = keine Anschriftsangaben, J = Anschriftsangaben vorhanden
        /// </remarks>
        public bool MMAN
        {
            get { return _hatDban ?? DBAN != null; }
            set { _hatDban = value; }
        }
        /// <summary>
        /// Holt oder setzt das Vorhandensein von Arbeitgeberangaben
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAG, Länge 1, Mussangabe
        /// N = keine Arbeitgeberangaben, J = Arbeitgeberangaben vorhanden
        /// </remarks>
        public bool MMAG
        {
            get { return _hatDbag ?? DBAG != null; }
            set { _hatDbag = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von von Arbeitgeberanschrift abweichender Beschäftigungsort
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAB 
        /// N = kein abweichender Beschäftigungsort, J = abweichender Beschäftigungsort
        /// </remarks>
        public bool MMAB
        {
            get { return _hatDbab ?? DBAB != null; }
            set { _hatDbab = value; }
        }
        /// <summary>
        /// Holt oder setzt das Vorhandensein von Fehlzeiten
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBFZ, Länge 1, Mussangabe
        /// N = keine Fehlzeiten, J = Fehlzeiten vorhanden
        /// </remarks>
        public bool MMFZ
        {
            get { return _hatDbfz ?? DBFZ != null; }
            set { _hatDbfz = value; }
        }
        /// <summary>
        /// Holt oder setzt das Vorhandensein von steuerpflichtigen sonstigen Bezug
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBSE, Länge 1, Mussangabe
        /// N = keine Beträge, J = Beiträge vorhanden
        /// </remarks>
        public bool MMSE
        {
            get { return _hatDbse ?? DBSE != null; }
            set { _hatDbse = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorrhandensein von steuerfreien Bezügen
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBSB, Länge 1, Mussangabe
        /// N = keine Beträge, J = Beträge vorhanden
        /// </remarks>
        public bool MMSB
        {
            get { return _hatDbsb ?? DBSB != null; }
            set { _hatDbsb = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Ausbildung
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAS, Länge 1, Mussangabe
        /// N = keine DBAS-Daten, J = DBAS-Daten vorhanden
        /// </remarks>
        public bool MMAS
        {
            get { return _hatDbas ?? DBAS != null; }
            set { _hatDbas = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Zusatzdaten
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBZD, Länge 1, Mussangabe
        /// N = keine Zusatzdaten, J = Zusatzdaten vorhanden
        /// </remarks>
        public bool MMZD
        {
            get { return _hatDbzd ?? DBZD != null; }
            set { _hatDbzd = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Nebenbeschäftigung Arbeitslose
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBNB, Länge 1, Mussangabe
        /// N = keine DBNB-Daten, J = DBNB-Daten vorhanden
        /// </remarks>
        public bool MMNB
        {
            get { return _hatDbnb ?? DBNB != null; }
            set { _hatDbnb = value; }
        }
        /// <summary>
        /// Holt oder setzt das Vorhandensein von Heimatarbeiter
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBHA, Länge 1, Mussangabe 
        /// N = keine DBHA-Daten, J = DBHA-Daten vorhanden
        /// </remarks>
        public bool MMHA
        {
            get { return _hatDbha ?? DBHA != null; }
            set { _hatDbha = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Kündigung/Entlassung
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBKE, Länge 1, Mussangabe 
        /// N = keine DBKE-Daten, DBKE-Daten vorhanden
        /// </remarks>
        public bool MMKE
        {
            get { return _hatDbke ?? DBKE != null; }
            set { _hatDbke = value; }
        }

        /// <summary>
        /// Holt oder setzt das Reservefeld 2
        /// </summary>
        /// <remarks>
        /// Reservefeld 2, Blank = Grundstellung, Länge 14, Mussangabe
        /// </remarks>
        public string RESERVE2 { get; set; }

        /// <summary>
        /// ELENA-Grunddaten
        /// </summary>
        public DBEN DBEN
        {
            get
            {
                return ListeDBEN == null ? null : ListeDBEN.SingleOrDefault();
            }
            set
            {
                ListeDBEN = ListeDBEN.Set(value);
                _hatDben = null;
            }
        }

        /// <summary>
        /// Name
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
        /// Geburtsangaben
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
        /// Anschrift
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
        /// Arbeiterangaben
        /// </summary>
        public DBAG DBAG
        {
            get
            {
                return ListeDBAG == null ? null : ListeDBAG.SingleOrDefault();
            }
            set
            {
                ListeDBAG = ListeDBAG.Set(value);
                _hatDbag = null;
            }
        }

        /// <summary>
        /// Arbeitgeberanschriftabweichung
        /// </summary>
        public DBAB DBAB
        {
            get
            {
                return ListeDBAB == null ? null : ListeDBAB.SingleOrDefault();
            }
            set
            {
                ListeDBAB = ListeDBAB.Set(value);
                _hatDbab = null;
            }
        }

        /// <summary>
        /// Fehlzeiten
        /// </summary>
        public DBFZ DBFZ
        {
            get
            {
                return ListeDBFZ == null ? null : ListeDBFZ.SingleOrDefault();
            }
            set
            {
                ListeDBFZ = ListeDBFZ.Set(value);
                _hatDbfz = null;
            }
        }

        /// <summary>
        /// Steuerpflichtbezug
        /// </summary>
        public DBSE DBSE
        {
            get
            {
                return ListeDBSE == null ? null : ListeDBSE.SingleOrDefault();
            }
            set
            {
                ListeDBSE = ListeDBSE.Set(value);
                _hatDbse = null;
            }
        }

        /// <summary>
        /// Steuerfreibezug
        /// </summary>
        public DBSB DBSB
        {
            get
            {
                return ListeDBSB == null ? null : ListeDBSB.SingleOrDefault();
            }
            set
            {
                ListeDBSB = ListeDBSB.Set(value);
                _hatDbsb = null;
            }
        }

        /// <summary>
        /// Ausbildung
        /// </summary>
        public DBAS DBAS
        {
            get
            {
                return ListeDBAS == null ? null : ListeDBAS.SingleOrDefault();
            }
            set
            {
                ListeDBAS = ListeDBAS.Set(value);
                _hatDbas = null;
            }
        }

        /// <summary>
        /// Zusatzdaten
        /// </summary>
        public DBZD DBZD
        {
            get
            {
                return ListeDBZD == null ? null : ListeDBZD.SingleOrDefault();
            }
            set
            {
                ListeDBZD = ListeDBZD.Set(value);
                _hatDbzd = null;
            }
        }

        /// <summary>
        /// Nebenbeschäftigung Arbeitslose
        /// </summary>
        public DBNB DBNB
        {
            get
            {
                return ListeDBNB == null ? null : ListeDBNB.SingleOrDefault();
            }
            set
            {
                ListeDBNB = ListeDBNB.Set(value);
                _hatDbnb = null;
            }
        }

        /// <summary>
        /// Heimarbeiter
        /// </summary>
        public DBHA DBHA
        {
            get
            {
                return ListeDBHA == null ? null : ListeDBHA.SingleOrDefault();
            }
            set
            {
                ListeDBHA = ListeDBHA.Set(value);
                _hatDbha = null;
            }
        }

        /// <summary>
        /// Kündigung
        /// </summary>
        public DBKE DBKE
        {
            get
            {
                return ListeDBKE == null ? null : ListeDBKE.SingleOrDefault();
            }
            set
            {
                ListeDBKE = ListeDBKE.Set(value);
                _hatDbke = null;
            }
        }

        private IList<DBEN> ListeDBEN { get; set; }

        private IList<DBNA> ListeDBNA { get; set; }

        private IList<DBGB> ListeDBGB { get; set; }

        private IList<DBAN> ListeDBAN { get; set; }

        private IList<DBAG> ListeDBAG { get; set; }

        private IList<DBAB> ListeDBAB { get; set; }

        private IList<DBFZ> ListeDBFZ { get; set; }

        private IList<DBSE> ListeDBSE { get; set; }

        private IList<DBSB> ListeDBSB { get; set; }

        private IList<DBAS> ListeDBAS { get; set; }

        private IList<DBZD> ListeDBZD { get; set; }

        private IList<DBNB> ListeDBNB { get; set; }

        private IList<DBHA> ListeDBHA { get; set; }

        private IList<DBKE> ListeDBKE { get; set; }

        /// <summary>
        /// Holt oder setzt eine Liste von Fehlern
        /// </summary>
        public IList<DBFE> DBFE { get; set; }
    }
}
