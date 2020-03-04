// <copyright file="Info.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    /// <summary>
    /// Informationen über die Verfahren
    /// </summary>
    public static class Info
    {
        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSAG { get; } = new Verfahrenkennzeichen("EUBP ", "EBE", "AGBPL");

        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSEK { get; } = new Verfahrenkennzeichen("EUBP ", "EBE", "AGBPL");

        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSBN { get; } = new Verfahrenkennzeichen("EUBP ", "EBE", "AGBPL");

        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSAN { get; } = new Verfahrenkennzeichen("EUBP ", "EBE", "AGBPL");

        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSLA { get; } = new Verfahrenkennzeichen("EUBP ", "EBE", "AGBPL");
    }
}
