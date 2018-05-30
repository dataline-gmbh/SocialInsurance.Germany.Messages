// <copyright file="DSAB.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datensatz Arbeitsbescheinigung
    /// </summary>
    public class DSAB : BasisDatensatzBEA
    {
        private bool? _hatDbsa;
        private bool? _hatDbha;
        private bool? _hatDbke;

        /// <summary>
        /// Erstellt eine neue Instanz von <see cref="DSAB"/>.
        /// </summary>
        public DSAB()
        {
            KE = "DSAB";
        }

        /// <summary>
        /// Holt oder setzt die Anzahl der Datenbausteine in <see cref="DBSE"/>.
        /// </summary>
        public int MMSE
        {
            get => DBSE?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Holt oder setzt, ob der Datenbaustein <see cref="DBSA"/> vorhanden ist.
        /// </summary>
        public bool MMSA
        {
            get => _hatDbsa ?? DBSA != null;
            set => _hatDbsa = value;
        }

        /// <summary>
        /// Holt oder setzt die Anzahl der Datenbausteine in <see cref="DBSB"/>.
        /// </summary>
        public int MMSB
        {
            get => DBSB?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Anzahl der Datenbausteine in <see cref="DBAZ"/>.
        /// </summary>
        public int MMAZ
        {
            get => DBAZ?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Anzahl der Datenbausteine in <see cref="DBEN"/>.
        /// </summary>
        public int MMEN
        {
            get => DBEN?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Anzahl der Datenbausteine in <see cref="DBFZ"/>.
        /// </summary>
        public int MMFZ
        {
            get => DBFZ?.Count ?? 0;
            private set { }
        }

        /// <summary>
        /// Holt oder setzt, ob der Datenbaustein <see cref="DBHA"/> vorhanden ist.
        /// </summary>
        public bool MMHA
        {
            get => _hatDbha ?? DBHA != null;
            set => _hatDbha = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Datenbaustein <see cref="DBKE"/> vorhanden ist.
        /// </summary>
        public bool MMKE
        {
            get => _hatDbke ?? DBKE != null;
            set => _hatDbke = value;
        }

        /// <summary>
        /// Holt oder setzt eine Liste der Datenbausteine Steuerliche Eckdaten.
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
        /// Holt oder setzt eine Liste der Datenbausteine Sozialversicherungdaten B.
        /// </summary>
        public IList<DBSB> DBSB { get; set; }

        /// <summary>
        /// Holt oder setzt eine Liste der Datenbausteine Arbeitszeit.
        /// </summary>
        public IList<DBAZ> DBAZ { get; set; }

        /// <summary>
        /// Holt oder setzt eine Liste der Datenbausteine Entgeltdaten.
        /// </summary>
        public IList<DBEN> DBEN { get; set; }

        /// <summary>
        /// Holt oder setzt eine Liste der Datenbausteine Fehlzeit.
        /// </summary>
        public IList<DBFZ> DBFZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Datenbaustein Heimarbeiter.
        /// </summary>
        public DBHA DBHA
        {
            get => ListeDBHA?.SingleOrDefault();
            set
            {
                ListeDBHA = ListeDBHA.Set(value);
                _hatDbha = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Datenbaustein Kündigung/Entlassung.
        /// </summary>
        public DBKE DBKE
        {
            get => ListeDBKE?.SingleOrDefault();
            set
            {
                ListeDBKE = ListeDBKE.Set(value);
                _hatDbke = null;
            }
        }

        /// <summary>
        /// Fragt alle Datenbausteine in diesem Datensatz ab.
        /// </summary>
        public override IEnumerable<IDatenbaustein> Datenbausteine
        {
            get
            {
                foreach (var datenbaustein in ListExtensions.Enumerate(base.Datenbausteine, DBSE, ListeDBSA, DBSB, DBAZ, DBEN, DBFZ, ListeDBHA, ListeDBKE, DBFE))
                    yield return datenbaustein;
            }
        }

        private IList<DBSA> ListeDBSA { get; set; }

        private IList<DBHA> ListeDBHA { get; set; }

        private IList<DBKE> ListeDBKE { get; set; }
    }
}
