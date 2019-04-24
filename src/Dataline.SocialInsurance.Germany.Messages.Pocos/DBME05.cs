// <copyright file="DBME05.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBME - Meldesachverhalt
    /// </summary>
    public class DBME05 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBME05"/> Klasse
        /// </summary>
        public DBME05()
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
        /// Holt oder setzt das Kennzeichen Midijob.
        /// </summary>
        /// <remarks>
        /// Kennzeichen Gleitzone, Länge 1, Mussangabe.
        /// 0 = kein Arbeitsentgelt innerhalb der Grenzen des § 20 Abs. 2 SGB IV/Verzicht;
        /// 1 = Arbeitentgelt durchgehend innerhalb Grenzen des § 20 Abs. 2 SGB IV;
        /// 2 = Arbeitsentgelt sowohl innerhalb als auch außerhalb der Grenzen des § 20 Abs. 2 SGB IV.
        /// </remarks>
        public string KENNZMIDI { get; set; }

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
        public bool KENNZMF { get; set; }

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

        /// <summary>
        /// Holt oder setzt das Entgelt Rentenberechnung
        /// (nur, wenn <see cref="KENNZMIDI"/> gleich 1 oder 2 ist).
        /// </summary>
        /// <remarks>Länge 1, Kann-Feld.</remarks>
        /// <value>
        /// Das Entgelt (in vollen Euro), das ohne die Anwendung des § 163 Abs. 10 AGB IV i.V.m.
        /// § 20 Abs. 2 SGB IV (Midijobs) in der Rentenversicherung beitragspflichtig wäre (tatsächliches
        /// Entgelt) zuzüglich des in der Rentenversicherung beitragspflichtigen Entgeltes in Zeiträumen,
        /// in denen keine Beschäftigung nach § 20 Abs. 2 SGB IV vorlag.
        /// </value>
        public int EGRB { get; set; }
    }
}
