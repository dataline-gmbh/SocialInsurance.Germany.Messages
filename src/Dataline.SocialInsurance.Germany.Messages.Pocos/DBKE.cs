// <copyright file="DBKE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBKE - Kündigung/Entlassung
    /// </summary>
    public class DBKE : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBKE"/> Klasse
        /// </summary>
        public DBKE()
        {
            KE = "DBKE";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Arbeitsverhältnisses
        /// </summary>
        /// <remarks>
        /// Ende des Arbeitsverhältnisses am, Länge 8, Mussangabe
        /// (d.h. "Kündigung zum" oder "Ende des befristeten Arbeitsverhältnisses
        /// am oder bei Ausbildungsverhältnissen das tatsächliche Ende")
        /// </remarks>
        public LocalDate AVEND { get; set; }

        /// <summary>
        /// Holt oder setzt, ob es sich umn ein befristetes Arbeitsverhältnis hält
        /// </summary>
        /// <remarks>
        /// Handelt es sich um ein befristetes Arbeitsverhältnis? Länge 1, Mussangabe
        /// J = ja, N = nein
        /// </remarks>
        public string AVBFR { get; set; }

        /// <summary>
        /// Holt oder setzt, ob der befristete Arbeitsvertrag schriftlich abgeschlossen wurde
        /// </summary>
        /// <remarks>
        /// Der befristete Arbeitsvertrag wurde schriftlich abgeschlossen, Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string AVBFSCHR { get; set; }

        /// <summary>
        /// Holt oder setzt die bei Abschluss des Arbeitsvertrages befristete Zeit
        /// </summary>
        /// <remarks>
        /// Das Arbeitsverhältnis war bei Abschluss des Arbeitsvertrages befristet zum, Länge 8, Mussangabe
        /// </remarks>
        public int AVBFURSP { get; set; }

        /// <summary>
        /// Holt oder setzt den Abschluss des befristeten Arbeitsvertrag
        /// </summary>
        /// <remarks>
        /// Der befristete Arbeitsvertrag wurde abgeschlossen am, Länge 8, Mussangabe
        /// </remarks>
        public int AVBFABSCHL { get; set; }

        /// <summary>
        /// Holt oder setzt die letzte Verlängerung des befristeten Arbeitsvertrags
        /// </summary>
        /// <remarks>
        /// Der befristete Arbeitsvertrag wurde zuletzt verlängert am, Länge 8, Mussangabe
        /// </remarks>
        public int AVBFABVL { get; set; }

        /// <summary>
        /// Holt oder setzt, ob das befristete Arbeitsverhältnis für mind. 2 Monate vorgesehen war
        /// </summary>
        /// <remarks>
        /// Das befristete Arbeitsverhältnis war für mind. 2 Monate vorgesehen, Länge 1, Mussangabe unter Bedingungen
        /// eine Möglichkeit der Weiterbeschäftigung wurde durch den Arbeitgeber bei Abschluss des Vertrags in Aussicht gestellt.
        /// </remarks>
        public string AVBFRL { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Entlassung/Kündigung des Arbeitsverhältnisses oder Abschluss des Aufhebungsvertrags
        /// </summary>
        /// <remarks>
        /// Entlassung / Kündigung des Arbeitsverhältnisses oder Abschluss des Aufhebungsvertrages am, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate? AVKUEAM { get; set; }

        /// <summary>
        /// Holt oder setzt, ob es sich um eine unwiderrufliche Freistellung mit Weiterzahlung des Arbeitsentgelts handelt
        /// </summary>
        /// <remarks>
        /// Es handelt sich um eine unwiderrufliche Freistellung durch den Arbeitgeber mit tatsächlicher Weiterzahlung des Arbeitsentgeltes
        /// J = ja, N = nein
        /// </remarks>
        public string AVUWFWZ { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum des Beginns der unwiderruflichen Freistellung mit Weiterzahlung des Arbeitsentgelts
        /// </summary>
        /// <remarks>
        /// Datum des Beginns der unwiderruflichen Freistellung durch den Arbeitgeber, Länge 8, Mussangabe
        /// mit tatsächlicher Weiterzahlung des Arbeitsentgeltes
        /// </remarks>
        public LocalDate AVUWFWZBEG { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum des Endes der unwiderruflichen Freistellung mit Weiterzahlung des Arbeitsentgelts
        /// </summary>
        /// <remarks>
        /// Datum des Endes der unwiderruflichen Freistellung durch den Arbeitgeber, Länge 8, Mussangabe
        /// mit tatsächlicher Weiterzahlung des Arbeitsentgeltes
        /// </remarks>
        public LocalDate AVUWFWZEND { get; set; }

        /// <summary>
        /// Holt oder setzt den Monat für den die letzte volsst#ndige Entgeltabrechnung durchgeführt wurde
        /// </summary>
        /// <remarks>
        /// Monat für den die letzte vollständige Entgeltabrechnung (Rechnungslauf) vor dem Ende des Beschäftigungsverhältnisses durchgeführt wurde, Länge 6, Mussangabe
        /// (d.h. für den standardmäßig keine Änderungsdatensätze mehr zu erwarten sind)
        /// </remarks>
        public int AVLETZTRL { get; set; }

        /// <summary>
        /// Holt oder setzt, wodurch die Entlassung/Kündigung des Arbeitsverhältnisses verursacht wurde
        /// </summary>
        /// <remarks>
        /// Entlassung / Kündigung des Arbeitsverhältnisses, Länge 1, Mussangabe
        /// 1 = durch den Arbeitgeber 2 = durch den Arbeitnehmer, Arbeitgeber hätte ansonsten nicht zum selben Zeitpunkt gekündigt
        /// 3 = durch den Arbeitnehmer, Arbeitgeber hätte ansonsten zum selben Zeitpunkt gekündigt
        /// 4 = durch einen Aufhebungsvertrag, Arbeitgeber hätte ansonsten nicht zum selben Zeitpunkt gekündigt
        /// 5 = durch einen Aufhebungsvertrag, Arbeitgeber hätte ansonsten zum selben Zeitpunkt gekündigt
        /// </remarks>
        public int AVKUEDU { get; set; }

        /// <summary>
        /// Holt oder setzt, ob die Entlassung/Kündigung des Arbeitsverhältnisses durch den Arbeitgeber schriftlich erfolgte
        /// </summary>
        /// <remarks>
        /// Wenn es sich um eine Entlassung / Kündigung des Arbeitsverhältnisses durch den Arbeitgeber handelt, erfolgte sie schriftlich?, Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string AVKUESCH { get; set; }

        /// <summary>
        /// Holt oder setzt, ob es sich um eine betriebsbedingte Kündigung hält
        /// </summary>
        /// <remarks>
        /// Handelt es sich um eine betriebsbedingte Kündigung gem. § 1a KSchG bzw. hätte der Arbeitgeber betriebsbedingt
        /// gekündigt, wenn er die Kündigung ausgesprochen hätte? Länge 1, Mussangabe
        /// J = ja, N = nein
        /// </remarks>
        public string AVKUEBETR { get; set; }

        /// <summary>
        /// Holt oder setzt, ob vom Arbeitnehmer eine Kündigungsschutzklage erhoben wurde
        /// </summary>
        /// <remarks>
        /// Wurde vom Arbeitnehmer Kündigungsschutzklage gem. § 4 KSchG erhoben? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein, U = unbekannt
        /// </remarks>
        public string AVKUESCHUKL { get; set; }

        /// <summary>
        /// Holt oder setzt, wie die Kündigung zugestellt wurde
        /// </summary>
        /// <remarks>
        /// Wie wurde die Kündigung zugestellt? Länge 1, Mussangabe
        /// 1 = persönlich, 2 = per Post
        /// </remarks>
        public int AVKUEZUST { get; set; }

        /// <summary>
        /// Holt oder setzt, ob die Kündigung wegen vertragswidrigem Verhalten des Arbeitnehmers erfolgt ist
        /// </summary>
        /// <remarks>
        /// Wenn Entlassung/Kündigung des Arbeitsverhältnis durch Arbeitgeber erfolgte oder
        /// erfolgt wäre, erfolgte sie wegen vertragswidrigem Verhalten des Arbeitnehmers? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string AVKUEAL { get; set; }

        /// <summary>
        /// Holt oder setzt, ob bei Kündigung durch den Arbeitgeber eine Abmahnung bei vertragswidrigem Verhalten erfolgt ist
        /// </summary>
        /// <remarks>
        /// Wenn Kündigung des Arbeitsverhältnisses durch Arbeitgeber wegen vertragswidrigem
        /// Verhalten erfolgte, war deshalb bereits eine Abmahnung erfolgt? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string AVKUEALAM { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der vorherigen Abmahnung
        /// </summary>
        /// <remarks>
        /// Datum der vorherigen Abmahnung, Länge 8, Mussangabe
        /// </remarks>
        public int AVAMDAT { get; set; }

        /// <summary>
        /// Holt oder setzt die Schilderung des vertragswidrigen Verhaltens, bei Kündigung
        /// </summary>
        /// <remarks>
        /// Schilderung des vertragswidrigen Verhaltens, das Anlass der Kündigung / Entlassung war (Freitext), Länge 255, Kannangabe
        /// </remarks>
        public string VWIVER { get; set; }

        /// <summary>
        /// Holt oder setzt, ob vor und/oder nach der Kündigung getroffene Vereinbarungen existieren
        /// </summary>
        /// <remarks>
        /// Existieren zusätzlich vor und / oder nach der Kündigung getroffeneVereinbarungen? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string AVKUEZVB { get; set; }

        /// <summary>
        /// Holt oder setzt, ob eine Sozialauswahl vorgenommen wurde
        /// </summary>
        /// <remarks>
        /// Wurde eine Sozialauswahl vorgenommen? Länge 1, Mussangabe
        /// 1 = ja, 2 = nein ,3 = entfällt, weil personenbedingte Entlassung/Kündigung
        /// </remarks>
        public int SAW { get; set; }

        /// <summary>
        /// Holt oder setzt, welche Arbeitsagentur die Sozialauswahl geprüft hat
        /// </summary>
        /// <remarks>
        /// Wenn die Sozialauswahl von einer Arbeitsagentur geprüft wurde: Welche Arbeitsagentur hat geprüft? (Freitext), Länge 30, Kannangabe
        /// </remarks>
        public string SAWPRNA { get; set; }

        /// <summary>
        /// Holt oder setzt den Termin der Kündigung, an welchem der Arbeitgeber sie ausgesprochen hat
        /// </summary>
        /// <remarks>
        /// Wenn der Arbeitgeber die Kündigung ausgesprochen hätte, wäre die Kündigung am folgenden Termin ausgesprochen worden, Länge 8, Mussangabe
        /// </remarks>
        public int AGKUEAM { get; set; }

        /// <summary>
        /// Holt oder setzt den Termin der Kündigung, zu welchem der Arbeitgeber sie ausgesprochen hat
        /// </summary>
        /// <remarks>
        /// Wenn der Arbeitgeber die Kündigung ausgesprochen hätte, wäre die Kündigung zum folgenden Termin ausgesprochen worden, Länge 8, Mussangabe
        /// </remarks>
        public int AGKUEZU { get; set; }

        /// <summary>
        /// Holt oder setzt die maßgebende Kündigungsfrist des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// die maßgebende (gesetzl., tarifvertragl., vertragl.) Kündigungsfrist des Arbeitgebers, Länge 3, Mussangabe
        /// (Zahlenwert bezogen auf die Zeiteinheit in KFZE)
        /// </remarks>
        public int KF { get; set; }

        /// <summary>
        /// Holt oder setzt die Zeiteinheit, in der die Kündigungsfrist angegeben wurde
        /// </summary>
        /// <remarks>
        /// Zeiteinheit, in der die Kündigungsfrist angegeben wurde, Länge 1, Mussangabe
        /// 1 = Kalendertage, 2 = Werktage, 3 = Wochen, 4 = Monate
        /// </remarks>
        public int KFZE { get; set; }

        /// <summary>
        /// Holt oder setzt die Terminierung der Kündigungsfrist
        /// </summary>
        /// <remarks>
        /// Terminierung der Kündigungsfrist, Länge 1, Mussangabe
        /// 1 = zum Ende der Woche, 2 = zum 15. des Monats, 3 = zum Monatsende
        /// 4 = zum Ende des Vierteljahres, 5 = ohne festes Ende
        /// </remarks>
        public int KFBZ { get; set; }

        /// <summary>
        /// Holt oder setzt, ob die Kündigung durch den Arbeitgeber gesetzlich oder tarifvertraglich ausgeschlossen wurde
        /// </summary>
        /// <remarks>
        /// Ist die ordentliche Kündigung des Arbeitsverhältnis durch den Arbeitgeber/Auftraggeber/Zwischenmeister
        /// gesetzlich oder tarifvertraglich ausgeschlossen? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string KA { get; set; }

        /// <summary>
        /// Holt oder setzt, ob die Kündigung zeitlich unbegrenzt ausgeschlossen ist
        /// </summary>
        /// <remarks>
        /// Die ordentliche Kündigung ist zeitlich unbegrenzt ausgeschlossen, Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string KAU { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund für die fristgebundene Kündigung, obwohl die ordentliche Kündigung zeitlich unbegrenzt ausgeschlossen war
        /// </summary>
        /// <remarks>
        /// Grund für die fristgebundene Kündigung aus wichtigem Grund, Länge 30, Mussangabe unter Bedingungen
        /// obwohl die ordentliche Kündigung zeitlich unbegrenzt ausgeschlossen war (Freitext)
        /// </remarks>
        public string KAUAUG { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund für den zeitlich begrenzeten Ausschluss der Kündigung
        /// </summary>
        /// <remarks>
        /// Grund für zeitlich begrenzten Ausschluss der Kündigung (Freitext), Mussangabe unter Bedingungen
        /// </remarks>
        public string KABGG { get; set; }

        /// <summary>
        /// Holt oder setzt, ob die Kündigung nur bei Abfindung, Entschädigung oder ähnlichen Leistungen zulässig ist
        /// </summary>
        /// <remarks>
        /// Ist die ordentliche Kündigung (tarif-) vertraglich nur bei einer Abfindung,
        /// Entschädigung oder ähnlichen Leistungen zulässig? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string OKGL { get; set; }

        /// <summary>
        /// Holt oder setzt, ob die Vorraussetzungen für eine fristgebundene Kündigung aus wichtigem Ground vorliegen
        /// </summary>
        /// <remarks>
        /// Liegen gleichzeitig die Voraussetzungen für eine fristgebundene Kündigung aus wichtigem
        /// Grund vor oder wären diese ohne besondere (tarif-) vertragliche Kündigung gegeben gewesen? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string OKGLFG { get; set; }

        /// <summary>
        /// Holt oder setzt, ob die Zahlungen von Leistungen bei Beendigung des Arbeitsverhältnisses erfolgen
        /// </summary>
        /// <remarks>
        /// Erfolgen Zahlungen von Leistungen oder besteht ein Anspruch auf Leistungen im Zusammenhang
        /// mit der Beendigung des Arbeitsverhältnisses bzw. Heimarbeitsverhältnisses? Länge 1, Mussangabe
        /// 1 = ja, 2 = nein, 3 = ungewiss
        /// </remarks>
        public int AVENLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund, wenn Leistungsanspruch ungewiss ist
        /// </summary>
        /// <remarks>
        /// Grund, wenn Leistungsanspruch wie in der Variablen "Leistungszahlung bei
        /// Beendigung des Arbeitsverhältnisses" ungewiss ist (Freitext), Länge 30, Mussangabe unter Bedingungen
        /// </remarks>
        public string AVENLZG { get; set; }

        /// <summary>
        /// Holt oder setzt, ob das Arbeitsentgelt über das Arbeitsverhältnis hinaus gezahlt wird
        /// </summary>
        /// <remarks>
        /// Wird das Arbeitsentgelt über das Arbeitsverhältnis hinaus gezahlt?
        /// J = ja, N = nein, U = ungewiss
        /// </remarks>
        public string BVEGEN { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum, bis zu welchem das Arbeitsentgelt gezahlt wird
        /// </summary>
        /// <remarks>
        /// Arbeitsentgelt wird über das Arbeitsverhältnis hinaus gezahlt bis zum, Länge 8, Mussangabe
        /// </remarks>
        public int BVEGENB { get; set; }

        /// <summary>
        /// Holt oder setzt, ob eine Urlaubsabgeltung wegen der Beendigung des Arbeitsverhältnisses gezahlt wurde
        /// </summary>
        /// <remarks>
        /// Wurde eine Urlaubsabgeltung wegen der Beendigung des Arbeitsverhältnisses gezahlt? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string AVENUAG { get; set; }

        /// <summary>
        /// Holt oder setzt die Dauer des Urlaubs bei Inanspruchnahme im Anschluss an das Arbeitsverhältnis
        /// </summary>
        /// <remarks>
        /// Bei Inanspruchnahme des Urlaubs im Anschluss an das Arbeitsverhältnis betrüge seine
        /// Dauer nach den gesetzlichen / (tarif-) vertraglichen Bestimmungen, Länge 8, Mussangabe
        /// </remarks>
        public int BVENUR { get; set; }

        /// <summary>
        /// Holt oder setzt, ob eine Vorruhestandsleistung oder vergleichbare Leistung bei Beendigung des Arbeitsverhältnisses erfolgt
        /// </summary>
        /// <remarks>
        /// Erfolgt eine Vorruhestandsleistung oder vergleichbare Leistung
        /// bei Beendigung des Arbeitsverhältnisses? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string AVENVL { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn der Vorruhestandsgeldzahlung bei Beendigung des Arbeitsverhältnisses
        /// </summary>
        /// <remarks>
        /// Beginn der Vorruhestandsgeldzahlung bei Beendigung des Arbeitsverhältnisses, Länge 8, Mussangabe
        /// </remarks>
        public int AVENVGB { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorruhestandsgeld bei Beendigung des Arbeitsverhältnisses
        /// </summary>
        /// <remarks>
        /// Vorruhestandsgeld bei Beendigung des Arbeitsverhältnisses
        /// in v.H. des Bruttoarbeitsentgelts, Länge 5, Mussangabe
        /// </remarks>
        public int AVENVG { get; set; }

        /// <summary>
        /// Holt oder setzt, ob bei Kündigung die Abfindung bis zu 0,5 Monatsentgelte beträgt
        /// </summary>
        /// <remarks>
        /// Bei Kündigung nach §1a KSchG: Beträgt die Abfindung bis zu 0,5
        /// Monatsentgelte für jedes Beschäftigungsjahr? Länge 1, Kannangabe
        /// J = ja, N = nein
        /// </remarks>
        public string ABFMONAT { get; set; }

        /// <summary>
        /// Holt oder setzt, ob die Abfindung auch gezahlt worden wäre, wenn die Kündigung durch den Arbeitgeber erfolgt wäre
        /// </summary>
        /// <remarks>
        /// Wäre die Abfindung auch gezahlt worden, wenn die Kündigung
        /// durch den Arbeitgeber erfolgt wäre? Länge 1, Mussangabe unter Bedingungen
        /// J = ja, N = nein
        /// </remarks>
        public string ABFGEZ { get; set; }
    }
}
