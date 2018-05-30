// <copyright file="KuendigungDurch.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Durch wen oder was wurde das Arbeitsverhältnis beendet?
    /// </summary>
    public enum KuendigungDurch
    {
        /// <summary>Grundstellung</summary>
        Grundstellung = 0,

        /// <summary>Arbeitgeber</summary>
        Arbeitgeber = 1,

        /// <summary>Arbeitnehmer, der AG hätte nicht oder später gekündigt</summary>
        Arbeitnehmer_AGHaetteNichtOderSpaeterGekuendigt,

        /// <summary>Arbeitnehmer, der AG hätte zum selben Zeitpunkt gekündigt</summary>
        Arbeitnehmer_AGHaetteGleichzeitigGekuendigt,

        /// <summary>Aufhebungsvertrag, der AG hätte nicht oder später gekündigt</summary>
        Aufhebungsvertrag_AGHaetteNichtOderSpaeterGekuendigt,

        /// <summary>Aufhebungsvertrag, der AG hätte zum selben Zeitpunkt gekündigt</summary>
        Aufhebungsvertrag_AGHaetteGleichzeitigGekuendigt,

        /// <summary>Kraft Gesetz oder Tarifvertrag</summary>
        Gesetz,
    }
}
