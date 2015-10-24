// <copyright file="NumericEnumTypeHandler{T}.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using BeanIO.Types;

namespace SocialInsurance.Germany.Messages.Mappings.Types
{
    /// <summary>
    /// Eine <see cref="ITypeHandler"/>-Implementation, die das <see cref="Enum"/> in Zahlen konvertiert (und umgekehrt)
    /// </summary>
    /// <typeparam name="T">Der Enum-Typ</typeparam>
    public class NumericEnumTypeHandler<T> : ITypeHandler
    {
        /// <inheritdoc/>
        public Type TargetType
        {
            get { return typeof(T); }
        }

        /// <inheritdoc/>
        public string Format(object value)
        {
            if (value == null)
                return null;
            return string.Format("{0:D}", value);
        }

        /// <inheritdoc/>
        public object Parse(string text)
        {
            if (string.IsNullOrEmpty(text))
                return null;
            return Enum.Parse(typeof(T), text);
        }
    }
}
