// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SlidesAsyncApi.cs">
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
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.RequestHandlers;

namespace Aspose.Slides.Cloud.Sdk
{
    /// <summary>
    /// Aspose.Slides for Cloud API.
    /// </summary>
    public class SlidesAsyncApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="SlidesAsyncApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The Client Id.
        /// </param>
        /// <param name="appKey">
        /// The Client Secret.
        /// </param>
        public SlidesAsyncApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlidesAsyncApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public SlidesAsyncApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetOperationResult(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling GetOperationResult");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/async/{id}/result");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "id", id);
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "GET", null, null, requestFiles, "application/json");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param> 
        /// <returns><see cref="Operation"/></returns>            
        public Operation GetOperationStatus(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling GetOperationStatus");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/async/{id}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "id", id);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Operation>(resourcePath, "GET", null, null, requestFiles, "application/json");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="format"></param> 
        /// <param name="password"></param> 
        /// <param name="storage"></param> 
        /// <param name="fontsFolder"></param> 
        /// <param name="slides"></param> 
        /// <param name="options"></param> 
        /// <returns><see cref="string"/></returns>            
        public string StartConvert(System.IO.Stream document, ExportFormat format, string password = null, string storage = null, string fontsFolder = null, List<int> slides = null, ExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling StartConvert");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/async/convert/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", slides);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeApi<string>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="format"></param> 
        /// <param name="outPath"></param> 
        /// <param name="password"></param> 
        /// <param name="storage"></param> 
        /// <param name="fontsFolder"></param> 
        /// <param name="slides"></param> 
        /// <param name="options"></param> 
        /// <returns><see cref="string"/></returns>            
        public string StartConvertAndSave(System.IO.Stream document, ExportFormat format, string outPath, string password = null, string storage = null, string fontsFolder = null, List<int> slides = null, ExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling StartConvertAndSave");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling StartConvertAndSave");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/async/convert/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", slides);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeApi<string>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format"></param> 
        /// <param name="options"></param> 
        /// <param name="password"></param> 
        /// <param name="folder"></param> 
        /// <param name="storage"></param> 
        /// <param name="fontsFolder"></param> 
        /// <param name="slides"></param> 
        /// <returns><see cref="string"/></returns>            
        public string StartDownloadPresentation(string name, ExportFormat format, ExportOptions options = null, string password = null, string folder = null, string storage = null, string fontsFolder = null, List<int> slides = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling StartDownloadPresentation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/async/{name}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", slides);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<string>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="files">Files to merge</param> 
        /// <param name="request"></param> 
        /// <param name="storage"></param> 
        /// <returns><see cref="string"/></returns>            
        public string StartMerge(List<FileInfo> files = null, OrderedMergeRequest request = null, string storage = null)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/async/merge");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (files != null) 
            {
                requestFiles.AddRange(files);
            }
            return InvokeApi<string>(resourcePath, "POST", postBody, null, requestFiles, "application/json");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="outPath"></param> 
        /// <param name="files">Files to merge</param> 
        /// <param name="request"></param> 
        /// <param name="storage"></param> 
        /// <returns><see cref="string"/></returns>            
        public string StartMergeAndSave(string outPath, List<FileInfo> files = null, OrderedMergeRequest request = null, string storage = null)
        {
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling StartMergeAndSave");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/async/merge");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (files != null) 
            {
                requestFiles.AddRange(files);
            }
            return InvokeApi<string>(resourcePath, "PUT", postBody, null, requestFiles, "application/json");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format"></param> 
        /// <param name="outPath"></param> 
        /// <param name="options"></param> 
        /// <param name="password"></param> 
        /// <param name="folder"></param> 
        /// <param name="storage"></param> 
        /// <param name="fontsFolder"></param> 
        /// <param name="slides"></param> 
        /// <returns><see cref="string"/></returns>            
        public string StartSavePresentation(string name, ExportFormat format, string outPath, ExportOptions options = null, string password = null, string folder = null, string storage = null, string fontsFolder = null, List<int> slides = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling StartSavePresentation");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling StartSavePresentation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/async/{name}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", slides);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<string>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        protected override string GetBaseUrl(Configuration configuration)
        {
            return configuration.GetSlidesAsyncApiRootUrl();
        }
    }
}
