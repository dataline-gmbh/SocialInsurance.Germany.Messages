using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using CodeTiger;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public static class ReceiverCertificates
    {
        public static AsyncLazy<IReadOnlyCollection<X509Certificate2>> Certificates { get; }
        = new AsyncLazy<IReadOnlyCollection<X509Certificate2>>(async () =>
        {
            var result = new List<X509Certificate2>();
            var enumerator = Load().GetEnumerator();
            while (await enumerator.MoveNext(CancellationToken.None))
            {
                result.Add(enumerator.Current);
            }
            return result;
        });

        public static IAsyncEnumerable<X509Certificate2> Load()
        {
            return new CertLoader();
        }

        private class CertLoader : IAsyncEnumerable<X509Certificate2>
        {
            public IAsyncEnumerator<X509Certificate2> GetEnumerator()
            {
                return new CertEnumerator();
            }

            private class CertEnumerator : IAsyncEnumerator<X509Certificate2>
            {
                private readonly StringBuilder _currentCert = new StringBuilder(8000);
                private readonly HttpClient _httpClient;
                private StreamReader _reader;

                public CertEnumerator()
                {
                    _httpClient = new HttpClient();
                }

                public X509Certificate2 Current { get; private set; }

                public async Task<bool> MoveNext(CancellationToken cancellationToken)
                {
                    if (_reader == null)
                    {
                        var stream = await _httpClient.GetStreamAsync("https://trustcenter-data.itsg.de/agv/annahme-sha256.agv");
                        _reader = new StreamReader(stream);
                    }

                    string line;
                    while ((line = await _reader.ReadLineAsync()) != null)
                    {
                        if (string.IsNullOrEmpty(line.Trim()))
                        {
                            if (_currentCert.Length != 0)
                            {
                                _currentCert.AppendLine("-----END CERTIFICATE-----");
                                Current = Decode(_currentCert.ToString());
                                _currentCert.Clear();
                                return true;
                            }
                        }
                        else
                        {
                            if (_currentCert.Length == 0)
                            {
                                _currentCert.AppendLine("-----BEGIN CERTIFICATE-----");
                            }

                            _currentCert.AppendLine(line);
                        }
                    }

                    if (_currentCert.Length != 0)
                    {
                        _currentCert.AppendLine("-----BEGIN CERTIFICATE-----");
                        Current = Decode(_currentCert.ToString());
                        _currentCert.Clear();
                        return true;
                    }

                    return false;
                }

                public void Dispose()
                {
                    _reader?.Dispose();
                    _httpClient.Dispose();
                }

                private X509Certificate2 Decode(string cert)
                {
                    var byteArray = Encoding.UTF8.GetBytes(cert);
                    var result = new X509Certificate2();
                    result.Import(byteArray);
                    return result;
                }
            }
        }
    }
}
