// <copyright file="DBKV02.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBKV - Krankenversicherung (GKV-Monatsmeldung)
    /// </summary>
    public class DBKV02 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBKV02"/> Klasse
        /// </summary>
        public DBKV02()
        {
            KE = "DBKV";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Stornierung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, Stornierung einer bereits abgegebenen Meldung, Länge 1, Mussangabe
        /// N = keine Stornierung
        /// J = Stornierung
        /// </remarks>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund für Besonderheiten bei der Abgabe der KV-Daten
        /// </summary>
        /// <remarks>
        /// Grund für die Besonderheiten bei der Abgabed er KV-Daten, Länge 2, Mussangabe
        /// Grundstellung (00) = ohne Besonderheiten, 01 = GKVMonatsmeldung für unständig Beschäftigte
        /// 02 = GKVMonatsmeldung bei nicht vollständigem Sozialausgleich
        /// </remarks>
        public int KVGD { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der SV-Beitragspflichttage
        /// </summary>
        /// <remarks>
        /// Anzahl der Tage, für die eine Beitragspflicht zur Sozialversicherungim Abrechnungsmonat besteht (SV-Tage), Länge 2, Mussangabe
        /// </remarks>
        public int SVTG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums der Meldung
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, für den die Meldung gelten soll(Beschäftigungsbeginn oder Beginn des Abrechnungszeitraums), Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ZRBGKV { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums der Meldung
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraums, für den die Meldung gelten soll(Beschäftigungsende oder Ende des Abrechnungszeitraums), Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ZRENKV { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Entgelt
        /// </summary>
        /// <remarks>
        /// Laufendes Entgelt in Eurocent, Länge 8, Mussangabe
        /// </remarks>
        public int LFDEG { get; set; }

        /// <summary>
        /// Holt oder setzt das einmalig gezahlte Entgelt
        /// </summary>
        /// <remarks>
        /// Einmalig gezahltes Entgelt in Eurocent, Länge 8, Mussangabe
        /// </remarks>
        public int EZEG { get; set; }

        /// <summary>
        /// Holt oder setzt die beitragspflichtige Einnahme in der gesetzlichen Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Beitragspflichtige Einnahme in der gesetzlichen Rentenversicherung bei Bezug von Kurzarbeitergeld nach § 163 Absatz 6 SGB VI
        /// in Eurocent, Länge 8, Mussangabe
        /// </remarks>
        public int BBGRUKUG { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen für die Gleitzonenregelung des Beschäftigten
        /// </summary>
        /// <remarks>
        /// Kennzeichen, dass der Beschäftigte Entgelte im Sinne der Gleitzonenregelung erhält, Länge 1, Mussangabe
        /// 0 = kein Arbeitsentgelt innerhalb der Gleitzone, 1 = Arbeitsentgelt innerhalb der Gleitzone
        /// </remarks>
        public int KENNZGLESV { get; set; }

        /// <summary>
        /// Holt oder setzt das regelmäßige Jahresentgelt
        /// </summary>
        /// <remarks>
        /// Regelmäßiges Jahresentgelt in Eurocent, Länge 8, Mussangabe unter Bedingungen
        /// </remarks>
        public string RJEG { get; set; }

        /// <summary>
        /// Holt oder setzt die beitragpflichtigen Einnahmen der gesetzlichen Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Beitragspflichtige Einnahmen in der gesetzlichen Rentenversicherung bei Bezug von Aufstockungsbeträgen
        /// nach § 163 Absatz 5 Satz 1 SGB VI in Eurocent, Länge 8, Mussangabe
        /// </remarks>
        public string BBGRUATG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel
        /// </summary>
        /// <remarks>
        /// Beitragsgruppenschlüssel, Länge 4, Mussangabe
        /// Stelle 1 = KV, Stelle 2 = RV, Stelle 3 = ALV, Stelle 4 = PV
        /// </remarks>
        public string BYGR { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Rechtskreis
        /// </summary>
        /// <remarks>
        /// Kennzeichen Rechtskreis, Länge 1, Mussangabe
        /// W = altes Bundesland, O = neues Bundesland einschließlich Ost-Berlin
        /// </remarks>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Kennzeichen, ob die Elterneigenschaft beim Arbeitgeber nachgewiesen wurde
        /// </summary>
        [Obsolete]
        public bool? EENW { get; set; }

        /// <summary>
        /// Kennzeichen, ob für die Beschäftigung die Sonderregelung nach § 58 Absatz 3 SGB XI anzuwenden ist
        /// </summary>
        [Obsolete]
        public bool? SOSA { get; set; }
    }
}
