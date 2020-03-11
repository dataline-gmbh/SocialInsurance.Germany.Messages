// <copyright file="VOSZ04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// VOSZ - Vorlaufsatz
    /// </summary>
    /// <remarks>
    /// Dieser Vorlaufsatz ist speziell für das euBP-Verfahren!!!
    /// </remarks>
    public class VOSZ04 : IDatensatz
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="VOSZ04"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten gesetzt
        /// </remarks>
        public VOSZ04()
        {
            KE = "VOSZ";
            VFMM = "AGBPL"; // Meldungen der Arbeitgeber (Lohn)
            VERNR = 4;
            VERGES = "3.1.0";
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
        [Obsolete("Bitte verwenden Sie statt dessen ABSN")]
        public string BBNRAB { get => ABSN; set => ABSN = value; }

        /// <summary>
        /// Holt oder setzt die Absendernummer des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>Betriebsnummer des Erstellers der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
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
        /// Holt oder setzt das Kennzeichen, ob die Sendung komplett ist
        /// </summary>
        public bool KENNZSEKO { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Stornierung
        /// </summary>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Verursachers der Datei
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>Betriebsnummer des Verursachers der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        ///     <item>Absendernummer gemäß § 18n Abs. 2 SGB IV (A + 7 Ziffern linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        /// </list>
        /// </remarks>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Versionsnummer der gesamten Schnittstelle
        /// </summary>
        /// <remarks>
        /// Zulässig sind 3.0.0 und 3.1.0
        /// </remarks>
        public string VERGES { get; set; }

        /// <summary>
        /// Freifeld für den Absender (Aktenzeichen)
        /// </summary>
        /// <remarks>
        /// Länge 20, Kannangabe
        /// </remarks>
        public string AKAB { get; set; }

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
