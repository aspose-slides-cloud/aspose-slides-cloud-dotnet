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
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void CopyFile(CopyFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.DestPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFile");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/copy/{srcPath}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", null, null, files, contentType);
        }

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void CopyFolder(CopyFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.DestPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFolder");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/copy/{srcPath}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", null, null, files, contentType);
        }

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void CreateFolder(CreateFolderRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", null, null, files, contentType);
        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void DeleteFile(DeleteFileRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void DeleteFolder(DeleteFolderRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.Recursive);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove notes slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideRequest" /></param> 
        /// <returns><see cref="Slide"/></returns>            
        public Slide DeleteNotesSlide(DeleteNotesSlideRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Slide>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideParagraphRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteNotesSlideParagraph(DeleteNotesSlideParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a range of paragraphs. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteNotesSlideParagraphs(DeleteNotesSlideParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphs", request.Paragraphs);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a portion. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlidePortionRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteNotesSlidePortion(DeleteNotesSlidePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlidePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portions>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a range of portions. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlidePortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteNotesSlidePortions(DeleteNotesSlidePortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlidePortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "portions", request.Portions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portions>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideShapeRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteNotesSlideShape(DeleteNotesSlideShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a range of shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideShapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteNotesSlideShapes(DeleteNotesSlideShapesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideShapes");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", request.Shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteParagraph(DeleteParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a range of paragraphs. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteParagraphs(DeleteParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphs", request.Paragraphs);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a portion. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeletePortionRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeletePortion(DeletePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeletePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portions>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a range of portions. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeletePortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeletePortions(DeletePortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeletePortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "portions", request.Portions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portions>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove animation from a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSlideAnimation(DeleteSlideAnimationRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimation");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove an effect from slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSlideAnimationEffect(DeleteSlideAnimationEffectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationEffect");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/mainSequence/{effectIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", request.EffectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove an interactive sequence from slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationInteractiveSequenceRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSlideAnimationInteractiveSequence(DeleteSlideAnimationInteractiveSequenceRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationInteractiveSequence");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences/{sequenceIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", request.SequenceIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove an effect from slide animation interactive sequence. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationInteractiveSequenceEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSlideAnimationInteractiveSequenceEffect(DeleteSlideAnimationInteractiveSequenceEffectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationInteractiveSequenceEffect");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences/{sequenceIndex}/{effectIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", request.SequenceIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", request.EffectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Clear all interactive sequences from slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationInteractiveSequencesRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSlideAnimationInteractiveSequences(DeleteSlideAnimationInteractiveSequencesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationInteractiveSequences");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Clear main sequence in slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationMainSequenceRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSlideAnimationMainSequence(DeleteSlideAnimationMainSequenceRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationMainSequence");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/mainSequence");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Delete a presentation slide by index. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideByIndexRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides DeleteSlideByIndex(DeleteSlideByIndexRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Model.Slides>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideShapeRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteSlideShape(DeleteSlideShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a range of shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideShapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteSlideShapes(DeleteSlideShapesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideShapes");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", request.Shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a shape (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideSubshapeRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteSlideSubshape(DeleteSlideSubshapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideSubshape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a range of shapes (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideSubshapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteSlideSubshapes(DeleteSlideSubshapesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideSubshapes");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", request.Shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Delete presentation slides. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesCleanSlidesListRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides DeleteSlidesCleanSlidesList(DeleteSlidesCleanSlidesListRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesCleanSlidesList");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", request.Slides);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Model.Slides>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Clean document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        public DocumentProperties DeleteSlidesDocumentProperties(DeleteSlidesDocumentPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesDocumentProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentProperties>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Delete document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        public DocumentProperties DeleteSlidesDocumentProperty(DeleteSlidesDocumentPropertyRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentProperties>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove background from a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesSlideBackgroundRequest" /></param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        public SlideBackground DeleteSlidesSlideBackground(DeleteSlidesSlideBackgroundRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideBackground>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a paragraph (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSubshapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteSubshapeParagraph(DeleteSubshapeParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSubshapeParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a range of paragraphs (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSubshapeParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteSubshapeParagraphs(DeleteSubshapeParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSubshapeParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphs", request.Paragraphs);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a portion (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSubshapePortionRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteSubshapePortion(DeleteSubshapePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSubshapePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portions>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Remove a range of portions (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSubshapePortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteSubshapePortions(DeleteSubshapePortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSubshapePortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "portions", request.Portions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portions>(resourcePath, "DELETE", null, null, files, contentType);
        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param> 
        /// <returns><see cref="DiscUsage"/></returns>            
        public DiscUsage GetDiscUsage(GetDiscUsageRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/disc");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DiscUsage>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param> 
        /// <returns><see cref="FileVersions"/></returns>            
        public FileVersions GetFileVersions(GetFileVersionsRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/version/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<FileVersions>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param> 
        /// <returns><see cref="FilesList"/></returns>            
        public FilesList GetFilesList(GetFilesListRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<FilesList>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation layoutSlide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetLayoutSlideRequest" /></param> 
        /// <returns><see cref="LayoutSlide"/></returns>            
        public LayoutSlide GetLayoutSlide(GetLayoutSlideRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<LayoutSlide>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation layoutSlides info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetLayoutSlidesListRequest" /></param> 
        /// <returns><see cref="LayoutSlides"/></returns>            
        public LayoutSlides GetLayoutSlidesList(GetLayoutSlidesListRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetLayoutSlidesList");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<LayoutSlides>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation masterSlide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMasterSlideRequest" /></param> 
        /// <returns><see cref="MasterSlide"/></returns>            
        public MasterSlide GetMasterSlide(GetMasterSlideRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<MasterSlide>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation masterSlides info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMasterSlidesListRequest" /></param> 
        /// <returns><see cref="MasterSlides"/></returns>            
        public MasterSlides GetMasterSlidesList(GetMasterSlidesListRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetMasterSlidesList");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/masterSlides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<MasterSlides>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read notes slide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        public NotesSlide GetNotesSlide(GetNotesSlideRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<NotesSlide>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Get info whether a notes slide exists. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideExistsRequest" /></param> 
        /// <returns><see cref="EntityExists"/></returns>            
        public EntityExists GetNotesSlideExists(GetNotesSlideExistsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideExists");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/exist");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<EntityExists>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase GetNotesSlideShape(GetNotesSlideShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeBase>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read shape paragraph info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetNotesSlideShapeParagraph(GetNotesSlideShapeParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapeParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraph>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read shape paragraphs info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs GetNotesSlideShapeParagraphs(GetNotesSlideShapeParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapeParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraphs>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read paragraph portion info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapePortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetNotesSlideShapePortion(GetNotesSlideShapePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portion>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read paragraph portions info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapePortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions GetNotesSlideShapePortions(GetNotesSlideShapePortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapePortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portions>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes GetNotesSlideShapes(GetNotesSlideShapesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapes");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Shapes>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Convert notes slide to the specified image format. 
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

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetNotesSlideWithFormat");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read paragraph portion info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphPortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetParagraphPortion(GetParagraphPortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphPortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portion>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read paragraph portions info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphPortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions GetParagraphPortions(GetParagraphPortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphPortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portions>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide animation effects. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideAnimationRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation GetSlideAnimation(GetSlideAnimationRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideAnimation");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase GetSlideShape(GetSlideShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeBase>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read shape paragraph info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideShapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetSlideShapeParagraph(GetSlideShapeParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideShapeParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraph>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read shape paragraphs info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideShapeParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs GetSlideShapeParagraphs(GetSlideShapeParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideShapeParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraphs>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideShapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes GetSlideShapes(GetSlideShapesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideShapes");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Shapes>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shape info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideSubshapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase GetSlideSubshape(GetSlideSubshapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideSubshape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeBase>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read shape paragraph info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideSubshapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetSlideSubshapeParagraph(GetSlideSubshapeParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideSubshapeParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraph>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read shape paragraphs info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideSubshapeParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs GetSlideSubshapeParagraphs(GetSlideSubshapeParagraphsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideSubshapeParagraphs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraphs>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideSubshapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes GetSlideSubshapes(GetSlideSubshapesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideSubshapes");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Shapes>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Get API info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesApiInfoRequest" /></param> 
        /// <returns><see cref="ApiInfo"/></returns>            
        public ApiInfo GetSlidesApiInfo(GetSlidesApiInfoRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/info");
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ApiInfo>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        public Document GetSlidesDocument(GetSlidesDocumentRequest request)
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
            return InvokeApi<Document>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        public DocumentProperties GetSlidesDocumentProperties(GetSlidesDocumentPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesDocumentProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentProperties>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentProperty"/></returns>            
        public DocumentProperty GetSlidesDocumentProperty(GetSlidesDocumentPropertyRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentProperty>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Get image binary data. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesImageWithDefaultFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetSlidesImageWithDefaultFormat(GetSlidesImageWithDefaultFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesImageWithDefaultFormat");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/images/{index}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Get image in specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesImageWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetSlidesImageWithFormat(GetSlidesImageWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesImageWithFormat");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetSlidesImageWithFormat");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/images/{index}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation images info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesImagesRequest" /></param> 
        /// <returns><see cref="Images"/></returns>            
        public Images GetSlidesImages(GetSlidesImagesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesImages");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/images");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Images>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide placeholder info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesPlaceholderRequest" /></param> 
        /// <returns><see cref="Placeholder"/></returns>            
        public Placeholder GetSlidesPlaceholder(GetSlidesPlaceholderRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesPlaceholder");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/placeholders/{placeholderIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "placeholderIndex", request.PlaceholderIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Placeholder>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide placeholders info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesPlaceholdersRequest" /></param> 
        /// <returns><see cref="Placeholders"/></returns>            
        public Placeholders GetSlidesPlaceholders(GetSlidesPlaceholdersRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesPlaceholders");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/placeholders");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Placeholders>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Extract presentation text items. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesPresentationTextItemsRequest" /></param> 
        /// <returns><see cref="TextItems"/></returns>            
        public TextItems GetSlidesPresentationTextItems(GetSlidesPresentationTextItemsRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<TextItems>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation slide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideRequest" /></param> 
        /// <returns><see cref="Slide"/></returns>            
        public Slide GetSlidesSlide(GetSlidesSlideRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Slide>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide background info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideBackgroundRequest" /></param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        public SlideBackground GetSlidesSlideBackground(GetSlidesSlideBackgroundRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideBackground>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation slide comments. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideCommentsRequest" /></param> 
        /// <returns><see cref="SlideComments"/></returns>            
        public SlideComments GetSlidesSlideComments(GetSlidesSlideCommentsRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideComments>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide images info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideImagesRequest" /></param> 
        /// <returns><see cref="Images"/></returns>            
        public Images GetSlidesSlideImages(GetSlidesSlideImagesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideImages");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/images");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Images>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Extract slide text items. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideTextItemsRequest" /></param> 
        /// <returns><see cref="TextItems"/></returns>            
        public TextItems GetSlidesSlideTextItems(GetSlidesSlideTextItemsRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<TextItems>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation slides info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlidesListRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides GetSlidesSlidesList(GetSlidesSlidesListRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlidesList");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Model.Slides>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide theme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeRequest" /></param> 
        /// <returns><see cref="Theme"/></returns>            
        public Theme GetSlidesTheme(GetSlidesThemeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesTheme");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Theme>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide theme color scheme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeColorSchemeRequest" /></param> 
        /// <returns><see cref="ColorScheme"/></returns>            
        public ColorScheme GetSlidesThemeColorScheme(GetSlidesThemeColorSchemeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesThemeColorScheme");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme/colorScheme");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ColorScheme>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide theme font scheme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeFontSchemeRequest" /></param> 
        /// <returns><see cref="FontScheme"/></returns>            
        public FontScheme GetSlidesThemeFontScheme(GetSlidesThemeFontSchemeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesThemeFontScheme");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme/fontScheme");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<FontScheme>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide theme format scheme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeFormatSchemeRequest" /></param> 
        /// <returns><see cref="FormatScheme"/></returns>            
        public FormatScheme GetSlidesThemeFormatScheme(GetSlidesThemeFormatSchemeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesThemeFormatScheme");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme/formatScheme");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<FormatScheme>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read presentation document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesViewPropertiesRequest" /></param> 
        /// <returns><see cref="ViewProperties"/></returns>            
        public ViewProperties GetSlidesViewProperties(GetSlidesViewPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesViewProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/viewProperties");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ViewProperties>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read paragraph portion info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSubshapeParagraphPortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetSubshapeParagraphPortion(GetSubshapeParagraphPortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSubshapeParagraphPortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portion>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read paragraph portions info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSubshapeParagraphPortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions GetSubshapeParagraphPortions(GetSubshapeParagraphPortionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSubshapeParagraphPortions");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portions>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void MoveFile(MoveFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.DestPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFile");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/move/{srcPath}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", null, null, files, contentType);
        }

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void MoveFolder(MoveFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.DestPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFolder");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/move/{srcPath}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", null, null, files, contentType);
        }

        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param> 
        /// <returns><see cref="ObjectExist"/></returns>            
        public ObjectExist ObjectExists(ObjectExistsRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/exist/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ObjectExist>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Creates new paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph PostAddNewParagraph(PostAddNewParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraph>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Creates new portion. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewPortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion PostAddNewPortion(PostAddNewPortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewPortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portion>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Create new shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase PostAddNewShape(PostAddNewShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", request.ShapeToClone);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeBase>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Create new shape (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewSubshapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase PostAddNewSubshape(PostAddNewSubshapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewSubshape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", request.ShapeToClone);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeBase>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Creates new paragraph (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewSubshapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph PostAddNewSubshapeParagraph(PostAddNewSubshapeParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewSubshapeParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraph>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Creates new portion (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewSubshapePortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion PostAddNewSubshapePortion(PostAddNewSubshapePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewSubshapePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portion>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Add new notes slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        public NotesSlide PostAddNotesSlide(PostAddNotesSlideRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<NotesSlide>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Copy layoutSlide from source presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyLayoutSlideFromSourcePresentationRequest" /></param> 
        /// <returns><see cref="LayoutSlide"/></returns>            
        public LayoutSlide PostCopyLayoutSlideFromSourcePresentation(PostCopyLayoutSlideFromSourcePresentationRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromPassword", request.CloneFromPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromStorage", request.CloneFromStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<LayoutSlide>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Copy masterSlide from source presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyMasterSlideFromSourcePresentationRequest" /></param> 
        /// <returns><see cref="MasterSlide"/></returns>            
        public MasterSlide PostCopyMasterSlideFromSourcePresentation(PostCopyMasterSlideFromSourcePresentationRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromPassword", request.CloneFromPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromStorage", request.CloneFromStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "applyToAll", request.ApplyToAll);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<MasterSlide>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Read notes slide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostGetNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        public NotesSlide PostGetNotesSlide(PostGetNotesSlideRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/notesSlide");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            string contentType = "application/json";
            var postBody = request.Document;
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeStreamApi<NotesSlide>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Get info whether a notes slide exists. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostGetNotesSlideExistsRequest" /></param> 
        /// <returns><see cref="EntityExists"/></returns>            
        public EntityExists PostGetNotesSlideExists(PostGetNotesSlideExistsRequest request)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/notesSlide/exist");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            string contentType = "application/json";
            var postBody = request.Document;
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeStreamApi<EntityExists>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Convert notes slide to the specified image format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostGetNotesSlideWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostGetNotesSlideWithFormat(PostGetNotesSlideWithFormatRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostGetNotesSlideWithFormat");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/notesSlide/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType = "application/json";
            var postBody = request.Document;
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryStreamApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Creates new paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideAddNewParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph PostNotesSlideAddNewParagraph(PostNotesSlideAddNewParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideAddNewParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraph>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Creates new portion. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideAddNewPortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion PostNotesSlideAddNewPortion(PostNotesSlideAddNewPortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideAddNewPortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portion>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Create new shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideAddNewShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase PostNotesSlideAddNewShape(PostNotesSlideAddNewShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideAddNewShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", request.ShapeToClone);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeBase>(resourcePath, "POST", postBody, null, files, contentType);
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

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostNotesSlideShapeSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.ScaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.ScaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", request.Bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Merge the presentation with other presentations specified in the request parameter. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostPresentationMergeRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        public Document PostPresentationMerge(PostPresentationMergeRequest request)
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
            return InvokeApi<Document>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostShapeSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostShapeSaveAs(PostShapeSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostShapeSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostShapeSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.ScaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.ScaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", request.Bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Add an effect to slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlideAnimationEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation PostSlideAnimationEffect(PostSlideAnimationEffectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlideAnimationEffect");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/mainSequence");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Effect, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Set slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlideAnimationInteractiveSequenceRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation PostSlideAnimationInteractiveSequence(PostSlideAnimationInteractiveSequenceRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlideAnimationInteractiveSequence");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Sequence, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Add an animation effect to a slide interactive sequence. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlideAnimationInteractiveSequenceEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation PostSlideAnimationInteractiveSequenceEffect(PostSlideAnimationInteractiveSequenceEffectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlideAnimationInteractiveSequenceEffect");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences/{sequenceIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", request.SequenceIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Effect, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Save a slide to a specified format. 
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

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostSlideSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Create a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesAddRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides PostSlidesAdd(PostSlidesAddRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesAdd");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "layoutAlias", request.LayoutAlias);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Model.Slides>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Convert presentation from request content to format specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesConvertRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSlidesConvert(PostSlidesConvertRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostSlidesConvert");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/convert/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType = "application/json";
            var postBody = request.Document;
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryStreamApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Copy a slide from the current or another presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesCopyRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides PostSlidesCopy(PostSlidesCopyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesCopy");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/copy");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slideToCopy", request.SlideToCopy);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", request.Position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "source", request.Source);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sourcePassword", request.SourcePassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sourceStorage", request.SourceStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Model.Slides>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Create a presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        public Document PostSlidesDocument(PostSlidesDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocument");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "inputPassword", request.InputPassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType = "application/json";
            var postBody = request.Data;
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeStreamApi<Document>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Create presentation document from html. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentFromHtmlRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        public Document PostSlidesDocumentFromHtml(PostSlidesDocumentFromHtmlRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocumentFromHtml");
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
            return InvokeApi<Document>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Create a presentation from an existing source. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentFromSourceRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        public Document PostSlidesDocumentFromSource(PostSlidesDocumentFromSourceRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocumentFromSource");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fromSource");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sourcePath", request.SourcePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sourcePassword", request.SourcePassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sourceStorage", request.SourceStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Document>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Create a presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentFromTemplateRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        public Document PostSlidesDocumentFromTemplate(PostSlidesDocumentFromTemplateRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocumentFromTemplate");
            }

            // verify the required parameter 'templatePath' is set
            if (request.TemplatePath == null)
            {
                throw new ApiException(400, "Missing required parameter 'templatePath' when calling PostSlidesDocumentFromTemplate");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fromTemplate");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templatePath", request.TemplatePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templatePassword", request.TemplatePassword);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templateStorage", request.TemplateStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "isImageDataEmbedded", request.IsImageDataEmbedded);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Data, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Document>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Performs slides pipeline. 
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
        /// Replace text with a new value. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesPresentationReplaceTextRequest" /></param> 
        /// <returns><see cref="DocumentReplaceResult"/></returns>            
        public DocumentReplaceResult PostSlidesPresentationReplaceText(PostSlidesPresentationReplaceTextRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentReplaceResult>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Reorder presentation slide position. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesReorderRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides PostSlidesReorder(PostSlidesReorderRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesReorder");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/move");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newPosition", request.NewPosition);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Model.Slides>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Reorder presentation slides positions. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesReorderManyRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides PostSlidesReorderMany(PostSlidesReorderManyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesReorderMany");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/reorder");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldPositions", request.OldPositions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newPositions", request.NewPositions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Model.Slides>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Save a presentation to a specified format. 
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
            string resourcePath = GetResourceUrl("/slides/{name}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Set document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSetDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        public DocumentProperties PostSlidesSetDocumentProperties(PostSlidesSetDocumentPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesSetDocumentProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Properties, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentProperties>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Replace text with a new value. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSlideReplaceTextRequest" /></param> 
        /// <returns><see cref="SlideReplaceResult"/></returns>            
        public SlideReplaceResult PostSlidesSlideReplaceText(PostSlidesSlideReplaceTextRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideReplaceResult>(resourcePath, "POST", null, null, files, contentType);
        }

        /// <summary>
        /// Splitting presentations. Create one image per slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSplitRequest" /></param> 
        /// <returns><see cref="SplitDocumentResult"/></returns>            
        public SplitDocumentResult PostSlidesSplit(PostSlidesSplitRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SplitDocumentResult>(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Render shape to specified picture format (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSubshapeSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostSubshapeSaveAs(PostSubshapeSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSubshapeSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostSubshapeSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.ScaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.ScaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", request.Bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update a layoutSlide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutLayoutSlideRequest" /></param> 
        /// <returns><see cref="LayoutSlide"/></returns>            
        public LayoutSlide PutLayoutSlide(PutLayoutSlideRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.SlideDto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<LayoutSlide>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutNotesSlideShapeSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void PutNotesSlideShapeSaveAs(PutNotesSlideShapeSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutNotesSlideShapeSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutNotesSlideShapeSaveAs");
            }

            // verify the required parameter 'outPath' is set
            if (request.OutPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutNotesSlideShapeSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.ScaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.ScaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", request.Bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Merge the presentation with other presentations or some of their slides specified in the request parameter. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutPresentationMergeRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        public Document PutPresentationMerge(PutPresentationMergeRequest request)
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
            return InvokeApi<Document>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update portion properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSetParagraphPortionPropertiesRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion PutSetParagraphPortionProperties(PutSetParagraphPortionPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSetParagraphPortionProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portion>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update paragraph properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSetParagraphPropertiesRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph PutSetParagraphProperties(PutSetParagraphPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSetParagraphProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraph>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update portion properties (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSetSubshapeParagraphPortionPropertiesRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion PutSetSubshapeParagraphPortionProperties(PutSetSubshapeParagraphPortionPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSetSubshapeParagraphPortionProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portion>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update paragraph properties (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSetSubshapeParagraphPropertiesRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph PutSetSubshapeParagraphProperties(PutSetSubshapeParagraphPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSetSubshapeParagraphProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraph>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutShapeSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void PutShapeSaveAs(PutShapeSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutShapeSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutShapeSaveAs");
            }

            // verify the required parameter 'outPath' is set
            if (request.OutPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutShapeSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.ScaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.ScaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", request.Bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Set slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideAnimationRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation PutSlideAnimation(PutSlideAnimationRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideAnimation");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Animation, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Modify an animation effect for a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideAnimationEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation PutSlideAnimationEffect(PutSlideAnimationEffectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideAnimationEffect");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/mainSequence/{effectIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", request.EffectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Effect, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Modify an animation effect for a slide interactive sequence. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideAnimationInteractiveSequenceEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation PutSlideAnimationInteractiveSequenceEffect(PutSlideAnimationInteractiveSequenceEffectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideAnimationInteractiveSequenceEffect");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences/{sequenceIndex}/{effectIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", request.SequenceIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", request.EffectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Effect, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideAnimation>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void PutSlideSaveAs(PutSlideSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutSlideSaveAs");
            }

            // verify the required parameter 'outPath' is set
            if (request.OutPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutSlideSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", request.Width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", request.Height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideShapeInfoRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase PutSlideShapeInfo(PutSlideShapeInfoRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideShapeInfo");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeBase>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update shape properties (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideSubshapeInfoRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase PutSlideSubshapeInfo(PutSlideSubshapeInfoRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideSubshapeInfo");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeBase>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Convert presentation from request content to format specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesConvertRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void PutSlidesConvert(PutSlidesConvertRequest request)
        {
            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutSlidesConvert");
            }

            // verify the required parameter 'outPath' is set
            if (request.OutPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutSlidesConvert");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/convert/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType = "application/json";
            var postBody = request.Document;
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidStreamApi(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update presentation document from html. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesDocumentFromHtmlRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        public Document PutSlidesDocumentFromHtml(PutSlidesDocumentFromHtmlRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesDocumentFromHtml");
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
            return InvokeApi<Document>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Save a presentation to a specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void PutSlidesSaveAs(PutSlidesSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSaveAs");
            }

            // verify the required parameter 'outPath' is set
            if (request.OutPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutSlidesSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutSlidesSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Set document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSetDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentProperty"/></returns>            
        public DocumentProperty PutSlidesSetDocumentProperty(PutSlidesSetDocumentPropertyRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Property, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<DocumentProperty>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideRequest" /></param> 
        /// <returns><see cref="Slide"/></returns>            
        public Slide PutSlidesSlide(PutSlidesSlideRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.SlideDto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Slide>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Set background for a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideBackgroundRequest" /></param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        public SlideBackground PutSlidesSlideBackground(PutSlidesSlideBackgroundRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Background, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideBackground>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Set background color for a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideBackgroundColorRequest" /></param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        public SlideBackground PutSlidesSlideBackgroundColor(PutSlidesSlideBackgroundColorRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSlideBackgroundColor");
            }

            // verify the required parameter 'color' is set
            if (request.Color == null)
            {
                throw new ApiException(400, "Missing required parameter 'color' when calling PutSlidesSlideBackgroundColor");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/backgroundColor");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "color", request.Color);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<SlideBackground>(resourcePath, "PUT", null, null, files, contentType);
        }

        /// <summary>
        /// Set slide size for a presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideSizeRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        public Document PutSlidesSlideSize(PutSlidesSlideSizeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSlideSize");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slideSize");
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
            return InvokeApi<Document>(resourcePath, "PUT", null, null, files, contentType);
        }

        /// <summary>
        /// Update presentation document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesViewPropertiesRequest" /></param> 
        /// <returns><see cref="ViewProperties"/></returns>            
        public ViewProperties PutSlidesViewProperties(PutSlidesViewPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesViewProperties");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/viewProperties");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ViewProperties>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSubshapeSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        public void PutSubshapeSaveAs(PutSubshapeSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSubshapeSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutSubshapeSaveAs");
            }

            // verify the required parameter 'outPath' is set
            if (request.OutPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutSubshapeSaveAs");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", request.ScaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", request.ScaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", request.Bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", request.FontsFolder);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Options, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            InvokeVoidApi(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update notes slide properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        public NotesSlide PutUpdateNotesSlide(PutUpdateNotesSlideRequest request)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<NotesSlide>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase PutUpdateNotesSlideShape(PutUpdateNotesSlideShapeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlideShape");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ShapeBase>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update paragraph properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideShapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph PutUpdateNotesSlideShapeParagraph(PutUpdateNotesSlideShapeParagraphRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlideShapeParagraph");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Paragraph>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Update portion properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideShapePortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion PutUpdateNotesSlideShapePortion(PutUpdateNotesSlideShapePortionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlideShapePortion");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", request.ShapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", request.ParagraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", request.PortionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType;
            var postBody = SerializationHelper.Serialize(request.Dto, out contentType); // http body (model) parameter
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<Portion>(resourcePath, "PUT", postBody, null, files, contentType);
        }

        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param> 
        /// <returns><see cref="StorageExist"/></returns>            
        public StorageExist StorageExists(StorageExistsRequest request)
        {
            // verify the required parameter 'storageName' is set
            if (request.StorageName == null)
            {
                throw new ApiException(400, "Missing required parameter 'storageName' when calling StorageExists");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/{storageName}/exist");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", request.StorageName);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<StorageExist>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param> 
        /// <returns><see cref="FilesUploadResult"/></returns>            
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling UploadFile");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/{path}");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            if (request.File != null) 
            {
                AddFileParameter(files, request.File, "file");
            }
            return InvokeApi<FilesUploadResult>(resourcePath, "PUT", null, null, files, contentType);
        }
    }
}