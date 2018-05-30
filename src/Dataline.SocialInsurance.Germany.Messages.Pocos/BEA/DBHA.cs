// <copyright file="DBHA.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Heimarbeiter
    /// </summary>
    public class DBHA : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBHA";

        /// <summary>
        /// Anzahl der zu beanspruchenden Urlaubstage
        /// </summary>
        public int URLTAGE { get; set; }
    }
}
