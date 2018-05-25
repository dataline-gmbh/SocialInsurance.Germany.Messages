// <copyright file="DSMK.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.KSK
{
    /// <summary>
    /// Datensatz Meldungen der KSK
    /// </summary>
    public class DSMK : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDBMK;
        private bool? _hatDBNA;
        private bool? _hatDBAN;
        private bool? _hatDBRU;

        /// <summary>
        /// Kennung
        /// </summary>
        /// <value>Muss DSMK sein.</value>
        public string KE { get; set; } = "DSMK";

        /// <summary>
        /// Verfahren
        /// </summary>
        /// <value>Muss MVKSK sein.</value>
        public string VF { get; set; } = "MVKSK";

        /// <summary>
        /// Betriebsnummer des Absenders
        /// </summary>
        /// <value>8 Stellen</value>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <value>8 Stellen</value>
        public string BBNREP { get; set; }

        /// <summary>
        /// Versionsnummer des Datensatzes
        /// </summary>
        /// <value>01-99</value>
        public int VERNR { get; set; }

        /// <summary>
        /// Zeitpunkt der Erstellung des Datensatzes.
        /// </summary>
        public LocalDate ED { get; set; }

        /// <summary>
        /// Kennzeichnung für fehlerhafte Datensätze
        /// </summary>
        public FehlerKennzeichen FEKZ
        {
            get => _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft);
            set => _fekz = value;
        }

        /// <summary>
        /// Anzahl der Fehler des Datensatzes
        /// </summary>
        public int FEAN
        {
            get { return DBFE?.Count ?? 0; }
            private set { }
        }

        /// <summary>
        /// Rentenversicherungsnummer
        /// </summary>
        /// <value>12 Stellen</value>
        public string VSNR { get; set; }

        /// <summary>
        /// Geburtsdatum des Versicherten
        /// </summary>
        public LocalDate GEBDA { get; set; }

        /// <summary>
        /// Betriebsnummer des Verursachers des Datensatzes
        /// </summary>
        /// <remarks>Bei der Datenübermittlung zwischen KSK und Krankenkasse ist die BNR der KSK anzugeben.</remarks>
        /// <value>8 Stellen</value>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Grund der Abgabe gem. Anlage 2
        /// </summary>
        public Abgabegrund GD { get; set; }

        /// <summary>
        /// Identifikationsnummer des Datensatzes
        /// </summary>
        /// <value>20 Zeichen, optional</value>
        public string DSID { get; set; }

        /// <summary>
        /// Betriebsnummer der für den Versicherten zuständigen Krankenkasse
        /// </summary>
        /// <value>8 Stellen</value>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Dieses Feld steht der Krankenkasse zur Verfügung.
        /// </summary>
        /// <value>20 Stellen.</value>
        public string AZKK { get; set; }

        /// <summary>
        /// Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <value>8 Stellen</value>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Baustein DBMK vorhanden?
        /// </summary>
        /// <see cref="DBMK"/>
        public bool MMDBMK
        {
            get => _hatDBMK ?? DBMK != null;
            set => _hatDBMK = value;
        }

        /// <summary>
        /// Baustein DBNA vorhanden?
        /// </summary>
        /// <see cref="DBNA" />
        public bool MMDBNA
        {
            get => _hatDBNA ?? DBNA != null;
            set => _hatDBNA = value;
        }

        /// <summary>
        /// Baustein DBAN vorhanden?
        /// </summary>
        /// <see cref="DBAN"/>
        public bool MMDBAN
        {
            get => _hatDBAN ?? DBAN != null;
            set => _hatDBAN = value;
        }

        /// <summary>
        /// Baustein DBRU vorhanden?
        /// </summary>
        /// <see cref="DBRU"/>
        public bool MMDBRU
        {
            get => _hatDBRU ?? DBRU != null;
            set => _hatDBRU = value;
        }

        /// <summary>
        /// Baustein DBMK (Meldungen KSK)
        /// </summary>
        public DBMK DBMK
        {
            get => ListeDBMK?.SingleOrDefault();
            set
            {
                ListeDBMK = ListeDBMK.Set(value);
                _hatDBMK = null;
            }
        }

        /// <summary>
        /// Baustein DBNA (Name)
        /// </summary>
        public DBNA DBNA
        {
            get => ListeDBNA?.SingleOrDefault();
            set
            {
                ListeDBNA = ListeDBNA.Set(value);
                _hatDBNA = null;
            }
        }

        /// <summary>
        /// Baustein DBAN (Anschrift)
        /// </summary>
        public DBAN DBAN
        {
            get => ListeDBAN?.SingleOrDefault();
            set
            {
                ListeDBAN = ListeDBAN.Set(value);
                _hatDBAN = null;
            }
        }

        /// <summary>
        /// Baustein DBRU (Meldung Ruhensanordnung)
        /// </summary>
        public DBRU DBRU
        {
            get => ListeDBRU?.SingleOrDefault();
            set
            {
                ListeDBRU = ListeDBRU.Set(value);
                _hatDBRU = null;
            }
        }

        /// <summary>
        /// Liste der Fehlerbausteine
        /// </summary>
        public IList<DBFE> DBFE { get; set; }

        /// <summary>
        /// Eine Auflistung aller Datenbausteine in diesem Datensatz.
        /// </summary>
        public IEnumerable<IDatenbaustein> Datenbausteine
        {
            get
            {
                foreach (var datenbaustein in ListExtensions.Enumerate(ListeDBMK, ListeDBNA, ListeDBAN, ListeDBRU, DBFE))
                    yield return datenbaustein;
            }
        }

        private IList<DBMK> ListeDBMK { get; set; }

        private IList<DBNA> ListeDBNA { get; set; }

        private IList<DBAN> ListeDBAN { get; set; }

        private IList<DBRU> ListeDBRU { get; set; }
    }
}
