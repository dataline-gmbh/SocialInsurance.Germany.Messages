// <copyright file="DSEKext02.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DSEKext02
    {
        /// <summary>
        /// Holt oder setzt das Gültigkeitsdatum ab
        /// </summary>
        public LocalDate GLTAB { get; set; }

        /// <summary>
        /// Holt oder setzt das Änderungsdatum
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Änderung der Daten, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime AENDDAT { get; set; }

        /// <summary>
        /// Holt oder setzt den gewählten Erstattungssatz in %
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int ERSTSATZ { get; set; }
    }
}
