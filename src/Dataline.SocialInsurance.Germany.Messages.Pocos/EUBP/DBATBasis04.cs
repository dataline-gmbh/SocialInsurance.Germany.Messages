// <copyright file="DBATBasis04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// Die Basisklasse für die Datenbausteine Altersteilzeit.
    /// </summary>
    public abstract class DBATBasis04 : IDatenbaustein
    {
        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen KUG.
        /// </summary>
        /// <remarks>
        /// 0 = Summenfeldermodell
        /// 1 = Alternativ-/Options-Modell.
        /// </remarks>
        public string ATZMODELL { get; set; }

        /// <summary>
        /// Holt oder setzt den Aufstockungsbetrag bei ATZ.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int ASBTRG { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe der zusätzlichen beitragspflichtigen Einnahme in der RV.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int BYPFLEINRV { get; set; }

        /// <summary>
        /// Holt oder setzt den RV-Beitrag AG.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int BYPFLEINRVBYAG { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe meldepflichtiges Entgelt bei Störfall ATZ.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int EG { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe des seit dem Beginn der Vereinbarung angesparten Wertguthabens ATZ.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? SUM { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe des seit dem Beginn der Vereinbarung angesparten Wertguthabens ATZ Ost.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? SUMOST { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe des seit dem Beginn der Vereinbarung angesparten Wertguthabens ATZ West.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? SUMWEST { get; set; }

        /// <summary>
        /// Holt oder setzt KV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? KVPFLAEGSUM { get; set; }

        /// <summary>
        /// Holt oder setzt RV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? RVPFLAEGSUM { get; set; }

        /// <summary>
        /// Holt oder setzt AV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? AVPFLAEGSUM { get; set; }

        /// <summary>
        /// Holt oder setzt PV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? PVPFLAEGSUM { get; set; }

        /// <summary>
        /// Holt oder setzt UV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? UVPFLAEGSUM { get; set; }

        /// <summary>
        /// Holt oder setzt Betrag nach § 3 Abs. 1 Nr. 1 Buchstabe b des Altersteilzeitgesetzes.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? UNTERSCHIEDSBTRG { get; set; }

        /// <summary>
        /// Holt oder setzt Betrag nach § 3 Abs. 1 Nr. 1 Buchstabe a des Altersteilzeitgesetzes.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int REGELAEG { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft KV.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int KVSVLUFT { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft RV.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int RVSVLUFT { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft AV.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int AVSVLUFT { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft PV.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int PVSVLUFT { get; set; }

        /// <summary>
        /// Holt oder setzt KV-beitragspflichtiger Teil des Wertguthabens.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? KVABGEGRSVLUFTSUM { get; set; }

        /// <summary>
        /// Holt oder setzt RV-beitragspflichtiger Teil des Wertguthabens.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? RVABGEGRSVLUFTSUM { get; set; }

        /// <summary>
        /// Holt oder setzt AV-beitragspflichtiger Teil des Wertguthabens.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? AVABGEGRSVLUFTSUM { get; set; }

        /// <summary>
        /// Holt oder setzt PV-beitragspflichtiger Teil des Wertguthabens.
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen.
        /// </remarks>
        public int? PVABGEGRSVLUFTSUM { get; set; }
    }
}
