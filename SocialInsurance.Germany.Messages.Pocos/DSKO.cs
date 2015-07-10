using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSKO - Datensatz Kommunikation
    /// </summary>    
    public class DSKO : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSKO"/> Klasse.
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt.
        /// </remarks>
        public DSKO()
        {
            KE = "DSKO";
            VF = "DEUEV";
            VERNR = 2;
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
        /// DEUEV = DEÜVMeldeverfahren
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
        /// Holt oder setzt die Betriebsnummer des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Erstellers der Datei, Länge 15, Mussangabe
        /// Sie ist auf dem Weg zur Datenannahmestelle der Einzugsstelle identisch
        /// mit der Betriebsnummer des Absenders der Datei; Stellen 010 bis 024 
        /// (8 Stellen linksbündig mit nachfolgenden Leerzeichen).
        /// </remarks>
        public string BBNRER { get; set; }

        /// <summary>
        /// Holt oder setzt den Produkt-Identifier des geprüften Softwareproduktes
        /// </summary>
        /// <remarks>
        /// Produkt-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird, Länge 7, Mussangabe
        /// Sie wird von der ITSG, eindeutig für jedes systemuntersuchte Programm, vergeben
        /// </remarks>
        public string PRODID { get; set; }

        /// <summary>
        /// Holt oder setzt den Modifikations-Identifier des geprüften Softwareproduktes
        /// </summary>
        /// <remarks>
        /// Modifikations-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird, Länge 8, Mussangabe
        /// Sie wird je geprüfter Produktversion von der ITSG vergeben
        /// </remarks>
        public string MODID { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Name des Erstellers der Datei, Länge 30, Mussangabe
        /// </remarks>
        public string NAME1 { get; set; }

        /// <summary>
        /// Holt oder setzt den zweiten Namensbestandteil des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Zweiter Namensbestandteil des Erstellers der Datei, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME2 { get; set; }

        /// <summary>
        /// Holt oder setzt den dritten Namensbestandteil des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Dritter Namensbestandteil des Erstellers der Datei, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME3 { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Postleitzahl des Erstellers der Datei, Länge 10, Mussangabe
        /// </remarks>
        public string PLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Betriebssitz des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebssitz des Erstellers der Datei, Länge 34, Mussangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße des Betriebssitzes des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Straße des Betriebssitzes des Erstellers der Datei, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer des Betriebssitzes des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Hausnummer des Betriebssitzes des Erstellers der Datei, Länge 9, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NR { get; set; }

        /// <summary>
        /// Holt oder setzt die Anrede des Ansprechpartners beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// Anrede des Ansprechpartners beim Ersteller der Datei, Länge 1, Mussangabe
        /// M = Männlich, W = Weiblich
        /// </remarks>
        public string ANRAP { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des DEÜV-Ansprechpartners beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// Name des DEÜV-Ansprechpartners beim Ersteller der Datei, Länge 30, Mussangabe
        /// </remarks>
        public string NAMEAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Rufnummer des DEÜV-Ansprechpartners beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// Rufnummer des DEÜV-Ansprechpartners beim Ersteller der Datei, Länge 20, Mussangabe
        /// Die Telefonnummer ist funktionsbezogen durch je ein Leerzeichen zu
        /// gliedern, vor der Durchwahlnummer steht ein Bindestrich
        /// </remarks>
        public string TELAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Faxrufnummer des DEÜV-Ansprechpartners beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// Faxrufnummer des DEÜVAnsprechpartners beim Ersteller der Datei, Länge 20, Mussangabe
        /// Die Faxnummer ist funktionsbezogen durch je ein Leerzeichen zu
        /// gliedern, vor der Durchwahlnummer steht ein Bindestrich.
        /// </remarks>
        public string FAXAP { get; set; }

        /// <summary>
        /// Holt oder setzt die E-Mail-Adresse des Empfängers der Protokolle beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// E-Mail-Adresse des Empfängers der Protokolle beim Ersteller der Datei, Länge 70, Mussangabe
        /// </remarks>
        public string EMAILAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Bestätigung der fehlerfreien Verarbeitung
        /// </summary>
        /// <remarks>
        /// Wird eine Bestätigung der fehlerfreien Verarbeitung gewünscht? Länge 1, Mussangabe
        /// J = Ja, N = Nein
        /// </remarks>
        public string VERBEST { get; set; }

        /// <summary>
        /// Holt oder setzt die verschlüsselte Rückgabe fehlerhafter Datensätze/Datenbausteine
        /// </summary>
        /// <remarks>
        /// Verschlüsselte Rückgabe fehlerhafter Datensätze bzw. Datenbausteine mit angehängten
        /// Fehlerdatenbausteinen und sonstigen Rückmeldungen mittels Datensatz erwünscht, Länge 1, Mussangabe
        /// J = Ja, über E-Mail, K = Rückmeldungen über den Kommunikationsserver der Datenannahmestellen
        /// </remarks>
        public string FERUECK { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld
        /// </summary>
        /// <remarks>
        /// Reservefeld, Blank = Grundstellung, Länge 3, Mussangabe
        /// </remarks>
        public string RESERVE { get; set; }

        /// <summary>
        /// Holt oder setzt eine Liste von Fehlern
        /// </summary>
        public IList<DBFE> DBFE { get; set; }
    }
}
