// <copyright file="DBEN.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Entgeltdaten
    /// </summary>
    public class DBEN : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBEN";

        /// <summary>
        /// Holt oder setzt das Anfangsdatum des Zeitraums innerhalb des Meldemonats, für den Entgelt gemeldet wird.
        /// </summary>
        /// <remarks>I. d. R. der 1. des Monats.</remarks>
        public LocalDate MONATBEG { get; set; }

        /// <summary>
        /// Holt oder setzt das Enddatum des Zeitraums innerhalb des Meldemonats, für den Entgelt gemeldet wird.
        /// </summary>
        /// <remarks>I. d. R. der Letzte des Monats.</remarks>
        public LocalDate MONATEND { get; set; }

        /// <summary>
        /// Holt oder setzt, in welchem Rechtskreis das Arbeitsentgelt erzielt wurde, ohne dass es sich um eine Entsendung handelte.
        /// </summary>
        /// <value>W (West) oder O (Ost)</value>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Holt oder setzt das sozialversicherungspflichtige Bruttoarbeitsentgelt.
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public long SVBREGLF { get; set; }

        /// <summary>
        /// Holt oder setzt das einmalig gezahlte Sozialversicherungsbruttoentgelt.
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public long SVBREGE { get; set; }

        /// <summary>
        /// Holt oder setzt das fiktive Bruttoarbeitsentgelt, das ohne Berücksichtigung von Sonderregelungen beitragspflichtig gewesen wäre.
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public long FIBR { get; set; }

        /// <summary>
        /// Anzahl der tatsächlichen Urlaubstage für den Zeitraum der gesamten Bescheinigung.
        /// </summary>
        public int TATSURLTAGE { get; set; }

        /// <summary>
        /// Holt oder setzt das im bescheinigten Bruttoarbeitsentgelt enthaltene Urlaubsentgelt für den Zeitraum der gesamten Bescheinigung.
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public long URLEG { get; set; }

        /// <summary>
        /// Holt oder setzt, wann das Urlaubsentgelt zuletzt gezahlt wurde.
        /// </summary>
        /// <value>1 = bei Urlaubsantritt, 2 = als lfd. Entgeltzuschlag</value>
        public int URLEGGEZ { get; set; }

        /// <summary>
        /// Holt oder setzt, ob das Arbeitsentgelt wegen einer Vereinbarung gem. § 3 Abs. 1 Satz 1 PflegeZG
        /// oder aufgrund von Zeiten nach dem Familienpflegegesetz vermindert wurde.
        /// </summary>
        public bool? MIA { get; set; }

        /// <summary>
        /// Anfangsdatum des Zeitraums innerhalb des Meldemonats, für den eine Minderung des Arbeitsentgelts vorliegt.
        /// </summary>
        public LocalDate? MIABEG { get; set; }

        /// <summary>
        /// Enddatum des Zeitraums innerhalb des Meldemonats, für den eine Minderung des Arbeitsentgelts vorliegt.
        /// </summary>
        public LocalDate? MIAEND { get; set; }
    }
}
