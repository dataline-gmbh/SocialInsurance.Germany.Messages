// <copyright file="DBBF.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBBF - Bestandsfehler
    /// </summary>
    public class DBBF : IDatenbaustein
    {
        private int? _anbf;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBBF"/> Klasse
        /// </summary>
        public DBBF()
        {
            KE = "DBBF";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten Bestandsfehler
        /// </summary>
        public int ANBF
        {
            get => _anbf ?? (BF == null ? 0 : BF.Count);
            set => _anbf = value;
        }

        /// <summary>
        /// Holt oder setzt eine Liste mit Bestandsfehlern
        /// </summary>
        /// <remarks>
        /// Fehlernummer des Bestandsfehlers plus ein Leerzei-chen plus Fehlertext
        /// </remarks>
        public IList<string> BF { get; set; }
    }
}
