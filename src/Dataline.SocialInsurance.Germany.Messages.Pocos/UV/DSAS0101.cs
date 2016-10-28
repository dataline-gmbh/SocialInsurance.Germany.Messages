// <copyright file="DSAS0101.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos.UV
{
    /// <summary>
    /// Datensatz Abfrage Stammdaten
    /// </summary>
    public class DSAS0101 : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDbfu;

        private bool? _hatDbap;

        /// <inheritdoc />
        public string KE { get; set; } = "DSAS";

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5, Mussangabe
        /// UVELN = UV elektronischer Lohnnachweis
        /// </remarks>
        public string VF { get; set; } = Info.DSAS.Verfahren;

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
        /// Holt oder setzt die Versionsnummer des Datensatzes Abfrage Stammdaten
        /// </summary>
        /// <remarks>
        /// Versionsnummer des übermittelten Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public int VERNRAS { get; set; } = 1;

        /// <summary>
        /// Nebenversionsnummer des übermittelten Datensatzes.
        /// </summary>
        /// <remarks>
        /// Nebenversionsnummer des Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public int NEVERNR { get; set; } = 1;

        /// <summary>
        /// Holt oder setzt die Versionsnummer des Kernprüfprogramms
        /// </summary>
        /// <remarks>
        /// Versionsnummer des Kernprüfprogramms mit der der Datensatz geprüft wurde
        /// </remarks>
        public int VERNRDSAS { get; set; }

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Dateznsatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert der angibt, ob der Datenbaustein DBFU - Stammdatenfehler UV-Daten vorhanden ist
        /// </summary>
        public bool MMFU
        {
            get { return _hatDbfu ?? DBFU != null; }
            set { _hatDbfu = value; }
        }

        /// <summary>
        /// Holt oder setzt die Kennzeichnung für fehlerhafte Datensätze
        /// </summary>
        /// <remarks>
        /// Kennzeichnung für fehlerhafte Datensätze, Länge 1, 0 = Datensatz fehlerfrei 1 = Datensatz fehlerhaft, Mussangabe
        /// </remarks>
        public FehlerKennzeichen FEKZ
        {
            get { return _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft); }
            set { _fekz = value; }
        }

        /// <summary>
        /// Holt die Anzahl der Fehler des Datensatzes
        /// </summary>
        /// <remarks>
        /// Anzahl der Fehler des Datensatzes, Länge 1, Mussangabe
        /// </remarks>
        public int FEAN
        {
            get { return DBFE?.Count ?? 0; }

            // ReSharper disable once ValueParameterNotUsed
            // ReSharper disable once UnusedMember.Local
            private set { }
        }

        /// <summary>
        /// Holt oder setzt den Produkt-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird.
        /// </summary>
        /// <remarks>
        /// Sie wird von der ITSG, eindeutig für jedes systemuntersuchte Programm, vergeben.
        /// Länge 7, Mussangabe
        /// </remarks>
        public string PRODID { get; set; }

        /// <summary>
        /// Holt oder setzt den Modifikations-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird.
        /// </summary>
        /// <remarks>
        /// Sie wird von der ITSG, eindeutig für jedes systemuntersuchte Programm, vergeben.
        /// Länge 8, Mussangabe
        /// </remarks>
        public string MODID { get; set; }

        /// <summary>
        /// Holt oder setzt die Datensatz-ID des übermittelten Datensatzes
        /// </summary>
        /// <remarks>
        /// Länge 32, Mussangabe
        /// </remarks>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt die Vorgangs-ID für den (Teil-) Lohnnachweis aus dem Abruf der Stammdaten der meldenden Stelle
        /// </summary>
        /// <remarks>
        /// Länge 32, Mussangabe
        /// </remarks>
        public string VOID { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob dies die Stornierung einer bereits abgegebenen Meldung ist.
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt eine Kennzeichnung, ob die Meldung über eine Ausfüllhilfe oder ein zertifiziertes Lohnabrechnungsprogramm erstellt wurde.
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe, Nur 1 oder 5 zulässig
        /// </remarks>
        public Uebermittlungsweg MMUEB { get; set; }

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
        /// Holt oder setzt das persönliche Identifikationskennzeichen zur Mitgliedsnummer
        /// </summary>
        /// <remarks>
        /// Länge 5, Mussangabe, nur Werte größer als 9999
        /// </remarks>
        public int PIN { get; set; }

        /// <summary>
        /// Holt oder setzt die laufende Nummer
        /// </summary>
        /// <remarks>
        /// Zusätzlicher Zähler für mehrfach vorkommende meldende / abrechnende Stellen.
        /// Länge 3, Mussangabe
        /// </remarks>
        public int LFDNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Jahr, für welches der (Teil-) Lohnnachweis gemeldet wird.
        /// </summary>
        /// <remarks>
        /// Länge 4, Mussangabe
        /// </remarks>
        public int JAHR { get; set; }

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
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein <code>DBAP</code> vorhanden ist
        /// </summary>
        public bool MMDBAP
        {
            get { return _hatDbap ?? DBAP != null; }
            set { _hatDbap = value; }
        }

        /// <summary>
        /// Holt oder setzt den Grund der Abfrage der Stammdaten gemäß Anlage 1
        /// </summary>
        /// <remarks>
        /// Länge 4, Mussangabe, nur der Wert <code>UV01</code> ist zulässig
        /// </remarks>
        public string AFGRUND { get; set; } = "UV10";

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Stammdatenfehler UV-Daten vorhanden
        /// </summary>
        public DBFU DBFU
        {
            get
            {
                return ListeDBFU?.SingleOrDefault();
            }
            set
            {
                ListeDBFU = ListeDBFU.Set(value);
                _hatDbfu = null;
            }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Ansprechpartner vorhanden ist
        /// </summary>
        public DBAP01 DBAP
        {
            get
            {
                return ListeDBAP?.SingleOrDefault();
            }
            set
            {
                ListeDBAP = ListeDBAP.Set(value);
                _hatDbap = null;
            }
        }

        /// <inheritdoc />
        public IList<DBFE> DBFE { get; set; }

        /// <inheritdoc />
        public IEnumerable<IDatenbaustein> Datenbausteine => ListExtensions.Enumerate(ListeDBAP, ListeDBFU, DBFE);

        private IList<DBFU> ListeDBFU { get; set; }

        private IList<DBAP01> ListeDBAP { get; set; }
    }
}
