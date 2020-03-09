using System;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DBS404 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBS404"/> Klasse
        /// </summary>
        public DBS404()
        {
            KE = "DBS4";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// 0-EUR
        /// </remarks>
        public string WAEHRG { get; set; }

        /// <summary>
        /// Holt oder setzt die tatsächlich gezahlte Heuer
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public string SMKHEUERMTL { get; set; }

        /// <summary>
        /// Holt oder setzt das SMK-AG-pflichtige Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SMKAGBRUTTOMTL { get; set; }

        /// <summary>
        /// Holt oder setzt das SMK-AN-pflichtige Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SMKANBRUTTOMTL { get; set; }

        /// <summary>
        /// Holt oder setzt den SMK-Beitrag AG aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SMKBYAGMTL { get; set; }

        /// <summary>
        /// Holt oder setzt den SMK-Beitrag AN aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SMKBYANMTL { get; set; }

        /// <summary>
        /// Holt oder setzt SMK-AG-pflichtige einmalig gezahlte Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int EGASMKAGBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt SMK-AN-pflichtige einmalig gezahlte Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int EGASMKANBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt den SMK-Beitrag AG aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int EGASMKBYAG { get; set; }

        /// <summary>
        /// Holt oder setzt den SMK-Beitrag AN aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int EGASMKBYAN { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe des SMK-AG-pflichtigen Entgeltes (kumulativ, jährl.)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SMKAGBRUTTOGES { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe des SMK-AN-pflichtigen Entgeltes (kumulativ, jährl.)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SMKANBRUTTOGES { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe der reduzierten SMK-beitragspflichtigen Einnahme in der Gleitzone(kumulativ, jährlich)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int GZSMKBYPFLAEGES { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe SMK-Beitrag AG (kumulativ, jährl.)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SMKBYAGGES { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe SMK-Beitrag AN (kumulativ, jährl.)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SMKBYANGES { get; set; }
    }
}
