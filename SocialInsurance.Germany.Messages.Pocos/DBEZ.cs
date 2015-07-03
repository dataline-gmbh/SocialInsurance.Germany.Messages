using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBEZ - Entgeltersatzleistungszeiten
    /// </summary>
    public class DBEZ : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBEZ"/> Klasse.
        /// </summary>
        public DBEZ()
        {
            KE = "DBEZ";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Stornierung
        /// </summary>
        /// <remarks>
        /// Kennzeichen Stornierung, Länge 1, Mussangabe
        /// N = keine Stornierung, J = Stornierung
        /// </remarks>
        public string KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt die Angaben zur Leistungsart
        /// </summary>
        /// <remarks>
        /// Angaben zur Leistungsart, Länge 2, Mussangabe
        /// von 00 = Krankengeld bis 50 = Entgeltsicherung für ältere Arbeitnehmer
        /// </remarks>
        public int LEAT { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Abgabe
        /// </summary>
        /// <remarks>
        /// Grund der Abgabe, Länge 2, Mussangabe
        /// 02 = Ende des Leistungsbezuges
        /// 03 = Jahresmeldung, 04 = Gesonderte Meldung
        /// </remarks>
        public int GDMQ { get; set; }

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
        /// Holt oder setzt das Währungskennzeichen
        /// </summary>
        /// <remarks>
        /// Währungskennzeichen, Länge 1, Mussangabe
        /// D = DM, E = Euro
        /// </remarks>
        public string WG { get; set; }

        /// <summary>
        /// Holt oder setzt das Entgelt
        /// </summary>
        /// <remarks>
        /// Entgelt in vollen DM/Euro, Länge 6, Mussangabe
        /// </remarks>
        public int EG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsanteil
        /// </summary>
        /// <remarks>
        /// Beitragsanteil, Länge 7, Mussangabe
        /// 5 Stellen DM/Euro, 2 Stellen Pfennige/Cent
        /// </remarks>
        public int BY { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Rechtskreis
        /// </summary>
        /// <remarks>
        /// Kennzeichen Rechtskreis, Länge 1, Mussangabe
        /// W = altes Bundesland, O = neues Bundesland einschließlich Ost-Berlin
        /// </remarks>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Holt oder setzt den Wiedereingliederungsfall
        /// </summary>
        /// <remarks>
        /// Wiedereingliederungsfall, Länge 1, Mussangabe
        /// N = kein Wiedereingliederungsfall, J = Wiedereingliederungsfall
        /// </remarks>
        public string MMWE { get; set; }
    }
}
