using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    class DBAZ
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBAZ"/> Klasse.
        /// </summary>
        public DBAZ()
        {
            KE = "DBAZ";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Angaben zu der gemeldeten Zeit
        /// </summary>
        /// <remarks>
        /// Angaben zu der gemeldeten Zeit, Länge 2, Mussangabe
        /// </remarks>
        public string LEAT { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRBG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZREN { get; set; }
    }
}
