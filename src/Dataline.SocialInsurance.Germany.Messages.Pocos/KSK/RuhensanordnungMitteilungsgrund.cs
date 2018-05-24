// <copyright file="RuhensanordnungMitteilungsgrund.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.KSK
{
    /// <summary>
    /// Mitteilungsgründe für Baustein Ruhensanordnung (<see cref="DBRU"/>)
    /// </summary>
    public enum RuhensanordnungMitteilungsgrund
    {
        /// <summary>Beginn der Ruhensanordnung</summary>
        Beginn,

        /// <summary>Beginn und Ende einer Ruhensanordnung</summary>
        BeginnUndEnde,

        /// <summary>Ende der Ruhensanordnung</summary>
        Ende,
    }
}
