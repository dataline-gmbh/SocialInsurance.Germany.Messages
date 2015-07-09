using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// die folgenden wiederholen sich entsprechend der Anzahl im Feld ANSB in DBSB
    /// </summary>
    public class DBSBF
    {
        /// <summary>
        /// Holt oder setzt das Vorzeichen für steuerfreie Bezüge
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag
        /// </remarks>
        public string VSB { get; set; }

        /// <summary>
        /// Holt oder setzt die Höhe des steuerfreien Bezuges
        /// </summary>
        /// <remarks>
        /// Höhe des steuerfreien Bezuges, Länge 10, Mussangabe
        /// </remarks>
        public int SB { get; set; }

        /// <summary>
        /// Holt oder setzt die Art des Bezuges
        /// </summary>
        /// <remarks>
        /// Art des Bezuges, Länge 2, Mussangabe
        /// </remarks>
        public int SBART { get; set; }

        /// <summary>
        /// Holt oder setzt die Art des sonstigen steuerfreien Bezuges
        /// </summary>
        /// <remarks>
        /// Art des sonstigen steuerfreien Bezuges (Freitext), Länge 30, Mussangabe unter Bedingungen
        /// </remarks>
        public string SBARTTX { get; set; }
    }
}
