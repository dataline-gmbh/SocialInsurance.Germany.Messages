// <copyright file="DBLT10.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Zusatzdaten für die Berechnung des Übergangsgeldes bei Leistungen zur Teilhabe
    /// </summary>
    public class DBLT10 : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBLT10"/>-Objekt.
        /// </summary>
        public DBLT10()
        {
            KE = "DBLT";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Beginn des Beschäftigungsverhältnisses.
        /// </summary>
        public LocalDate? BVSEIT { get; set; }

        /// <summary>
        /// Holt oder setzt, bis wann der Arbeitnehmer beschäftigt ist.
        /// </summary>
        public LocalDate? BVBIS { get; set; }

        /// <summary>
        /// Holt oder setzt, als was der Arbeitnehmer beschäftigt ist.
        /// </summary>
        public string BVALS { get; set; }

        /// <summary>
        /// Holt oder setzt, ob es sich um ein Ausbildungsverhältnis handelt.
        /// </summary>
        public bool AUSBVERH { get; set; }

        /// <summary>
        /// Holt oder setzt, ob aufgrund von Vorerkrankungen für weniger als 6 Wochen Entgeltfortzahlung besteht.
        /// </summary>
        public bool? VORER { get; set; }

        /// <summary>
        /// Holt oder setzt die während der LT weitergezahlten vermögenswirksamen Leistungen (monatl. Betrag).
        /// </summary>
        public int VWL { get; set; }

        /// <summary>
        /// Holt oder setzt die während der LT weitergezahlten Sachbezüge und Teilarbeitsentgelte (monatl. Gesamtbetrag brutto).
        /// </summary>
        public int BRUTTOSB { get; set; }

        /// <summary>
        /// Holt oder setzt die während der LT weitergezahlten Sachbezüge und Teilarbeitsentgelte (monatl. Gesamtbetrag netto).
        /// </summary>
        public int NETTOSB { get; set; }

        /// <summary>
        /// Holt oder setzt den Verzicht auf Beitragsfreiheit bei geringfügiger Beschäftigung.
        /// </summary>
        public bool? MMVERZICHTBEITRAGSFREI { get; set; }

        /// <summary>
        /// Holt oder setzt, ob Arbeitsentgelt in der Gleitzone liegt.
        /// </summary>
        public bool? AEUEBERGANGSBEREICH { get; set; }

        /// <summary>
        /// Holt oder setzt den Rechtskreis.
        /// </summary>
        /// <value>W oder O.</value>
        public string RECHTSKREIS { get; set; }
    }
}
