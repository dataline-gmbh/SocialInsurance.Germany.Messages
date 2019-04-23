// <copyright file="DBKSTypeHandler.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.IO;
using System.Text;
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
            using (var meldungen = Meldungen.LoadMeldungen())
                factory.Load(meldungen);
            return factory;
        });

        /// <inheritdoc/>
        public Type TargetType => typeof(DBKS);

        private StreamFactory Factory => _factory.Value;

        /// <inheritdoc/>
        public string Format(object value)
        {
            string returnValue;
            var sb = new StringBuilder(capacity: 220); // Ein DBKS hat derzeit eine Länge von 220 Zeichen.
            using (var output = new StringWriter(sb))
            {
                using (var writer = Factory.CreateWriter("DBKS", output))
                    writer.Write(value);
                returnValue = output.ToString();
            }
            return returnValue;
        }

        /// <inheritdoc/>
        public object Parse(string text)
        {
            object returnObject;
            using (var reader = Factory.CreateReader("DBKS", new StringReader(text)))
                returnObject = reader.Read();
            return returnObject;
        }
    }
}
