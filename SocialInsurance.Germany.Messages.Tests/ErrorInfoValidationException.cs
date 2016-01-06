using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Tests
{
    public class ErrorInfoValidationException : ValidationException
    {
        public ErrorInfoValidationException(IReadOnlyCollection<ErrorInfo> errors) : base(errors.Select(x => x.FE).ToList())
        {
            Errors = errors;
        }

        public IReadOnlyCollection<ErrorInfo> Errors { get; private set; }
    }
}
