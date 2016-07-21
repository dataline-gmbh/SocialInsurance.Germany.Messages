// <copyright file="DBSB.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBSB - Steuerpflichtiger sonstiger Bezug
    /// </summary>
    public class DBSB : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBSB"/> Klasse
        /// </summary>
        public DBSB()
        {
            KE = "DBSB";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten steuerfreien Bezüge
        /// </summary>
        /// <remarks>
        /// Anzahl der angehängten steuerfreien Bezüge, Länge 2, Mussangabe
        /// </remarks>
        public int ANSB { get; set; }

        /// <summary>
        /// Holt oder setzt die Liste der sich wiederholenden Felder
        /// </summary>
        public IList<DBSB_SB> SB { get; set; }

        /// <summary>
        /// wiederholt sich entsprechend der Anzahl im Feld ANSB in DBSB
        /// </summary>
        public class DBSB_SB
        {
            /// <summary>
            /// Holt oder setzt das Vorzeichen für steuerfreie Bezüge
            /// </summary>
            /// <remarks>
            /// Plus (+) / Leerzeichen = positiver Betrag
            /// Minus (-) = negativer Betrag
            /// </remarks>
            public string VSB { get; set; }

            /// <summary>
            /// Holt oder setzt die Höhe des steuerfreien Bezuges
            /// </summary>
            /// <remarks>
            /// Höhe des steuerfreien Bezuges, Länge 10, Mussangabe
            /// </remarks>
            public int SB { get; set; }

            /// <summary>
            /// Holt oder setzt die Art des Bezuges
            /// </summary>
            /// <remarks>
            /// Art des Bezuges, Länge 2, Mussangabe
            /// </remarks>
            public int SBART { get; set; }

            /// <summary>
            /// Holt oder setzt die Art des sonstigen steuerfreien Bezuges
            /// </summary>
            /// <remarks>
            /// Art des sonstigen steuerfreien Bezuges (Freitext), Länge 30, Mussangabe unter Bedingungen
            /// </remarks>
            public string SBARTTX { get; set; }
        }
    }
}
