// <copyright file="DSBEv0101.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSBE - Datensatz BV Beitragserhebung
    /// </summary>
    public class DSBEv0101 : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDbmi;

        private bool? _hatDbhb;

        private bool? _hatDbbf;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSBEv01"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt
        /// </remarks>
        public DSBEv0101()
        {
            KE = "DSBE";
            VF = "BVBEI";
            VERNRDS = 1;
            NEVERNR = 1;
            IK = 0;
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des Datensatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des Datensatzes, Länge 2, Mussangabe
        /// BV Beitragserhebung
        /// </remarks>
        public int VERNRDS { get; set; }

        /// <summary>
        /// Nebenversionsnummer des übermittelten Datensatzes.
        /// </summary>
        /// <remarks>
        /// Nebenversionsnummer des Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public int NEVERNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des Kernprüfprogramms
        /// </summary>
        /// <remarks>
        /// Versionsnummer des Kernprüfprogramms mit der der Datensatz geprüft wurde
        /// </remarks>
        public int VERNRKP { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5,  Mussangabe
        /// BVBEI = BV Beitragserhebung
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Erstellers des Datensatzes, Länge 8, Mussangabe
        /// </remarks>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers des Datensatzes, Länge 8, Mussangabe
        /// </remarks>
        public string BBNREP { get; set; }

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Datensatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, Mussangabe
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
        /// Holt oder setzt einen Wert der angibt, ob der Datenbaustein DBBF - Bestandsfehler vorhanden ist
        /// </summary>
        public bool MMBF
        {
            get { return _hatDbbf ?? DBBF != null; }
            set { _hatDbbf = value; }
        }

        /// <summary>
        /// Holt oder setzt Produkt-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird.
        /// </summary>
        /// <remarks>
        /// Sie wird von der ITSG, eindeutig für jedes systemuntersuchte Programm, vergeben
        /// </remarks>
        public string PRODID { get; set; }

        /// <summary>
        /// Holt oder setzt den Modifikations-Identifier des geprüften Softwareproduk-tes, das beim Ersteller der Datei eingesetzt wird.
        /// </summary>
        /// <remarks>
        /// Sie wird je geprüfter Produktversion von der ITSG vergeben
        /// </remarks>
        public string MODID { get; set; }

        /// <summary>
        /// Holt oder setzt die eindeutige Kennzeichnung des Datensatzes durch den Ersteller
        /// </summary>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Verarbeitung des Datensatzes
        /// </summary>
        /// <remarks>
        /// Datum wird durch die DASBV bei Verarbeitung gesetzt
        /// </remarks>
        public DateTime? VD { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Arbeitsgebers
        /// </summary>
        /// <remarks>
        /// Name des Arbeitsgebers, Länge 30, Mussangabe
        /// </remarks>
        public string NA1 { get; set; }

        /// <summary>
        /// Holt oder setzt den zweiten Namensbestandteil des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Zweiter Namensbestandteil des Arbeitgebers, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NA2 { get; set; }

        /// <summary>
        /// Holt oder setzt den dritten Namensbestandteil des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Dritter Namensbestandteil des Arbeitgebers, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NA3 { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße der Betriebsstätte der Beschäftigung
        /// </summary>
        /// <remarks>
        /// Straße der Betriebsstätte der Beschäftigung, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer der Betriebsstätte der Beschäftigung
        /// </summary>
        /// <remarks>
        /// Hausnummer der Betriebsstätte der Beschäftigung, Länge 9, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string HNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl der Betriebsstätte der Beschäftigung
        /// </summary>
        /// <remarks>
        /// Postleitzahl der Betriebsstätte der Beschäftigung, Länge 5, Mussangabe
        /// </remarks>
        public int PLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort der Betriebsstätte der Beschäftigung
        /// </summary>
        /// <remarks>
        /// Ort der Betriebsstätte der Beschäftigung, Länge 34, Mussangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen beim Verursacher des Datensatzes
        /// </summary>
        /// <remarks>
        /// Aktenzeichen beim Verursacher des Datensatzes, Länge 20, Kannangabe
        /// z.B. die Personalnummer beim Arbeitgeber
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Verursachers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Verursachers des Datensatzes, Länge 15, Mussangabe
        /// im Datenaustauschverfahren AGBVB
        /// </remarks>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Abrechnungsstelle, Länge 15, Pflichtangabe, soweit bekannt
        /// im Datenaustauschverfahren AGBVB
        /// wenn abweichend vom Beschäftigungsbetrieb (BBNRVU), z.B. die Nummer der Zentrale oder des
        /// Steuerberaters/Dienstleisters
        /// </remarks>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der für den Beschäftigten zuständigen berufsständischen Versorgungseinrichtung
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der für den Beschäftigten zuständigen berufsständischen Versorgungseinrichtung, Länge 15, Mussangabe
        /// </remarks>
        public string BBNRBV { get; set; }

        /// <summary>
        /// Holt oder setzt die Mitgliedsnummer des berufsständisch Versicherten
        /// </summary>
        /// <remarks>
        /// Mitgliedsnummer des berufsständisch Versicherten im Arbeitgeberverfahren zur Beitragserhebung, Länge 17, Mussangabe
        /// Ist die Mitgliedsnummer noch nicht bekannt, muss die fiktive Mitgliedsnummer für diese BV verwendet werden
        /// </remarks>
        public string MNRBV { get; set; }

        /// <summary>
        /// Holt oder setzt den Monat, zu dem die Daten gehören
        /// </summary>
        /// <remarks>
        /// Monat, zu dem die Daten gehören, Länge 6, Mussangabe
        /// </remarks>
        public DateTime ABMO { get; set; }

        /// <summary>
        /// Holt oder setzt den Monat, mit dem die Daten gemeldet werden
        /// </summary>
        /// <remarks>
        /// Monat, mit dem die Daten gemeldet werden, Länge 6, Mussangabe
        /// </remarks>
        public DateTime VEMO { get; set; }

        /// <summary>
        /// Holt oder setzt den Meldevorgang
        /// </summary>
        /// <remarks>
        /// Meldevorgang, Länge 1, Mussangabe
        /// <list type="bullet">
        /// <item>G = Grundmeldung - die Daten stellen das Gesamtergebnis des abgerechneten Monats (ABMO) dar;
        /// eventuell vorangegangene Meldungen zum selben ABMO werden ersetzt</item>
        /// <item>K = Korrekturmeldung - die Daten bewirken eine Korrektur des bisherigen Meldestandes zum ABMO
        /// (es muss zumindest bereits eine Grundmeldung vorliegen)</item>
        /// </list>
        /// </remarks>
        public string MEVO { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen für Sozialversicherungstage im ABMO
        /// </summary>
        /// <remarks>
        /// Vorzeichen für Sozialversicherungstage im ABMO, Länge 1, Mussangabe
        /// "Leerzeichen" oder "+" = positiv, "-" = negativ (nur mit MEVO "K" zulässig)
        /// </remarks>
        public string VZSVTG { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der Sozialversicherungstage im ABMO
        /// </summary>
        /// <remarks>
        /// Anzahl der Sozialversicherungstage im ABMO, Länge 2, Mussangabe
        /// 00 - 31
        /// </remarks>
        public int SVTG { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen für laufendes Arbeitsentgelt im ABMO
        /// </summary>
        /// <remarks>
        /// Vorzeichen für laufendes Arbeitsentgelt im ABMO, Länge 1, Mussangabe
        /// "Leerzeichen" oder "+" = positiv, "-" = negativ (nur mit MEVO "K" zulässig)
        /// </remarks>
        public string VZLGA { get; set; }

        /// <summary>
        /// Holt oder setzt das beitragspflichtige laufende Entgelt im ABMO
        /// </summary>
        /// <remarks>
        /// Beitragspflichtiges laufendes Entgelt im ABMO, Länge 8, Mussangabe
        /// nicht gekürzt auf die Beitragsbemessungsgrenze (mit Centangabe)
        /// </remarks>
        public int LGA { get; set; }

        /// <summary>
        /// Holt oder setzt die Internkennung
        /// </summary>
        /// <remarks>
        /// Internkennung, Länge 1, Mussangabe
        /// Fix 0
        /// </remarks>
        public int IK { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen für Einmalzahlung im ABMO
        /// </summary>
        /// <remarks>
        /// Vorzeichen für Einmahlzahlung im ABMO, Länge 1, Mussangabe
        /// "Leerzeichen" oder "+" = positiv, "-" = negativ (nur mit MEVO "K" zulässig)
        /// </remarks>
        public string VZEGA { get; set; }

        /// <summary>
        /// Holt oder setzt die beitragspflichtige Einmalzahlung im ABMO
        /// </summary>
        /// <remarks>
        /// Beitragspflichtige Einmalzahlung im ABMO, Länge 9, Mussangabe
        /// nicht gekürzt auf die Beitragsbemessungsgrenze, jedoch auf die Darstellbarkeit (mit Centangabe)
        /// </remarks>
        public int EGA { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen für Bemessungsgrundlage als Einmalzahlung im ABMO
        /// </summary>
        /// <remarks>
        /// Vorzeichen für Bemessungsgrundlage aus Einmalzahlung im ABMO, Länge 1, Mussangabe
        /// "Leerzeichen" oder "+" = positiv, "-" = negativ (nur mit MEVO "K" zulässig)
        /// </remarks>
        public string VZEGAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Bemessungsgrundlage als Einmalzahlung im ABMO
        /// </summary>
        /// <remarks>
        /// Bemessungsgrundlage aus Einmalzahlung im ABMO(mit Centangabe), Länge 8, Mussangabe
        /// </remarks>
        public int EGAB { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen des Zahlenden
        /// </summary>
        /// <remarks>
        /// Kennzeichen des Zahlenden, Länge 1, Mussangabe
        /// 0 = Selbstzahler, 1 = Firmenzahler, Einzelzahlung
        /// 2 = Firmenzahler, Sammelzahlung mit BBNRVU, 3 = Firmenzahler, Sammelzahlung mit BBNRAS
        /// 4 = Firmenzahler, Sammelzahlung mit BBNR Zentrale, 5 = Firmenzahler, Lastschrift
        /// </remarks>
        public string BZ { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen für Pflichtbetrag im ABMO
        /// </summary>
        /// <remarks>
        /// Vorzeichen für Pflichtbetrag im ABMO, Länge 1, Mussangabe
        /// "Leerzeichen" oder "+" = positiv, "-" = negativ (nur mit MEVO "K" zulässig)
        /// </remarks>
        public string VZPB { get; set; }

        /// <summary>
        /// Holt oder setzt den Pflichtbeitrag aus LGA und EGA im ABMO
        /// </summary>
        /// <remarks>
        /// Gesamt Pflichtbeitrag aus LGA und EGA im ABMO(mit Centangabe), Länge 8, Mussangabe
        /// </remarks>
        public int PB { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Mitgliedsidentifikation vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBMI Mitgliedsidentifikation vorhanden, Länge 1, Mussangabe
        /// J = Mitgliedsidentifikation vorhanden
        /// (Der Datenbaustein DBMI muss immer vorhanden sein)
        /// </remarks>
        public bool MMMI
        {
            get { return _hatDbmi ?? DBMI != null; }
            set { _hatDbmi = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Höherversicherungsbeitrag vorhanden ist.
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBHB Höherversicherungsbeitrag vorhanden, Länge 1, Mussangabe
        /// N = kein Höherversicherungsbeitrag, J = Höherversicherungsbeitrag vorhanden
        /// (nur bei Firmenzahlern zugelassen)
        /// </remarks>
        public bool MMHB
        {
            get { return _hatDbhb ?? DBHB != null; }
            set { _hatDbhb = value; }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Mitgliedsidentifikation
        /// </summary>
        public DBMI DBMI
        {
            get
            {
                return ListeDBMI == null ? null : ListeDBMI.SingleOrDefault();
            }
            set
            {
                ListeDBMI = ListeDBMI.Set(value);
                _hatDbmi = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Höherversicherungsbeitrag
        /// </summary>
        public DBHB DBHB
        {
            get
            {
                return ListeDBHB == null ? null : ListeDBHB.SingleOrDefault();
            }
            set
            {
                ListeDBHB = ListeDBHB.Set(value);
                _hatDbhb = null;
            }
        }

        /// <summary>
        /// Holt oder setzt eine Liste von Fehlern
        /// </summary>
        public IList<DBFE> DBFE { get; set; }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Bestandsfehler
        /// </summary>
        public DBBF DBBF
        {
            get
            {
                return ListeDBBF == null ? null : ListeDBBF.SingleOrDefault();
            }
            set
            {
                ListeDBBF = ListeDBBF.Set(value);
                _hatDbbf = null;
            }
        }

        private IList<DBBF> ListeDBBF { get; set; }

        private IList<DBMI> ListeDBMI { get; set; }

        private IList<DBHB> ListeDBHB { get; set; }
    }
}
