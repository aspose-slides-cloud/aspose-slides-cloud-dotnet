// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiAccessor.cs">
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

namespace Aspose.Slides.Cloud.Sdk
{
    using RequestHandlers;
    using System.Collections.Generic;
    using System.IO;

    internal class ApiAccessor
    {        
        public ApiAccessor(Configuration configuration)
        {
            List<IRequestHandler> requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new JwtRequestHandler(configuration));
            requestHandlers.Add(new DebugLogRequestHandler(configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            m_requestHandlers = requestHandlers;
        }

        public Stream InvokeBinaryApi(
            string url,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
        {
            return new StringToStreamApiInvoker(m_requestHandlers).InvokeApi(url, method, body, headerParams, files, contentType);
        }

        public Stream InvokeBinaryStreamApi(
            string url,
            string method,
            Stream body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
        {
            return new StreamToStreamApiInvoker(m_requestHandlers).InvokeApi(url, method, body, headerParams, files, contentType);
        }

        public T InvokeApi<T>(
            string url,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
            where T : class
        {
            return new StringToObjectApiInvoker<T>(m_requestHandlers).InvokeApi(url, method, body, headerParams, files, contentType);
        }

        public T InvokeStreamApi<T>(
            string url,
            string method,
            Stream body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
            where T : class
        {
            return new StreamToObjectApiInvoker<T>(m_requestHandlers).InvokeApi(url, method, body, headerParams, files, contentType);
        }

        public void InvokeVoidApi(
            string url,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
        {
            new StringToNullApiInvoker(m_requestHandlers).InvokeApi(url, method, body, headerParams, files, contentType);
        }

        public void InvokeVoidStreamApi(
            string url,
            string method,
            Stream body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
        {
            new StreamToNullApiInvoker(m_requestHandlers).InvokeApi(url, method, body, headerParams, files, contentType);
        }

        public static FileInfo ToFileInfo(Stream stream, string paramName)
        {
            // TODO: add contenttype
            return new FileInfo { Name = paramName, Content = stream };
        }                 

        private readonly List<IRequestHandler> m_requestHandlers;
    }
}
