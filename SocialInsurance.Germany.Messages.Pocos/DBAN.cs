using System;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBAN - Anschrift
    /// </summary>
    public class DBAN
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBAN"/> Klasse.
        /// </summary>
        public DBAN()
        {
            Kennung = "DBAN";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        public string Kennung { get; set; }

        /// <summary>
        /// Länderkennzeichen, Stellen 005-007, Mussangabe unter Bedingungen
        /// </summary>
        public string Länderkennzeichen { get; set; }

        /// <summary>
        /// LAENDER-KENNZ LDKZ, PLZ, Stellen 008-017, Mussangabe unter Bedingungen
        /// </summary>
        public string PLZ { get; set; }

        /// <summary>
        /// WOHNORT ORT, Wohnort, Stellen 018-051, Mussangabe
        /// </summary>
        public string Wohnort { get; set; }

        /// <summary>
        /// STRASSE STR, Straße, Stellen 052-084, Pflichtangabe, soweit bekannt
        /// </summary>
        public string Strasse { get; set; }

        /// <summary>
        /// HAUS-NR NR, Hausnummer, Stellen 085-093, Pflichtangabe, soweit bekannt
        /// Wenn die Hausnummer nicht separat abgelegt werden kann, ist es zulässig, die Hausnummer in das
        /// Feld Straße zu übernehmen. In solchen Fällen muss dann das Feld Hausnummer auf Grundstellung
        /// (Leerzeichen) stehen.
        /// </summary>
        public string Hausnummer { get; set; }

        /// <summary>
        /// ADR-ZUSATZ, Anschriftenzusatz, Stellen 094-133, Pflichtangabe, soweit bekannt
        /// </summary>
        public string Anschriftenzusatz { get; set; }
    }
}
