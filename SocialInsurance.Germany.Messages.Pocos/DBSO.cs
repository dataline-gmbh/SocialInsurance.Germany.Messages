using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBSO - Sofortmeldung
    /// </summary>
    public class DBSO : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBSO"/> Klasse.
        /// </summary>
        public DBSO() 
        {
            KE = "DBSO";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Stornierung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, Länge 1, Stornierung einer bereits abgegebenen 
        /// Sofortmeldung, N = keine Stornierung J = Stornierung, Mussangabe
        /// </remarks>
        public string KENNZSTSO{ get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, Länge 8,  in der Form: jhjjmmtt, Mussangabe
        /// </remarks>
        public DateTime ZRBGSO { get; set; }
    }
}
