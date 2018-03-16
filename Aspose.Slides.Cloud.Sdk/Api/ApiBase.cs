// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiBase.cs">
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

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Aspose.Slides.Cloud.Sdk
{
    /// <summary>
    /// Aspose.Slides for Cloud API.
    /// </summary>
    public abstract class ApiBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiBase"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="appKey">
        /// The app Key.
        /// </param>
        protected ApiBase(string appSid, string appKey) : this(new Configuration { AppSid = appSid, AppKey = appKey })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiBase"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        protected ApiBase(Configuration configuration)
        {
            m_configuration = configuration;
            m_api = new ApiAccessor(configuration);
        }

        /// <summary>
        /// Gets image in specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="SlidesImagesGetSlidesImageWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        protected string GetResourceUrl(string resourcePath)
        {
            string url = m_configuration.GetApiRootUrl() + resourcePath;
            return Regex.Replace(url, "\\*", string.Empty).Replace("&amp;", "&").Replace("/?", "?");
        }

        protected Stream InvokeBinaryApi(
            string url,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
        {
            return m_api.InvokeBinaryApi(url, method, body, headerParams, files, contentType);
        }

        protected Stream InvokeBinaryStreamApi(
            string url,
            string method,
            Stream body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
        {
            return m_api.InvokeBinaryStreamApi(url, method, body, headerParams, files, contentType);
        }

        protected T InvokeApi<T>(
            string url,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
            where T : class
        {
            return m_api.InvokeApi<T>(url, method, body, headerParams, files, contentType);
        }

        protected T InvokeStreamApi<T>(
            string url,
            string method,
            Stream body,
            Dictionary<string, string> headerParams,
            List<FileInfo> files,
            string contentType)
            where T : class
        {
            return m_api.InvokeStreamApi<T>(url, method, body, headerParams, files, contentType);
        }

        protected void PickFiles(List<FileInfo> files, object entity)
        {
            if (entity != null)
            {
                if (entity is FileInfo)
                {
                    files.Add((FileInfo)entity);
                }
                else
                {
                    IEnumerable<FileInfo> entityFiles = entity as IEnumerable<FileInfo>;
                    if (entityFiles != null)
                    {
                        files.AddRange(entityFiles);
                    }
                    else
                    {
                        if (!(entity is IEnumerable) && !(entity is Stream))
                        {
#if NETFRAMEWORK
                            foreach (PropertyInfo property in entity.GetType().GetProperties())
#else
                            foreach (PropertyInfo property in entity.GetType().GetTypeInfo().DeclaredProperties)
#endif
                            {
                                PickFiles(files, property.GetValue(entity, null));
                            }
                        }
                    }
                }
            }
        }

        private readonly ApiAccessor m_api;
        private readonly Configuration m_configuration;
    }
}
