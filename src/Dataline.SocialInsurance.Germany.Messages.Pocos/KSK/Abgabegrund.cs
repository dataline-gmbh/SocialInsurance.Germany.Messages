// <copyright file="Abgabegrund.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.KSK
{
    /// <summary>
    /// Schlüsselzahlen für die Abgabegründe in den Meldungen nach § 28a Abs. 13 SGB IV
    /// </summary>
    public enum Abgabegrund
    {
        /// <summary>Monatliche Meldung</summary>
        MonatlicheMeldung = 1,

        /// <summary>Meldung über eine Ruhensanordnung</summary>
        MeldungUeberRuhensanordnung,
    }
}
