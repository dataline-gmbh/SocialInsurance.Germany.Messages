// <copyright file="DBAZ.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Arbeitszeit
    /// </summary>
    public class DBAZ : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBAZ";

        /// <summary>
        /// Vereinbarte regelmäßige durschnittliche Wochenarbeitszeit in Stunden.
        /// </summary>
        /// <remarks>Je 2 Vor- und Nachkommastellen</remarks>
        public int AZWOECH { get; set; }

        /// <summary>
        /// Die durchschnittliche Arbeitszeit eines vergleichbaren Vollzeitbeschäftigten in Stunden pro Woche.
        /// </summary>
        /// <remarks>Je 2 Vor- und Nachkommastellen</remarks>
        public int AZVG { get; set; }

        /// <summary>
        /// Grund für eine Änderung der regelmäßigen Wochenarbeitszeit
        /// </summary>
        public ArbeitszeitaenderungGrund AZAEGR { get; set; }

        /// <summary>
        /// Beginn der Arbeitszeitänderung
        /// </summary>
        public LocalDate? AZAEBEG { get; set; }
    }
}
