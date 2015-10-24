// <copyright file="IDatenbaustein.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Schnittstelle für Datenbausteine
    /// </summary>
    public interface IDatenbaustein
    {
        /// <summary>
        /// Holt die Kennung des Datenbausteins
        /// </summary>
        string KE { get; }
    }
}
