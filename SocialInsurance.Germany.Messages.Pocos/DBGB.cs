using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBGB - Geburtsangaben
    /// </summary>
    public class DBGB : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBGB"/> Klasse
        /// </summary>
        public DBGB() 
        {
            KE = "DBGB";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Geburtsnamen
        /// </summary>
        /// <remarks>
        /// Geburtsname, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string GBNA { get; set; }

        /// <summary>
        /// Holt oder setzt den Vorsatzwort des Geburtsnamens
        /// </summary>
        /// <remarks>
        /// Vorsatzwort des Geburtsnamens,Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string GBVORSA { get; set; }

        /// <summary>
        /// Holt oder setzt den Namenszusatz des Geburtsnamens
        /// </summary>
        /// <remarks>
        /// Namenzusatz des Geburtsnamens, Stellen 055-074, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string GBNAZU { get; set; }

        /// <summary>
        /// Holt oder setzt das Geburtsdatum
        /// </summary>
        /// <remarks>
        /// Geburtsdatum, Länge 8, im Format: jhjjmmtt, Mussangabe
        /// </remarks>
        public DateTime GBDT { get; set; }

        /// <summary>
        /// Holt oder setzt das Geschlecht
        /// </summary>
        /// <remarks>
        /// Geschlecht, Länge 1, M = männlich; W = weiblich, Mussangabe
        /// </remarks>
        public string GE { get; set; }

        /// <summary>
        /// Holt oder setzt den Geburtsort
        /// </summary>
        /// <remarks>
        /// Geburtsort, Länge 34, Mussangabe
        /// </remarks>
        public string GBOT { get; set; }
    }
}
