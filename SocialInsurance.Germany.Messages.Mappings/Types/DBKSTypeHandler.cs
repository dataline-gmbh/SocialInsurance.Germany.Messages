using BeanIO;
using BeanIO.Types;
using SocialInsurance.Germany.Messages.Pocos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Mappings.Types
{
    public class DBKSTypeHandler : ITypeHandler
    {
        private StreamFactory _factory;

        public Type TargetType
        {
            get { return typeof(DBKS); }
        }

        private StreamFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = StreamFactory.NewInstance();
                    _factory.Load(Meldungen.LoadMeldungen());
                }
                return _factory;
            }
        }

        public string Format(object value)
        {
            var output = new StringWriter();
            var writer = Factory.CreateWriter("DBKS", output);
            writer.Write(value);
            writer.Close();
            return output.ToString();
        }

        public object Parse(string text)
        {
            var reader = Factory.CreateReader("DBKS", new StringReader(text));
            return reader.Read();
        }
    }
}
