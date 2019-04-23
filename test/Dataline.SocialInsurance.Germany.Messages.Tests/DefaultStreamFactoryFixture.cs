using System;

using BeanIO;

using SocialInsurance.Germany.Messages.Mappings;

namespace SocialInsurance.Germany.Messages.Tests
{
    public class DefaultStreamFactoryFixture
    {
        private readonly Lazy<StreamFactory> _factory;

        public DefaultStreamFactoryFixture()
        {
            _factory = new Lazy<StreamFactory>(() =>
            {
                var factory = StreamFactory.NewInstance();
                using (var meldungStream = Meldungen.LoadMeldungen())
                    factory.Load(meldungStream);
                return factory;
            });
        }

        public StreamFactory Factory => _factory.Value;
    }
}
