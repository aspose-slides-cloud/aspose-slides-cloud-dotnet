// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NotesSlideApi.cs">
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
    public class NotesSlideApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesSlideApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public NotesSlideApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesSlideApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public NotesSlideApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Remove Notes Slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideRequest" /></param> 
        /// <returns><see cref="SlideResponse"/></returns>            
        public SlideResponse DeleteNotesSlide(DeleteNotesSlideRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlide");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Read Notes slide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlideResponse"/></returns>            
        public NotesSlideResponse GetNotesSlide(GetNotesSlideRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlide");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<NotesSlideResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Convert Notes Slide to the specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetNotesSlideWithFormat(GetNotesSlideWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideWithFormat");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/saveAs/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Add new Notes Slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlideResponse"/></returns>            
        public NotesSlideResponse PostAddNotesSlide(PostAddNotesSlideRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNotesSlide");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<NotesSlideResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update Notes Slide properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlideResponse"/></returns>            
        public NotesSlideResponse PutUpdateNotesSlide(PutUpdateNotesSlideRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlide");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<NotesSlideResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }
    }
}