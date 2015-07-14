using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBKS - Knappschaft
    /// </summary>
    public class DBKSK : DBKS
    {
        /// <summary>
        /// Holt oder setzt den Stand der Ausbildung
        /// </summary>
        /// <remarks>
        /// Stand der Ausbildung (Knappschaft), Länge 1, Kannangabe
        /// </remarks>
        public string AUSBKNV { get; set; }

        /// <summary>
        /// Holt oder setzt den knappschaftlichen Tätigkeitsschlüssel
        /// </summary>
        /// <remarks>
        /// Knappschaftlicher Tätigkeitsschlüssel, Länge 144, Mussangabe in der Form:
        /// Ab-Monat (2 Stellen),
        /// Tätigkeitsschlüssel (9 Stellen)
        /// Besonderheitenschlüssel (1 Stelle)
        /// </remarks>
        public string TTSCKNV { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Beschäftigungsverhältnisses
        /// </summary>
        /// <remarks>
        /// Ende des Beschäftigungsverhältnisses im knappschaftlichen Betrieb, Länge 8, Mussangabe unter Bedingungen
        /// </remarks>
        public DateTime ENDEVS { get; set; }

        /// <summary>
        /// Holt oder setzt den Abkehrgrund Knappschaft
        /// </summary>
        /// <remarks>
        /// Abkehrgrund Knappschaft, Länge 2, Mussangabe unter Bedingungen
        /// </remarks>
        public string ABKGDKNV { get; set; }

        /// <summary>
        /// Holt oder setzt den Bergmannsprämienbezug/Schichten unter Tage
        /// </summary>
        /// <remarks>
        /// Bergmannsprämienbezug/Schichten unter Tage, Länge 24, Mussangabe unter Bedingungen
        /// </remarks>
        public string BPUT { get; set; }

        private string RESERVE { get; set; }
    }
}
