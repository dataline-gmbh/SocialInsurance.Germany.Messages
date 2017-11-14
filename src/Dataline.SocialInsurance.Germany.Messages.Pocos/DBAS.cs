// <copyright file="DBAS.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBAS - Ausbildung
    /// </summary>
    public class DBAS : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBAS"/> Klasse
        /// </summary>
        public DBAS()
        {
            KE = "DBAS";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Merkmal zur Ausbildung
        /// </summary>
        /// <remarks>
        /// Merkmal zur Ausbildung, Länge 1, Mussangabe
        /// 1 = Ausbildungsverhältnis, 2 = Ende der Ausbildung
        /// </remarks>
        public int MMARTAS { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum, an dem die Ausbildung begonnen wurde
        /// </summary>
        /// <remarks>
        /// Datum, an dem die Ausbildung begonnen wurde, Länge 8
        /// </remarks>
        public int ASBEG { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum, an dem laut Ausbidungsvertrag die Ausbildung beendet wird
        /// </summary>
        /// <remarks>
        /// Datum, an dem laut Ausbildungsvertrag die Ausbildung beendet wird, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate ASVOREND { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum, an dem die Ausbildung tatsächlich geendet hat
        /// </summary>
        /// <remarks>
        /// Datum, an dem die Ausbildung tatsächlich geendet hat, Länge 8, Mussangabe
        /// </remarks>
        public LocalDate TATASEND { get; set; }
    }
}
