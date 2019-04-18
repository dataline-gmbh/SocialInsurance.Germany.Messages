// <copyright file="DBBE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Höhe der beitragspflichtigen Einnahmen (§ 23c SGB IV)
    /// </summary>
    public class DBBE : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBBE"/>-Objekt.
        /// </summary>
        public DBBE()
        {
            KE = "DBBE";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Zahlung.
        /// </summary>
        public LocalDate ZAHLBEGINN { get; set; }

        /// <summary>
        /// Holt oder setzt die Höhe der monatlichen beitragspflichtigen Einnahmen brutto.
        /// </summary>
        public int? BEITRPFLBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt die Höhe der monatlichen beitragspflichtigen Einnahmen netto.
        /// </summary>
        public int BEITRPFLNETTO { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des teilweise anrechenbaren Zeitraum der vorherigen AU.
        /// </summary>
        public LocalDate? TEILANRAUBEGINN { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des teilweise anrechenbaren Zeitraum der vorherigen AU.
        /// </summary>
        public LocalDate? TEILANRAUENDE { get; set; }
    }
}
