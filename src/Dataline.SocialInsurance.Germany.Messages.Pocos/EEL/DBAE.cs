// <copyright file="DBAE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Zusatzdaten für die Berechnung des Übergangsgeldes bei Leistungen zur Teilhabe
    /// </summary>
    public class DBAE : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBAE"/>-Objekt.
        /// </summary>
        public DBAE()
        {
            KE = "DBAE";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das monatliche Bruttoarbeitsentgelt während des Bezugs von Entgeltersatzleistungen.
        /// (6 Vor-, 2 Nachkommastellen.)
        /// </summary>
        public int WAEHREELBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt, bis wann das Arbeitsentgelt gezahlt wird.
        /// </summary>
        /// <value>Ein Datum, <see langword="null"/> (Grundstellung) oder <c>99999999</c> für "Fortlaufend".</value>
        public LocalDate? DATUMAEBIS { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des letzten Abrechnungszeitraums vor Beginn der AU/med. Leist./LT.
        /// </summary>
        public LocalDate EAZBEGINN1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des letzten Abrechnungszeitraums vor Beginn der AU/med. Leist./LT.
        /// </summary>
        public LocalDate EAZENDE1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Bruttoarbeitsentgelt im Zeitraum 1.
        /// </summary>
        public int BRUTTO1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Nettoarbeitsentgelt im Zeitraum 1.
        /// </summary>
        public int NETTO1 { get; set; }

        /// <summary>
        /// Holt oder setzt das beitragsfrei umgewandelte laufende Arbeitsentgelt der letzten 12 Monate.
        /// (2 Nachkommastellen.)
        /// </summary>
        /// <remarks>
        /// Bei Seeleuten, bei denen sich die Beiträge nach der Durchschnittsheuer richten, ist nur die Grundstellung (0) zulässig.
        /// </remarks>
        public int UMGEWAE { get; set; }

        /// <summary>
        /// Holt oder setzt die Entgeltart.
        /// </summary>
        /// <value>1 = Stundenlohn, 2 = festes Monatsentgelt, 3 = Sonstiges (Akkord-/Stücklohn, etc)</value>
        public int ENTGART { get; set; }

        /// <summary>
        /// Holt oder setzt das vereinbarte Bruttoarbeitsentgelt.
        /// (2 Nachkommastellen.)
        /// </summary>
        public int BRUTTOAE { get; set; }

        /// <summary>
        /// Holt oder setzt das Nettoentgelt aus dem vereinbarten Bruttoarbeitsentgelt.
        /// (2 Nachkommastellen.)
        /// </summary>
        public int NETTOAE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums 2.
        /// </summary>
        public LocalDate? EAZBEGINN2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums 2.
        /// </summary>
        public LocalDate? EAZENDE2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Bruttoentgelt im Zeitraum 2.
        /// </summary>
        public int BRUTTO2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Nettoentgelt im Zeitraum 2.
        /// </summary>
        public int NETTO2 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums 3.
        /// </summary>
        public LocalDate? EAZBEGINN3 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums 3.
        /// </summary>
        public LocalDate? EAZENDE3 { get; set; }

        /// <summary>
        /// Holt oder setzt das Bruttoentgelt im Zeitraum 3.
        /// </summary>
        public int BRUTTO3 { get; set; }

        /// <summary>
        /// Holt oder setzt das Nettoentgelt im Zeitraum 3.
        /// </summary>
        public int NETTO3 { get; set; }

        /// <summary>
        /// Holt oder setzt den beitragspflichtigen Teil der Einmalzahlungen der letzten 12 Monate
        /// vor Beginn der AU/med. Leist./LT in der KV.
        /// </summary>
        /// <remarks>
        /// Bei Seeleuten, bei denen sich die Beiträge nach der Durchschnittsheuer richten, ist nur die Grundstellung (0) zulässig.
        /// </remarks>
        public int EZKV { get; set; }

        /// <summary>
        /// Holt oder setzt den beitragspflichtigen Teil der Einmalzahlungen der letzten 12 Monate
        /// vor Beginn der AU/med. Leist./LT in der RV/knappschaftl. RV.
        /// </summary>
        /// <remarks>
        /// Bei Seeleuten, bei denen sich die Beiträge nach der Durchschnittsheuer richten, ist nur die Grundstellung (0) zulässig.
        /// </remarks>
        public int EZRV { get; set; }

        /// <summary>
        /// Holt oder setzt den beitragspflichtigen Teil der Einmalzahlungen der letzten 12 Monate
        /// vor Beginn der AU/med. Leist./LT in der ALV.
        /// </summary>
        /// <remarks>
        /// Bei Seeleuten, bei denen sich die Beiträge nach der Durchschnittsheuer richten, ist nur die Grundstellung (0) zulässig.
        /// </remarks>
        public int EZALV { get; set; }
    }
}
