// <copyright file="DSRA02.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos.AAG
{
    /// <summary>
    /// DSRA-Datensatz Version 2
    /// </summary>
    public class DSRA02 : IDatensatz
    {
        private bool? _hatDbra;

        private bool? _hatDbap;

        private bool? _hatDbna;

        private bool? _fekz;

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt
        /// </remarks>
        public string KE { get; set; } = "DSRA";

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5, Mussangabe
        /// DEUEV = DEÜV- Meldeverfahren
        /// </remarks>
        public string VF { get; set; } = Info.DSRA.Verfahren;

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers des Datensatzes
        /// </summary>
        /// <remarks>
        ///  Betriebsnummer des Erstellers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        [Obsolete("Bitte verwenden Sie statt dessen ABSN")]
        public string BBNRAB { get => ABSN; set => ABSN = value; }

        /// <summary>
        /// Holt oder setzt die Absendernummer der Datei
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>Betriebsnummer des Absenders der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        ///     <item>Absendernummer gemäß § 18n Abs. 2 SGB IV (A + 7 Ziffern linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        /// </list>
        /// </remarks>
        public string ABSN { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        [Obsolete("Bitte verwenden Sie statt dessen EPNR")]
        public string BBNREP { get => EPNR; set => EPNR = value; }

        /// <summary>
        /// Holt oder setzt die Absendernummer des Empfängers der Datei
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>Betriebsnummer des Empfängers der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        ///     <item>Absendernummer gemäß § 18n Abs. 2 SGB IV (A + 7 Ziffern linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        /// </list>
        /// </remarks>
        public string EPNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des übermittelten Datensatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des übermittelten Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public int VERNR { get; set; } = 2;

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Dateznsatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennzeichnung für fehlerhafte Datensätze
        /// </summary>
        /// <remarks>
        /// Kennzeichnung für fehlerhafte Datensätze, Länge 1, 0 = Datensatz fehlerfrei 1 = Datensatz fehlerhaft, Mussangabe
        /// </remarks>
        public bool FEKZ
        {
            get => _fekz ?? (DBFE != null && DBFE.Count != 0);
            set => _fekz = value;
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
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Versicherungsnummer in der Form: bbttmmjjassp, Länge 12, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string VSNR { get; set; }

        /// <summary>
        /// Holt oder setzt das der Krankenkasse zur Verfügung stehende Feld
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht der Krankenkasse zur Verfügung, Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string AZKK { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Beschäftigungsbetriebes
        /// </summary>
        /// <remarks>
        /// Entspricht der Betriebsnummer aus dem Feld BBNR-VU des DSER der Anmeldung oder der des
        /// Antrags des Arbeitgebers.
        /// </remarks>
        public string BBNRAG { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen (<code>AZ-VU</code>) des Arbeitgebers.
        /// </summary>
        /// <remarks>
        /// Sofern der Arbeitgeber in einem Antrag im DSER im Feld Aktenzeichen-Verursacher (<code>AZ-VU</code>) ein Aktenzeichen,
        /// bzw. eine Personalnummer des/der Beschäftigten angegeben hat, ist diese hier zurück zu melden.
        /// </remarks>
        public string AZAG { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle (z.B. Steuerberater)
        /// </summary>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Abgabe
        /// </summary>
        /// <remarks>
        /// 01 = Mitteilung über einen abweichenden Erstattungsbetrag bei Arbeitsunfähigkeit
        /// 02 = Mitteilung über einen abweichenden Erstattungsbetrag bei Beschäftigungsverbot nach dem MuSchG
        /// 03 = Mitteilung über einen abweichenden Erstattungsbetrag bei Mutterschaft
        /// </remarks>
        public int GD { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob dies die Stornierung einer bereits abgegebenen Meldung ist.
        /// </summary>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt die eindeutige Kennzeichnung des Datensatzes durch den Ersteller
        /// </summary>
        /// <remarks>
        /// Muss-Feld (wird aber als 'kann'-Feld behandelt), Länge 32
        /// </remarks>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein <code>DBRA</code> vorhanden ist
        /// </summary>
        public bool MMRM
        {
            get => _hatDbra ?? DBRA != null;
            set => _hatDbra = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein <code>DBAP</code> vorhanden ist
        /// </summary>
        public bool MMAP
        {
            get => _hatDbap ?? DBAP != null;
            set => _hatDbap = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Name vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBNA, Länge 1, Mussangabe
        /// Name vorhanden: J = Ja
        /// </remarks>
        public bool MMNA
        {
            get => _hatDbna ?? DBNA != null;
            set => _hatDbna = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Rückmeldung AAG vorhanden ist
        /// </summary>
        public DBRA02 DBRA
        {
            get => ListeDBRA?.SingleOrDefault();
            set
            {
                ListeDBRA = ListeDBRA.Set(value);
                _hatDbra = null;
            }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Ansprechpartner vorhanden ist
        /// </summary>
        public DBAP01 DBAP
        {
            get => ListeDBAP?.SingleOrDefault();
            set
            {
                ListeDBAP = ListeDBAP.Set(value);
                _hatDbap = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Name
        /// </summary>
        public DBNA DBNA
        {
            get => ListeDBNA?.SingleOrDefault();
            set
            {
                ListeDBNA = ListeDBNA.Set(value);
                _hatDbna = null;
            }
        }

        /// <summary>
        /// Holt oder setzt eine Liste von Fehlern
        /// </summary>
        public IList<DBFE> DBFE { get; set; }

        /// <summary>
        /// Holt die Datenbausteine eines Datensatzes
        /// </summary>
        public IEnumerable<IDatenbaustein> Datenbausteine
        {
            get
            {
                foreach (var datenbaustein in ListExtensions.Enumerate(ListeDBRA, ListeDBAP, ListeDBNA, DBFE))
                    yield return datenbaustein;
            }
        }

        private IList<DBRA02> ListeDBRA { get; set; }

        private IList<DBAP01> ListeDBAP { get; set; }

        private IList<DBNA> ListeDBNA { get; set; }
    }
}
