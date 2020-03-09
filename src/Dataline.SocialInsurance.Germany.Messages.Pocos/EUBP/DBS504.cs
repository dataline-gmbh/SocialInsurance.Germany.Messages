using System;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DBS504 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBS504"/> Klasse
        /// </summary>
        public DBS504()
        {
            KE = "DBS5";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt Summe des SMK-AGpflichtigen Arbeitsentgeltes (kumulativ) einschl. einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public string SMKAGBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt Summe des SMK-ANpflichtigen Arbeitsentgeltes (kumulativ) einschl. einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SMKANBRUTTO { get; set; }
    }
}
