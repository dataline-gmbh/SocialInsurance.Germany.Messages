using System;

using BeanIO;

using SocialInsurance.Germany.Messages.Mappings;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class DeuevStreamFactoryFixture
    {
        private readonly Lazy<StreamFactory> _factory;

        public DeuevStreamFactoryFixture()
        {
            _factory = new Lazy<StreamFactory>(() =>
            {
                var factory = StreamFactory.NewInstance();
                factory.Load(Meldungen.LoadMeldungen());
                factory.Load(new Uri("resource:SocialInsurance.Germany.Messages.Tests.Deuev.DeuevMappings.xml, Dataline.SocialInsurance.Germany.Messages.Tests"));
                return factory;
            });
        }

        public StreamFactory Factory => _factory.Value;
    }
}
