// <copyright file="DBAW.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Abwesenheiten ohne Arbeitsentgelt
    /// </summary>
    public class DBAW : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBAW"/>-Objekt.
        /// </summary>
        public DBAW()
        {
            KE = "DBAW";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der Tage in Zeitraum 1.
        /// </summary>
        public int TAGE1 { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der Tage in Zeitraum 2.
        /// </summary>
        public int TAGE2 { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der Tage in Zeitraum 3.
        /// </summary>
        public int TAGE3 { get; set; }
    }
}
