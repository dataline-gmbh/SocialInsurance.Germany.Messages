// <copyright file="DSAN04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DSAN - Datensatz Stammdaten Arbeitnehmer
    /// </summary>
    public class DSAN04 : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSAN04"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt
        /// </remarks>
        public DSAN04()
        {
            KE = "DSAN";
            VF = "EUBP";
            VERNR = 4;
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5, Mussangabe
        /// EUBP = Elektronisch unterstützte Betriebsprüfung
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Absenders des Datensatzes
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
        public int VERNR { get; set; }

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
        public FehlerKennzeichen FEKZ
        {
            get => _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft);
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
            get => DBFE?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Holt oder setzt das Ordungsmerkmal für den Mandanten/Betrieb/Betriebsteil als Unterscheidung unterhalb einer Betriebsnummer
        /// </summary>
        /// <remarks>
        /// Länge 20, Mussangabe
        /// </remarks>
        public string MANDANT { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen Verursacher (Personalnummer)
        /// </summary>
        /// <remarks>
        /// Länge 20, Mussangabe, wenn Versicherungsnummer leer, sonst Pflichtangabe
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Länge 12, Mussangabe, wenn Aktenzeichen Verursacher leer, sonst Pflichtangabe
        /// </remarks>
        public string VSNR { get; set; }

        /// <summary>
        /// Holt die Anzahl Stammdatensätze
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int ANSTAN => DSANext?.Count ?? 0;

        /// <summary>
        /// Holt oder setzt eine Liste von Stammdatensätzen
        /// </summary>
        public IList<DSANext04> DSANext { get; set; }

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
                foreach (var datenbaustein in ListExtensions.Enumerate(DBFE))
                    yield return datenbaustein;
            }
        }
    }
}
