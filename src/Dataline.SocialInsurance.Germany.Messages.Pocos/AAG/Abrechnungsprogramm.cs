// <copyright file="Abrechnungsprogramm.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.AAG
{
    /// <summary>
    /// Wurde die Meldung über eine Ausfüllhilfe oder ein zertifiziertes Entgeltabrechnungsprogramm erstellt?
    /// </summary>
    public enum Abrechnungsprogramm
    {
        /// <summary>
        /// Meldung aus systemgeprüftem Programm
        /// </summary>
        SystemgeprueftesProgramm = 1,

        /// <summary>
        /// Meldung mittels systemgeprüfter Ausfüllhilfe
        /// </summary>
        Ausfuellhilfe = 2,
    }
}
