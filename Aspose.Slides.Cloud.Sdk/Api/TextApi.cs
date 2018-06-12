// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextApi.cs">
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
    public class TextApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="TextApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public TextApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TextApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public TextApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Extract presentation text items. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesPresentationTextItemsRequest" /></param> 
        /// <returns><see cref="TextItemsResponse"/></returns>            
        public TextItemsResponse GetSlidesPresentationTextItems(GetSlidesPresentationTextItemsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesPresentationTextItems");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/textItems");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withEmpty", request.WithEmpty);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<TextItemsResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Extract slide text items. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideTextItemsRequest" /></param> 
        /// <returns><see cref="TextItemsResponse"/></returns>            
        public TextItemsResponse GetSlidesSlideTextItems(GetSlidesSlideTextItemsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideTextItems");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/textItems");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withEmpty", request.WithEmpty);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<TextItemsResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Replace text by a new value. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesPresentationReplaceTextRequest" /></param> 
        /// <returns><see cref="PresentationStringReplaceResponse"/></returns>            
        public PresentationStringReplaceResponse PostSlidesPresentationReplaceText(PostSlidesPresentationReplaceTextRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesPresentationReplaceText");
            }

            // verify the required parameter 'oldValue' is set
            if (request.OldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling PostSlidesPresentationReplaceText");
            }

            // verify the required parameter 'newValue' is set
            if (request.NewValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling PostSlidesPresentationReplaceText");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/replaceText");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldValue", request.OldValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newValue", request.NewValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreCase", request.IgnoreCase);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<PresentationStringReplaceResponse>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Replace text by a new value. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSlideReplaceTextRequest" /></param> 
        /// <returns><see cref="SlideStringReplaceResponse"/></returns>            
        public SlideStringReplaceResponse PostSlidesSlideReplaceText(PostSlidesSlideReplaceTextRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesSlideReplaceText");
            }

            // verify the required parameter 'oldValue' is set
            if (request.OldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling PostSlidesSlideReplaceText");
            }

            // verify the required parameter 'newValue' is set
            if (request.NewValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling PostSlidesSlideReplaceText");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/replaceText");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldValue", request.OldValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newValue", request.NewValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreCase", request.IgnoreCase);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideStringReplaceResponse>(resourcePath, "POST", null, null, files, contentType);
        }
    }
}
