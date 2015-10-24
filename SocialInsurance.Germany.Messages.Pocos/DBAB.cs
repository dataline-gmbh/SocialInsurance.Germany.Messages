// <copyright file="DBAB.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBAB - Von der Arbeitgeberanschrift abweichender Beschäftigungsort
    /// </summary>
    public class DBAB : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBAB"/> Klasse
        /// </summary>
        public DBAB()
        {
            KE = "DBAB";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Länderkennzeichen bei ausländischen Anschriften
        /// </summary>
        /// <remarks>
        /// Bei ausländischen Anschriften muss hier das Länder(Kfz)kennzeichen angegeben werden, Länge 3, Mussangabe
        /// </remarks>
        public string BORTLDKZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl des Beschäftigungsortes
        /// </summary>
        /// <remarks>
        /// Postleitzahl des Beschäftigungsortes, Länge 10, Mussangabe
        /// Bei inländischen Anschriften muss die Postleitzahl 5 Stellen
        /// numerisch sein (linksbündig mit nachfolgenden Leerzeichen).
        /// </remarks>
        public string BPLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort der Beschäftigung
        /// </summary>
        /// <remarks>
        /// Ort der Beschäftigung, Länge 34, Mussangabe
        /// </remarks>
        public string BORT { get; set; }
    }
}
