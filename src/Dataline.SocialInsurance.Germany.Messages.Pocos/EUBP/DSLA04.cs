// <copyright file="DSLA04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DSLA - Datensatz Lohn Arbeitnehmer
    /// </summary>
    public class DSLA04 : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        private bool? _hatDbkg;

        private bool? _hatDbat;

        private bool? _hatDbwo;

        private bool? _hatDbww;

        private bool? _hatDbs4;

        private bool? _hatDbvt;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSME04"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt
        /// </remarks>
        public DSLA04()
        {
            KE = "DSLA";
            VERNR = 4;
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
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5, Mussangabe
        /// DEUEV = DEÜV- Meldeverfahren RVSNR = Rückmeldung der Versicherungsnummer an den Arbeitgeber, Mussangabe
        /// </remarks>
        public string VF { get; set; }

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
        /// Versionsnummer des übermittelten Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public int VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Dateznsatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
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

            // ReSharper disable once UnusedMember.Local
            // ReSharper disable once ValueParameterNotUsed
            private set { }
        }

        /// <summary>
        /// Holt oder setzt Ordnungsmerkmal "Mandant"
        /// </summary>
        public string MANDANT { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen des Verursachers
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht dem Verursacher zur Verfügung, Länge 20, Kannangabe
        /// Bei der Datenübermittlung zwischen dem Arbeitgeber
        /// und der Datenannahmestelle: z
        /// B. Aktenzeichen / Personalnummer
        /// des Beschäftigten
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Versicherungsnummer in der Form: bbttmmjjassp, Länge 12, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string VSNR { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Vortragswerte vorhanden ist
        /// </summary>
        /// <remarks>
        /// Vortragswerte vorhanden, Länge 1, Mussangabe
        /// N = keine Vortragswerte
        /// J = Vortragswerte vorhanden
        /// </remarks>
        public bool MMVT
        {
            get => _hatDbvt ?? DBVT != null;
            set => _hatDbvt = value;
        }

        /// <summary>
        /// Anzahl der Lohnabrechnungen des Arbeitnehmers im Prüfzeitraum
        /// </summary>
        /// <remarks>
        /// Länge 3, Mussangabe
        /// </remarks>
        public int ANABRECH { get; set; }

        /// <summary>
        /// Jahr der Abrechnung (FÜR-Periode) Jahr für das die Abrechnung erfolgt ist.
        /// </summary>
        /// <remarks>
        /// Länge 4, Mussangabe
        /// </remarks>
        public int KJ { get; set; }

        /// <summary>
        /// Monat der Abrechnung (FÜR-Periode) Monat für den die Abrechnung erfolgt ist.
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int KM { get; set; }

        /// <summary>
        /// Jahr der Abrechnung (INPeriode) Jahr in dem die Abrechnung erfolgt ist.
        /// </summary>
        /// <remarks>
        /// Länge 4, Mussangabe
        /// </remarks>
        public int KJIN { get; set; }

        /// <summary>
        /// Monat der Abrechnung (IN-Periode) Monat in dem die Abrechnung erfolgt ist.
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int KMIN { get; set; }

        /// <summary>
        /// Holt oder setzt Kennzeichen der Art der Abrechnung
        /// </summary>
        /// <remarks>
        /// E - erstmalige Abrechnung
        /// K - Korrekturabrechnung
        /// </remarks>
        public string KENNZART { get; set; }

        /// <summary>
        /// Abrechnungsdatum, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </summary>
        public DateTime ABRECHDAT { get; set; }

        /// <summary>
        /// Abrechnungsfolgenummer; Nur bei mehreren Erstabrechnungen für den gleichen Abrechnungsmonat von 1 an aufsteigend zu füllen, ansonsten Grundstellung
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// </remarks>
        public int ABRNR { get; set; }

        /// <summary>
        /// Anwendung der Märzklausel?
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// J = Ja
        /// N = Nein
        /// </remarks>
        public bool KENNZMK { get; set; }

        /// <summary>
        /// KV-Tage
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int KVTG { get; set; }

        /// <summary>
        /// RV-Tage
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int RVTG { get; set; }

        /// <summary>
        /// AV-Tage
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int AVTG { get; set; }

        /// <summary>
        /// PV-Tage
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int PVTG { get; set; }

        /// <summary>
        /// St-Tage
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int STTG { get; set; }

        /// <summary>
        /// Kennzeichen Beitragszuschlag Pflegeversicherung?
        /// </summary>
        /// <remarks>
        /// Länge 1, Mussangabe
        /// J = Ja
        /// N = Nein
        /// </remarks>
        public bool KENNZPVZ { get; set; }

        /// <summary>
        /// Währung (EUR)
        /// </summary>
        public string WG { get; set; }

        /// <summary>
        /// Holt oder setzt einheitliche Pauschsteuer für geringfügig Beschäftigte
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PAUSCHSTEUERGB { get; set; }

        /// <summary>
        /// Holt oder setzt Gesamtbrutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int GESBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt ungemindertes SV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? SVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt Steuerbrutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? STEUERBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt KV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt RV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt AV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt PV-Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt umlagepfl. Brutto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? UMBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt Insolvenzgeldumlagepflichtiges Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? INSOBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt UV-pflichtiges Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int UVBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt Lohnsteuer laufend
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? LOHNSTEUER { get; set; }

        /// <summary>
        /// Holt oder setzt Solidaritätszuschlag laufend
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? SOLI { get; set; }

        /// <summary>
        /// Holt oder setzt Kirchensteuer laufend
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KIRCHENST { get; set; }

        /// <summary>
        /// Holt oder setzt KV-Beitrag AG ohne KVZusatzbeitrag
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYAG { get; set; }

        /// <summary>
        /// Holt oder setzt KV-Zusatzbeitrag AG aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYAGZUSATZ { get; set; }

        /// <summary>
        /// Holt oder setzt KV-Beitrag AN ohne KVZusatzbeitrag
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYAN { get; set; }

        /// <summary>
        /// Holt oder setzt KV-Zusatzbeitrag AN aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYANZUSATZ { get; set; }

        /// <summary>
        /// Holt oder setzt RV-Beitrag AG zur gesetzlichen Rentenversicherung aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVBYAG { get; set; }

        /// <summary>
        /// Holt oder setzt RV-Beitrag AN zur gesetzlichen Rentenversicherung aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVBYAN { get; set; }

        /// <summary>
        /// Holt oder setzt AV-Beitrag AG zur gesetzlichen Rentenversicherung aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBYAG { get; set; }

        /// <summary>
        /// Holt oder setzt AV-Beitrag AN zur gesetzlichen Rentenversicherung aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBYAN { get; set; }

        /// <summary>
        /// Holt oder setzt PV-Beitrag AG zur gesetzlichen Rentenversicherung aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBYAG { get; set; }

        /// <summary>
        /// Holt oder setzt PV-Beitrag AN zur gesetzlichen Rentenversicherung aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBYAN { get; set; }

        /// <summary>
        /// Holt oder setzt U1-Beitrag AG aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? U1BYAG { get; set; }

        /// <summary>
        /// Holt oder setzt U2-Beitrag AG aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? U2BYAG { get; set; }

        /// <summary>
        /// Holt oder setzt InsolvenzgeldumlageBeitrag AG aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? INSOBYAG { get; set; }

        /// <summary>
        /// Holt oder setzt Beitrag AG zur berufsständischen Versorgung aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? BVBYAG { get; set; }

        /// <summary>
        /// Holt oder setzt Beitrag AN zur berufsständischen Versorgung aus laufend gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? BVBYAN { get; set; }

        /// <summary>
        /// Holt oder setzt ungemindertes SV-Brutto (monatlich) aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? SVBRUTTOEGA { get; set; }

        /// <summary>
        /// Holt oder setzt Steuer-Brutto (monatlich) aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? STBRUTTOEGA { get; set; }

        /// <summary>
        /// Holt oder setzt Lohnsteuer aus sonstigen Bezügen
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? LOHNSTEUEREGA { get; set; }

        /// <summary>
        /// Holt oder setzt Solidaritätszuschlag aus sonstigen Bezügen
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? SOLIEGA { get; set; }

        /// <summary>
        /// Holt oder setzt Kirchensteuer aus sonstigen Bezügen
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KIRCHENSTEGA { get; set; }

        /// <summary>
        /// Holt oder setzt KV-pflichtiges, einmalig gezahltes Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBRUTTOEGA { get; set; }

        /// <summary>
        /// Holt oder setzt RV-pflichtiges, einmalig gezahltes Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVBRUTTOEGA { get; set; }

        /// <summary>
        /// Holt oder setzt AV-pflichtiges, einmalig gezahltes Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBRUTTOEGA { get; set; }

        /// <summary>
        /// Holt oder setzt PV-pflichtiges, einmalig gezahltes Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBRUTTOEGA { get; set; }

        /// <summary>
        /// Holt oder setzt Insolvenzgeldumlagepflichtiges, einmalig gezahltes Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? INSOBRUTTOEGA { get; set; }

        /// <summary>
        /// Holt oder setzt KV-Beitrag AG ohne KVZusatzbeitrag aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYAGEGA { get; set; }

        /// <summary>
        /// Holt oder setzt KV-Zusatzbeitrag AG aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYAGEGAZUSATZ { get; set; }

        /// <summary>
        /// Holt oder setzt KV-Beitrag AN ohne KVZusatzbeitrag aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYANEGA { get; set; }

        /// <summary>
        /// Holt oder setzt KV-Zusatzbeitrag AN aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYANEGAZUSATZ { get; set; }

        /// <summary>
        /// Holt oder setzt RV-Beitrag AG aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVBYAGEGA { get; set; }

        /// <summary>
        /// Holt oder setzt RV-Beitrag AN aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVBYANEGA { get; set; }

        /// <summary>
        /// Holt oder setzt AV-Beitrag AG aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBYAGEGA { get; set; }

        /// <summary>
        /// Holt oder setzt AV-Beitrag AN aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBYANEGA { get; set; }

        /// <summary>
        /// Holt oder setzt PV-Beitrag AG aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBYAGEGA { get; set; }

        /// <summary>
        /// Holt oder setzt PV-Beitrag AN aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBYANEGA { get; set; }

        /// <summary>
        /// Holt oder setzt Insolvenzgeldumlage-Beitrag aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? INSOBYAGEGA { get; set; }

        /// <summary>
        /// Holt oder setzt Beitrag AG zur berufsständischen Versorgung aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? BVBYAGEGA { get; set; }

        /// <summary>
        /// Holt oder setzt Beitrag AN zur berufsständischen Versorgung aus einmalig gezahltem Arbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? BVBYANEGA { get; set; }

        /// <summary>
        /// Holt oder setzt Hinzurechnungsbetrag
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? HINZUBTRG { get; set; }

        /// <summary>
        /// Holt oder setzt Resturlaub in Tagen (Vorjahr)
        /// </summary>
        /// <remarks>
        /// Länge 5 mit 2 NK, Kannangabe
        /// </remarks>
        public int? URLRESTVJ { get; set; }

        /// <summary>
        /// Holt oder setzt genommener Urlaub in Tagen (lfd. Jahr)
        /// </summary>
        /// <remarks>
        /// Länge 5 mit 2 NK, Kannangabe
        /// </remarks>
        public int? URLGENOM { get; set; }

        /// <summary>
        /// Holt oder setzt Resturlaub in Tagen
        /// </summary>
        /// <remarks>
        /// Länge 5 mit 2 NK, Kannangabe
        /// </remarks>
        public int? URLREST { get; set; }

        /// <summary>
        /// Holt oder setzt unbezahlter Urlaub in Tagen
        /// </summary>
        /// <remarks>
        /// Länge 5 mit 2 NK, Kannangabe
        /// </remarks>
        public int? URLUNBEZ { get; set; }

        /// <summary>
        /// Holt oder setzt Netto
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int NETTO { get; set; }

        /// <summary>
        /// Holt oder setzt Auszahlungsbetrag
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int ZAHLBTRG { get; set; }

        /// <summary>
        /// Holt oder setzt Anwesenheitstage (monatlich)
        /// </summary>
        /// <remarks>
        /// Länge 2, Kannangabe
        /// </remarks>
        public int? ANWESEND { get; set; }

        /// <summary>
        /// Holt oder setzt Fehltage (monatlich, unbezahlte Tage)
        /// </summary>
        /// <remarks>
        /// Länge 2, Kannangabe
        /// </remarks>
        public int? FEHL { get; set; }

        /// <summary>
        /// Holt oder setzt bezahlte Stunden (monatlich)
        /// </summary>
        /// <remarks>
        /// Länge 5 mit 2 NK, Kannangabe
        /// </remarks>
        public int? BEZSTD { get; set; }

        /// <summary>
        /// Holt oder setzt Krankheitstage (monatlich)
        /// </summary>
        /// <remarks>
        /// Länge 2, Kannangabe
        /// </remarks>
        public int? AU { get; set; }

        /// <summary>
        /// Holt oder setzt Krankheitsstunden (monatlich)
        /// </summary>
        /// <remarks>
        /// Länge 5 mit 2 NK, Kannangabe
        /// </remarks>
        public int? AUSTD { get; set; }

        /// <summary>
        /// Holt oder setzt Stunden mit Zeitlohn (monatlich)
        /// </summary>
        /// <remarks>
        /// Länge 5 mit 2 NK, Kannangabe
        /// </remarks>
        public int? ZEITLOHNSTD { get; set; }

        /// <summary>
        /// Holt oder setzt Überstunden (monatlich)
        /// </summary>
        /// <remarks>
        /// Länge 5 mit 2 NK, Mussangabe
        /// </remarks>
        public int UESTD { get; set; }

        /// <summary>
        /// Holt oder setzt Summe der Steuern nach dem Doppelbesteuerungsabkommen
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int DOPPELST { get; set; }

        /// <summary>
        /// Holt die Anzahl Lohnarten
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int ANLA
        {
            get => DSLAext?.Count ?? 0;

            // ReSharper disable once UnusedMember.Local
            // ReSharper disable once ValueParameterNotUsed
            private set { }
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Kurzarbeitergeld vorhanden ist
        /// </summary>
        /// <remarks>
        /// Kurzarbeitergeld vorhanden, Länge 1, Mussangabe
        /// N = keine Kurzarbeitergeld
        /// J = Kurzarbeitergeld vorhanden
        /// </remarks>
        public bool MMKG
        {
            get => _hatDbkg ?? DBKG != null;
            set => _hatDbkg = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Altersteilzeit vorhanden ist
        /// </summary>
        /// <remarks>
        /// Altersteilzeit vorhanden, Länge 1, Mussangabe
        /// N = keine Altersteilzeit
        /// J = Altersteilzeit vorhanden
        /// </remarks>
        public bool MMAT
        {
            get => _hatDbat ?? DBAT != null;
            set => _hatDbat = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Wertguthaben Ost vorhanden ist
        /// </summary>
        /// <remarks>
        /// Wertguthaben Ost vorhanden, Länge 1, Mussangabe
        /// N = keine Wertguthaben Ost
        /// J = Wertguthaben Ost vorhanden
        /// </remarks>
        public bool MMWO
        {
            get => _hatDbwo ?? DBWO != null;
            set => _hatDbwo = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Wertguthaben West vorhanden ist
        /// </summary>
        /// <remarks>
        /// Wertguthaben West vorhanden, Länge 1, Mussangabe
        /// N = keine Wertguthaben West
        /// J = Wertguthaben West vorhanden
        /// </remarks>
        public bool MMWW
        {
            get => _hatDbww ?? DBWW != null;
            set => _hatDbww = value;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob der Datenbaustein Seemännische Besonderheiten vorhanden ist
        /// </summary>
        /// <remarks>
        /// Seemännische Besonderheiten vorhanden, Länge 1, Mussangabe
        /// N = keine Seemännische Besonderheiten
        /// J = Seemännische Besonderheiten vorhanden
        /// </remarks>
        public bool MMS4
        {
            get => _hatDbs4 ?? DBS4 != null;
            set => _hatDbs4 = value;
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Vortragswerte
        /// </summary>
        public DBVT04 DBVT
        {
            get => ListeDBVT?.SingleOrDefault();
            set
            {
                ListeDBVT = ListeDBVT.Set(value);
                _hatDbvt = null;
            }
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Kurzarbeitergeld
        /// </summary>
        public DBKG04 DBKG
        {
            get => ListeDBKG?.SingleOrDefault();
            set
            {
                ListeDBKG = ListeDBKG.Set(value);
                _hatDbkg = null;
            }
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Altersteilzeit
        /// </summary>
        public DBAT04 DBAT
        {
            get => ListeDBAT?.SingleOrDefault();
            set
            {
                ListeDBAT = ListeDBAT.Set(value);
                _hatDbat = null;
            }
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Wertguthaben Ost
        /// </summary>
        public DBWO04 DBWO
        {
            get => ListeDBWO?.SingleOrDefault();
            set
            {
                ListeDBWO = ListeDBWO.Set(value);
                _hatDbwo = null;
            }
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Wertguthaben West
        /// </summary>
        public DBWW04 DBWW
        {
            get => ListeDBWW?.SingleOrDefault();
            set
            {
                ListeDBWW = ListeDBWW.Set(value);
                _hatDbww = null;
            }
        }

        /// <summary>
        /// Holt oder setzt Datenbaustein Seemännische Besonderheiten
        /// </summary>
        public DBS404 DBS4
        {
            get => ListeDBS4?.SingleOrDefault();
            set
            {
                ListeDBS4 = ListeDBS4.Set(value);
                _hatDbs4 = null;
            }
        }

        /// <summary>
        /// Holt oder setzt eine Liste von Lohnarten
        /// </summary>
        public IList<DSLAext04> DSLAext { get; set; }

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
                foreach (var datenbaustein in ListExtensions.Enumerate(ListeDBVT, ListeDBKG, ListeDBAT, ListeDBWO, ListeDBWW, ListeDBS4, DBFE))
                    yield return datenbaustein;
            }
        }

        private IList<DBVT04> ListeDBVT { get; set; }

        private IList<DBKG04> ListeDBKG { get; set; }

        private IList<DBAT04> ListeDBAT { get; set; }

        private IList<DBWO04> ListeDBWO { get; set; }

        private IList<DBWW04> ListeDBWW { get; set; }

        private IList<DBS404> ListeDBS4 { get; set; }
    }
}
