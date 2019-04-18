// <copyright file="DBEE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Ende Entgeltersatzleistung
    /// </summary>
    public class DBEE : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBEE"/>-Objekt.
        /// </summary>
        public DBEE()
        {
            KE = "DBEE";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Entgeltersatzleistung durch den Arbeitgeber.
        /// </summary>
        public LocalDate? EELABAG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Entgeltersatzleistung durch den SV-Träger.
        /// </summary>
        public LocalDate? EELABSV { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende der Entgeltersatzleistung
        /// </summary>
        public LocalDate? EELENDE { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Beendigung der Entgeltersatzleistung.
        /// </summary>
        public int EELENDEGRUND { get; set; }
    }
}
