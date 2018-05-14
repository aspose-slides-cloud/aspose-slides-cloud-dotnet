// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LayoutSlidesApi.cs">
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
    public class LayoutSlidesApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutSlidesApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public LayoutSlidesApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutSlidesApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public LayoutSlidesApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Read presentation layoutSlide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetLayoutSlideRequest" /></param> 
        /// <returns><see cref="LayoutSlideResponse"/></returns>            
        public LayoutSlideResponse GetLayoutSlide(GetLayoutSlideRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetLayoutSlide");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides/{slideIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<LayoutSlideResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation layoutSlides info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetLayoutSlidesListRequest" /></param> 
        /// <returns><see cref="LayoutSlideListResponse"/></returns>            
        public LayoutSlideListResponse GetLayoutSlidesList(GetLayoutSlidesListRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetLayoutSlidesList");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<LayoutSlideListResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Copy layoutSlide from source presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyLayoutSlideFromSourcePresentationRequest" /></param> 
        /// <returns><see cref="LayoutSlideResponse"/></returns>            
        public LayoutSlideResponse PostCopyLayoutSlideFromSourcePresentation(PostCopyLayoutSlideFromSourcePresentationRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCopyLayoutSlideFromSourcePresentation");
            }

            // verify the required parameter 'cloneFrom' is set
            if (request.CloneFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'cloneFrom' when calling PostCopyLayoutSlideFromSourcePresentation");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFrom", request.CloneFrom);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromPosition", request.CloneFromPosition);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromStorage", request.CloneFromStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<LayoutSlideResponse>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation layoutSlide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutLayoutSlideRequest" /></param> 
        /// <returns><see cref="LayoutSlideResponse"/></returns>            
        public LayoutSlideResponse PutLayoutSlide(PutLayoutSlideRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutLayoutSlide");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides/{slideIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.SlideDto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<LayoutSlideResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }
    }
}