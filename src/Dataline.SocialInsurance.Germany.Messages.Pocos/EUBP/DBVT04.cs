// <copyright file="DBVT04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DBVT04 : IDatenbaustein
    {
        private bool? _hatDbvkg;

        private bool? _hatDbvsk;

        private bool? _hatDbvatzsf;

        private bool? _hatDbvatzao;

        private bool? _hatDbvwosf;

        private bool? _hatDbvwoao;

        private bool? _hatDbvwwsf;

        private bool? _hatDbvwwao;

        private bool? _hatDbs5;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBVT04"/> Klasse
        /// </summary>
        public DBVT04()
        {
            KE = "DBVT";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Abrechnungsjahr
        /// </summary>
        public int KJ { get; set; }

        /// <summary>
        /// Holt oder setzt den Abrechnungsmonat
        /// </summary>
        public int KM { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Krankenkasse
        /// </summary>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe KV-Tage
        /// </summary>
        public int KVTG { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe RV-Tage
        /// </summary>
        public int RVTG { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe AV-Tage
        /// </summary>
        public int AVTG { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe PV-Tage
        /// </summary>
        public int PVTG { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe der Steuer-Tage
        /// </summary>
        public string STTG { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Beitragszuschlag Pflegeversicherung
        /// </summary>
        /// <remarks>
        /// J - Ja, N - Nein
        /// </remarks>
        public string KENNZPVZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Personengruppe
        /// </summary>
        /// <remarks>
        /// Personengruppe, Länge 3, Kann-Feld
        /// </remarks>
        public int PERSGR { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel KV
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// </remarks>
        public string BYGRKV { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel RV
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// </remarks>
        public string BYGRRV { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel AV
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// </remarks>
        public string BYGRAV { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel PV
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// </remarks>
        public string BYGRPV { get; set; }

        /// <summary>
        /// Holt oder setzt das Gesamtbrutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int GESBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt das Steuerbrutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int STEUERBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt das KV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int KVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt das RV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int RVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt das AV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int AVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt das PV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int PVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt das umlagepfl. Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int UMBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt das insolvenzgeldumlagepflichtige Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int INSOBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt das UV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int UVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte Kurzarbeitergeld vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte Kurzarbeitergeld vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte Kurzarbeitergeld
        /// J = Vortragswerte Kurzarbeitergeld vorhanden
        /// </remarks>
        public bool MMVKG
        {
            get => _hatDbvkg ?? DBVK != null;
            set => _hatDbvkg = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte SaisonKurzarbeitergeld vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte SaisonKurzarbeitergeld vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte SaisonKurzarbeitergeld
        /// J = Vortragswerte SaisonKurzarbeitergeld vorhanden
        /// </remarks>
        public bool MMVSK
        {
            get => _hatDbvsk ?? DBVS != null;
            set => _hatDbvsk = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte Altersteilzeit SummenfelderModell vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte Altersteilzeit SummenfelderModell vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte Altersteilzeit SummenfelderModell
        /// J = Vortragswerte Altersteilzeit SummenfelderModell vorhanden
        /// </remarks>
        public bool MMVATZSF
        {
            get => _hatDbvatzsf ?? DBVF != null;
            set => _hatDbvatzsf = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte Altersteilzeit Alternativ-/Options-Modell vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte Altersteilzeit Alternativ-/Options-Modell vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte Altersteilzeit Alternativ-/Options-Modell
        /// J = Vortragswerte Altersteilzeit Alternativ-/Options-Modell vorhanden
        /// </remarks>
        public bool MMVATZAO
        {
            get => _hatDbvatzao ?? DBVA != null;
            set => _hatDbvatzao = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte Wertguthaben Ost SummenfelderModell vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte Wertguthaben Ost SummenfelderModell vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte Wertguthaben Ost SummenfelderModell
        /// J = Vortragswerte Wertguthaben Ost SummenfelderModell vorhanden
        /// </remarks>
        public bool MMVWOSF
        {
            get => _hatDbvwosf ?? DBOS != null;
            set => _hatDbvwosf = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte Wertguthaben Ost Alternativ-/Options-Modell vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte Wertguthaben Ost Alternativ-/Options-Modell vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte Wertguthaben Ost Alternativ-/Options-Modell
        /// J = Vortragswerte Wertguthaben Ost Alternativ-/Options-Modell vorhanden
        /// </remarks>
        public bool MMVWOAO
        {
            get => _hatDbvwoao ?? DBOA != null;
            set => _hatDbvwoao = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte Wertguthaben West SummenfelderModell vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte Wertguthaben West SummenfelderModell vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte Wertguthaben West SummenfelderModell
        /// J = Vortragswerte Wertguthaben West SummenfelderModell vorhanden
        /// </remarks>
        public bool MMVWWSF
        {
            get => _hatDbvwwsf ?? DBWS != null;
            set => _hatDbvwwsf = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte Wertguthaben West Alternativ-/Options-Modell vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte Wertguthaben West Alternativ-/Options-Modell vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte Wertguthaben West Alternativ-/Options-Modell
        /// J = Vortragswerte Wertguthaben West Alternativ-/Options-Modell vorhanden
        /// </remarks>
        public bool MMVWWAO
        {
            get => _hatDbvwwao ?? DBWA != null;
            set => _hatDbvwwao = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte Wertguthaben West Alternativ-/Options-Modell vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte Wertguthaben West Alternativ-/Options-Modell vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte Wertguthaben West Alternativ-/Options-Modell
        /// J = Vortragswerte Wertguthaben West Alternativ-/Options-Modell vorhanden
        /// </remarks>
        public bool MMS5
        {
            get => _hatDbs5 ?? DBS5 != null;
            set => _hatDbs5 = value;
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Vortragswerte Kurzarbeitergeld
        /// </summary>
        public DBVK04 DBVK
        {
            get => ListeDBVK?.SingleOrDefault();
            set
            {
                ListeDBVK = ListeDBVK.Set(value);
                _hatDbvkg = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Vortragswerte Saison-Kurzarbeitergeld
        /// </summary>
        public DBVS04 DBVS
        {
            get => ListeDBVS?.SingleOrDefault();
            set
            {
                ListeDBVS = ListeDBVS.Set(value);
                _hatDbvsk = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Vortragswerte Altersteilzeit Summenfelder-Modell
        /// </summary>
        public DBVF04 DBVF
        {
            get => ListeDBVF?.SingleOrDefault();
            set
            {
                ListeDBVF = ListeDBVF.Set(value);
                _hatDbvatzsf = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Vortragswerte Altersteilzeit Alternativ-/Options-Modell
        /// </summary>
        public DBVA04 DBVA
        {
            get => ListeDBVA?.SingleOrDefault();
            set
            {
                ListeDBVA = ListeDBVA.Set(value);
                _hatDbvatzao = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Vortragswerte Wertguthaben Ost Summenfelder-Modell
        /// </summary>
        public DBOS04 DBOS
        {
            get => ListeDBOS?.SingleOrDefault();
            set
            {
                ListeDBOS = ListeDBOS.Set(value);
                _hatDbvwosf = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Vortragswerte Wertguthaben West Alternativ-/OptionsModell
        /// </summary>
        public DBOA04 DBOA
        {
            get => ListeDBOA?.SingleOrDefault();
            set
            {
                ListeDBOA = ListeDBOA.Set(value);
                _hatDbvwoao = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Vortragswerte Wertguthaben Ost Summenfelder-Modell
        /// </summary>
        public DBWS04 DBWS
        {
            get => ListeDBWS?.SingleOrDefault();
            set
            {
                ListeDBWS = ListeDBWS.Set(value);
                _hatDbvwwsf = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für Vortragswerte Wertguthaben West Alternativ-/OptionsModell
        /// </summary>
        public DBWA04 DBWA
        {
            get => ListeDBWA?.SingleOrDefault();
            set
            {
                ListeDBWA = ListeDBWA.Set(value);
                _hatDbvwwao = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein für seemännische Besonderheiten
        /// </summary>
        public DBS504 DBS5
        {
            get => ListeDBS5?.SingleOrDefault();
            set
            {
                ListeDBS5 = ListeDBS5.Set(value);
                _hatDbs5 = null;
            }
        }

        private IList<DBVK04> ListeDBVK { get; set; }

        private IList<DBVS04> ListeDBVS { get; set; }

        private IList<DBVF04> ListeDBVF { get; set; }

        private IList<DBVA04> ListeDBVA { get; set; }

        private IList<DBOS04> ListeDBOS { get; set; }

        private IList<DBOA04> ListeDBOA { get; set; }

        private IList<DBWS04> ListeDBWS { get; set; }

        private IList<DBWA04> ListeDBWA { get; set; }

        private IList<DBS504> ListeDBS5 { get; set; }
    }
}
