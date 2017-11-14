﻿// <copyright file="DBUV02.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBUV - Unfallversicherung
    /// </summary>
    public class DBUV02 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBUV02"/> Klasse
        /// </summary>
        public DBUV02()
        {
            KE = "DBUV";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten UV-Daten
        /// </summary>
        /// <remarks>
        /// Anzahl angehängter UV-Daten(maximal 9), Länge 1, Mussangabe
        /// </remarks>
        public int ANUV
        {
            get { return UV == null ? 0 : UV.Count; }
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Liste der sich wiederholenden UV-Daten
        /// </summary>
        public IList<DBUV_UV> UV { get; set; }

        /// <summary>
        /// sich wiederholende Werte des DBUV, wiederholen sich entsprechend der Anzahl im Feld ZAEHLER von ANUV
        /// </summary>
        public class DBUV_UV
        {
            /// <summary>
            /// Holt oder setzt den Grund bei Abgabe von UV-Daten
            /// </summary>
            /// <remarks>
            /// Grund für die Besonderheiten bei der Abgabe der UVDaten, Länge 3, Mussangabe
            /// Grundstellung (Leerzeichen) = ohne Besonderheiten
            /// A07 = Meldungen für Arbeitnehmer der UV-Träger
            /// A08 = Unternehmen ist Mitglied bei einer landwirtschaftlichen Berufsgenossenschaft
            /// A09 = Beitrag zur Unfallversicherung wird nicht nach dem Arbeitsentgelt bemessen (wie z.B. dieKopfpauschale)
            /// B01 = Entsparung von ausschließlich sozialversicherungspflichtigem Wertguthaben
            /// B02 = Keine UV-Pflicht wegen Auslandsbeschäftigung
            /// B03 = Versicherungsfreiheit in der UV gemäß SGB VII
            /// B04 = Erreichen des Höchstjahresarbeitsentgeltes in einer vorangegangenen Entgeltmeldung
            /// B05 = UV-Entgelt wird in einer nachfolgenden Entgeltmeldung oder in einer weiteren Entgeltmeldung mit Abgabegrund 91 gemeldet
            /// B06 = UV-Entgelt wird in einer anderen Gefahrtarifstelle dieser Entgeltmeldung angegeben
            /// B09 = Sonstige Sachverhalte, die kein UV-Entgelt in der Meldung erfordern
            /// C01 = Entsparung von übertragenem Wertguthaben durch die DRV Bund
            /// </remarks>
            public string UVGD { get; set; }

            /// <summary>
            /// Holt oder setzt die Betriebsnummer des zuständigen UV-Trägers
            /// </summary>
            /// <remarks>
            /// Betriebsnummer des zuständigen UV-Trägers, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen)
            /// </remarks>
            public string BBNRUV { get; set; }

            /// <summary>
            /// Holt oder setzt die Mitgliedsnummer des Unternehmens
            /// </summary>
            /// <remarks>
            /// Mitgliedsnummer des Unternehmens beim zuständigen UV-Träger, Länge 20, Mussangabe unter Bedingungen
            /// </remarks>
            public string MNR { get; set; }

            /// <summary>
            /// Holt oder setzt die Betriebsnummer des UV-Trägers, dessen Gefahrtarif angewendet wird
            /// </summary>
            /// <remarks>
            /// Betriebsnummer des UV-Trägers, dessen Gefahrtarif angewendet wird,
            /// Länge 15(8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe unter Bedingungen
            /// </remarks>
            public string BBNRGT { get; set; }

            /// <summary>
            /// Holt oder setzt die Gefahrtarifstelle
            /// </summary>
            /// <remarks>
            /// Gefahrtarifstelle, Länge 8, Mussangabe unter Bedingungen
            /// </remarks>
            public string GTST { get; set; }

            /// <summary>
            /// Holt oder setzt das beitragspflichtige Arbeitsentgelt
            /// </summary>
            /// <remarks>
            /// Beitragspflichtiges Arbeitsentgelt zur Unfallversicherung, Länge 6, Mussangabe
            /// </remarks>
            public int UVEG { get; set; }

            /// <summary>
            /// Holt oder setzt die geleisteten Arbeitsstunden
            /// </summary>
            /// <remarks>
            /// Geleistete Arbeitsstunden, Länge 4, Mussangabe
            /// </remarks>
            public int ARBSTD { get; set; }
        }
    }
}
