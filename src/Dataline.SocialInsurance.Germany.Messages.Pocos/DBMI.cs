// <copyright file="DBMI.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBMI - Datenbaustein Mitgliedsidentifikation
    /// </summary>
    public class DBMI : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBMI"/> Klasse
        /// </summary>
        public DBMI()
        {
            KE = "DBMI";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennung des Arbeitnehmers beim Arbeitgeber
        /// </summary>
        /// <remarks>
        /// Kennung des Arbeitnehmers beim Arbeitgeber(z.B. Personalnummer), Länge 20, Mussangabe
        /// </remarks>
        public string KEAN { get; set; }

        /// <summary>
        /// Holt oder setzt den Familiennamen
        /// </summary>
        /// <remarks>
        /// Familienname, Länge 30, Mussangabe
        /// </remarks>
        public string FMNA { get; set; }

        /// <summary>
        /// Holt oder setzt den Vornamen
        /// </summary>
        /// <remarks>
        /// Vorname, Länge 30, Mussangabe
        /// </remarks>
        public string VONA { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorsatzwort
        /// </summary>
        /// <remarks>
        /// Vorsatzwort(z.B. von, zu), Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string VOSA { get; set; }

        /// <summary>
        /// Holt oder setzt den Namenszusatz
        /// </summary>
        /// <remarks>
        /// Namenszusatz(z.B. Baronin, Graf), Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAZU { get; set; }

        /// <summary>
        /// Holt oder setzt den Titel
        /// </summary>
        /// <remarks>
        /// Titel(z.B. Dr., Prof.), Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string TITEL { get; set; }

        /// <summary>
        /// Holt oder setzt das Geschlecht
        /// </summary>
        /// <remarks>
        /// Geschlecht, M = männlich, W = weiblich, Länge 1, Mussangabe
        /// </remarks>
        public string GE { get; set; }

        /// <summary>
        /// Holt oder setzt das Geburtsdatum
        /// </summary>
        /// <remarks>
        /// Geburtsdatum, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate GBDT { get; set; }
    }
}
