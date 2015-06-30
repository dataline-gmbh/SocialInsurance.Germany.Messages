using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    public enum FehlerKennzeichen
    {
        Fehlerfrei,
        Fehlerhaft,
        [EditorBrowsable(EditorBrowsableState.Never)]
        ManuelleNachbearbeitung,
        Hinweis,
        [EditorBrowsable(EditorBrowsableState.Never)]
        ErgebnisStatusfeststellung,
    }
}
