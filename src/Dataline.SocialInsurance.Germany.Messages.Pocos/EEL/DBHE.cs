// <copyright file="DBHE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Höhe der Entgeltersatzleistung
    /// </summary>
    public class DBHE : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBHE"/>-Objekt.
        /// </summary>
        public DBHE()
        {
            KE = "DBHE";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Zahlung.
        /// </summary>
        public LocalDate ZAHLBEGINN { get; set; }

        /// <summary>
        /// Holt oder setzt die Höhe der täglichen Entgeltersatzleistung brutto.
        /// </summary>
        public int? EELBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt die Höhe der täglichen Entgeltersatzleistung netto.
        /// </summary>
        public int EELNETTO { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Teilzeitraums der nachgewiesenen AU.
        /// </summary>
        public LocalDate? TEILNACHWEISAUBEGINN { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Teilzeitraums der nachgewiesenen AU.
        /// </summary>
        public LocalDate? TEILNACHWEISAUENDE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Aktuelle Arbeitsunfähigkeit.
        /// </summary>
        /// <value>0 = Grundstellung, 1 = anrechenbare Zeit, 2 = keine Abrechnung, 3 = Prüfung der AU, 5 = teilweise Anrechnung</value>
        public int KZAU { get; set; }
    }
}
