using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBQK - Quittung-KVdR
    /// </summary>
    public class DBQK : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBQK"/> Klasse.
        /// </summary>
        public DBQK()
        {
            KE = "DBQK";
            VF = "KVDR";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, KVDR = Quittung- KVdR, Länge 5
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Verarbeitung der quittierten Datei
        /// </summary>
        /// <remarks>
        /// Datum der Verarbeitung der quittierten Datei, Länge 8, Mussangabe
        /// </remarks>
        public DateTime VD { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Erstellung der quittierten Datei
        /// </summary>
        /// <remarks>
        /// Datum der Erstellung der quittierten Datei, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Dateinummer der Sendung
        /// </summary>
        /// <remarks>
        /// Dateinummer der Sendung, Länge 6, Mussangabe
        /// </remarks>
        public string DTNR { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der übermittelten KVdR-Datensätze
        /// </summary>
        /// <remarks>
        /// Anzahl der übermittelten KVdR-Datensätze ohne Vor- und Nachlaufsatz, Länge 8
        /// </remarks>
        public string ANZDS { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der fehlerfreien Datensätze
        /// </summary>
        /// <remarks>
        /// Anzahl der fehlerfreien Datensätze, Länge 8, Mussangabe
        /// </remarks>
        public string ANZOK { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der fehlerhaften Datensätze
        /// </summary>
        /// <remarks>
        /// Anzahl der fehlerhaften Datensätze, Länge 8, Mussangabe
        /// </remarks>
        public string ANZFE { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der erstellten Hinweise
        /// </summary>
        /// <remarks>
        /// Anzahl der erstellten Hinweise, Länge 8, Mussangabe
        /// </remarks>
        public string ANZHW { get; set; }
    }
}
