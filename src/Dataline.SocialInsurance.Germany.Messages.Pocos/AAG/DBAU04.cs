// <copyright file="DBAU04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.AAG
{
    /// <summary>
    /// Datenbaustein: DBAU - Erstattung der Arbeitgeberaufwendungen Arbeitsunfähigkeit
    /// </summary>
    public class DBAU04 : IDatenbaustein
    {
        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; } = "DBAU";

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
        /// Holt oder setzt das Entgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 9, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen, Angabe in Abhängigkeit vom Feld ARTENTGELT
        /// </remarks>
        public int EG { get; set; }

        /// <summary>
        /// Holt oder setzt die Art des Entgelts
        /// </summary>
        /// <remarks>
        /// Art des Entgelts, Länge 1, Mussangabe
        /// 1 = Stundenlohn, 2 = monatliches Bruttoarbeitsentgelt, 3 = Akkordlohn
        /// </remarks>
        public int ARTEG { get; set; }

        /// <summary>
        /// Holt oder setzt die Abtretung
        /// </summary>
        /// <remarks>
        /// Die Abtretung nach § 5 AAG wird erklärt, Länge 1, Mussangabe
        /// J = Ja N = Nein
        /// </remarks>
        public bool ABTG { get; set; }

        /// <summary>
        /// Holt oder setzt die ausgefallene Kalenderzeit
        /// </summary>
        /// <remarks>
        /// Ausgefallene Kalendertage/Arbeitstage/Arbeitsstunden, Länge 5, Mussangabe
        /// mit zwei Nachkommastellen
        /// </remarks>
        public int AUSFALLZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Art der Ausfallzeit
        /// </summary>
        /// <remarks>
        /// Art der Ausfallzeit, Länge 1, Mussangabge
        /// 1 = Kalendertage, 2 = Arbeitstage, 3 = Arbeitsstunden
        /// </remarks>
        public int ARTAUSFALLZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Angabe der wöchentlichen Arbeitszeit in Stunden und Industrieminuten
        /// </summary>
        /// <remarks>
        /// Angabe der wöchentlichen Arbeitszeit in Stunden und Industrieminuten, Länge 4, Mussangabe unter Bedingungen
        /// mit zwei Nachkommastellen in der Form: 0000 (z. B. 3750)
        /// </remarks>
        public int AZWOECH { get; set; }

        /// <summary>
        /// Holt oder setzt die Angabe der täglichen Arbeitszeit in Stunden und Industrieminuten
        /// </summary>
        /// <remarks>
        /// Angabe der täglichen Arbeitszeit in Stunden und Industrieminuten, Länge 4, Mussangabe unter Bedingungen
        /// mit zwei Nachkommastellen in der Form: 0000 (z. B. 3750)
        /// </remarks>
        public int AZTGL { get; set; }

        /// <summary>
        /// Holt oder setzt das forgezahlte Bruttoarbeitsentgelt
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
        /// Holt oder setzt den Prozentsatz der Erstattung
        /// </summary>
        /// <remarks>
        /// Prozentsatz der Erstattung, Länge 5, Mussangabe
        /// in der Form: 00000 (80% = 08000)
        /// </remarks>
        public int ESATZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Erstattungsbeitrag
        /// </summary>
        /// <remarks>
        /// Erstattungsbetrag, Länge 9, Mussangabe
        /// in der Form: EURO/CENT
        /// </remarks>
        public int EBU { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Unfall
        /// </summary>
        /// <remarks>
        /// Kennzeichen Unfall, Länge 1, Pflichtangabe, soweit bekannt
        /// in der Form: 0 = Grundstellung
        /// 1 = Schädigung durch Dritte, 2 = Arbeitsunfall/Berufskrankheit
        /// </remarks>
        public int URAU { get; set; }

        /// <summary>
        /// Holt oder setzt, ob am 1. Arbeitsunfähigkeitstag noch gearbeitet wurde
        /// </summary>
        /// <remarks>
        /// Wurde am 1. Arbeitsunfähigkeitstag noch gearbeitet? Länge 1, Mussangabe
        /// J = Ja, N = Nein
        /// </remarks>
        public bool AUTG { get; set; }

        /// <summary>
        /// Holt oder setzt den letzten Arbeitstag/von Bord am
        /// </summary>
        /// <remarks>
        /// Letzter Arbeitstag/von Bord am, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate LAT { get; set; }

        /// <summary>
        /// Erstattungsfähige Arbeitgeberzuwendungen zur betrieblichen Altersvorsorge
        /// </summary>
        /// <remarks>
        /// Kann, EURO/CENT
        /// </remarks>
        public int EZB { get; set; }
    }
}
