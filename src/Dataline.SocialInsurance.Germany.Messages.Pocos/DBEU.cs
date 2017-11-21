﻿// <copyright file="DBEU.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBEU - Europäische Versicherungsnummer
    /// </summary>
    public class DBEU : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBEU"/> Klasse
        /// </summary>
        public DBEU()
        {
            KE = "DBEU";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Geburtsland
        /// </summary>
        /// <remarks>
        /// Geburtsland eines EU-/EWR-Staatsangehörigen, Länge 3, Mussangabe
        /// </remarks>
        public int GBLD { get; set; }

        /// <summary>
        /// Holt oder setzt die Europäische VSNR
        /// </summary>
        /// <remarks>
        /// Europäische VSNR, Stellen 008-027, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string EUVSNR { get; set; }
    }
}
