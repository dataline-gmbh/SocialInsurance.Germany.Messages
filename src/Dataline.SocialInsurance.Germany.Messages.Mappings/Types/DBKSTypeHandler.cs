// <copyright file="DBKSTypeHandler.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeanIO;
using BeanIO.Types;
using SocialInsurance.Germany.Messages.Pocos;

namespace SocialInsurance.Germany.Messages.Mappings.Types
{
    /// <summary>
    /// Eine <see cref="ITypeHandler"/>-Implementation, die DBKS als Basis-Klasse berücksichtigt
    /// </summary>
    public class DBKSTypeHandler : ITypeHandler
    {
        private static readonly Lazy<StreamFactory> _factory = new Lazy<StreamFactory>(() =>
        {
            var factory = StreamFactory.NewInstance();
            factory.Load(Meldungen.LoadMeldungen());
            return factory;
        });

        /// <inheritdoc/>
        public Type TargetType => typeof(DBKS);

        private StreamFactory Factory => _factory.Value;

        /// <inheritdoc/>
        public string Format(object value)
        {
            var output = new StringWriter();
            var writer = Factory.CreateWriter("DBKS", output);
            writer.Write(value);
            writer.Close();
            return output.ToString();
        }

        /// <inheritdoc/>
        public object Parse(string text)
        {
            var reader = Factory.CreateReader("DBKS", new StringReader(text));
            return reader.Read();
        }
    }
}
