// <copyright file="DBKGBasis04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public abstract class DBKGBasis04 : IDatenbaustein
    {
        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Art des gewählten Wertguthabenmodells
        /// </summary>
        /// <remarks>
        /// 0 = KUG
        /// 1 = S-KUG
        /// </remarks>
        public string KENNZKUG { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl Sollstunden
        /// </summary>
        /// <remarks>
        /// Stunden, Länge 5 mit 2 NK, Mussangabe
        /// </remarks>
        public int SOLLSTD { get; set; }

        /// <summary>
        /// Holt oder setzt die ausgefallenen Arbeitsstunden
        /// </summary>
        /// <remarks>
        /// Stunden, Länge 5 mit 2 NK, Mussangabe
        /// </remarks>
        public int AUSFSTD { get; set; }

        /// <summary>
        /// Holt oder setzt das auf 80 % gekürzte ausgefallene Arbeitsentgelt KV (sog. Fiktivlohn)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVAEGKV { get; set; }

        /// <summary>
        /// Holt oder setzt das auf 80 % gekürzte ausgefallene Arbeitsentgelt RV (sog. Fiktivlohn)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVAEGRV { get; set; }

        /// <summary>
        /// Holt oder setzt das auf 80 % gekürzte ausgefallene Arbeitsentgelt PV (sog. Fiktivlohn)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVAEGPV { get; set; }

        /// <summary>
        /// Holt oder setzt das auf 80 % gekürzte ausgefallene Arbeitsentgelt für behinderte AN in geschützten Einrichtungen
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? FIKTIVAEGRVBEH { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe KV-Beitrag ohne KV-Zusatzbeitrag aus fiktivem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVKVBY { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe RV-Beitrag aus fiktivem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVRVBY { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe PV-Beitrag aus fiktivem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int FIKTIVPVBY { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe KV-Zusatzbeitrag aus fiktivem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? FIKTIVKVBYZUSATZ { get; set; }
    }
}
