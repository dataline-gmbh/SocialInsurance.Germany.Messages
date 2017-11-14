﻿// <copyright file="DBAZ.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBAZ - Anrechnungszeiten
    /// </summary>
    public class DBAZ : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBAZ"/> Klasse
        /// </summary>
        public DBAZ()
        {
            KE = "DBAZ";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob eine Stornierung vorliegt
        /// </summary>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt die Angaben zu der gemeldeten Zeit
        /// </summary>
        /// <remarks>
        /// Angaben zu der gemeldeten Zeit, Länge 2, Mussangabe
        /// </remarks>
        public int LEAT { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ZRBG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ZREN { get; set; }
    }
}
