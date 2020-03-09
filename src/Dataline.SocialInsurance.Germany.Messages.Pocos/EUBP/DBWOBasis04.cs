namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public abstract class DBWOBasis04 : IDatenbaustein
    {
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
        /// 1 = Alternativ-/Optionsmodell
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
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt RV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt KnV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt AV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt PV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt UV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? UVPFLAEGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag KV ohne KV-Zusatzbeitrag aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYANSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag KVZusatzbeitrag aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYANZUSATZSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag AV aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBYANSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag PV aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBYANSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag KV ohne KV-Zusatzbeitrag aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYAGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag KV-Zusatzbeitrag aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYAGZUSATZSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag RV aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVBYAGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag KnV aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVBYAGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag AV aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBYAGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag PV aus angespartem Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBYAGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Summe des steuerfreien Anteils am Wertguthaben Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? STFRSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft KV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int KVSVLUFTO { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft RV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVSVLUFTO { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft KnV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVSVLUFTO { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft AV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int AVSVLUFTO { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft PV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int PVSVLUFTO { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVABGEGRSVLUFTSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVABGEGRSVLUFTSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVABGEGRSVLUFTSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVABGEGRSVLUFTSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVABGEGRSVLUFTSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Entgeltguthabenaufbau monatl. Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? EGAUFO { get; set; }

        /// <summary>
        /// Holt oder setzt Entgeltguthabenabbau monatl. Ost
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? EGABO { get; set; }

        /// <summary>
        /// Holt oder setzt KV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVEGAO { get; set; }

        /// <summary>
        /// Holt oder setzt RV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVEGAO { get; set; }

        /// <summary>
        /// Holt oder setzt KnV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVEGAO { get; set; }

        /// <summary>
        /// Holt oder setzt AV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVEGAO { get; set; }

        /// <summary>
        /// Holt oder setzt PV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVEGAO { get; set; }

        /// <summary>
        /// Holt oder setzt Summe meldepflichtiges Entgelt bei Störfall WG
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int EG { get; set; }

        /// <summary>
        /// Holt oder setzt Wertguthaben (Ost) enthaltener AG-Anteil am GSV-Beitrag, kumuliert seit 01.01.2009 oder späterem Abschluss
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int GSVAGSUMO { get; set; }

        /// <summary>
        /// Holt oder setzt Anzahl Verträge zu flexiblen Arbeitsregelungen (Ost)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 1, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int ANZVTO { get; set; }
    }
}
