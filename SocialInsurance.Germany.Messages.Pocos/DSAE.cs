﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz : DSAE - Meldungen von Entgeltersatzleistungen und Anrechnungszeiten der Leistungsträger an die Rentenversicherung
    /// </summary>
    public class DSAE : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDbaz;

        private bool? _hatDbez;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSAE"/> Klasse.
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt.
        /// </remarks>
        public DSAE()
        {
            KE = "DSME";
            VF = "DEUEV";
            VERNR = 1;
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5,
        /// DEUEV = DEÜV- Meldeverfahren, Mussangabe
        /// </remarks>
        public string VF { get; set; }
        
        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Erstellers des Datensatzes (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers des Datensatzes (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string BBNREP { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des übermittelten Datensatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des übermittelten Datensatzes, 01 - 99, Mussangabe
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
        /// Holt oder setzt die Anzahl der Fehler des Datensatzes
        /// </summary>
        /// <remarks>
        /// Anzahl der Fehler des Datensatzes, Länge 1, Mussangabe
        /// </remarks>
        public int FEAN
        {
            get { return DBFE == null ? 0 : DBFE.Count; }
            private set { }
        }

        /// <summary>
        /// Holt oder setut die Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Versicherungsnummer in der Form: bbttmmjjassp, Länge 12, Mussangabe
        /// </remarks>
        public string VSNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Versicherungsträger, für den die Meldung bestimmt ist
        /// </summary>
        /// <remarks>
        /// Versicherungsträger, für den die Meldung bestimmt ist, Länge 2, Mussangabe
        /// </remarks>
        public string VSTR { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Verursachers des Datensatzers
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Verursachers des Datensatzes (8 Stellen linksbündig mit nachfolgenden Leerzeichen)
        /// </remarks>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Steht dem Verursacher zur Verfügung
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht dem Verursacher zur Verfügung, Länge 20, Mussangabe unter Bedingungen
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld 1
        /// </summary>
        /// <remarks> 
        /// Reservefeld, Länge 58, Mussangabe
        ///  Das Feld ist aus Vereinheitlichungsgründen enthalten und hier auf Grundstellung (Leerzeichen)
        /// </remarks>
        public string RESERVE1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Anrechnungszeiten
        /// </summary>
        /// <remarks>
        /// Merkmal, Datenbaustein DBAZ, Länge 1, Mussangabe
        /// Anrechnungszeiten vorhanden:
        /// N = keine Anrechnungszeiten, J = Anrechnungszeiten vorhanden
        /// </remarks>
        public bool MMAZ
        {
            get { return _hatDbaz ?? Anrechnungszeiten!= null; }
            set { _hatDbaz = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Entgeltersatzleistungszeiten
        /// </summary>
        /// <remarks>
        /// Merkmal, Datenbaustein DBEZ, Länge 1, Mussangabe
        /// Entgeltersatzleistungszeiten vorhanden:
        /// N = keine Entgeltersatzleistungszeiten, J = Entgeltersatzleistungszeiten vorhanden
        /// </remarks>
        public bool MMEZ
        {
            get { return _hatDbez ?? Entgeltersatzleistungszeiten != null; }
            set { _hatDbez = value; }
        }

        /// <summary>
        /// Holt oder setzt das Reservefeld 2
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 8, Mussangabe
        /// Feld nicht belegt (Grundstellung)
        /// </remarks>
        public string RESERVE2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen,aus welchem Verfahren der Bundesagentur für Arbeit die Meldung erstellt wurde
        /// </summary>
        public string KENNZUE { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld 3
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 5, Mussangabe
        /// Feld nicht belegt (Grundstellung)
        /// </remarks>
        public string RESERVE3 { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des
        /// </summary>
        public string VERNRKP { get; set; }

        public DBAZ Anrechnungszeiten
        {
            get
            {
                return ListeDBAZ == null ? null : ListeDBAZ.SingleOrDefault();
            }
            set
            {
                ListeDBAZ = ListeDBAZ.Set(value);
                _hatDbaz = null;
            }
        }

        public DBEZ Entgeltersatzleistungszeiten
        {
            get
            {
                return ListeDBEZ == null ? null : ListeDBEZ.SingleOrDefault();
            }
            set
            {
                ListeDBEZ = ListeDBEZ.Set(value);
                _hatDbez = null;
            }
        }
        
        private IList<DBAZ> ListeDBAZ {get;set;}

        private IList<DBEZ> ListeDBEZ { get; set; }

        public IList<DBFE> DBFE { get; set; }
    }
}
