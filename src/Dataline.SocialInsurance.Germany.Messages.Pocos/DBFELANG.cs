// <copyright file="DBFELANG.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBFE - Fehler für VOSZ v01 mit langer Fehlermeldung
    /// </summary>
    public class DBFELANG : DBFE
    {
        /// <summary>
        /// Fehler-Langmeldung
        /// </summary>
        /// <remarks>
        /// Im Moment immer leer
        /// </remarks>
        public string FELANG { get; set; }
    }
}
