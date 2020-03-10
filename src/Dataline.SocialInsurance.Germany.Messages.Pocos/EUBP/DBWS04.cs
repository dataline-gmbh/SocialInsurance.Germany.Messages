// <copyright file="DBWS04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DBWS04 : DBWWBasis04
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBWS04"/> Klasse
        /// </summary>
        public DBWS04()
        {
            KE = "DBWS";
            WGMODELL = "0";
        }
    }
}
