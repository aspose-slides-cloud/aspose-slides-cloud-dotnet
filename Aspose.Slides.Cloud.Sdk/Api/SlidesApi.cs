// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SlidesApi.cs">
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
    public class SlidesApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="SlidesApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public SlidesApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SlidesApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public SlidesApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Delete presentation slide by its index. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideByIndexRequest" /></param> 
        /// <returns><see cref="SlideListResponse"/></returns>            
        public SlideListResponse DeleteSlideByIndex(DeleteSlideByIndexRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideByIndex");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideListResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Delete presentation slides. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesCleanSlidesListRequest" /></param> 
        /// <returns><see cref="SlideListResponse"/></returns>            
        public SlideListResponse DeleteSlidesCleanSlidesList(DeleteSlidesCleanSlidesListRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesCleanSlidesList");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", request.Slides);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideListResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove presentation slide background color. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesSlideBackgroundRequest" /></param> 
        /// <returns><see cref="SlideBackgroundResponse"/></returns>            
        public SlideBackgroundResponse DeleteSlidesSlideBackground(DeleteSlidesSlideBackgroundRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesSlideBackground");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/background");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideBackgroundResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Convert slide to some format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetSlideWithFormat(GetSlideWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideWithFormat");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/saveAs/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideRequest" /></param> 
        /// <returns><see cref="SlideResponse"/></returns>            
        public SlideResponse GetSlidesSlide(GetSlidesSlideRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlide");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation slide background color type. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideBackgroundRequest" /></param> 
        /// <returns><see cref="SlideBackgroundResponse"/></returns>            
        public SlideBackgroundResponse GetSlidesSlideBackground(GetSlidesSlideBackgroundRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideBackground");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/background");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideBackgroundResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation slide comments. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideCommentsRequest" /></param> 
        /// <returns><see cref="SlideCommentsResponse"/></returns>            
        public SlideCommentsResponse GetSlidesSlideComments(GetSlidesSlideCommentsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideComments");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/comments");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideCommentsResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation slides info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlidesListRequest" /></param> 
        /// <returns><see cref="SlideListResponse"/></returns>            
        public SlideListResponse GetSlidesSlidesList(GetSlidesSlidesListRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlidesList");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideListResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Convert slide to some format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlideSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSlideSaveAs(PostSlideSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlideSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/saveAs/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Reorder presentation slide position 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesReorderPositionRequest" /></param> 
        /// <returns><see cref="SlideListResponse"/></returns>            
        public SlideListResponse PostSlidesReorderPosition(PostSlidesReorderPositionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesReorderPosition");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldPosition", request.OldPosition);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newPosition", request.NewPosition);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slideToCopy", request.SlideToCopy);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slideToClone", request.SlideToClone);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "source", request.Source);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "layoutAlias", request.LayoutAlias);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideListResponse>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Update slide properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideRequest" /></param> 
        /// <returns><see cref="SlideResponse"/></returns>            
        public SlideResponse PutSlidesSlide(PutSlidesSlideRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSlide");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.SlideDto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Set presentation slide background color. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideBackgroundRequest" /></param> 
        /// <returns><see cref="SlideBackgroundResponse"/></returns>            
        public SlideBackgroundResponse PutSlidesSlideBackground(PutSlidesSlideBackgroundRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSlideBackground");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/background");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "color", request.Color);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Background, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideBackgroundResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }
    }
}
