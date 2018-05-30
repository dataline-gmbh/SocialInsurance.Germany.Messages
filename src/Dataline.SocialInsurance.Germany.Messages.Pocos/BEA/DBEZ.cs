// <copyright file="DBEZ.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Arbeitszeit EU
    /// </summary>
    public class DBEZ : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBEZ";

        /// <summary>
        /// Vereinbarte durchschnittliche Wochenarbeitszeit in Stunden.
        /// </summary>
        public int AZWOECH { get; set; }

        /// <summary>
        /// Grund für eine Änderung der regelmäßigen Wochenarbeitszeit
        /// </summary>
        public ArbeitszeitaenderungGrund AZAEGR { get; set; }

        /// <summary>
        /// Beginn der Arbeitszeitänderung
        /// </summary>
        public LocalDate? AZAEBEG { get; set; }

        /// <summary>
        /// Durchschnittliche wöchentliche Arbeitszeit des gesamten bescheinigten Beschäftigungsverhältnisses
        /// </summary>
        public int AZDUWOECH { get; set; }

        /// <summary>
        /// Durchschnittliche Anzahl Arbeitstage pro Woche während des bescheinigten Beschäftigungsverhältnisses
        /// </summary>
        public int ATDUWOE { get; set; }
    }
}
