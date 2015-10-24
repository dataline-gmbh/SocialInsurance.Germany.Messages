using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

using BeanIO;

using SocialInsurance.Germany.Messages.Mappings;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests
{
    public abstract class TestBasis
    {
        private readonly StreamFactory _factory;

        private readonly string _namespace;

        protected TestBasis()
        {
            _factory = StreamFactory.NewInstance();
            _factory.Load(Meldungen.LoadMeldungen());
            _namespace = GetType().Namespace;
        }

        protected StreamFactory StreamFactory
        {
            get { return _factory; }
        }

        protected TextReader LoadData(string resourceName)
        {
            //var frame = new StackTrace(1).GetFrame(0);
            //var method = frame.GetMethod();
            //var ns = method.DeclaringType.Namespace;
            var ns = _namespace;
            var resName = string.Format("{0}.{1}", ns, resourceName);
            var asm = GetType().Assembly;
            //var asm = method.DeclaringType.Assembly;
            var resStream = asm.GetManifestResourceStream(resName);
            Assert.NotNull(resStream);
            return new StreamReader(resStream);
        }
    }
}
