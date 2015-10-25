// <copyright file="BW0210.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos.BNA
{
    /// <summary>
    /// Beitragsnachweis-Datensatz
    /// </summary>
    public class BW0210 : IDatensatz
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="BW0210"/> Klasse.
        /// </summary>
        public BW0210()
        {
            KE = "BW02";
            VF = "BWNAC";
            DBFE = new List<DBFE>();
            VERNR = 10;
        }

        /// <summary>
        /// Holt oder setzt die Kennung des Datenbausteins
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Baustein es sich handelt, Länge 4, Mussangabe
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal, um welche Art von Datenaustausch es sich handelt
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist: BWBNV = Beitragsnachweis der Zahlstellen, Länge 5, Mussangabe
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebs-/Zahlestellnummer des Absenders (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebs-/Zahlestellnummer des Empfängers (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string BBNREP { get; set; }

        /// <summary>
        /// Holt oder setzt eine Liste von Fehlern
        /// </summary>
        /// <remarks>
        /// Versionsnummer des Vorlaufsatzes 01-99, Länge 2, Mussangabe
        /// </remarks>
        public int VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Erstellung der Datei
        /// </summary>
        /// <remarks>
        /// Datum der Erstellung der Datei, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt das Fehlerkennzeichen
        /// </summary>
        /// <remarks>
        /// Kennzeichnung für fehlerhafte Datensätze
        /// 0 = Datensatz fehlerfrei
        /// 1 = Datensatzfehlerhaft
        /// 2 = unbesetzt
        /// 3 = Hinweis für die Zahlstellen und die Krankenkasse
        /// Länge 1, Mussangabe
        /// </remarks>
        public int FEKZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Fehleranzahl
        /// </summary>
        /// <remarks>
        /// Anzahl der Fehler des Datensatzes in der Form: n, Länge 1, Mussangabe
        /// </remarks>
        public int FEAN { get; set; }

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
        /// Dieses Feld steht der Einzustelle zur freien Verfügung, Länge 20, Pflichtangabe, soweit bekannt
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
        /// Holt oder setzt die Betriebsnummer des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Arbeitgebers (8 STellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string BBNRAG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Nachweiszeitraums
        /// </summary>
        /// <remarks>
        /// Beginn des Nachweiszeitraums, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRBEG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Nachweiszeitraums
        /// </summary>
        /// <remarks>
        /// Ende des Nachweiszeitraums, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZREND { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen des KV-Beitrags
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZKV1 { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - allgemein - ohne Zusatzbeitrag (Beitragsgruppe 1000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITR1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen des KV-Beitrags
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZKV2 { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - erhöht - ohne Zusatzbeitrag (Beitragsgruppe 2000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITR2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen des KV-Beitrags
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZKV3 { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - ermäßigt - ohne Zusatzbeitrag (Beitragsgruppe 3000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITR3 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum PV-Beitrag
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZPV { get; set; }

        /// <summary>
        /// Holt oder setzt den PV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Pflegeversicherung (Beitragsgruppen 0001 und 0002) mit Centangaben, Länge 11, Mussangabe
        /// </remarks>
        public int PVBEITR { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum RV-Beitrag
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZRV1 { get; set; }

        /// <summary>
        /// Holt oder setzt den RV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung (Beitragsgruppen 0100) mit Centangaben, Länge 11, Mussangabe
        /// </remarks>
        public int RVBEITR1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zur Arbeitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZAV1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Abreitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Abreitslosenversicherung - voller Beitrag - (Beitragsgruppe 0010) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int AVBEITR1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZRV3 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung - halber Beitrag - (Beitragsgruppe 0300) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int RVBEITR3 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zur Insolvenzgeldversicherung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZINSG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Insolvenzgeldversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung (Beitragsgruppe 0050) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int INSGU { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zur Arbeitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZAV2 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Abreitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Abreitslosenversicherung - halber Beitrag - (Beitragsgruppe 0020) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int AVBEITR2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zur Umlage Krankheitsaufwendung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZU1 { get; set; }

        /// <summary>
        /// Holt oder setzt die Umlage Krankheitsaufwendung
        /// </summary>
        /// <remarks>
        /// Umlage Krankheitsaufwendung (Beitragsgruppe U1) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int U1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zur Umlage Krankheitsaufwendung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZU2 { get; set; }

        /// <summary>
        /// Holt oder setzt die Umlage Mutterschaftsaufwendung
        /// </summary>
        /// <remarks>
        /// Umlage Mutterschaftsaufwendung (Beitragsgruppe U2) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int U2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum Pauschal-Beitrag zur Krankenversicherung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZKV6 { get; set; }

        /// <summary>
        /// Holt oder setzt den Pauschal-Beitrag zur Krankenversicherung
        /// </summary>
        /// <remarks>
        /// Pauschal-Beitrag zur Krankenversicherung (Beitragsgruppe 6000) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITR6 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum Pauschal-Beitrag zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZRV5 { get; set; }

        /// <summary>
        /// Holt oder setzt den Pauschal-Beitrag zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Pauschal-Beitrag zur Rentenversicherung (Beitragsgruppe 0500) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int RVBEITR5 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zur Zwischensumme
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZZWS { get; set; }

        /// <summary>
        /// Holt oder setzt die Zwischensumme
        /// </summary>
        /// <remarks>
        /// Zwischensumme der Stellen 183-317, Länge 11, Mussangabe
        /// </remarks>
        public int ZWS { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum Beitrag zur Krankenversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZKVF { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Krankenversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankenversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int KVBEITRF { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum Beitrag zur Pflegeversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZPVF { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitrag zur Pflegeversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Beitrag zur Pflegeversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int PVBEITRF { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum Erstattungbetrag der Arbeitgeberaufwendungen
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZERSTU1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Erstattungbetrag der Arbeitgeberaufwendungen
        /// </summary>
        /// <remarks>
        /// Erstattungbetrag der Arbeitgeberaufwendungen bei Krankheit und Mutterschaft mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int ERSTAAG { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum Zusatzbetrag zur Krankversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZZBF { get; set; }

        /// <summary>
        /// Holt oder setzt den Zusatzbetrag zur Krankversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Zusatzbetrag zur Krankversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int ZBF { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZBEITR2 { get; set; }

        /// <summary>
        /// Holt oder setzt den wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Wahlweise; z.B zur Seemannskasse - Arbeitgeberanteil - mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int BEITR2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zum wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZBEITR3 { get; set; }

        /// <summary>
        /// Holt oder setzt den wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Wahlweise; z.B zur Seemannskasse - Arbeitgeberanteil - mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int BEITR3 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen zur Summe
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob positiver oder negativer Beitrag, Länge 1, Mussangabe
        /// </remarks>
        public string VZSUM { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe
        /// </summary>
        /// <remarks>
        /// Zahlbetrag/Guthaben (Summe Stellen 318-401) mit Centeingabe, Länge 11, Mussangabe
        /// </remarks>
        public int SUM { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen
        /// </summary>
        public string VZKV1SA { get; set; }

        /// <summary>
        /// Holt oder setzt den Betrag
        /// </summary>
        public int KVBEITR1SA { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen
        /// </summary>
        public string VZKV3SA { get; set; }

        /// <summary>
        /// Holt oder setzt den Betrag
        /// </summary>
        public int KVBEITR3SA { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen
        /// </summary>
        public string VZKVFSA { get; set; }

        /// <summary>
        /// Holt oder setzt den Betrag
        /// </summary>
        public int KVBEITRFSA { get; set; }

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
        /// Holt oder setzt das Vorzeichen zur einheitlichen Pauschalsteuer
        /// </summary>
        /// <remarks>
        /// Kennzeiche, ob positiver oder negativer Betrag
        /// Länge 1, Mussangabe
        /// </remarks>
        public string VZBEITR { get; set; }

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
        /// Länge 20, Plichtangabe, soweit bekannt
        /// </remarks>
        public string STNR { get; set; }

        /// <summary>
        /// Holt oder setzt eine Auflistung von DBFE-Fehler
        /// </summary>
        /// <remarks>
        /// Es folgen ggf. ein oder mehrere Datenbausteine DBFE-Fehler gemäß den Angaben in dem FEKZ.
        /// Die Anzahl der Fehler-Datenbausteine ergibt sich aus dem Feld FEAN.
        /// </remarks>
        public IList<DBFE> DBFE { get; set; }
    }
}
