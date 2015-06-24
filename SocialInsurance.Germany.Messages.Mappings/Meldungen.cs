using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Mappings
{
    public static class Meldungen
    {
        public static Stream LoadMeldungen()
        {
            var asm = typeof(Meldungen).GetTypeInfo().Assembly;
            return asm.GetManifestResourceStream("SocialInsurance.Germany.Messages.Mappings.Meldungen.xml");
        }
    }
}
