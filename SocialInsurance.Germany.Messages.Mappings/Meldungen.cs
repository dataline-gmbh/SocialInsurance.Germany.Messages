// <copyright file="Meldungen.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Mappings
{
    /// <summary>
    /// Hilfsklasse für die Abfrage des <see cref="Stream"/> der alle Mappings enthält.
    /// </summary>
    public static class Meldungen
    {
        /// <summary>
        /// Lädt den <see cref="Stream"/> der alle Mappings enthält.
        /// </summary>
        /// <returns>Der <see cref="Stream"/> der alle Mappings enthält</returns>
        public static Stream LoadMeldungen()
        {
            var asm = typeof(Meldungen).GetTypeInfo().Assembly;
            return asm.GetManifestResourceStream("SocialInsurance.Germany.Messages.Mappings.Meldungen.xml");
        }
    }
}
