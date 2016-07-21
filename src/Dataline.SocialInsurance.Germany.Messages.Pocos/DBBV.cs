// <copyright file="DBBV.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBBV - Bankverbindung
    /// </summary>
    public class DBBV : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBBV"/> Klasse
        /// </summary>
        public DBBV()
        {
            KE = "DBBV";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Überweisung oder Verrechnung/Gutschrift mit Beitragskonto
        /// </summary>
        /// <remarks>
        /// Überweisung oder Verrechnung/Gutschrift mit Beitragskonto, Länge 1, Mussangabe
        /// 0 = Überweisung, 1 = Verrechnung, 2 = Gutschrift
        /// </remarks>
        public int ÜBVER { get; set; }

        /// <summary>
        /// Holt oder setzt die Verrechnung mit dem Beitragsnachweismonat
        /// </summary>
        /// <remarks>
        /// Verrechnung mit dem Beitragsnachweismonat, Länge 6, Mussangabe unter Bedingungen
        /// </remarks>
        public int VERMO { get; set; }

        /// <summary>
        /// Holt oder setzt die Kontonummer/IBAN des Vertragspartners
        /// </summary>
        /// <remarks>
        /// Kontonummer/IBAN des Vertragspartners, linksbündig beginnend, Länge 34, Kannangabe
        /// </remarks>
        public string IBAN { get; set; }

        /// <summary>
        /// Holt oder setzt die BIC oder sonstige Identifikation der Bank
        /// </summary>
        /// <remarks>
        /// BIC der Bank oder sonstige Identifikation, Länge 11, Kannangabe
        /// </remarks>
        public string BIC { get; set; }

        /// <summary>
        /// Holt oder setzt die Angabe des Kontoinhabers
        /// </summary>
        /// <remarks>
        /// Angabe des Kontoinhabers in der Form: Name, Vorname, Länge 50, Mussangabe unter Bedingungen
        /// </remarks>
        public string KTOINH { get; set; }

        /// <summary>
        /// Holt oder setzt den Verwendungszweck
        /// </summary>
        /// <remarks>
        /// Verwendungszweck, Länge 50, Kannangabe
        /// </remarks>
        public string VERWZWECK { get; set; }
    }
}
