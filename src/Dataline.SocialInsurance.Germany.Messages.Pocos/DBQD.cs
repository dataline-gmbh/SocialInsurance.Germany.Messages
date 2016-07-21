// <copyright file="DBQD.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBQD - Quittung-DEÜV
    /// </summary>
    public class DBQD : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBQD"/> Klasse
        /// </summary>
        public DBQD()
        {
            KE = "DBQD";
            VF = "DEUEV";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, DEUEV = Quittung- DEÜV, Länge 5
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Verarbeitung der quittierten Datei
        /// </summary>
        /// <remarks>
        /// Datum der Verarbeitung der quittierten Datei, Länge 8, Mussangabe
        /// </remarks>
        public DateTime VD { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Erstellung der quittierten Datei
        /// </summary>
        /// <remarks>
        /// Datum der Erstellung der quittierten Datei, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Dateinummer der Sendung
        /// </summary>
        /// <remarks>
        /// Dateinummer der Sendung, Länge 6, Mussangabe
        /// </remarks>
        public int DTNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der übermittelten DEÜV-Datensätze
        /// </summary>
        /// <remarks>
        /// Anzahl der übermittelten DEÜV-Datensätze ohne Vor- und Nachlaufsatz, Länge 8
        /// </remarks>
        public int ANZDS { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der fehlerfreien Datensätze
        /// </summary>
        /// <remarks>
        /// Anzahl der fehlerfreien Datensätze, Länge 8, Mussangabe
        /// </remarks>
        public int ANZOK { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der fehlerhaften Datensätze
        /// </summary>
        /// <remarks>
        /// Anzahl der fehlerhaften Datensätze, Länge 8, Mussangabe
        /// </remarks>
        public int ANZFE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der erstellten Hinweise
        /// </summary>
        /// <remarks>
        /// Anzahl der erstellten Hinweise, Länge 8, Mussangabe
        /// </remarks>
        public int ANZHW { get; set; }
    }
}
