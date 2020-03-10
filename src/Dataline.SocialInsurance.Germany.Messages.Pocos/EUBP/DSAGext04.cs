// <copyright file="DSAGext04.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EUBP
{
    public class DSAGext04
    {
        /// <summary>
        /// Holt oder setzt das Gültigkeitsdatum ab
        /// </summary>
        public LocalDate GLTAB { get; set; }

        /// <summary>
        /// Holt oder setzt das Änderungsdatum
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Änderung der Daten, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime AENDDAT { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Betriebes/Betriebsteils/Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Länge 35, Mussangabe
        /// </remarks>
        public string NAME { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl des Betriebes/Betriebsteils/Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Länge 10, Kannangabe
        /// </remarks>
        public string PLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort des Betriebes/Betriebsteils/Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Länge 34, Kannangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße des Betriebes/Betriebsteils/Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Länge 33, Kannangabe
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer des Betriebes/Betriebsteils/Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Länge 9, Kannangabe
        /// </remarks>
        public string HNR { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Umlagepflicht des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// 0-Nein
        /// 1-ja, aber nur U2
        /// 2-ja, U1 und U2
        /// </remarks>
        public int KENNZUM { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen Insolvenzgeld-Umlagepflicht des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// 0-Nein
        /// 1-Ja
        /// </remarks>
        public int KENNZUI { get; set; }

        /// <summary>
        /// Holt oder setzt die Bundesfinanzamtsnummer
        /// </summary>
        /// <remarks>
        /// Länge 4, Kannangabe
        /// </remarks>
        public int BUFANR { get; set; }

        /// <summary>
        /// Holt oder setzt die Steuernummer des Betriebes
        /// </summary>
        /// <remarks>
        /// Länge 20, Kannangabe
        /// </remarks>
        public string STNR { get; set; }
    }
}
