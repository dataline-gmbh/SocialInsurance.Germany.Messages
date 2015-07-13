using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBAA - Ansprechpartner Arbeitgeber
    /// </summary>
    public class DBAA : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBAA"/> Klasse.
        /// </summary>
        public DBAA()
        {
            KE = "DBAA";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anrede des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Anrede des Ansprechpartners für das Erstattungsverfahren, Länge 1, Pflichtangabe, soweit bekannt
        /// nach dem AAG beim Arbeitgeber
        /// M = Männlich, W = Weiblich
        /// </remarks>
        public string ANRAA { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Name des Ansprechpartners für das Erstattungsverfahren nach dem AAG beim Arbeitgeber, Länge 30, Mussangabe
        /// </remarks>
        public string NAMEAA { get; set; }

        /// <summary>
        /// Holt oder setzt die Rufnummer des Ansprechspartners
        /// </summary>
        /// <remarks>
        /// Rufnummer des Ansprechpartners für das Erstattungsverfahren nach dem AAG beim Arbeitgeber, Länge 20, Mussangabe
        /// </remarks>
        public string TELAA { get; set; }

        /// <summary>
        /// Holt oder setzt die Faxnummer des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Faxrufnummer des Ansprechpartners für das Erstattungsverfahren nach dem AAG beim Arbeitgeber, Länge 20, Kannangabe
        /// </remarks>
        public string FAXAA { get; set; }

        /// <summary>
        /// Holt oder setzt die E-Mail-Adresse des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// E-Mail-Adresse des Ansprechpartners für das Erstattungsverfahren nach dem AAG beim Arbeitgeber, Länge 70, Kannangabe
        /// </remarks>
        public string EMAILAA { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Betriebes
        /// </summary>
        /// <remarks>
        /// Name des Betriebes, Länge 30, Kannangabe
        /// </remarks>
        public string NABE1 { get; set; }

        /// <summary>
        /// Holt oder setzt den zweiten Namensbestandteil des Betriebes
        /// </summary>
        /// <remarks>
        /// Zweiter Namensbestandteil des Betriebes, Länge 30, Kannangabe
        /// </remarks>
        public string NABE2 { get; set; }

        /// <summary>
        /// Holt oder setzt den drittenn Namensbestandteil des Betriebes
        /// </summary>
        /// <remarks>
        /// Dritter Namensbestandteil des Betriebes, Länge 30, Kannangabe
        /// </remarks>
        public string NABE3 { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl des Betriebes
        /// </summary>
        /// <remarks>
        /// Postleitzahl des Betriebes, Länge 10, Kannangabe
        /// </remarks>
        public string PLZB { get; set; }

        /// <summary>
        /// Holt oder setzt den Betriebssitz
        /// </summary>
        /// <remarks>
        /// Betriebssitz, Länge 34, Kannangabe
        /// </remarks>
        public string ORTB { get; set; }

        /// <summary>
        /// Holt oder setzt die Strasse des Betriebssitzes
        /// </summary>
        /// <remarks>
        /// Strasse des Betriebssitzes, Länge 33, Kannangabe
        /// </remarks>
        public string STRB { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer des Betriebssitzes
        /// </summary>
        /// <remarks>
        /// Hausnummer des Betriebssitzes, Länge 33, Kannangabe
        /// </remarks>
        public string NRB { get; set; }
    }
}
