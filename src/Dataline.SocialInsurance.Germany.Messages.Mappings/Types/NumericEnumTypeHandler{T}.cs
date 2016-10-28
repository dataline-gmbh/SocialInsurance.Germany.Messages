// <copyright file="NumericEnumTypeHandler{T}.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using BeanIO.Config;
using BeanIO.Types;

namespace SocialInsurance.Germany.Messages.Mappings.Types
{
    /// <summary>
    /// Eine <see cref="ITypeHandler"/>-Implementation, die das <see cref="Enum"/> in Zahlen konvertiert (und umgekehrt)
    /// </summary>
    /// <typeparam name="T">Der Enum-Typ</typeparam>
    public class NumericEnumTypeHandler<T> : IConfigurableTypeHandler
    {
        private string _format = "{0:D}";

        /// <inheritdoc/>
        public Type TargetType => typeof(T);

        public void Configure(Properties properties)
        {
            foreach (var property in properties)
            {
                var propName = property.Key;
                var propValue = property.Value;
                switch (propName)
                {
                    case "format":
                        _format = $"{{0:{propValue}}}";
                        break;
                }
            }
        }

        /// <inheritdoc/>
        public string Format(object value)
        {
            return value == null ? null : string.Format(_format, value);
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
