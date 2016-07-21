// <copyright file="IDatensatz.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Schnittstelle für Datensätze
    /// </summary>
    public interface IDatensatz
    {
        /// <summary>
        /// Holt die Kennung für den Datensatz
        /// </summary>
        string KE { get; }

        /// <summary>
        /// Holt die Liste der Fehler-Datenbausteine
        /// </summary>
        IList<DBFE> DBFE { get; }

        /// <summary>
        /// Holt die Datenbausteine eines Datensatzes
        /// </summary>
        IEnumerable<IDatenbaustein> Datenbausteine { get; }
    }
}
