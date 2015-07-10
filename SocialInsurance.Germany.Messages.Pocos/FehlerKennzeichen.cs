using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Fehlerkennzeichen für das Feld FEKZ als Enum
    /// </summary>
    public enum FehlerKennzeichen
    {
        /// <summary>
        /// keine Fehler, 0
        /// </summary>
        Fehlerfrei,
        /// <summary>
        /// enthält Fehler, 1
        /// </summary>
        Fehlerhaft,
        /// <summary>
        /// Manuelle Nachbearbeitung
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        ManuelleNachbearbeitung,
        /// <summary>
        /// Hinweis
        /// </summary>
        Hinweis,
        /// <summary>
        /// Ergebnis Statusfeststellung
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        ErgebnisStatusfeststellung,
    }
}
