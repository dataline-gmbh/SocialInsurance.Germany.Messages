// <copyright file="DSSD01.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.UV
{
    /// <summary>
    /// Datensatz Stammdaten
    /// </summary>
    public class DSSD01 : IDatensatz
    {
        /// <inheritdoc />
        public string KE { get; set; } = "DSSD";

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5, Mussangabe
        /// UVELN = UV elektronischer Lohnnachweis
        /// </remarks>
        public string VF { get; set; } = Info.DSSD.Verfahren;

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers des Datensatzes
        /// </summary>
        /// <remarks>
        ///  Betriebsnummer des Erstellers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        public string BBNREP { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des Datensatzes Stammdaten
        /// </summary>
        /// <remarks>
        /// Versionsnummer des übermittelten Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public int VERNRSD { get; set; } = 1;

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Dateznsatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Datensatz-ID des übermittelten Datensatzes
        /// </summary>
        /// <remarks>
        /// Länge 32, Mussangabe
        /// </remarks>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt die Vorgangs-ID aus der Abfrage der Stammdaten der meldenden Stelle
        /// </summary>
        /// <remarks>
        /// Länge 32, Mussangabe
        /// </remarks>
        public string VOID { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des lohnverantwortenden Beschäftigungsbetriebes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des lohnverantwortenden Beschäftigungsbetriebes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen)
        /// </remarks>
        public string BBNRLB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Abrechnungsstelle, z. B. Steuerberater, Länge 15, Pflichtangabe, soweit bekannt
        /// 8 Stellen linksbündig mit nachfolgenden Leerzeichen
        /// </remarks>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt die laufende Nummer
        /// </summary>
        /// <remarks>
        /// Zusätzlicher Zähler für mehrfach vorkommende meldende / abrechnende Stellen.
        /// Länge 3, Mussangabe
        /// </remarks>
        public int LFDNR { get; set; }

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
        /// Holt oder setzt die Gültigkeit der Mitgliedsnummer
        /// </summary>
        public LocalDate MNRGVON { get; set; }

        /// <summary>
        /// Holt oder setzt die Gültigkeit der Mitgliedsnummer
        /// </summary>
        public LocalDate MNRGBIS { get; set; }

        /// <summary>
        /// Holt oder setzt das Jahr, für welches der (Teil-)Lohnnachweis angekündigt wird
        /// </summary>
        public int JAHR { get; set; }

        /// <summary>
        /// Holt oder setzt die erste Namenszeile des Unternehmens für Ausfüllhilfen
        /// </summary>
        public string UVNAME1 { get; set; }

        /// <summary>
        /// Holt oder setzt die zweite Namenszeile des Unternehmens für Ausfüllhilfen
        /// </summary>
        public string UVNAME2 { get; set; }

        /// <summary>
        /// Holt oder setzt die dritte Namenszeile des Unternehmens für Ausfüllhilfen
        /// </summary>
        public string UVNAME3 { get; set; }

        /// <summary>
        /// Holt oder setzt die vierte Namenszeile des Unternehmens für Ausfüllhilfen
        /// </summary>
        public string UVNAME4 { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort des Unternehmens für Ausfüllhilfen
        /// </summary>
        public string UVORT { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsmassstab
        /// </summary>
        public Beitragsmassstab BEITRAG { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten Gefahrtarifstellen
        /// </summary>
        public int ANZGTST
        {
            get { return GTST?.Count ?? 0; }

            // ReSharper disable once ValueParameterNotUsed
            // ReSharper disable once UnusedMember.Local
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Liste der Gefahrentarifstellen
        /// </summary>
        public IList<Gefahrentarifstelle> GTST { get; set; }

        /// <inheritdoc />
        public IEnumerable<IDatenbaustein> Datenbausteine { get; } = new IDatenbaustein[0];

        /// <inheritdoc />
        IList<DBFE> IDatensatz.DBFE { get; } = new List<DBFE>();

        /// <summary>
        /// Informationen über eine Gefahrentarifstelle
        /// </summary>
        public class Gefahrentarifstelle
        {
            /// <summary>
            /// Holt oder setzt die Betriebsnummer des UV-Trägers, dessen Gefahrtarif angewendet wird
            /// </summary>
            public string BBNRGT { get; set; }

            /// <summary>
            /// Holt oder setzt die Nummer der Gefahrtarifstelle
            /// </summary>
            public string GTST { get; set; }

            /// <summary>
            /// Holt oder setzt den Namen der Gefahrtarifstelle
            /// </summary>
            public string GTSTNAME { get; set; }

            /// <summary>
            /// Holt oder setzt die Gültigkeit der Gefahrtarifstelle
            /// </summary>
            public LocalDate GTSTVON { get; set; }

            /// <summary>
            /// Holt oder setzt die Gültigkeit der Gefahrtarifstelle
            /// </summary>
            public LocalDate GTSTBIS { get; set; }
        }
    }
}
