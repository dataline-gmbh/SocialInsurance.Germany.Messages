// <copyright file="DBLT.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Zusatzdaten für die Berechnung des Übergangsgeldes bei Leistungen zur Teilhabe
    /// </summary>
    public class DBLT : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBLT"/>-Objekt.
        /// </summary>
        public DBLT()
        {
            KE = "DBLT";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Beginn des Beschäftigungsverhältnisses.
        /// </summary>
        public LocalDate? BVSEIT { get; set; }

        /// <summary>
        /// Holt oder setzt, bis wann der Arbeitnehmer beschäftigt ist.
        /// </summary>
        public LocalDate? BVBIS { get; set; }

        /// <summary>
        /// Holt oder setzt, als was der Arbeitnehmer beschäftigt ist.
        /// </summary>
        public string BVALS { get; set; }

        /// <summary>
        /// Holt oder setzt, ob es sich um ein Ausbildungsverhältnis handelt.
        /// </summary>
        public bool AUSBVERH { get; set; }

        /// <summary>
        /// Holt oder setzt, ob aufgrund von Vorerkrankungen für weniger als 6 Wochen Entgeltfortzahlung besteht.
        /// </summary>
        public bool? VORER { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der ersten anrechenbaren Vorerkrankungszeit.
        /// </summary>
        /// <value>Ein Datum, <see langword="null"/> als Grundstellung, oder 99999999, wenn die Erkrankung noch andauert.</value>
        public LocalDate? VORERBEGINN1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende der ersten anrechenbaren Vorerkrankungszeit.
        /// </summary>
        /// <value>Ein Datum, <see langword="null"/> als Grundstellung, oder 99999999, wenn die Erkrankung noch andauert.</value>
        public LocalDate? VORERENDE1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der zweiten anrechenbaren Vorerkrankungszeit.
        /// </summary>
        public LocalDate? VORERBEGINN2 { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende der zweiten anrechenbaren Vorerkrankungszeit.
        /// </summary>
        public LocalDate? VORERENDE2 { get; set; }

        /// <summary>
        /// Holt oder setzt das monatliche Arbeitsentgelt für eine Vollzeitbeschäftigung
        /// im Kalendermonat vor Beginn der Leistung (ohne außertarifliche Zahlungen).
        /// </summary>
        public int AEBMZRMONAT { get; set; }

        /// <summary>
        /// Holt oder setzt das stündliche Arbeitsentgelt für eine Vollzeitbeschäftigung
        /// im Kalendermonat vor Beginn der Leistung (ohne außertarifliche Zahlungen).
        /// </summary>
        public int AEBMZRSTUEND { get; set; }

        /// <summary>
        /// Holt oder setzt die tarifvertraglich vereinbarte wöchentliche Arbeitszeit.
        /// </summary>
        public int WOECHAZTARIF { get; set; }

        /// <summary>
        /// Holt oder setzt, von wann der derzeit gültige Tarifvertrag ist.
        /// </summary>
        public LocalDate? TARIFVERTRAGVOM { get; set; }

        /// <summary>
        /// Holt oder setzt die maßgebende Tarifgemeinschaft oder den maßgebenden Tarifvertrag.
        /// </summary>
        public string ANGABETARIFGEMEINSCHAFT { get; set; }

        /// <summary>
        /// Holt oder setzt die/den maßgebende(n) Tarifgemeinschaft/-vertrag.
        /// </summary>
        /// <value>1 = Tarif West, 2 = Tarif Ost, 3 = nach ortsüblichem Arbeitsentgelt, 4 = keine Angaben möglich</value>
        public int MMTARIFVERTRAG { get; set; }

        /// <summary>
        /// Holt oder setzt die Vergütungs-/Lohngruppe.
        /// </summary>
        public string VERGUETGRUPPE { get; set; }

        /// <summary>
        /// Holt oder setzt die tarifvertraglich geregelten monatlichen vermögenswirksamen Leistungen des Arbeitgebers.
        /// </summary>
        public int VWLMONATLICH { get; set; }

        /// <summary>
        /// Holt oder setzt eine tarifvertraglich geregelte Einmalzahlunge (Weihnachtsgeld, Urlaubsgeld, usw.)
        /// </summary>
        public int EZTARIF { get; set; }

        /// <summary>
        /// Holt oder setzt die während der LT weitergezahlten vermögenswirksamen Leistungen (monatl. Betrag).
        /// </summary>
        public int VWL { get; set; }

        /// <summary>
        /// Holt oder setzt die während der LT weitergezahlten Sachbezüge und Teilarbeitsentgelte (monatl. Gesamtbetrag brutto).
        /// </summary>
        public int BRUTTOSB { get; set; }

        /// <summary>
        /// Holt oder setzt die während der LT weitergezahlten Sachbezüge und Teilarbeitsentgelte (monatl. Gesamtbetrag netto).
        /// </summary>
        public int NETTOSB { get; set; }

        /// <summary>
        /// Holt oder setzt den Verzicht auf Beitragsfreiheit bei geringfügiger Beschäftigung.
        /// </summary>
        public bool? MMVERZICHTBEITRAGSFREI { get; set; }

        /// <summary>
        /// Holt oder setzt, ob Arbeitsentgelt in der Gleitzone liegt.
        /// </summary>
        public bool? AEGLEITZONE { get; set; }

        /// <summary>
        /// Holt oder setzt den Verzicht auf Beitagsminderung in der RV bei Anwendung der Gleitzone.
        /// </summary>
        public bool? MMVERZICHTBEITRGLEITZONE { get; set; }

        /// <summary>
        /// Holt oder setzt den Rechtskreis.
        /// </summary>
        /// <value>W oder O.</value>
        public string RECHTSKREIS { get; set; }

        /// <summary>
        /// Holt oder setzt, ob das Arbeitsentgelt mindestens den tariflichen Bestimmungen entspricht.
        /// </summary>
        /// <value>J = ja, N = nein, U = unbekannt</value>
        public string AETARIFBEST { get; set; }
    }
}
