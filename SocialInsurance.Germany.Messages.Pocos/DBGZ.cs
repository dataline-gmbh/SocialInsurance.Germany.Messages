using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBGZ - Meldesachverhalt Gleitzone
    /// </summary>
    public class DBGZ : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBGZ"/> Klasse.
        /// </summary>
        public DBGZ()
        {
            KE = "DBGZ";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Stornierung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, Stornierung einer bereits abgegebenen Meldung, Länge 1, Mussangabe
        /// N = keine Stornierung, J = Stornierung
        /// </remarks>
        public string KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Gleitzone
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob die Beiträge nach den besonderen Vorschriften der Gleitzone berechnet werden, Länge 1, Mussangabe
        /// </remarks>
        public string KENNZGLZ { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Gesamtentgelt
        /// </summary>
        /// <remarks>
        /// Laufendes Gesamtetgelt in Eurocent
        /// </remarks>
        public string GAEG { get; set; }

        /// <summary>
        /// Holt oder setzt das einmalig gezahlte Gesamtentgelt in Eurocent
        /// </summary>
        /// <remarks>
        /// Einmalig gezahltes Gesamtentgelt in Eurocent, Länge 6, Mussangabe
        /// </remarks>
        public string EGAEG { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der zur Sozialversicherung beitragspflichtigen Tage
        /// </summary>
        /// <remarks>
        /// Anzahl der Tage, für die eine Beitragspflicht zur Sozialversicherung im Abrechnungsmonat besteht(SV-Tage), Länge 2, Mussangabe
        /// </remarks>
        public string SVTG { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld
        /// </summary>
        /// <remarks>
        /// Reservefeld, Leerzeichen, Länge 4, Mussangabe
        /// </remarks>
        public string RESERVE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRBG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZREN { get; set; }
    }
}
