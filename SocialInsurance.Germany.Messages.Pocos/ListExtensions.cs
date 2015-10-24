// <copyright file="ListExtensions.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Erweiterungsfunktionen für <see cref="IList{T}"/>
    /// </summary>
    internal static class ListExtensions
    {
        /// <summary>
        /// Fügt <paramref name="newValue"/> der Liste hinzu. Alle alten Werte werden entfernt.
        /// </summary>
        /// <typeparam name="T">Der Elementtyp von <paramref name="list"/></typeparam>
        /// <param name="list">Die Liste, die <paramref name="newValue"/> als einzigen Wert enthalten soll</param>
        /// <param name="newValue">Der zu setzende Wert</param>
        /// <returns>Die geänderte oder neu erstellte Liste</returns>
        /// <remarks>
        /// Nicht löschen. Es ist korrekt, dass die Datenbausteine als Liste gespeichert werden, da dies durch die
        /// Mappings notwendig ist.
        /// </remarks>
        public static IList<T> Set<T>(this IList<T> list, T newValue)
        {
            if (list == null)
            {
                list = new List<T>();
            }
            else
            {
                list.Clear();
            }

            if (newValue != null)
                list.Add(newValue);
            return list;
        }
    }
}
