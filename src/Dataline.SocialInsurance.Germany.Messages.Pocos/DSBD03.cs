// <copyright file="DSBD03.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSBD - Datensatz Betriebsdatenpflege
    /// <para />
    /// Version 3 gültig ab 01.07.2019
    /// </summary>
    public class DSBD03 : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDbpa;

        private bool? _hatDbtn;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSBD03"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt
        /// </remarks>
        public DSBD03()
        {
            KE = "DSBD";
            VERNR = 3;
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
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5,  Mussangabe
        /// BTRAG = Betriebsdatenpflege durch Arbeitgeber,
        /// BTRKS = Betriebsdatenpflege durch die Deutsche Rentenversicherung Knappschaft-Bahn-See im selbst verwalteten Betriebsnummernbereich
        /// BTRKV = Betriebsdatenpflege durch Krankenkassen, Deutsche Rentenversicherung Knappschaft-Bahn-See, Arbeitsgemeinschaft Berufsständischer Versorgungseinrichtungen, Unfallversicherung
        /// BTRRV = Betriebsdatenpflege durch Rentenversicherung
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Absendernummer der Datei
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>Betriebsnummer des Absenders der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        ///     <item>Absendernummer gemäß § 18n Abs. 2 SGB IV (A + 7 Ziffern linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        /// </list>
        /// </remarks>
        public string ABSN { get; set; }

        /// <summary>
        /// Holt oder setzt die Absendernummer des Empfängers der Datei
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>Betriebsnummer des Empfängers der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        ///     <item>Absendernummer gemäß § 18n Abs. 2 SGB IV (A + 7 Ziffern linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        /// </list>
        /// </remarks>
        public string EPNR { get; set; }

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
            get => _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft);
            set => _fekz = value;
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
        /// Holt oder setzt die Betriebsnummer des Beschäftigungsbetriebs
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Betriebsstätte, für die die Meldung vorgenommen wird, Länge 15, Mussangabe
        /// </remarks>
        public string BBNRBB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Abrechnungsstelle, Länge 15, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Abgabe
        /// </summary>
        /// <remarks>
        /// Grund der Abgabe, Länge 2, Kannangabe
        /// 01 = Änderung (im Verfahren BTRKS)
        /// 02 = Neuvergabe (im Verfahren BTRKS)
        /// 03 = Mitteilung ausschließlich der Teilnahmepflichten (im Verfahren BTRKV)
        ///
        /// Bei der Betriebsdatenpflege durch Arbeitgeber (VF = „BTRAG“) oder die Rentenversicherung (VF = „BTRRV“) ist nur die Grundstellung (Leerzeichen) zulässig.
        /// </remarks>
        public int? GD { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum, zu dem das Veränderungsereignis wirksam wird
        /// </summary>
        /// <remarks>
        /// Die Grundstellung (<see langword="null"/>) ist bei der Betriebsdatenpflege durch Arbeitgeber(VF = „BTRAG“) unzulässig.
        /// </remarks>
        public DateTime? DTEREIGNIS { get; set; }

        /// <summary>
        /// Holt oder setzt die Wirtschaftsunterklasse
        /// </summary>
        /// <remarks>
        /// Wirtschaftsunterklasse nach der Klassifikation WZ2008
        /// </remarks>
        public string WUKL { get; set; }

        /// <summary>
        /// Holt oder setzt den ersten Teil des Namens des Beschäftigungsbetriebes
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung des Betriebes – Teil 1, Länge 30, Mussangabe
        /// </remarks>
        public string NAMEBB1 { get; set; }

        /// <summary>
        /// Holt oder setzt den zweiten Teil des Namens des Beschäftigungsbetriebes
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung des Betriebes – Teil 2, Länge 30, Pflichtangabe unter Bedingungen
        /// </remarks>
        public string NAMEBB2 { get; set; }

        /// <summary>
        /// Holt oder setzt den dritten Teil des Namens des Beschäftigungsbetriebes
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung des Betriebes – Teil 3, Länge 30, Pflichtangabe unter Bedingungen
        /// </remarks>
        public string NAMEBB3 { get; set; }

        /// <summary>
        /// Holt oder setzt die inländische Postleitzahl des Beschäftigungsbetriebs
        /// </summary>
        /// <remarks>
        /// Postleitzahl(zustellbezogen), Länge 10, Mussangabe
        /// </remarks>
        public string PLZBB { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort des Beschäftigungsbetriebes
        /// </summary>
        /// <remarks>
        /// Ort des Betriebes, Länge 34, Mussangabe
        /// </remarks>
        public string ORTBB { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße des Beschäftigungsbetriebes
        /// </summary>
        /// <remarks>
        /// Straße des Betriebes, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STRBB { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer des Beschäftigungsbetriebes
        /// </summary>
        /// <remarks>
        /// Hausnummer des Betriebes, Länge 9, Pflichtangabe, soweit bekannt
        /// Hinweis: Wenn die Hausnummer nicht separat abgelegt
        /// werden kann, ist es zulässig, die Hausnummer in
        /// das Feld Straße zu übernehmen. In solchen Fällen
        /// muss dann das Feld Hausnummer auf Grundstellung (Leerzeichen) stehen
        /// </remarks>
        public string HNRBB { get; set; }

        /// <summary>
        /// Holt oder setzt die Bestätigung/Einstellung der Betriebstätigkeit
        /// </summary>
        /// <remarks>
        /// Bestätigung über die Betriebstätigkeit bzw. Einstellung
        /// der Betriebstätigkeit (Mitteilung für Betriebseinstellungen bis Ende des lfd. Kalenderjahres möglich)
        /// A = aktiver oder wieder zu aktivierender Betrieb (nur im Verfahren „BTRKS“)
        /// B = Vollständige Beendigung der Betriebstätigkeit des Beschäftigungsbetriebs
        ///
        /// Bei der Betriebsdatenpflege durch Arbeitgeber (VF = „BTRAG“) ist nur der Wert „B“ oder die Grundstellung (Leerzeichen) zulässig.
        /// </remarks>
        public string KENNZEND { get; set; }

        /// <summary>
        /// Holt oder setzt das Geschlecht zur Anrede des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Geschlecht zur Anrede des Ansprechpartners, Länge 1, Pflichtangabe, soweit bekannt
        /// M = Männlich, W = Weiblich, N = Keine Einzelperson
        /// </remarks>
        public string ANRAP { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Name des Ansprechpartners, Länge 30, Mussangabe
        /// </remarks>
        public string NAMEAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Rufnummer des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Rufnummer des Ansprechpartners, Länge 20, Mussangabe
        /// </remarks>
        public string TELAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Faxrufnummer des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Faxrufnummer des Ansprechpartners, Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string FAXAP { get; set; }

        /// <summary>
        /// Holt oder setzt die E-Mail-Adresse des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// E-Mail-Adresse des Ansprechpartners, Länge 70, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string EMAILAP { get; set; }

        /// <summary>
        /// Holt oder setzt das dem Verursacher zur Verfügung stehende Feld
        /// </summary>
        /// <remarks>
        /// Länge 20, Kannangabe
        /// Bei der Datenübermittlung zwischen dem Arbeitgeber
        /// und der Datenannahmestelle: z. B. Aktenzeichen / Personalnummer
        /// des Beschäftigten
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Holt oder setzt das dem Verursacher zur Verfügung stehende Feld
        /// </summary>
        /// <remarks>
        /// Länge 32, Kannangabe
        /// </remarks>
        public string DATENSATZID { get; set; }

        /// <summary>
        /// Änderung in den Namensfeldern
        /// </summary>
        public bool KENNZNAME { get; set; }

        /// <summary>
        /// Änderung in den Anschriftenfeldern Beschäftigungsbetrieb
        /// </summary>
        public bool KENNZANSCHRIFT { get; set; }

        /// <summary>
        /// Änderung in den Ansprechpartnerdaten
        /// </summary>
        public bool KENNZANSPRECH { get; set; }

        /// <summary>
        /// Holt oder setzt den Produkt-Identifier des geprüften Softwareproduktes
        /// </summary>
        /// <remarks>
        /// Produkt-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird, Länge 7, Mussangabe
        /// Sie wird von der ITSG, eindeutig für jedes systemuntersuchte Programm, vergeben
        /// </remarks>
        public int? PRODID { get; set; }

        /// <summary>
        /// Holt oder setzt den Modifikations-Identifier des geprüften Softwareproduktes
        /// </summary>
        /// <remarks>
        /// Modifikations-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird, Länge 8, Mussangabe
        /// Sie wird je geprüfter Produktversion von der ITSG vergeben
        /// </remarks>
        public int? MODID { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein abweichende Postanschrift vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBPA, Länge 1, Mussangabe
        /// Abweichende Korrespondenzanschrift vorhanden:
        /// N = Nein
        /// J = Ja
        /// Hinweis: Die Korrespondenzanschrift muss zum Unternehmen
        /// gehören. Sie gehört somit nicht zu einem Dienstleister wie zum Beispiel einem Steuerberater
        /// </remarks>
        public bool MMPA
        {
            get => _hatDbpa ?? DBPA != null;
            set => _hatDbpa = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Teilnahmepflichten vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBTN, Länge 1, Mussangabe
        /// Teilnahmepflichten vorhanden:
        /// N = Nein
        /// J = Ja
        /// </remarks>
        public bool MMTN
        {
            get => _hatDbtn ?? DBTN != null;
            set => _hatDbtn = value;
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Abweichende Korrespondenzanschrift
        /// </summary>
        public DBPA DBPA
        {
            get => ListeDBPA?.SingleOrDefault();
            set
            {
                ListeDBPA = ListeDBPA.Set(value);
                _hatDbpa = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Teilnahmepflicht
        /// </summary>
        public DBTN DBTN
        {
            get => ListeDBTN?.SingleOrDefault();
            set
            {
                ListeDBTN = ListeDBTN.Set(value);
                _hatDbtn = null;
            }
        }

        /// <summary>
        /// Holt oder setzt eine Liste von Fehlern
        /// </summary>
        public IList<DBFE> DBFE { get; set; }

        /// <summary>
        /// Holt die Datenbausteine eines Datensatzes
        /// </summary>
        public IEnumerable<IDatenbaustein> Datenbausteine
        {
            get
            {
                foreach (var datenbaustein in ListExtensions.Enumerate(ListeDBPA, ListeDBTN, DBFE))
                    yield return datenbaustein;
            }
        }

        private IList<DBPA> ListeDBPA { get; set; }

        private IList<DBTN> ListeDBTN { get; set; }
    }
}
