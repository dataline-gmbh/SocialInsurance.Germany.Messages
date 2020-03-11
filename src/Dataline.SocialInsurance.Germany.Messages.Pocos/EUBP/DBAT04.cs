// <copyright file="DBAT04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// DBAT - Datenbaustein Altersteilzeit
    /// </summary>
    public class DBAT04 : DBATBasis04
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBAT04"/> Klasse
        /// </summary>
        public DBAT04()
        {
            KE = "DBAT";
        }
    }
}
