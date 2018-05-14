// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PropertiesApi.cs">
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
    public class PropertiesApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public PropertiesApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public PropertiesApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Clean document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentPropertiesResponse"/></returns>            
        public DocumentPropertiesResponse DeleteSlidesDocumentProperties(DeleteSlidesDocumentPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesDocumentProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentPropertiesResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Delete document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertiesResponse"/></returns>            
        public DocumentPropertiesResponse DeleteSlidesDocumentProperty(DeleteSlidesDocumentPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesDocumentProperty");
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null)
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling DeleteSlidesDocumentProperty");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties/{propertyName}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentPropertiesResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentPropertiesResponse"/></returns>            
        public DocumentPropertiesResponse GetSlidesDocumentProperties(GetSlidesDocumentPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesDocumentProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentPropertiesResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse GetSlidesDocumentProperty(GetSlidesDocumentPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesDocumentProperty");
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null)
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling GetSlidesDocumentProperty");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties/{propertyName}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentPropertyResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Set document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSetDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentPropertiesResponse"/></returns>            
        public DocumentPropertiesResponse PostSlidesSetDocumentProperties(PostSlidesSetDocumentPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesSetDocumentProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Properties, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentPropertiesResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Set document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSetDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse PutSlidesSetDocumentProperty(PutSlidesSetDocumentPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSetDocumentProperty");
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null)
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PutSlidesSetDocumentProperty");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties/{propertyName}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Property, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentPropertyResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }
    }
}