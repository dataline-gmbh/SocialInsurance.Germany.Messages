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
    public class DBKS
    {
        /// <summary>
        /// KENNUNG KE, Kennung, Stellen 001-004, Mussangabe
        /// </summary>
        public string Kennung { get; set; }

        /// <summary>
        /// KENNZ-KNV-SEE KENNZKS, Kennzeichen Daten, Stellen 005-005, Mussangabe
        /// Vorhanden für
        /// K = knappschaftliche SV
        /// S = See-SV
        /// </summary>
        public string KennzeichenDaten { get; set; }

        /// <summary>
        /// DATEN-KNV-SEE, zur Verfügung der knappschaftlichen bzw. Seesozialversicherung, Stellen 006-220, Mussangabe unter Bedingungen
        /// </summary>
        public string DatenKNVSee { get; set; }
    }
}
