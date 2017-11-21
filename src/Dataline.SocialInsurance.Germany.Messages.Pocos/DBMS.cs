// <copyright file="DBMS.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBMS - Meldesachverhalt Sozialausgleich
    /// </summary>
    public class DBMS : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBMS"/> Klasse
        /// </summary>
        public DBMS()
        {
            KE = "DBMS";
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
        /// Kennzeichen, Stornierung einer bereits abgegebenen Meldung
        /// N = keine Stornierung, J = Stornierung
        /// </remarks>
        public bool KENNZST { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen, ob und wie der Sozialausgleich durch den Arbeitgeber durchzuführen ist
        /// </summary>
        /// <remarks>
        /// Kennzeichen, ob und wie der Sozialausgleich durch den Arbeitgeber durchzuführen ist, Länge 1, Mussangabe
        /// </remarks>
        public int KENNZSOZA { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Beginn des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ZRBG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums, für den die Meldung gelten soll
        /// </summary>
        /// <remarks>
        /// Ende des Zeitraums, für den die Meldung gelten soll, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ZREN { get; set; }
    }
}
