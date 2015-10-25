// <copyright file="DBBG01.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBBG - Meldesachverhalt Beitragsbemessungsgrenze
    /// </summary>
    public class DBBG01 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBBG01"/> Klasse
        /// </summary>
        public DBBG01()
        {
            KE = "DBBG";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Stornierung
        /// </summary>
        /// <remarks>
        /// Kennzeichen, Stornierung einer bereits abgegebenen Meldung, Länge 1, Mussangabe
        /// N = keine Stornierung, J = Stornierung
        /// </remarks>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob die BBG überschritten wird.
        /// </summary>
        /// <remarks>
        /// 1 = Es wird die BBG-RC/AlV überschritten
        /// 2 = Es wird nur die BBG überschritten
        /// </remarks>
        public int KENNZBBGUE { get; set; }

        /// <summary>
        /// Holt oder setzt das verminderte KV-pflichtige Arbeitsentgelt in Eurocent (entsprechend der Verhältnisberechnung nach § 22 Abs. 2 Satz 1 SGB IV)
        /// </summary>
        public int VKVEG
        { get; set; }

        /// <summary>
        /// Holt oder setzt das verminderte RV-pflichtige Arbeitsentgelt in Eurocent (entsprechend der Verhältnisberechnung nach § 22 Abs. 2 Satz 1 SGB IV)
        /// </summary>
        public int VRVEG
        { get; set; }

        /// <summary>
        /// Holt oder setzt das verminderte AV-pflichtige Arbeitsentgelt in Eurocent (entsprechend der Verhältnisberechnung nach § 22 Abs. 2 Satz 1 SGB IV)
        /// </summary>
        public int VAVEG
        { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRBG
        { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZREN
        { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag (Arbeitgeberbeitragsanteil) in Eurocent
        /// </summary>
        public int KVAG
        { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag (Arbeitnehmerbeitragsanteil ohne Sozialausgleich) in Eurocent
        /// </summary>
        public int KVAN
        { get; set; }

        /// <summary>
        /// Holt oder setzt den KV-Beitrag (Arbeitnehmerbeitragsanteil mit Sozialausgleich) in Eurocent
        /// </summary>
        public int KVSO
        { get; set; }

        /// <summary>
        /// Holt oder setzt den PV-Beitrag (Arbeitgeberbeitragsanteil) in Eurocent
        /// </summary>
        public int PVAG
        { get; set; }

        /// <summary>
        /// Holt oder setzt den PV-Beitrag (Arbeitnehmerbeitragsanteil ohne Sozialausgleich) in Eurocent
        /// </summary>
        public int PVAN
        { get; set; }

        /// <summary>
        /// Holt oder setzt den RV-Beitrag (Arbeitgeberbeitragsanteil) in Eurocent
        /// </summary>
        public int RVAG
        { get; set; }

        /// <summary>
        /// Holt oder setzt den RV-Beitrag (Arbeitnehmerbeitragsanteil ohne Sozialausgleich) in Eurocent
        /// </summary>
        public int RVAN
        { get; set; }

        /// <summary>
        /// Holt oder setzt den AV-Beitrag (Arbeitgeberbeitragsanteil) in Eurocent
        /// </summary>
        public int AVAG
        { get; set; }

        /// <summary>
        /// Holt oder setzt den AV-Beitrag (Arbeitnehmerbeitragsanteil ohne Sozialausgleich) in Eurocent
        /// </summary>
        public int AVAN
        { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen des Rechtskreises
        /// </summary>
        /// <remarks>
        /// Kennzeichen des Rechtskreises
        /// W = alte Bundesländer einschließlich Westberlin
        /// O = neue Bundesländer einschließlich Ostberlin
        /// Länge 1, Mussangabe
        /// </remarks>
        public string KENNZRK
        { get; set; }
    }
}
