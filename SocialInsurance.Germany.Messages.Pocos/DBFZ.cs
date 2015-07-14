using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBFZ - Arbeitgeberangaben
    /// </summary>
    public class DBFZ : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBFZ"/> Klasse
        /// </summary>
        public DBFZ()
        {
            KE = "DBFZ";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten Fehlzeiteninformationen
        /// </summary>
        /// <remarks>
        /// Anzahl der angehängten Fehlzeiteninformationen, Länge 2, Mussangabe
        /// </remarks>
        public int ANFZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Liste der sich wiederholenden Felder
        /// </summary>
        public IList<DBFZ_FEHL> FEHL { get; set; }

        /// <summary>
        /// sich wiederholende Felder von DBFZ
        /// </summary>
        public class DBFZ_FEHL
        {
            /// <summary>
            /// Holt oder setzt den Beginn einer Fehlzeit
            /// </summary>
            /// <remarks>
            /// Beginn einer Fehlzeit, Länge 8, Mussangabe
            /// </remarks>
            public DateTime FEHLBEG { get; set; }

            /// <summary>
            /// Holt oder setzt die Art der Fehlzeit
            /// </summary>
            /// <remarks>
            /// Art der Fehlzeit, Länge 2
            /// 01 = Krankengeld/Krankentage-geld/KUG-Krankengeld/Übergangsgeld/Verletztengeld
            /// 02 = Kranken-/ Verletztengeld bei Pflege eines kranken Kindes
            /// 03 = Mutterschutzfrist (Mutterschaft nach §§ 3 Abs. 2, 6 Abs.1 MuschG)
            /// 04 = Versorgungskrankengeld, 05 = unbesetzt
            /// 06 = Pflegezeit nach § 2 oder § 3 Abs.1 PflegeZG
            /// 07 = Elternzeit, 08 = Einstellung Entgeltersatzleistung wegen voller Erwerbsminderungsrente
            /// 09 = Wehrdienst/Eignungsübung/Zivildienst/Wehrübung, 10 = unbezahlter Urlaub
            /// 11 = sonstige unbezahlte Fehlzeit, 12 = unbesetzt, 13 = Aussteuerung
            /// 14 = unbesetzt, 15 = unbesetzt, 16 = unwiderrufliche Freistellung ohne Weiterzahlung des Arbeitsentgeltes
            /// </remarks>
            public int FEHLART { get; set; }

            /// <summary>
            /// Holt oder setzt das Ende der Fehlzeit
            /// </summary>
            /// <remarks>
            /// Ende der Fehlzeit, Länge 8, Mussangabe
            /// </remarks>
            public int FEHLEND { get; set; }
        }
    }
}
