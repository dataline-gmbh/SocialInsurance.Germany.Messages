using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

using ExtraStandard;
using ExtraStandard.Encryption;
using ExtraStandard.Extra14;

using Microsoft.Extensions.Configuration;

using Org.BouncyCastle.Pkcs;

using SocialInsurance.Germany.Messages.Tests.Support;

namespace SocialInsurance.Germany.Messages.Tests
{
    /// <summary>
    /// Informationen über den Absender
    /// </summary>
    /// <remarks>
    /// <para>Folgende Daten werden aus den "user-secrets" geladen:</para>
    /// <list type="bullet">
    /// <item>prod-id: Produkt-ID</item>
    /// <item>mod-id: Modifikations-ID</item>
    /// <item>tel: Telefonnummer</item>
    /// <item>email: E-Mail-Adresse</item>
    /// <item>cert: Zertifikat (P12/PFX)</item>
    /// </list>
    /// <para>Im Zertifikatsspeicher des Benutzers (unter Windows) müssen sowohl das Zertifikat als auch die Aussteller-Zertifikate hinterlegt sein.</para> 
    /// </remarks>
    public sealed class AbsenderInformation
    {
        public AbsenderInformation()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets()
                .Build();

            var prodId = config["prod-id"];
            if (!string.IsNullOrEmpty(prodId))
                ProdId = XmlConvert.ToInt32(prodId);

            var modId = config["mod-id"];
            if (!string.IsNullOrEmpty(modId))
                ModId = XmlConvert.ToInt32(modId);

            Telefon = config["tel"];
            Email = config["email"];

            var cert = config["cert"];
            if (!string.IsNullOrEmpty(cert))
            {
                Zertifikat = new X509Certificate2(Convert.FromBase64String(cert), (string) null, X509KeyStorageFlags.Exportable);
                var info = BnrInfo.Extract(Zertifikat.Subject);
                Betriebsnummer = info.Betriebsnummer;
                Name = info.CompanyName;
                Ansprechpartner = info.ContactPerson;
                switch (Ansprechpartner)
                {
                    case "Martina Koester":
                        IstMaennlich = false;
                        break;
                    case "Martin Friedhoff":
                        IstMaennlich = true;
                        break;
                    default:
                        IstMaennlich = true;
                        break;
                }
            }

            IstKonfiguriert =
                !string.IsNullOrEmpty(prodId)
                && !string.IsNullOrEmpty(modId)
                && !string.IsNullOrEmpty(Email)
                && Zertifikat != null
                && Zertifikat.HasPrivateKey
                && !string.IsNullOrEmpty(Betriebsnummer);
        }

        public bool IstKonfiguriert { get; }

        public int ProdId { get; }
        public int ModId { get; }
        public X509Certificate2 Zertifikat { get; }

        public string Betriebsnummer { get; }
        public string Name { get; }
        public string PLZ { get; } = "30449";
        public string Ort { get; } = "Hannover";
        public bool? IstMaennlich { get; }
        public string Ansprechpartner { get; }
        public string Email { get; }
        public string Telefon { get; }

        public ExtraDataTransformHandler CreateSupplyTransformHandler(X509Certificate2 receiverCertificate)
        {
            return CreateTransformHandler(receiverCertificate, (comp, encr) => new ExtraDataTransformHandler(comp, encr));
        }

        public ExtraDataTransformHandler CreateQueryTransformHandler()
        {
            return CreateTransformHandler(null, (comp, encr) => new ExtraQueryDataTransformHandler(comp, encr));
        }

        public ExtraDataTransformHandler CreateConfirmTransformHandler()
        {
            return CreateTransformHandler(null, (comp, encr) => new ExtraQueryDataTransformHandler(comp, encr));
        }

        private ExtraDataTransformHandler CreateTransformHandler<T>(X509Certificate2 receiverCertificate, Func<IEnumerable<IExtraCompressionHandler>, IEnumerable<IExtraEncryptionHandler>, T> createFunc) where T : ExtraDataTransformHandler
        {
            var compression = new ExtraStandard.Compression.NoneCompressionHandler();
            var encryptionHandlers = new List<IExtraEncryptionHandler>()
            {
                new NoneEncryptionHandler()
            };

            if (receiverCertificate != null)
            {
                var senderPkcsStore = new Pkcs12Store(new MemoryStream(Zertifikat.Export(X509ContentType.Pkcs12)), new char[0]);
                var receiverCertBc = new Org.BouncyCastle.X509.X509CertificateParser().ReadCertificate(receiverCertificate.RawData);
                var encryption = new Pkcs7EncryptionHandler(senderPkcsStore, receiverCertBc);
                encryptionHandlers.Add(encryption);
            }

            var dataTransformsHelper = createFunc(new[] { compression }, encryptionHandlers);
            return dataTransformsHelper;
        }

        private class ExtraQueryDataTransformHandler : ExtraDataTransformHandler
        {
            public ExtraQueryDataTransformHandler(IEnumerable<IExtraCompressionHandler> compressionHandlers, IEnumerable<IExtraEncryptionHandler> encryptionHandlers) 
                : base(compressionHandlers, encryptionHandlers)
            {
            }

            public override bool AddDataInfo(IExtraCompressionHandler handler, bool first, bool last, int index, bool forInput)
            {
                return handler.AlgorithmId != ExtraCompression.None && base.AddDataInfo(handler, first, last, index, forInput);
            }

            public override bool AddDataInfo(IExtraEncryptionHandler handler, bool first, bool last, int index, bool forInput)
            {
                return handler.AlgorithmId != ExtraEncryption.None && base.AddDataInfo(handler, first, last, index, forInput);
            }
        }
    }
}
