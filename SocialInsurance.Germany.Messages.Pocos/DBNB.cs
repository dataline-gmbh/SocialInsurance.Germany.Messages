using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBNB - Nebenbeschäftigung Arbeitslose
    /// </summary>
    public class DBNB : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBNB"/> Klasse.
        /// </summary>
        public DBNB()
        {
            KE = "DBNB";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Arbeitsstunden in der ersten Kalenderwoche des Monats
        /// </summary>
        /// <remarks>
        /// Arbeitstunden in der ersten Kalenderwoche des Monats, Länge 4, Mussangabe
        /// dabei sind nur die Stunden aus dem aktuellen Monat zu melden 
        /// </remarks>
        public int STU1KW { get; set; }

        /// <summary>
        /// Holt oder setzt die Arbeitsstunden in der zweiten Kalenderwoche des Monats
        /// </summary>
        /// <remarks>
        /// Arbeitstunden in der zweiten Kalenderwoche des Monats, Länge 4, Mussangabe
        /// dabei sind nur die Stunden aus dem aktuellen Monat zu melden 
        /// </remarks>
        public int STU2KW { get; set; }
        /// <summary>
        /// Holt oder setzt die Arbeitsstunden in der dritten Kalenderwoche des Monats
        /// </summary>
        /// <remarks>
        /// Arbeitstunden in der dritten Kalenderwoche des Monats, Länge 4, Mussangabe
        /// dabei sind nur die Stunden aus dem aktuellen Monat zu melden 
        /// </remarks>
        public int STU3KW { get; set; }
        /// <summary>
        /// Holt oder setzt die Arbeitsstunden in der vierten Kalenderwoche des Monats
        /// </summary>
        /// <remarks>
        /// Arbeitstunden in der vierten Kalenderwoche des Monats, Länge 4, Mussangabe
        /// dabei sind nur die Stunden aus dem aktuellen Monat zu melden 
        /// </remarks>
        public int STU4KW { get; set; }
        /// <summary>
        /// Holt oder setzt die Arbeitsstunden in der fünften Kalenderwoche des Monats
        /// </summary>
        /// <remarks>
        /// Arbeitstunden in der fünften Kalenderwoche des Monats, Länge 4, Mussangabe
        /// dabei sind nur die Stunden aus dem aktuellen Monat zu melden 
        /// </remarks>
        public int STU5KW { get; set; }
        /// <summary>
        /// Holt oder setzt die Arbeitsstunden in der sechsten Kalenderwoche des Monats
        /// </summary>
        /// <remarks>
        /// Arbeitstunden in der sechsten Kalenderwoche des Monats, Länge 4, Mussangabe
        /// dabei sind nur die Stunden aus dem aktuellen Monat zu melden 
        /// </remarks>
        public int STU6KW { get; set; }

        /// <summary>
        /// Holt oder setzt den Tag der Ausgabe falls das Einkommen durch Heimarbeit erzielt wurde        
        /// </summary>
        /// <remarks>
        /// Tag der Ausgabe, falls das Einkommen durch Heimarbeit erzielt wurde, Länge 40, Mussangabe
        /// (kann wahlweise ein Datum oder Freitext sein, z. B. „1. Montag im Monat“)
        /// </remarks>
        public string HEIMARBAUSG { get; set; }

        /// <summary>
        /// Holt oder setzt den Tag der Ablieferung falls das Einkommen durch Heimarbeit erzielt wurde        
        /// </summary>
        /// <remarks>
        /// Tag der Ablieferung, falls das Einkommen durch Heimarbeit erzielt wurde, Länge 40, Mussangabe
        /// (kann wahlweise ein Datum oder Freitext sein, z. B. „1. Montag im Monat“)
        /// </remarks>
        public string HEIMARBABL { get; set; }

    }
}
