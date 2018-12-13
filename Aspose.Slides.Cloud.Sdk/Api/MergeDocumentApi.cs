// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MergeDocumentApi.cs">
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
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk.RequestHandlers;

namespace Aspose.Slides.Cloud.Sdk
{
    /// <summary>
    /// Aspose.Slides for Cloud API.
    /// </summary>
    public class MergeDocumentApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeDocumentApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public MergeDocumentApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeDocumentApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public MergeDocumentApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Merge the presentation with other presentations specified in the request parameter. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostPresentationMergeRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostPresentationMerge(PostPresentationMergeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostPresentationMerge");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/merge");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Request, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Merge the presentation with other presentations or some of their slides specified in the request parameter. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutPresentationMergeRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PutPresentationMerge(PutPresentationMergeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutPresentationMerge");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/merge");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Request, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }
    }
}