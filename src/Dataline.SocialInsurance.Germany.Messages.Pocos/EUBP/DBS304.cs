// <copyright file="DBS304.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DBS304 : IDatenbaustein
    {
        public DBS304()
        {
            KE = "DBS3";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die ID für Seemännische Berufsgruppen
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// bei Bedarf im Pflichtenheft nachsehen
        /// </remarks>
        public int BERUFSGR { get; set; }

        /// <summary>
        /// Holt oder setzt die Versicherungsart
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// bei Bedarf im Pflichtenheft nachsehen
        /// </remarks>
        public int VERSART { get; set; }

        /// <summary>
        /// Holt oder setzt die Fahrzeuggruppe
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// bei Bedarf im Pflichtenheft nachsehen
        /// </remarks>
        public int FZGR { get; set; }

        /// <summary>
        /// Holt oder setzt die Patente
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// bei Bedarf im Pflichtenheft nachsehen
        /// </remarks>
        public int PAT { get; set; }

        /// <summary>
        /// Holt oder setzt die Beitragspflicht zur SMK
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// 0-nein
        /// 1-nur AG-Anteil
        /// 2- AG- und AN-Anteil
        /// </remarks>
        public int KENNZSMK { get; set; }

        /// <summary>
        /// Holt oder setzt das Durchschnitts-Heuerkennzeichen der BG Verkehr
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// </remarks>
        public int DHEUERKENNZ { get; set; }

        /// <summary>
        /// Holt oder setzt die monatl. Durchschnitts-Heuer
        /// </summary>
        /// <remarks>
        /// Mussangabe
        /// Länge 10, 2 NK
        /// </remarks>
        public int DHEUER { get; set; }
    }
}
