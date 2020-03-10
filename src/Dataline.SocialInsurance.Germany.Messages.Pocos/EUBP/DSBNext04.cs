// <copyright file="DSBNext04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DSBNext04
    {
        private bool? _hatDbrb;

        private bool? _hatDbsc;

        public DSBNext04()
        {
            WG = "E";
        }

        /// <summary>
        /// Holt oder setzt die Datensatz-ID
        /// </summary>
        /// <remarks>
        /// Datensatz-ID
        /// Dieses Feld steht in der Abrechnungstelle (z.B. Steuerberater, Rechenzentrum, Arbeitgeber, Zahlstelle) zur freien Verfügung
        /// Länge 20, Kannangabe
        /// </remarks>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenkennzeichen
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht der Einzustelle zur freien Verfügung, Länge 20, Kannangabe
        /// </remarks>
        public string AZKK { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennzeichenart
        /// </summary>
        /// <remarks>
        /// Art des Beitragsnachweises
        /// 0 = normaler Beitragnachweis
        /// 1 = Dauer-Beitragsnachweis
        /// Länge 1, Mussangabe
        /// </remarks>
        public int KEART { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Nachweiszeitraums
        /// </summary>
        /// <remarks>
        /// Beginn des Nachweiszeitraums, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ZRBEG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Nachweiszeitraums
        /// </summary>
        /// <remarks>
        /// Ende des Nachweiszeitraums, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ZREND { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - allgemein - ohne Zusatzbeitrag (Beitragsgruppe 1000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITR1 { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - erhöht - ohne Zusatzbeitrag (Beitragsgruppe 2000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITR2 { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - ermäßigt - ohne Zusatzbeitrag (Beitragsgruppe 3000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITR3 { get; set; }

        /// <summary>
        /// Holt oder setzt den PV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Pflegeversicherung (Beitragsgruppen 0001 und 0002) mit Centangaben, Länge 11, Mussangabe
        /// </remarks>
        public int PVBEITR { get; set; }

        /// <summary>
        /// Holt oder setzt den RV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung (Beitragsgruppen 0100) mit Centangaben, Länge 11, Mussangabe
        /// </remarks>
        public int RVBEITR1 { get; set; }

        /// <summary>
        /// Holt oder setzt den/die Zusatzbeitrag/Pflichtbeiträge
        /// </summary>
        /// <remarks>
        /// Zusatzbeitrag zur Krankversicherung für Pflichtversicherte mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int ZBP { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Abreitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Abreitslosenversicherung - voller Beitrag - (Beitragsgruppe 0010) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int AVBEITR1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung - halber Beitrag - (Beitragsgruppe 0300) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int RVBEITR3 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Insolvenzgeldversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung (Beitragsgruppe 0050) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int INSGU { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Abreitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Abreitslosenversicherung - halber Beitrag - (Beitragsgruppe 0020) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int AVBEITR2 { get; set; }

        /// <summary>
        /// Holt oder setzt die Umlage Krankheitsaufwendung
        /// </summary>
        /// <remarks>
        /// Umlage Krankheitsaufwendung (Beitragsgruppe U1) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int U1 { get; set; }

        /// <summary>
        /// Holt oder setzt die Umlage Mutterschaftsaufwendung
        /// </summary>
        /// <remarks>
        /// Umlage Mutterschaftsaufwendung (Beitragsgruppe U2) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int U2 { get; set; }

        /// <summary>
        /// Holt oder setzt den Pauschal-Beitrag zur Krankenversicherung
        /// </summary>
        /// <remarks>
        /// Pauschal-Beitrag zur Krankenversicherung (Beitragsgruppe 6000) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITR6 { get; set; }

        /// <summary>
        /// Holt oder setzt den Pauschal-Beitrag zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Pauschal-Beitrag zur Rentenversicherung (Beitragsgruppe 0500) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int RVBEITR5 { get; set; }

        /// <summary>
        /// Holt oder setzt die Zwischensumme
        /// </summary>
        /// <remarks>
        /// Zwischensumme der Stellen 183-317, Länge 11, Mussangabe
        /// </remarks>
        public int ZWS { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Krankenversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankenversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITRF { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Pflegeversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Beitrag zur Pflegeversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int PVBEITRF { get; set; }

        /// <summary>
        /// Holt oder setzt den Erstattungbetrag der Arbeitgeberaufwendungen
        /// </summary>
        /// <remarks>
        /// Erstattungbetrag der Arbeitgeberaufwendungen bei Krankheit und Mutterschaft mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int ERSTAAG { get; set; }

        /// <summary>
        /// Holt oder setzt den Zusatzbetrag zur Krankversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Zusatzbetrag zur Krankversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int ZBF { get; set; }

        /// <summary>
        /// Holt oder setzt den wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Wahlweise; z.B zur Seemannskasse - Arbeitgeberanteil - mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int BEITR2 { get; set; }

        /// <summary>
        /// Holt oder setzt den wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Wahlweise; z.B zur Seemannskasse - Arbeitgeberanteil - mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int BEITR3 { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe
        /// </summary>
        /// <remarks>
        /// Zahlbetrag/Guthaben (Summe Stellen 318-401) mit Centeingabe, Länge 11, Mussangabe
        /// </remarks>
        public int SUM { get; set; }

        /// <summary>
        /// Holt oder setzt Name 1 des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Arbeitgeber/Zahlstelle-Bezeichnung Zeile 1, Länge 30, Mussangabe
        /// </remarks>
        public string NAME1 { get; set; }

        /// <summary>
        /// Holt oder setzt Name 2 des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Arbeitgeber/Zahlstelle-Bezeichnung Zeile 2, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME2 { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Straße/Postfach des Arbeitgebers/Zahlstelle, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt das Länderkennzeichen
        /// </summary>
        /// <remarks>
        /// Länderkennzeichen gemäß Anlage 8 DEÜV (Nur bei ausländischen Anschriften), Länge 3, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string LDKZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Postleitzahl des Arbeigebers/Zahlstelle (bei inländischen Anschriften muss die Postleitzahl 5 Stellen
        /// nummerisch linksbündig mit nachfolgenden Leerzeichen sein)
        /// Länge 10, Mussangabe
        /// </remarks>
        public string PLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Ort des Sitzes des Arbeitgebers/Zahlstelle, Länge 25, Mussangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Abrechnungsstelle 1
        /// </summary>
        /// <remarks>
        /// Abrechnungsstelle 1 (z.B. Steuerberater-Nummer), Länge 15, Pflicht, soweit bekannt
        /// </remarks>
        public string ABRECHN1 { get; set; }

        /// <summary>
        /// Holt oder setzt die Abrechnungsstelle 2
        /// </summary>
        /// <remarks>
        /// Abrechnungsstelle 2 (z.B. Mandanten-Nummer), Länge 15, Pflicht, soweit bekannt
        /// </remarks>
        public string ABRECHN2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ordnungsmerkmal
        /// </summary>
        /// <remarks>
        /// Kasseninternes Ordnungsmerkmal, Länge 20, Pflicht, soweit bekannt
        /// </remarks>
        public string ORDN { get; set; }

        /// <summary>
        /// Holt oder setzt das Verarbeitungsmerkmal
        /// </summary>
        /// <remarks>
        /// Kennzeichen für laufenden Beitragsnachweis.
        /// Wird "S" angegeben, sind die Stellen 122-425 mir den zu stornierenden Werten anzugeben.
        /// Der ursprüngliche Beitragsnachweis wird vollständig storniert.
        /// Länge 1, Mussangabe
        /// </remarks>
        public string VAMM { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragssatz zur Krankversicherung
        /// </summary>
        /// <remarks>
        /// Beitragsatz zur Krankversicherung inklusive des kassenindividuellen Zusatzbeitragssatzes.
        /// Es ist die für den Nachweiszeitraum (Stellen 122-137) maßgebliche Summe der Beitragsätze mit zwich Nachkommastellen angzugeben (z.B. für 14,6% + 0,3% = 1490)
        /// Länge 4, Mussangabe
        /// </remarks>
        public int BEITRSA { get; set; }

        /// <summary>
        /// Holt oder setzt den erhöhten Beitragssatz zur Krankversicherung
        /// </summary>
        /// <remarks>
        /// Erhöhter Beitragsatz zur Krankversicherung. Es ist der für den Nachweiszeitraum (Stellen 122 - 137)
        /// maßgebliche erhöhte Beitragssatz mit zwie Nachkommastellen anzugeben.
        /// (z.B. für 15,9% = 1590) Bei Nachweiszeiträumen ab 01.01.2009 ist nur die Grundstellung (0000) zulässig.
        /// Länge 4, Mussangabe
        /// </remarks>
        public int BEITRSE { get; set; }

        /// <summary>
        /// Holt oder setzt den ermäßigten Beitragssatz zur Krankversicherung
        /// </summary>
        /// <remarks>
        /// Ermäßigter Beitragsatz zur Krankversicherung inklusive des kassenindividuellen Zusatzbeitragssatzes.
        /// Es ist die für den Nachweiszeitraum (Stellen 122 - 137) maßgebliche Summe der Beigratsätze mit Nachkomma-
        /// stellen anzugeben (z.B. für 14,0% + 0,3% = 1430) zulässig.
        /// Länge 4, Mussangabe
        /// </remarks>
        public int BEITRSH { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen des Rechtskreises
        /// </summary>
        /// <remarks>
        /// Kennzeichen des Rechtskreises
        /// W = alte Bundesländer einschließlich Westberlin
        /// O = neue Bundesländer einschließlich Ostberlin
        /// Länge 1, Mussangabe
        /// </remarks>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen für Jahres-Beitragsnachweis
        /// </summary>
        /// <remarks>
        /// Kennzeichen für Jahres-Beitragsnachweis zum Umlageverfahren (U1/U2)
        /// 0 = nein
        /// 1 = ja
        /// Länge 1, Mussangabe
        /// </remarks>
        public int KENNUML { get; set; }

        /// <summary>
        /// Holt oder setzt die laufende Nummer
        /// </summary>
        /// <remarks>
        /// Die laufende Nummer (01 - 999) ist anzugeben, wenn innerhalb eines Entgeltabrechungszeitraums mehr als ein Datensatz je Betriebsstätte übermittelt wird.
        /// Wird in Stelle 628 "S" angegeben, ist die laufende des zu stornierenden Datensatzes anzugeben.
        /// Länge 3, Mussangabe
        /// </remarks>
        public int LFDNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Währungskennzeichen
        /// </summary>
        /// <remark>
        /// Währungskennzeichen
        /// E = Euro, Länge = 1, Mussangabe
        /// </remark>
        public string WG { get; set; }

        /// <summary>
        /// Holt oder setzt die einheitliche Pauschalsteuer
        /// </summary>
        /// <remarks>
        /// Einheitliche Pauschalsteuer für geringfügig entlohnte Beschäftigte mit Centangabe
        /// Länge 11, Mussangabe
        /// </remarks>
        public int BEITR { get; set; }

        /// <summary>
        /// Holt oder setzt die Steuernummer des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Länge 20, Kannangabe
        /// </remarks>
        public string STNR { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Schätzbeiträge vorhanden ist
        /// </summary>
        /// <remarks>
        /// Schätzbeiträge vorhanden, Länge 1, Mussangabe
        /// N = keine Schätzbeiträge
        /// J = Schätzbeiträge vorhanden
        /// </remarks>
        public bool MMSC
        {
            get => _hatDbsc ?? DBSC != null;
            set => _hatDbsc = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Restbeträge vorhanden ist
        /// </summary>
        /// <remarks>
        /// Restbeträge vorhanden, Länge 1, Mussangabe
        /// N = keine Restbeträge
        /// J = Restbeträge vorhanden
        /// </remarks>
        public bool MMRB
        {
            get => _hatDbrb ?? DBRB != null;
            set => _hatDbrb = value;
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Schätzbeiträge
        /// </summary>
        public DBSC04 DBSC
        {
            get => ListeDBSC?.SingleOrDefault();
            set
            {
                ListeDBSC = ListeDBSC.Set(value);
                _hatDbsc = null;
            }
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Restbeträge
        /// </summary>
        public DBRB04 DBRB
        {
            get => ListeDBRB?.SingleOrDefault();
            set
            {
                ListeDBRB = ListeDBRB.Set(value);
                _hatDbrb = null;
            }
        }

        private IList<DBSC04> ListeDBSC { get; set; }

        private IList<DBRB04> ListeDBRB { get; set; }
    }
}
