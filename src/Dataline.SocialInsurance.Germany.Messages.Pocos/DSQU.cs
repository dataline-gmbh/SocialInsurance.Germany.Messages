﻿// <copyright file="DSQU.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSQU - Bestätigungsdatensatz DEÜV, KVdR und KVNR
    /// </summary>
    public class DSQU : IDatensatz
    {
        private bool? _hatDbqd;

        private bool? _hatDbqk;

        private bool? _hatDbqv;

        private FehlerKennzeichen? _fekz;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSQU"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren wird die Konstante Kennung gesetzt
        /// </remarks>
        public DSQU()
        {
            KE = "DSQU";
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
        /// Holt oder setzt die Versionnummer des übermittelten Datensatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des übermittelten Datensatzes, 01 - 99, Länge 2, Mussangabe
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
            get { return DBFE == null ? 0 : DBFE.Count; }
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des Kernprüfprogramms
        /// </summary>
        /// <remarks>
        /// Versionsnummer des Kernprüfprogramms, mit der die quittierte Datei verarbeitet wurde, Länge 2, Mussangabe
        /// </remarks>
        public int VERKP { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Quittung-DEÜV vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBQD, Länge 1, Mussangabe
        /// QUITTUNG-DEÜV vorhanden:
        /// J = Quittung-DEÜV ist vorhanden, N = Quittung-DEÜV ist nicht vorhanden
        /// </remarks>
        public bool MMQD
        {
            get { return _hatDbqd ?? DBQD != null; }
            set { _hatDbqd = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein DBQK-Quittung-KVDR vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBQK, Länge 1, Mussangabe
        /// QUITTUNG-KVDR vorhanden:
        /// J = Quittung-KVDR ist vorhanden, N = Quittung-KVDR ist nicht vorhanden
        /// </remarks>
        public bool MMQK
        {
            get { return _hatDbqk ?? DBQK != null; }
            set { _hatDbqk = value; }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein DBQV-Quittung-KVNR vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBQV, Länge 1, Mussangabe
        /// QUITTUNG-KVNR vorhanden:
        /// J = Quittung-KVNR ist vorhanden, N = Quittung-KVNR ist nicht vorhanden
        /// </remarks>
        public bool MMQV
        {
            get { return _hatDbqv ?? DBQV != null; }
            set { _hatDbqv = value; }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Quittung-DEÜV
        /// </summary>
        public DBQD DBQD
        {
            get
            {
                return ListeDBQD == null ? null : ListeDBQD.SingleOrDefault();
            }
            set
            {
                ListeDBQD = ListeDBQD.Set(value);
                _hatDbqd = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für DBQK-Quittung-KVDR
        /// </summary>
        public DBQK DBQK
        {
            get
            {
                return ListeDBQK == null ? null : ListeDBQK.SingleOrDefault();
            }
            set
            {
                ListeDBQK = ListeDBQK.Set(value);
                _hatDbqk = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für DBQV-Quittung-KVNR
        /// </summary>
        public DBQV DBQV
        {
            get
            {
                return ListeDBQV == null ? null : ListeDBQV.SingleOrDefault();
            }
            set
            {
                ListeDBQV = ListeDBQV.Set(value);
                _hatDbqv = null;
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
                foreach (var datenbaustein in ListExtensions.Enumerate(ListeDBQD, ListeDBQK, ListeDBQV, DBFE))
                    yield return datenbaustein;
            }
        }

        private IList<DBQD> ListeDBQD { get; set; }

        private IList<DBQK> ListeDBQK { get; set; }

        private IList<DBQV> ListeDBQV { get; set; }
    }
}
