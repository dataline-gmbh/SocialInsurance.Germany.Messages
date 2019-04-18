// <copyright file="DBTK.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Zusatzdaten für die Berechnung der Entgeltersatzleistungen
    /// bei Bezug von Transfer-Kurzarbeitergeld
    /// </summary>
    public class DBTK : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBTK"/>-Objekt.
        /// </summary>
        public DBTK()
        {
            KE = "DBTK";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Brutto-Arbeitsentgelt, das für die Berechnung des Transfer-KUG zugrunde gelegt wird.
        /// </summary>
        public int BRUTTOSOLL { get; set; }

        /// <summary>
        /// Holt oder setzt das Netto-Arbeitsentgelt, das für die Berechnung des Transfer-KUG zugrunde gelegt wird.
        /// </summary>
        public int NETTOSOLL { get; set; }

        /// <summary>
        /// Holt oder setzt das tatsächlich geflossene Transfer-KUG.
        /// </summary>
        public int TRANSFERKUG { get; set; }

        /// <summary>
        /// Holt oder setzt das tatsächlich erzielte Brutto-Arbeitsentgelt.
        /// </summary>
        public int BRUTTOIST { get; set; }

        /// <summary>
        /// Holt oder setzt das tatsächlich erzielte Netto-Arbeitsentgelt.
        /// </summary>
        public int NETTOIST { get; set; }

        /// <summary>
        /// Holt oder setzt den Aufstockungsbetrag.
        /// </summary>
        public int AUFSTOCKUNGSBETRAG { get; set; }
    }
}
