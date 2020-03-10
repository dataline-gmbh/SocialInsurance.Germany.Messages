// <copyright file="DBS1ext04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>
using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DBS1ext04
    {
        /// <summary>
        /// Holt oder setzt das Gültigkeitsdatum ab
        /// </summary>
        public LocalDate GLTAB { get; set; }

        /// <summary>
        /// Holt oder setzt den SV-Wechselkurs (USD > EUR) in EUR
        /// </summary>
        public int WK { get; set; }
    }
}
