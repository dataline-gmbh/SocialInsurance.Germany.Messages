// <copyright file="DSVV.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos.ELENA
{
    /// <summary>
    /// Datensatz: DSVV - Vergabe einer Versicherungs-/Verfahrensnummer
    /// </summary>
    [Obsolete("ELENA-Verfahren")]
    public class DSVV : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDben;

        private bool? _hatDbna;

        private bool? _hatDbgb;

        private bool? _hatDban;

        private bool? _hatDbag;

        private bool? _hatDbab;

        private bool? _hatDbfz;

        private bool? _hatDbse;

        private bool? _hatDbsb;

        private bool? _hatDbas;

        private bool? _hatDbzd;

        private bool? _hatDbnb;

        private bool? _hatDbha;

        private bool? _hatDbke;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSVV"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt
        /// </remarks>
        public DSVV()
        {
            KE = "DSVV";
            VF = "ELENA";
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
        /// Holt oder setzt die Betriebsnummer des Erstellers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Erstellers des Datensatzes, Länge 8, Mussangabe
        /// </remarks>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers des Datensatzes, Länge 8, Mussangabe
        /// </remarks>
        public string BBNREP { get; set; }

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
            get { return DBFE?.Count ?? 0; }
            private set { /* Must be existent, but inaccessible! */ }
        }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer/Verfahrensnummer
        /// </summary>
        /// <remarks>
        /// Ist bei der Anforderung leer, Länge 12
        /// </remarks>
        public string VSNRVFNR { get; set; }

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
        /// Holt oder setzt die Betriebsnummer der für den/die Beschäftigte(n) zuständigen Krankenkasse
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der für den/die Beschäftigte(n) zuständigen Krankenkasse, Länge 15, Mussangabe unter Bedingungen
        /// </remarks>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen KK
        /// </summary>
        /// <remarks>
        /// Entfällt hier, Grundstellung liefern, Länge 20, Mussangabe
        /// </remarks>
        public string AZKK { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Abrechnungsstelle (z.B. Steuerberater), Länge 15, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt die Personengruppe
        /// </summary>
        /// <remarks>
        /// Personengruppe gemäß Anlage 3 der Gemeinsamen Grundsätze, Länge 3, Mussangabe
        /// für die Datenerfassung und Datenübermittlung zur Sozialversicherung nach § 28b Abs. 2 SGB IV
        /// </remarks>
        public int PERSGR { get; set; }

        /// <summary>
        /// Holt oder setzt den Staatsangehörigkeitsschlüssel
        /// </summary>
        /// <remarks>
        /// Staatsangehörigkeitsschlüssel des statistischen Bundesamtes, Länge 3, Mussangabe
        /// </remarks>
        public string SASC { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob die Person als Beamter/Soldat/Richter tätig ist
        /// </summary>
        /// <remarks>
        /// Ist diese Person als Beamter / Richter / Soldat tätig? Länge 1, Mussangabe
        /// J = j, N = nein
        /// </remarks>
        public bool BEAM { get; set; }

        /// <summary>
        /// Holt oder setzt das dem Verursacher zur Verfügung stehende Feld
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht dem Verursacher zur Verfügung, Länge 20, Kannangabe
        /// Bei Meldungen zwischen dem Arbeitgeber und der ZSS: z. B. Aktenzeichen/Personalnummer des / der Beschäftigten
        /// </remarks>
        public string DSID { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob es sich um eine Stornierung handelt
        /// </summary>
        /// <remarks>
        /// Kennzeichen, Stornierung einer bereits abgegebenen Meldung
        /// N = keine Stornierung
        /// </remarks>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein ELENA Grunddaten vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBEN, Länge 1, Mussangabe
        /// N = keine Grunddaten
        /// </remarks>
        public bool MMEN
        {
            get => _hatDben ?? DBEN != null;
            set => _hatDben = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Name vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBNA, Länge 1, Mussangabe
        /// J = Namensdaten vorhanden
        /// </remarks>
        public bool MMNA
        {
            get => _hatDbna ?? DBNA != null;
            set => _hatDbna = value;
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
            get => _hatDbgb ?? DBGB != null;
            set => _hatDbgb = value;
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
            get => _hatDban ?? DBAN != null;
            set => _hatDban = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Arbeitgeberangaben vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAG, Länge 1, Mussangabe
        /// N = keine Arbeitgeberangaben
        /// </remarks>
        public bool MMAG
        {
            get => _hatDbag ?? DBAG != null;
            set => _hatDbag = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Arbeitgeberanschrift abweichender Beschäftigungsort vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAB
        /// N = kein abweichender Beschäftigungsort
        /// </remarks>
        public bool MMAB
        {
            get => _hatDbab ?? DBAB != null;
            set => _hatDbab = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Fehlzeiten vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBFZ, Länge 1, Mussangabe
        /// N = keine Fehlzeiten
        /// </remarks>
        public bool MMFZ
        {
            get => _hatDbfz ?? DBFZ != null;
            set => _hatDbfz = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Steuerpflichtiger sonstiger Bezug vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBSE, Länge 1, Mussangabe
        /// N = keine Beträge
        /// </remarks>
        public bool MMSE
        {
            get => _hatDbse ?? DBSE != null;
            set => _hatDbse = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Steuerfreie Bezüge vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBSB, Länge 1, Mussangabe
        /// N = keine Beträge
        /// </remarks>
        public bool MMSB
        {
            get => _hatDbsb ?? DBSB != null;
            set => _hatDbsb = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Ausbildung vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBAS, Länge 1, Mussangabe
        /// N = keine DBAS-Daten
        /// </remarks>
        public bool MMAS
        {
            get => _hatDbas ?? DBAS != null;
            set => _hatDbas = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Zusatzdaten vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBZD, Länge 1, Mussangabe
        /// N = keine Zusatzdaten
        /// </remarks>
        public bool MMZD
        {
            get => _hatDbzd ?? DBZD != null;
            set => _hatDbzd = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Nebenbeschäftigung Arbeitslose vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBNB, Länge 1, Mussangabe
        /// N = keine DBNB-Daten
        /// </remarks>
        public bool MMNB
        {
            get => _hatDbnb ?? DBNB != null;
            set => _hatDbnb = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Heimatarbeiter vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBHA, Länge 1, Mussangabe
        /// N = keine DBHA-Daten
        /// </remarks>
        public bool MMHA
        {
            get => _hatDbha ?? DBHA != null;
            set => _hatDbha = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Kündigung/Entlassung vorhanden ist
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBKE, Länge 1, Mussangabe
        /// N = keine DBKE-Daten
        /// </remarks>
        public bool MMKE
        {
            get => _hatDbke ?? DBKE != null;
            set => _hatDbke = value;
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBEN</code>
        /// </summary>
        public DBEN DBEN
        {
            get => ListeDBEN?.SingleOrDefault();
            set
            {
                ListeDBEN = ListeDBEN.Set(value);
                _hatDben = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBNA</code>
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
        /// Holt oder setzt den Datenbaustein <code>DBGB</code>
        /// </summary>
        public DBGB DBGB
        {
            get => ListeDBGB?.SingleOrDefault();
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
            get => ListeDBAN?.SingleOrDefault();
            set
            {
                ListeDBAN = ListeDBAN.Set(value);
                _hatDban = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBAG</code>
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
        /// Holt oder setzt den Datenbaustein <code>DBAB</code>
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
        /// Holt oder setzt den Datenbaustein <code>DBFZ</code>
        /// </summary>
        public DBFZ DBFZ
        {
            get => ListeDBFZ?.SingleOrDefault();
            set
            {
                ListeDBFZ = ListeDBFZ.Set(value);
                _hatDbfz = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBSE</code>
        /// </summary>
        public DBSE DBSE
        {
            get => ListeDBSE?.SingleOrDefault();
            set
            {
                ListeDBSE = ListeDBSE.Set(value);
                _hatDbse = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBSB</code>
        /// </summary>
        public DBSB DBSB
        {
            get => ListeDBSB?.SingleOrDefault();
            set
            {
                ListeDBSB = ListeDBSB.Set(value);
                _hatDbsb = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBEN</code>
        /// </summary>
        public DBAS DBAS
        {
            get => ListeDBAS?.SingleOrDefault();
            set
            {
                ListeDBAS = ListeDBAS.Set(value);
                _hatDbas = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBZD</code>
        /// </summary>
        public DBZD DBZD
        {
            get => ListeDBZD?.SingleOrDefault();
            set
            {
                ListeDBZD = ListeDBZD.Set(value);
                _hatDbzd = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBNB</code>
        /// </summary>
        public DBNB DBNB
        {
            get => ListeDBNB?.SingleOrDefault();
            set
            {
                ListeDBNB = ListeDBNB.Set(value);
                _hatDbnb = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBHA</code>
        /// </summary>
        public DBHA DBHA
        {
            get => ListeDBHA?.SingleOrDefault();
            set
            {
                ListeDBHA = ListeDBHA.Set(value);
                _hatDbha = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein <code>DBKE</code>
        /// </summary>
        public DBKE DBKE
        {
            get => ListeDBKE?.SingleOrDefault();
            set
            {
                ListeDBKE = ListeDBKE.Set(value);
                _hatDbke = null;
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
                foreach (var datenbaustein in ListExtensions.Enumerate(ListeDBEN, ListeDBNA, ListeDBGB, ListeDBAN, ListeDBAG, ListeDBAB, ListeDBFZ, ListeDBSE, ListeDBSB, ListeDBAS, ListeDBZD, ListeDBNB, ListeDBHA, ListeDBKE, DBFE))
                    yield return datenbaustein;
            }
        }

        private IList<DBEN> ListeDBEN { get; set; }

        private IList<DBNA> ListeDBNA { get; set; }

        private IList<DBGB> ListeDBGB { get; set; }

        private IList<DBAN> ListeDBAN { get; set; }

        private IList<DBAG> ListeDBAG { get; set; }

        private IList<DBAB> ListeDBAB { get; set; }

        private IList<DBFZ> ListeDBFZ { get; set; }

        private IList<DBSE> ListeDBSE { get; set; }

        private IList<DBSB> ListeDBSB { get; set; }

        private IList<DBAS> ListeDBAS { get; set; }

        private IList<DBZD> ListeDBZD { get; set; }

        private IList<DBNB> ListeDBNB { get; set; }

        private IList<DBHA> ListeDBHA { get; set; }

        private IList<DBKE> ListeDBKE { get; set; }
    }
}
