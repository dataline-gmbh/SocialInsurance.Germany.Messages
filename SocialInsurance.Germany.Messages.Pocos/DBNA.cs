using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBNA - Name
    /// </summary>
    public class DBNA : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBNA"/> Klasse
        /// </summary>
        public DBNA() 
        {
            KE = "DBNA";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Familiennamen
        /// </summary>
        /// <remarks>
        /// Familienname, Länge 30, Mussangabe
        /// </remarks>
        public string FMNA { get; set; }

        /// <summary>
        /// Holt oder setzt den Vornamen
        /// </summary>
        /// <remarks>
        /// Vorname, Länge 30, Mussangabe
        /// </remarks>
        public string VONA { get; set; }

        /// <summary>
        /// Holt oder setzt den Vorsatzwort
        /// </summary>
        /// <remarks>
        /// Vorsatzwort, Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string VOSA { get; set; }

        /// <summary>
        /// Holt oder setzt den Namenszusatz
        /// </summary>
        /// <remarks>
        /// Namenszusatz, Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAZU { get; set; }

        /// <summary>
        /// Holt oder setzt den Titel
        /// </summary>
        /// <remarks>
        /// Titel, Stellen Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string TITEL { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Änderung
        /// </summary>
        /// <remarks>
        /// Kennzeichenänderung, Länge 1, Mussangabe unter Bedingungen
        /// </remarks>
        public string KENNZAB { get; set; }
    }
}
