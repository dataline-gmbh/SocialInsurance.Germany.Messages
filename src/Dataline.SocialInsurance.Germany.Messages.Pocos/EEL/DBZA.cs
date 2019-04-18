// <copyright file="DBZA.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Arbeitszeit
    /// </summary>
    public class DBZA : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBZA"/>-Objekt.
        /// </summary>
        public DBZA()
        {
            KE = "DBZA";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der Stunden, in der das Bruttoarbeitsentgelt erzielt wurde.
        /// (3 Vor-, 2 Nachkommastellen)
        /// </summary>
        public int ANZAHLSTD { get; set; }

        /// <summary>
        /// Holt oder setzt die vereinbarte regelmäßige Arbeitszeit vor Beginn der AU/med. Leist./LT.
        /// (2 Vor- und Nachkommastellen.)
        /// </summary>
        public int REGAZ { get; set; }

        /// <summary>
        /// Holt oder setzt die bezahlten Mehrarbeitsstunden oder geleisteten Stunden bei unregelmäßiger Arbeitszeit.
        /// (3 Vor-, 2 Nachkommastellen)
        /// </summary>
        public int MAZR1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn von Zeitraum 2.
        /// </summary>
        public LocalDate? AZBEGINN2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende von Zeitraum 2.
        /// </summary>
        public LocalDate? AZENDE2 { get; set; }

        /// <summary>
        /// Holt oder setzt die bezahlten Mehrarbeitsstunden oder geleisteten Stunden bei unregelmäßiger Arbeitszeit im Zeitraum 2.
        /// (3 Vor-, 2 Nachkommastellen)
        /// </summary>
        public int MAZR2 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn von Zeitraum 3.
        /// </summary>
        public LocalDate? AZBEGINN3 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende von Zeitraum 3.
        /// </summary>
        public LocalDate? AZENDE3 { get; set; }

        /// <summary>
        /// Holt oder setzt die bezahlten Mehrarbeitsstunden oder geleisteten Stunden bei unregelmäßiger Arbeitszeit im Zeitraum 3.
        /// (3 Vor-, 2 Nachkommastellen)
        /// </summary>
        public int MAZR3 { get; set; }
    }
}
