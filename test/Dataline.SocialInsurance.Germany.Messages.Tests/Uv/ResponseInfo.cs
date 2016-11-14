using System;
using System.Collections.Generic;
using System.Linq;

using ExtraStandard;
using ExtraStandard.Extra14;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public class ResponseInfo
    {
        public ResponseInfo(TransportResponseType response, IReadOnlyCollection<PackageInfo> packages)
        {
            RequestId = response.TransportHeader.RequestDetails.RequestID.Value;
            ResponseId = response.TransportHeader.ResponseDetails.ResponseID.Value;
            Flags = response.TransportHeader.ResponseDetails.GetReportFlags().Select(x => x.AsExtraFlag()).ToList();
            Packages = packages;
        }

        public string RequestId { get; }
        public string ResponseId { get; }
        public IReadOnlyCollection<ExtraFlag> Flags { get; }
        public IReadOnlyCollection<PackageInfo> Packages { get; }
    }
}
