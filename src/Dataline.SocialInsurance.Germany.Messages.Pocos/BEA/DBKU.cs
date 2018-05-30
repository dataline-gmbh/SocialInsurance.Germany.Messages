// <copyright file="DBKU.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Kündigung/Entlassung EU
    /// </summary>
    public class DBKU : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBKU";

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
        /// Holt oder setzt, zu wann das Arbeitsverhältnis bei Vertragsabschluss befristet war.
        /// </summary>
        public LocalDate? AVBFURSPR { get; set; }

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
        /// Holt oder setzt das Datum der Beendigung des Arbeitsverhältnisses oder des Abschlusses des Aufhebungsvertrags.
        /// </summary>
        public LocalDate? AVKUEAM { get; set; }

        /// <summary>
        /// Holt oder setzt, durch wen oder was die Kündigung erfolgte.
        /// </summary>
        public KuendigungDurch? AVKUEDU { get; set; }

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
        /// Wenn die Kündigung des Arbeitsverhältnisses durch den AG erfolgte o. erfolgt wäre, erfolgte sie wegen vertragswidrigen Verhalten des AN?
        /// </summary>
        public bool? AVKUEAL { get; set; }

        /// <summary>
        /// Erfolgt die Zahlung einer Entlassungsentschädigung (Abfindung, Entschädigung oder ähnliche Leistung) oder besteht ein Anspruch
        /// auf Leistungen im Zusammenhang mit der Beendigung des Arbeits- bzw.Beschäftigungsverhältnisses bzw. Heimarbeitsverhältnisses?
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
        /// Anzahl der Tage, auf die nach Ausscheiden aus dem Arbeitsverhältnis noch ein Anspruch auf Urlaubsabgeltung wegen nicht genommenen Urlaubs bestand.
        /// </summary>
        public int URLTAGEAV { get; set; }

        /// <summary>
        /// Bei Inanspruchnahme des Urlaubs in Anschluss an das Arbeitsverhältnis betrüge seine Dauer nach den gesetzl./(tarif-)vertragl. Bestimmungen...
        /// </summary>
        public LocalDate? AVENUR { get; set; }

        /// <summary>
        /// Höhe der Urlaubsabgeltung
        /// </summary>
        /// <remarks>2 Nachkommastellen</remarks>
        public long UAGHOE { get; set; }

        /// <summary>
        /// Verzicht auf Ansprüche aus dem Arbeitsvertrag.
        /// </summary>
        /// <value>
        /// 1 = Abfindung/Entlassungsentschädigung
        /// 2 = Arbeitsentgeltanspruch über das Ende des Arbeitsverhältnisses hinaus
        /// 3 = Urlaubsabgeltung wegen Beendigung des Arbeitsverhältnisses
        /// 4 = Abfindung/Entlassungsentschädigung und Arbeitsentgeltanspruch über das Ende des Arbeitsverhältnisses hinaus
        /// 5 = Abfindung/Entlassungsentschädigung und Urlaubsabgeltung wegen Beendigung des Arbeitsverhältnisses
        /// 6 = Arbeitsentgeltanspruch über das Ende des Arbeitsverhältnisses hinaus und Urlaubsabgeltung wegen Beendigung des Arbeitsverhältnisses
        /// 7 = Abfindung/Entlassungsentschädigung und Arbeitsentgeltanspruch über das Ende des Arbeitsverhältnisses hinaus und Urlaubsabgeltung wegen Beendigung des Arbeitsverhältnisses
        /// </value>
        public int AVVERZ { get; set; }

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
    }
}
