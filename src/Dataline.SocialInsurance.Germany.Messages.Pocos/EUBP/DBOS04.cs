namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DBOS04 : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBOS04"/> Klasse
        /// </summary>
        public DBOS04()
        {
            KE = "DBOS";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Art des gewählten Wertguthabenmodells
        /// </summary>
        /// <remarks>
        /// 0 = Summenfeldermodell
        /// </remarks>
        public string WGMODELL { get; set; }

        /// <summary>
        /// Holt oder setzt die Summe Wertguthaben §7e SGB IV Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SUMGESO { get; set; }

        /// <summary>
        /// Holt oder setzt KV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int KVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt RV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int RVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt KnV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int KNVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt AV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int AVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt PV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int PVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt UV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int UVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag KV ohne KV-Zusatzbeitrag aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int KVBYANSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag KVZusatzbeitrag aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int KVBYANZUSATZSUMO { get; set; }

    }
}
