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

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Aspose.Slides.Cloud.Sdk
{
    internal abstract class ApiInvoker<T, B> where T : class
    {
        public ApiInvoker(List<IRequestHandler> requestHandlers)
        {
            m_requestHandlers = requestHandlers;
        }

        public object InvokeApi(
            string url,
            string method,
            B body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType,
            Type returnType)
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
                try
                {
                    response = Call(url, method, headerParams, files, body, contentType);
                }
                catch (NeedRepeatRequestException)
                {
                    response = Call(url, method, headerParams, files, body, contentType);
                }
                if (returnType == null)
                {
                    
                    return null;
                }
                if (typeof(Stream).IsAssignableFrom(returnType))
                {
                    return response;
                }
                return SerializationHelper.Deserialize(response, contentType, returnType);
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404 && returnType != null && method == "GET")
                {
                    return null;
                }
                throw;
            }
            catch (NeedRepeatRequestException)
            {
                throw new ApiException(401, "Unauthorized");
            }
            finally
            {
                if (!typeof(Stream).IsAssignableFrom(returnType) && response != null)
                {
                    response.Dispose();
                }
            }
        }

        protected abstract void CopyToStream(B data, Stream stream);

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
            client.Method = method;
            switch (method)
            {
                case "GET":
                    m_requestHandlers.ForEach(p => p.BeforeSend(client, null));
                    break;
                case "POST":
                case "PUT":
                case "DELETE":
#if NETFRAMEWORK
                    using (Stream requestStream = client.GetRequestStream())
#else
                    using (Stream requestStream = client.GetRequestStreamAsync().Result)
#endif
                    {
                        WriteBodyAndFiles(requestStream, body, files, ref contentType);
                        client.ContentType = contentType;
                        m_requestHandlers.ForEach(p => p.BeforeSend(client, null));
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
            //content is multipart if there are multiple files and/or body params
            if (files.Count > 0)
            {
                string formDataBoundary = Guid.NewGuid().ToString();
                int partIndex = 0;
                contentType = "multipart/form-data; boundary=" + formDataBoundary;
                if (body != null)
                {
                    WriteMultipartFormDataHeader(stream, null, contentType, formDataBoundary, ref partIndex);
                    CopyToStream(body, stream);
                }
                int i = 1;
                foreach (FileInfo file in files)
                {
                    string fileName = file.Name ?? "file" + i;
                    string fileType = file.MimeType ?? "application/octet-stream";
                    WriteMultipartFormDataHeader(stream, fileName, fileType, formDataBoundary, ref partIndex);
                    StreamHelper.CopyTo(file.Content, stream);
                    i++;
                }
                // Add the end of the request.  Start with a newline
                WriteToStream(stream, "\r\n--" + formDataBoundary + "--\r\n");
            }
            else if (body != null)
            {
                CopyToStream(body, stream);
            }
        }

        private static void WriteMultipartFormDataHeader(
            Stream stream, string name, string mimeType, string boundary, ref int partIndex)
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

        private readonly List<IRequestHandler> m_requestHandlers;
    }
}
