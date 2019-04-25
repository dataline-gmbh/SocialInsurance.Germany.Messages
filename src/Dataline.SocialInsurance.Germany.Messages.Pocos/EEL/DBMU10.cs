// <copyright file="DBMU10.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Zusatzdaten für die Berechnung des Übergangsgeldes bei Leistungen zur Teilhabe
    /// </summary>
    public class DBMU10 : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBMU"/>-Objekt.
        /// </summary>
        public DBMU10()
        {
            KE = "DBMU";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Schutzfrist.
        /// </summary>
        public LocalDate SCHUTZFRBEGINN { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Beschäftigungsverhältnisses.
        /// </summary>
        public LocalDate BVBEGINN { get; set; }

        /// <summary>
        /// Holt oder setzt den letzten bezahlten (SV-)Tag vor der Entbindung.
        /// </summary>
        public LocalDate? LETZTTAG { get; set; }

        /// <summary>
        /// Holt oder setzt, an welchem Tag das Beschäftigungsverhältnis beendet wurde.
        /// </summary>
        public LocalDate? ENDEBVAM { get; set; }

        /// <summary>
        /// Holt oder setzt, zu wann das Beschäftigungsverhältnis beendet wird/wurde.
        /// </summary>
        public LocalDate? ENDEBVZUM { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Beendigung des Beschäftigungsverhältnisses
        /// (vgl. Anlage 2 der Gemeinsamen Grundsätze)
        /// </summary>
        /// <value>Gültige Werte: Grundstellung (0) und 1-6.</value>
        public int BVGEKUEND { get; set; }

        /// <summary>
        /// Holt oder setzt das Nettoarbeitsentgelt während des Bezugs von Mutterschaftsgeld.
        /// </summary>
        public int WAEHREELNETTO { get; set; }

        /// <summary>
        /// Holt oder setzt, bis wann das Arbeitsentgelt gezahlt wird.
        /// </summary>
        /// <value>Ein Datum, <see langword="null"/> oder 99999999 (laufende Zahlung).</value>.
        public LocalDate? DATUMAEBIS { get; set; }

        /// <summary>
        /// Holt oder setzt den Schlüssel für die Fehlzeit vor Beginn der Schutzfrist
        /// oder bis zur Auflösung des Beschäftigungsverhältnisses.
        /// </summary>
        /// <value>Siehe Anlage 2 der Gemeinsamen Grundsätze.</value>
        public int FEHLZEIT { get; set; }

        /// <summary>
        /// Holt oder setzt, ob das Nettoarbeitsentgelt der letzten 3 abrechneten Kalendermonat
        /// vor Beginn der Schutzfrist regelmäßig mehr als 390 bvw. 403 EUR betrug.
        /// </summary>
        public bool AEUEBER { get; set; }

        /// <summary>
        /// Holt oder setzt die Entgeltart.
        /// </summary>
        /// <value>
        /// 0 = Grundstellung, 1 = Stundenlohn, 2 = festes Monatsentgelt, 3 = Sonstiges (Akkord-/Stücklohn o.ä.)
        /// </value>
        public int ENTGART { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des 1. Monats.
        /// </summary>
        public LocalDate? BEGINN1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des 1. Monats.
        /// </summary>
        public LocalDate? ENDE1 { get; set; }

        /// <summary>
        /// Holt oder setzt die bezahlten Arbeitsstunden im 1. Monat.
        /// </summary>
        public int BEZAZ1 { get; set; }

        /// <summary>
        /// Holt oder setzt die bezahlten Mehrarbeitsstunden von <see cref="BEZAZ1"/> im 1. Monat.
        /// </summary>
        public int MASTD1 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitsstunden (unentschuldigt) im 1. Monat.
        /// </summary>
        public int AZUNENTSTD1 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitstage (unentschuldigt) im 1. Monat.
        /// </summary>
        public int AZUNENTTAGE1 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitsstunden (entschuldigt) im 1. Monat.
        /// </summary>
        public int AZENTSCHSTD1 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitstage (entschuldigt) im 1. Monat.
        /// </summary>
        public int AZENTSCHTAGE1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Nettoarbeitsentgelt im 1. Monat.
        /// </summary>
        public int NETTO1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des 2. Monats.
        /// </summary>
        public LocalDate? BEGINN2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des 2. Monats.
        /// </summary>
        public LocalDate? ENDE2 { get; set; }

        /// <summary>
        /// Holt oder setzt die bezahlten Arbeitsstunden im 2. Monat.
        /// </summary>
        public int BEZAZ2 { get; set; }

        /// <summary>
        /// Holt oder setzt die bezahlten Mehrarbeitsstunden von <see cref="BEZAZ2"/> im 2. Monat.
        /// </summary>
        public int MASTD2 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitsstunden (unentschuldigt) im 2. Monat.
        /// </summary>
        public int AZUNENTSTD2 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitstage (unentschuldigt) im 2. Monat.
        /// </summary>
        public int AZUNENTTAGE2 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitsstunden (entschuldigt) im 2. Monat.
        /// </summary>
        public int AZENTSCHSTD2 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitstage (entschuldigt) im 2. Monat.
        /// </summary>
        public int AZENTSCHTAGE2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Nettoarbeitsentgelt im 2. Monat.
        /// </summary>
        public int NETTO2 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des 3. Monats.
        /// </summary>
        public LocalDate? BEGINN3 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des 3. Monats.
        /// </summary>
        public LocalDate? ENDE3 { get; set; }

        /// <summary>
        /// Holt oder setzt die bezahlten Arbeitsstunden im 3. Monat.
        /// </summary>
        public int BEZAZ3 { get; set; }

        /// <summary>
        /// Holt oder setzt die bezahlten Mehrarbeitsstunden von <see cref="BEZAZ3"/> im 3. Monat.
        /// </summary>
        public int MASTD3 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitsstunden (unentschuldigt) im 3. Monat.
        /// </summary>
        public int AZUNENTSTD3 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitstage (unentschuldigt) im 3. Monat.
        /// </summary>
        public int AZUNENTTAGE3 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitsstunden (entschuldigt) im 3. Monat.
        /// </summary>
        public int AZENTSCHSTD3 { get; set; }

        /// <summary>
        /// Holt oder setzt die unbezahlten Arbeitstage (entschuldigt) im 3. Monat.
        /// </summary>
        public int AZENTSCHTAGE3 { get; set; }

        /// <summary>
        /// Holt oder setzt das Nettoarbeitsentgelt im 3. Monat.
        /// </summary>
        public int NETTO3 { get; set; }

        /// <summary>
        /// Holt oder setzt die regelmäßige wöchentliche Arbeitszeit.
        /// </summary>
        public int AZWOECH { get; set; }
    }
}
