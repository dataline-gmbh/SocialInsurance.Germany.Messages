using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBSE - Steuerpflichtiger sonstiger Bezug
    /// </summary>
    public class DBSE : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBSE"/> Klasse
        /// </summary>
        public DBSE()
        {
            KE = "DBSE";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten steuerpflichtigen sonstigen Bezüge
        /// </summary>
        /// <remarks>
        /// Anzahl der angehängten steuerpflichtigen sonstigen Bezüge, Länge 2, Mussangabe
        /// </remarks>
        public int ANSTSOB { get; set; }

        /// <summary>
        /// Holt oder setzt die Liste der sich wiederholenden Felder
        /// </summary>
        public IList<DBSE_STSOB> STSOB { get; set; }

        /// <summary>
        /// wiederholt sich entsprechend der Anzahl im Feld ANSTSOB von DBSE
        /// </summary>
        public class DBSE_STSOB
        {
            /// <summary>
            /// Holt oder setzt das Vorzeichen vom steuerpflichtigen sonstigen Bezug
            /// </summary>
            /// <remarks>
            /// Plus (+) / Leerzeichen = positiver Betrag
            /// Minus (-) = negativer Betrag
            /// </remarks>
            public string VSTSOB { get; set; }

            /// <summary>
            /// Holt oder setzt die Höhe des steuerpflichtigen sonstigen Bezuges
            /// </summary>
            /// <remarks>
            /// Höhe des steuerpflichtigen sonstigen Bezuges(steuerpflichtiges Arbeitsentgelt), Länge 10, Mussangabe
            /// </remarks>
            public int STSOB { get; set; }

            /// <summary>
            /// Holt oder setzt die Art des steuerpflichtigen sonstigen Bezuges
            /// </summary>
            /// <remarks>
            /// Art des steuerpflichtigen sonstigen Bezuges (Schlüssel)
            /// 01 = Weihnachtszuwendungen, 02 = 13. und 14. Monatsgehälter
            /// 03 = Urlaubsgeld, 04 = Gratifikationen und Tantiemen, 05 = Urlaubsabgeltungen
            /// 06 = Jubiläumszuwendungen, 07 = Abfindungsbrutto, 99 = sonstiges
            /// </remarks>
            public int STSOBART { get; set; }

            /// <summary>
            /// Holt oder setzt die Art des steuerpflichtigen sonstigen Bezuges
            /// </summary>
            /// <remarks>
            /// Art des steuerpflichtigen sonstigen Bezuges (Freitext), Länge 30, Mussangabe unter Bedingungen
            /// </remarks>
            public string STSOBARTTX { get; set; }
        }
    }
}
