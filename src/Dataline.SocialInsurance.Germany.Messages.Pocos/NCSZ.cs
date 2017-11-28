// <copyright file="NCSZ.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// NCSZ - Nachlaufsatz
    /// </summary>
    public class NCSZ : IDatensatz
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="NCSZ"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren wird die Konstante Kennung gesetzt
        /// </remarks>
        public NCSZ()
        {
            KE = "NCSZ";
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
        /// Holt oder setzt die Betriebsnummer des Absenders der Datei
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Absenders der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        [Obsolete("Bitte verwenden Sie statt dessen ABSN")]
        public string BBNRAB { get => ABSN; set => ABSN = value; }

        /// <summary>
        /// Holt oder setzt die Absendernummer der Datei
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>Betriebsnummer des Absenders der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        ///     <item>Absendernummer gemäß § 18n Abs. 2 SGB IV (A + 7 Ziffern linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        /// </list>
        /// </remarks>
        public string ABSN { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe
        /// </remarks>
        [Obsolete("Bitte verwenden Sie statt dessen EPNR")]
        public string BBNREP { get => EPNR; set => EPNR = value; }

        /// <summary>
        /// Holt oder setzt die Absendernummer des Empfängers der Datei
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>Betriebsnummer des Empfängers der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        ///     <item>Absendernummer gemäß § 18n Abs. 2 SGB IV (A + 7 Ziffern linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        /// </list>
        /// </remarks>
        public string EPNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Erstellung der Datei
        /// </summary>
        /// <remarks>
        /// Datum der Erstellung der Datei, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Dateifolgenummer
        /// </summary>
        /// <remarks>
        /// Dateifolgenummer, 000001 - 999999, Länge 6, Mussangabe
        /// </remarks>
        public int DTNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der erstellten Datensätze
        /// </summary>
        /// <remarks>
        /// Anzahl der erstellten Datensätze (ohne Vor- und Nachlaufsätze), Länge 8, Mussangabe
        /// </remarks>
        public int ZLSZ { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des Nachlaufsatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des Nachlaufsatzes, 01 - 99, Länge 2, Mussangabe
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
