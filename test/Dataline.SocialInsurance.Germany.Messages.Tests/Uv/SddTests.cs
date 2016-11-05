using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using BeanIO;

using ExtraStandard;
using ExtraStandard.Extra14;
using ExtraStandard.GkvKomServer;

using ikvm.extensions;

using Microsoft.Extensions.Configuration;

using NodaTime;

using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.UV;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public class SddTests
    {
        private ServerSupply ServerSupply { get; } = new ServerSupply();
        private AbsenderInformation Absender => ServerSupply.Absender;

        [Fact]
        public async Task Sdd10()
        {
            Skip.If(!Absender.IstKonfiguriert, "PROD-ID, MOD-ID und Zertifikat müssen als Benutzer-Secret gesetzt sein.");

            var fileNumber = 1;
            var ed = DateTime.Now;
            var request = new List<IDatensatz>()
            {
                new VOSZ()
                {
                    VFMM = Info.DSAS.Merkmal,
                    BBNRAB = Absender.Betriebsnummer,
                    BBNREP = "95783331",
                    ED = LocalDate.FromDateTime(ed),
                    DTNR = fileNumber,
                    NAAB = Absender.Name,
                },
                new DSKO04()
                {
                    VF = Info.DSAS.Verfahren,
                    BBNRAB = Absender.Betriebsnummer,
                    BBNREP = "95783331",
                    ED = ed,
                    BBNRER = Absender.Betriebsnummer,
                    PRODID = Absender.ProdId,
                    MODID = Absender.ModId,
                    NAME1 = Absender.Name,
                    PLZ = Absender.PLZ,
                    ORT = Absender.Ort,
                    ANRAP = (Absender.IstMaennlich ?? false) ? "M" : "F",
                    NAMEAP = Absender.Ansprechpartner,
                    TELAP = Absender.Telefon,
                    EMAILAP = Absender.Email,
                },
                new DSAS0101()
                {
                    BBNRAB = Absender.Betriebsnummer,
                    BBNREP = "95783331",
                    VERNRDSAS = 1,
                    ED = ed,
                    PRODID = Absender.ProdId.ToString(),
                    MODID = Absender.ModId.ToString(),
                    DSID = "1",
                    VOID = "VOID",
                    MMUEB = Uebermittlungsweg.SystemgeprueftesProgramm,
                    BBNRUV = "52742028",
                    MNR = "818134770",
                    PIN = 10872,
                    JAHR = 2016,
                    BBNRLB = "99300671",
                    BBNRAS = Absender.Betriebsnummer,
                    AFGRUND = "UV10",
                },
                new NCSZ()
                {
                    BBNRAB = Absender.Betriebsnummer,
                    BBNREP = "95783331",
                    ED = LocalDate.FromDateTime(ed),
                    DTNR = fileNumber,
                    ZLSZ = 1,
                }
            };

            var response = await ServerSupply.SupplyData(fileNumber, request);
        }
    }
}
