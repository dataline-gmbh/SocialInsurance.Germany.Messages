using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBZD - Zusatzdaten
    /// </summary>
    public class DBZD : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBZD"/> Klasse
        /// </summary>
        public DBZD()
        {
            KE = "DBZD";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das fiktive Bruttoarbeitsentgelt
        /// </summary>
        /// <remarks>
        /// Fiktives Bruttoarbeitsentgelt, Länge 10, Mussangabe
        /// das ohne Berücksichtigung von Sonderregelungen beitragspflichtig gewesen wäre 
        /// (z. B. Gleitzone, Kug, Beschäftigungssicherungsvereinbarung nach § 421t Abs. 7 SGB III
        /// Arbeitsentgelt, welches ohne Altersteilzeitvereinbarung erzielt worden wäre)
        /// </remarks>
        public int FIBR { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen pauschal besteuerter Arbeitslohn SB
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VPAULSB { get; set; }

        /// <summary>
        /// Holt oder setzt den pauschal besteuerten Arbeitslohn nach § 37b EStG(Sachzuwendungen)
        /// </summary>
        /// <remarks>
        /// pauschal besteuerter Arbeitslohn nach § 37b EStG (Sachzuwendungen), Länge 10, Mussangabe
        /// </remarks>
        public int PAULSB { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen pauschal besteuerter Arbeitslohn
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VPAULGER { get; set; }

        /// <summary>
        /// Holt oder setzt den pauschal besteuerten Arbeitslohn nach §§ 40, 40a EStG 
        /// </summary>
        /// <remarks>
        /// pauschal besteuerter Arbeitslohn nach §§ 40, 40a EStG, Länge 10, Mussangabe
        /// </remarks>
        public int PAULGER { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen sonstig pauschal besteuerter Arbeitslohn
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag 
        /// Minus (-) = negativer Betrag
        /// </remarks>
        public string VPAULSO { get; set; }

        /// <summary>
        /// Holt oder setzt den pauschal besteuerten Arbeitslohn nach § 40b EStG 
        /// </summary>
        /// <remarks>
        /// pauschal besteuerter Arbeitslohn nach § 40b EStG, Länge 10, Mussangabe 
        /// </remarks>
        public int PAULSO { get; set; }

        /// <summary>
        /// Holt oder setzt den Arbeitgeberzuschuss zur freiwilligen oder privaten Krankenversicherung
        /// </summary>
        /// <remarks>
        /// Arbeitgeberzuschuss zur freiwilligen Krankenversicherung oder zur privaten Krankenversicherung, Länge 10, Mussangabe
        /// </remarks>
        public int AGFREIWKV { get; set; }

        /// <summary>
        /// Holt oder setzt den Arbeitgeberzuschuss zur freiwilligen oder privaten Pflegeversicherung
        /// </summary>
        /// <remarks>
        /// Arbeitgeberzuschuss zur freiwilligen oder privaten Pflegeversicherung, Länge 10, Mussangabe
        /// </remarks>
        public int AGFREIWPV { get; set; }

        /// <summary>
        /// Holt oder setzt den Gesamtbeitrag KV bei freiwilligen Mitgliedern in der gesetzlichen Krankenversicherung
        /// </summary>
        /// <remarks>
        /// Gesamtbeitrag KV bei freiwilligen Mitgliedern in der gesetzlichen Krankenversicherung, Länge 10, Mussangabe
        /// </remarks>
        public int BYFREIWKVLFE { get; set; }

        /// <summary>
        /// Holt oder setzt den Gesamtbeitrag PV bei freiwilligen Mitgliedern in der gesetzlichen Krankenversicherung
        /// </summary>
        /// <remarks>
        /// Gesamtbeitrag PV bei freiwilligen Mitgliedern in der gesetzlichen Krankenversicherung, Länge 10, Mussangabe
        /// </remarks>
        public int BYFREIWPVLFE { get; set; }

        /// <summary>
        /// Holt oder setzt den Gesamtpflichtbeitrag zur berufsständischen Versorgung
        /// </summary>
        /// <remarks>
        /// Gesamtpflichtbeitrag zur berufsständischen Versorgung, Länge 10, Mussangabe
        /// </remarks>
        public int PBRVBERVERS { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Lohnsteuer pauschal
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag
        /// </remarks>
        public string VLSTPAU { get; set; }

        /// <summary>
        /// Holt oder setzt die Lohnsteuer des pauschal versteuerten Einkommens
        /// </summary>
        /// <remarks>
        /// Lohnsteuer des pauschal versteuerten Einkommens, Länge 10, Mussangabe
        /// vorausgesetzt, die Lohnsteuer des pauschal versteuerten Einkommens wird vom Arbeitnehmer gezahlt
        /// </remarks>
        public int LSTPAU { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Solidaritätszuschlag pauschal
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VSOLIPAU { get; set; }

        /// <summary>
        /// Holt oder setzt den Solidaritätszuschlag des pauschal versteuerten Einkommens
        /// </summary>
        /// <remarks>
        /// Solidaritätszuschlag des pauschal versteuerten Einkommens, Länge 10, Mussangabe
        /// vorausgesetzt, der Solidaritätszuschlag des pauschal versteuerten Einkommens wird vom Arbeitnehmer gezahlt
        /// </remarks>
        public int SOLIPAU { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorzeichen Kirchensteuer pauschal
        /// </summary>
        /// <remarks>
        /// Plus (+) / Leerzeichen = positiver Betrag
        /// Minus (-) = negativer Betrag 
        /// </remarks>
        public string VKISTPAU { get; set; }

        /// <summary>
        /// Holt oder setzt die Kirchensteuer des pauschal versteuerten Einkommens
        /// </summary>
        /// <remarks>
        /// Kirchensteuer des pauschal versteuerten Einkommens, Länge 10, Mussangabe
        /// vorausgesetzt, die Kirchensteuer des pauschal versteuerten Einkommens wird vom Arbeitnehmer gezahlt
        /// </remarks>
        public int KISTPAU { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund für eine Änderung der regelmäßigen Wochenarbeitszeit
        /// </summary>
        /// <remarks>
        /// Grund für eine Änderung der regelmäßigen Wochenarbeitszeit, Länge 1, Mussangabe
        /// </remarks>
        public int AZAEGR { get; set; }

        /// <summary>
        /// Holt oder setzt die durchschnittliche regelmäßige Arbeitszeit eines vergleichbaren Vollzeitbeschäftigten in Stunden pro Woche 
        /// </summary>
        /// <remarks>
        /// durchschnittliche regelmäßige Arbeitszeit eines vergleichbaren Vollzeitbeschäftigten in Stunden pro Woche, Länge 4, Mussangabe
        /// </remarks>
        public int AZVG { get; set; }
    }
}
