using System;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBUV - Unfallversicherung
    /// </summary>
    public class DBUV : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBUV"/> Klasse.
        /// </summary>
        public DBUV()
        {
            KE = "DBUV";
        }

        /// <summary>
        /// KENNUNG KE, Kennung, Stellen 001-004, Mussangabe
        /// </summary>
        public string KE { get; set; }

        /// <summary>
        /// ANZAHL-UV, Anzahl angehängter UV-Daten(maximal 9), Stellen 005-005, Mussangabe
        /// </summary>
        public string AnzahlUV { get; set; }

        /// <summary>
        /// RESERVE, Reservefelder, Stellen 006-020, Mussangabe
        /// </summary>
        public string Reserve { get; set; }

        // die folgenden Felder wiederholen sich entsprechend der Anzahl im Feld ANUV

        /// <summary>
        /// UV-GRUND-n UVGDn, Grund für die Besonderheiten bei der Abgabe der UVDaten, Stellen 001-003, Mussangabe
        /// Grundstellung (Leerzeichen) = ohne Besonderheiten
        /// A07 = Meldungen für Arbeitnehmer der UV-Träger
        /// A08 = Unternehmen ist Mitglied bei einer landwirtschaftlichen Berufsgenossenschaft
        /// A09 = Beitrag zur Unfallversicherung wird nicht nach dem Arbeitsentgelt bemessen (wie z.B. dieKopfpauschale)
        /// B01 = Entsparung von ausschließlich sozialversicherungspflichtigem Wertguthaben
        /// B02 = Keine UV-Pflicht wegen Auslandsbeschäftigung
        /// B03 = Versicherungsfreiheit in der UV gemäß SGB VII
        /// C01 = Entsparung von übertragenem Wertguthaben durch die DRV Bund
        /// </summary>
        public string UVGrund { get; set; }

        /// <summary>
        /// BBNR-UV-n BBNRUVn, Betriebsnummer des zuständigen UV-Trägers, Stellen 004-0018, (8 Stellen linksbündig mit nachfolgenden Leerzeichen)
        /// </summary>
        public string Betriebsnummer { get; set; }

        /// <summary>
        /// MITGLIEDS-NR-n MNRn, Mitgliedsnummer des Unternehmens beim zuständigen UV-Träger, Stellen 039-053, Mussangabe unter Bedingungen
        /// </summary>
        public string Mitgliedsnummer { get; set; }

        /// <summary>
        /// BBNR-GTS-n BBNRGTn, Betriebsnummer des UV-Trägers, dessen Gefahrtarif angewendet wird, Stellen 039-053, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe unter Bedingungen
        /// </summary>
        public string BetriebsnummerGTS { get; set; }

        /// <summary>
        /// GT-STELLE-n GTSTn, Gefahrtarifstelle, Stellen 054-061, Mussangabe unter Bedingungen
        /// </summary>
        public string Gefahrtarifstelle { get; set; }

        /// <summary>
        /// UV-EG-n UVEGn, Beitragspflichtiges Arbeitsentgelt zur Unfallversicherung, Stellen 062-067, Mussangabe
        /// </summary>
        public string BeitragsArbeitsentgelt { get; set; }

        /// <summary>
        /// ARBSTD-n ARBSTDn, Geleistete Arbeitsstunden, Stellen 068-071, Mussangabe
        /// </summary>
        public string Arbeitsstunden { get; set; }
    }
}
