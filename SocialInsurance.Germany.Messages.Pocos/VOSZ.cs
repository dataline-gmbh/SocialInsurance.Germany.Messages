// <copyright file="VOSZ.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: VOSZ - Vorlaufsatz
    /// </summary>
    public class VOSZ : IDatensatz
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="VOSZ"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren wird die Konstante Kennung gesetzt
        /// </remarks>
        public VOSZ()
        {
            VERNR = 1;
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal, um welche Art von Datenaustausch es sich handelt
        /// </summary>
        /// <remarks>
        /// Merkmal, um welche Art von Datenaustausch es sich handelt, Länge 5, Mussangabe
        /// </remarks>
        public string VFMM { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Erstellers der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        public string BBNREP { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Erstellung der Datei
        /// </summary>
        /// <remarks>
        /// Datum der Erstellung der Datei, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Dateifolgenummer
        /// </summary>
        /// <remarks>
        /// Dateifolgenummer, 000001 - 999999, Länge 6, Mussangabe
        /// </remarks>
        public int DTNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Kurzbezeichnung des Absenders
        /// </summary>
        /// <remarks>
        /// Kurzbezeichnung des Absenders, Länge 50, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des Vorlaufsatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des Vorlaufsatzes, 01 - 99, Länge 2, Mussangabe
        /// </remarks>
        public int VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt eine Liste von Fehlern
        /// </summary>
        public IList<DBFE> DBFE { get; set; }

        /// <summary>
        /// Holt die Datenbausteine eines Datensatzes
        /// </summary>
        public IEnumerable<IDatenbaustein> Datenbausteine
        {
            get
            {
                foreach (var datenbaustein in ListExtensions.Enumerate(DBFE))
                    yield return datenbaustein;
            }
        }
    }
}
