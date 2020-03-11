// <copyright file="DBOA04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBOA - Datenbaustein Vortragswerte Wertguthaben Ost Alternativ-/Options-Modell
    /// </summary>
    public class DBOA04 : DBWOBasis04
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBOA04"/> Klasse
        /// </summary>
        public DBOA04()
        {
            KE = "DBOA";
            WGMODELL = "1";
        }
    }
}
