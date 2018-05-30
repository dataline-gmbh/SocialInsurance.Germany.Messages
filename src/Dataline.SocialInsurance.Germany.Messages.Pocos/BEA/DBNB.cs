// <copyright file="DBNB.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datenbaustein Nebenbeschäftigung Arbeitslose
    /// </summary>
    public class DBNB : IDatenbaustein
    {
        /// <summary>
        /// Kennung
        /// </summary>
        public string KE { get; set; } = "DBNB";

        /// <summary>
        /// Tatsächliche Arbeitszeit in der 1. Kalenderwoche des Monats
        /// </summary>
        public int STU1KW { get; set; }

        /// <summary>
        /// Tatsächliche Arbeitszeit in der 2. Kalenderwoche des Monats
        /// </summary>
        public int STU2KW { get; set; }

        /// <summary>
        /// Tatsächliche Arbeitszeit in der 3. Kalenderwoche des Monats
        /// </summary>
        public int STU3KW { get; set; }

        /// <summary>
        /// Tatsächliche Arbeitszeit in der 4. Kalenderwoche des Monats
        /// </summary>
        public int STU4KW { get; set; }

        /// <summary>
        /// Tatsächliche Arbeitszeit in der 5. Kalenderwoche des Monats
        /// </summary>
        public int STU5KW { get; set; }

        /// <summary>
        /// Tatsächliche Arbeitszeit in der 6. Kalenderwoche des Monats
        /// </summary>
        public int STU6KW { get; set; }
    }
}
