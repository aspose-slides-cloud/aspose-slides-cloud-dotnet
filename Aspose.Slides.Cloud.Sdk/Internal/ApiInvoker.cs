// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiInvoker.cs">
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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
#if !NETFRAMEWORK
    using System.Reflection;
#endif
    using System.Text;

    internal abstract class ApiInvoker<T, B> where T : class
    {
        public ApiInvoker(List<IRequestHandler> requestHandlers, StreamCopier<B> streamCopier, ResponseProcessor<T> responseProcessor)
        {
#if NETFRAMEWORK
            var sdkVersion = GetType().Assembly.GetName().Version;
#else
            var sdkVersion = GetType().GetTypeInfo().Assembly.GetName().Version;
#endif
            AddDefaultHeader(c_asposeClientHeaderName, ".net sdk");
            AddDefaultHeader(c_asposeClientVersionHeaderName, string.Format("{0}.{1}", sdkVersion.Major, sdkVersion.Minor));
            m_requestHandlers = requestHandlers;
            m_streamCopier = streamCopier;
            m_responseProcessor = responseProcessor;
        }

        public T InvokeApi(
            string url,
            string method,
            B body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
        {
            Stream response = null;
            try
            {
                if (files == null)
                {
                    files = new List<FileInfo>();
                }
                if (headerParams == null)
                {
                    headerParams = new Dictionary<string, string>();
                }
                m_requestHandlers.ForEach(p => url = p.ProcessUrl(url));
                try
                {
                    response = Call(url, method, headerParams, files, body, contentType);
                }
                catch (NeedRepeatRequestException)
                {
                    response = Call(url, method, headerParams, files, body, contentType);
                }
                return m_responseProcessor.ProcessResponse(response, contentType);
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }
                throw;
            }
            finally
            {
                m_responseProcessor.PostProcessResponse(response);
            }
        }

        private Stream Call(
            string path,
            string method,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            B body,
            string contentType)
        {
            WebRequest client = WebRequest.Create(path);

            foreach (var headerParamsItem in headerParams)
            {
                client.Headers[headerParamsItem.Key] = headerParamsItem.Value;
            }
            foreach (var defaultHeaderMapItem in m_defaultHeaderMap)
            {
                if (!headerParams.ContainsKey(defaultHeaderMapItem.Key))
                {
                    client.Headers[defaultHeaderMapItem.Key] = defaultHeaderMapItem.Value;
                }
            }

            client.Method = method;
            switch (method)
            {
                case "GET":
                    m_requestHandlers.ForEach(p => p.BeforeSend(client, null));
                    break;
                case "POST":
                case "PUT":
                case "DELETE":
                    using (MemoryStream inputData = new MemoryStream())
                    {
                        WriteBodyAndFiles(inputData, body, files, ref contentType);
                        client.ContentType = contentType;
                        m_requestHandlers.ForEach(p => p.BeforeSend(client, inputData));
                        inputData.Position = 0;
#if NETFRAMEWORK
                        using (Stream requestStream = client.GetRequestStream())
#else
                        using (Stream requestStream = client.GetRequestStreamAsync().Result)
#endif
                        {
                            StreamHelper.CopyTo(inputData, requestStream);
                        }
                    }
                    break;
                default:
                    throw new ApiException(500, "unknown method type " + method);
            }

            HttpWebResponse webResponse = (HttpWebResponse)GetResponse(client);

            MemoryStream resultStream = new MemoryStream();
            StreamHelper.CopyTo(webResponse.GetResponseStream(), resultStream);
            m_requestHandlers.ForEach(p => p.ProcessResponse(webResponse, resultStream));
            resultStream.Position = 0;
            return resultStream;
        }

        private void WriteBodyAndFiles(Stream stream, B body, List<FileInfo> files, ref string contentType)
        {
            string formDataBoundary = Guid.NewGuid().ToString();
            int partCount = files.Count + (body != null ? 1 : 0);
            int partIndex = 0;
            if (files.Count > 0)
            {
                contentType = partCount > 1 ? "multipart/form-data; boundary=" + formDataBoundary : "multipart/form-data";
            }
            if (body != null)
            {
                WriteMultipartFormDataHeader(stream, null, contentType, formDataBoundary, ref partIndex, partCount);
                m_streamCopier.CopyToStream(body, stream);
            }
            foreach (FileInfo file in files)
            {
                WriteMultipartFormDataHeader(stream, file.Name, file.MimeType, formDataBoundary, ref partIndex, partCount);
                StreamHelper.CopyTo(file.Content, stream);
            }
            if (partCount > 1)
            {
                // Add the end of the request.  Start with a newline
                WriteToStream(stream, "\r\n--" + formDataBoundary + "--\r\n");
            }
        }

        private static void WriteMultipartFormDataHeader(
            Stream stream, string name, string mimeType, string boundary, ref int partIndex, int partCount)
        {
            if (partCount > 1)
            {
                // Thanks to feedback from commenters, add a CRLF to allow multiple parameters to be added.
                // Skip it on the first parameter, add it to subsequent parameters.
                if (partIndex > 0)
                {
                    WriteToStream(stream, "\r\n");
                    stream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));
                }
                partIndex++;


                WriteToStream(stream, "--" + boundary + "\r\n");
                if (!string.IsNullOrEmpty(mimeType))
                {
                    WriteToStream(stream, "Content-type: " + mimeType + "; charset=utf-8\r\n");
                }
                if (!string.IsNullOrEmpty(name))
                {
                    WriteToStream(stream, "Content-Disposition: form-data; name=" + Path.GetFileNameWithoutExtension(name) + "; filename=" + name + "\r\n\r\n");
                }
                else
                {
                    WriteToStream(stream, "Content-Disposition: form-data\r\n\r\n");
                }
            }
        }

        private static void WriteToStream(Stream stream, string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            stream.Write(bytes, 0, bytes.Length);
        }

        private WebResponse GetResponse(WebRequest request)
        {
            try
            {
#if NETFRAMEWORK
                return request.GetResponse();
#else
                return request.GetResponseAsync().Result;
#endif
            }
#if !NETFRAMEWORK
            catch (AggregateException ex)
            {
                foreach (Exception iex in ex.InnerExceptions)
                {
                    WebException wex = iex as WebException;
                    if (wex != null && wex.Response != null)
                    {
                        return wex.Response;
                    }
                }
                throw;
            }
#endif
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    return wex.Response;
                }
                throw;
            }
        }

        private void AddDefaultHeader(string key, string value)
        {
            if (!m_defaultHeaderMap.ContainsKey(key))
            {
                m_defaultHeaderMap.Add(key, value);
            }
        }

        private const string c_asposeClientHeaderName = "x-aspose-client";
        private const string c_asposeClientVersionHeaderName = "x-aspose-client-version";
        //TODO: move to ApiAccessor
        private readonly Dictionary<string, string> m_defaultHeaderMap = new Dictionary<string, string>();
        private readonly List<IRequestHandler> m_requestHandlers;
        private readonly StreamCopier<B> m_streamCopier;
        private readonly ResponseProcessor<T> m_responseProcessor;

        private List<IRequestHandler> requestHandlers;
    }
}
