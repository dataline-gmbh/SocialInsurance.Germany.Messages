using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBKS - Knappschaft/See
    /// </summary>
    public class DBKS : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBKS"/> Klasse
        /// </summary>
        public DBKS()
        {
            KE = "DBKS";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennzeichen-Daten für S = See oder K = Knappschaft
        /// </summary>
        /// <remarks>
        /// Kennzeichen-Daten, Länge 1, Mussangabe
        /// Vorhanden für
        /// K = knappschaftliche SV
        /// S = See-SV
        /// </remarks>
        public string KENNZKS { get; set; }
    }
}
