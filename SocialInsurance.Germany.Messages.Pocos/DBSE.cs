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
        /// Initialisiert eine neue Instanz der <see cref="DBSE"/> Klasse.
        /// </summary>
        public DBSE()
        {
            KE = "DBSE";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten steuerpflichtigen sonstigen Bezüge
        /// </summary>
        /// <remarks>
        /// Anzahl der angehängten steuerpflichtigen sonstigen Bezüge, Länge 2, Mussangabe
        /// </remarks>
        public int ANSTSOB { get; set; }

        public IList<DBSEF> DBSEFListe { get; set; }
    }
}
