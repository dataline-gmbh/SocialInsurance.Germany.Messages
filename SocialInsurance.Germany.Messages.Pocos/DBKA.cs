// <copyright file="DBKA.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBKA - Abweichende Korrespondenzanschrift
    /// </summary>
    public class DBKA : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBKA"/> Klasse
        /// </summary>
        public DBKA()
        {
            KE = "DBKA";
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
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung - Teil 1, Länge 30, Mussangabe
        /// </remarks>
        public string NAME1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Name - Teil 2
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung - Teil 2, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME2 { get; set; }

        /// <summary>
        /// Holt oder setzt den Name - Teil 3
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung - Teil 3, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME3 { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl
        /// </summary>
        /// <remarks>
        /// Postleitzahl(zustellbezogen)(5 Stellen numerisch linksbündig mit nachfolgenden Leerzeichen), Länge 10, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string PLZZU { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort
        /// </summary>
        /// <remarks>
        /// Ort, Länge 34, Mussangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße
        /// </summary>
        /// <remarks>
        /// Straße, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer
        /// </summary>
        /// <remarks>
        /// Hausnummer, Länge 9, Pflichtangabe, soweit bekannt
        /// Hinweis: Wenn die Hausnummer nicht separat abgelegt werden kann, ist es zulässig, die Hausnummer in das
        /// Feld Straße zu übernehmen. In solchen Fällen muss dann das Feld Hausnummer auf Grundstellung (Leerzeichen) stehen.
        /// </remarks>
        public string HNR { get; set; }

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
    }
}
