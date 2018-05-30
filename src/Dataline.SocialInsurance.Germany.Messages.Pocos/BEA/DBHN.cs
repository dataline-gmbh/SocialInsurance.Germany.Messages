// <copyright file="DBHN.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Heimarbeiter Nebeneinkommen
    /// </summary>
    public class DBHN : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBHN";

        /// <summary>
        /// Tag der Ausgabe, falls das Einkommen durch Heimarbeit erzielt wurde.
        /// </summary>
        public LocalDate? HEIMARBAUSG { get; set; }

        /// <summary>
        /// Tag der Ablieferung, falls das Einkommen durch Heimarbeit erzielt wurde.
        /// </summary>
        public LocalDate? HEIMARBABL { get; set; }
    }
}
