// <copyright file="DBVO.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Zusatzdaten für die Berechnung des Übergangsgeldes bei Leistungen zur Teilhabe
    /// </summary>
    public class DBVO : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBVO"/>-Objekt.
        /// </summary>
        public DBVO()
        {
            KE = "DBVO";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund für die Anforderung.
        /// </summary>
        /// <value>1 = Arbeitsunfähigkeit wegen Krankheit, 2 = Teilnahme an einer leistung zur med. Vorsorge/Rehabilitation</value>
        public int GRUNDAV { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Arbeitsunfähigkeit/Maßnahme (beim Arbeitgeber).
        /// </summary>
        public LocalDate AUABAG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Arbeitsunfähigkeit/Maßnahme (beim Sozialversicherungsträger).
        /// </summary>
        /// <value>Ein Datum, oder <see langword="null"/>, wenn sich das Datum nicht von <see cref="AUABAG"/> unterscheidet.</value>
        public LocalDate? AUABSV { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen für die aktuelle Arbeitsunfähigkeit.
        /// </summary>
        /// <value>0 (Grundstellung) oder 4 ("AU-Meldung liegt nicht vor").</value>
        public int KZAKAU { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der zu prüfenden Arbeitsunfähigkeiten.
        /// </summary>
        public int ANZAHLAU { get; set; }

        /// <summary>
        /// Holt oder setzt eine Liste der Arbeitsunfähigkeiten.
        /// </summary>
        public IList<DBVO_AU> AU { get; set; }

        /// <summary>
        /// Teildaten Vorherige Arbeitsunfähigkeit
        /// </summary>
        public class DBVO_AU
        {
            /// <summary>
            /// Holt oder setzt den Beginn der vorherigen Arbeitsunfähigkeit.
            /// </summary>
            public LocalDate? BEGINNAU { get; set; }

            /// <summary>
            /// Holt oder setzt das Ende der vorherigen Arbeitsunfähigkeit.
            /// </summary>
            public LocalDate? ENDEAU { get; set; }

            /// <summary>
            /// Holt oder setzt das Kennzeichen Arbeitsunfähigkeit.
            /// </summary>
            /// <value>0 = Grundstellung, 1 = liegt vor, 2 = liegt teilweise vor, 4 = liegt nicht vor</value>
            public int KZNACHWEIS { get; set; }

            /// <summary>
            /// Holt oder setzt den Beginn des Teilzeitraums der nachgewiesenen Arbeitsunfähigkeit.
            /// </summary>
            public LocalDate? TEILNACHWEISAUBEGINN { get; set; }

            /// <summary>
            /// Holt oder setzt das Ende des Teilzeitraums der nachgewiesenen Arbeitsunfähigkeit.
            /// </summary>
            public LocalDate? TEILNACHWEISAUENDE { get; set; }

            /// <summary>
            /// Holt oder setzt das Kennzeichen Aktuelle Arbeitsunfähigkeit.
            /// </summary>
            /// <value>0 = Grundstellung, 1 = anrechenbare Zeit, 2 = keine Anrechnung, 3 = Prüfung der AU, 5 = teilw. Anrechnung</value>
            public int KZAU { get; set; }

            /// <summary>
            /// Holt oder setzt den Beginn des teilweise anrechenbaren Zeitraums der vorherigen Arbeitsunfähigkeit.
            /// </summary>
            public LocalDate? TEILANRAUBEGINN { get; set; }

            /// <summary>
            /// Holt oder setzt das Ende des teilweise anrechenbaren Zeitraums der vorherigen Arbeitsunfähigkeit.
            /// </summary>
            public LocalDate? TEILANRAUENDE { get; set; }
        }
    }
}
