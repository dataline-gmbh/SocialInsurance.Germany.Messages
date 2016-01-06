using SocialInsurance.Germany.Messages.Pocos;

namespace SocialInsurance.Germany.Messages.Tests
{
    public class ErrorInfo : DBFE
    {
        public ErrorInfo(string dbfe)
            : this(Parse(dbfe))
        {
        }

        public ErrorInfo(DBFE error)
        {
            KE = error.KE;
            FE = error.FE;
            var parts = FE.Split(new[]
            {
                ' '
            }, 2);
            Code = parts.Length < 1 ? string.Empty : parts[0];
            Message = parts.Length < 2 ? string.Empty : parts[1].TrimEnd();
        }

        public string Code { get; private set; }
        public string Message { get; private set; }

        private static DBFE Parse(string dbfe)
        {
            return new DBFE()
            {
                KE = "DBFE",
                FE = string.IsNullOrEmpty(dbfe) ? string.Empty : dbfe.Substring(4),
            };
        }
    }
}
