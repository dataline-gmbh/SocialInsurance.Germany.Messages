using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBSV - Sozialversicherungsausweis
    /// </summary>
    public class DBSV : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBSV"/> Klasse
        /// </summary>
        public DBSV()
        {
            KE = "DBSV";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das SV-Ausweis Kennzeichen.
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob ein SV-Ausweis zu erstellen ist, Länge 1, Mussangabe
        /// J = SV-Ausweis ausstellen
        /// </remarks>
        public string KENNZSVA { get; set; }
    }
}
