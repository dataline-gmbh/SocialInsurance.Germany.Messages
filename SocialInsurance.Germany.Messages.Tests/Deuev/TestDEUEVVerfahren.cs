using System;
using System.Collections.Generic;
using System.IO;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class TestDEUEVVerfahren : TestBasis
    {
        [Fact]
        public void TestDEUEVMeldung10()
        {
            var input = LoadData("deuev10.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "10");
                Assert.NotNull(dsme.DBME);
                Assert.NotNull(dsme.DBNA);
                Assert.NotNull(dsme.DBAN);
                Assert.Null(dsme.DBUV);
                Assert.Null(dsme.DBSV);
                Assert.Null(dsme.DBSO);
                if (string.IsNullOrWhiteSpace(dsme.VSNR))
                {
                    Assert.NotNull(dsme.DBGB);
                    Assert.NotNull(dsme.DBEU);
                }

                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung11()
        {
            var input = LoadData("deuev11.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "11");
                Assert.NotNull(dsme.DBME);
                Assert.NotNull(dsme.DBNA);
                Assert.Null(dsme.DBGB);
                Assert.NotNull(dsme.DBAN);
                Assert.Null(dsme.DBEU);
                Assert.Null(dsme.DBUV);
                Assert.Null(dsme.DBKS);
                Assert.Null(dsme.DBSO);
                Assert.Null(dsme.DBSV);
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung12()
        {
            var input = LoadData("deuev12.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "12");
                writer.Write(dsme);
                Assert.NotNull(dsme.DBME);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung13()
        {
            var input = LoadData("deuev13.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "13");
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung20()
        {
            var input = LoadData("deuev20.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "20");
                Assert.NotNull(dsme.DBNA);
                Assert.NotNull(dsme.DBSO);
                Assert.Null(dsme.DBUV);
                Assert.Null(dsme.DBKS);
                Assert.Null(dsme.DBSV);
                if (string.IsNullOrWhiteSpace(dsme.VSNR))
                {
                    Assert.NotNull(dsme.DBGB);
                    Assert.NotNull(dsme.DBAN);
                    Assert.NotNull(dsme.DBEU);
                }

                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung30()
        {
            var input = LoadData("deuev30.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "30");
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung31()
        {
            var input = LoadData("deuev31.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "31");
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung32()
        {
            var input = LoadData("deuev32.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "32");
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung33()
        {
            var input = LoadData("deuev33.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "33");
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung34()
        {
            var input = LoadData("deuev34.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "34");
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung36()
        {
            var input = LoadData("deuev36.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.NotNull(dsme.DBME);
                Assert.NotNull(dsme.DBUV);
                Assert.Equal(dsme.GD, "36");
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung49()
        {
            var input = LoadData("deuev49.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.NotNull(dsme.DBME);
                Assert.NotNull(dsme.DBUV);
                Assert.Equal(dsme.GD, "49");
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung51()
        {
            var input = LoadData("deuev51.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "51");
                Assert.NotNull(dsme.DBME);
                Assert.NotNull(dsme.DBUV);
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung57()
        {
            var input = LoadData("deuev57.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "57");
                Assert.NotNull(dsme.DBME);
                Assert.NotNull(dsme.DBUV);
                writer.Write(dsme);
                CheckDSMEEntrys(reader, writer);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        private void CheckDSMEEntrys(BeanIO.IBeanReader reader, BeanIO.IBeanWriter writer)
        {
            while (true)
            {
                var streamObject = reader.Read();
                if (streamObject is NCSZ)
                {
                    writer.Write(streamObject);
                    break;
                }
                else
                {
                    Assert.IsType<DSME>(streamObject);
                }

                writer.Write(streamObject);
            }
        }
    }
}
