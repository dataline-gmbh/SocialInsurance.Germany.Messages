// <copyright file="DBID.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Identifikatsiondaten
    /// </summary>
    public class DBID : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBID"/>-Objekt.
        /// </summary>
        public DBID()
        {
            KE = "DBID";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen SV.
        /// </summary>
        /// <remarks>Dieses Feld steht der Einzugsstelle zur freien Verfügung.</remarks>
        public string AZSV { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen Verursacher.
        /// </summary>
        /// <remarks>Dieses Feld steht dem Verursacher zur freien Verfügung.</remarks>
        public string AZVU { get; set; }
    }
}
