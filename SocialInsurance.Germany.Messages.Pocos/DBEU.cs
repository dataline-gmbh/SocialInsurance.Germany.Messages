using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBEU - Europäische Versicherungsnummer
    /// </summary>
    public class DBEU
    {
        /// <summary>
        /// KENNUNG KE, Kennung, Stellen 001-004, Mussangabe
        /// </summary>
        public string Kennung { get; set; }

        /// <summary>
        /// GB-LAND GBLD, Geburtsland eines EU-/EWR-Staatsangehörigen, Stellen 005-007, Mussangabe
        /// </summary>
        public string Geburtsland { get; set; }

        /// <summary>
        /// EUVSNR EUVSNR, Europäische VSNR, Stellen 008-027, Pflichtangabe, soweit bekannt
        /// </summary>
        public string EUVersicherungsnummer { get; set; }
    }
}
