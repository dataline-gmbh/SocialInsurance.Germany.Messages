// <copyright file="BasisDatensatzBEA.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Basisklasse für BEA-Datensätze
    /// </summary>
    public abstract class BasisDatensatzBEA : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDbna;
        private bool? _hatDban;
        private bool? _hatDbag;
        private bool? _hatDbab;

        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; }

        /// <summary>
        /// Versionsnummer
        /// </summary>
        public int VERNR { get; set; } = 3;

        /// <summary>
        /// Verfahrensmerkmal
        /// </summary>
        public string VF { get; set; } = "ALG";

        /// <summary>
        /// Betriebsnummer des Absenders
        /// </summary>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Erstellungsdatum
        /// </summary>
        public LocalDate ED { get; set; }

        /// <summary>
        /// Fehlerkennzeichen
        /// </summary>
        public FehlerKennzeichen FEKZ
        {
            get => _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft);
            set => _fekz = value;
        }

        /// <summary>
        /// Anzahl Fehlre
        /// </summary>
        public int FEAN
        {
            get { return DBFE?.Count ?? 0; }
            private set { }
        }

        /// <summary>
        /// Versicherungsnummer
        /// </summary>
        public string VSNR { get; set; }

        /// <summary>
        /// Betriebsnummer des Verursachers
        /// </summary>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Aktenzeichen des Verursachers
        /// </summary>
        public string AZVU { get; set; }

        /// <summary>
        /// Betriebsnummer der Abrechnungsstelle
        /// </summary>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Datensatz-ID
        /// </summary>
        public string DSID { get; set; }

        /// <summary>
        /// Beginn des Arbeitsverhältnisses
        /// </summary>
        public LocalDate AVBEG { get; set; }

        /// <summary>
        /// Holt oder setzt, ob der Baustein Name vorhanden ist.
        /// </summary>
        public bool MMNA
        {
            get => _hatDbna ?? DBNA != null;
            set => _hatDbna = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein Anschrift vorhanden ist.
        /// </summary>
        public bool MMAN
        {
            get => _hatDban ?? DBAN != null;
            set => _hatDban = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein Arbeitgeber vorhanden ist.
        /// </summary>
        public bool MMAG
        {
            get => _hatDbag ?? DBAG != null;
            set => _hatDbag = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein Abweichende Anschrift vorhanden ist.
        /// </summary>
        public bool MMAB
        {
            get => _hatDbab ?? DBAB != null;
            set => _hatDbab = value;
        }

        /// <summary>
        /// Datenbaustein Name
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
        /// Datenbaustein Anschrift
        /// </summary>
        public DBAN DBAN
        {
            get => ListeDBAN?.SingleOrDefault();
            set
            {
                ListeDBAN = ListeDBAN.Set(value);
                _hatDban = null;
            }
        }

        /// <summary>
        /// Datenbaustein Arbeitgeber
        /// </summary>
        public DBAG DBAG
        {
            get => ListeDBAG?.SingleOrDefault();
            set
            {
                ListeDBAG = ListeDBAG.Set(value);
                _hatDbag = null;
            }
        }

        /// <summary>
        /// Datenbaustein Abweichende Anschrift
        /// </summary>
        public DBAB DBAB
        {
            get => ListeDBAB?.SingleOrDefault();
            set
            {
                ListeDBAB = ListeDBAB.Set(value);
                _hatDbab = null;
            }
        }

        /// <summary>
        /// Datenbausteine Fehler
        /// </summary>
        public IList<DBFE> DBFE { get; set; }

        /// <summary>
        /// Eine Auflistung aller Datenbausteine in diesem Datensatz.
        /// </summary>
        public virtual IEnumerable<IDatenbaustein> Datenbausteine
        {
            get
            {
                foreach (var datenbaustein in ListExtensions.Enumerate(ListeDBNA, ListeDBAN, ListeDBAG, ListeDBAB/*, DBFE*/))
                    yield return datenbaustein;
            }
        }

        private IList<DBNA> ListeDBNA { get; set; }

        private IList<DBAN> ListeDBAN { get; set; }

        private IList<DBAG> ListeDBAG { get; set; }

        private IList<DBAB> ListeDBAB { get; set; }
    }
}
