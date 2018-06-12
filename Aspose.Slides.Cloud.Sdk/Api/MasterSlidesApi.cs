// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MasterSlidesApi.cs">
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
    public class MasterSlidesApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="MasterSlidesApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public MasterSlidesApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MasterSlidesApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public MasterSlidesApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Read presentation masterSlide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMasterSlideRequest" /></param> 
        /// <returns><see cref="MasterSlideResponse"/></returns>            
        public MasterSlideResponse GetMasterSlide(GetMasterSlideRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetMasterSlide");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/masterSlides/{slideIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<MasterSlideResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation masterSlides info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMasterSlidesListRequest" /></param> 
        /// <returns><see cref="MasterSlideListResponse"/></returns>            
        public MasterSlideListResponse GetMasterSlidesList(GetMasterSlidesListRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetMasterSlidesList");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/masterSlides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<MasterSlideListResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Copy masterSlide from source presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyMasterSlideFromSourcePresentationRequest" /></param> 
        /// <returns><see cref="MasterSlideResponse"/></returns>            
        public MasterSlideResponse PostCopyMasterSlideFromSourcePresentation(PostCopyMasterSlideFromSourcePresentationRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCopyMasterSlideFromSourcePresentation");
            }

            // verify the required parameter 'cloneFrom' is set
            if (request.CloneFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'cloneFrom' when calling PostCopyMasterSlideFromSourcePresentation");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/masterSlides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFrom", request.CloneFrom);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromPosition", request.CloneFromPosition);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromStorage", request.CloneFromStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "applyToAll", request.ApplyToAll);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<MasterSlideResponse>(resourcePath, "POST", null, null, files, contentType);
        }
    }
}
