// <copyright file="DBME04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBME - Meldesachverhalt
    /// </summary>
    public class DBME04 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBME04"/> Klasse
        /// </summary>
        public DBME04()
        {
            KE = "DBME";
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
        /// Kennzeichen Stornierung, Länge 1, Stornierung einer bereits abgegebenen Meldung: N = keine Stornierung;J = Stornierung, Mussangabe
        /// </remarks>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Gleitzone
        /// </summary>
        /// <remarks>
        /// Kennzeichen Gleitzone, Länge 1, 0 = kein Arbeitsentgelt
        /// innerhalb der Gleitzone/Verzicht auf die Gleitzonenregelung;
        /// 1 = Arbeitentgelt durchgehend innerhalb der Gleitzone;
        /// 2 = Arbeitsentgelt sowohl innerhalb als auch außerhalb der Gleitzone, Mussangabe
        /// </remarks>
        public string KENNZGLE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, Länge 8, für den die Meldung gelten soll
        /// (Beschäftigungsbeginn), in der Form: jhjjmmtt, Mussangabe
        /// </remarks>
        public LocalDate ZRBG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraumes, Länge 8, für den die Meldung gelten soll
        /// (Beschäftigungsende), in der Form: jhjjmmtt
        /// Das ZREN muss für Anmeldungen (GD im DSME = 10 - 13) Nullen sein, Mussangabe
        /// </remarks>
        public LocalDate? ZREN { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der Tage für kurzfristig Beschäftigte
        /// </summary>
        public int ZLTG { get; set; }

        /// <summary>
        /// Holt oder setzt das Währungskennzeichen
        /// </summary>
        /// <remarks>
        /// Währungskennzeichen, Länge 1, E = Euro, Mussangabe unter Bedingungen
        /// </remarks>
        public string WG { get; set; }

        /// <summary>
        /// Holt oder setzt das Entgelt
        /// </summary>
        /// <remarks>
        /// Entgelt in vollen Euro, Länge 6, Mussangabe
        /// </remarks>
        public int EG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel
        /// </summary>
        /// <remarks>
        /// Beitragsgruppenschlüssel, Länge 4,
        /// Stelle 1 = KV, Stelle 2 = RV,
        /// Stelle 3 = ALV, Stelle 4 = PV, Mussangabe
        /// </remarks>
        public string BYGR { get; set; }

        /// <summary>
        /// Holt oder setzt den Tätigkeitsschlüssel
        /// </summary>
        /// <remarks>
        /// Angaben zur Tätigkeit, Länge 9, Mussangabe
        /// </remarks>
        public string TTSC { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Betriebssstätte (Rechtskreis)
        /// </summary>
        /// <remarks>
        /// Kennzeichen Betriebsstätte (Rechtskreis), Länge 1,
        /// W = altes Bundesland, O = neues Bundesland einschließlich Ost-Berlin, Mussangabe
        /// </remarks>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Mehrfachbeschäftigter
        /// </summary>
        /// <remarks>
        /// Kennzeichen Mehrfachbeschäftigter, Länge 1, Mussangabe
        /// </remarks>
        public string KENNZMF { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Additionspflege
        /// </summary>
        /// <remarks>
        /// Zulässig ist die Grundstellung (Null) oder „2“ – „9“. Länge 1. Mussangabe.
        /// </remarks>
        public int KENNZAP { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen "Saisonarbeitnehmer"
        /// </summary>
        /// <remarks>
        /// Länge 1, Kann-Feld
        /// </remarks>
        public bool? KENNZSAN { get; set; }
    }
}
