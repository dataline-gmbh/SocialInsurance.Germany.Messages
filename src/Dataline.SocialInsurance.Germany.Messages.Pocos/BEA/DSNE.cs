// <copyright file="DSNE.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos.BEA
{
    /// <summary>
    /// Datensatz Nebeneinkommen
    /// </summary>
    public class DSNE : BasisDatensatzBEA
    {
        private bool? _hatDbne;
        private bool? _hatDbsa;
        private bool? _hatDbnb;
        private bool? _hatDbhn;

        /// <summary>
        /// Erstellt eine neue Instanz von <see cref="DSNE"/>.
        /// </summary>
        public DSNE()
        {
            KE = "DSNE";
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBNE"/> vorhanden ist.
        /// </summary>
        public bool MMNE
        {
            get => _hatDbne ?? DBNE != null;
            set => _hatDbne = value;
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
        /// Holt oder setzt, ob der Baustein <see cref="DBNB"/> vorhanden ist.
        /// </summary>
        public bool MMNB
        {
            get => _hatDbnb ?? DBNB != null;
            set => _hatDbnb = value;
        }

        /// <summary>
        /// Holt oder setzt, ob der Baustein <see cref="DBHN"/> vorhanden ist.
        /// </summary>
        public bool MMHN
        {
            get => _hatDbhn ?? DBHN != null;
            set => _hatDbhn = value;
        }

        /// <summary>
        /// Holt oder setzt den Baustein Nebeneinkommen.
        /// </summary>
        public DBNE DBNE
        {
            get => ListeDBNE?.SingleOrDefault();
            set
            {
                ListeDBNE = ListeDBNE.Set(value);
                _hatDbne = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein Sozialversicherungsdaten A.
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
        /// Holt oder setzt den Baustein Nebenbeschäftigung Arbeitslose.
        /// </summary>
        public DBNB DBNB
        {
            get => ListeDBNB?.SingleOrDefault();
            set
            {
                ListeDBNB = ListeDBNB.Set(value);
                _hatDbnb = null;
            }
        }

        /// <summary>
        /// Holt oder setzt den Baustein Heimarbeiter Nebeneinkommen.
        /// </summary>
        public DBHN DBHN
        {
            get => ListeDBHN?.SingleOrDefault();
            set
            {
                ListeDBHN = ListeDBHN.Set(value);
                _hatDbhn = null;
            }
        }

        /// <summary>
        /// Fragt alle Bausteine in diesem Datensatz ab.
        /// </summary>
        public override IEnumerable<IDatenbaustein> Datenbausteine
        {
            get
            {
                foreach (var datenbaustein in ListExtensions.Enumerate(base.Datenbausteine, ListeDBNE, ListeDBSA, ListeDBNB, ListeDBHN, DBFE))
                    yield return datenbaustein;
            }
        }

        private IList<DBNE> ListeDBNE { get; set; }

        private IList<DBSA> ListeDBSA { get; set; }

        private IList<DBNB> ListeDBNB { get; set; }

        private IList<DBHN> ListeDBHN { get; set; }
    }
}
