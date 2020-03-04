using System;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DBVS04 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBVS04"/> Klasse
        /// </summary>
        public DBVS04()
        {
            KE = "DBVS";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen KUG
        /// </summary>
        /// <remarks>
        /// 1 = S-KUG
        /// </remarks>
        public string KENNZKUG { get; set; }

        /// <summary>
        /// Holt oder setzt das fiktive Arbeitsentgelt KV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVAEGKV { get; set; }

        /// <summary>
        /// Holt oder setzt das fiktive Arbeitsentgelt RV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVAEGRV { get; set; }

        /// <summary>
        /// Holt oder setzt das fiktive Arbeitsentgelt PV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVAEGPV { get; set; }

        /// <summary>
        /// Holt oder setzt das fiktive Arbeitsentgelt RV bei behinderten AN in geschützten Einrichtungen
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? FIKTIVAEGRVBEH { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag ohne Zusatzbeitrag aus fiktivem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVKVBY { get; set; }

        /// <summary>
        /// Holt oder setzt den RV-Beitrag aus fiktivem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVRVBY { get; set; }

        /// <summary>
        /// Holt oder setzt den PV-Beitrag aus fiktivem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVPVBY { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Zusatzbeitrag aus fiktivem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? FIKTIVKVBYZUSATZ { get; set; }
    }
}
