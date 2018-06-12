// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NotesSlideShapesApi.cs">
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
    public class NotesSlideShapesApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesSlideShapesApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public NotesSlideShapesApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="NotesSlideShapesApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public NotesSlideShapesApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Removes a shape, specified shapes or all shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphListResponse"/></returns>            
        public ParagraphListResponse DeleteNotesSlideParagraph(DeleteNotesSlideParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideParagraph");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteNotesSlideParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ParagraphListResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Removes a shape, specified shapes or all shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideParagraphsRequest" /></param> 
        /// <returns><see cref="ParagraphListResponse"/></returns>            
        public ParagraphListResponse DeleteNotesSlideParagraphs(DeleteNotesSlideParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideParagraphs");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteNotesSlideParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphs", request.Paragraphs);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ParagraphListResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Removes a shape, specified shapes or all shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlidePortionRequest" /></param> 
        /// <returns><see cref="PortionListResponse"/></returns>            
        public PortionListResponse DeleteNotesSlidePortion(DeleteNotesSlidePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlidePortion");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteNotesSlidePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<PortionListResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Removes a shape, specified shapes or all shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlidePortionsRequest" /></param> 
        /// <returns><see cref="PortionListResponse"/></returns>            
        public PortionListResponse DeleteNotesSlidePortions(DeleteNotesSlidePortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlidePortions");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteNotesSlidePortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "portions", request.Portions);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<PortionListResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Removes a shape, specified shapes or all shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeListResponse"/></returns>            
        public ShapeListResponse DeleteNotesSlideShape(DeleteNotesSlideShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideShape");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteNotesSlideShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeListResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Removes a shape, specified shapes or all shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideShapesRequest" /></param> 
        /// <returns><see cref="ShapeListResponse"/></returns>            
        public ShapeListResponse DeleteNotesSlideShapes(DeleteNotesSlideShapesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideShapes");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteNotesSlideShapes");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", request.Shapes);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeListResponse>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes or shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeResponse"/></returns>            
        public ShapeResponse GetNotesSlideShape(GetNotesSlideShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShape");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetNotesSlideShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes or shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse GetNotesSlideShapeParagraph(GetNotesSlideShapeParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapeParagraph");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetNotesSlideShapeParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ParagraphResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes or shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeParagraphsRequest" /></param> 
        /// <returns><see cref="ParagraphListResponse"/></returns>            
        public ParagraphListResponse GetNotesSlideShapeParagraphs(GetNotesSlideShapeParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapeParagraphs");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetNotesSlideShapeParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ParagraphListResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes or shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapePortionRequest" /></param> 
        /// <returns><see cref="PortionResponse"/></returns>            
        public PortionResponse GetNotesSlideShapePortion(GetNotesSlideShapePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapePortion");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetNotesSlideShapePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<PortionResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes or shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapePortionsRequest" /></param> 
        /// <returns><see cref="PortionListResponse"/></returns>            
        public PortionListResponse GetNotesSlideShapePortions(GetNotesSlideShapePortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapePortions");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetNotesSlideShapePortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<PortionListResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetNotesSlideShapeWithFormat(GetNotesSlideShapeWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapeWithFormat");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/saveAs/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.ScaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.ScaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", request.Bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes or shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapesRequest" /></param> 
        /// <returns><see cref="ShapeListResponse"/></returns>            
        public ShapeListResponse GetNotesSlideShapes(GetNotesSlideShapesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapes");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetNotesSlideShapes");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeListResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Creates new paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideAddNewParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse PostNotesSlideAddNewParagraph(PostNotesSlideAddNewParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideAddNewParagraph");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostNotesSlideAddNewParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ParagraphResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Creates new portion. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideAddNewPortionRequest" /></param> 
        /// <returns><see cref="PortionResponse"/></returns>            
        public PortionResponse PostNotesSlideAddNewPortion(PostNotesSlideAddNewPortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideAddNewPortion");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostNotesSlideAddNewPortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<PortionResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Creates new shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideAddNewShapeRequest" /></param> 
        /// <returns><see cref="ShapeResponse"/></returns>            
        public ShapeResponse PostNotesSlideAddNewShape(PostNotesSlideAddNewShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideAddNewShape");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostNotesSlideAddNewShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", request.ShapeToClone);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideShapeSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostNotesSlideShapeSaveAs(PostNotesSlideShapeSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideShapeSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/saveAs/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.ScaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.ScaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", request.Bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Updates shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeResponse"/></returns>            
        public ShapeResponse PutUpdateNotesSlideShape(PutUpdateNotesSlideShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlideShape");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutUpdateNotesSlideShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Updates shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideShapeParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse PutUpdateNotesSlideShapeParagraph(PutUpdateNotesSlideShapeParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlideShapeParagraph");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutUpdateNotesSlideShapeParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ParagraphResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Updates shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideShapePortionRequest" /></param> 
        /// <returns><see cref="PortionResponse"/></returns>            
        public PortionResponse PutUpdateNotesSlideShapePortion(PutUpdateNotesSlideShapePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlideShapePortion");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutUpdateNotesSlideShapePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<PortionResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }
    }
}
