using System;
using System.Collections.Generic;
using System.IO;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class TestDEUEVVerfahren : TestBasis
    {
        /// <summary>
        /// Anmeldung
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung10()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev10.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "10")
                {
                    Assert.DoesNotContain(dsme.PERSGR, new List<string> { "103", "900", "901" });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                    if (string.IsNullOrWhiteSpace(dsme.VSNR))
                    {
                        Assert.NotNull(dsme.DBGB);
                        Assert.NotNull(dsme.DBEU);
                    }
                }
            }
        }

        /// <summary>
        /// Anmeldung
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung11()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev11.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "11")
                {
                    Assert.DoesNotContain(dsme.PERSGR, new List<string> { "103", "900", "901" });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Anmeldung
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung12()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev12.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "12")
                {
                    Assert.DoesNotContain(dsme.PERSGR, new List<string> { "103", "900", "901" });
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Anmeldung
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung13()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev13.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "13")
                {
                    Assert.NotNull(dsme.DBME);
                    Assert.NotNull(dsme.DBNA);
                    Assert.NotNull(dsme.DBAN);
                    Assert.Null(dsme.DBUV);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Sofortmeldung für Beschäftigte
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung20()
        {
           var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev20.dat");
           foreach (var dsme in deuevMessage.DSME)
           {
               if (dsme.GD == "20")
               {
                   Assert.Equal(dsme.GD, "20");
                   Assert.Null(dsme.DBME);
                   Assert.NotNull(dsme.DBSO);
                   Assert.Null(dsme.DBUV);
                   Assert.Null(dsme.DBKS);
                   Assert.Null(dsme.DBSV);
                   Assert.Null(dsme.DBRG);
                   Assert.Null(dsme.DBKV);
                   if (string.IsNullOrWhiteSpace(dsme.VSNR))
                   {
                       Assert.NotNull(dsme.DBGB);
                       Assert.NotNull(dsme.DBAN);
                       Assert.NotNull(dsme.DBEU);
                   }
               }
           }
        }

        /// <summary>
        /// Abmeldung
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung30()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev30.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "30")
                {
                    Assert.Equal(dsme.GD, "30");
                    Assert.NotNull(dsme.DBME);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Abmeldung, Wechsel der Krankenkasse/Einzugsstelle
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung31()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev31.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "31")
                {
                    Assert.Equal(dsme.GD, "31");
                    Assert.NotNull(dsme.DBME);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Abmeldung
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung32()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev32.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "32")
                {
                    Assert.Equal(dsme.GD, "32");
                    Assert.NotNull(dsme.DBME);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Abmeldung
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung33()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev33.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "33")
                {
                    Assert.Equal(dsme.GD, "33");
                    Assert.NotNull(dsme.DBME);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Abmeldung
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung34()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev34.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "34")
                {
                    Assert.Equal(dsme.GD, "34");
                    Assert.NotNull(dsme.DBME);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Wechsel des Entgeltabrechnungssystems
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung36()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev36.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "36")
                {
                    Assert.Equal(dsme.GD, "36");
                    Assert.NotNull(dsme.DBME);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Abmeldung, Ende der Beschäftigung wegen Tod
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung49()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev49.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "49")
                {
                    Assert.Equal(dsme.GD, "49");
                    Assert.NotNull(dsme.DBME);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Unterbrechung der Beschäftigung ohne Fortzahlung des Arbeitsentgelts
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung51()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev51.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "51")
                {
                    Assert.Equal(dsme.GD, "51");
                    Assert.NotNull(dsme.DBME);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        /// <summary>
        /// Sondermeldung
        /// </summary>
        [Fact]
        public void TestDEUEVMeldung57()
        {
            var deuevMessage = GetAndCheckDeuevMessageFromFile("deuev57.dat");
            foreach (var dsme in deuevMessage.DSME)
            {
                if (dsme.GD == "57")
                {
                    Assert.Equal(dsme.GD, "57");
                    Assert.NotNull(dsme.DBME);
                    Assert.Null(dsme.DBGB);
                    Assert.Null(dsme.DBEU);
                    Assert.Null(dsme.DBSV);
                    Assert.Null(dsme.DBVR);
                    Assert.Null(dsme.DBRG);
                    Assert.Null(dsme.DBSO);
                    Assert.Null(dsme.DBKV);
                }
            }
        }

        private DeuevMessageData GetAndCheckDeuevMessageFromFile(string fileName)
        {
            var input = LoadData(fileName).ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            var deuevMessage = new DeuevMessageData();
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                deuevMessage.VOSZ = new List<VOSZ> { vosz };
                writer.Write(vosz);
                streamObject = reader.Read();
                if (streamObject is VOSZ)
                {
                    deuevMessage.VOSZ.Add(streamObject as VOSZ);
                    streamObject = reader.Read();
                }
                var dsko = Assert.IsType<DSKO>(streamObject);
                deuevMessage.DSKO = dsko;
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                deuevMessage.DSME = new List<DSME> { dsme };
                writer.Write(dsme);
                while (true)
                {
                    streamObject = reader.Read();
                    if (streamObject is NCSZ)
                    {
                        writer.Write(streamObject);
                        deuevMessage.NCSZ = new List<NCSZ> { streamObject as NCSZ };
                        streamObject = reader.Read();
                        if (streamObject is NCSZ)
                        {
                            deuevMessage.NCSZ.Add(streamObject as NCSZ);
                        }
                        break;
                    }
                    else
                    {
                        Assert.IsType<DSME>(streamObject);
                        deuevMessage.DSME.Add(streamObject as DSME);
                    }
                    writer.Write(streamObject);
                }
                writer.Close();
                Assert.Equal(input, output.ToString());
                return deuevMessage;
            }
            finally
            {
                reader.Close();
            }
        }

        private class DeuevMessageData
        {
            public List<VOSZ> VOSZ { get; set; }

            public DSKO DSKO { get; set; }

            public List<DSME> DSME { get; set; }

            public List<NCSZ> NCSZ { get; set; }
        }
    }
}
