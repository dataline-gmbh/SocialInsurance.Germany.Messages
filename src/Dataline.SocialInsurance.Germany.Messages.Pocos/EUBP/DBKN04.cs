// <copyright file="DBKN04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBKN - Datenbaustein Knappschaft
    /// </summary>
    public class DBKN04 : IDatenbaustein
    {
        public DBKN04()
        {
            KE = "DBKN";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Tätigkeitsschlüssel Knappschaft
        /// </summary>
        /// <remarks>
        /// Länge 12, Mussangabe
        /// </remarks>
        public string KNVTTSC { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des knappschaftl. Beschäftigungsverhältnisses
        /// </summary>
        /// <remarks>
        /// Kannangabe
        /// </remarks>
        public LocalDate? KNVENVS { get; set; }

        /// <summary>
        /// Holt oder setzt den Abkehrgrund Knappschaft
        /// </summary>
        /// <remarks>
        /// Kannangabe
        /// 05 = Still-, Teilstill-, Zusammenlegung von Betrieben
        /// 06 = werkseitige Kündigung, wenn nicht 05
        /// 07 = Abmeldung wegen Krankheit, Unfallfolgen, Rentengewährung
        /// 08 = Abkehr auf eigenen Wunsch, Ablauf eines befristeten Arbeitsvertrages
        /// 09 = sonstige Gründe
        /// </remarks>
        public int? KNVABKGD { get; set; }
    }
}
