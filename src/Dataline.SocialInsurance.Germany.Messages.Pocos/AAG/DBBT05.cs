﻿// <copyright file="DBBT05.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.AAG
{
    /// <summary>
    /// Datenbaustein: DBBT - Erstattung der Arbeitgeberaufwendungen Beschäftigungsverbot
    /// </summary>
    public class DBBT05 : IDatenbaustein
    {
        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; } = "DBBT";

        /// <summary>
        /// Holt oder setzt das Kennzeichen Verarbeitung
        /// </summary>
        /// <remarks>
        /// Kennzeichen Verarbeitung, Länge 1, Mussangabe
        /// 0 = Antrag auf Erstattung, 1 = Stornierung des Erstattungsantrags
        /// </remarks>
        [Obsolete("Bitte verwenden Sie statt dessen KENNZV")]
        public string KENNST { get => KENNZV.ToString("D1"); set => KENNZV = Convert.ToInt32(value, 10); }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Verarbeitung
        /// </summary>
        /// <remarks>
        /// Kennzeichen Verarbeitung, Länge 1, Mussangabe
        /// 0 = Antrag auf Erstattung, 1 = Stornierung des Erstattungsantrags
        /// </remarks>
        public int KENNZV { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Erstattungszeitraums
        /// </summary>
        /// <remarks>
        /// Beginn des Erstattungszeitraums, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate EZEITVOM { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Erstattungszeitraums
        /// </summary>
        /// <remarks>
        /// Ende des Erstattungszeitraums, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate EZEITBIS { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen der Art der Abrechnung
        /// </summary>
        /// <remarks>
        /// Kennzeichen Art der Abrechnung, Länge 1, Mussangabe
        /// 0 = Endabrechnung, 1 = Zwischenabrechnung
        /// </remarks>
        public int ARTAB { get; set; }

        /// <summary>
        /// Holt oder setzt das fortgezahlte Bruttoarbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Fortgezahltes Bruttoarbeitsentgelt(ohne Einmalzahlung), Länge 9, Mussangabe
        /// in der Form: EURO/CENT
        /// </remarks>
        public int FBRUTAU { get; set; }

        /// <summary>
        /// Holt oder setzt die fortgezahlten Arbeitgeberanteile
        /// </summary>
        /// <remarks>
        /// Fortgezahlte Arbeitgeberanteile(ohne Einmalzahlung), Länge 9, Pflichtangabe, soweit bekannt
        /// in der Form: EURO/CENT
        /// </remarks>
        public int FAGANT { get; set; }

        /// <summary>
        /// Holt oder setzt den Erstattungssatz für das fortgezahlte Bruttoarbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Erstattungssatz für das fortgezahlte Bruttoarbeitsentgelt(100% = 10000), Länge 5, Mussangabe
        /// </remarks>
        public int ESATZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Erstattungsbetrag
        /// </summary>
        /// <remarks>
        /// Erstattungsbetrag in der Form: EURO/CENT, Länge 9, Mussangabe
        /// </remarks>
        public int EBU { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Art des Beschäftigungsverbotes
        /// </summary>
        /// <remarks>
        /// Kennzeichen Art des Beschäftigungsverbotes
        /// 0 = individuelles Beschäftigungsverbot(ärztliches Attest liegt vor)
        /// 1 = generelles Beschäftigungsverbot
        /// 2 = teilweise individuelles Beschäftigungsverbot(ärztliches Attest liegt vor)
        /// 3 = teilweise generelles Beschäftigungsverbot
        /// </remarks>
        public int ARTBV { get; set; }

        /// <summary>
        /// Holt oder setzt den mutmaßlichen Entbindungstag
        /// </summary>
        /// <remarks>
        /// Mutmaßlicher Entbindungstag, Länge 8, Pflichtangabe, soweit bekannt
        /// </remarks>
        public LocalDate? MUTEN { get; set; }

        /// <summary>
        /// Erstattungsfähige Arbeitgeberzuwendungen zur betrieblichen Altersvorsorge
        /// </summary>
        /// <remarks>
        /// Kann, EURO/CENT
        /// </remarks>
        public int EZB { get; set; }

        /// <summary>
        /// SV-pflichtiges Arbeitsentgelt (ohne Einmalzahlung)
        /// </summary>
        /// <remarks>
        /// Kann, EURO/CENT
        /// </remarks>
        public int SVAE { get; set; }
    }
}
