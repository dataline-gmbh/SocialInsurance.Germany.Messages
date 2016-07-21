// <copyright file="FehlerKennzeichen.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.ComponentModel;

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
