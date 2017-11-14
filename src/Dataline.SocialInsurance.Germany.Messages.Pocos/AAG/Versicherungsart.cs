// <copyright file="Versicherungsart.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.AAG
{
    /// <summary>
    /// Art der Versicherung
    /// </summary>
    public enum Versicherungsart
    {
        /// <summary>
        /// In der GKV versichert
        /// </summary>
        GKV = 0,

        /// <summary>
        /// Privat versichert
        /// </summary>
        Privat,

        /// <summary>
        /// LKK-versichert
        /// </summary>
        LKK,

        /// <summary>
        /// Geringfügige Beschaeftigung
        /// </summary>
        GeringfuegigeBeschaeftigung,
    }
}
