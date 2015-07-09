using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBFZ - Arbeitgeberangaben
    /// </summary>
    public class DBFZ : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBFZ"/> Klasse.
        /// </summary>
        public DBFZ()
        {
            KE = "DBFZ";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten Fehlzeiteninformationen
        /// </summary>
        /// <remarks>
        /// Anzahl der angehängten Fehlzeiteninformationen, Länge 2, Mussangabe
        /// </remarks>
        public int ANFZ { get; set; }

        public IList<DBFZF> DBFZFListe { get; set; }
    }
}
