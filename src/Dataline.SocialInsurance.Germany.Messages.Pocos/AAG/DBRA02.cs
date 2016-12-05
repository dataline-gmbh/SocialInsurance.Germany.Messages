// <copyright file="DBRA02.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.AAG
{
    /// <summary>
    /// Datenbaustein: DBRA - Rückmeldung AAG
    /// </summary>
    public class DBRA02 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBRA02"/> Klasse
        /// </summary>
        public DBRA02()
        {
            KE = "DBRA";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

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
        /// Holt oder setzt den beantragten Erstattungsbetrag in der Form EURO/CENT
        /// </summary>
        /// <remarks>
        /// Zulässig ist nur ein Wert größer 0
        /// </remarks>
        public int BEBU { get; set; }

        /// <summary>
        /// Holt oder setzt den festgestellten Erstattungsbetrag in der Form EURO/CENT
        /// </summary>
        /// <remarks>
        /// Zulässig ist nur ein Wert größer 0
        /// </remarks>
        public int FEBU { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Abweichung
        /// </summary>
        /// <remarks>
        /// 01 = Erstattungssatz nicht korrekt
        /// 02 = Erstattungszeitraum abweichend vom Beschäftigungszeitraum
        /// 03 = Erstattung U1 über RV-BBG-OST beantragt und auf RV-BBG-OST reduziert (Satzungsregelung)
        /// 04 = Erstattung U1 über RV-BBG-West beantragt und auf RV-BBG-West reduziert (Satzungsregelung)
        /// 05 = Kürtung wegen des Bezuges einer Entgeltersatzleistung
        /// 06 = Erstattungszeitraum fällt in den Wartezeitraum (28 Tage seit Aufnahme der Beschäftigung)
        /// 07 = Erstattungszeitraum abweichend zum bestehenden EFZ-Anspruch (z.B. Höchstanspruchsdauer überschritten)
        /// 08 = Erstattung für den ersten Tag der AU beantragt, an dem aber noch gearbeitet wurde
        /// 09 = Erstattungszeitraum abweichend zum Mutterschaftsgeldzeitraum
        /// 10 = Mutterschaftsgeld nicht berücksichtigt
        /// 11 = GSV-Beitrag im Erstattungsbetrag nicht pauschal berücksichtigt
        /// 12 = GSV-Beitrag im Erstattungsbetrag nicht in tatsächlicher Höhe berücksichtigt
        /// 13 = Antrag umfasste bereits erstattete Zeiträume
        /// 14 = Sonstiges
        /// 15 = Es konnte keine Teilnahme am Umlageverfahren für den Erstattungszeitraum festgestellt werden
        /// 16 = Es ist keine Versicherungszeit/Mitgliedschaft für den Beschäftigten feststellbar
        /// 17 = Geringfügig Beschäftigter - Zuständigkeit Knappschaft-Bahn-See (§ 2 Abs. 1 AAG)
        /// 18 = Erstattungszeitraum ist verjährt (§ 6 Abs. 1 AAG)
        /// 19 = Beschäftigungsverbot nicht alleiniger Grund für Arbeitsausfall
        /// 20 = GSV - Beiträge bei U1 - Erstattungen nicht erstattungsfähig (Satzungsregelung)
        /// 21 = Erstattungszeitraum fällt vollständig in den Bezugszeitraum einer Entgeltersatzleistung
        /// 22 = Erstattungszeitraum liegt vollständig im Wartezeitraum (28 Tage seit Aufnahme der Beschäftigung)
        /// 23 = Für den Erstattungszeitraum besteht kein EFZ-Anspruch (z. B. Höchstanspruchsdauer überschritten)
        /// 24 = Für den Erstattungszeitraum liegt kein Mutterschaftsgeldzeitraum vor
        /// 25 = Erstattungszeitraum liegt vollständig in einem bereits erstatteten Zeitraum
        /// 26 = Der Antrag enthält Arbeitsentgeltbestandteile, die nicht erstattungsfähig sind
        /// 27 = Für die Person besteht kein Erstattungsanspruch nach dem AAG
        /// 28 = Fehlzeit bestand aufgrund Erkrankung des Kindes
        /// 29 = Versagung wegen fehlender Mitwirkung (§ 4 Abs. 1 AAG)
        /// 30 = Teilnahme am freiwilligen Ausgleichsverfahren nach § 12 AAG
        /// 31 = Beschäftigungsverbot liegt (teilweise) innerhalb einer Schutzfrist nach dem MuSchG
        /// 32 = Es liegt kein Beschäftigungsverbot vor
        /// </remarks>
        public int GAB { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Feststellung
        /// </summary>
        /// <remarks>
        /// Muss, Länge 1
        /// 1 = dem Antrag wurde vollständig entsprochen
        /// 2 = dem Antrag wurde teilweise entsprochen
        /// 3 = dem Antrag konnte nicht entsprochen werden
        /// </remarks>
        public int KENNF { get; set; }

        /// <summary>
        /// Holt oder setzt den abweichenden Beginn des Erstattungszeitraums
        /// </summary>
        /// <remarks>
        /// Abweichender Beginn des Erstattungszeitraums, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate? AEZEITVOM { get; set; }

        /// <summary>
        /// Holt oder setzt das abweichende Ende des Erstattungszeitraums
        /// </summary>
        /// <remarks>
        /// Abweichendes Ende des Erstattungszeitraums, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate? AEZEITBIS { get; set; }
    }
}
