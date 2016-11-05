using System;
using System.Text.RegularExpressions;

namespace SocialInsurance.Germany.Messages.Tests.Support
{
    public static class BnrExtractor
    {
        private static readonly Regex _bnrExtractor = new Regex("OU=BN([0-9]{8})");

        public static string Extract(string subject)
        {
            var subjectMatch = _bnrExtractor.Match(subject);
            return subjectMatch.Success ? subjectMatch.Groups[1].Value : null;
        }
    }
}
