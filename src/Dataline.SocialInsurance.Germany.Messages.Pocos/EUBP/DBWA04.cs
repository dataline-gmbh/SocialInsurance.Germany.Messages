// <copyright file="DBWA04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBWA - Datenbaustein Datenbaustein Vortragswerte Wertguthaben West Alternativ-/Options-Modell
    /// </summary>
    public class DBWA04 : DBWWBasis04
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBWA04"/> Klasse
        /// </summary>
        public DBWA04()
        {
            KE = "DBWA";
            WGMODELL = "1";
        }
    }
}
