using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBVR - Rückmeldung des Zusammentreffens bei geringfügiger Beschäftigung
    /// </summary>
    public class DBVR : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBVR"/> Klasse
        /// </summary>
        public DBVR()
        {
            KE = "DBVR";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>        
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Abgabegrund
        /// </summary>
        /// <remarks>
        /// Grund der Abgabe, Länge 2, Mussangabe
        /// </remarks>
        public int GDMQ{ get; set; }
        
        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Vergabeanstalt
        /// </summary>
        /// <remarks>
        /// Bereichsnummer der Vergabeanstalt, Länge 2, Mussangabe
        /// </remarks>
        public int BRNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Versicherungsnummer ermittelt bzw. vergeben in der Form: bbttmmjjassp, Länge 12
        /// </remarks>
        public string VSNRZH { get; set; }
    }
}
