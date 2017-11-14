﻿// <copyright file="DBSV.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBSV - Sozialversicherungsausweis
    /// </summary>
    public class DBSV : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBSV"/> Klasse
        /// </summary>
        public DBSV()
        {
            KE = "DBSV";
            KENNZSVA = true;
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das SV-Ausweis Kennzeichen.
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob ein SV-Ausweis zu erstellen ist, Länge 1, Mussangabe
        /// J = SV-Ausweis ausstellen
        /// </remarks>
        public bool KENNZSVA { get; set; }
    }
}
