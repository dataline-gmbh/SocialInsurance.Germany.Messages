using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

using ExtraStandard.Extra14;
using ExtraStandard.GkvKomServer.Extra14;

namespace SocialInsurance.Germany.Messages.Tests.Uv
{
    public abstract class ServerCommunication
    {
        public AbsenderInformation Absender { get; } = new AbsenderInformation();

        protected abstract Uri RequestUrl { get; }

        protected abstract IGkvExtra14Validator CreateValidator();

        protected async Task<TransportResponseType> Execute(TransportRequestType request)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("xreq", "http://www.extra-standard.de/namespace/request/1");
            ns.Add("xcpt", "http://www.extra-standard.de/namespace/components/1");
            ns.Add("xplg", "http://www.extra-standard.de/namespace/plugins/1");

            var requestEncoding = ExtraStandard.ExtraUtilities.DefaultExtraEncoding;
            var serialized = ExtraStandard.ExtraUtilities.Serialize(request, requestEncoding);
            var document = XDocument.Load(new MemoryStream(serialized));

            var validator = CreateValidator();
            validator.Validate(document);

            var contentType = $"text/xml; charset={requestEncoding.WebName}";

#if USE_HTTPCLIENT
            var messageHandler = new WebRequestHandler()
            {
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ClientCertificates =
                {
                    new X509Certificate2(Absender.Zertifikat.RawData)
                },
            };

            var httpClient = new HttpClient(messageHandler)
            {
                DefaultRequestHeaders =
                {
                    UserAgent =
                    {
                        new ProductInfoHeaderValue("DatalineLohnabzug", "27.0.0")
                    }
                }
            };

            var requestContent = new ByteArrayContent(serialized)
            {
                Headers =
                {
                    ContentType = MediaTypeHeaderValue.Parse(contentType)
                }
            };
            using (var response = await httpClient.PostAsync(RequestUrl, requestContent))
            {
                var responseData = await response.EnsureSuccessStatusCode().Content.ReadAsByteArrayAsync();
                ExtraErrorType extraError;
                if (ExtraStandard.Extra14.ExtraUtilities.TryDeserializeError(responseData, out extraError))
                    throw new Exception(string.Join(Environment.NewLine, extraError.GetFlags().Select(x => x.AsExtraFlag()).Select(x => $"{x.Code} ({x.Weight}): {x.Text}")));

                return ExtraStandard.ExtraUtilities.Deserialize<TransportResponseType>(responseData);
            }
#else
            var userAgent = "DatalineLohnabzug/27.0.0";
            var httpWebRequest = WebRequest.CreateHttp(RequestUrl);
            httpWebRequest.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            httpWebRequest.UserAgent = userAgent;
            httpWebRequest.ReadWriteTimeout = httpWebRequest.Timeout / 2;
            httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
            httpWebRequest.Method = WebRequestMethods.Http.Post;
            httpWebRequest.ContentType = contentType;
            httpWebRequest.PreAuthenticate = true;
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.Expect = null;
            var clientCerts = new X509Certificate2Collection
            {
                new X509Certificate2(Absender.Zertifikat.RawData)
            };
            httpWebRequest.ClientCertificates = clientCerts;

            httpWebRequest.ContentLength = serialized.Length;
            using (var requestStream = await httpWebRequest.GetRequestStreamAsync())
            {
                await requestStream.WriteAsync(serialized, 0, serialized.Length);
            }

            using (var response = await httpWebRequest.GetResponseAsync())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    var temp = new MemoryStream();
                    Debug.Assert(responseStream != null, "responseStream != null");
                    await responseStream.CopyToAsync(temp);

                    var responseData = temp.ToArray();
                    ExtraErrorType extraError;
                    if (ExtraUtilities.TryDeserializeError(responseData, out extraError))
                        throw new Exception(string.Join(Environment.NewLine, extraError.GetFlags().Select(x => x.AsExtraFlag()).Select(x => $"{x.Code} ({x.Weight}): {x.Text}")));

                    return ExtraStandard.ExtraUtilities.Deserialize<TransportResponseType>(responseData);
                }
            }
#endif
        }
    }
}
