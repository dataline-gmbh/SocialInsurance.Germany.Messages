// <copyright file="DBRB04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBRB - Datenbaustein Restbeträge
    /// </summary>
    public class DBRB04 : IDatenbaustein
    {
        public DBRB04()
        {
            KE = "DBRB";
        }

        /// <summary>
        /// Holt oder setzt die Kennung des Datenbausteins
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Baustein es sich handelt, Länge 4, Mussangabe
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VKV1REST => (KV1REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - allgemein - ohne Zusatzbeitrag (Beitragsgruppe 1000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KV1REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VKV2REST => (KV2REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - erhöht - ohne Zusatzbeitrag (Beitragsgruppe 2000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KV2REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VKV3REST => (KV3REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - ermäßigt - ohne Zusatzbeitrag (Beitragsgruppe 3000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KV3REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VPVREST => (PVREST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den PV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Pflegeversicherung (Beitragsgruppen 0001 und 0002) mit Centangaben, Länge 11, Mussangabe
        /// </remarks>
        public int? PVREST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VRV1REST => (RV1REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den RV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung (Beitragsgruppen 0100) mit Centangaben, Länge 11, Mussangabe
        /// </remarks>
        public int? RV1REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VZZBPREST => (ZBPREST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den/die Zusatzbeitrag/Pflichtbeiträge
        /// </summary>
        /// <remarks>
        /// Zusatzbeitrag zur Krankversicherung für Pflichtversicherte mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? ZBPREST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VAV1REST => (AV1REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Abreitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Abreitslosenversicherung - voller Beitrag - (Beitragsgruppe 0010) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? AV1REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VRV3REST => (RV3REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung - halber Beitrag - (Beitragsgruppe 0300) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? RV3REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VINSOREST => (INSOREST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Insolvenzgeldversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung (Beitragsgruppe 0050) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? INSOREST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VAV2REST => AV2REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Abreitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Abreitslosenversicherung - halber Beitrag - (Beitragsgruppe 0020) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? AV2REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VU1REST => (U1REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt die Umlage Krankheitsaufwendung
        /// </summary>
        /// <remarks>
        /// Umlage Krankheitsaufwendung (Beitragsgruppe U1) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? U1REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VU2REST => (U2REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt die Umlage Mutterschaftsaufwendung
        /// </summary>
        /// <remarks>
        /// Umlage Mutterschaftsaufwendung (Beitragsgruppe U2) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? U2REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VKV6REST => (KV6REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Pauschal-Beitrag zur Krankenversicherung
        /// </summary>
        /// <remarks>
        /// Pauschal-Beitrag zur Krankenversicherung (Beitragsgruppe 6000) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KV6REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VRV5REST => (RV5REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Pauschal-Beitrag zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Pauschal-Beitrag zur Rentenversicherung (Beitragsgruppe 0500) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? RV5REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VKVFREST => (KVFREST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Krankenversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankenversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KVFREST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VPVFREST => (PVFREST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Pflegeversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Beitrag zur Pflegeversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? PVFREST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VZZBFREST => (ZBFREST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Zusatzbetrag zur Krankversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Zusatzbetrag zur Krankversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? ZBFREST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VZBEITR2REST => (BEITR2REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Wahlweise; z.B zur Seemannskasse - Arbeitgeberanteil - mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? BEITR2REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VZBEITR3REST => (BEITR3REST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Wahlweise; z.B zur Seemannskasse - Arbeitgeberanteil - mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? BEITR3REST { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VBEITRREST => (BEITRREST ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt die Pauschsteuer für geringfügig Beschäftigte
        /// </summary>
        /// <remarks>
        /// Pauschsteuer mit Centeingabe, Länge 11, Mussangabe
        /// </remarks>
        public int? BEITRREST { get; set; }
    }
}
