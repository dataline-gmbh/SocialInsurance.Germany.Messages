using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBKS - See
    /// </summary>
    public class DBKSS : DBKS
    {
        /// <summary>
        /// Holt oder setzt die seemännischen Berufsgruppen
        /// </summary>
        /// <remarks>
        /// Seemännische Berufsgruppen, Länge 2, Mussangabe
        /// </remarks>
        public string BGR { get; set; }

        /// <summary>
        /// Holt oder setzt die Versicherungsarten
        /// </summary>
        /// <remarks>
        /// Versicherungsarten, Länge 2, Mussangabe bei
        /// - nichtfahrenden Versicherten
        /// - Beschäftigung auf ISR-Schiffen
        /// - Versicherung kraft Ausstrahlung
        /// - Versicherung auf Antrag
        /// </remarks>
        public string VA { get; set; }

        /// <summary>
        /// Holt oder setzt die Fahrzeuggruppen
        /// </summary>
        /// <remarks>
        /// Fahrzeuggruppen, Länge 2, Mussangabe
        /// </remarks>
        public string FGR { get; set; }

        /// <summary>
        /// Holt oder setzt die seemännischen Befähigungszeugnisse (Patente)
        /// </summary>
        /// <remarks>
        /// Seemännische Befähigungszeugnisse, Länge 2, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string PAT { get; set; }

        /// <summary>
        /// Holt oder setzt den Antrag auf RV-Befreiung
        /// </summary>
        /// <remarks>
        /// Formloser Antrag auf Befreiung von der Rentenversicherungspflicht, Länge 1, Mussangabe
        /// für nichtdeutsche Seeleute (gilt nur zur Fristwahrung)
        /// N = kein Antrag
        /// J = Antrag
        /// </remarks>
        public string AQRVB { get; set; }

        private string RESERVE { get; set; }
    }
}
