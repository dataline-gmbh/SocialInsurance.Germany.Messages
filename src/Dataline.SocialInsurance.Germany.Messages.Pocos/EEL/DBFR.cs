// <copyright file="DBFR.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.EEL
{
    /// <summary>
    /// Datenbaustein Angaben zur Freistellung bei Erkrankung/Verletzung des Kindes
    /// </summary>
    public class DBFR : IDatenbaustein
    {
        /// <summary>
        /// Erstellt ein neues <see cref="DBFR"/>-Objekt.
        /// </summary>
        public DBFR()
        {
            KE = "DBFR";
        }

        /// <summary>
        /// Holt oder setzt die Kennung.
        /// </summary>
        /// <remarks>Kennung, um welchen Datenbaustein es sich handelt</remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt, zu wann das Beschäftigungsverhältnis beendet wird.
        /// </summary>
        public LocalDate? ENDEBVZUM { get; set; }

        /// <summary>
        /// Holt oder setzt, von welchem Tag an der Arbeitnehmer wegen Erkrankung/Verletzung des Kindes freigestellt ist.
        /// </summary>
        public LocalDate FREISTVOM { get; set; }

        /// <summary>
        /// Holt oder setzt, bis zu welchem Tag der Arbeitnehmer wegen Erkrankung/Verletzung des Kindes freigestellt ist.
        /// </summary>
        public LocalDate FREISTBIS { get; set; }

        /// <summary>
        /// Holt oder setzt, ob am ersten Tag der Freistellung noch gearbeitet und für den gesamten Tag Arbeitsentgelt gezahlt wurde.
        /// </summary>
        public bool VAEERSTTAG { get; set; }

        /// <summary>
        /// Holt oder setzt die Gesamtzahl der Tage der Freistellung.
        /// </summary>
        public int TAGE { get; set; }

        /// <summary>
        /// Holt oder setzt, ob der Anspruch auf bezahlte Freistellung im Freistellungszeitraum gegeben ist.
        /// </summary>
        /// <value>0 = gegeben, 1-3 = ausgeschlossen (1 = Tarifvertrag, 2 = Betriebsvereinbarung, 3 = Arbeitsvertrag)</value>
        public int KEINEFREIST { get; set; }

        /// <summary>
        /// Holt oder setzt, inwieweit der Anspruch auf bezahlte Freistellung auf die Anzahl der Arbeitstage beschränkt ist.
        /// </summary>
        public int BEGRZFREIST { get; set; }

        /// <summary>
        /// Holt oder setzt, von welchem Tag an der Arbeitnehmer wegen Erkrankung/Verletzung des Kindes bezahlt freigestellt ist.
        /// </summary>
        public LocalDate? BEZFREISTVOM { get; set; }

        /// <summary>
        /// Holt oder setzt, bis zu welchem Tag der Arbeitnehmer wegen Erkrankung/Verletzung des Kindes bezahlt freigestellt ist.
        /// </summary>
        public LocalDate? BEZFREISTBIS { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der bezahlten Freistellungstage im Kalenderjahr der Freistellung.
        /// </summary>
        public int BEZFREISTJAHR { get; set; }

        /// <summary>
        /// Holt oder setzt das während der Freistellung ausgefallene Bruttoarbeitsentgelt.
        /// </summary>
        public int FREISTBRUTTO { get; set; }

        /// <summary>
        /// Holt oder setzt das während der Freistellung ausgefallene Nettoarbeitsentgelt.
        /// </summary>
        public int FREISTNETTO { get; set; }

        /// <summary>
        /// Holt oder setzt, ob in den letzten 12 Kalendermonaten beitragspflichtige Einmalzahlungen gezahlt wurden.
        /// </summary>
        public bool FREISTEZ { get; set; }
    }
}
