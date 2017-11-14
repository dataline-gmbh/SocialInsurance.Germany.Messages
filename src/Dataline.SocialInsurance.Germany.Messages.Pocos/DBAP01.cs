// <copyright file="DBAP01.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// DBAB - Ansprechpartner
    /// </summary>
    public class DBAP01 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBAP01"/> Klasse
        /// </summary>
        public DBAP01()
        {
            KE = "DBAP";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Geschlecht zur Anrede des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Geschlecht zur Anrede des Ansprechpartners, Länge 1, Pflichtangabe, soweit bekannt
        /// M = Männlich, W = Weiblich, S = Sonstiges
        /// </remarks>
        public string ANRAP { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Name des Ansprechpartners, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAMEAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Rufnummer des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Rufnummer des Ansprechpartners, Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string TELAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Faxrufnummer des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Faxrufnummer des Ansprechpartners, Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string FAXAP { get; set; }

        /// <summary>
        /// Holt oder setzt die E-Mail-Adresse des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// E-Mail-Adresse des Ansprechpartners, Länge 70, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string EMAILAP { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Name des Erstellers der Datei, Länge 30, Mussangabe
        /// </remarks>
        public string NAME1 { get; set; }

        /// <summary>
        /// Holt oder setzt den zweiten Namensbestandteil des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Zweiter Namensbestandteil des Erstellers der Datei, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME2 { get; set; }

        /// <summary>
        /// Holt oder setzt den dritten Namensbestandteil des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Dritter Namensbestandteil des Erstellers der Datei, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME3 { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Postleitzahl des Erstellers der Datei, Länge 10, Mussangabe
        /// </remarks>
        public string PLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Betriebssitz des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebssitz des Erstellers der Datei, Länge 34, Mussangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße des Betriebssitzes des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Straße des Betriebssitzes des Erstellers der Datei, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer des Betriebssitzes des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Hausnummer des Betriebssitzes des Erstellers der Datei, Länge 9, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NR { get; set; }
    }
}
