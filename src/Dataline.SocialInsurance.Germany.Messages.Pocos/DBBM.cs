// <copyright file="DBBM.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBBM - Bestandsabweichung Meldeverfahren
    /// </summary>
    public class DBBM : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBBM"/> Klasse
        /// </summary>
        public DBBM()
        {
            KE = "DBBM";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Storno-Kennzeichen
        /// </summary>
        /// <remarks>Länge 1, Mussfeld, Stornierung einer bereits abgegebenen Meldung</remarks>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer
        /// </summary>
        /// <remarks>Länge 12, Kannfeld</remarks>
        public string AVSNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Personengruppe
        /// </summary>
        /// <remarks>Länge 3, Kannfeld</remarks>
        public int APERSGR { get; set; }

        /// <summary>
        /// Holt oder setzt den Abgabegrund
        /// </summary>
        /// <remarks>Länge 2, Kannfeld</remarks>
        public int AGD { get; set; }

        /// <summary>
        /// Holt oder setzt den Staatsangehörigkeitsschlüssel
        /// </summary>
        /// <remarks>Länge 3, Mussfeld</remarks>
        public string ASASC { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Gleitzone
        /// </summary>
        /// <remarks>
        /// Länge 1, Kannfeld
        /// 0 = kein Arbeitsentgelt innerhalb der Gleitzone/Verzicht auf die Gleitzonenregelung
        /// 1 = Arbeitsentgelt durchgehend innerhalb der Gleitzone
        /// 2 = Arbeitsentgelt sowohl innerhalb als auch außerhalb der Gleitzone
        /// </remarks>
        public int? AKENNZGLE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums, für den die Meldung gelten soll (Beschäftigungsbeginn)
        /// </summary>
        /// <remarks>Länge 8, Kannfeld</remarks>
        public LocalDate? AZRBG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraumes, für den die Meldung gelten soll (Beschäftigungsende)
        /// </summary>
        /// <remarks>Länge 8, Kannfeld</remarks>
        public LocalDate? AZREN { get; set; }

        /// <summary>
        /// Holt oder setzt das Entgelt in vollen Euro
        /// </summary>
        /// <remarks>Länge 6, Kannfeld</remarks>
        public int? AEG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel
        /// </summary>
        /// <remarks>
        /// Länge 4, Kannfeld
        /// Stelle  Bedeutung
        /// 1       KV
        /// 2       RV
        /// 3       ALV
        /// 4       PV
        /// </remarks>
        public string ABYGR { get; set; }

        /// <summary>
        /// Holt oder setzt den Tätigkeitsschlüssel
        /// </summary>
        /// <remarks>
        /// Länge 9, Kannfeld
        /// </remarks>
        public string ATTSC { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Betriebssstätte (Rechtskreis)
        /// </summary>
        /// <remarks>
        /// Kennzeichen Betriebsstätte (Rechtskreis), Länge 1,
        /// W = altes Bundesland, O = neues Bundesland einschließlich Ost-Berlin, Kannfeld
        /// </remarks>
        public string AKENNZRK { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Mehrfachbeschäftigter
        /// </summary>
        /// <remarks>
        /// Kennzeichen Mehrfachbeschäftigter, Länge 1, Kannfeld
        /// </remarks>
        public bool? AKENNZMF { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums, für den die Meldung gelten soll (Beschäftigungsbeginn oder Beginn des Abrechnungszeitraums)
        /// </summary>
        /// <remarks>Länge 8, Kannfeld</remarks>
        public LocalDate? AZRBGKV { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraumes, für den die Meldung gelten soll (Beschäftigungsende oder Beginn des Abrechnungszeitraums)
        /// </summary>
        /// <remarks>Länge 8, Kannfeld</remarks>
        public LocalDate? AZRENKV { get; set; }

        /// <summary>
        /// Holt oder setzt das einmalig gezahlte Entgelt
        /// </summary>
        /// <remarks>
        /// Einmalig gezahltes Entgelt in Eurocent, Länge 8, Kannfeld
        /// </remarks>
        public int? AEZEG { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Entgelt zur KV/PV in Eurocent
        /// </summary>
        /// <remarks>Länge 8, Kannfeld</remarks>
        public int? ALFDKV { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Entgelt zur RV in Eurocent
        /// </summary>
        /// <remarks>Länge 8, Kannfeld</remarks>
        public int? ALFDRV { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Entgelt zur ALV in Eurocent
        /// </summary>
        /// <remarks>Länge 8, Kannfeld</remarks>
        public int? ALFDAV { get; set; }
    }
}
