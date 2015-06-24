using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBSO - Sofortmeldung
    /// </summary>
    public class DBSO
    {
        /// <summary>
        /// KENNUNG KE, Kennung, Stellen 001-004, Mussangabe
        /// </summary>
        public string Kennung { get; set; }

        /// <summary>
        /// KENNZ-STORNO-SOFORT KENNZSTSO, Kennzeichen, Stellung 005-005, Stornierung einer bereits abgegebenen Sofortmeldung, N = keine Stornierung J = Stornierung, Mussangabe
        /// </summary>
        public string KennzeichenStorno { get; set; }

        /// <summary>
        /// ZEITRAUM-BEGINN-SOFORT ZRBGSO, Beginn des Zeitraums, Stellen 006-013,  in der Form: jhjjmmtt, Mussangabe
        /// </summary>
        public DateTime Zeitraumbeginn { get; set; }
    }
}
