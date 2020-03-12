// <copyright file="DBVS04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBVS - Datenbaustein Vortragswerte Saison-Kurzarbeitergeld
    /// </summary>
    public class DBVS04 : DBKGBasis04
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBVS04"/> Klasse
        /// </summary>
        public DBVS04()
        {
            KE = "DBVS";
            KENNZKUG = 1;
        }
    }
}
