// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OAuthRequestHandler.cs">
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

using System.IO;
using System.Net;
#if !NETFRAMEWORK
using System.Reflection;
#endif

namespace Aspose.Slides.Cloud.Sdk.RequestHandlers
{
    internal class HeadersRequestHandler : IRequestHandler
    {        
        public HeadersRequestHandler(Configuration configuration)
        {
            m_configuration = configuration;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
#if NETFRAMEWORK
            var sdkVersion = GetType().Assembly.GetName().Version;
#else
            var sdkVersion = GetType().GetTypeInfo().Assembly.GetName().Version;
#endif
            if (m_configuration.HttpRequestTimeout > 0)
            {
                request.Timeout = m_configuration.HttpRequestTimeout * 1000;
            }
            request.Headers["x-aspose-client"] = string.Format(".net sdk v{0}.{1}", sdkVersion.Major, sdkVersion.Minor);
            if (m_configuration.Timeout > 0)
            {
                request.Headers["x-aspose-timeout"] = m_configuration.Timeout.ToString();
            }
            foreach (string key in m_configuration.CustomHeaders.Keys)
            {
                request.Headers[key] = m_configuration.CustomHeaders[key];
            }
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
        }

        private readonly Configuration m_configuration;
    }
}