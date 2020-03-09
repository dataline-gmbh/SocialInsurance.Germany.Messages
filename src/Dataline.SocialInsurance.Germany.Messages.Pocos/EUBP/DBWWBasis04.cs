namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public abstract class DBWWBasis04 : IDatenbaustein
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
        /// Holt oder setzt die Summe Wertguthaben §7e SGB IV West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int SUMGESW { get; set; }

        /// <summary>
        /// Holt oder setzt KV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVPFLAEGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt RV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVPFLAEGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt KnV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVPFLAEGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt AV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVPFLAEGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt PV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVPFLAEGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt UV-pflichtiges Arbeitsentgelt aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? UVPFLAEGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag KV ohne KV-Zusatzbeitrag aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYANSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag KVZusatzbeitrag aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYANZUSATZSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag AV aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBYANSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag PV aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBYANSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag KV ohne KV-Zusatzbeitrag aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYAGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag KV-Zusatzbeitrag aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVBYAGZUSATZSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitnehmerbeitrag RV aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVBYAGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag KnV aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVBYAGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag AV aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVBYAGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Arbeitgeberbeitrag PV aus angespartem Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVBYAGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Summe des steuerfreien Anteils am Wertguthaben West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? STFRSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft KV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int KVSVLUFTW { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft RV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVSVLUFTW { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft KnV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVSVLUFTW { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft AV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int AVSVLUFTW { get; set; }

        /// <summary>
        /// Holt oder setzt SV-Luft PV
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int PVSVLUFTW { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVABGEGRSVLUFTSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVABGEGRSVLUFTSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVABGEGRSVLUFTSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVABGEGRSVLUFTSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt abgegrenzte SV-Luft bei Alternativ-/Optionsmodell
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVABGEGRSVLUFTSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Entgeltguthabenaufbau monatl. West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? EGAUFW { get; set; }

        /// <summary>
        /// Holt oder setzt Entgeltguthabenabbau monatl. West
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? EGABW { get; set; }

        /// <summary>
        /// Holt oder setzt KV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KVEGAW { get; set; }

        /// <summary>
        /// Holt oder setzt RV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? RVEGAW { get; set; }

        /// <summary>
        /// Holt oder setzt KnV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? KNVEGAW { get; set; }

        /// <summary>
        /// Holt oder setzt AV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? AVEGAW { get; set; }

        /// <summary>
        /// Holt oder setzt PV-beitragspflichtiger Teil der Einmalzahlung, der unabhängig vom Störfall fällig geworden wäre
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Kannangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int? PVEGAW { get; set; }

        /// <summary>
        /// Holt oder setzt Summe meldepflichtiges Entgelt bei Störfall WG
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int EG { get; set; }

        /// <summary>
        /// Holt oder setzt Wertguthaben (West) enthaltener AG-Anteil am GSV-Beitrag, kumuliert seit 01.01.2009 oder späterem Abschluss
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 10, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int GSVAGSUMW { get; set; }

        /// <summary>
        /// Holt oder setzt Anzahl Verträge zu flexiblen Arbeitsregelungen (West)
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 1, Mussangabe
        /// EURO/CENT mit zwei Nachkommastellen
        /// </remarks>
        public int ANZVTW { get; set; }
    }
}
