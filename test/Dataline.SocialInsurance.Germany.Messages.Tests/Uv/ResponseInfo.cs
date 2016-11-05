using System;
using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public class ResponseInfo
    {
        public ResponseInfo(string requestId, string responseId, IReadOnlyCollection<PackageInfo> packages)
        {
            RequestId = requestId;
            ResponseId = responseId;
            Packages = packages;
        }

        public string RequestId { get; }
        public string ResponseId { get; }
        public IReadOnlyCollection<PackageInfo> Packages { get; }
    }
}
