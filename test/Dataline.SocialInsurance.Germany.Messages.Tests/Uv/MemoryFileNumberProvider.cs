using System;
using System.Collections.Concurrent;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public class MemoryFileNumberProvider : IFileNumberProvider
    {
        private readonly ConcurrentDictionary<string, int> _fileNumbers = new ConcurrentDictionary<string, int>();

        public int GetNext(string method)
        {
            var nextValue = _fileNumbers.GetOrAdd(method, 1);
            while (!_fileNumbers.TryUpdate(method, nextValue + 1, nextValue))
            {
                nextValue = _fileNumbers.GetOrAdd(method, 1);
            }
            return nextValue;
        }

        public void SetNext(string method, int nextValue)
        {
            _fileNumbers.AddOrUpdate(method, nextValue, (_, __) => nextValue);
        }
    }
}
