using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BeanIO;

using ExtraStandard;

using NodaTime;

using SocialInsurance.Germany.Messages.Pocos;
using SocialInsurance.Germany.Messages.Pocos.UV;

using Xunit;
using Xunit.Abstractions;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public class SddTests
    {
        private readonly ITestOutputHelper _output;

        public SddTests(ITestOutputHelper output)
        {
            _output = output;
        }

        private ServerSupply ServerSupply { get; } = new ServerSupply();
        private ServerQuery ServerQuery { get; } = new ServerQuery();
        private ServerConfirmation ServerConfirmation { get; } = new ServerConfirmation();

        private AbsenderInformation Absender => ServerSupply.Absender;

        [Fact]
        public async Task Sdd10Supply()
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
                    ANRAP = (Absender.IstMaennlich ?? false) ? "M" : "W",
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
                    PRODID = Absender.ProdId,
                    MODID = Absender.ModId,
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
                    VFMM = Info.DSAS.Merkmal,
                    BBNRAB = Absender.Betriebsnummer,
                    BBNREP = "95783331",
                    ED = LocalDate.FromDateTime(ed),
                    DTNR = fileNumber,
                    ZLSZ = 2,
                }
            };

            var response = await ServerSupply.SupplyData(fileNumber, request);
            Assert.All(response.Flags, flag => Assert.NotEqual(ExtraFlagWeight.Error, flag.Weight));
            Assert.All(response.Packages, package => Assert.All(package.Flags, flag => Assert.NotEqual(ExtraFlagWeight.Error, flag.Weight)));
        }

        [Fact]
        public async Task Sdd10Query()
        {
            Skip.If(!Absender.IstKonfiguriert, "PROD-ID, MOD-ID und Zertifikat müssen als Benutzer-Secret gesetzt sein.");

            var response = await ServerQuery.Query(new ServerQuery.QueryInfo(Info.DSAS.Dateikennung, "95783331"));
            Assert.All(response.Flags, flag => Assert.NotEqual(ExtraFlagWeight.Error, flag.Weight));
            Assert.All(response.Packages, package =>
            {
                Assert.All(package.Flags, flag => Assert.NotEqual(ExtraFlagWeight.Error, flag.Weight));
                try
                {
                    foreach (var record in package.Decode())
                    {
                        if (record.DBFE.Count != 0)
                        {
                            foreach (var dbfe in record.DBFE)
                            {
                                _output.WriteLine($"{package.DataName}: {record.KE}: {dbfe.FE}");
                            }
                        }
                    }
                }
                catch (InvalidRecordException ex)
                {
                    _output.WriteLine(ex.ToString());
                    foreach (var fieldError in ex.RecordContext.GetFieldErrors())
                    {
                        foreach (var fieldErrorMessage in fieldError)
                        {
                            _output.WriteLine($"\t{fieldError.Key}: {fieldErrorMessage}");
                        }
                    }
                }
            });

            var failedPackages = response
                .Packages
                .Where(x =>
                {
                    try
                    {
                        var records = x.Decode();
                        if (records.Any(rec => rec.DBFE.Any()))
                            return true;
                        if (records.OfType<DSAS0101>().Any(rec => (rec.DBFU?.ANFU ?? 0) != 0))
                            return true;
                        return false;
                    }
                    catch
                    {
                        return true;
                    }
                })
                .ToList();
            await ServerConfirmation.Confirm(response.Packages.Select(x => x.ResponseId).ToList());


        }
    }
}
