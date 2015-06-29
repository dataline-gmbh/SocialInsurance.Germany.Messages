using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBTN - Datenbaustein Teilnahmepflichten
    /// </summary>
    public class DBTN : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBTN"/> Klasse.
        /// </summary>
        public DBTN()
        {
            KE = "DBTN";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Sofortmeldepflicht
        /// </summary>
        /// <remarks>
        /// Entscheidung, ob der Betrieb der Sofortmeldepflicht unterliegt, Länge 1, Mussangabe
        /// J = Ja, N = Nein
        /// </remarks>
        public string SOFOPFL { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Entscheidung zur Sofortmeldepflicht
        /// </summary>
        /// <remarks>
        /// Entscheidung zur Sofortmeldepflicht, Länge 8, Mussangabe unter Bedingungen
        /// </remarks>
        public DateTime DATENTSO { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Verpflichtung zur Abgabe einer Sofortmeldung
        /// </summary>
        /// <remarks>
        /// Datum, ab wann die Verpflichtung zur Abgabe einer Sofortmeldung besteht bzw. nicht besteht, Länge 8, Mussangabe unter Bedingungen
        /// </remarks>
        public DateTime GUELTSO { get; set; }
        
        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Krankenkasse, die über die Sofortmeldepflicht entschieden hat
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Krankenkasse, die über die Sofortmeldepflicht entschieden hat, Länge 15, Mussangabe unter Bedingungen
        /// </remarks>
        public string BBNRENTSO { get; set; }

        /// <summary>
        /// Holt oder setzt die Insolvenzgeldumlagepflicht
        /// </summary>
        /// <remarks>
        /// Entscheidung, ob der Betrieb der Insolvenzgeldumlage-pflicht unterliegt, Länge 1, Mussangabe
        /// J = Ja, N = Nein
        /// </remarks>
        public string INSOLVUPFL { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Entscheidung zur Insolvenzgeldumlagepflicht
        /// </summary>
        /// <remarks>
        /// Datum der Entscheidung zur Insolvenzgeldumlage-pflicht, Länge 8, Mussangabe unter Bedingungen
        /// </remarks>
        public DateTime DATENTIU { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Insolvenzgeldumlagepflicht
        /// </summary>
        /// <remarks>
        /// Datum, ab wann die Teilnahme an der Insolvenzgeldumlagepflicht besteht oder nicht, Länge 8, Mussangabe unter Bedingungen
        /// </remarks>
        public DateTime GUELTIU { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnumer der Krankenkasse, die über die Insolvenzgeldumlagepflicht entschieden hat
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Krankenkasse, die über die Insolvenzgeldumlagepflicht entschieden hat, Länge 15, Mussangabe unter Bedingungen
        /// </remarks>
        public string BBNRENTIU { get; set; }

        /// <summary>
        /// Holt oder setzt die Umlagepflicht U1-Entscheidung
        /// </summary>
        /// <remarks>
        /// Entscheidung, ob der Betrieb der Umlagepflicht U1unterliegt, Länge 1, Mussangabe
        /// J = Ja, N = Nein
        /// </remarks>
        public string U1PFL { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum der Entscheidung zur Umlagepflicht U1
        /// </summary>
        /// <remarks>
        /// Datum der Entscheidung zur Umlagepflicht U1, Länge 8, Mussangabe unter Bedingungen
        /// </remarks>
        public DateTime DATENTU1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Datum, ab wann die Teilnahme an der Umlage 1 besteht oder nicht
        /// </summary>
        /// <remarks>
        /// Datum, ab wann die Teilnahme an der Umlage 1 besteht oder nicht, Länge 8, Mussangabe unter Bedingungen
        /// </remarks>
        public DateTime GUELTU1 { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Krankenkasse, die über die Umlagepflicht U1 entschieden hat
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Krankenkasse, die über die Umlagepflicht U1 entschieden hat, Länge 15, Mussangabe unter Bedingungen
        /// </remarks>
        public string BBNRENTU1 { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 8, Mussangabe
        /// </remarks>
        public string RESERVE { get; set; }
    }
}
