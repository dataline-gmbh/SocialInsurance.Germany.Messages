// <copyright file="DBAG.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein: DBAG - Arbeitgeberangaben
    /// </summary>
    public class DBAG : IDatenbaustein
    {
        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; } = "DBAG";

        /// <summary>
        /// Holt oder setzt den Namen des Arbeitgebers/Dienstherrn
        /// </summary>
        /// <remarks>
        /// Name des Arbeitgebers/des Dienstherrn, Länge 30, Mussangabe
        /// </remarks>
        public string NAME1AG { get; set; }

        /// <summary>
        /// Holt oder setzt den zweiten Namensteil des Arbeitgebers/Dienstherrn
        /// </summary>
        /// <remarks>
        /// zweiter Namensteil des Arbeitgebers/Dienstherrn, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME2AG { get; set; }

        /// <summary>
        /// Holt oder setzt den dritten Namensteil des Arbeitgebers/Dienstherrn
        /// </summary>
        /// <remarks>
        /// dritten Namensteil des Arbeitgebers/Dienstherrn, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME3AG { get; set; }

        /// <summary>
        /// Holt oder setzt das Länderkennzeichen bei ausländischen Anschriften
        /// </summary>
        /// <remarks>
        /// Bei ausländischen Anschriften muss hier das Länder(Kfz)kennzeichen angegeben werden, Länge 3, Mussangabe
        /// </remarks>
        public string AGLDKZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl
        /// </summary>
        /// <remarks>
        /// Postleitzahl, Länge 10, Mussangabe
        /// Bei inländischen Anschriften muss die Postleitzahl 5
        /// Stellen numerisch sein (linksbündig mit nachfolgenden Leerzeichen)
        /// </remarks>
        public string AGPLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Standort des Beschäftigungsbetriebs
        /// </summary>
        /// <remarks>
        /// Standort des Beschäftigungsbetriebs, Länge 34, Mussangabe
        /// </remarks>
        public string AGORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße des Beschäftigungsbetriebs
        /// </summary>
        /// <remarks>
        /// Straße des Beschäftigungsbetriebs, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string AGSTR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer des Beschäftigungsbetriebs
        /// </summary>
        /// <remarks>
        /// Hausnummer des Beschäftigungsbetriebs, Länge 9, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string AGHAUSNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Anschriftenzusatz des Beschäftigungsbetriebs
        /// </summary>
        /// <remarks>
        /// Anschriftenzusatz des Beschäftigungsbetriebs. Länge 40, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string AGADRZU { get; set; }

        /// <summary>
        /// Holt oder setzt den Vor- und Familiennamen des Ansprechpartners beim Arbeitgeber für die Entgeltabrechnung.
        /// </summary>
        /// <remarks>60 Zeichen.</remarks>
        public string AGAPE { get; set; }

        /// <summary>
        /// Holt oder setzt den Vor- und Familiennamen des Ansprechpartners beim Arbeitgeber für sonstige Personalfragen.
        /// </summary>
        /// <remarks>60 Zeichen.</remarks>
        public string AGAPP { get; set; }

        /// <summary>
        /// Holt oder setzt die Telefonnummer des Ansprechpartners beim Arbeitgeber für die Entgeltabrechnung.
        /// </summary>
        /// <remarks>25 Zeichen.</remarks>
        public string AGTELE { get; set; }

        /// <summary>
        /// Holt oder setzt die Telefonnummer des Ansprechpartners beim Arbeitgeber für sonstige Personalfragen.
        /// </summary>
        /// <remarks>25 Zeichen.</remarks>
        public string AGTELP { get; set; }

        /// <summary>
        /// Holt oder setzt die E-Mail-Adresse des Ansprechpartners beim Arbeitgeber für die Entgeltabrechnung.
        /// </summary>
        /// <remarks>70 Zeichen.</remarks>
        public string AGEMAILE { get; set; }

        /// <summary>
        /// Holt oder setzt die E-Mail-Adresse des Ansprechpartners beim Arbeitgeber für sonstige Personalfragen.
        /// </summary>
        /// <remarks>70 Zeichen.</remarks>
        public string AGEMAILP { get; set; }
    }
}
