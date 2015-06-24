using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBGB - Geburtsangaben
    /// </summary>
    public class DBGB
    {
        /// <summary>
        /// KENNUNG, Kennung, Stellen 001-004, Mussangabe
        /// </summary>
        public string Kennung { get; set; }

        /// <summary>
        /// GB-NAME GBNA, Geburtsname, Stellen 05-034, Pflichtangabe, soweit bekannt
        /// </summary>
        public string Geburtsname { get; set; }

        /// <summary>
        /// GB-VORSATZWORT GBVOSA, Vorsatzwort des Geburtsnamens, Stellen 035-054, Pflichtangabe, soweit bekannt
        /// </summary>
        public string Geburtsnamenvorsatzwort { get; set; }

        /// <summary>
        /// GB-NAMENSZUSATZ GBNAZU, Namenzusatz des Geburtsnamens, Stellen 055-074, Pflichtangabe, soweit bekannt
        /// </summary>
        public string Geburtsnamenzusatz { get; set; }

        /// <summary>
        /// GEBURTSDATUM GBDT, Geburtsdatum, Stellen 075-082, im Format: jhjjmmtt, Mussangabe
        /// </summary>
        public string Geburtsdatum { get; set; }

        /// <summary>
        /// GESCHLECHT GE, Geschlecht, Stellen 083-083, M = männlich; W = weiblich, Mussangabe
        /// </summary>
        public string Geschlecht { get; set; }

        /// <summary>
        /// GB-ORT GBOT, Geburtsort, Stellen 084-117, Mussangabe
        /// </summary>
        public string Geburtsort { get; set; }
    }
}
