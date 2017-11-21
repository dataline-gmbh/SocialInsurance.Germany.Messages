// <copyright file="DBFE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBFE - Fehler
    /// </summary>
    public class DBFE : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBFE"/> Klasse
        /// </summary>
        public DBFE()
        {
            KE = "DBFE";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Fehlernummer
        /// </summary>
        /// <remarks>
        /// Fehlernummer, 7 Stellen plus 1 Leerzeichen plus Fehlertext (z. B. : xxxxxxx Entgelt überschreitet die BBG), Länge 72
        /// </remarks>
        public string FE { get; set; }
    }
}
