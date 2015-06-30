using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBKV - Krankenversicherung (GKV-Monatsmeldung)
    /// </summary>
    public class DBKV : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBKV"/> Klasse.
        /// </summary>
        public DBKV() 
        {
            KE = "DBKV";
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
        /// Kennzeichen, Stornierung einer bereits abgegebenen Meldung, Länge 1, Mussangabe
        /// N = keine Stornierung
        /// J = Stornierung
        /// </remarks>
        public string KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld 1
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 2, Mussangabe
        /// </remarks>
        public string RESERVE1 { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der SV-Beitragspflichttage
        /// </summary>
        /// <remarks>
        /// Anzahl der Tage, für die eine Beitragspflicht zur Sozialversicherungim Abrechnungsmonat besteht (SV-Tage), Länge 2, Mussangabe
        /// </remarks>
        public string SVTG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums der Meldung
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, für den die Meldung gelten soll(Beschäftigungsbeginn oder Beginn des Abrechnungszeitraums), Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRBGKV { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums der Meldung
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraums, für den die Meldung gelten soll(Beschäftigungsende oder Ende des Abrechnungszeitraums), Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRENKV { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld 2
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 8, Mussangabe
        /// </remarks>
        public string RESERVE2 { get; set; }

        /// <summary>
        /// Holt oder setzt das einmalig gezahlte Entgelt
        /// </summary>
        /// <remarks>
        /// Einmalig gezahltes Entgelt in Eurocent, Länge 8, Mussangabe
        /// </remarks>
        public string EZEG { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld 3
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 27, Mussangabe
        /// </remarks>
        public string RESERVE3 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel
        /// </summary>
        /// <remarks>
        /// Beitragsgruppenschlüssel, Länge 4, Mussangabe
        /// Stelle 1 = KV, Stelle 2 = RV, Stelle 3 = ALV, Stelle 4 = PV
        /// </remarks>
        public string BYGR { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Rechtskreis
        /// </summary>
        /// <remarks>
        /// Kennzeichen Rechtskreis, Länge 1, Mussangabe
        /// W = altes Bundesland, O = neues Bundesland einschließlich Ost-Berlin
        /// </remarks>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Entgelt zur KV/PV
        /// </summary>
        /// <remarks>
        /// Laufendes Entgelt zur KV/PV in Eurocent, Länge 8, Mussangabe
        /// Laufendes Arbeitsentgelt von dem Beiträge bei Versicherungspflicht
        /// zur Kranken- und Pflegeversicherung gezahlt wurden oder zu zahlen gewesen wären
        /// </remarks>
        public string LFDKV { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Entgelt zur RV
        /// </summary>
        /// <remarks>
        /// Laufendes Entgelt zur RV in Eurocent, Länge 8, Mussangabe
        /// Laufendes Arbeitsentgelt von dem Beiträge zur gesetzlichen Rentenversicherung gezahlt wurden
        /// </remarks>
        public string LFDRV { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Entgelt zur AIV
        /// </summary>
        /// <remarks>
        /// Laufendes Entgelt zur AlV in Eurocent
        /// Laufendes Arbeitsentgelt von dem Beiträge zur Arbeitslosenversicherung gezahlt wurden
        /// </remarks>
        public string LFDAV { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld 4
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 53, Mussangabe
        /// </remarks>
        public string RESERVE4 { get; set; }
    }
}
