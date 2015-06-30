using System.Collections.Generic;
namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Schnittstelle für Datensätze
    /// </summary>
    public interface IDatensatz
    {
        /// <summary>
        /// Holt die Kennung für den Datensatz
        /// </summary>
        string KE { get; }

        DBFE Fehler { get; }
    }
}
