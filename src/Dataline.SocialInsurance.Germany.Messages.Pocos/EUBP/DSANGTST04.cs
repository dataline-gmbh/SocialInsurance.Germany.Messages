// <copyright file="DSANGTST04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DSANGTST04
    {
        /// <summary>
        /// Holt oder setzt die Betriebsnummer des zuständigen UV-Trägers
        /// </summary>
        /// <remarks>
        /// Länge 15, Kannangabe
        /// </remarks>
        public string BBNRUV { get; set; }

        /// <summary>
        /// Holt oder setzt die Mitgliedsnummer beim zuständigen UV-Träger
        /// </summary>
        /// <remarks>
        /// Länge 20, Kannangabe
        /// </remarks>
        public string MTNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des zuständigen UV-Trägers, dessen Gefahrtarif angewendet wird
        /// </summary>
        /// <remarks>
        /// Länge 15, Kannangabe
        /// </remarks>
        public string BBNRGTST { get; set; }

        /// <summary>
        /// Holt oder setzt die Gefahrtarifstelle
        /// </summary>
        /// <remarks>
        /// Länge 8, Kannangabe
        /// </remarks>
        public string GTST { get; set; }

        /// <summary>
        /// Holt oder setzt den Prozentsatz der Gefahrtarifstelle
        /// </summary>
        /// <remarks>
        /// Länge 3, Kannangabe
        /// </remarks>
        public int? GTSTSATZ { get; set; }
    }
}
