// <copyright file="DSANext04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DSANext04
    {
        private bool? _hatDbkn;

        private bool? _hatDbs3;

        /// <summary>
        /// Holt oder setzt das Gültigkeitsdatum ab
        /// </summary>
        public LocalDate GLTAB { get; set; }

        /// <summary>
        /// Holt oder setzt das Änderungsdatum
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Änderung der Daten, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime AENDDAT { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen Verursacher (bisherige Personalnummer)
        /// </summary>
        /// <remarks>
        /// Länge 20, Mussangabe, wenn Versicherungsnummer leer, sonst Pflichtangabe
        /// </remarks>
        public string AZVUALT { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen Verursacher (weitergeführte Personalnummer)
        /// </summary>
        /// <remarks>
        /// Länge 20, Mussangabe, wenn Versicherungsnummer leer, sonst Pflichtangabe
        /// </remarks>
        public string AZVUWEITER { get; set; }

        /// <summary>
        /// Holt oder setzt das Ersteintrittsdatum
        /// </summary>
        public LocalDate? ERSTEINTR { get; set; }

        /// <summary>
        /// Holt oder setzt das Eintrittsdatum
        /// </summary>
        public LocalDate EINTR { get; set; }

        /// <summary>
        /// Holt oder setzt das Austrittsdatum
        /// </summary>
        public LocalDate? AUSTR { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Mitarbeiters
        /// </summary>
        /// <remarks>
        /// Länge 30, Mussangabe
        /// </remarks>
        public string NAME { get; set; }

        /// <summary>
        /// Holt oder setzt den Geburtsnamen des Mitarbeiters
        /// </summary>
        /// <remarks>
        /// Länge 30, Kannangabe
        /// </remarks>
        public string GBNAME { get; set; }

        /// <summary>
        /// Holt oder setzt den Vornamen des Mitarbeiters
        /// </summary>
        /// <remarks>
        /// Länge 30, Kannangabe
        /// </remarks>
        public string VONAME { get; set; }

        /// <summary>
        /// Holt oder setzt das Geschlecht des Mitarbeiters
        /// </summary>
        /// <remarks>
        /// Länge 1, Kannangabe
        /// M-männlich
        /// W-weiblich
        /// </remarks>
        public string GE { get; set; }

        /// <summary>
        /// Holt oder setzt das Länder- (Kfz-) Kennzeichen des Wohnsitzlandes ("D" für Deutschland)
        /// </summary>
        /// <remarks>
        /// Länge 3, Kannangabe
        /// D  -Deutschland
        /// </remarks>
        public string LDKZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl des Wohnsitzes des Mitarbeiters
        /// </summary>
        /// <remarks>
        /// Länge 10, Kannangabe
        /// </remarks>
        public string PLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort des Wohnsitzes des Mitarbeiters
        /// </summary>
        /// <remarks>
        /// Länge 34, Kannangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße des Wohnsitzes des Mitarbeiters
        /// </summary>
        /// <remarks>
        /// Länge 33, Kannangabe
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer des Wohnsitzes des Mitarbeiters
        /// </summary>
        /// <remarks>
        /// Länge 9, Kannangabe
        /// </remarks>
        public string HNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Europäische Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Länge 20, Kannangabe
        /// </remarks>
        public string EUVSNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Geburtsdatum des Mitarbeiters
        /// </summary>
        public LocalDate? GBDT { get; set; }

        /// <summary>
        /// Holt oder setzt den Geburtsort des Mitarbeiters
        /// </summary>
        /// <remarks>
        /// Länge 34, Kannangabe
        /// </remarks>
        public string GBORT { get; set; }

        /// <summary>
        /// Holt oder setzt den Staatsangehörigkeitsschlüssel
        /// </summary>
        /// <remarks>
        /// Länge 3, Kannangabe
        /// </remarks>
        public string SASC { get; set; }

        /// <summary>
        /// Holt oder setzt den Todestag des Mitarbeiters
        /// </summary>
        public LocalDate? TODDAT { get; set; }

        /// <summary>
        /// Holt oder setzt den Rechtskreis der Arbeitsstätte
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// O-Ost
        /// W-West
        /// </remarks>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Holt oder setzt Pflegeversicherung-Besonderheiten der Beitragstragung bei Betrieben / Betriebsteilen im Bundesland Sachsen
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// </remarks>
        public bool KENNZPVS { get; set; }

        /// <summary>
        /// Holt oder setzt die Kontonummer
        /// </summary>
        /// <remarks>
        /// Länge 10, Kannangabe
        /// </remarks>
        public string KNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Bankleitzahl
        /// </summary>
        /// <remarks>
        /// Länge 8, Kannangabe
        /// </remarks>
        public string BLZ { get; set; }

        /// <summary>
        /// Holt oder setzt die IBAN
        /// </summary>
        /// <remarks>
        /// Länge 34, Kannangabe
        /// </remarks>
        public string IBAN { get; set; }

        /// <summary>
        /// Holt oder setzt die BIC
        /// </summary>
        /// <remarks>
        /// Länge 11, Kannangabe
        /// </remarks>
        public string BIC { get; set; }

        /// <summary>
        /// Holt oder setzt die Steuerklasse
        /// </summary>
        /// <remarks>
        /// Kannangabe
        /// </remarks>
        public int? STKL { get; set; }

        /// <summary>
        /// Holt oder setzt die Kirchensteuerpflicht des Arbeitnehmers
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// </remarks>
        public bool KISTPF { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl Kinderfreibeträge
        /// </summary>
        /// <remarks>
        /// Länge 3 mit 1 NK, Kannangabe
        /// </remarks>
        public int? KIFRBTRG { get; set; }

        /// <summary>
        /// Holt oder setzt den Steuerfreibetrag Jahr
        /// </summary>
        /// <remarks>
        /// Länge 10 mit 2 NK, Kannangabe
        /// </remarks>
        public int? EGSTFRBTRG { get; set; }

        /// <summary>
        /// Holt oder setzt den Klartext der Tätigkeit im Unternehmen
        /// </summary>
        /// <remarks>
        /// Länge 25, Kannangabe
        /// </remarks>
        public int? TT { get; set; }

        /// <summary>
        /// Holt oder setzt den Tätigkeitsschlüssel
        /// </summary>
        /// <remarks>
        /// Länge 9, Kannangabe
        /// </remarks>
        public int? TTSC { get; set; }

        /// <summary>
        /// Holt oder setzt die Personengruppe
        /// </summary>
        /// <remarks>
        /// Länge 9, Kannangabe
        /// </remarks>
        public int? PERSGR { get; set; }

        /// <summary>
        /// Holt oder setzt die Beitragsgruppe KV
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public int? BYGRKV { get; set; }

        /// <summary>
        /// Holt oder setzt die Beitragsgruppe RV
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public int? BYGRRV { get; set; }

        /// <summary>
        /// Holt oder setzt die Beitragsgruppe AV
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public int? BYGRAV { get; set; }

        /// <summary>
        /// Holt oder setzt die Beitragsgruppe PV
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public int? BYGRPV { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Geringverdiener
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZGV { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Mehrfachbeschäftigung
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZMF { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Mehrfachbezug
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZMFB { get; set; }

        /// <summary>
        /// Holt oder setzt das Statuskennzeichen
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// null=keins von Beiden
        /// 1=Ehegatte, Lebenspartner, Abkömmling
        /// 2=geschäftsführender Gesellschafter einer GmbH
        /// </remarks>
        public int? KENNZSTA { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Krankenkasse
        /// </summary>
        /// <remarks>
        /// Länge 15, Kannangabe
        /// </remarks>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Holt oder setzt den Gesamtbeitrag zur privaten KV (monatlich)
        /// </summary>
        /// <remarks>
        /// Länge 10 mit 2 NK, Kannangabe
        /// </remarks>
        public int? GESBYPRIVKV { get; set; }

        /// <summary>
        /// Holt oder setzt den Gesamtbeitrag zur privaten PV (monatlich)
        /// </summary>
        /// <remarks>
        /// Länge 10 mit 2 NK, Kannangabe
        /// </remarks>
        public int? GESBYPRIVPV { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Trägers der berufsständischen Versorgung
        /// </summary>
        /// <remarks>
        /// Länge 15, Kannangabe
        /// </remarks>
        public string BBNRVW { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal für die Zusatzversorgungsanstalt
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// 0-keine
        /// 1-ZV des öffentl. Dienstes
        /// 2-ZV des Baugewerbes
        /// 3-sonstige ZV
        /// </remarks>
        public int KENNZZVA { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen der Zusatzversorgungsanstalt
        /// </summary>
        /// <remarks>
        /// Länge 35, Kannangabe
        /// </remarks>
        public string ZVA { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Baulohn
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZBAU { get; set; }

        /// <summary>
        /// Holt oder setzt die vereinbarte wöchentl. Arbeitszeit in Stunden
        /// </summary>
        /// <remarks>
        /// Länge 4, 2 NK, Mussangabe
        /// </remarks>
        public int? AZWOECH { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Gleitzone/Übergangsbereich
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZGLE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Verzicht auf Reduzierung des AN-Anteils in der RV bei Gleitzone
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool? KENNZVERZGLE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Verzicht auf Rentenversicherungsfreiheit bei geringfügiger Beschäftigung
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool? KENNZVERZRVFGB { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Verzicht auf Rentenversicherungspflicht bei geringfügiger Beschäftigung
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool? KENNZVERZRVPGB { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal für Wertguthabenvereinbarung
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZWG { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal für Elterneigenschaft
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZELT { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal für ausgezahltes Kindergeld
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZKG { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal für Versorgungsbezugsempfänger
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZVBE { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal für Rentenbezieher
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZRBZ { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal für Altersteilzeitmodell
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// 0-keine Altersteilzeit
        /// 1-Blockmodell
        /// 2-Teilzeitmodell
        /// </remarks>
        public int KENNZATZ { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Altfall ATZ
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public bool KENNZATZALT { get; set; }

        /// <summary>
        /// Holt oder setzt das Beginn-Datum der ATZ
        /// </summary>
        /// <remarks>
        /// Kannangabe
        /// </remarks>
        public LocalDate? ATZBG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende-Datum der ATZ
        /// </summary>
        /// <remarks>
        /// Kannangabe
        /// </remarks>
        public LocalDate? ATZEN { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Freistellungsphase
        /// </summary>
        /// <remarks>
        /// Kannangabe
        /// </remarks>
        public LocalDate? FPBEG { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Knappschaft vorhanden ist
        /// </summary>
        /// <remarks>
        /// Knappschaft vorhanden, Länge 1, Mussangabe
        /// N = keine Knappschaft
        /// J = Knappschaft vorhanden
        /// </remarks>
        public bool MMKN
        {
            get => _hatDbkn ?? DBKN != null;
            set => _hatDbkn = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Knappschaft vorhanden ist
        /// </summary>
        /// <remarks>
        /// Knappschaft vorhanden, Länge 1, Mussangabe
        /// N = keine Knappschaft
        /// J = Knappschaft vorhanden
        /// </remarks>
        public bool MMS3
        {
            get => _hatDbs3 ?? DBS3 != null;
            set => _hatDbs3 = value;
        }

        /// <summary>
        /// Holt die Anzahl Lohnarten
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int ANGTST
        {
            get => DSANGTST?.Count ?? 0;

            // ReSharper disable once UnusedMember.Local
            // ReSharper disable once ValueParameterNotUsed
            private set { }
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Knappschaft
        /// </summary>
        public DBKN04 DBKN
        {
            get => ListeDBKN?.SingleOrDefault();
            set
            {
                ListeDBKN = ListeDBKN.Set(value);
                _hatDbkn = null;
            }
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Seemännische Besonderheiten
        /// </summary>
        public DBS304 DBS3
        {
            get => ListeDBS3?.SingleOrDefault();
            set
            {
                ListeDBS3 = ListeDBS3.Set(value);
                _hatDbs3 = null;
            }
        }

        /// <summary>
        /// Holt oder setzt eine Liste von Lohnarten
        /// </summary>
        public IList<DSANGTST04> DSANGTST { get; set; }

        private IList<DBKN04> ListeDBKN { get; set; }

        private IList<DBS304> ListeDBS3 { get; set; }
    }
}
