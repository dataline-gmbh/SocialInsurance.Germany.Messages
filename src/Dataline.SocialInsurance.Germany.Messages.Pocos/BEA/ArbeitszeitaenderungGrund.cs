// <copyright file="ArbeitszeitaenderungGrund.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Gründe für Änderungn der regelmäßigen Wochenarbeitszeit
    /// </summary>
    public enum ArbeitszeitaenderungGrund
    {
        /// <summary>Die Grundstellung.</summary>
        Grundstellung = 0,

        /// <summary>Altersteilzeitvereinbarung - wenn Aufstockungsbeträge nach § 3 Abs. 1 ATG gezahlt werden</summary>
        Altersteilzeitvereinbarung,

        /// <summary>Vereinbarung über flexible Arbeitszeiten mit Arbeitsphasen und Freizeitphasen (§ 7 Abs. 1a SGB IV)</summary>
        VereinbarungFlexibleArbeitszeiten,

        /// <summary>Elternzeit</summary>
        Elternzeit,

        /// <summary>Pflegezeit gem. § 3 Abs. 1 Satz 1 PflegeZG</summary>
        Pflegezeit,

        /// <summary>Vollzeit auf Teilzeit</summary>
        VollzeitAufTeilzeit,

        /// <summary>Änderung innerhalb der Teilzeit</summary>
        AenderungInnerhalbTeilzeit,

        /// <summary>Teilzeit auf Vollzeit</summary>
        TeilzeitAufVollzeit,

        /// <summary>Beschäftigungsvereinbarung (§ 419 Abs. 7 SGB III)</summary>
        Beschaeftigungssicherungsvereinbarung,

        /// <summary>Familienpflegezeit und Nachpflegephase nach dem Familienpflegezeitgesetz</summary>
        Familienpflegezeit,

        /// <summary>Änderung immerhalb der Vollzeit</summary>
        AenderungInnerhalbVollzeit,

        /// <summary>Sonstiges</summary>
        Sonstiges,

        /// <summary>Betreuungs-/Begleitzeit gem. § 3 Abs. 5 Satz 1, Abs. 6 Satz 1 PflegeZG</summary>
        BetreuungsBegleitzeit,
    }
}
