// <copyright file="VOSZ_FELANG.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: VOSZ - Vorlaufsatz
    /// </summary>
    public class VOSZ_FELANG : VOSZ
    {
        /// <summary>
        /// Holt oder setzt eine lange Fehlermeldung
        /// </summary>
        protected string FELANG { get; set; }
    }
}
