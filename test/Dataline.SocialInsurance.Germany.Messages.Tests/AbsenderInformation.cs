using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

using Microsoft.Extensions.Configuration;

using SocialInsurance.Germany.Messages.Tests.Support;

namespace SocialInsurance.Germany.Messages.Tests
{
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
                Betriebsnummer = BnrExtractor.Extract(Zertifikat.Subject);
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
        public string Name { get; } = "DATALINE GmbH u Co KG";
        public string PLZ { get; } = "30449";
        public string Ort { get; } = "Hannover";
        public bool? IstMaennlich { get; } = true;
        public string Ansprechpartner { get; } = "Martin Friedhoff";
        public string Email { get; }
        public string Telefon { get; }
    }
}
