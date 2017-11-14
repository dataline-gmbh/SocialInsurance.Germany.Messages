// <copyright file="Info.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.AAG
{
    /// <summary>
    /// Informationen über die Verfahren
    /// </summary>
    public static class Info
    {
        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der DSAS-Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSER { get; } = new Verfahrenkennzeichen("AAGER", "AAG", "AGAAG");

        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der DSSD-Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSRA { get; } = new Verfahrenkennzeichen("AAGER", "AAK", "AGAAG");
    }
}
