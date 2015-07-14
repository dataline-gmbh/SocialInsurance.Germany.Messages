using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeanIO.Types;

namespace SocialInsurance.Germany.Messages.Mappings.Types
{
    public class NumericEnumTypeHandler<T> : ITypeHandler
    {
        public Type TargetType
        {
            get { return typeof(T); }
        }

        public string Format(object value)
        {
            if (value == null)
                return null;
            return string.Format("{0:D}", value);
        }

        public object Parse(string text)
        {
            if (string.IsNullOrEmpty(text))
                return null;
            return Enum.Parse(typeof(T), text);
        }
    }
}
