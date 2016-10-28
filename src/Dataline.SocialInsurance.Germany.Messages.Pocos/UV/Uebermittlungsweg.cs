// <copyright file="Uebermittlungsweg.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

namespace SocialInsurance.Germany.Messages.Pocos.UV
{
    /// <summary>
    /// Wurde die Meldung über eine Ausfüllhilfe oder ein zertifiziertes Lohnabrechnungsprogramm erstellt?
    /// </summary>
    public enum Uebermittlungsweg
    {
        /// <summary>
        /// Meldung eines Arbeitgebers aus systemgeprüftem Programm (§ 18 DEÜV)
        /// </summary>
        SystemgeprueftesProgramm = 1,

        /// <summary>
        /// Meldung eines Arbeitgebers mittels maschinell erstellter Ausfüllhilfe (§ 18 DEÜV)
        /// </summary>
        Ausfuellhilfe = 5,
    }
}
