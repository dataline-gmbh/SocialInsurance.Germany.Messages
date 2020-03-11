// <copyright file="DBS104.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBS1 - Datenbaustein Seemännische Besonderheiten (DSAG)
    /// </summary>
    public class DBS104 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBS104"/> Klasse
        /// </summary>
        public DBS104()
        {
            KE = "DBS1";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt die Anzahl Wechselkurse
        /// </summary>
        /// <remarks>
        /// Länge 2, Mussangabe
        /// </remarks>
        public int ANWK
        {
            get => DBS1ext?.Count ?? 0;

            // ReSharper disable once UnusedMember.Local
            // ReSharper disable once ValueParameterNotUsed
            private set { }
        }

        /// <summary>
        /// Holt oder setzt eine Liste von Wechselkursen
        /// </summary>
        public IList<DBS1ext04> DBS1ext { get; set; }
    }
}
