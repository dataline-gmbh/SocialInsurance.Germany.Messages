// <copyright file="DBZU04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.AAG
{
    /// <summary>
    /// Datenbaustein: DBZU - Erstattung der Arbeitgeberzuschusses Mutterschaft
    /// </summary>
    public class DBZU04 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBZU04"/> Klasse
        /// </summary>
        public DBZU04()
        {
            KE = "DBZU";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

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
        /// Holt oder setzt das Kennzeichen Art der Abrechnung
        /// </summary>
        /// <remarks>
        /// Kennzeichen Art der Abrechnung, Länge 1, Mussangabe
        /// 0 = Endabrechnung, 1 = Zwischenabrechnung
        /// </remarks>
        public int ARTAB { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Schutzfrist
        /// </summary>
        /// <remarks>
        /// Beginn der Schutzfrist, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate SFRISTVOM { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende der Schutzfrist
        /// </summary>
        /// <remarks>
        /// Ende der Schutzfrist, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate SFRISTBIS { get; set; }

        /// <summary>
        /// Holt oder setzt die Höhe des monatlichen Bruttoentgelts
        /// </summary>
        /// <remarks>
        /// Höhe des monatlichen Bruttoentgelts, Länge 9, Mussangabe
        /// </remarks>
        public int BRUTMON { get; set; }

        /// <summary>
        /// Holt oder setzt das kalendertägliche Nettoarbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Kalendertägliches Nettoarbeitsentgelt, Länge 9, Mussangabe
        /// </remarks>
        public int NETTG { get; set; }

        /// <summary>
        /// Holt oder setzt die Höhe des monatlichen Nettoarbeitsentgelts
        /// </summary>
        /// <remarks>
        /// Höhe des monatlichen Nettoarbeitsentgelts, Länge 9, Mussangabe
        /// </remarks>
        public int NETMON { get; set; }

        /// <summary>
        /// Holt oder setzt den Zuschuss zum Mutterschaftsgeld
        /// </summary>
        /// <remarks>
        /// Zuschuss zum Mutterschaftsgeld(ohne Einmalzahlung), Länge 9, Mussangabe
        /// </remarks>
        public int ZUMUG { get; set; }

        /// <summary>
        /// Holt oder setzt das kalendertägliche Nettoarbeitsentgelt aus anderer(auch geringfügiger) Beschäftigung
        /// </summary>
        /// <remarks>
        /// Kalendertägliches Nettoarbeitsentgelt aus anderer (auch geringfügiger) Beschäftigung, Länge 9, Pflichtangabe, soweit bekannt
        /// </remarks>
        public int NETBESCH { get; set; }

        /// <summary>
        /// Holt oder setzt den mutmaßlichen Entbindungstag
        /// </summary>
        /// <remarks>
        /// Mutmaßlicher Entbindungstag, Länge 8, Pflichtangabe, soweit bekannt
        /// </remarks>
        public LocalDate? MUTEN { get; set; }
    }
}
