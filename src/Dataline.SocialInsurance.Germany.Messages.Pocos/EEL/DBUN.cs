// <copyright file="DBUN.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Arbeits-/Schul-/Kindergartenunfall
    /// </summary>
    public class DBUN : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBUN"/>-Objekt.
        /// </summary>
        public DBUN()
        {
            KE = "DBUN";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Unfallaktenzeichen des jeweiligen UV-Trägers.
        /// </summary>
        public string UNFALLAZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Tag des Versicherungsfalls.
        /// </summary>
        public LocalDate? VTAG { get; set; }

        /// <summary>
        /// Holt oder setzt das Institutionskennzeichen des UV-Trägers.
        /// </summary>
        public string IKUV { get; set; }

        /// <summary>
        /// Holt oder setzt die Zuschläge im letzten Abrechnungszeitraum (Wert in Eurocent)
        /// </summary>
        public int? ZUSCHL1 { get; set; }

        /// <summary>
        /// Holt oder setzt die Zuschläge im 2. Abrechnungszeitraum (Wert in Eurocent)
        /// </summary>
        public int? ZUSCHL2 { get; set; }

        /// <summary>
        /// Holt oder setzt die Zuschläge im 3. Abrechnungszeitraum (Wert in Eurocent)
        /// </summary>
        public int? ZUSCHL3 { get; set; }

        /// <summary>
        /// Holt oder setzt die ausgefallenen Zuschläge während der Freistellung (Wert in Eurocent).
        /// </summary>
        public int? FREISTZUSCHL { get; set; }

        /// <summary>
        /// Holt oder setzt die Einmalzahlungen in den letzten 12 Monaten vor der AU/med. Leist./LT in der UV.
        /// </summary>
        public int? EZUV { get; set; }
    }
}
