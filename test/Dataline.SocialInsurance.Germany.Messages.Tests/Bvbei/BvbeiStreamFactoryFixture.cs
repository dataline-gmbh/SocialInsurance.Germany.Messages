using System;

using BeanIO;

using SocialInsurance.Germany.Messages.Mappings;

namespace SocialInsurance.Germany.Messages.Tests.Bvbei
{
    public class BvbeiStreamFactoryFixture
    {
        private readonly Lazy<StreamFactory> _factory;

        public BvbeiStreamFactoryFixture()
        {
            _factory = new Lazy<StreamFactory>(() =>
            {
                var factory = StreamFactory.NewInstance();
                using (var meldungStream = Meldungen.LoadMeldungen())
                    factory.Load(meldungStream);
                factory.Load(new Uri("resource:SocialInsurance.Germany.Messages.Tests.Bvbei.BvbeiMappings.xml, Dataline.SocialInsurance.Germany.Messages.Tests"));
                return factory;
            });
        }

        public StreamFactory Factory => _factory.Value;
    }
}
