using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBHA - Heimarbeiter
    /// </summary>
    public class DBHA : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBHA"/> Klasse.
        /// </summary>
        public DBHA()
        {
            KE = "DBHA";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der zu beanspruchenden Urlaubstage
        /// </summary>
        /// <remarks>
        /// Anzahl der zu beanspruchenden Urlaubstage, Länge 3, Mussangabe
        /// </remarks>
        public int URLTAGE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der tatsächlichen Urlaubstage
        /// </summary>
        /// <remarks>
        /// Anzahl der tatsächlichen Urlaubstage, Länge 3, Mussangabe
        /// </remarks>
        public int TATSURLTAGE { get; set; }

        /// <summary>
        /// Holt oder setzt das im  bescheinigten Bruttoarbeitsentgelt enthaltene Urlaubsentgelt 
        /// </summary>
        /// <remarks>
        /// Im bescheinigten Bruttoarbeitsentgelt enthaltenes Urlaubsentgelt, Länge 10, Mussangabe
        /// </remarks>
        public int URLEG { get; set; }

        /// <summary>
        /// Holt oder setzt die Art der Zahlung des Urlaubsentgelt
        /// </summary>
        /// <remarks>
        /// Art der Zahlung des Urlaubsentgelt, Länge 1, Mussangabe
        /// 1 = bei Urlaubsantritt, 2 = als laufender Entgeltzuschlag
        /// </remarks>
        public int ULEGGEZ { get; set; }
    }
}
