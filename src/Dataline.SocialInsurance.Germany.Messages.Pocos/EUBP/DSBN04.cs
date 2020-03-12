// <copyright file="DSBN04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DSBN - Datensatz Beitragsnachweis
    /// </summary>
    public class DSBN04 : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSBN04"/> Klasse.
        /// </summary>
        public DSBN04()
        {
            KE = "DSBN";
            VF = "EUBP";
            DBFE = new List<DBFE>();
            VERNR = 4;
        }

        /// <summary>
        /// Holt oder setzt die Kennung des Datenbausteins
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Baustein es sich handelt, Länge 4, Mussangabe
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal, um welche Art von Datenaustausch es sich handelt
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist: BWBNV = Beitragsnachweis der Zahlstellen, Länge 5, Mussangabe
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
        /// Holt oder setzt die Betriebsnummer des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// (BBNRAB) Betriebs-/Zahlestellnummer des Absenders (8 Stellen linksbündig mit nachfolgenden Leerzeichen) oder in Ausnahmefall Absendernummer (8 Stellen linksbündig mit nachfolgenden Leerzeichen. Muss mit A beginnen sonst numerisch Annnnnnn), Länge 15, Mussangabe
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
        /// Holt oder setzt die Betriebsnummer des Empfängers der Datei
        /// </summary>
        /// <remarks>
        /// (BBNREP) Betriebs-/Zahlestellnummer des Empfängers (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string EPNR { get; set; }

        /// <summary>
        /// Holt oder setzt eine Liste von Fehlern
        /// </summary>
        /// <remarks>
        /// Versionsnummer des Vorlaufsatzes 01-99, Länge 2, Mussangabe
        /// </remarks>
        public int VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Erstellung der Datei
        /// </summary>
        /// <remarks>
        /// Datum der Erstellung der Datei, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt das Fehlerkennzeichen
        /// </summary>
        /// <remarks>
        /// Kennzeichnung für fehlerhafte Datensätze
        /// 0 = Datensatz fehlerfrei
        /// 1 = Datensatzfehlerhaft
        /// 2 = unbesetzt
        /// 3 = Hinweis für die Zahlstellen und die Krankenkasse
        /// Länge 1, Mussangabe
        /// </remarks>
        public FehlerKennzeichen FEKZ
        {
            get => _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft);
            set => _fekz = value;
        }

        /// <summary>
        /// Holt oder setzt die Fehleranzahl
        /// </summary>
        /// <remarks>
        /// Anzahl der Fehler des Datensatzes in der Form: n, Länge 1, Mussangabe
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
        /// Holt oder setzt die Betriebsnummer der Einzugsstelle
        /// </summary>
        /// <remarks>
        /// Länge 15, Mussangabe
        /// </remarks>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Holt die Anzahl Beitragsnachweise dieser Krankenkasse
        /// </summary>
        /// <remarks>
        /// Länge 4, Mussangabe
        /// </remarks>
        public int ANBNW
        {
            get => DSBNext?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Holt oder setzt eine Liste von Beitragsnachweisen
        /// </summary>
        public IList<DSBNext04> DSBNext { get; set; }

        /// <summary>
        /// Holt oder setzt eine Auflistung von DBFE-Fehler
        /// </summary>
        /// <remarks>
        /// Es folgen ggf. ein oder mehrere Datenbausteine DBFE-Fehler gemäß den Angaben in dem FEKZ.
        /// Die Anzahl der Fehler-Datenbausteine ergibt sich aus dem Feld FEAN.
        /// </remarks>
        public IList<DBFE> DBFE { get; set; }

        /// <summary>
        /// Holt die Datenbausteine eines Datensatzes
        /// </summary>
        public IEnumerable<IDatenbaustein> Datenbausteine
        {
            get
            {
                if (DBFE != null)
                    return DBFE;
                return Enumerable.Empty<IDatenbaustein>();
            }
        }
    }
}
