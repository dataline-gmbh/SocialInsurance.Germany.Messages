// <copyright file="DBVA04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBVA - Datenbaustein Datenbaustein Vortragswerte Altersteilzeit Alternativ-/Options-Modell
    /// </summary>
    public class DBVA04 : DBATBasis04
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBVA04"/> Klasse
        /// </summary>
        public DBVA04()
        {
            KE = "DBVA";
            ATZMODELL = "1";
        }
    }
}
