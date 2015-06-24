using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBME - Meldesachverhalt
    /// </summary>
    public class DBME
    {
        /// <summary>
        /// KENNUNG KE, Kennung, Stellen 001-004, Mussangabe
        /// </summary>
        public string Kennung { get; set; }

        /// <summary>
        /// KENNZ-STORNO KENNZST, Kennzeichen Stornierung, Stellen 005-005, Stornierung einer bereits abgegebenen Meldung: N = keine Stornierung;J = Stornierung, Mussangabe
        /// </summary>
        public string KennzeichenStorno { get; set; }

        /// <summary>
        /// KENNZ-GLEITZONE KENNZGLE, Kennzeichen Gleitzone, Stellen 006-006, 0 = kein Arbeitsentgelt innerhalb der Gleitzone/Verzicht auf die Gleitzonenregelung;1 = Arbeitentgelt durchgehend innerhalb der Gleitzone;2 = Arbeitsentgelt sowohl innerhalb als auch außerhalb der Gleitzone, Mussangabe
        /// </summary>
        public string KennzeichenGleitzone { get; set; }

        /// <summary>
        /// ZEITRAUM-BEGINN ZRBG, Beginn des Zeitraums, Stellen 007-014, für den die Meldung gelten soll (Beschäftigungsbeginn), in der Form: jhjjmmtt, Mussangabe
        /// </summary>
        public DateTime ZeitraumBeginn { get; set; }

        /// <summary>
        /// ZEITRAUM-ENDE ZREN, Ende des Zeitraumes, Stellen 015-022, für den die Meldung gelten soll(Beschäftigungsende), in der Form: jhjjmmtt. Das ZREN muss für Anmeldungen (GD im DSME = 10 - 13) Nullen sein., Mussangabe
        /// </summary>
        public DateTime ZeitraumEnde { get; set; }

        /// <summary>
        /// ZAHL-TAGE ZLTG, Anzahl der Tage für kurzfristig Beschäftigte, Stellen 023-024, Mussangabe
        /// </summary>
        public string Zahltage { get; set; }

        /// <summary>
        /// WAEHRUNGS-KENNZ WG, Währungskennzeichen, Stellen 025-025, E = Euro, Mussangabe unter Bedingungen
        /// </summary>
        public string Währungskennzeichen { get; set; }

        /// <summary>
        /// ENTGELT EG, Entgelt in vollen Euro, Stellen 025-031, Mussangabe
        /// </summary>
        public string Entgelt { get; set; }

        /// <summary>
        /// BEITRAGS-GRUPPE BYGR, Beitragsgruppenschlüssel, Stellen 032-035, Stelle 1 = KV, Stelle 2 = RV, Stelle 3 = ALV, Stelle 4 = PV, Mussangabe
        /// </summary>
        public string Beitragsgruppe { get; set; }

        /// <summary>
        /// TAETIGKEITS-SC TTSC, Angaben zur Tätigkeit, Stellen 036,044, Mussangabe
        /// </summary>
        public string Tätigkeitsschlüssel { get; set; }

        /// <summary>
        /// KENNZ-RECHTSKREIS KENNZRK, Kennzeichen Betriebsstätte (Rechtskreis), Stellen 045-045, W = altes Bundesland, O = neues Bundesland einschließlich Ost-Berlin, Mussangabe
        /// </summary>
        public string KennzeichenRechtskreis { get; set; }

        /// <summary>
        /// KENNZ-MEHRFACH KENNZMF, Kennzeichen Mehrfachbeschäftigter, Stellen 046-046, Mussangabe
        /// </summary>
        public string KennzeichenMehrfach { get; set; }

        /// <summary>
        /// INTERN, Internes Kennzeichen der Sozialversicherungsträger, Stellen 047-047
        /// </summary>
        public string Intern { get; set; }

        /// <summary>
        /// RESERVE, Reservefelder, Stellen 048-147
        /// </summary>
        public string Reserve { get; set; }
    }
}
