// <copyright file="DBFZ.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using NodaTime;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Fehlzeiten
    /// </summary>
    public class DBFZ : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBFZ";

        /// <summary>
        /// Beginn einer Fehlzeit
        /// </summary>
        public LocalDate FEHLBEG { get; set; }

        /// <summary>
        /// Art der Fehlzeit
        /// </summary>
        /// <value>
        /// 01 = Krankengeld/Krankentagegeld/KurzarbeitergeldKrankengeld/Übergangsgeld/Verletztengeld
        /// 02 = Kranken-/Verletztengeld bei Pflege eines kranken Kindes
        /// 03 = Mutterschutzfrist (Mutterschaft nach §§ 3 Abs. 2, 6 Abs. 1 (MuschG)
        /// 04 = Versorgungskrankengeld
        /// 05 = unbezahlte Pflegezeit nach § 2 oder § 3 Abs.1 PflegeZG
        /// 06 = Elternzeit
        /// 07 = Rente wegen voller Erwerbsminderung
        /// 08 = Wehrdienst/Eignungsübung/Zivildienst/Wehrübung
        /// 09 = unbezahlter Urlaub
        /// 10 = sonstige unbezahlte Fehlzeit
        /// 11 = Aussteuerung
        /// 12 = Freistellung wegen Insolvenz
        /// 13 = Pflegeunterstützungsgeld
        /// 14 = Betreuungs-/Begleitzeit gem. §3 Abs. 5 S.1, Abs. 6 S.1
        /// </value>
        public int FEHLART { get; set; }

        /// <summary>
        /// Ende der Fehlzeit
        /// </summary>
        public LocalDate? FEHLEND { get; set; }
    }
}
