// <copyright file="DBSE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Steuerliche Eckdaten
    /// </summary>
    public class DBSE : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBSE";

        /// <summary>
        /// Steuerklasse des Arbeitnehmers
        /// </summary>
        /// <value>0 bis 6</value>
        public int STKL { get; set; }

        /// <summary>
        /// Faktor der Steuerberechnung
        /// </summary>
        /// <remarks>3 Nachkommastellen</remarks>
        public int FKT { get; set; }

        /// <summary>
        /// Kinderfreibetrag des Arbeitnehmers
        /// </summary>
        /// <remarks>1 Nachkommastelle</remarks>
        public int KINDFRB { get; set; }

        /// <summary>
        /// Änderungsdatum/Änderung Steuereckdaten Beginn
        /// </summary>
        public LocalDate? AESTEDATBEG { get; set; }
    }
}
