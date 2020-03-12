// <copyright file="DBSC04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBSC - Datenbaustein Schätzbeiträge
    /// </summary>
    public class DBSC04 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBSC04"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt
        /// </remarks>
        public DBSC04()
        {
            KE = "DBSC";
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
        public string VKV1SCHAETZ => (KV1SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - allgemein - ohne Zusatzbeitrag (Beitragsgruppe 1000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KV1SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VKV2SCHAETZ => (KV2SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - erhöht - ohne Zusatzbeitrag (Beitragsgruppe 2000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KV2SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VKV3SCHAETZ => (KV3SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den KV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankversicherung - ermäßigt - ohne Zusatzbeitrag (Beitragsgruppe 3000) mit Centabgabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KV3SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VPVSCHAETZ => (PVSCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den PV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Pflegeversicherung (Beitragsgruppen 0001 und 0002) mit Centangaben, Länge 11, Mussangabe
        /// </remarks>
        public int? PVSCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VRV1SCHAETZ => (RV1SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den RV-Beitrag
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung (Beitragsgruppen 0100) mit Centangaben, Länge 11, Mussangabe
        /// </remarks>
        public int? RV1SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VZZBPSCHAETZ => (ZBPSCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den/die Zusatzbeitrag/Pflichtbeiträge
        /// </summary>
        /// <remarks>
        /// Zusatzbeitrag zur Krankversicherung für Pflichtversicherte mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? ZBPSCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VAV1SCHAETZ => (AV1SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Abreitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Abreitslosenversicherung - voller Beitrag - (Beitragsgruppe 0010) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? AV1SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VRV3SCHAETZ => (RV3SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung - halber Beitrag - (Beitragsgruppe 0300) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? RV3SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VINSOSCHAETZ => (INSOSCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Insolvenzgeldversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Rentenversicherung (Beitragsgruppe 0050) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? INSOSCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VAV2SCHAETZ => (AV2SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Abreitslosenversicherung
        /// </summary>
        /// <remarks>
        /// Beitrag zur Abreitslosenversicherung - halber Beitrag - (Beitragsgruppe 0020) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? AV2SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VU1SCHAETZ => (U1SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt die Umlage Krankheitsaufwendung
        /// </summary>
        /// <remarks>
        /// Umlage Krankheitsaufwendung (Beitragsgruppe U1) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? U1SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VU2SCHAETZ => (U2SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt die Umlage Mutterschaftsaufwendung
        /// </summary>
        /// <remarks>
        /// Umlage Mutterschaftsaufwendung (Beitragsgruppe U2) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? U2SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VKV6SCHAETZ => (KV6SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Pauschal-Beitrag zur Krankenversicherung
        /// </summary>
        /// <remarks>
        /// Pauschal-Beitrag zur Krankenversicherung (Beitragsgruppe 6000) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KV6SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VRV5SCHAETZ => (RV5SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Pauschal-Beitrag zur Rentenversicherung
        /// </summary>
        /// <remarks>
        /// Pauschal-Beitrag zur Rentenversicherung (Beitragsgruppe 0500) mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? RV5SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VKVFSCHAETZ => (KVFSCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Krankenversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Beitrag zur Krankenversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? KVFSCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VPVFSCHAETZ => (PVFSCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Beitrag zur Pflegeversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Beitrag zur Pflegeversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? PVFSCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VZZBFSCHAETZ => (ZBFSCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den Zusatzbetrag zur Krankversicherung freiwilliger Mitglieder
        /// </summary>
        /// <remarks>
        /// Zusatzbetrag zur Krankversicherung freiwilliger Mitglieder mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? ZBFSCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VZBEITR2SCHAETZ => (BEITR2SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Wahlweise; z.B zur Seemannskasse - Arbeitgeberanteil - mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? BEITR2SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VZBEITR3SCHAETZ => (BEITR3SCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt den wahlweisen Beitrag
        /// </summary>
        /// <remarks>
        /// Wahlweise; z.B zur Seemannskasse - Arbeitgeberanteil - mit Centangabe, Länge 11, Mussangabe
        /// </remarks>
        public int? BEITR3SCHAETZ { get; set; }

        /// <summary>
        /// Holt das Vorzeichen für den Wert des Members
        /// </summary>
        public string VBEITRSCHAETZ => (BEITRSCHAETZ ?? 0) < 0 ? "-" : "+";

        /// <summary>
        /// Holt oder setzt die Pauschsteuer für geringfügig Beschäftigte
        /// </summary>
        /// <remarks>
        /// Pauschsteuer mit Centeingabe, Länge 11, Mussangabe
        /// </remarks>
        public int? BEITRSCHAETZ { get; set; }
    }
}
