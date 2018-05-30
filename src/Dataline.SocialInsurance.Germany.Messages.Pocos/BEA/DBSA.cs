// <copyright file="DBSA.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Sozialversicherungsdaten A
    /// </summary>
    public class DBSA : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBSA";

        /// <summary>
        /// Beitragsgruppe A;
        /// Beitragsgruppenschlüssel ab Beginn des Arbeitsverhältnisses
        /// </summary>
        public int BYGRA { get; set; }

        /// <summary>
        /// Personengruppe A, ab Beginn des Arbeitsverhältnisses
        /// </summary>
        public int PERSGRA { get; set; }

        /// <summary>
        /// Gibt an, ob der/die AN wegen ihrer Beschäftigung der knappschaftlichen RV angehört.
        /// </summary>
        public bool? KNAPPRV { get; set; }

        /// <summary>
        /// Beginn der knappschaftlichen RV
        /// </summary>
        public LocalDate? KNAPPRVBEG { get; set; }

        /// <summary>
        /// Tätigkeitsschlüssel, Angabe der Tätigkeit die zuletzt ausgeübt wurde.
        /// </summary>
        public string TTSC { get; set; }
    }
}
