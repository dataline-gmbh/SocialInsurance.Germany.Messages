// <copyright file="DSEU.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datensatz Arbeitsbescheinigung bei zwischen- und überstaatlichem Recht
    /// </summary>
    public class DSEU : BasisDatensatzBEA
    {
        private bool? _hatDbsa;
        private bool? _hatDbku;

        /// <summary>
        /// Erstellt eine neue Instanz von <see cref="DSEU"/>.
        /// </summary>
        public DSEU()
        {
            KE = "DSEU";
        }

        /// <summary>
        /// Gibt an, wie wiele Bausteine in <see cref="DBSE"/> vorhanden sind.
        /// </summary>
        public int MMSE
        {
            get => DBSE?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBSA"/> vorhanden ist.
        /// </summary>
        public bool MMSA
        {
            get => _hatDbsa ?? DBSA != null;
            set => _hatDbsa = value;
        }

        /// <summary>
        /// Gibt an, wie wiele Bausteine in <see cref="DBSB"/> vorhanden sind.
        /// </summary>
        public int MMSB
        {
            get => DBSB?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Gibt an, wie wiele Bausteine in <see cref="DBEZ"/> vorhanden sind.
        /// </summary>
        public int MMZU
        {
            get => DBEZ?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Gibt an, wie wiele Bausteine in <see cref="DBEE"/> vorhanden sind.
        /// </summary>
        public int MMEE
        {
            get => DBEE?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Gibt an, wie wiele Bausteine in <see cref="DBFZ"/> vorhanden sind.
        /// </summary>
        public int MMFZ
        {
            get => DBFZ?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBKU"/> vorhanden ist.
        /// </summary>
        public bool MMKU
        {
            get => _hatDbku ?? DBKU != null;
            set => _hatDbku = value;
        }

        /// <summary>
        /// Holt oder setzt eine Sammlung von Datenbausteinen Steuerliche Eckdaten.
        /// </summary>
        public IList<DBSE> DBSE { get; set; }

        /// <summary>
        /// Holt oder setzt den Datenbaustein Sozialversicherungsdaten A.
        /// </summary>
        public DBSA DBSA
        {
            get => ListeDBSA?.SingleOrDefault();
            set
            {
                ListeDBSA = ListeDBSA.Set(value);
                _hatDbsa = null;
            }
        }

        /// <summary>
        /// Holt oder setzt eine Sammlung von Datenbausteinen Sozialversicherungdaten B.
        /// </summary>
        public IList<DBSB> DBSB { get; set; }

        /// <summary>
        /// Holt oder setzt eine Sammlung von Datenbausteinen Arbeitzeit EU.
        /// </summary>
        public IList<DBEZ> DBEZ { get; set; }

        /// <summary>
        /// Holt oder setzt eine Sammlung von Datenbausteinen Entgeltdaten EU.
        /// </summary>
        public IList<DBEE> DBEE { get; set; }

        /// <summary>
        /// Holt oder setzt eine Sammlung von Datenbausteinen Fehlzeit.
        /// </summary>
        public IList<DBFZ> DBFZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Datenbaustein Kündigung/Entlassung EU.
        /// </summary>
        public DBKU DBKU
        {
            get => ListeDBKU?.SingleOrDefault();
            set
            {
                ListeDBKU = ListeDBKU.Set(value);
                _hatDbku = null;
            }
        }

        /// <summary>
        /// Fragt alle Datenbausteine in diesem Datensatz ab.
        /// </summary>
        public override IEnumerable<IDatenbaustein> Datenbausteine
        {
            get
            {
                foreach (var datenbaustein in ListExtensions.Enumerate(base.Datenbausteine, DBSE, ListeDBSA, DBSB, DBEZ, DBEE, DBFZ, ListeDBKU))
                    yield return datenbaustein;
            }
        }

        private IList<DBSA> ListeDBSA { get; set; }

        private IList<DBKU> ListeDBKU { get; set; }
    }
}
