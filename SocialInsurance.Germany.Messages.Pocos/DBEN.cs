using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBEN - ELENA Grunddaten zum Arbeitgeber und Arbeitnehmer
    /// </summary>
    public class DBEN : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBEN"/> Klasse.
        /// </summary>
        public DBEN()
        {
            KE = "DBEN";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Arbeits-/Dienstverhältnisses
        /// </summary>
        /// <remarks>
        /// Beginn des Arbeits-/Dienstverhältnisses, Länge 8, Mussangabe
        /// </remarks>
        public DateTime AVBEG { get; set; }

        /// <summary>
        /// Holt oder setzt die Steuerklasse des Arbeitnehmers
        /// </summary>
        /// <remarks>
        /// Steuerklasse des Arbeitnehmers bzw. Grundstellung, Länge 1, Mussangabe
        /// 1-6: gemäß der Steuerklassen-Definition oder 0 (keine) 
        /// </remarks>
        public int STKL { get; set; }

        /// <summary>
        /// Holt oder setzt den Faktor der Steuerberechnung
        /// </summary>
        /// <remarks>
        /// Faktor der Steuerberechnung, Länge 4, Mussangabe
        /// </remarks>
        public int FKT { get; set; }

        /// <summary>
        /// Holt oder setzt den Kinderfreibetrag des Arbeitnehmers
        /// </summary>
        /// <remarks>
        /// Kinderfreibetrag des Arbeitnehmers, Länge 3, Mussangabe
        /// </remarks>
        public int KINDFRB { get; set; }

        /// <summary>
        /// Holt oder setzt die Angaben zur Tätigkeit
        /// </summary>
        /// <remarks>
        /// Angaben zur Tätigkeit, Länge 9, Mussangabe unter Bedingungen
        /// nach dem Tätigkeitsschlüssel der Bundesagentur für Arbeit gemäß Anlage 5 des gemeinsamen
        /// Rundschreibens „Gemeinsames Meldeverfahren zur Kranken-, Pflege-, Renten- und Arbeitslosenversicherung“
        /// (fünfstellig, linksbündig mit nachfolgenden Leerzeichen)
        /// </remarks>
        public string TTSC { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Betriebsstätte(Rechtskreis)
        /// </summary>
        /// <remarks>
        /// Kennzeichen Betriebsstätte (Rechtskreis), Länge 1, Mussangabe
        /// W = altes Bundesland inkl. des ehem. Westteils von Berlin
        /// O = neues Bundesland inklusive des ehem. Ostteils von Berlin
        /// </remarks>
        public string KENNZRK { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel
        /// </summary>
        /// <remarks>
        /// Beitragsgruppenschlüssel gemäß Anlage 1 der Gemeinsamen Grundsätze 
        /// für die Datenerfassung und Datenübermittlung zur Sozialversicherung 
        /// </remarks>
        public int BYGR { get; set; }

        /// <summary>
        /// Holt oder setzt die vereinbarte Wochenarbeitszeit in Stunden
        /// </summary>
        /// <remarks>
        /// vereinbarte Wochenarbeitszeit in Stunden, Länge 4, Mussangabe
        /// Steht die Wochenarbeitszeit nicht fest, ist ein Durchschnittswert
        /// für die im Abrechnungszeitraum geleistete Wochenstundenzahl zu errechnen. 
        /// </remarks>
        public int AZWOECH { get; set; }

        /// <summary>
        /// Holt oder setzt das Summenvorzeichen LFD
        /// </summary>
        /// <remarks>
        /// Summenvorzeichen, Länge 1, Mussangabe
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag
        /// </remarks>
        public string VSTBREGLF { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende steuerpflichtige Bruttoarbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Laufendes steuerpflichtiges Bruttoarbeitsentgelt, Länge 10, Mussangabe
        /// </remarks>
        public int STBREGLF { get; set; }

        /// <summary>
        /// Holt oder setzt das Summenvorzeichen SONST
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VSTBREGSO { get; set; }

        /// <summary>
        /// Holt oder setzt das sonstige steuerpflichtige Bruttoarbeitsentgelt
        /// </summary>
        /// <remarks>
        /// sonstiges steuerpflichtiges Bruttoarbeitsentgelt, Länge 10, Mussangabe
        /// </remarks>
        public int STRBEGSO { get; set; }

        /// <summary>
        /// Holt oder setzt das laufende Sozialversicherungsbruttoengtgelt
        /// </summary>
        /// <remarks>
        /// laufendes Sozialversicherungsbruttoentgelt, Länge 10, Mussangabe
        /// begrenzt auf die Beitragsbemessungsgrenze der Allgemeinen Rentenversicherung 
        /// </remarks>
        public int SVBREGLF { get; set; }

        /// <summary>
        /// Holt oder setzt das einmalig gezahlte Sozialversicherungsbruttoentgelt
        /// </summary>
        /// <remarks>
        /// einmalig gezahltes Sozialversicherungsbruttoentgelt, Länge 10, Mussangabe
        /// </remarks>
        public int SVBREGE { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Gesamtbruttoentgelt
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag
        /// </remarks>
        public string VGSBREG { get; set; }

        /// <summary>
        /// Holt oder setzt das Gesamtbruttoentgelt
        /// </summary>
        /// <remarks>
        /// Gesamtbruttoentgelt gem. § 1 Abs. 2 EBeschRiLi, Länge 10, Mussangabe
        /// </remarks>
        public int GSBREG { get; set; }

        /// <summary>
        /// Holt oder setzt die Abzüge SV bei Pflichtversicherten, KV laufend
        /// </summary>
        /// <remarks>
        /// Abzüge SV bei Pflichtversicherten, KV laufend, Länge 10, Mussangabe
        /// </remarks>
        public int KVLF { get; set; }

        /// <summary>
        /// Holt oder setzt die Abzüge SV bei Pflichtversicherten, KV Einmalentgelte
        /// </summary>
        public int KVE { get; set; }

        /// <summary>
        /// Holt oder setzt die Abzüge SV bei Pflichtversicherten, RV laufend
        /// </summary>
        /// <remarks>
        /// Abzüge SV bei Pflichtversicherten, Länge 10, Mussangabe
        /// RV laufend bzw. Pflichtbeiträge an berufsständische Versorgungseinrichtungen
        /// </remarks>
        public int RVLF { get; set; }

        /// <summary>
        /// Holt oder setzt die Abzüge SV bei Pflichtversicherten, RV Einmalentgelte
        /// </summary>
        /// <remarks>
        /// Abzüge SV bei Pflichtversicherten, Länge 10, Mussangabe
        /// RV Einmalentgelte bzw. Pflichtbeiträge an berufsständische Versorgungseinrichtungen
        /// </remarks>
        public int RVE { get; set; }

        /// <summary>
        /// Holt oder setzt die Abzüge SV bei Pflichtversicherten, ALV laufen
        /// </summary>
        /// <remarks>
        /// Abzüge SV bei Pflichtversicherten,ALV laufend, Länge 10, Mussangabe
        /// </remarks>
        public int AVLF { get; set; }

        /// <summary>
        /// Holt oder setzt die Abzüge SV bei Pflichtversicherten, ALV Einmalentgelte
        /// </summary>
        /// <remarks>
        /// Abzüge SV bei Pflichtversicherten, ALV Einmalentgelte, Länge 10, Mussangabe
        /// </remarks>
        public int AVE { get; set; }

        /// <summary>
        /// Holt oder setzt die Abzüge SV bei Pflichtversicherten, PV laufend
        /// </summary>
        /// <remarks>
        /// Abzüge SV bei Pflichtversicherten, PV laufend, Länge 10, Mussangabe
        /// </remarks>
        public int PVLF { get; set; }

        /// <summary>
        /// Holt oder setzt die Abzüge SV bei Pflichtversicherten, PV Einmalentgelte
        /// </summary>
        public int PVE { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Lohnsteuer
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VLSTLF { get; set; }

        /// <summary>
        /// Holt oder setzt die Lohnsteuer laufend
        /// </summary>
        /// <remarks>
        /// Lohnsteuer laufend, Länge 10, Mussangabe
        /// </remarks>
        public int LSTLF { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Lohnsteuer sonstiger Bezug
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VLSTSOB { get; set; }

        /// <summary>
        /// Holt oder setzt die Lohnsteuer sonstiger Bezug
        /// </summary>
        /// <remarks>
        /// Lohnsteuer sonstiger Bezug, Länge 10, Mussangabe
        /// </remarks>
        public int LSTSOB { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Solidaritätszuschlag LFD
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VSOLILF { get; set; }

        /// <summary>
        /// Holt oder setzt den Solidaritätszuschlag laufend
        /// </summary>
        /// <remarks>
        /// Solidaritätszuschlag laufend, Länge 10, Mussangabe
        /// </remarks>
        public int SOLILF { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Solidaritätszuschlag Sonstiger Bezug
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag
        /// </remarks>
        public string VSOLISOB { get; set; }

        /// <summary>
        /// Holt oder setzt den Solidaritätszuschlag sonstiger Bezug
        /// </summary>
        /// <remarks>
        /// Solidaritätszuschlag sonstiger Bezug, Länge 10, Mussangabe
        /// </remarks>
        public int SOLISOB { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Kirchensteuer LFD
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VKISTLF { get; set; }

        /// <summary>
        /// Holt oder setzt Kirchensteuer laufend
        /// </summary>
        /// <remarks>
        /// Kirchensteuer laufend, Länge 10, Mussangabe
        /// </remarks>
        public int KISTLF { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Kirchensteuer sonstiger Bezug
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VKISTSOB { get; set; }

        /// <summary>
        /// Holt oder setzt Kirchensteuer sonstiger Bezug
        /// </summary>
        /// <remarks>
        /// Kirchensteuer sonstiger Bezug, Länge 10, Mussangabe
        /// </remarks>
        public int KISTSOB { get; set; }
    }
}
