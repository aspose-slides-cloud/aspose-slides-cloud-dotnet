// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DocumentApi.cs">
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
    public class DocumentApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public DocumentApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public DocumentApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Get API info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesApiInfoRequest" /></param> 
        /// <returns><see cref="ApiInfoResponse"/></returns>            
        public ApiInfoResponse GetSlidesApiInfo(GetSlidesApiInfoRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/info");
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ApiInfoResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse GetSlidesDocument(GetSlidesDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesDocument");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Export presentation to some format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetSlidesDocumentWithFormat(GetSlidesDocumentWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesDocumentWithFormat");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetSlidesDocumentWithFormat");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/saveAs/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "jpegQuality", request.JpegQuality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Create presentation  
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostSlidesDocument(PostSlidesDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocument");
            }

            // verify the required parameter 'data' is set
            if (request.Data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostSlidesDocument");
            }

            // verify the required parameter 'templatePath' is set
            if (request.TemplatePath == null)
            {
                throw new ApiException(400, "Missing required parameter 'templatePath' when calling PostSlidesDocument");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templatePath", request.TemplatePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templateStorage", request.TemplateStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "isImageDataEmbedded", request.IsImageDataEmbedded);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Data, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Performs slides pipeline. Http-request contains pipeline DTO. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesPipelineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSlidesPipeline(PostSlidesPipelineRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/pipeline");
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Pipeline, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Saves presentation with options 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSlidesSaveAs(PostSlidesSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostSlidesSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/saveAs/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Splitting presentations. Create one image per slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSplitRequest" /></param> 
        /// <returns><see cref="SplitDocumentResponse"/></returns>            
        public SplitDocumentResponse PostSlidesSplit(PostSlidesSplitRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesSplit");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/split");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "to", request.To);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "from", request.From);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFolder", request.DestFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SplitDocumentResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Create presentation  
        /// </summary>
        /// <param name="request">Request. <see cref="PutNewPresentationRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PutNewPresentation(PutNewPresentationRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutNewPresentation");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templatePath", request.TemplatePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templatePassword", request.TemplatePassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templateStorage", request.TemplateStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType = "application/json";
            var postBody = request.Stream;
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeStreamApi<DocumentResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Convert presentation from request content to format specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesConvertRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutSlidesConvert(PutSlidesConvertRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutSlidesConvert");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/convert");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType = "application/json";
            var postBody = request.Document;
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryStreamApi(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Create presentation document from html 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesDocumentFromHtmlRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PutSlidesDocumentFromHtml(PutSlidesDocumentFromHtmlRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesDocumentFromHtml");
            }

            // verify the required parameter 'html' is set
            if (request.Html == null)
            {
                throw new ApiException(400, "Missing required parameter 'html' when calling PutSlidesDocumentFromHtml");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fromHtml");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Html, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Set slide size for the presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideSizeRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PutSlidesSlideSize(PutSlidesSlideSizeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSlideSize");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slidesize");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sizeType", request.SizeType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleType", request.ScaleType);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentResponse>(resourcePath, "PUT", null, null, files, contentType);
        }
    }
}