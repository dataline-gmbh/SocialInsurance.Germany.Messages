// <copyright file="IVerfahrenkennzeichen.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Informationen über das Verfahren
    /// </summary>
    public interface IVerfahrenkennzeichen
    {
        /// <summary>
        /// Holt das Kennzeichen für das Verfahren für den <code>DSKO</code>- und die Nutzdatensätze (z.B. <code>UVSDD</code>)
        /// </summary>
        string Verfahren { get; }

        /// <summary>
        /// Holt das Kennzeichen für Meldedateien für das Verfahren (z.B. <code>UVS</code>)
        /// </summary>
        string Dateikennung { get; }

        /// <summary>
        /// Holt das Verfahrensmerkmal für die <code>VOSZ</code>- und <code>NCSZ</code>-Datensätze (z.B. <code>UNUVS</code>)
        /// </summary>
        string Merkmal { get; }
    }
}
