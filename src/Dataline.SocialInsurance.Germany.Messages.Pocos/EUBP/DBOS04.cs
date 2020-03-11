// <copyright file="DBOS04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBOS - Datenbaustein Datenbaustein Vortragswerte Wertguthaben Ost Summenfelder-Modell
    /// </summary>
    public class DBOS04 : DBWOBasis04
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBOS04"/> Klasse
        /// </summary>
        public DBOS04()
        {
            KE = "DBOS";
            WGMODELL = "0";
        }
    }
}
