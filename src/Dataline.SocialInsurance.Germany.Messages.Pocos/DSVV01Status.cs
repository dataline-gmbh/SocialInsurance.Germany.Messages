// <copyright file="DSVV01Status.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Ergebnis der Prüfung bei der DSRV
    /// </summary>
    /// <remarks>
    /// Bei der Anfrage ist nur die Grundstellung zulässig.
    /// </remarks>
    public enum DSVV01Status
    {
        /// <summary>
        /// Bei der Anfrage ist nur die Grundstellung zulässig
        /// </summary>
        Grundstellung = 0,

        /// <summary>
        /// Keine Versicherungsnummer gefunden
        /// </summary>
        KeinErgebnis = 1,

        /// <summary>
        /// Versicherungsnummer gefunden
        /// </summary>
        EindeutigesErgebnis = 2,

        /// <summary>
        /// Versicherungsnummer möglicherweise gefunden
        /// </summary>
        KeinEindeutigesErgebnis = 3,
    }
}
