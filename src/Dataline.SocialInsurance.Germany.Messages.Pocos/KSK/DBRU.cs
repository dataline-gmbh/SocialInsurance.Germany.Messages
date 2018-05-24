// <copyright file="DBRU.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.KSK
{
    /// <summary>
    /// Datenbaustein Ruhensanordnung
    /// </summary>
    public class DBRU : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBRU";

        /// <summary>
        /// Kennzeichen, ob dies eine Stornierung einer bereits abgegebenen Meldung ist.
        /// </summary>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Mitteilungsgrund
        /// </summary>
        public RuhensanordnungMitteilungsgrund MIGR { get; set; }

        /// <summary>
        /// Beginn des Ruhens nach § 16 Abs. 2 KSVG
        /// </summary>
        public LocalDate DATBGR { get; set; }

        /// <summary>
        /// Ende des Ruhens nach § 16 Abs. 2 KSVG
        /// </summary>
        public LocalDate DATEDR { get; set; }
    }
}
