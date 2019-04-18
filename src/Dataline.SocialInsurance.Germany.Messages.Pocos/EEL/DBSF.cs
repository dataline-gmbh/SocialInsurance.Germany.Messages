// <copyright file="DBSF.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Zusatzdaten für die Berechnung der Entgeltersatzleistungen für Seeleute
    /// </summary>
    public class DBSF : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBSF"/>-Objekt.
        /// </summary>
        public DBSF()
        {
            KE = "DBSF";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt, ab wann der Arbeitnehmer an Bord/im Ausland bereits arbeitsunfähig war.
        /// </summary>
        public LocalDate? AUBORD { get; set; }

        /// <summary>
        /// Holt oder setzt, wann der Arbeitnehmer arbeitsunfähig im Inland eingetroffen ist.
        /// </summary>
        public LocalDate? AUINLAND { get; set; }

        /// <summary>
        /// Holt oder setzt, über wie viele Tage ein Urlaubsanspruch bei Beendigung des Arbeitsverhältnisses bestand.
        /// </summary>
        public int UANSPRUCH { get; set; }

        /// <summary>
        /// Holt oder setzt, von wann an das Arbeitsverhältnis verlängert wurde.
        /// </summary>
        public LocalDate? VERLAENGVON { get; set; }

        /// <summary>
        /// Holt oder setzt, bis wann das Arbeitsverhältnis verlängert wurde.
        /// </summary>
        public LocalDate? VERLAENGBIS { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennzahl der Durchschnittsheuer nach der Beitragsübersicht der BG Verkehr.
        /// </summary>
        public int KZDHEU { get; set; }

        /// <summary>
        /// Holt oder setzt die Durchschnittsheuer nach der Beitragsübersicht der BG Verkehr (Betrag in Eurocent)
        /// </summary>
        public int DHEU { get; set; }

        /// <summary>
        /// Holt oder setzt das tatsächliche Nettoentgelt (Betrag in Eurocent)
        /// </summary>
        /// <remarks>Betrag kann im Einzelfall höher als <see cref="DHEU"/> sein.</remarks>
        public int HEUNETTO { get; set; }
    }
}
