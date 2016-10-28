// <copyright file="DBFU.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos.UV
{
    public class DBFU : IDatenbaustein
    {
        /// <inheritdoc />
        public string KE { get; set; } = "DBFU";

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten FU-Daten (maximal 9)
        /// </summary>
        public int ANFU
        {
            get { return Meldungen?.Count ?? 0; }

            // ReSharper disable once ValueParameterNotUsed
            // ReSharper disable once UnusedMember.Local
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Liste mit Fehlermeldungen
        /// </summary>
        public IList<DBFUMeldung> Meldungen { get; set; }

        /// <summary>
        /// Fehlermeldung für den DBFU-Datenbaustein
        /// </summary>
        public class DBFUMeldung
        {
            /// <summary>
            /// Holt oder setzt den Stammdatenfehler
            /// </summary>
            /// <remarks>
            /// Fehlernummer des Stammdatenfehlers plus 1 Leerzeichen plus Fehlertext
            /// 72 Stellen, Alphanumerisch, Mussfeld
            /// </remarks>
            public string FU { get; set; }

            /// <summary>
            /// Holt oder setzt einen Wert, der angibt ob ein Eintrag inder QM-Datenbank erfolgt
            /// </summary>
            /// <remarks>
            /// 1 Stelle, Numerisch, Mussfeld (0 oder 1)
            /// </remarks>
            public bool QMDB { get; set; }
        }
    }
}
