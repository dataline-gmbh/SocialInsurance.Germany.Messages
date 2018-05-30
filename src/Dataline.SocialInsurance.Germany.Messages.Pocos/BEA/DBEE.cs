// <copyright file="DBEE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Entgeltdaten EU
    /// </summary>
    public class DBEE : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBEE";

        /// <summary>
        /// Anfangsdatum des Zeitraums innerhalb des Meldemonats, für den Entgelt gemeldet wird
        /// </summary>
        public LocalDate MONATBEGEU { get; set; }

        /// <summary>
        /// Enddatum des Zeitraums innerhalb des Meldemonats, für den Entgelt gemeldet wird.
        /// </summary>
        public LocalDate MONATENDEU { get; set; }

        /// <summary>
        /// Laufendes steuerpflichtes Bruttoarbeitsentgelt
        /// </summary>
        public long STBREGLFEU { get; set; }

        /// <summary>
        /// Sonstiges steuerpflichtiges Bruttoarbeitsentgelt
        /// </summary>
        public long STBREGSOEU { get; set; }
    }
}
