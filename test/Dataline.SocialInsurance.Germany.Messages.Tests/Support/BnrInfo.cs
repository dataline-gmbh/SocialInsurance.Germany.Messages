using System;
using System.Text.RegularExpressions;

namespace SocialInsurance.Germany.Messages.Tests.Support
{
    public class BnrInfo
    {
        private static readonly Regex _bnrExtractor = new Regex("CN=([^,]+)\\s*,\\s*OU=BN([0-9]{8})\\s*,\\s*OU=([^,]+)");

        private BnrInfo(string contactPerson, string bnr, string companyName)
        {
            ContactPerson = contactPerson;
            Betriebsnummer = bnr;
            CompanyName = companyName;
        }

        public string ContactPerson { get; }

        public string Betriebsnummer { get; }

        public string CompanyName { get; }

        public static BnrInfo Extract(string subject)
        {
            var subjectMatch = _bnrExtractor.Match(subject);
            if (!subjectMatch.Success)
                return null;
            var contactPerson = subjectMatch.Groups[1].Value;
            var bnr = subjectMatch.Groups[2].Value;
            var companyName = subjectMatch.Groups[3].Value;
            return new BnrInfo(contactPerson, bnr, companyName);
        }
    }
}
