using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBNA Name
    /// </summary>
    public class DBNA
    {
        /// <summary>
        /// KENNUNG KE, Kennung, Stellen 001 - 004, Mussangabe
        /// </summary>
        public string Kennung { get; set; }

        /// <summary>
        /// FAMILIENNAME FMNA, Familienname, Stellen 005 - 034, Mussangabe
        /// </summary>
        public string Familienname { get; set; }

        /// <summary>
        /// VORNAME VONA, Vorname, Stellen 035-064, Mussangabe
        /// </summary>
        public string Vorname { get; set; }

        /// <summary>
        /// VORSATZWORT VOSA, Vorsatzwort, Stellen 065-084, Pflichtangabe, soweit bekannt
        /// </summary>
        public string Vorsatzwort { get; set; }

        /// <summary>
        /// NAMENSZUSATZ NAZU, Namenszusatz, Stellen 085-104, Pflichtangabe, soweit bekannt
        /// </summary>
        public string Namenszusatz { get; set; }

        /// <summary>
        /// TITEL TITEL, Titel, Stellen 105-124, Pflichtangabe, soweit bekannt
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// KENNZ-AEND-BER KENNZAB, Kennzeichenänderung, Stellen 125-125, Mussangabe unter Bedingungen
        /// </summary>
        public string Kennzeichenänderung { get; set; }
    }
}
