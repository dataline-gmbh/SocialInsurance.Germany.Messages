using System;
using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Tests
{
    public class ValidationException : Exception
    {
        public ValidationException(IReadOnlyCollection<string> messages) : base(string.Join(Environment.NewLine, messages))
        {
            Messages = messages;
        }

        public IReadOnlyCollection<string> Messages { get; private set; }
    }
}
