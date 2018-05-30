// <copyright file="DBSB.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Sozialversicherungdaten B
    /// </summary>
    public class DBSB : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBSB";

        /// <summary>
        /// Beginn der Änderung der Personen- und/oder Beitragsgruppe.
        /// </summary>
        public LocalDate PERSBYGRBEG { get; set; }

        /// <summary>
        /// Beitragsgruppe B;
        /// Beitragsgruppenschlüssel
        /// </summary>
        public int BYGRB { get; set; }

        /// <summary>
        /// Personengruppe B
        /// </summary>
        public int PERSGRB { get; set; }
    }
}
