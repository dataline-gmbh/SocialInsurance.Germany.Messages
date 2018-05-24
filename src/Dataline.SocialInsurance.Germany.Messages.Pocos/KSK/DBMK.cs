// <copyright file="DBMK.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.KSK
{
    /// <summary>
    /// Datenbaustein Meldungen KSK
    /// </summary>
    public class DBMK : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBMK";

        /// <summary>
        /// Kennzeichen, ob dies eine Stornierung einer bereits abgegebenen Meldung ist
        /// </summary>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Voraussichtliches Jahresarbeitseinkommen in Eurocent (ohne Berücksichtigung Mindestbemessungsgrundlage)
        /// </summary>
        public long VOSJAEK { get; set; }

        /// <summary>
        /// Beitragsberechnunggrundlage in Eurocent
        /// </summary>
        public long BERBT { get; set; }

        /// <summary>
        /// Beginn des Zeitraums, für den die Meldung gelten soll
        /// (Beginn des Abrechnungszeitraums)
        /// </summary>
        public LocalDate ZRBG { get; set; }

        /// <summary>
        /// Ende des Zeitraums, für den die Meldung gelten soll
        /// (Ende des Abrechnungszeitraums)
        /// </summary>
        public LocalDate ZREN { get; set; }

        /// <summary>
        /// Anzahl der Tage, für die eine Beitragspflicht zur KV im Abrechnungsmonat besteht.
        /// </summary>
        public int SVTG { get; set; }

        /// <summary>
        /// Kennzeichen über bestehende RV-Pflicht
        /// </summary>
        public bool KZRV { get; set; }

        /// <summary>
        /// Kennzeichen des Rechtskreises in der gesetzl. RV (W = West, O = Ost)
        /// </summary>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Kennzeichen für Mahnungen nach § 16 Abs. 2 Satz 7 KSVG
        /// </summary>
        public bool KZMA { get; set; }
    }
}
