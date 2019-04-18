// <copyright file="DBAL.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Allgemeines
    /// </summary>
    public class DBAL : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBAL"/>-Objekt.
        /// </summary>
        public DBAL()
        {
            KE = "DBAL";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt.</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt, ab wann die AU/med. Leistung/LT beginnt.
        /// </summary>
        /// <remarks>AU = Arbeitsunfähigkeit, med. Leistung = Medizinische Rehabilitation, LT = Leistung zur Teilhabe am Arbeitsleben</remarks>
        public LocalDate? DATUMAB { get; set; }

        /// <summary>
        /// Holt oder setzt, ob am ersten Tag der AU/med. Leistung/LT gearbeitet wurde.
        /// </summary>
        public bool AEERSTTAG { get; set; }

        /// <summary>
        /// Holt oder setzt, bis wann das Arbeitsentgelt fortgezahlt wird.
        /// </summary>
        public LocalDate DATUMEZGBIS { get; set; }

        /// <summary>
        /// Holt oder setzt, wann das Beschäftigungsverhältnis beendet wurde.
        /// </summary>
        public LocalDate? ENDEBVAM { get; set; }

        /// <summary>
        /// Holt oder setzt, zu wann das Beschäftigungsverhältnis beendet wurde.
        /// </summary>
        public LocalDate? ENDEBVZUM { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Beendigung des Arbeitsverhältnisses.
        /// </summary>
        public int? GRUNDBEEND { get; set; }

        /// <summary>
        /// Holt oder setzt, ob der Pflegezuschlag für Kinderlose gezahlt wird.
        /// </summary>
        public bool PFLZUSCHLAG { get; set; }

        /// <summary>
        /// Holt oder setzt, ob der Arbeitnehmer am Arbeitszeitmodell (Wertguthaben §7 Abs. 1a SGB IV) teilnimmt.
        /// </summary>
        public bool ARBZEITMOD { get; set; }

        /// <summary>
        /// Holt oder setzt, ob der Arbeitnehmer im maßgebenden Abrechnungszeitraum von Kurzarbeit betroffen war.
        /// </summary>
        /// <value>0 = kein KUG, 1 = KUG, 2 = Saison-Kug, 3 = Transfer-KUG</value>
        public int MMKUG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des KUG-Zeitraums.
        /// </summary>
        public LocalDate? KUGBEGINN { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des KUG-Zeitraums.
        /// </summary>
        public LocalDate? KUGENDE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums 1 für Lohnausgleich im Baugewerbe.
        /// </summary>
        public LocalDate? LAGBEGINN1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums 1 für Lohnausgleich im Baugewerbe.
        /// </summary>
        public LocalDate? LAGENDE1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums 2 für Lohnausgleich im Baugewerbe.
        /// </summary>
        public LocalDate? LAGBEGINN2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums 2 für Lohnausgleich im Baugewerbe.
        /// </summary>
        public LocalDate? LAGENDE2 { get; set; }
    }
}
