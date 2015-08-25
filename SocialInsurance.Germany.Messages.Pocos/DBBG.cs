using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBBG - Meldesachverhalt Beitragsbemessungsgrenze
    /// </summary>
    public class DBBG : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBBG"/> Klasse
        /// </summary>
        public DBBG()
        {
            KE = "DBBG";
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
        public int KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende beitragspflichtige Gesamtentgelt KV
        /// </summary>
        /// <remarks>
        /// Laufendes beitragspflichtiges Gesamtentgelt KV in Eurocent, Länge 7, Mussangabe
        /// </remarks>
        public int GAEGKV { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende beitragspflichtige Gesamtentgelt RV
        /// </summary>
        /// <remarks>
        /// Laufendes beitragspflichtiges Gesamtentgelt RV in Eurocent, Länge 7, Mussangabe
        /// </remarks>
        public int GAEGRV { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende beitragspflichtige Gesamtentgelt AV
        /// </summary>
        /// <remarks>
        /// Laufendes beitragspflichtiges Gesamtentgelt AIV in Eurocent, Länge 7, Mussangabe
        /// </remarks>
        public int GAEGALV { get; set; }

        /// <summary>
        /// Holt oder setzt den beitragspflichtigen Teil des einmalig gezahlten Entgelts KV
        /// </summary>
        /// <remarks>
        /// Beitragspflichtiger Teil des einmalig gezahlten Entgelts KV in Eurocent, Länge 7, Mussangabe
        /// </remarks>
        public int EGAKV { get; set; }

        /// <summary>
        /// Holt oder setzt den beitragspflichtigen Teil des einmalig gezahlten Entgelts KV
        /// </summary>
        /// <remarks>
        /// Beitragspflichtiger Teil des einmalig gezahlten Entgelts RV in Eurocent, Länge 7, Mussangabe
        /// </remarks>
        public int EGARV { get; set; }

        /// <summary>
        /// Holt oder setzt den beitragspflichtigen Teil des einmalig gezahlten Entgelts KV
        /// </summary>
        /// <remarks>
        /// Beitragspflichtiger Teil des einmalig gezahlten Entgelts AIV in Eurocent, Länge 7, Mussangabe
        /// </remarks>
        public int EGALV { get; set; }

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

        /// <summary>
        /// Holt oder setzt das Kennzeichen Rechtskreis
        /// </summary>
        /// <remarks>
        /// Kennzeichen Rechtskreis, Länge 1, Mussangabe
        /// W = altes Bundesland, O = neues Bundesland einschließlich Ost-Berlin
        /// </remarks>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der zur Sozialversicherung beitragspflichtigen Tage
        /// </summary>
        /// <remarks>
        /// Anzahl der Tage, für die eine Beitragspflicht zur Sozialversicherung im Abrechnungsmonat besteht(SV-Tage), Länge 2, Mussangabe
        /// </remarks>
        public string SVTG { get; set; }
    }
}
