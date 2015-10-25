// <copyright file="DBKV03.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBKV - Krankenversicherung (GKV-Monatsmeldung)
    /// </summary>
    public class DBKV03 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBKV03"/> Klasse
        /// </summary>
        public DBKV03()
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
        public string KENNZST { get; set; }

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
        public DateTime ZRBGKV { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums der Meldung
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraums, für den die Meldung gelten soll(Beschäftigungsende oder Ende des Abrechnungszeitraums), Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRENKV { get; set; }

        /// <summary>
        /// Holt oder setzt das einmalig gezahlte Entgelt
        /// </summary>
        /// <remarks>
        /// Einmalig gezahltes Entgelt in Eurocent, Länge 8, Mussangabe
        /// </remarks>
        public int EZEG { get; set; }

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
        /// Holt oder setzt das laufende Entgelt zur KV/PV in Eurocent
        /// </summary>
        public int LFDKV { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Entgelt zur RV in Eurocent
        /// </summary>
        public int LFDRV { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Entgelt zur ALV in Eurocent
        /// </summary>
        public int LFDAV { get; set; }
    }
}
