// <copyright file="Verfahrenkennzeichen.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Implementation der <see cref="IVerfahrenkennzeichen"/>-Schnittstelle
    /// </summary>
    internal sealed class Verfahrenkennzeichen : IVerfahrenkennzeichen
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Verfahrenkennzeichen"/>-Klasse.
        /// </summary>
        /// <param name="verfahren">Das Kennzeichen für das Verfahren für den <code>DSKO</code>- und die Nutzdatensätze (z.B. <code>UVSDD</code>)</param>
        /// <param name="dateikennung">Das Kennzeichen für Meldedateien für das Verfahren (z.B. <code>UVS</code>)</param>
        /// <param name="merkmal">Das Verfahrensmerkmal für die <code>VOSZ</code>- und <code>NCSZ</code>-Datensätze (z.B. <code>UNUVS</code>)</param>
        public Verfahrenkennzeichen(string verfahren, string dateikennung, string merkmal)
        {
            Verfahren = verfahren;
            Dateikennung = dateikennung;
            Merkmal = merkmal;
        }

        /// <inheritdoc />
        public string Verfahren { get; }

        /// <inheritdoc />
        public string Dateikennung { get; }

        /// <inheritdoc />
        public string Merkmal { get; }
    }
}
