using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBHB - Höherversicherungsbeitrag
    /// </summary>
    public class DBHB : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBHB"/> Klasse.
        /// </summary>
        public DBHB()
        {
            KE = "DBHB";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen für den Höhenversicherungsbeitrag im ABMO
        /// </summary>
        /// <remarks>
        /// Vorzeichen für den Höherversicherungsbeitrag im ABMO, Länge 1, Mussangabe
        /// "Leerzeichen" oder "+" = positiv, "-" = negativ (nur mit MEVO "K" zulässig)
        /// </remarks>
        public string VZHB { get; set; }

        /// <summary>
        /// Holt oder setzt den Höherversicherungsbeitrag
        /// </summary>
        /// <remarks>
        /// Höherversicherungsbeitrag(mit Centangabe), Länge 8, Mussangabe
        /// </remarks>
        public int HB { get; set; }
    }
}
