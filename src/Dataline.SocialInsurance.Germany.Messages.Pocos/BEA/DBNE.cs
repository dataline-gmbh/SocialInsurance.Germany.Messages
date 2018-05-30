// <copyright file="DBNE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein BEA Grunddaten Nebeneinkommen
    /// </summary>
    public class DBNE : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBNE";

        /// <summary>
        /// Ende des Arbeitsverhältnisses am (d.h. "Kündigung zum" oder
        /// "Ende des befristeten Arbeitsverhältnisses am")
        /// </summary>
        public LocalDate? AVEND { get; set; }

        /// <summary>
        /// Anfangsdatum des Zeitraums innerhalb des Meldemonats, für den Entgelt gemeldet wird.
        /// </summary>
        /// <remarks>I. d. R. der 1. des Monats.</remarks>
        public LocalDate MONATBEG { get; set; }

        /// <summary>
        /// Enddatum des Zeitraums innerhalb des Meldemonats, für den Entgelt gemeldet wird.
        /// </summary>
        /// <remarks>I. d. R. der Letzte des Monats.</remarks>
        public LocalDate MONATEND { get; set; }

        /// <summary>
        /// Laufendes SV-Bruttoentgelt, begrenzt auf die BBG der allg. RV
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public long SVBREGLF { get; set; }

        /// <summary>
        /// Einmalig gezahltes SV-Bruttoentgelt
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public long SVBREGE { get; set; }

        /// <summary>
        /// Anfangsdatum des Zeitraums, für den eine Einmalzahlung gewährt wird.
        /// </summary>
        public LocalDate? SVBREGEBEG { get; set; }

        /// <summary>
        /// Enddatum des Zeitraums, für den eine Einmalzahlung gewährt wird.
        /// </summary>
        public LocalDate? SVBREGEEND { get; set; }

        /// <summary>
        /// Laufendes Nettoentgelt.
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public long NETTOLFD { get; set; }

        /// <summary>
        /// Einmalig gezahltes Nettoentgelt.
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public long NETTOEINMAL { get; set; }

        /// <summary>
        /// Vereinbarte Wochenarbeitszeit in Stunden.
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public int AZWOECH { get; set; }

        /// <summary>
        /// Wird für die Tätigkeit gem. Tätigkeitsschlüssel eine Aufwandsentschädigung gezahlt?
        /// </summary>
        public bool TTAUFENT { get; set; }

        /// <summary>
        /// Gibt an, ob das bisherige monatliche Einkommen und die wöchentliche Arbeitszeit künftig konstant bleiben.
        /// </summary>
        public bool BVUNFORT { get; set; }

        /// <summary>
        /// Gibt an, ob das künftige monatl. Einkommen unterschiedlich hoch ist, beträgt aber min. 165 Euro
        /// und weniger als 15 Stunden Arbeitszeit wöchentlich.
        /// </summary>
        public bool BVUNFORTU { get; set; }
    }
}
