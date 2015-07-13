using System;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBAN - Anschrift
    /// </summary>
    public class DBAN : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBAN"/> Klasse
        /// </summary>
        public DBAN()
        {
            KE = "DBAN";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Länderkennzeichen
        /// </summary>
        /// <remarks>
        /// Länderkennzeichen, Länge 3, Mussangabe unter Bedingungen
        /// </remarks>
        public string LDKZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl
        /// </summary>
        /// <remarks>
        /// Postleitzahl, Länge 10, Mussangabe unter Bedingungen
        /// </remarks>
        public string PLZ { get; set; }
                
        /// <summary>
        /// Holt oder setzt den Ort
        /// </summary>
        /// <remarks>
        /// Wohnort, Länge 34, Mussangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Strasse
        /// </summary>
        /// <remarks>
        /// Straße, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer
        /// </summary>
        /// <remarks>
        /// HAUS-NR NR, Hausnummer, Länge 9, Pflichtangabe, soweit bekannt
        /// Wenn die Hausnummer nicht separat abgelegt werden kann, ist es zulässig, die Hausnummer in das
        /// Feld Straße zu übernehmen. In solchen Fällen muss dann das Feld Hausnummer auf Grundstellung
        /// (Leerzeichen) stehen.
        /// </remarks>
        public string NR { get; set; }

        /// <summary>
        /// Holt oder setzt den Anschriftenzusatz
        /// </summary>
        /// <remarks>
        /// ADR-ZUSATZ, Anschriftenzusatz, Stellen 094-133, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string ADRZU { get; set; }
    }
}
