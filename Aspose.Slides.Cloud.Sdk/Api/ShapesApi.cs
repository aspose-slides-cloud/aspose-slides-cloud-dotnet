// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapesApi.cs">
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
    public class ShapesApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="ShapesApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public ShapesApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ShapesApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ShapesApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Removes a shape, specified shapes or all shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphListResponse"/></returns>            
        public ParagraphListResponse DeleteParagraph(DeleteParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraph");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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
        /// <param name="request">Request. <see cref="DeleteParagraphsRequest" /></param> 
        /// <returns><see cref="ParagraphListResponse"/></returns>            
        public ParagraphListResponse DeleteParagraphs(DeleteParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraphs");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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
        /// <param name="request">Request. <see cref="DeletePortionRequest" /></param> 
        /// <returns><see cref="PortionListResponse"/></returns>            
        public PortionListResponse DeletePortion(DeletePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeletePortion");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeletePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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
        /// <param name="request">Request. <see cref="DeletePortionsRequest" /></param> 
        /// <returns><see cref="PortionListResponse"/></returns>            
        public PortionListResponse DeletePortions(DeletePortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeletePortions");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeletePortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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
        /// <param name="request">Request. <see cref="DeleteSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeListResponse"/></returns>            
        public ShapeListResponse DeleteSlideShape(DeleteSlideShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideShape");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteSlideShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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
        /// <param name="request">Request. <see cref="GetParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse GetParagraph(GetParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraph");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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
        /// <param name="request">Request. <see cref="GetParagraphsRequest" /></param> 
        /// <returns><see cref="ParagraphListResponse"/></returns>            
        public ParagraphListResponse GetParagraphs(GetParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphs");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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
        /// <param name="request">Request. <see cref="GetPortionRequest" /></param> 
        /// <returns><see cref="PortionResponse"/></returns>            
        public PortionResponse GetPortion(GetPortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPortion");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetPortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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
        /// <param name="request">Request. <see cref="GetPortionsRequest" /></param> 
        /// <returns><see cref="PortionListResponse"/></returns>            
        public PortionListResponse GetPortions(GetPortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPortions");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetPortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<PortionListResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes or shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetShapeRequest" /></param> 
        /// <returns><see cref="ShapeResponse"/></returns>            
        public ShapeResponse GetShape(GetShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetShape");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetShapeWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetShapeWithFormat(GetShapeWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetShapeWithFormat");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/saveAs/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.ScaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.ScaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", request.Bounds);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes or shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideShapesParentRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse GetSlidesSlideShapesParent(GetSlidesSlideShapesParentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideShapesParent");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetSlidesSlideShapesParent");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SaaSposeResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Creates new shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse PostAddNewParagraph(PostAddNewParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewParagraph");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostAddNewParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", request.ShapeToClone);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.ParagraphDto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ParagraphResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Creates new shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewPortionRequest" /></param> 
        /// <returns><see cref="PortionResponse"/></returns>            
        public PortionResponse PostAddNewPortion(PostAddNewPortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewPortion");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostAddNewPortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", request.ShapeToClone);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.PortionDto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<PortionResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Creates new shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewShapeRequest" /></param> 
        /// <returns><see cref="ShapeResponse"/></returns>            
        public ShapeResponse PostAddNewShape(PostAddNewShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewShape");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostAddNewShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", request.ShapeToClone);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.ShapeDto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeResponse>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Updates shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideShapeInfoRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse PutSlideShapeInfo(PutSlideShapeInfoRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideShapeInfo");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutSlideShapeInfo");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SaaSposeResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Updates shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse PutUpdateParagraph(PutUpdateParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateParagraph");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutUpdateParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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
        /// <param name="request">Request. <see cref="PutUpdatePortionRequest" /></param> 
        /// <returns><see cref="PortionResponse"/></returns>            
        public PortionResponse PutUpdatePortion(PutUpdatePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdatePortion");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutUpdatePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path + "/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
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

        /// <summary>
        /// Updates shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateShapeRequest" /></param> 
        /// <returns><see cref="ShapeResponse"/></returns>            
        public ShapeResponse PutUpdateShape(PutUpdateShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateShape");
            }

            // verify the required parameter 'path' is set
            if (request.Path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutUpdateShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeResponse>(resourcePath, "PUT", postBody, null, files, contentType);
        }
    }
}