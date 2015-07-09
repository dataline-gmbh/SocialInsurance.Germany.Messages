using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBSB - Steuerpflichtiger sonstiger Bezug
    /// </summary>
    public class DBSB : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBSB"/> Klasse.
        /// </summary>
        public DBSB()
        {
            KE = "DBSB";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten steuerfreien Bezüge
        /// </summary>
        /// <remarks>
        /// Anzahl der angehängten steuerfreien Bezüge, Länge 2, Mussangabe
        /// </remarks>
        public int ANSB { get; set; }

        public IList<DBSBF> ListeDBSBF { get; set; }
    }
}
