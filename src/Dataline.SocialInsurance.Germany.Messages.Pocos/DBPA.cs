// <copyright file="DBPA.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBPA - Abweichende Postanschrift
    /// <para />
    /// Gültig ab 01.07.2019
    /// </summary>
    public class DBPA : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBPA"/> Klasse
        /// </summary>
        public DBPA()
        {
            KE = "DBPA";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Name - Teil 1
        /// <para />
        /// Die Grundstellung (Leerzeichen) ist nur zulässig, wenn im Feld KENNZLPA der Wert „L“ angegeben ist.
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung - Teil 1, Länge 30, Mussangabe unter Bedingungen
        /// </remarks>
        public string NAMEPA1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Name - Teil 2
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung - Teil 2, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAMEPA2 { get; set; }

        /// <summary>
        /// Holt oder setzt den Name - Teil 3
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung - Teil 3, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAMEPA3 { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl
        /// <para />
        /// Die Grundstellung (Leerzeichen) ist nur zulässig, wenn im Feld KENNZLPA der Wert „L“ angegeben ist.
        /// </summary>
        /// <remarks>
        /// Postleitzahl(zustellbezogen)(5 Stellen numerisch linksbündig mit nachfolgenden Leerzeichen), Länge 10, Mussangabe unter Bedingungen
        /// </remarks>
        public string PLZPA { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort
        /// <para />
        /// Die Grundstellung (Leerzeichen) ist nur zulässig, wenn im Feld KENNZLPA der Wert „L“ angegeben ist.
        /// </summary>
        /// <remarks>
        /// Ort, Länge 34, Mussangabe unter Bedingungen
        /// </remarks>
        public string ORTPA { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße
        /// </summary>
        /// <remarks>
        /// Straße, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STRPA { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer
        /// </summary>
        /// <remarks>
        /// Hausnummer, Länge 9, Pflichtangabe, soweit bekannt
        /// Hinweis: Wenn die Hausnummer nicht separat abgelegt werden kann, ist es zulässig, die Hausnummer in das
        /// Feld Straße zu übernehmen. In solchen Fällen muss dann das Feld Hausnummer auf Grundstellung (Leerzeichen) stehen.
        /// </remarks>
        public string HNRPA { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl - Postfach
        /// </summary>
        /// <remarks>
        /// Postleitzahl(postfachbezogen) (5 Stellen numerisch linksbündig mit nachfolgenden Leerzeichen), Länge 10, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string PLZPO { get; set; }

        /// <summary>
        /// Holt oder setzt das Postfach
        /// </summary>
        /// <remarks>
        /// Postfach, Länge 10, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string POSTFACH { get; set; }

        /// <summary>
        /// Länderkennzeichen gemäß Anlage 8 (nur bei ausländischen Anschriften)
        /// </summary>
        /// <remarks>
        /// Länge 3, Mussangabe unter Bedingungen
        /// </remarks>
        public string LDKZPA { get; set; }

        /// <summary>
        /// Kennzeichen, ob die abweichende Postanschrift in der Datei der Beschäftigungsbetriebe gelöscht werden soll
        /// <para />
        /// Grundstellung (<see langword="null"/>) - keine Löschung;
        /// L - Löschung
        /// </summary>
        public string KENNZLPA { get; set; }
    }
}
