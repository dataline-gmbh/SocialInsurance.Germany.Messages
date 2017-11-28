// <copyright file="DSVV01.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSVV - Abfrage einer Versicherungsnummer
    /// </summary>
    public class DSVV01 : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDbna;

        private bool? _hatDbgb;

        private bool? _hatDban;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSVV01"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt
        /// </remarks>
        public DSVV01()
        {
            KE = "DSVV";
            VF = "DEUEV";
            VERNR = 1;
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
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5,  Mussangabe
        /// BVBEI = BV Beitragserhebung
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Absenders des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Absenders des Datensatzes, Länge 8, Mussangabe
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
        /// Betriebsnummer des Empfängers des Datensatzes, Länge 8, Mussangabe
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
        /// Versionsnummer des Datensatzes, Länge 2, Mussangabe
        /// 01 – 99
        /// </remarks>
        public int VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Datensatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, Mussangabe
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
            private set { /* Must be existent, but inaccessible! */ }
        }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Ist bei der Anforderung leer, Länge 12
        /// </remarks>
        public string VSNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Ergebnis der Prüfung bei der DSRV
        /// </summary>
        /// <remarks>
        /// Bei der Anfrage der Versicherungsnummer ist nur die Grundstellung zulässig
        /// </remarks>
        public DSVV01Status KENNZRM { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Verursachers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Verursachers des Datensatzes, Länge 15, Mussangabe
        /// Bei Meldungen zwischen dem Arbeitgeber und der ZSS ist hier
        /// die Betriebsnummer des Beschäftigungsbetriebes anzugeben
        /// </remarks>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Holt oder setzt das dem Verursacher zur Verfügung stehende Feld
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht dem Verursacher zur Verfügung, Länge 20, Kannangabe
        /// Bei Meldungen zwischen dem Arbeitgeber und der ZSS: z. B. Aktenzeichen/Personalnummer des/der Beschäftigten
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Holt oder setzt das dem Verursacher zur Verfügung stehende Feld
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht dem Verursacher zur Verfügung, Länge 32, Mussangabe
        /// Bei Meldungen zwischen dem Arbeitgeber und der ZSS: z. B. Aktenzeichen/Personalnummer des / der Beschäftigten
        /// </remarks>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt den Übermittlungsweg der abgegebenen Meldung
        /// </summary>
        /// <remarks>
        /// Länge 1, Kannangeba, Grundstellung, 1 oder 5
        /// <list type="table">
        ///   <listheader>
        ///     <term>Wert</term>
        ///     <term>Bedeutung</term>
        ///   </listheader>
        ///   <item>
        ///     <term>1</term>
        ///     <term>Meldung aus systemgeprüftem Programm (§ 18 DEÜV)</term>
        ///   </item>
        ///   <item>
        ///     <term>5</term>
        ///     <term>Meldung mittels maschinell erstellter Ausfüllhilfe (§ 18 DEÜV)</term>
        ///   </item>
        /// </list>
        /// </remarks>
        public int? MMUEB { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Name vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBNA, Länge 1, Mussangabe
        /// J = Namensdaten vorhanden
        /// </remarks>
        public bool MMNA
        {
            get { return _hatDbna ?? DBNA != null; }
            set { _hatDbna = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Geburtsangaben vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBGB, Länge 1, Mussangabe
        /// J = Geburtsangaben vorhanden
        /// </remarks>
        public bool MMGB
        {
            get { return _hatDbgb ?? DBGB != null; }
            set { _hatDbgb = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Anschrift vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAN, Länge 1,
        /// J = Anschriftsangaben vorhanden
        /// </remarks>
        public bool MMAN
        {
            get { return _hatDban ?? DBAN != null; }
            set { _hatDban = value; }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBNA</code>
        /// </summary>
        public DBNA DBNA
        {
            get
            {
                return ListeDBNA?.SingleOrDefault();
            }
            set
            {
                ListeDBNA = ListeDBNA.Set(value);
                _hatDbna = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBGB</code>
        /// </summary>
        public DBGB DBGB
        {
            get
            {
                return ListeDBGB?.SingleOrDefault();
            }
            set
            {
                ListeDBGB = ListeDBGB.Set(value);
                _hatDbgb = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBAN</code>
        /// </summary>
        public DBAN DBAN
        {
            get
            {
                return ListeDBAN?.SingleOrDefault();
            }
            set
            {
                ListeDBAN = ListeDBAN.Set(value);
                _hatDban = null;
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
                foreach (var datenbaustein in ListExtensions.Enumerate(ListeDBNA, ListeDBGB, ListeDBAN, DBFE))
                    yield return datenbaustein;
            }
        }

        private IList<DBNA> ListeDBNA { get; set; }

        private IList<DBGB> ListeDBGB { get; set; }

        private IList<DBAN> ListeDBAN { get; set; }
    }
}
