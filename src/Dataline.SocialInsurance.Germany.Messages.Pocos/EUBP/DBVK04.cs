// <copyright file="DBVK04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBVK - Datenbaustein Vortragswerte Kurzarbeitergeld
    /// </summary>
    public class DBVK04 : DBKGBasis04
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBVK04"/> Klasse
        /// </summary>
        public DBVK04()
        {
            KE = "DBVK";
            KENNZKUG = 0;
        }
    }
}
