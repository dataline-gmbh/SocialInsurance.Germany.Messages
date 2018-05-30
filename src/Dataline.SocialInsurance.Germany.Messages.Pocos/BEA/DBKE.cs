// <copyright file="DBKE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Kündigung/Entlassung
    /// </summary>
    public class DBKE : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBKE";

        /// <summary>
        /// Holt oder setzt, wann das Arbeitsverhältnis beendet wurde ("Kündigung zum"
        /// oder "Ende des befristeten Arbeitsverhältnisses am", oder bei Ausbildungsverhältnissen
        /// das tatsächliche Ende).
        /// </summary>
        public LocalDate? AVEND { get; set; }

        /// <summary>
        /// Holt oder setzt, wann das Beschäftigungsverhältnis endet.
        /// </summary>
        public LocalDate BVEND { get; set; }

        /// <summary>
        /// Holt oder setzt, ob es sich um ein befristetes Arbeitsverhältnis handelt.
        /// </summary>
        /// <value>J = Ja, N = Nein, Z = Zweckbefristung</value>
        public string AVBFR { get; set; }

        /// <summary>
        /// Holt oder setzt, ob der befristetet Arbeitsvertrag schriftlich abgeschlossen wurde.
        /// </summary>
        public bool? AVBFSCHR { get; set; }

        /// <summary>
        /// Holt oder setzt, zu wann das Arbeitsverhältnis bei Vertragsabschluss befristet war.
        /// </summary>
        public LocalDate? AVBFURSP { get; set; }

        /// <summary>
        /// Holt oder setzt, wann der befristete Arbeitsvertrag abgeschlossen wurde.
        /// </summary>
        public LocalDate? AVBFABSCHL { get; set; }

        /// <summary>
        /// Holt oder setzt, ob der befristete Arbeitsvertrag verlängert wurde.
        /// </summary>
        public bool? VLBAV { get; set; }

        /// <summary>
        /// Der befristete Arbeitsverhältnis wurde zuletzt verlängert am...
        /// </summary>
        public LocalDate? AVBFABVL { get; set; }

        /// <summary>
        /// Das befristete Arbeitsverhältnis war für mind. 2 Monate vorgesehen und eine Möglichkeit
        /// der Weiterbeschäftigung wurde durch den Arbeitgeber bei Abschluss des Vertrags in Aussicht gestellt.
        /// </summary>
        public bool? AVBFRL { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Beendigung des Arbeitsverhältnisses oder des Abschlusses des Aufhebungsvertrags.
        /// </summary>
        public LocalDate? AVKUEAM { get; set; }

        /// <summary>
        /// Holt oder setzt im Fall einer unwiderruflichen Freistellung durch den AG mit tatsächlicher
        /// Weiterzahlung des Arbeitsentgelts, ob die Freistellung einvernehmlich erfolgte.
        /// </summary>
        public bool? AVUWFWZ { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum des Beginns der unwiderruflichen Freistellung.
        /// </summary>
        public LocalDate? AVUWFWZBEG { get; set; }

        /// <summary>
        /// Monat, für den die letzte vollständige Entgeltabrechnung (Rechnungslauf) vor dem Ende des
        /// Beschäftigungsverhältnisses durchgeführt wurde (d.h. standardmäßig keine Änderung mehr zu erwarten ist).
        /// </summary>
        public LocalDate AVLETZTRL { get; set; }

        /// <summary>
        /// Holt oder setzt, durch wen oder was die Kündigung erfolgte.
        /// </summary>
        public KuendigungDurch? AVKUEDU { get; set; }

        /// <summary>
        /// Holt oder setzt, ob die Kündigung schriftlich erfolgte, wenn sie durch den Arbeitgeber erfolgte.
        /// </summary>
        public bool? AVKUESCH { get; set; }

        /// <summary>
        /// Holt oder setzt, ob es sich um eine betriebsbedingte Kündigung mit Abfindungsangebot gem. § 1a KSchG handelt.
        /// </summary>
        public bool? AVKUEBETR { get; set; }

        /// <summary>
        /// Holt oder setzt, ob vom AN Kündigungsschutzklage erhoben wurde.
        /// </summary>
        /// <value>J = Ja, N = Nein, U = Ungewiss</value>
        public string AVKUESCHUKL { get; set; }

        /// <summary>
        /// Holt oder setzt, wie die Kündigung zugestellt wurde.
        /// </summary>
        /// <value>1 = persönlich, 2 = nicht persönlich/postalisch</value>
        public int? AVKUEZUST { get; set; }

        /// <summary>
        /// Wenn die Kündigung des Arbeitsverhältnisses durch den AG erfolgte o. erfolgt wäre, erfolgte sie wegen vertragswidrigen Verhalten des AN?
        /// </summary>
        public bool? AVKUEAL { get; set; }

        /// <summary>
        /// Wenn die Kündigung des Arbeitsverhältnisses durch den AG wegen vertragswidrigen Verhaltens erfolgte, war bereits eine Abmahnung wegen desselben Verhaltens erfolgt?
        /// </summary>
        public bool? AVKUEALAM { get; set; }

        /// <summary>
        /// Datum der (vorherigen) Abmahnung.
        /// </summary>
        public LocalDate? AVAMDAT { get; set; }

        /// <summary>
        /// Holt oder setzt, ob zusätzlich vor und/oder nach der Kündigung getroffene Vereinbarungen existieren.
        /// </summary>
        public bool? AVKUEZVB { get; set; }

        /// <summary>
        /// Wurde eine Sozialauswahl vorgenommen?
        /// </summary>
        /// <value>J = Ja, N = Nein, E = Entfällt (personenbezogene Kündigung)</value>
        public string SAW { get; set; }

        /// <summary>
        /// Wenn die Sozialauswahl von der Arbeitsagentur geprüft wurde, ist der Schlüssel der jeweiligen AA einzutragen.
        /// </summary>
        /// <remarks>3 Stelllen</remarks>
        public string SAWPRSC { get; set; }

        /// <summary>
        /// Wenn der Arbeitgeber die Kündigung ausgesprochen hätte, wäre die Kündigung an diesem Termin ausgesprochen worden.
        /// </summary>
        public LocalDate? AGKUEAM { get; set; }

        /// <summary>
        /// Wenn der Arbeitgeber die Kündigung ausgesprochen hätte, wäre die Kündigung zu diesem Termin ausgesprochen worden.
        /// </summary>
        public LocalDate? AGKUEZU { get; set; }

        /// <summary>
        /// Die maßgebende (gesetzl./tarifvertr./vertr.) Kündigungsfrist des AG.
        /// Zahlenwerte bezogen auf die Zeiteinjheit in <see cref="KFZE"/>.
        /// </summary>
        public int KF { get; set; }

        /// <summary>
        /// Zeiteinheit, in der die Kündigungsfrist angegeben wurde.
        /// </summary>
        /// <value>1 = Kalendertage, 2 = Werktage, 3 = Wochen, 4 = Monate</value>
        public int KFZE { get; set; }

        /// <summary>
        /// Terminierung der Kündigungsfrist.
        /// </summary>
        /// <value>
        /// 1 = zum Ende der Woche, 2 = zum 15. des Monats, 3 = zum Monatsende, 4 = zum Ende des Vierteljahres,
        /// 5 = zum Ende des Halbjahres, 6 = zum Jahresschluss, 7 = ohne festes Ende
        /// </value>
        public int KFBZ { get; set; }

        /// <summary>
        /// Ist die ordentliche Kündigung des Arbeitsverhältnisses durch den Arbeitgeber/Auftraggeber/Zwischenmeister
        /// gesetzlich oder (tarif-)vertraglich ausgeschlossen?
        /// </summary>
        public bool? KA { get; set; }

        /// <summary>
        /// Ist die ordentliche Kündigung zeitlich unbegrenzt ausgeschlossen?
        /// </summary>
        public bool? KAU { get; set; }

        /// <summary>
        /// Wurde die fristgebundene Kündigung aus wichtigem Grund ausgesprochen,
        /// obwohl die ordentliche Kündigung zeitlich unbegrenzt ausgeschlossen war?
        /// </summary>
        public bool? KAUAUG { get; set; }

        /// <summary>
        /// Ist die ordentliche Kündigung (tarif-)vertraglich nur bei einer Abfindung, Entschädigung oder ähnlichen Leistungen zulässig?
        /// </summary>
        public bool? OKGL { get; set; }

        /// <summary>
        /// Liegen gleichzeitig die Voraussetzungen für eine fristgebundene Kündigung aus wichtigem Grund vor
        /// oder wären diese ohne besondere (tarif-)vertragliche Kündigungsregelung gegeben gewesen?
        /// </summary>
        public bool? OKGLFG { get; set; }

        /// <summary>
        /// Erfolgt die Zahlung einer Entlassungsentschädigung (Abfindung, Entschädigung oder ähnliche Leistung) oder besteht
        /// ein Anspruch auf Leistungen im Zusammenhang mit der Beendigung des Arbeits- bzw. Beschäftigungsverhältnisses bzw. Heimarbeitsverhältnisses?
        /// </summary>
        /// <value>J = Ja, N = Nein, U = Ungewiss</value>
        public string AVENLZ { get; set; }

        /// <summary>
        /// Grund für Ungewissheit auf Leistungszahlung (nur angeben, wenn <see cref="AVENLZ"/> = U).
        /// </summary>
        /// <value> 1 = Entgeltanspruch streitig, 2 = Entgeltanspruch unklar, 3 = Abrechnung noch nicht abgeschlossen, 4 = Sonstiges</value>
        public int AVENLZG { get; set; }

        /// <summary>
        /// Wurde eine Entlassungsentschädigung wegen der Beendigung des Arbeitsverhältnisses gezahlt?
        /// </summary>
        /// <value>J = Ja, N = Nein, U = Ungewiss</value>
        public string ABF { get; set; }

        /// <summary>
        /// Höhe der Entlassungsentschädigung (brutto)
        /// </summary>
        /// <value>2 Nachkommastellen</value>
        public long ABFHOE { get; set; }

        /// <summary>
        /// Dauer der Betriebs- und Unternehmenszugehörigkeit (auf volle Jahre nach unten abgerundet)
        /// </summary>
        public int BETZU { get; set; }

        /// <summary>
        /// Wird das Arbeitsentgelt über das Beschäftigungsverhältnis hinaus gezahlt?
        /// </summary>
        /// <value>J = Ja, N = Nein, U = Ungewiss</value>
        public string BVEGEN { get; set; }

        /// <summary>
        /// Datum, bis zu dem das Arbeitsentgelt über das Beschäftigungsverhältnis hinaus gezahlt wird.
        /// </summary>
        public LocalDate? BVEGENB { get; set; }

        /// <summary>
        /// Wurd eine Urlaubsabgeltung wegen der Beendigung des Arbeitsverhältnisses gezahlt?
        /// </summary>
        /// <value>J = Ja, N = Nein, U = Ungewiss</value>
        public string AVENUAG { get; set; }

        /// <summary>
        /// Bei Inanspruchnahme des Urlaubs in Anschluss an das Arbeitsverhältnis betrüge seine Dauer nach den gesetzl./(tarif-)vertragl. Bestimmungen...
        /// </summary>
        public LocalDate? BVENUR { get; set; }

        /// <summary>
        /// Erfolgt eine Vorruhestandsleistung oder vergleichbare Leistung wegen Beendigung des Arbeitsverhältnisses.
        /// </summary>
        /// <value>J = Ja, N = Nein, U = Ungewiss</value>
        public string AVENVL { get; set; }

        /// <summary>
        /// Beginn der Vorruhestandsgeldzahlung bei Beendigung des Arbeitsverhältnisses.
        /// </summary>
        public LocalDate? AVENVGB { get; set; }

        /// <summary>
        /// Vorruhestandgeld bei Beendigung des Arbeitsverhältnisses vom Hundert des Bruttoarbeitsentgelt.
        /// </summary>
        /// <remarks>2 Nachkommastellen.</remarks>
        public int AVENVG { get; set; }

        /// <summary>
        /// Bei Kündigung nach § 1 a KSchG: Beträgt die Abfindung bis zu 0,5 Monatsentgelte für jedes Beschäftigungsjahr?
        /// </summary>
        public bool? ABFMONAT { get; set; }

        /// <summary>
        /// Wäre die Abfindung auch gezahlt worden, wenn die Kündigung durch den Arbeitgeber erfolgt wäre.
        /// </summary>
        public bool? ABFGEZ { get; set; }

        /// <summary>
        /// Bis wann wurde der befristete Arbeitsvertag zuletzt verlängert?
        /// </summary>
        public LocalDate? BFHG { get; set; }
    }
}
