// <copyright file="DSLAext04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>using System;


namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DSLAext04
    {
        /// <summary>
        /// Holt oder setzt die Lohnart
        /// </summary>
        public string LA { get; set; }

        /// <summary>
        /// Holt oder setzt die Bezeichnung Lohnart
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// Holt oder setzt die Herkunft der Lohnart
        /// </summary>
        /// <remarks>
        /// 0 - Keine Angabe
        /// 1 - Standardlohnart
        /// 2 - individuelle Lohnart
        /// </remarks>
        public string KENNZHERKUNFT { get; set; }

        /// <summary>
        /// Holt oder setzt die Verwendung der Lohnart
        /// </summary>
        /// <remarks>
        /// 0 - Keine Angabe
        /// 1 - buchbare Lohnart
        /// 2 - Rechen-/Systemlohnart
        /// </remarks>
        public string KENNZVERW { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Bruttolohnart/Nettobe- oder -abzüge
        /// </summary>
        /// <remarks>
        /// 0 - Bruttolohnart
        /// 1 - Nettobe- oder -abzug
        /// </remarks>
        public string KENNZBRUTTONETTO { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen SV
        /// </summary>
        /// <remarks>
        /// 0-SV-freies Arbeitsentgelt
        /// 1-laufendes Arbeitsentgelt
        /// 2-einmalig gezahltes Arbeitsentgelt
        /// 3-laufendes Arbeitsentgelt mit Freibetrag
        /// 4-einmalig gezahltes Arbeitsentgelt mit Freibetrag
        /// 5-umlagepflichtiges einmalig gezahltes Arbeitsentgelt (Vereinfachungsregel)
        /// </remarks>
        public string KENNZSV { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen UV
        /// </summary>
        /// <remarks>
        /// 0-UV-freies Entgelt
        /// 1-UV-pflichtiges Entgelt
        /// 2-UV-pflichtiges Entgelt mit Freibetrag
        /// </remarks>
        public string KENNZUV { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Steuer
        /// </summary>
        /// <remarks>
        /// 0-steuerfreies Arbeitsentgelt
        /// 1-laufendes Arbeitsentgelt
        /// 2-sonstiges Arbeitsentgelt
        /// 3-laufendes Arbeitsentgelt mit Freibetrag
        /// 4-sonstiges Arbeitsentgelt mit Freibetrag
        /// </remarks>
        public string KENNZSTEUER { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Steuerpflicht
        /// </summary>
        /// <remarks>
        /// 0-keine Angabe
        /// 1-individuelle Steuer
        /// 2-Pauschalsteuer
        /// 3-Mehrjahresbesteuerung
        /// </remarks>
        public string KENNZSTPFL { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Pauschalsteuer
        /// </summary>
        /// <remarks>
        /// 0-keine Angabe
        /// 1-Pauschalsteuer nach § 37b EStG
        /// 2-Pauschalsteuer nach § 40 Abs. 1 EStG
        /// 3-Pauschalsteuer nach § 40 Abs. 2 EStG
        /// 4-Pauschalsteuer nach § 40a Abs. 2 EStG
        /// 5-Pauschalsteuer nach § 40b EStG
        /// </remarks>
        public string KENNZPAUSCHSTEUER { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der gegen Entgelt geleisteten Stunden
        /// </summary>
        /// <remarks>
        /// Länge 6 mit 2 NK, Kannangabe
        /// </remarks>
        public int? BEZMENGE { get; set; }

        /// <summary>
        /// Holt oder setzt den Faktor für nach Menge bezahlte Arbeitsleistung
        /// </summary>
        /// <remarks>
        /// Länge 8 mit 4 NK, Kannangabe
        /// </remarks>
        public int? FAKTOR { get; set; }

        /// <summary>
        /// Holt oder setzt den Faktor für Zuschläge in Prozent
        /// </summary>
        /// <remarks>
        /// Länge 5 mit 2 NK, Kannangabe
        /// </remarks>
        public int? ZUSCHLAG { get; set; }

        /// <summary>
        /// Holt oder setzt den Gesamtbetrag aus Lohnart
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int LABTRGGES { get; set; }

        /// <summary>
        /// Holt oder setzt den Steuerbetrag aus Lohnart
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int LABTRGST { get; set; }

        /// <summary>
        /// Holt oder setzt den SV-Betrag aus Lohnart
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int LABTRGSV { get; set; }
    }
}
