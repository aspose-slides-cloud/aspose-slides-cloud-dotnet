// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DebugLogRequestHandler.cs">
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
#if NETFRAMEWORK
    using System.Diagnostics;
#else
    using Microsoft.Extensions.Logging;
#endif
    using System.IO;
    using System.Net;
    using System.Text;

    internal class DebugLogRequestHandler : IRequestHandler
    {
        public DebugLogRequestHandler(Configuration configuration)
        {
            m_configuration = configuration;
#if !NETFRAMEWORK
            m_logger = new LoggerFactory().AddDebug(LogLevel.Trace).CreateLogger<DebugLogRequestHandler>();
#endif
        }

        public string ProcessUrl(string url)
        {
            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            if (m_configuration.DebugMode)
            {
                LogRequest(request, streamToSend);
            }
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (m_configuration.DebugMode)
            {                
                resultStream.Position = 0;
                LogResponse(response, resultStream);
            }
        }

        private void LogRequest(WebRequest request, Stream streamToSend)
        {           
            string header = string.Format("{0}: {1}", request.Method, request.RequestUri);
            StringBuilder sb = new StringBuilder();
            FormatHeaders(sb, request.Headers);
            if (streamToSend != null)
            {
                streamToSend.Position = 0;
                StreamHelper.CopyStreamToStringBuilder(sb, streamToSend);
                streamToSend.Position = 0;
            }
            Log(header, sb);            
        }

        private void LogResponse(HttpWebResponse response, Stream resultStream)
        {
            string header = string.Format("\r\nResponse {0}: {1}", (int)response.StatusCode, response.StatusCode);
            StringBuilder sb = new StringBuilder();
            FormatHeaders(sb, response.Headers);
            StreamHelper.CopyStreamToStringBuilder(sb, resultStream);
            Log(header, sb);
        }

        private void FormatHeaders(StringBuilder sb, WebHeaderCollection headerDictionary)
        {
            foreach (string key in headerDictionary.AllKeys)
            {
                sb.Append(key);
                sb.Append(": ");
                sb.AppendLine(headerDictionary[key]);
            }
        }

        private void Log(string header, StringBuilder sb)
        {
#if NETFRAMEWORK
            Trace.WriteLine(header);
            Trace.WriteLine(sb.ToString());
#else
            m_logger.LogTrace(header);
            m_logger.LogTrace(sb.ToString());
#endif
        }

        private readonly Configuration m_configuration;

#if !NETFRAMEWORK
        private readonly ILogger m_logger;
#endif
    }
}