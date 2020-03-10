﻿// <copyright file="DSKO03.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// Datensatz: DSKO - Datensatz Kommunikation
    /// </summary>
    public class DSKO03 : IDatensatz
    {
        private FehlerKennzeichen? _fekz;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSKO03"/> Klasse
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt
        /// </remarks>
        public DSKO03()
        {
            KE = "DSKO";
            VERNR = 3;
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5, Mussangabe
        /// DEUEV = DEÜVMeldeverfahren
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Absenders des Datensatzes
        /// </summary>
        /// <remarks>
        ///  Betriebsnummer des Erstellers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
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
        /// Holt oder setzt die Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
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
        /// Holt oder setzt die Versionsnummer des übermittelten Datensatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des übermittelten Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public int VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Dateznsatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennzeichnung für fehlerhafte Datensätze
        /// </summary>
        /// <remarks>
        /// Kennzeichnung für fehlerhafte Datensätze, Länge 1, 0 = Datensatz fehlerfrei 1 = Datensatz fehlerhaft, Mussangabe
        /// </remarks>
        public FehlerKennzeichen FEKZ
        {
            get => _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft);
            set => _fekz = value;
        }

        /// <summary>
        /// Holt die Anzahl der Fehler des Datensatzes
        /// </summary>
        /// <remarks>
        /// Anzahl der Fehler des Datensatzes, Länge 1, Mussangabe
        /// </remarks>
        public int FEAN
        {
            get { return DBFE == null ? 0 : DBFE.Count; }
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Erstellers der Datei, Länge 15, Mussangabe
        /// Sie ist auf dem Weg zur Datenannahmestelle der Einzugsstelle identisch
        /// mit der Betriebsnummer des Absenders der Datei; Stellen 010 bis 024
        /// (8 Stellen linksbündig mit nachfolgenden Leerzeichen)
        /// </remarks>
        [Obsolete("Bitte verwenden Sie statt dessen ABSNER")]
        public string BBNRER { get => ABSNER; set => ABSNER = value; }

        /// <summary>
        /// Holt oder setzt die Absendernummer des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>Betriebsnummer des Erstellers der Datei (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        ///     <item>Absendernummer gemäß § 18n Abs. 2 SGB IV (A + 7 Ziffern linksbündig mit nachfolgenden Leerzeichen), Länge 15, Mussangabe</item>
        /// </list>
        /// </remarks>
        public string ABSNER { get; set; }

        /// <summary>
        /// Holt oder setzt den Produkt-Identifier des geprüften Softwareproduktes
        /// </summary>
        /// <remarks>
        /// Produkt-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird, Länge 7, Mussangabe
        /// Sie wird von der ITSG, eindeutig für jedes systemuntersuchte Programm, vergeben
        /// </remarks>
        public int PRODID { get; set; }

        /// <summary>
        /// Holt oder setzt den Modifikations-Identifier des geprüften Softwareproduktes
        /// </summary>
        /// <remarks>
        /// Modifikations-Identifier des geprüften Softwareproduktes, das beim Ersteller der Datei eingesetzt wird, Länge 8, Mussangabe
        /// Sie wird je geprüfter Produktversion von der ITSG vergeben
        /// </remarks>
        public int MODID { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Name des Erstellers der Datei, Länge 30, Mussangabe
        /// </remarks>
        public string NAME1 { get; set; }

        /// <summary>
        /// Holt oder setzt den zweiten Namensbestandteil des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Zweiter Namensbestandteil des Erstellers der Datei, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME2 { get; set; }

        /// <summary>
        /// Holt oder setzt den dritten Namensbestandteil des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Dritter Namensbestandteil des Erstellers der Datei, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAME3 { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Postleitzahl des Erstellers der Datei, Länge 10, Mussangabe
        /// </remarks>
        public string PLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Betriebssitz des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Betriebssitz des Erstellers der Datei, Länge 34, Mussangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße des Betriebssitzes des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Straße des Betriebssitzes des Erstellers der Datei, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer des Betriebssitzes des Erstellers der Datei
        /// </summary>
        /// <remarks>
        /// Hausnummer des Betriebssitzes des Erstellers der Datei, Länge 9, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NR { get; set; }

        /// <summary>
        /// Holt oder setzt die Anrede des Ansprechpartners beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// Anrede des Ansprechpartners beim Ersteller der Datei, Länge 1, Mussangabe
        /// M = Männlich, W = Weiblich
        /// </remarks>
        public string ANRAP { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des DEÜV-Ansprechpartners beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// Name des DEÜV-Ansprechpartners beim Ersteller der Datei, Länge 30, Mussangabe
        /// </remarks>
        public string NAMEAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Rufnummer des DEÜV-Ansprechpartners beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// Rufnummer des DEÜV-Ansprechpartners beim Ersteller der Datei, Länge 20, Mussangabe
        /// Die Telefonnummer ist funktionsbezogen durch je ein Leerzeichen zu
        /// gliedern, vor der Durchwahlnummer steht ein Bindestrich
        /// </remarks>
        public string TELAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Faxrufnummer des DEÜV-Ansprechpartners beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// Faxrufnummer des DEÜVAnsprechpartners beim Ersteller der Datei, Länge 20, Mussangabe
        /// Die Faxnummer ist funktionsbezogen durch je ein Leerzeichen zu
        /// gliedern, vor der Durchwahlnummer steht ein Bindestrich
        /// </remarks>
        public string FAXAP { get; set; }

        /// <summary>
        /// Holt oder setzt die E-Mail-Adresse des Empfängers der Protokolle beim Ersteller der Datei
        /// </summary>
        /// <remarks>
        /// E-Mail-Adresse des Empfängers der Protokolle beim Ersteller der Datei, Länge 70, Mussangabe
        /// </remarks>
        public string EMAILAP { get; set; }

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
