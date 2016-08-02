// <copyright file="DBRA01.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.AAG
{
    /// <summary>
    /// Datenbaustein: DBRA - Rückmeldung AAG
    /// </summary>
    public class DBRA01 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBRA01"/> Klasse
        /// </summary>
        public DBRA01()
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
        /// </remarks>
        public int GAB { get; set; }
    }
}
