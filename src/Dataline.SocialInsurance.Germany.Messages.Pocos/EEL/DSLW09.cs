// <copyright file="DSLW09.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datensatz Leistungswesen (EEL) -- Version 9
    /// </summary>
    public class DSLW09 : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDbna;
        private bool? _hatDban;
        private bool? _hatDbal;
        private bool? _hatDbae;
        private bool? _hatDbza;
        private bool? _hatDbee;
        private bool? _hatDbaw;
        private bool? _hatDbfr;
        private bool? _hatDbun;
        private bool? _hatDbmu;
        private bool? _hatDbvo;
        private bool? _hatDbhe;
        private bool? _hatDbbe;
        private bool? _hatDblt;
        private bool? _hatDbsf;
        private bool? _hatDbtk;
        private bool? _hatDbap;
        private bool? _hatDbid;

        /// <summary>
        /// Erstellt ein neues <see cref="DSLW"/>-Objekt.
        /// </summary>
        public DSLW09()
        {
            KE = "DSLW";
            VF = "LEIST";
            VERNR = 9;
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datensatz es sich handelt</remarks>
        /// <value>Immer "<c>DSLW</c>".</value>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren.
        /// </summary>
        /// <remarks>Verfahren, für das der Datensatz bestimmt ist</remarks>
        /// <value>Immer "<c>LEIST</c>".</value>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Absenders.
        /// </summary>
        public string ABSN { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers.
        /// </summary>
        public string EPNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer.
        /// </summary>
        /// <remarks>Versionsnummer des übermittelten Datensatzes</remarks>
        /// <value>Immer <c>9</c>.</value>
        public int VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Erstellungsdatum
        /// </summary>
        /// <remarks>Zeitpunkt der Erstellung des Datensatzes.</remarks>
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
            get { return DBFE == null ? 0 : DBFE.Count; }
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer des Arbeitnehmers.
        /// </summary>
        /// <value>Eine gültige Rentenversicherungsnummer.</value>
        public string VSNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Geburtsdatum des Arbeitnehmers.
        /// </summary>
        public LocalDate GEBURTSDAT { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Verursachers des Datensatzes.
        /// </summary>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Holt oder setzt die Datensatz-ID.
        /// </summary>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt den Produkt-Identifier.
        /// </summary>
        public string PRODID { get; set; }

        /// <summary>
        /// Holt oder setzt den Modifikations-Identifier.
        /// </summary>
        public string MODID { get; set; }

        /*
        // Dieses Feld dürfen wir nicht verwenden.
        /// <summary>
        /// Holt oder setzt das Datum der Weiterleitung durch die Datenannahmestelle.
        /// </summary>
        public DateTime? DATUMVERARBEITUNG { get; set; }
        */

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der für den/die Beschäftigte(n) zuständigen Krankenkasse.
        /// </summary>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Holt oer setzt die Betriebsnummer der Abrechnungsstelle.
        /// </summary>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen, ob eine Rückmeldung der Entgeltersatzleistung durch den Arbeitgeber abgefordert wird.
        /// </summary>
        public bool RUECKMELDUNGEEL { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Abgabe gemäß Anlage 2 der Gemeinsamen Grundsätze.
        /// </summary>
        public int ABGABEGRUND { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen, ob es sich um eine Stornierung einer bereits abgegebenen Meldung handelt.
        /// </summary>
        public bool KENNZSTORNO { get; set; }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBNA" /> gesetzt ist.
        /// </summary>
        public bool MMNA
        {
            get => _hatDbna ?? DBNA != null;
            set => _hatDbna = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBAN" /> gesetzt ist.
        /// </summary>
        public bool MMAN
        {
            get => _hatDban ?? DBAN != null;
            set => _hatDban = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBAL" /> gesetzt ist.
        /// </summary>
        public bool MMAL
        {
            get => _hatDbal ?? DBAL != null;
            set => _hatDbal = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBAE" /> gesetzt ist.
        /// </summary>
        public bool MMAE
        {
            get => _hatDbae ?? DBAE != null;
            set => _hatDbae = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBZA" /> gesetzt ist.
        /// </summary>
        public bool MMZA
        {
            get => _hatDbza ?? DBZA != null;
            set => _hatDbza = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBEE" /> gesetzt ist.
        /// </summary>
        public bool MMEE
        {
            get => _hatDbee ?? DBEE != null;
            set => _hatDbee = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBAW" /> gesetzt ist.
        /// </summary>
        public bool MMAW
        {
            get => _hatDbaw ?? DBAW != null;
            set => _hatDbaw = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBFR" /> gesetzt ist.
        /// </summary>
        public bool MMFR
        {
            get => _hatDbfr ?? DBFR != null;
            set => _hatDbfr = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBUN" /> gesetzt ist.
        /// </summary>
        public bool MMUN
        {
            get => _hatDbun ?? DBUN != null;
            set => _hatDbun = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBMU" /> gesetzt ist.
        /// </summary>
        public bool MMMU
        {
            get => _hatDbmu ?? DBMU != null;
            set => _hatDbmu = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBVO" /> gesetzt ist.
        /// </summary>
        public bool MMVO
        {
            get => _hatDbvo ?? DBVO != null;
            set => _hatDbvo = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBHE" /> gesetzt ist.
        /// </summary>
        public bool MMHE
        {
            get => _hatDbhe ?? DBHE != null;
            set => _hatDbhe = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBBE" /> gesetzt ist.
        /// </summary>
        public bool MMBE
        {
            get => _hatDbbe ?? DBBE != null;
            set => _hatDbbe = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBLT" /> gesetzt ist.
        /// </summary>
        public bool MMLT
        {
            get => _hatDblt ?? DBLT != null;
            set => _hatDblt = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBSF" /> gesetzt ist.
        /// </summary>
        public bool MMSF
        {
            get => _hatDbsf ?? DBSF != null;
            set => _hatDbsf = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBTK" /> gesetzt ist.
        /// </summary>
        public bool MMTK
        {
            get => _hatDbtk ?? DBTK != null;
            set => _hatDbtk = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBAP" /> gesetzt ist.
        /// </summary>
        public bool MMAP
        {
            get => _hatDbap ?? DBAP != null;
            set => _hatDbap = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBID" /> gesetzt ist.
        /// </summary>
        public bool MMID
        {
            get => _hatDbid ?? DBID != null;
            set => _hatDbid = value;
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBNA.
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
        /// Holt oder setzt den Baustein DBAN.
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
        /// Holt oder setzt den Baustein DBAL.
        /// </summary>
        public DBAL DBAL
        {
            get => ListeDBAL?.SingleOrDefault();
            set
            {
                ListeDBAL = ListeDBAL.Set(value);
                _hatDbal = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBAE.
        /// </summary>
        public DBAE DBAE
        {
            get => ListeDBAE?.SingleOrDefault();
            set
            {
                ListeDBAE = ListeDBAE.Set(value);
                _hatDbae = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBZA.
        /// </summary>
        public DBZA DBZA
        {
            get => ListeDBZA?.SingleOrDefault();
            set
            {
                ListeDBZA = ListeDBZA.Set(value);
                _hatDbza = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBEE.
        /// </summary>
        public DBEE DBEE
        {
            get => ListeDBEE?.SingleOrDefault();
            set
            {
                ListeDBEE = ListeDBEE.Set(value);
                _hatDbee = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBAW.
        /// </summary>
        public DBAW DBAW
        {
            get => ListeDBAW?.SingleOrDefault();
            set
            {
                ListeDBAW = ListeDBAW.Set(value);
                _hatDbaw = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBFR.
        /// </summary>
        public DBFR DBFR
        {
            get => ListeDBFR?.SingleOrDefault();
            set
            {
                ListeDBFR = ListeDBFR.Set(value);
                _hatDbfr = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBUN.
        /// </summary>
        public DBUN DBUN
        {
            get => ListeDBUN?.SingleOrDefault();
            set
            {
                ListeDBUN = ListeDBUN.Set(value);
                _hatDbun = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBMU.
        /// </summary>
        public DBMU DBMU
        {
            get => ListeDBMU?.SingleOrDefault();
            set
            {
                ListeDBMU = ListeDBMU.Set(value);
                _hatDbmu = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBVO.
        /// </summary>
        public DBVO DBVO
        {
            get => ListeDBVO?.SingleOrDefault();
            set
            {
                ListeDBVO = ListeDBVO.Set(value);
                _hatDbvo = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBHE.
        /// </summary>
        public DBHE DBHE
        {
            get => ListeDBHE?.SingleOrDefault();
            set
            {
                ListeDBHE = ListeDBHE.Set(value);
                _hatDbhe = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBBE.
        /// </summary>
        public DBBE DBBE
        {
            get => ListeDBBE?.SingleOrDefault();
            set
            {
                ListeDBBE = ListeDBBE.Set(value);
                _hatDbbe = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBLT.
        /// </summary>
        public DBLT DBLT
        {
            get => ListeDBLT?.SingleOrDefault();
            set
            {
                ListeDBLT = ListeDBLT.Set(value);
                _hatDblt = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBSF.
        /// </summary>
        public DBSF DBSF
        {
            get => ListeDBSF?.SingleOrDefault();
            set
            {
                ListeDBSF = ListeDBSF.Set(value);
                _hatDbsf = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBTK.
        /// </summary>
        public DBTK DBTK
        {
            get => ListeDBTK?.SingleOrDefault();
            set
            {
                ListeDBTK = ListeDBTK.Set(value);
                _hatDbtk = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein DBAP.
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
        /// Holt oder setzt den Baustein DBID.
        /// </summary>
        public DBID DBID
        {
            get => ListeDBID?.SingleOrDefault();
            set
            {
                ListeDBID = ListeDBID.Set(value);
                _hatDbid = null;
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
            get => ListExtensions.Enumerate(DBFE);
        }

        private IList<DBNA> ListeDBNA { get; set; }

        private IList<DBAN> ListeDBAN { get; set; }

        private IList<DBAL> ListeDBAL { get; set; }

        private IList<DBAE> ListeDBAE { get; set; }

        private IList<DBZA> ListeDBZA { get; set; }

        private IList<DBEE> ListeDBEE { get; set; }

        private IList<DBAW> ListeDBAW { get; set; }

        private IList<DBFR> ListeDBFR { get; set; }

        private IList<DBUN> ListeDBUN { get; set; }

        private IList<DBMU> ListeDBMU { get; set; }

        private IList<DBVO> ListeDBVO { get; set; }

        private IList<DBHE> ListeDBHE { get; set; }

        private IList<DBBE> ListeDBBE { get; set; }

        private IList<DBLT> ListeDBLT { get; set; }

        private IList<DBSF> ListeDBSF { get; set; }

        private IList<DBTK> ListeDBTK { get; set; }

        private IList<DBAP01> ListeDBAP { get; set; }

        private IList<DBID> ListeDBID { get; set; }
    }
}
