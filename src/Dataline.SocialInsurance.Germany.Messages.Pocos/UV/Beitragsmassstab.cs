// <copyright file="Beitragsmassstab.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.UV
{
    /// <summary>
    /// Der Massstab der Beiträge
    /// </summary>
    public enum Beitragsmassstab
    {
        /// <summary>
        /// Entgelt (der angezeigte Lohnnachweis wird auf Basis von Entgelten erwartet)
        /// </summary>
        Entgelt = 1,

        /// <summary>
        /// Arbeitsstunden (der angezeigte Lohnnachweis wird auf Basis von Arbeitsstunden als Beitragsgrundlage erwartet)
        /// </summary>
        Arbeitsstunden,

        /// <summary>
        /// Versicherte (der angezeigte Lohnnachweis wird auf Basis der Versichertenanzahl als Beitragsgrundlage erwartet)
        /// </summary>
        Versicherte,

        /// <summary>
        /// Einwohnerzahlen (es wird kein Lohnnachweis erwartet)
        /// </summary>
        Einwohnerzahlen,

        /// <summary>
        /// rivathaushalte (es wird kein Lohnnachweis erwartet)
        /// </summary>
        Privathaushalte,

        /// <summary>
        /// Sonstige Unternehmen ohne Meldepflicht (es wird kein Lohnnachweis erwartet)
        /// </summary>
        SonstigeUnternehmenOhneMeldepflicht,
    }
}
