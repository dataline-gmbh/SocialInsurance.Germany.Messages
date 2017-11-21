// <copyright file="Info.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.UV
{
    /// <summary>
    /// Informationen über die Verfahren
    /// </summary>
    public static class Info
    {
        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der DSAS-Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSAS { get; } = new Verfahrenkennzeichen("UVSDD", "UVS", "UNUVS");

        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der DSSD-Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSSD { get; } = new Verfahrenkennzeichen("UVSDD", "UVU", "UVTUN");

        /// <summary>
        /// Holt Informationen zum Verfahren zu dem der DSLN-Datensatz gehört
        /// </summary>
        public static IVerfahrenkennzeichen DSLN { get; } = new Verfahrenkennzeichen("UVELN", "UVL", "UNUVL");
    }
}
