// <copyright file="DatumLaufendHandler.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

#pragma warning disable

using System;
using BeanIO.Types;
using NodaTime;
using NodaTime.Text;

namespace SocialInsurance.Germany.Messages.Mappings.Types
{
    public sealed class DatumLaufendHandler : ITypeHandler
    {
        private static readonly LocalDatePattern MeldungDatumFormat;

        static DatumLaufendHandler()
        {
            MeldungDatumFormat = LocalDatePattern.CreateWithInvariantCulture("yyyyMMdd");
        }

        public Type TargetType => typeof(LocalDate);

        public string Format(object value)
        {
            switch (value)
            {
                case null:
                    return "00000000";
                case LocalDate ld when ld.Year == 9999:
                    return "99999999";
                case LocalDate ld:
                    return MeldungDatumFormat.Format(ld);
                default:
                    throw new NotSupportedException();
            }
        }

        public object Parse(string text)
        {
            if (text is null)
                return null;
            switch (text.Substring(0, 4))
            {
                case "0000":
                    return null;
                case "9999":
                    return new LocalDate(9999, 12, 31);
                default:
                    return MeldungDatumFormat.Parse(text);
            }
        }
    }
}
