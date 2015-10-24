// <copyright file="BW03.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// BW03 - Datensatz Beitragsnachweis der Zahlstellen
    /// </summary>
    public class BW03 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="BW03"/> Klasse.
        /// </summary>
        public BW03()
        {
            KE = "BW03";
            VF = "BWBNV";
            DBFE = new List<DBFE>();
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
        /// Holt oder setzt die Zahl Zahlstellennummer/Betriebsnummer
        /// </summary>
        /// <remarks>
        /// Zahlstellennummer oder Betriebsnummer der Zahlstelle (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string BBNRZA { get; set; }

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
        /// Holt oder setzt das Vorzeichen zum Zusatzbeitrag/Pflichtbeitrag
        /// </summary>
        /// <remarks>
        /// Zurzeit nicht belegt (nur Grundstellung zulässig), Länge 1, Mussangabe
        /// </remarks>
        public string VZZBP { get; set; }

        /// <summary>
        /// Holt oder setzt den/die Zusatzbeitrag/Pflichtbeiträge
        /// </summary>
        /// <remarks>
        /// Zusatzbeitrag zur Krankversicherung für Pflichtversicherte mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int ZBP { get; set; }

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
        /// Holt oder setzt die laufende Nummer
        /// </summary>
        /// <remarks>
        /// Die laufende Nummer (01 - 999) ist anzugeben, wenn innerhalb eines Entgeltabrechungszeitraums mehr als ein Datensatz je Betriebsstätte übermittelt wird.
        /// Wird in Stelle 628 "S" angegeben, ist die laufende des zu stornierenden Datensatzes anzugeben.
        /// Länge 3, Mussangabe
        /// </remarks> /// <summary>
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
        /// Holt oder setzt eine Auflistung von DBFE-Fehler
        /// </summary>
        /// <remarks>
        /// Es folgen ggf. ein oder mehrere Datenbausteine DBFE-Fehler gemäß den Angaben in dem FEKZ.
        /// Die Anzahl der Fehler-Datenbausteine ergibt sich aus dem Feld FEAN.
        /// </remarks>
        public List<DBFE> DBFE { get; set; }
    }
}
