// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AuthWithSignatureRequestHandler.cs">
//   Copyright (c) 2018 Aspose.Slides for Cloud
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Slides.Cloud.Sdk.RequestHandlers
{
    using System;
    using System.IO;
    using System.Net;
    using System.Security.Cryptography;
    using System.Text;

    internal class AuthWithSignatureRequestHandler : IRequestHandler
    {
        public AuthWithSignatureRequestHandler(Configuration configuration)
        {
            m_configuration = configuration;
        }

        public string ProcessUrl(string url)
        {
            if (m_configuration.AuthType != AuthType.RequestSignature)
            {
                return url;
            }

            url = UrlHelper.AddQueryParameterToUrl(url, "appSid", m_configuration.AppSid);                      
            url = Sign(url);

            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
        }

        private string Sign(string url)
        {
            UriBuilder uriBuilder = new UriBuilder(url);
            
            // Remove final slash here as it can be added automatically.
            uriBuilder.Path = uriBuilder.Path.TrimEnd('/');



            //// Compute the hash.
            var encoding = new ASCIIEncoding();
            // converting key to bytes will throw an exception, need to replace '-' and '_' characters first.
            var usablePrivateKey = m_configuration.AppKey.Replace("-", "+").Replace("_", "/");
            var privateKeyBytes = Convert.FromBase64String(usablePrivateKey);

            var uri = new Uri(uriBuilder.Uri.AbsoluteUri);
            var encodedPathAndQueryBytes = encoding.GetBytes(uri.LocalPath + uri.Query);

            // compute the hash
            var algorithm = new HMACSHA1(privateKeyBytes);
            var hash = algorithm.ComputeHash(encodedPathAndQueryBytes);

            // convert the bytes to string and make url-safe by replacing '+' and '/' characters
            var signarure = Convert.ToBase64String(hash).Replace("+", "-").Replace("/", "_");

            // Add the signature to query string.
            return string.Format("{0}&signature={1}", uriBuilder.Uri.AbsoluteUri, signarure);
        }

        private readonly Configuration m_configuration;
    }
}
