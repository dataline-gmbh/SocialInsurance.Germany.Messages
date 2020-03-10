// <copyright file="DBVF04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DBVF04 : DBATBasis04
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBVF04"/> Klasse
        /// </summary>
        public DBVF04()
        {
            KE = "DBVF";
            ATZMODELL = "0";
        }
    }
}
