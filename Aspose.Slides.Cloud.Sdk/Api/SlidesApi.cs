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
        /// The Client Id.
        /// </param>
        /// <param name="appKey">
        /// The Client Secret.
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
        /// <param name="srcPath">Source file path e.g. '/folder/file.ext'</param> 
        /// <param name="destPath">Destination file path</param> 
        /// <param name="srcStorageName">Source storage name</param> 
        /// <param name="destStorageName">Destination storage name</param> 
        /// <param name="versionId">File version ID to copy</param> 
        /// <returns><see cref=""/></returns>            
        public void CopyFile(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)
        {
            // verify the required parameter 'srcPath' is set
            if (srcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }
            // verify the required parameter 'destPath' is set
            if (destPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFile");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/copy/{srcPath}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", versionId);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use CopyFile method")]
        public void CopyFile(CopyFileRequest request)
        {
            CopyFile(request.SrcPath, request.DestPath, request.SrcStorageName, request.DestStorageName, request.VersionId);
        }

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="srcPath">Source folder path e.g. '/src'</param> 
        /// <param name="destPath">Destination folder path e.g. '/dst'</param> 
        /// <param name="srcStorageName">Source storage name</param> 
        /// <param name="destStorageName">Destination storage name</param> 
        /// <returns><see cref=""/></returns>            
        public void CopyFolder(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)
        {
            // verify the required parameter 'srcPath' is set
            if (srcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFolder");
            }
            // verify the required parameter 'destPath' is set
            if (destPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFolder");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/copy/{srcPath}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", destStorageName);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use CopyFolder method")]
        public void CopyFolder(CopyFolderRequest request)
        {
            CopyFolder(request.SrcPath, request.DestPath, request.SrcStorageName, request.DestStorageName);
        }

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="path">Folder path to create e.g. 'folder_1/folder_2/'</param> 
        /// <param name="storageName">Storage name</param> 
        /// <returns><see cref=""/></returns>            
        public void CreateFolder(string path, string storageName = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling CreateFolder");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", storageName);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use CreateFolder method")]
        public void CreateFolder(CreateFolderRequest request)
        {
            CreateFolder(request.Path, request.StorageName);
        }

        /// <summary>
        /// Delete a category from a chart. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="categoryIndex">Category index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart DeleteChartCategory(string name, int slideIndex, int shapeIndex, int categoryIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteChartCategory");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/categories/{categoryIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "categoryIndex", categoryIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete a category from a chart. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteChartCategoryRequest" /></param> 
        /// <returns><see cref="Chart"/></returns>            
        [System.Obsolete("Use DeleteChartCategory method")]
        public Chart DeleteChartCategory(DeleteChartCategoryRequest request)
        {
            return DeleteChartCategory(request.Name, request.SlideIndex, request.ShapeIndex, request.CategoryIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Delete a data point from a chart series. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="seriesIndex">Series index.</param> 
        /// <param name="pointIndex">Data point index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart DeleteChartDataPoint(string name, int slideIndex, int shapeIndex, int seriesIndex, int pointIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteChartDataPoint");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/series/{seriesIndex}/dataPoints/{pointIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "seriesIndex", seriesIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "pointIndex", pointIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete a data point from a chart series. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteChartDataPointRequest" /></param> 
        /// <returns><see cref="Chart"/></returns>            
        [System.Obsolete("Use DeleteChartDataPoint method")]
        public Chart DeleteChartDataPoint(DeleteChartDataPointRequest request)
        {
            return DeleteChartDataPoint(request.Name, request.SlideIndex, request.ShapeIndex, request.SeriesIndex, request.PointIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Delete a series from a chart. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index (must be a chart).</param> 
        /// <param name="seriesIndex">Series index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart DeleteChartSeries(string name, int slideIndex, int shapeIndex, int seriesIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteChartSeries");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/series/{seriesIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "seriesIndex", seriesIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete a series from a chart. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteChartSeriesRequest" /></param> 
        /// <returns><see cref="Chart"/></returns>            
        [System.Obsolete("Use DeleteChartSeries method")]
        public Chart DeleteChartSeries(DeleteChartSeriesRequest request)
        {
            return DeleteChartSeries(request.Name, request.SlideIndex, request.ShapeIndex, request.SeriesIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="path">File path e.g. '/folder/file.ext'</param> 
        /// <param name="storageName">Storage name</param> 
        /// <param name="versionId">File version ID to delete</param> 
        /// <returns><see cref=""/></returns>            
        public void DeleteFile(string path, string storageName = null, string versionId = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFile");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", versionId);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "DELETE", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use DeleteFile method")]
        public void DeleteFile(DeleteFileRequest request)
        {
            DeleteFile(request.Path, request.StorageName, request.VersionId);
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="path">Folder path e.g. '/folder'</param> 
        /// <param name="storageName">Storage name</param> 
        /// <param name="recursive">Enable to delete folders, subfolders and files</param> 
        /// <returns><see cref=""/></returns>            
        public void DeleteFolder(string path, string storageName = null, bool? recursive = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFolder");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", recursive);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "DELETE", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use DeleteFolder method")]
        public void DeleteFolder(DeleteFolderRequest request)
        {
            DeleteFolder(request.Path, request.StorageName, request.Recursive);
        }

        /// <summary>
        /// Remove notes slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Slide"/></returns>            
        public Slide DeleteNotesSlide(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Slide>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove notes slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideRequest" /></param> 
        /// <returns><see cref="Slide"/></returns>            
        [System.Obsolete("Use DeleteNotesSlide method")]
        public Slide DeleteNotesSlide(DeleteNotesSlideRequest request)
        {
            return DeleteNotesSlide(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteNotesSlideParagraph(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideParagraphRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        [System.Obsolete("Use DeleteNotesSlideParagraph method")]
        public Paragraphs DeleteNotesSlideParagraph(DeleteNotesSlideParagraphRequest request)
        {
            return DeleteNotesSlideParagraph(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a range of paragraphs. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphs">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteNotesSlideParagraphs(string name, int slideIndex, int shapeIndex, List<int> paragraphs = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphs", paragraphs);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of paragraphs. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        [System.Obsolete("Use DeleteNotesSlideParagraphs method")]
        public Paragraphs DeleteNotesSlideParagraphs(DeleteNotesSlideParagraphsRequest request)
        {
            return DeleteNotesSlideParagraphs(request.Name, request.SlideIndex, request.ShapeIndex, request.Paragraphs, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteNotesSlidePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlidePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a portion. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlidePortionRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        [System.Obsolete("Use DeleteNotesSlidePortion method")]
        public Portions DeleteNotesSlidePortion(DeleteNotesSlidePortionRequest request)
        {
            return DeleteNotesSlidePortion(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.PortionIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a range of portions. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portions">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteNotesSlidePortions(string name, int slideIndex, int shapeIndex, int paragraphIndex, List<int> portions = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlidePortions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "portions", portions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of portions. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlidePortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        [System.Obsolete("Use DeleteNotesSlidePortions method")]
        public Portions DeleteNotesSlidePortions(DeleteNotesSlidePortionsRequest request)
        {
            return DeleteNotesSlidePortions(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Portions, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a shape. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteNotesSlideShape(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideShapeRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use DeleteNotesSlideShape method")]
        public Shapes DeleteNotesSlideShape(DeleteNotesSlideShapeRequest request)
        {
            return DeleteNotesSlideShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a range of shapes. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapes">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteNotesSlideShapes(string name, int slideIndex, List<int> shapes = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteNotesSlideShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteNotesSlideShapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use DeleteNotesSlideShapes method")]
        public Shapes DeleteNotesSlideShapes(DeleteNotesSlideShapesRequest request)
        {
            return DeleteNotesSlideShapes(request.Name, request.SlideIndex, request.Shapes, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteParagraph(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        [System.Obsolete("Use DeleteParagraph method")]
        public Paragraphs DeleteParagraph(DeleteParagraphRequest request)
        {
            return DeleteParagraph(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a range of paragraphs. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphs">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteParagraphs(string name, int slideIndex, int shapeIndex, List<int> paragraphs = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphs", paragraphs);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of paragraphs. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        [System.Obsolete("Use DeleteParagraphs method")]
        public Paragraphs DeleteParagraphs(DeleteParagraphsRequest request)
        {
            return DeleteParagraphs(request.Name, request.SlideIndex, request.ShapeIndex, request.Paragraphs, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeletePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeletePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a portion. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeletePortionRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        [System.Obsolete("Use DeletePortion method")]
        public Portions DeletePortion(DeletePortionRequest request)
        {
            return DeletePortion(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.PortionIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a range of portions. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portions">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeletePortions(string name, int slideIndex, int shapeIndex, int paragraphIndex, List<int> portions = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeletePortions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "portions", portions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of portions. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeletePortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        [System.Obsolete("Use DeletePortions method")]
        public Portions DeletePortions(DeletePortionsRequest request)
        {
            return DeletePortions(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Portions, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Delete a presentation section. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="sectionIndex">Section index.</param> 
        /// <param name="withSlides">True to delete the slides related to the deleted section; move them to the remaining sections otherwise.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Sections"/></returns>            
        public Sections DeleteSection(string name, int sectionIndex, bool? withSlides = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSection");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/sections/{sectionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionIndex", sectionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withSlides", withSlides);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Sections>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete a presentation section. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionRequest" /></param> 
        /// <returns><see cref="Sections"/></returns>            
        [System.Obsolete("Use DeleteSection method")]
        public Sections DeleteSection(DeleteSectionRequest request)
        {
            return DeleteSection(request.Name, request.SectionIndex, request.WithSlides, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Delete presentation sections. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="sections">The indices of the sections to be deleted; delete all by default.</param> 
        /// <param name="withSlides">True to delete the slides related to the deleted sections; move them to the remaining sections otherwise.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Sections"/></returns>            
        public Sections DeleteSections(string name, List<int> sections = null, bool? withSlides = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSections");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/sections");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sections", sections);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withSlides", withSlides);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Sections>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete presentation sections. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSectionsRequest" /></param> 
        /// <returns><see cref="Sections"/></returns>            
        [System.Obsolete("Use DeleteSections method")]
        public Sections DeleteSections(DeleteSectionsRequest request)
        {
            return DeleteSections(request.Name, request.Sections, request.WithSlides, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove animation from a slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteAnimation(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove animation from a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use DeleteAnimation method")]
        public SlideAnimation DeleteSlideAnimation(DeleteSlideAnimationRequest request)
        {
            return DeleteAnimation(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove an effect from slide animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="effectIndex">Index of the effect to be removed.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteAnimationEffect(string name, int slideIndex, int effectIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/mainSequence/{effectIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", effectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove an effect from slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use DeleteAnimationEffect method")]
        public SlideAnimation DeleteSlideAnimationEffect(DeleteSlideAnimationEffectRequest request)
        {
            return DeleteAnimationEffect(request.Name, request.SlideIndex, request.EffectIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove an interactive sequence from slide animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="sequenceIndex">The index of an interactive sequence to be deleted.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteAnimationInteractiveSequence(string name, int slideIndex, int sequenceIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationInteractiveSequence");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences/{sequenceIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", sequenceIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove an interactive sequence from slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationInteractiveSequenceRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use DeleteAnimationInteractiveSequence method")]
        public SlideAnimation DeleteSlideAnimationInteractiveSequence(DeleteSlideAnimationInteractiveSequenceRequest request)
        {
            return DeleteAnimationInteractiveSequence(request.Name, request.SlideIndex, request.SequenceIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove an effect from slide animation interactive sequence. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="sequenceIndex">Interactive sequence index.</param> 
        /// <param name="effectIndex">Index of the effect to be removed.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteAnimationInteractiveSequenceEffect(string name, int slideIndex, int sequenceIndex, int effectIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationInteractiveSequenceEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences/{sequenceIndex}/{effectIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", sequenceIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", effectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove an effect from slide animation interactive sequence. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationInteractiveSequenceEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use DeleteAnimationInteractiveSequenceEffect method")]
        public SlideAnimation DeleteSlideAnimationInteractiveSequenceEffect(DeleteSlideAnimationInteractiveSequenceEffectRequest request)
        {
            return DeleteAnimationInteractiveSequenceEffect(request.Name, request.SlideIndex, request.SequenceIndex, request.EffectIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Clear all interactive sequences from slide animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteAnimationInteractiveSequences(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationInteractiveSequences");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Clear all interactive sequences from slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationInteractiveSequencesRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use DeleteAnimationInteractiveSequences method")]
        public SlideAnimation DeleteSlideAnimationInteractiveSequences(DeleteSlideAnimationInteractiveSequencesRequest request)
        {
            return DeleteAnimationInteractiveSequences(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Clear main sequence in slide animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteAnimationMainSequence(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideAnimationMainSequence");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/mainSequence");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Clear main sequence in slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideAnimationMainSequenceRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use DeleteAnimationMainSequence method")]
        public SlideAnimation DeleteSlideAnimationMainSequence(DeleteSlideAnimationMainSequenceRequest request)
        {
            return DeleteAnimationMainSequence(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Delete a presentation slide by index. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides DeleteSlide(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideByIndex");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Model.Slides>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete a presentation slide by index. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideByIndexRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        [System.Obsolete("Use DeleteSlide method")]
        public Model.Slides DeleteSlideByIndex(DeleteSlideByIndexRequest request)
        {
            return DeleteSlide(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a shape. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteShape(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideShapeRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use DeleteShape method")]
        public Shapes DeleteSlideShape(DeleteSlideShapeRequest request)
        {
            return DeleteShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a range of shapes. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapes">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteShapes(string name, int slideIndex, List<int> shapes = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of shapes. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideShapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use DeleteShapes method")]
        public Shapes DeleteSlideShapes(DeleteSlideShapesRequest request)
        {
            return DeleteShapes(request.Name, request.SlideIndex, request.Shapes, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a shape (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteSubshape(string name, int slideIndex, string path, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideSubshape");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteSlideSubshape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a shape (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideSubshapeRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use DeleteSubshape method")]
        public Shapes DeleteSlideSubshape(DeleteSlideSubshapeRequest request)
        {
            return DeleteSubshape(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a range of shapes (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapes">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteSubshapes(string name, int slideIndex, string path, List<int> shapes = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideSubshapes");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteSlideSubshapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of shapes (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlideSubshapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use DeleteSubshapes method")]
        public Shapes DeleteSlideSubshapes(DeleteSlideSubshapesRequest request)
        {
            return DeleteSubshapes(request.Name, request.SlideIndex, request.Path, request.Shapes, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Delete presentation slides. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slides">The indices of the slides to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides DeleteSlides(string name, List<int> slides = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesCleanSlidesList");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", slides);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Model.Slides>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete presentation slides. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesCleanSlidesListRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        [System.Obsolete("Use DeleteSlides method")]
        public Model.Slides DeleteSlidesCleanSlidesList(DeleteSlidesCleanSlidesListRequest request)
        {
            return DeleteSlides(request.Name, request.Slides, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Clean document properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        public DocumentProperties DeleteDocumentProperties(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesDocumentProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<DocumentProperties>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Clean document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        [System.Obsolete("Use DeleteDocumentProperties method")]
        public DocumentProperties DeleteSlidesDocumentProperties(DeleteSlidesDocumentPropertiesRequest request)
        {
            return DeleteDocumentProperties(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Delete document property. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="propertyName">The property name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        public DocumentProperties DeleteDocumentProperty(string name, string propertyName, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesDocumentProperty");
            }
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling DeleteSlidesDocumentProperty");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties/{propertyName}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", propertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<DocumentProperties>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        [System.Obsolete("Use DeleteDocumentProperty method")]
        public DocumentProperties DeleteSlidesDocumentProperty(DeleteSlidesDocumentPropertyRequest request)
        {
            return DeleteDocumentProperty(request.Name, request.PropertyName, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Resets all presentation protection settings.  
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Presentation password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ProtectionProperties"/></returns>            
        public ProtectionProperties DeleteProtection(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesProtectionProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/protection");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ProtectionProperties>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Resets all presentation protection settings.  
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesProtectionPropertiesRequest" /></param> 
        /// <returns><see cref="ProtectionProperties"/></returns>            
        [System.Obsolete("Use DeleteProtection method")]
        public ProtectionProperties DeleteSlidesProtectionProperties(DeleteSlidesProtectionPropertiesRequest request)
        {
            return DeleteProtection(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Resets all presentation protection settings.  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="password">Presentation password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteProtectionOnline(System.IO.Stream document, string password)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DeleteSlidesProtectionPropertiesOnline");
            }
            // verify the required parameter 'password' is set
            if (password == null)
            {
                throw new ApiException(400, "Missing required parameter 'password' when calling DeleteSlidesProtectionPropertiesOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/protection/delete");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Resets all presentation protection settings.  
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesProtectionPropertiesOnlineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DeleteProtectionOnline method")]
        public System.IO.Stream DeleteSlidesProtectionPropertiesOnline(DeleteSlidesProtectionPropertiesOnlineRequest request)
        {
            return DeleteProtectionOnline(request.Document, request.Password);
        }

        /// <summary>
        /// Remove background from a slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        public SlideBackground DeleteBackground(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlidesSlideBackground");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/background");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideBackground>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove background from a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSlidesSlideBackgroundRequest" /></param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        [System.Obsolete("Use DeleteBackground method")]
        public SlideBackground DeleteSlidesSlideBackground(DeleteSlidesSlideBackgroundRequest request)
        {
            return DeleteBackground(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a paragraph (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteSubshapeParagraph(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSubshapeParagraph");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteSubshapeParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a paragraph (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSubshapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        [System.Obsolete("Use DeleteSubshapeParagraph method")]
        public Paragraphs DeleteSubshapeParagraph(DeleteSubshapeParagraphRequest request)
        {
            return DeleteSubshapeParagraph(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.ParagraphIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a range of paragraphs (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphs">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteSubshapeParagraphs(string name, int slideIndex, string path, int shapeIndex, List<int> paragraphs = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSubshapeParagraphs");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteSubshapeParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphs", paragraphs);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of paragraphs (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSubshapeParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        [System.Obsolete("Use DeleteSubshapeParagraphs method")]
        public Paragraphs DeleteSubshapeParagraphs(DeleteSubshapeParagraphsRequest request)
        {
            return DeleteSubshapeParagraphs(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.Paragraphs, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a portion (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteSubshapePortion(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSubshapePortion");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteSubshapePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a portion (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSubshapePortionRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        [System.Obsolete("Use DeleteSubshapePortion method")]
        public Portions DeleteSubshapePortion(DeleteSubshapePortionRequest request)
        {
            return DeleteSubshapePortion(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.ParagraphIndex, request.PortionIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Remove a range of portions (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portions">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteSubshapePortions(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, List<int> portions = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSubshapePortions");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteSubshapePortions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "portions", portions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of portions (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteSubshapePortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        [System.Obsolete("Use DeleteSubshapePortions method")]
        public Portions DeleteSubshapePortions(DeleteSubshapePortionsRequest request)
        {
            return DeleteSubshapePortions(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.ParagraphIndex, request.Portions, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Removes shapes with name \&quot;watermark\&quot; from the presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="shapeName">Name of the watermark shape. If null, default value \"watermark\"is used.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref=""/></returns>            
        public void DeleteWatermark(string name, string shapeName = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteWatermark");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/watermark/delete");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeName", shapeName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Removes shapes with name \&quot;watermark\&quot; from the presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWatermarkRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use DeleteWatermark method")]
        public void DeleteWatermark(DeleteWatermarkRequest request)
        {
            DeleteWatermark(request.Name, request.ShapeName, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="path">File path e.g. '/folder/file.ext'</param> 
        /// <param name="storageName">Storage name</param> 
        /// <param name="versionId">File version ID to download</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadFile(string path, string storageName = null, string versionId = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DownloadFile");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", versionId);
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "GET", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadFile method")]
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
            return DownloadFile(request.Path, request.StorageName, request.VersionId);
        }

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="storageName">Storage name</param> 
        /// <returns><see cref="DiscUsage"/></returns>            
        public DiscUsage GetDiscUsage(string storageName = null)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/disc");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", storageName);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<DiscUsage>(resourcePath, "GET", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param> 
        /// <returns><see cref="DiscUsage"/></returns>            
        [System.Obsolete("Use GetDiscUsage method")]
        public DiscUsage GetDiscUsage(GetDiscUsageRequest request)
        {
            return GetDiscUsage(request.StorageName);
        }

        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <param name="path">File path e.g. '/file.ext'</param> 
        /// <param name="storageName">Storage name</param> 
        /// <returns><see cref="FileVersions"/></returns>            
        public FileVersions GetFileVersions(string path, string storageName = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFileVersions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/version/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", storageName);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<FileVersions>(resourcePath, "GET", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param> 
        /// <returns><see cref="FileVersions"/></returns>            
        [System.Obsolete("Use GetFileVersions method")]
        public FileVersions GetFileVersions(GetFileVersionsRequest request)
        {
            return GetFileVersions(request.Path, request.StorageName);
        }

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="path">Folder path e.g. '/folder'</param> 
        /// <param name="storageName">Storage name</param> 
        /// <returns><see cref="FilesList"/></returns>            
        public FilesList GetFilesList(string path, string storageName = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFilesList");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", storageName);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<FilesList>(resourcePath, "GET", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param> 
        /// <returns><see cref="FilesList"/></returns>            
        [System.Obsolete("Use GetFilesList method")]
        public FilesList GetFilesList(GetFilesListRequest request)
        {
            return GetFilesList(request.Path, request.StorageName);
        }

        /// <summary>
        /// Read presentation layoutSlide info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="LayoutSlide"/></returns>            
        public LayoutSlide GetLayoutSlide(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetLayoutSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides/{slideIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<LayoutSlide>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation layoutSlide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetLayoutSlideRequest" /></param> 
        /// <returns><see cref="LayoutSlide"/></returns>            
        [System.Obsolete("Use GetLayoutSlide method")]
        public LayoutSlide GetLayoutSlide(GetLayoutSlideRequest request)
        {
            return GetLayoutSlide(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation layoutSlides info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="LayoutSlides"/></returns>            
        public LayoutSlides GetLayoutSlides(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetLayoutSlidesList");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<LayoutSlides>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation layoutSlides info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetLayoutSlidesListRequest" /></param> 
        /// <returns><see cref="LayoutSlides"/></returns>            
        [System.Obsolete("Use GetLayoutSlides method")]
        public LayoutSlides GetLayoutSlidesList(GetLayoutSlidesListRequest request)
        {
            return GetLayoutSlides(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation masterSlide info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="MasterSlide"/></returns>            
        public MasterSlide GetMasterSlide(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetMasterSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/masterSlides/{slideIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<MasterSlide>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation masterSlide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMasterSlideRequest" /></param> 
        /// <returns><see cref="MasterSlide"/></returns>            
        [System.Obsolete("Use GetMasterSlide method")]
        public MasterSlide GetMasterSlide(GetMasterSlideRequest request)
        {
            return GetMasterSlide(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation masterSlides info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="MasterSlides"/></returns>            
        public MasterSlides GetMasterSlides(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetMasterSlidesList");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/masterSlides");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<MasterSlides>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation masterSlides info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetMasterSlidesListRequest" /></param> 
        /// <returns><see cref="MasterSlides"/></returns>            
        [System.Obsolete("Use GetMasterSlides method")]
        public MasterSlides GetMasterSlidesList(GetMasterSlidesListRequest request)
        {
            return GetMasterSlides(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read notes slide info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        public NotesSlide GetNotesSlide(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<NotesSlide>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read notes slide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        [System.Obsolete("Use GetNotesSlide method")]
        public NotesSlide GetNotesSlide(GetNotesSlideRequest request)
        {
            return GetNotesSlide(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Get info whether a notes slide exists. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="EntityExists"/></returns>            
        public EntityExists NotesSlideExists(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideExists");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/exist");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<EntityExists>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get info whether a notes slide exists. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideExistsRequest" /></param> 
        /// <returns><see cref="EntityExists"/></returns>            
        [System.Obsolete("Use NotesSlideExists method")]
        public EntityExists GetNotesSlideExists(GetNotesSlideExistsRequest request)
        {
            return NotesSlideExists(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Get header/footer info for the notes slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="NotesSlideHeaderFooter"/></returns>            
        public NotesSlideHeaderFooter GetNotesSlideHeaderFooter(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideHeaderFooter");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/headerFooter");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<NotesSlideHeaderFooter>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get header/footer info for the notes slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideHeaderFooterRequest" /></param> 
        /// <returns><see cref="NotesSlideHeaderFooter"/></returns>            
        [System.Obsolete("Use GetNotesSlideHeaderFooter method")]
        public NotesSlideHeaderFooter GetNotesSlideHeaderFooter(GetNotesSlideHeaderFooterRequest request)
        {
            return GetNotesSlideHeaderFooter(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide shape info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase GetNotesSlideShape(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        [System.Obsolete("Use GetNotesSlideShape method")]
        public ShapeBase GetNotesSlideShape(GetNotesSlideShapeRequest request)
        {
            return GetNotesSlideShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read shape paragraph info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetNotesSlideParagraph(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapeParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read shape paragraph info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        [System.Obsolete("Use GetNotesSlideParagraph method")]
        public Paragraph GetNotesSlideShapeParagraph(GetNotesSlideShapeParagraphRequest request)
        {
            return GetNotesSlideParagraph(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read shape paragraphs info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs GetNotesSlideParagraphs(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapeParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read shape paragraphs info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapeParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        [System.Obsolete("Use GetNotesSlideParagraphs method")]
        public Paragraphs GetNotesSlideShapeParagraphs(GetNotesSlideShapeParagraphsRequest request)
        {
            return GetNotesSlideParagraphs(request.Name, request.SlideIndex, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read paragraph portion info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetNotesSlidePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read paragraph portion info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapePortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        [System.Obsolete("Use GetNotesSlidePortion method")]
        public Portion GetNotesSlideShapePortion(GetNotesSlideShapePortionRequest request)
        {
            return GetNotesSlidePortion(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.PortionIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read paragraph portions info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions GetNotesSlidePortions(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapePortions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read paragraph portions info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapePortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        [System.Obsolete("Use GetNotesSlidePortions method")]
        public Portions GetNotesSlideShapePortions(GetNotesSlideShapePortionsRequest request)
        {
            return GetNotesSlidePortions(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes GetNotesSlideShapes(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideShapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use GetNotesSlideShapes method")]
        public Shapes GetNotesSlideShapes(GetNotesSlideShapesRequest request)
        {
            return GetNotesSlideShapes(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Convert notes slide to the specified image format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="width">Output file width.</param> 
        /// <param name="height">Output file height.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadNotesSlide(string name, int slideIndex, NotesSlideExportFormat format, int? width = null, int? height = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetNotesSlideWithFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Convert notes slide to the specified image format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetNotesSlideWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadNotesSlide method")]
        public System.IO.Stream GetNotesSlideWithFormat(GetNotesSlideWithFormatRequest request)
        {
            return DownloadNotesSlide(request.Name, request.SlideIndex, request.Format, request.Width, request.Height, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Read paragraph portion info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetPortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphPortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read paragraph portion info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphPortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        [System.Obsolete("Use GetPortion method")]
        public Portion GetParagraphPortion(GetParagraphPortionRequest request)
        {
            return GetPortion(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.PortionIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read paragraph portions info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions GetPortions(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphPortions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read paragraph portions info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetParagraphPortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        [System.Obsolete("Use GetPortions method")]
        public Portions GetParagraphPortions(GetParagraphPortionsRequest request)
        {
            return GetPortions(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation sections info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Sections"/></returns>            
        public Sections GetSections(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSections");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/sections");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Sections>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation sections info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSectionsRequest" /></param> 
        /// <returns><see cref="Sections"/></returns>            
        [System.Obsolete("Use GetSections method")]
        public Sections GetSections(GetSectionsRequest request)
        {
            return GetSections(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide animation effects. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index. If specified, only effects related to that shape are returned.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation GetAnimation(string name, int slideIndex, int? shapeIndex = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideAnimation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide animation effects. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideAnimationRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use GetAnimation method")]
        public SlideAnimation GetSlideAnimation(GetSlideAnimationRequest request)
        {
            return GetAnimation(request.Name, request.SlideIndex, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Get footer info for the slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">The position of the slide to be reordered.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="HeaderFooter"/></returns>            
        public HeaderFooter GetSlideHeaderFooter(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideHeaderFooter");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/headerFooter");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<HeaderFooter>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get footer info for the slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideHeaderFooterRequest" /></param> 
        /// <returns><see cref="HeaderFooter"/></returns>            
        [System.Obsolete("Use GetSlideHeaderFooter method")]
        public HeaderFooter GetSlideHeaderFooter(GetSlideHeaderFooterRequest request)
        {
            return GetSlideHeaderFooter(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide shape info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase GetShape(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide shape info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        [System.Obsolete("Use GetShape method")]
        public ShapeBase GetSlideShape(GetSlideShapeRequest request)
        {
            return GetShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read shape paragraph info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetParagraph(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideShapeParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read shape paragraph info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideShapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        [System.Obsolete("Use GetParagraph method")]
        public Paragraph GetSlideShapeParagraph(GetSlideShapeParagraphRequest request)
        {
            return GetParagraph(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read shape paragraphs info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs GetParagraphs(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideShapeParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read shape paragraphs info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideShapeParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        [System.Obsolete("Use GetParagraphs method")]
        public Paragraphs GetSlideShapeParagraphs(GetSlideShapeParagraphsRequest request)
        {
            return GetParagraphs(request.Name, request.SlideIndex, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes GetShapes(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideShapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use GetShapes method")]
        public Shapes GetSlideShapes(GetSlideShapesRequest request)
        {
            return GetShapes(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide shape info (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase GetSubshape(string name, int slideIndex, string path, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideSubshape");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetSlideSubshape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide shape info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideSubshapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        [System.Obsolete("Use GetSubshape method")]
        public ShapeBase GetSlideSubshape(GetSlideSubshapeRequest request)
        {
            return GetSubshape(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read shape paragraph info (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetSubshapeParagraph(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideSubshapeParagraph");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetSlideSubshapeParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read shape paragraph info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideSubshapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        [System.Obsolete("Use GetSubshapeParagraph method")]
        public Paragraph GetSlideSubshapeParagraph(GetSlideSubshapeParagraphRequest request)
        {
            return GetSubshapeParagraph(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.ParagraphIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read shape paragraphs info (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs GetSubshapeParagraphs(string name, int slideIndex, string path, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideSubshapeParagraphs");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetSlideSubshapeParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read shape paragraphs info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideSubshapeParagraphsRequest" /></param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        [System.Obsolete("Use GetSubshapeParagraphs method")]
        public Paragraphs GetSlideSubshapeParagraphs(GetSlideSubshapeParagraphsRequest request)
        {
            return GetSubshapeParagraphs(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path (for smart art and group shapes).</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes GetSubshapes(string name, int slideIndex, string path, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideSubshapes");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetSlideSubshapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlideSubshapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use GetSubshapes method")]
        public Shapes GetSlideSubshapes(GetSlideSubshapesRequest request)
        {
            return GetSubshapes(request.Name, request.SlideIndex, request.Path, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Get API info. 
        /// </summary>
        /// <returns><see cref="ApiInfo"/></returns>            
        public ApiInfo GetApiInfo()
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/info");
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ApiInfo>(resourcePath, "GET", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Get API info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesApiInfoRequest" /></param> 
        /// <returns><see cref="ApiInfo"/></returns>            
        [System.Obsolete("Use GetApiInfo method")]
        public ApiInfo GetSlidesApiInfo()
        {
            return GetApiInfo();
        }

        /// <summary>
        /// Read presentation info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document GetPresentation(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesDocument");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Document>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        [System.Obsolete("Use GetPresentation method")]
        public Document GetSlidesDocument(GetSlidesDocumentRequest request)
        {
            return GetPresentation(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation document properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        public DocumentProperties GetDocumentProperties(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesDocumentProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<DocumentProperties>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        [System.Obsolete("Use GetDocumentProperties method")]
        public DocumentProperties GetSlidesDocumentProperties(GetSlidesDocumentPropertiesRequest request)
        {
            return GetDocumentProperties(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation document property. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="propertyName">The property name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="DocumentProperty"/></returns>            
        public DocumentProperty GetDocumentProperty(string name, string propertyName, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesDocumentProperty");
            }
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling GetSlidesDocumentProperty");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties/{propertyName}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", propertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<DocumentProperty>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentProperty"/></returns>            
        [System.Obsolete("Use GetDocumentProperty method")]
        public DocumentProperty GetSlidesDocumentProperty(GetSlidesDocumentPropertyRequest request)
        {
            return GetDocumentProperty(request.Name, request.PropertyName, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Get image binary data. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="index">Image index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImageDefaultFormat(string name, int index, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesImageWithDefaultFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/images/{index}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get image binary data. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesImageWithDefaultFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadImageDefaultFormat method")]
        public System.IO.Stream GetSlidesImageWithDefaultFormat(GetSlidesImageWithDefaultFormatRequest request)
        {
            return DownloadImageDefaultFormat(request.Name, request.Index, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Get image in specified format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="index">Image index.</param> 
        /// <param name="format">Export format (png, jpg, gif).</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImage(string name, int index, ImageExportFormat format, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesImageWithFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/images/{index}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", index);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get image in specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesImageWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadImage method")]
        public System.IO.Stream GetSlidesImageWithFormat(GetSlidesImageWithFormatRequest request)
        {
            return DownloadImage(request.Name, request.Index, request.Format, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation images info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Images"/></returns>            
        public Images GetPresentationImages(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesImages");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/images");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Images>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation images info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesImagesRequest" /></param> 
        /// <returns><see cref="Images"/></returns>            
        [System.Obsolete("Use GetPresentationImages method")]
        public Images GetSlidesImages(GetSlidesImagesRequest request)
        {
            return GetPresentationImages(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide placeholder info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="placeholderIndex">Placeholder index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Placeholder"/></returns>            
        public Placeholder GetPlaceholder(string name, int slideIndex, int placeholderIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesPlaceholder");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/placeholders/{placeholderIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "placeholderIndex", placeholderIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Placeholder>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide placeholder info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesPlaceholderRequest" /></param> 
        /// <returns><see cref="Placeholder"/></returns>            
        [System.Obsolete("Use GetPlaceholder method")]
        public Placeholder GetSlidesPlaceholder(GetSlidesPlaceholderRequest request)
        {
            return GetPlaceholder(request.Name, request.SlideIndex, request.PlaceholderIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide placeholders info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Placeholders"/></returns>            
        public Placeholders GetPlaceholders(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesPlaceholders");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/placeholders");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Placeholders>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide placeholders info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesPlaceholdersRequest" /></param> 
        /// <returns><see cref="Placeholders"/></returns>            
        [System.Obsolete("Use GetPlaceholders method")]
        public Placeholders GetSlidesPlaceholders(GetSlidesPlaceholdersRequest request)
        {
            return GetPlaceholders(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Extract presentation text items. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="withEmpty">True to incude empty items.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="TextItems"/></returns>            
        public TextItems GetPresentationTextItems(string name, bool? withEmpty = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesPresentationTextItems");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/textItems");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withEmpty", withEmpty);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<TextItems>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Extract presentation text items. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesPresentationTextItemsRequest" /></param> 
        /// <returns><see cref="TextItems"/></returns>            
        [System.Obsolete("Use GetPresentationTextItems method")]
        public TextItems GetSlidesPresentationTextItems(GetSlidesPresentationTextItemsRequest request)
        {
            return GetPresentationTextItems(request.Name, request.WithEmpty, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation protection properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ProtectionProperties"/></returns>            
        public ProtectionProperties GetProtectionProperties(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesProtectionProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/protection");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ProtectionProperties>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation protection properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesProtectionPropertiesRequest" /></param> 
        /// <returns><see cref="ProtectionProperties"/></returns>            
        [System.Obsolete("Use GetProtectionProperties method")]
        public ProtectionProperties GetSlidesProtectionProperties(GetSlidesProtectionPropertiesRequest request)
        {
            return GetProtectionProperties(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation slide info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Slide"/></returns>            
        public Slide GetSlide(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Slide>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation slide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideRequest" /></param> 
        /// <returns><see cref="Slide"/></returns>            
        [System.Obsolete("Use GetSlide method")]
        public Slide GetSlidesSlide(GetSlidesSlideRequest request)
        {
            return GetSlide(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide background info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        public SlideBackground GetBackground(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideBackground");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/background");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideBackground>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide background info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideBackgroundRequest" /></param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        [System.Obsolete("Use GetBackground method")]
        public SlideBackground GetSlidesSlideBackground(GetSlidesSlideBackgroundRequest request)
        {
            return GetBackground(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation slide comments. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">The position of the slide to be reordered.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideComments"/></returns>            
        public SlideComments GetComments(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideComments");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/comments");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideComments>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation slide comments. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideCommentsRequest" /></param> 
        /// <returns><see cref="SlideComments"/></returns>            
        [System.Obsolete("Use GetComments method")]
        public SlideComments GetSlidesSlideComments(GetSlidesSlideCommentsRequest request)
        {
            return GetComments(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide images info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Images"/></returns>            
        public Images GetSlideImages(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideImages");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/images");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Images>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide images info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideImagesRequest" /></param> 
        /// <returns><see cref="Images"/></returns>            
        [System.Obsolete("Use GetSlideImages method")]
        public Images GetSlidesSlideImages(GetSlidesSlideImagesRequest request)
        {
            return GetSlideImages(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation slide properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideProperties"/></returns>            
        public SlideProperties GetSlideProperties(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slideProperties");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideProperties>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation slide properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlidePropertiesRequest" /></param> 
        /// <returns><see cref="SlideProperties"/></returns>            
        [System.Obsolete("Use GetSlideProperties method")]
        public SlideProperties GetSlidesSlideProperties(GetSlidesSlidePropertiesRequest request)
        {
            return GetSlideProperties(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Extract slide text items. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="withEmpty">True to include empty items.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="TextItems"/></returns>            
        public TextItems GetSlideTextItems(string name, int slideIndex, bool? withEmpty = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlideTextItems");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/textItems");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withEmpty", withEmpty);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<TextItems>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Extract slide text items. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlideTextItemsRequest" /></param> 
        /// <returns><see cref="TextItems"/></returns>            
        [System.Obsolete("Use GetSlideTextItems method")]
        public TextItems GetSlidesSlideTextItems(GetSlidesSlideTextItemsRequest request)
        {
            return GetSlideTextItems(request.Name, request.SlideIndex, request.WithEmpty, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation slides info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides GetSlides(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesSlidesList");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Model.Slides>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation slides info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesSlidesListRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        [System.Obsolete("Use GetSlides method")]
        public Model.Slides GetSlidesSlidesList(GetSlidesSlidesListRequest request)
        {
            return GetSlides(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide theme info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Theme"/></returns>            
        public Theme GetTheme(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesTheme");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Theme>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide theme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeRequest" /></param> 
        /// <returns><see cref="Theme"/></returns>            
        [System.Obsolete("Use GetTheme method")]
        public Theme GetSlidesTheme(GetSlidesThemeRequest request)
        {
            return GetTheme(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide theme color scheme info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ColorScheme"/></returns>            
        public ColorScheme GetColorScheme(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesThemeColorScheme");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme/colorScheme");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ColorScheme>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide theme color scheme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeColorSchemeRequest" /></param> 
        /// <returns><see cref="ColorScheme"/></returns>            
        [System.Obsolete("Use GetColorScheme method")]
        public ColorScheme GetSlidesThemeColorScheme(GetSlidesThemeColorSchemeRequest request)
        {
            return GetColorScheme(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide theme font scheme info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="FontScheme"/></returns>            
        public FontScheme GetFontScheme(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesThemeFontScheme");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme/fontScheme");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<FontScheme>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide theme font scheme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeFontSchemeRequest" /></param> 
        /// <returns><see cref="FontScheme"/></returns>            
        [System.Obsolete("Use GetFontScheme method")]
        public FontScheme GetSlidesThemeFontScheme(GetSlidesThemeFontSchemeRequest request)
        {
            return GetFontScheme(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read slide theme format scheme info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="FormatScheme"/></returns>            
        public FormatScheme GetFormatScheme(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesThemeFormatScheme");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme/formatScheme");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<FormatScheme>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide theme format scheme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeFormatSchemeRequest" /></param> 
        /// <returns><see cref="FormatScheme"/></returns>            
        [System.Obsolete("Use GetFormatScheme method")]
        public FormatScheme GetSlidesThemeFormatScheme(GetSlidesThemeFormatSchemeRequest request)
        {
            return GetFormatScheme(request.Name, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read presentation document properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ViewProperties"/></returns>            
        public ViewProperties GetViewProperties(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesViewProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/viewProperties");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ViewProperties>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesViewPropertiesRequest" /></param> 
        /// <returns><see cref="ViewProperties"/></returns>            
        [System.Obsolete("Use GetViewProperties method")]
        public ViewProperties GetSlidesViewProperties(GetSlidesViewPropertiesRequest request)
        {
            return GetViewProperties(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read paragraph portion info (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetSubshapePortion(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSubshapeParagraphPortion");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetSubshapeParagraphPortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read paragraph portion info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSubshapeParagraphPortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        [System.Obsolete("Use GetSubshapePortion method")]
        public Portion GetSubshapeParagraphPortion(GetSubshapeParagraphPortionRequest request)
        {
            return GetSubshapePortion(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.ParagraphIndex, request.PortionIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Read paragraph portions info (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions GetSubshapePortions(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSubshapeParagraphPortions");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetSubshapeParagraphPortions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read paragraph portions info (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSubshapeParagraphPortionsRequest" /></param> 
        /// <returns><see cref="Portions"/></returns>            
        [System.Obsolete("Use GetSubshapePortions method")]
        public Portions GetSubshapeParagraphPortions(GetSubshapeParagraphPortionsRequest request)
        {
            return GetSubshapePortions(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.ParagraphIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="srcPath">Source file path e.g. '/src.ext'</param> 
        /// <param name="destPath">Destination file path e.g. '/dest.ext'</param> 
        /// <param name="srcStorageName">Source storage name</param> 
        /// <param name="destStorageName">Destination storage name</param> 
        /// <param name="versionId">File version ID to move</param> 
        /// <returns><see cref=""/></returns>            
        public void MoveFile(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)
        {
            // verify the required parameter 'srcPath' is set
            if (srcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFile");
            }
            // verify the required parameter 'destPath' is set
            if (destPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFile");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/move/{srcPath}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", destStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", versionId);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use MoveFile method")]
        public void MoveFile(MoveFileRequest request)
        {
            MoveFile(request.SrcPath, request.DestPath, request.SrcStorageName, request.DestStorageName, request.VersionId);
        }

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="srcPath">Folder path to move e.g. '/folder'</param> 
        /// <param name="destPath">Destination folder path to move to e.g '/dst'</param> 
        /// <param name="srcStorageName">Source storage name</param> 
        /// <param name="destStorageName">Destination storage name</param> 
        /// <returns><see cref=""/></returns>            
        public void MoveFolder(string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)
        {
            // verify the required parameter 'srcPath' is set
            if (srcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFolder");
            }
            // verify the required parameter 'destPath' is set
            if (destPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFolder");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/folder/move/{srcPath}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", srcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", destPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", srcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", destStorageName);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use MoveFolder method")]
        public void MoveFolder(MoveFolderRequest request)
        {
            MoveFolder(request.SrcPath, request.DestPath, request.SrcStorageName, request.DestStorageName);
        }

        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="path">File or folder path e.g. '/file.ext' or '/folder'</param> 
        /// <param name="storageName">Storage name</param> 
        /// <param name="versionId">File version ID</param> 
        /// <returns><see cref="ObjectExist"/></returns>            
        public ObjectExist ObjectExists(string path, string storageName = null, string versionId = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling ObjectExists");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/exist/{path}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", versionId);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ObjectExist>(resourcePath, "GET", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param> 
        /// <returns><see cref="ObjectExist"/></returns>            
        [System.Obsolete("Use ObjectExists method")]
        public ObjectExist ObjectExists(ObjectExistsRequest request)
        {
            return ObjectExists(request.Path, request.StorageName, request.VersionId);
        }

        /// <summary>
        /// Creates new paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="position">Position of the new paragraph in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph CreateParagraph(string name, int slideIndex, int shapeIndex, Paragraph dto, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PostAddNewParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates new paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        [System.Obsolete("Use CreateParagraph method")]
        public Paragraph PostAddNewParagraph(PostAddNewParagraphRequest request)
        {
            return CreateParagraph(request.Name, request.SlideIndex, request.ShapeIndex, request.Dto, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Creates new portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="position">Position of the new portion in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion CreatePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, Portion dto, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewPortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PostAddNewPortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates new portion. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewPortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        [System.Obsolete("Use CreatePortion method")]
        public Portion PostAddNewPortion(PostAddNewPortionRequest request)
        {
            return CreatePortion(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Dto, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Create new shape. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <param name="shapeToClone">Optional index for clone shape instead of adding a new one.</param> 
        /// <param name="position">Position of the new shape in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase CreateShape(string name, int slideIndex, ShapeBase dto = null, int? shapeToClone = null, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", shapeToClone);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create new shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        [System.Obsolete("Use CreateShape method")]
        public ShapeBase PostAddNewShape(PostAddNewShapeRequest request)
        {
            return CreateShape(request.Name, request.SlideIndex, request.Dto, request.ShapeToClone, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Create new shape (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <param name="shapeToClone">Optional index for clone shape instead of adding a new one.</param> 
        /// <param name="position">Position of the new shape in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase CreateSubshape(string name, int slideIndex, string path, ShapeBase dto = null, int? shapeToClone = null, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewSubshape");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostAddNewSubshape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", shapeToClone);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create new shape (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewSubshapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        [System.Obsolete("Use CreateSubshape method")]
        public ShapeBase PostAddNewSubshape(PostAddNewSubshapeRequest request)
        {
            return CreateSubshape(request.Name, request.SlideIndex, request.Path, request.Dto, request.ShapeToClone, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Creates new paragraph (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="position">Position of the new paragraph in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph CreateSubshapeParagraph(string name, int slideIndex, string path, int shapeIndex, Paragraph dto, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewSubshapeParagraph");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostAddNewSubshapeParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PostAddNewSubshapeParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates new paragraph (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewSubshapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        [System.Obsolete("Use CreateSubshapeParagraph method")]
        public Paragraph PostAddNewSubshapeParagraph(PostAddNewSubshapeParagraphRequest request)
        {
            return CreateSubshapeParagraph(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.Dto, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Creates new portion (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="position">Position of the new portion in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion CreateSubshapePortion(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, Portion dto, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNewSubshapePortion");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostAddNewSubshapePortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PostAddNewSubshapePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates new portion (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNewSubshapePortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        [System.Obsolete("Use CreateSubshapePortion method")]
        public Portion PostAddNewSubshapePortion(PostAddNewSubshapePortionRequest request)
        {
            return CreateSubshapePortion(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.ParagraphIndex, request.Dto, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Add new notes slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="dto">A NotesSlide object with notes slide data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        public NotesSlide CreateNotesSlide(string name, int slideIndex, NotesSlide dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAddNotesSlide");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PostAddNotesSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<NotesSlide>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Add new notes slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        [System.Obsolete("Use CreateNotesSlide method")]
        public NotesSlide PostAddNotesSlide(PostAddNotesSlideRequest request)
        {
            return CreateNotesSlide(request.Name, request.SlideIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Changes the placement of selected shapes on the slide. Aligns shapes to the margins or the edge of the slide or aligns them relative to each other. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="alignmentType">Alignment type that will be applied to the shapes.</param> 
        /// <param name="alignToSlide">If true, shapes will be aligned relative to the slide edges.</param> 
        /// <param name="shapes">Shapes indexes.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes AlignShapes(string name, int slideIndex, ShapesAlignmentType alignmentType, bool? alignToSlide = null, List<int> shapes = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAlignShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/align/{alignmentType}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "alignmentType", alignmentType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "alignToSlide", alignToSlide);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Changes the placement of selected shapes on the slide. Aligns shapes to the margins or the edge of the slide or aligns them relative to each other. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAlignShapesRequest" /></param> 
        /// <returns><see cref="Shapes"/></returns>            
        [System.Obsolete("Use AlignShapes method")]
        public Shapes PostAlignShapes(PostAlignShapesRequest request)
        {
            return AlignShapes(request.Name, request.SlideIndex, request.AlignmentType, request.AlignToSlide, request.Shapes, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Add a new category to a chart. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="category">Category DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart CreateChartCategory(string name, int slideIndex, int shapeIndex, ChartCategory category, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostChartCategory");
            }
            // verify the required parameter 'category' is set
            if (category == null)
            {
                throw new ApiException(400, "Missing required parameter 'category' when calling PostChartCategory");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/categories");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(category); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Add a new category to a chart. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartCategoryRequest" /></param> 
        /// <returns><see cref="Chart"/></returns>            
        [System.Obsolete("Use CreateChartCategory method")]
        public Chart PostChartCategory(PostChartCategoryRequest request)
        {
            return CreateChartCategory(request.Name, request.SlideIndex, request.ShapeIndex, request.Category, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Add a new data point to a chart series. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="seriesIndex">Series index.</param> 
        /// <param name="dataPoint">Data point DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart CreateChartDataPoint(string name, int slideIndex, int shapeIndex, int seriesIndex, DataPoint dataPoint, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostChartDataPoint");
            }
            // verify the required parameter 'dataPoint' is set
            if (dataPoint == null)
            {
                throw new ApiException(400, "Missing required parameter 'dataPoint' when calling PostChartDataPoint");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/series/{seriesIndex}/dataPoints");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "seriesIndex", seriesIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dataPoint); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Add a new data point to a chart series. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartDataPointRequest" /></param> 
        /// <returns><see cref="Chart"/></returns>            
        [System.Obsolete("Use CreateChartDataPoint method")]
        public Chart PostChartDataPoint(PostChartDataPointRequest request)
        {
            return CreateChartDataPoint(request.Name, request.SlideIndex, request.ShapeIndex, request.SeriesIndex, request.DataPoint, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Add a new series to a chart. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index (must be a chart).</param> 
        /// <param name="series">Series DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart CreateChartSeries(string name, int slideIndex, int shapeIndex, Series series, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostChartSeries");
            }
            // verify the required parameter 'series' is set
            if (series == null)
            {
                throw new ApiException(400, "Missing required parameter 'series' when calling PostChartSeries");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/series");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(series); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Add a new series to a chart. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartSeriesRequest" /></param> 
        /// <returns><see cref="Chart"/></returns>            
        [System.Obsolete("Use CreateChartSeries method")]
        public Chart PostChartSeries(PostChartSeriesRequest request)
        {
            return CreateChartSeries(request.Name, request.SlideIndex, request.ShapeIndex, request.Series, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Copy layoutSlide from source presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="cloneFrom">Name of the document to clone layoutSlide from.</param> 
        /// <param name="cloneFromPosition">Position of cloned layout slide.</param> 
        /// <param name="cloneFromPassword">Password for the document to clone layoutSlide from.</param> 
        /// <param name="cloneFromStorage">Storage of the document to clone layoutSlide from.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="LayoutSlide"/></returns>            
        public LayoutSlide CopyLayoutSlide(string name, string cloneFrom, int cloneFromPosition, string cloneFromPassword = null, string cloneFromStorage = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCopyLayoutSlideFromSourcePresentation");
            }
            // verify the required parameter 'cloneFrom' is set
            if (cloneFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'cloneFrom' when calling PostCopyLayoutSlideFromSourcePresentation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides");
            var headerParams = new Dictionary<string, string>();
            
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFrom", cloneFrom);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromPosition", cloneFromPosition);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromStorage", cloneFromStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "cloneFromPassword", cloneFromPassword);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<LayoutSlide>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Copy layoutSlide from source presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyLayoutSlideFromSourcePresentationRequest" /></param> 
        /// <returns><see cref="LayoutSlide"/></returns>            
        [System.Obsolete("Use CopyLayoutSlide method")]
        public LayoutSlide PostCopyLayoutSlideFromSourcePresentation(PostCopyLayoutSlideFromSourcePresentationRequest request)
        {
            return CopyLayoutSlide(request.Name, request.CloneFrom, request.CloneFromPosition, request.CloneFromPassword, request.CloneFromStorage, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Copy masterSlide from source presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="cloneFrom">Name of the document to clone masterSlide from.</param> 
        /// <param name="cloneFromPosition">Position of cloned master slide.</param> 
        /// <param name="cloneFromPassword">Password for the document to clone masterSlide from.</param> 
        /// <param name="cloneFromStorage">Storage of the document to clone masterSlide from.</param> 
        /// <param name="applyToAll">True to apply cloned master slide to every existing slide.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="MasterSlide"/></returns>            
        public MasterSlide CopyMasterSlide(string name, string cloneFrom, int cloneFromPosition, string cloneFromPassword = null, string cloneFromStorage = null, bool? applyToAll = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCopyMasterSlideFromSourcePresentation");
            }
            // verify the required parameter 'cloneFrom' is set
            if (cloneFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'cloneFrom' when calling PostCopyMasterSlideFromSourcePresentation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/masterSlides");
            var headerParams = new Dictionary<string, string>();
            
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFrom", cloneFrom);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromPosition", cloneFromPosition);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cloneFromStorage", cloneFromStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "applyToAll", applyToAll);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "cloneFromPassword", cloneFromPassword);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<MasterSlide>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Copy masterSlide from source presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyMasterSlideFromSourcePresentationRequest" /></param> 
        /// <returns><see cref="MasterSlide"/></returns>            
        [System.Obsolete("Use CopyMasterSlide method")]
        public MasterSlide PostCopyMasterSlideFromSourcePresentation(PostCopyMasterSlideFromSourcePresentationRequest request)
        {
            return CopyMasterSlide(request.Name, request.CloneFrom, request.CloneFromPosition, request.CloneFromPassword, request.CloneFromStorage, request.ApplyToAll, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Get image binary data. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="index">Image index.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImageDefaultFormatOnline(System.IO.Stream document, int index, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostExportImageWithDefaultFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/images/{index}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", index);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get image binary data. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExportImageWithDefaultFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadImageDefaultFormatOnline method")]
        public System.IO.Stream PostExportImageWithDefaultFormat(PostExportImageWithDefaultFormatRequest request)
        {
            return DownloadImageDefaultFormatOnline(request.Document, request.Index, request.Password);
        }

        /// <summary>
        /// Get image in specified format. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="index">Image index.</param> 
        /// <param name="format">Export format (png, jpg, gif).</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImageOnline(System.IO.Stream document, int index, ImageExportFormat format, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostExportImageWithFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/images/{index}/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", index);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get image in specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExportImageWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadImageOnline method")]
        public System.IO.Stream PostExportImageWithFormat(PostExportImageWithFormatRequest request)
        {
            return DownloadImageOnline(request.Document, request.Index, request.Format, request.Password);
        }

        /// <summary>
        /// Get all presentation images in specified format.  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="format">Export format (png, jpg, gif).</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImagesOnline(System.IO.Stream document, ImageExportFormat format, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostExportImagesFromRequestWithFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/images/download/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get all presentation images in specified format.  
        /// </summary>
        /// <param name="request">Request. <see cref="PostExportImagesFromRequestWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadImagesOnline method")]
        public System.IO.Stream PostExportImagesFromRequestWithFormat(PostExportImagesFromRequestWithFormatRequest request)
        {
            return DownloadImagesOnline(request.Document, request.Format, request.Password);
        }

        /// <summary>
        /// Get all presentation images. 
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImagesDefaultFormat(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostExportImagesWithDefaultFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/images/download");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get all presentation images. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExportImagesWithDefaultFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadImagesDefaultFormat method")]
        public System.IO.Stream PostExportImagesWithDefaultFormat(PostExportImagesWithDefaultFormatRequest request)
        {
            return DownloadImagesDefaultFormat(request.Name, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Get all presentation images in specified format. 
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format">Export format (png, jpg, gif).</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImages(string name, ImageExportFormat format, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostExportImagesWithFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/images/download/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get all presentation images in specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExportImagesWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadImages method")]
        public System.IO.Stream PostExportImagesWithFormat(PostExportImagesWithFormatRequest request)
        {
            return DownloadImages(request.Name, request.Format, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Index of shape starting from 1</param> 
        /// <param name="format">Export picture format.</param> 
        /// <param name="scaleX">X scale ratio.</param> 
        /// <param name="scaleY">Y scale ratio.</param> 
        /// <param name="bounds">Shape thumbnail bounds type.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Fonts folder.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadShapeOnline(System.IO.Stream document, int slideIndex, int shapeIndex, ShapeExportFormat format, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostExportShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/shapes/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExportShapeRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadShapeOnline method")]
        public System.IO.Stream PostExportShape(PostExportShapeRequest request)
        {
            return DownloadShapeOnline(request.Document, request.SlideIndex, request.ShapeIndex, request.Format, request.ScaleX, request.ScaleY, request.Bounds, request.Password, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="width">Output file width; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="height">Output file height; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadSlideOnline(System.IO.Stream document, int slideIndex, SlideExportFormat format, int? width = null, int? height = null, string password = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostExportSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostExportSlideRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadSlideOnline method")]
        public System.IO.Stream PostExportSlide(PostExportSlideRequest request)
        {
            return DownloadSlideOnline(request.Document, request.SlideIndex, request.Format, request.Width, request.Height, request.Password, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Read notes slide info. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        public NotesSlide GetNotesSlideOnline(System.IO.Stream document, int slideIndex, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostGetNotesSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/notesSlide");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeStreamApi<NotesSlide>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read notes slide info. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostGetNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        [System.Obsolete("Use GetNotesSlideOnline method")]
        public NotesSlide PostGetNotesSlide(PostGetNotesSlideRequest request)
        {
            return GetNotesSlideOnline(request.Document, request.SlideIndex, request.Password);
        }

        /// <summary>
        /// Get info whether a notes slide exists. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="EntityExists"/></returns>            
        public EntityExists NotesSlideExistsOnline(System.IO.Stream document, int slideIndex, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostGetNotesSlideExists");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/notesSlide/exist");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeStreamApi<EntityExists>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get info whether a notes slide exists. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostGetNotesSlideExistsRequest" /></param> 
        /// <returns><see cref="EntityExists"/></returns>            
        [System.Obsolete("Use NotesSlideExistsOnline method")]
        public EntityExists PostGetNotesSlideExists(PostGetNotesSlideExistsRequest request)
        {
            return NotesSlideExistsOnline(request.Document, request.SlideIndex, request.Password);
        }

        /// <summary>
        /// Convert notes slide to the specified image format. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="width">Output file width.</param> 
        /// <param name="height">Output file height.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadNotesSlideOnline(System.IO.Stream document, int slideIndex, NotesSlideExportFormat format, int? width = null, int? height = null, string password = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostGetNotesSlideWithFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/notesSlide/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Convert notes slide to the specified image format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostGetNotesSlideWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadNotesSlideOnline method")]
        public System.IO.Stream PostGetNotesSlideWithFormat(PostGetNotesSlideWithFormatRequest request)
        {
            return DownloadNotesSlideOnline(request.Document, request.SlideIndex, request.Format, request.Width, request.Height, request.Password, request.FontsFolder);
        }

        /// <summary>
        /// Adds an image watermark to each slide of the presentation.  Image can be provided as a part of the form or withing PictureFrame DTO for detailed customization. Both options are applicable simultaneously.  
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="image">Image data.</param> 
        /// <param name="pictureFrame">PictureFrame DTO</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref=""/></returns>            
        public void CreateImageWatermark(string name, System.IO.Stream image = null, PictureFrame pictureFrame = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostImageWatermark");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/watermark/image");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(pictureFrame); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (image != null) 
            {
                requestFiles.Add(new FileInfo { Name = "image", Content = image });
            }
            InvokeVoidApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Adds an image watermark to each slide of the presentation.  Image can be provided as a part of the form or withing PictureFrame DTO for detailed customization. Both options are applicable simultaneously.  
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWatermarkRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use CreateImageWatermark method")]
        public void PostImageWatermark(PostImageWatermarkRequest request)
        {
            CreateImageWatermark(request.Name, request.Image, request.PictureFrame, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Adds an image watermark to each slide of the presentation.  Image can be provided as a part of the form or withing PictureFrame DTO for detailed customization. Both options are applicable simultaneously.  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="image">Image data.</param> 
        /// <param name="pictureFrame">PictureFrame DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateImageWatermarkOnline(System.IO.Stream document, System.IO.Stream image = null, PictureFrame pictureFrame = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostImageWatermarkOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/watermark/image");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(pictureFrame); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            if (image != null) 
            {
                requestFiles.Add(new FileInfo { Name = "image", Content = image });
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Adds an image watermark to each slide of the presentation.  Image can be provided as a part of the form or withing PictureFrame DTO for detailed customization. Both options are applicable simultaneously.  
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageWatermarkOnlineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use CreateImageWatermarkOnline method")]
        public System.IO.Stream PostImageWatermarkOnline(PostImageWatermarkOnlineRequest request)
        {
            return CreateImageWatermarkOnline(request.Document, request.Image, request.PictureFrame, request.Password);
        }

        /// <summary>
        /// Get all presentation images. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImagesDefaultFormatOnline(System.IO.Stream document, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostImagesFromRequestWithDefaultFormat");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/images/download");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get all presentation images. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImagesFromRequestWithDefaultFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadImagesDefaultFormatOnline method")]
        public System.IO.Stream PostImagesFromRequestWithDefaultFormat(PostImagesFromRequestWithDefaultFormatRequest request)
        {
            return DownloadImagesDefaultFormatOnline(request.Document, request.Password);
        }

        /// <summary>
        /// Creates new paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="position">Position of the new paragraph in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph CreateNotesSlideParagraph(string name, int slideIndex, int shapeIndex, Paragraph dto, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideAddNewParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PostNotesSlideAddNewParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates new paragraph. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideAddNewParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        [System.Obsolete("Use CreateNotesSlideParagraph method")]
        public Paragraph PostNotesSlideAddNewParagraph(PostNotesSlideAddNewParagraphRequest request)
        {
            return CreateNotesSlideParagraph(request.Name, request.SlideIndex, request.ShapeIndex, request.Dto, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Creates new portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="position">Position of the new portion in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion CreateNotesSlidePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, Portion dto, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideAddNewPortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PostNotesSlideAddNewPortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates new portion. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideAddNewPortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        [System.Obsolete("Use CreateNotesSlidePortion method")]
        public Portion PostNotesSlideAddNewPortion(PostNotesSlideAddNewPortionRequest request)
        {
            return CreateNotesSlidePortion(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Dto, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Create new shape. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <param name="shapeToClone">Optional index for clone shape instead of adding a new one.</param> 
        /// <param name="position">Position of the new shape in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase CreateNotesSlideShape(string name, int slideIndex, ShapeBase dto, int? shapeToClone = null, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideAddNewShape");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PostNotesSlideAddNewShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", shapeToClone);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create new shape. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideAddNewShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        [System.Obsolete("Use CreateNotesSlideShape method")]
        public ShapeBase PostNotesSlideAddNewShape(PostNotesSlideAddNewShapeRequest request)
        {
            return CreateNotesSlideShape(request.Name, request.SlideIndex, request.Dto, request.ShapeToClone, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="name">Presentation name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Index of shape starting from 1</param> 
        /// <param name="format">Export picture format.</param> 
        /// <param name="options">export options</param> 
        /// <param name="scaleX">X scale ratio.</param> 
        /// <param name="scaleY">Y scale ratio.</param> 
        /// <param name="bounds">Shape thumbnail bounds type.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Presentation folder.</param> 
        /// <param name="storage">Presentation storage.</param> 
        /// <param name="fontsFolder">Fonts folder.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadNotesSlideShape(string name, int slideIndex, int shapeIndex, ShapeExportFormat format, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostNotesSlideShapeSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostNotesSlideShapeSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadNotesSlideShape method")]
        public System.IO.Stream PostNotesSlideShapeSaveAs(PostNotesSlideShapeSaveAsRequest request)
        {
            return DownloadNotesSlideShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Format, request.Options, request.ScaleX, request.ScaleY, request.Bounds, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Merge the presentation with other presentations specified in the request parameter. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="request">PresentationsMergeRequest with a list of presentations to merge.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document Merge(string name, PresentationsMergeRequest request, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostPresentationMerge");
            }
            // verify the required parameter 'request' is set
            if (request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling PostPresentationMerge");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/merge");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Document>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Merge the presentation with other presentations specified in the request parameter. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostPresentationMergeRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        [System.Obsolete("Use Merge method")]
        public Document PostPresentationMerge(PostPresentationMergeRequest request)
        {
            return Merge(request.Name, request.Request, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Replace text with a new value. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="oldValue">Text value to be replaced.</param> 
        /// <param name="newValue">Text value to replace with.</param> 
        /// <param name="ignoreCase">True if character case must be ignored.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ReplacePresentationTextOnline(System.IO.Stream document, string oldValue, string newValue, bool? ignoreCase = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostPresentationReplaceText");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling PostPresentationReplaceText");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling PostPresentationReplaceText");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/replaceText");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldValue", oldValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newValue", newValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreCase", ignoreCase);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Replace text with a new value. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostPresentationReplaceTextRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use ReplacePresentationTextOnline method")]
        public System.IO.Stream PostPresentationReplaceText(PostPresentationReplaceTextRequest request)
        {
            return ReplacePresentationTextOnline(request.Document, request.OldValue, request.NewValue, request.IgnoreCase, request.Password);
        }

        /// <summary>
        /// Splits PowerPoint presentation slides from the specified range into separate files and exports them in the specified file format. If the range is not provided all slides will be processed.  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="format">ExportFormat</param> 
        /// <param name="width">Slide width.</param> 
        /// <param name="height">Slide height.</param> 
        /// <param name="from">The start slide number for splitting, if is not specified splitting starts from the first slide of the presentation.</param> 
        /// <param name="to">The last slide number for splitting, if is not specified splitting ends at the last slide of the document.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream SplitOnline(System.IO.Stream document, SlideExportFormat format, int? width = null, int? height = null, int? from = null, int? to = null, string password = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostPresentationSplit");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/split/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "from", from);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "to", to);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Splits PowerPoint presentation slides from the specified range into separate files and exports them in the specified file format. If the range is not provided all slides will be processed.  
        /// </summary>
        /// <param name="request">Request. <see cref="PostPresentationSplitRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use SplitOnline method")]
        public System.IO.Stream PostPresentationSplit(PostPresentationSplitRequest request)
        {
            return SplitOnline(request.Document, request.Format, request.Width, request.Height, request.From, request.To, request.Password, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Create a section starting at a specified slide index. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="sectionName">Section name.</param> 
        /// <param name="slideIndex">Slide index (one-based).</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Sections"/></returns>            
        public Sections CreateSection(string name, string sectionName, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSection");
            }
            // verify the required parameter 'sectionName' is set
            if (sectionName == null)
            {
                throw new ApiException(400, "Missing required parameter 'sectionName' when calling PostSection");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/sections");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sectionName", sectionName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Sections>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create a section starting at a specified slide index. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSectionRequest" /></param> 
        /// <returns><see cref="Sections"/></returns>            
        [System.Obsolete("Use CreateSection method")]
        public Sections PostSection(PostSectionRequest request)
        {
            return CreateSection(request.Name, request.SectionName, request.SlideIndex, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Move presentation section to a specified position. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="sectionIndex">The position of the section to be reordered.</param> 
        /// <param name="newPosition">The new position of the reordered section.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Sections"/></returns>            
        public Sections MoveSection(string name, int sectionIndex, int newPosition, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSectionMove");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/sections/{sectionIndex}/move");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionIndex", sectionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newPosition", newPosition);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Sections>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Move presentation section to a specified position. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSectionMoveRequest" /></param> 
        /// <returns><see cref="Sections"/></returns>            
        [System.Obsolete("Use MoveSection method")]
        public Sections PostSectionMove(PostSectionMoveRequest request)
        {
            return MoveSection(request.Name, request.SectionIndex, request.NewPosition, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="name">Presentation name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Index of shape starting from 1</param> 
        /// <param name="format">Export picture format.</param> 
        /// <param name="options">export options</param> 
        /// <param name="scaleX">X scale ratio.</param> 
        /// <param name="scaleY">Y scale ratio.</param> 
        /// <param name="bounds">Shape thumbnail bounds type.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Presentation folder.</param> 
        /// <param name="storage">Presentation storage.</param> 
        /// <param name="fontsFolder">Fonts folder.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadShape(string name, int slideIndex, int shapeIndex, ShapeExportFormat format, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostShapeSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostShapeSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadShape method")]
        public System.IO.Stream PostShapeSaveAs(PostShapeSaveAsRequest request)
        {
            return DownloadShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Format, request.Options, request.ScaleX, request.ScaleY, request.Bounds, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Add an effect to slide animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="effect">Animation effect DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation CreateAnimationEffect(string name, int slideIndex, Effect effect, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlideAnimationEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling PostSlideAnimationEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/mainSequence");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(effect); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Add an effect to slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlideAnimationEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use CreateAnimationEffect method")]
        public SlideAnimation PostSlideAnimationEffect(PostSlideAnimationEffectRequest request)
        {
            return CreateAnimationEffect(request.Name, request.SlideIndex, request.Effect, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Set slide animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="sequence">Animation sequence DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation CreateAnimationInteractiveSequence(string name, int slideIndex, InteractiveSequence sequence, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlideAnimationInteractiveSequence");
            }
            // verify the required parameter 'sequence' is set
            if (sequence == null)
            {
                throw new ApiException(400, "Missing required parameter 'sequence' when calling PostSlideAnimationInteractiveSequence");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(sequence); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlideAnimationInteractiveSequenceRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use CreateAnimationInteractiveSequence method")]
        public SlideAnimation PostSlideAnimationInteractiveSequence(PostSlideAnimationInteractiveSequenceRequest request)
        {
            return CreateAnimationInteractiveSequence(request.Name, request.SlideIndex, request.Sequence, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Add an animation effect to a slide interactive sequence. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="sequenceIndex">The position of the interactive sequence.</param> 
        /// <param name="effect">Animation effect DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation CreateAnimationInteractiveSequenceEffect(string name, int slideIndex, int sequenceIndex, Effect effect, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlideAnimationInteractiveSequenceEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling PostSlideAnimationInteractiveSequenceEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences/{sequenceIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", sequenceIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(effect); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Add an animation effect to a slide interactive sequence. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlideAnimationInteractiveSequenceEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use CreateAnimationInteractiveSequenceEffect method")]
        public SlideAnimation PostSlideAnimationInteractiveSequenceEffect(PostSlideAnimationInteractiveSequenceEffectRequest request)
        {
            return CreateAnimationInteractiveSequenceEffect(request.Name, request.SlideIndex, request.SequenceIndex, request.Effect, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Replace slide text with a new value. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Index of target slide.</param> 
        /// <param name="oldValue">Text value to be replaced.</param> 
        /// <param name="newValue">Text value to replace with.</param> 
        /// <param name="ignoreCase">True if character case must be ignored.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ReplaceSlideTextOnline(System.IO.Stream document, int slideIndex, string oldValue, string newValue, bool? ignoreCase = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostSlideReplaceText");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling PostSlideReplaceText");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling PostSlideReplaceText");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/replaceText");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldValue", oldValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newValue", newValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreCase", ignoreCase);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Replace slide text with a new value. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlideReplaceTextRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use ReplaceSlideTextOnline method")]
        public System.IO.Stream PostSlideReplaceText(PostSlideReplaceTextRequest request)
        {
            return ReplaceSlideTextOnline(request.Document, request.SlideIndex, request.OldValue, request.NewValue, request.IgnoreCase, request.Password);
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="options">Export options.</param> 
        /// <param name="width">Output file width; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="height">Output file height; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadSlide(string name, int slideIndex, SlideExportFormat format, ExportOptions options = null, int? width = null, int? height = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlideSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlideSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadSlide method")]
        public System.IO.Stream PostSlideSaveAs(PostSlideSaveAsRequest request)
        {
            return DownloadSlide(request.Name, request.SlideIndex, request.Format, request.Options, request.Width, request.Height, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Create a slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="layoutAlias">Alias of layout slide for new slide. Alias may be the type of layout, name of layout slide or index</param> 
        /// <param name="position">The target position at which to create the slide. Add to the end by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides CreateSlide(string name, string layoutAlias = null, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesAdd");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "layoutAlias", layoutAlias);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Model.Slides>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesAddRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        [System.Obsolete("Use CreateSlide method")]
        public Model.Slides PostSlidesAdd(PostSlidesAddRequest request)
        {
            return CreateSlide(request.Name, request.LayoutAlias, request.Position, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Convert presentation from request content to format specified. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="format">Export format.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream Convert(System.IO.Stream document, ExportFormat format, string password = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostSlidesConvert");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/convert/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Convert presentation from request content to format specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesConvertRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use Convert method")]
        public System.IO.Stream PostSlidesConvert(PostSlidesConvertRequest request)
        {
            return Convert(request.Document, request.Format, request.Password, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Copy a slide from the current or another presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideToCopy">The index of the slide to be copied from the source presentation.</param> 
        /// <param name="position">The target position at which to copy the slide. Copy to the end by default.</param> 
        /// <param name="source">Name of the document to copy a slide from.</param> 
        /// <param name="sourcePassword">Password for the document to copy a slide from.</param> 
        /// <param name="sourceStorage">Template storage name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides CopySlide(string name, int slideToCopy, int? position = null, string source = null, string sourcePassword = null, string sourceStorage = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesCopy");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/copy");
            var headerParams = new Dictionary<string, string>();
            
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slideToCopy", slideToCopy);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "source", source);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sourceStorage", sourceStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "sourcePassword", sourcePassword);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Model.Slides>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Copy a slide from the current or another presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesCopyRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        [System.Obsolete("Use CopySlide method")]
        public Model.Slides PostSlidesCopy(PostSlidesCopyRequest request)
        {
            return CopySlide(request.Name, request.SlideToCopy, request.Position, request.Source, request.SourcePassword, request.SourceStorage, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Create a presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="data">Document input data.</param> 
        /// <param name="inputPassword">The password for input document.</param> 
        /// <param name="password">The document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document CreatePresentation(string name, System.IO.Stream data = null, string inputPassword = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocument");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}");
            var headerParams = new Dictionary<string, string>();
            
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "inputPassword", inputPassword);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (data != null) 
            {
                requestFiles.Add(new FileInfo { Name = "data", Content = data });
            }
            return InvokeStreamApi<Document>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create a presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        [System.Obsolete("Use CreatePresentation method")]
        public Document PostSlidesDocument(PostSlidesDocumentRequest request)
        {
            return CreatePresentation(request.Name, request.Data, request.InputPassword, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Create presentation document from html. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="html">HTML data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document ImportFromHtml(string name, string html = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocumentFromHtml");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fromHtml");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(html); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Document>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create presentation document from html. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentFromHtmlRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        [System.Obsolete("Use ImportFromHtml method")]
        public Document PostSlidesDocumentFromHtml(PostSlidesDocumentFromHtmlRequest request)
        {
            return ImportFromHtml(request.Name, request.Html, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Create presentation document from pdf or append pdf to an existing presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="pdf">PDF data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document ImportFromPdf(string name, System.IO.Stream pdf = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocumentFromPdf");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fromPdf");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (pdf != null) 
            {
                requestFiles.Add(new FileInfo { Name = "pdf", Content = pdf });
            }
            return InvokeStreamApi<Document>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create presentation document from pdf or append pdf to an existing presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentFromPdfRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        [System.Obsolete("Use ImportFromPdf method")]
        public Document PostSlidesDocumentFromPdf(PostSlidesDocumentFromPdfRequest request)
        {
            return ImportFromPdf(request.Name, request.Pdf, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Create a presentation from an existing source. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="sourcePath">Template file path.</param> 
        /// <param name="sourcePassword">Template file password.</param> 
        /// <param name="sourceStorage">Template storage name.</param> 
        /// <param name="password">The document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document CreatePresentationFromSource(string name, string sourcePath = null, string sourcePassword = null, string sourceStorage = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocumentFromSource");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fromSource");
            var headerParams = new Dictionary<string, string>();
            
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sourcePath", sourcePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sourceStorage", sourceStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "sourcePassword", sourcePassword);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Document>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create a presentation from an existing source. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentFromSourceRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        [System.Obsolete("Use CreatePresentationFromSource method")]
        public Document PostSlidesDocumentFromSource(PostSlidesDocumentFromSourceRequest request)
        {
            return CreatePresentationFromSource(request.Name, request.SourcePath, request.SourcePassword, request.SourceStorage, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Create a presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="templatePath">Template file path.</param> 
        /// <param name="data">Document input data.</param> 
        /// <param name="templatePassword">Template file password.</param> 
        /// <param name="templateStorage">Template storage name.</param> 
        /// <param name="isImageDataEmbedded">True if image data is embedded.</param> 
        /// <param name="password">The document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document CreatePresentationFromTemplate(string name, string templatePath, string data = null, string templatePassword = null, string templateStorage = null, bool? isImageDataEmbedded = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesDocumentFromTemplate");
            }
            // verify the required parameter 'templatePath' is set
            if (templatePath == null)
            {
                throw new ApiException(400, "Missing required parameter 'templatePath' when calling PostSlidesDocumentFromTemplate");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fromTemplate");
            var headerParams = new Dictionary<string, string>();
            
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templatePath", templatePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "templateStorage", templateStorage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "isImageDataEmbedded", isImageDataEmbedded);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "templatePassword", templatePassword);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(data); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Document>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create a presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesDocumentFromTemplateRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        [System.Obsolete("Use CreatePresentationFromTemplate method")]
        public Document PostSlidesDocumentFromTemplate(PostSlidesDocumentFromTemplateRequest request)
        {
            return CreatePresentationFromTemplate(request.Name, request.TemplatePath, request.Data, request.TemplatePassword, request.TemplateStorage, request.IsImageDataEmbedded, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Merges the presentation with other presentations or some of their slides specified in the request parameter. Returns result file in the response.  
        /// </summary>
        /// <param name="files">Files to merge</param> 
        /// <param name="request">Merge request.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream MergeOnline(List<FileInfo> files = null, OrderedMergeRequest request = null, string password = null)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/merge");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (files != null) 
            {
                requestFiles.AddRange(files);
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Merges the presentation with other presentations or some of their slides specified in the request parameter. Returns result file in the response.  
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesMergeRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use MergeOnline method")]
        public System.IO.Stream PostSlidesMerge(PostSlidesMergeRequest request)
        {
            return MergeOnline(request.Files, request.Request, request.Password);
        }

        /// <summary>
        /// Performs slides pipeline. 
        /// </summary>
        /// <param name="pipeline">A Pipeline object.</param> 
        /// <param name="files">Files to upload with the pipeline</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream Pipeline(Pipeline pipeline, List<FileInfo> files = null)
        {
            // verify the required parameter 'pipeline' is set
            if (pipeline == null)
            {
                throw new ApiException(400, "Missing required parameter 'pipeline' when calling PostSlidesPipeline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/pipeline");
            var formParams = new Dictionary<string, object>();
            var postBody = SerializationHelper.Serialize(pipeline); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (files != null) 
            {
                requestFiles.AddRange(files);
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Performs slides pipeline. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesPipelineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use Pipeline method")]
        public System.IO.Stream PostSlidesPipeline(PostSlidesPipelineRequest request)
        {
            return Pipeline(request.Pipeline, request.Files);
        }

        /// <summary>
        /// Replace text with a new value. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="oldValue">Text value to be replaced.</param> 
        /// <param name="newValue">Text value to replace with.</param> 
        /// <param name="ignoreCase">True if character case must be ignored.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="DocumentReplaceResult"/></returns>            
        public DocumentReplaceResult ReplacePresentationText(string name, string oldValue, string newValue, bool? ignoreCase = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesPresentationReplaceText");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling PostSlidesPresentationReplaceText");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling PostSlidesPresentationReplaceText");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/replaceText");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldValue", oldValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newValue", newValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreCase", ignoreCase);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<DocumentReplaceResult>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Replace text with a new value. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesPresentationReplaceTextRequest" /></param> 
        /// <returns><see cref="DocumentReplaceResult"/></returns>            
        [System.Obsolete("Use ReplacePresentationText method")]
        public DocumentReplaceResult PostSlidesPresentationReplaceText(PostSlidesPresentationReplaceTextRequest request)
        {
            return ReplacePresentationText(request.Name, request.OldValue, request.NewValue, request.IgnoreCase, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Reorder presentation slide position. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">The position of the slide to be reordered.</param> 
        /// <param name="newPosition">The new position of the reordered slide.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides MoveSlide(string name, int slideIndex, int newPosition, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesReorder");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/move");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newPosition", newPosition);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Model.Slides>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Reorder presentation slide position. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesReorderRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        [System.Obsolete("Use MoveSlide method")]
        public Model.Slides PostSlidesReorder(PostSlidesReorderRequest request)
        {
            return MoveSlide(request.Name, request.SlideIndex, request.NewPosition, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Reorder presentation slides positions. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="oldPositions">A comma separated array of positions of slides to be reordered.</param> 
        /// <param name="newPositions">A comma separated array of new slide positions.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        public Model.Slides ReorderSlides(string name, List<int> oldPositions = null, List<int> newPositions = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesReorderMany");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/reorder");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldPositions", oldPositions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newPositions", newPositions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Model.Slides>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Reorder presentation slides positions. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesReorderManyRequest" /></param> 
        /// <returns><see cref="Model.Slides"/></returns>            
        [System.Obsolete("Use ReorderSlides method")]
        public Model.Slides PostSlidesReorderMany(PostSlidesReorderManyRequest request)
        {
            return ReorderSlides(request.Name, request.OldPositions, request.NewPositions, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Save a presentation to a specified format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="format">Export format.</param> 
        /// <param name="options">Export options.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadPresentation(string name, ExportFormat format, ExportOptions options = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Save a presentation to a specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadPresentation method")]
        public System.IO.Stream PostSlidesSaveAs(PostSlidesSaveAsRequest request)
        {
            return DownloadPresentation(request.Name, request.Format, request.Options, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Set document properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="properties">New properties.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        public DocumentProperties SetDocumentProperties(string name, DocumentProperties properties, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesSetDocumentProperties");
            }
            // verify the required parameter 'properties' is set
            if (properties == null)
            {
                throw new ApiException(400, "Missing required parameter 'properties' when calling PostSlidesSetDocumentProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(properties); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<DocumentProperties>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSetDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentProperties"/></returns>            
        [System.Obsolete("Use SetDocumentProperties method")]
        public DocumentProperties PostSlidesSetDocumentProperties(PostSlidesSetDocumentPropertiesRequest request)
        {
            return SetDocumentProperties(request.Name, request.Properties, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Replace text with a new value. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="oldValue">Text value to be replaced.</param> 
        /// <param name="newValue">Text value to replace with.</param> 
        /// <param name="ignoreCase">True if character case must be ignored.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideReplaceResult"/></returns>            
        public SlideReplaceResult ReplaceSlideText(string name, int slideIndex, string oldValue, string newValue, bool? ignoreCase = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesSlideReplaceText");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling PostSlidesSlideReplaceText");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling PostSlidesSlideReplaceText");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/replaceText");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldValue", oldValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newValue", newValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreCase", ignoreCase);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideReplaceResult>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Replace text with a new value. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSlideReplaceTextRequest" /></param> 
        /// <returns><see cref="SlideReplaceResult"/></returns>            
        [System.Obsolete("Use ReplaceSlideText method")]
        public SlideReplaceResult PostSlidesSlideReplaceText(PostSlidesSlideReplaceTextRequest request)
        {
            return ReplaceSlideText(request.Name, request.SlideIndex, request.OldValue, request.NewValue, request.IgnoreCase, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Splitting presentations. Create one image per slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="options">Export options.</param> 
        /// <param name="format">Export format. Default value is jpeg.</param> 
        /// <param name="width">The width of created images.</param> 
        /// <param name="height">The height of created images.</param> 
        /// <param name="from">The start slide number for splitting, if is not specified splitting starts from the first slide of the presentation.</param> 
        /// <param name="to">The last slide number for splitting, if is not specified splitting ends at the last slide of the document.</param> 
        /// <param name="destFolder">Folder on storage where images are going to be uploaded. If not specified then images are uploaded to same folder as presentation.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref="SplitDocumentResult"/></returns>            
        public SplitDocumentResult Split(string name, ExportOptions options = null, SlideExportFormat? format = null, int? width = null, int? height = null, int? from = null, int? to = null, string destFolder = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSlidesSplit");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/split");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "from", from);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "to", to);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFolder", destFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SplitDocumentResult>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Splitting presentations. Create one image per slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSlidesSplitRequest" /></param> 
        /// <returns><see cref="SplitDocumentResult"/></returns>            
        [System.Obsolete("Use Split method")]
        public SplitDocumentResult PostSlidesSplit(PostSlidesSplitRequest request)
        {
            return Split(request.Name, request.Options, request.Format, request.Width, request.Height, request.From, request.To, request.DestFolder, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Render shape to specified picture format (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Presentation name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Index of shape starting from 1</param> 
        /// <param name="format">Export picture format.</param> 
        /// <param name="options">export options</param> 
        /// <param name="scaleX">X scale ratio.</param> 
        /// <param name="scaleY">Y scale ratio.</param> 
        /// <param name="bounds">Shape thumbnail bounds type.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Presentation folder.</param> 
        /// <param name="storage">Presentation storage.</param> 
        /// <param name="fontsFolder">Fonts folder.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadSubshape(string name, int slideIndex, string path, int shapeIndex, ShapeExportFormat format, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSubshapeSaveAs");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PostSubshapeSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PostSubshapeSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DownloadSubshape method")]
        public System.IO.Stream PostSubshapeSaveAs(PostSubshapeSaveAsRequest request)
        {
            return DownloadSubshape(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.Format, request.Options, request.ScaleX, request.ScaleY, request.Bounds, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Adds a text watermark to each slide of the presentation. Text watermark can be setup via method arguments or withing Shape DTO for detailed customization. Both options are applicable simultaneously.  
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="shape">Shape DTO</param> 
        /// <param name="fontHeight">Watermark font height.</param> 
        /// <param name="text">Watermark text.</param> 
        /// <param name="fontName">Watermark font name.</param> 
        /// <param name="fontColor">Watermark font color.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref=""/></returns>            
        public void CreateWatermark(string name, Shape shape = null, double? fontHeight = null, string text = null, string fontName = null, string fontColor = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostWatermark");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/watermark");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontHeight", fontHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "text", text);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontName", fontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontColor", fontColor);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(shape); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Adds a text watermark to each slide of the presentation. Text watermark can be setup via method arguments or withing Shape DTO for detailed customization. Both options are applicable simultaneously.  
        /// </summary>
        /// <param name="request">Request. <see cref="PostWatermarkRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use CreateWatermark method")]
        public void PostWatermark(PostWatermarkRequest request)
        {
            CreateWatermark(request.Name, request.Shape, request.FontHeight, request.Text, request.FontName, request.FontColor, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Removes shapes with name \&quot;watermark\&quot; from the presentation. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="shapeName">Name of the watermark shape. If null, default value \"watermark\"is used.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteWatermarkOnline(System.IO.Stream document, string shapeName = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostWatermarkDeleteOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/watermark/delete");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeName", shapeName);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryStreamApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Removes shapes with name \&quot;watermark\&quot; from the presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostWatermarkDeleteOnlineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use DeleteWatermarkOnline method")]
        public System.IO.Stream PostWatermarkDeleteOnline(PostWatermarkDeleteOnlineRequest request)
        {
            return DeleteWatermarkOnline(request.Document, request.ShapeName, request.Password);
        }

        /// <summary>
        /// Adds a text watermark to each slide of the presentation. Text watermark can be setup via method arguments or withing Shape DTO for detailed customization. Both options are applicable simultaneously.  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="shape">Shape DTO</param> 
        /// <param name="fontHeight">Watermark font height.</param> 
        /// <param name="text">Watermark text.</param> 
        /// <param name="fontName">Watermark font name.</param> 
        /// <param name="fontColor">Watermark font color.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateWatermarkOnline(System.IO.Stream document, Shape shape = null, double? fontHeight = null, string text = null, string fontName = null, string fontColor = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PostWatermarkOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/watermark");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontHeight", fontHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "text", text);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontName", fontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontColor", fontColor);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(shape); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Adds a text watermark to each slide of the presentation. Text watermark can be setup via method arguments or withing Shape DTO for detailed customization. Both options are applicable simultaneously.  
        /// </summary>
        /// <param name="request">Request. <see cref="PostWatermarkOnlineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use CreateWatermarkOnline method")]
        public System.IO.Stream PostWatermarkOnline(PostWatermarkOnlineRequest request)
        {
            return CreateWatermarkOnline(request.Document, request.Shape, request.FontHeight, request.Text, request.FontName, request.FontColor, request.Password);
        }

        /// <summary>
        /// Update a chart category. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="categoryIndex">Category index.</param> 
        /// <param name="category">Category DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart UpdateChartCategory(string name, int slideIndex, int shapeIndex, int categoryIndex, ChartCategory category, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutChartCategory");
            }
            // verify the required parameter 'category' is set
            if (category == null)
            {
                throw new ApiException(400, "Missing required parameter 'category' when calling PutChartCategory");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/categories/{categoryIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "categoryIndex", categoryIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(category); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update a chart category. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutChartCategoryRequest" /></param> 
        /// <returns><see cref="Chart"/></returns>            
        [System.Obsolete("Use UpdateChartCategory method")]
        public Chart PutChartCategory(PutChartCategoryRequest request)
        {
            return UpdateChartCategory(request.Name, request.SlideIndex, request.ShapeIndex, request.CategoryIndex, request.Category, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update a data point in a chart series. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="seriesIndex">Series index.</param> 
        /// <param name="pointIndex">Data point index.</param> 
        /// <param name="dataPoint">Data point DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart UpdateChartDataPoint(string name, int slideIndex, int shapeIndex, int seriesIndex, int pointIndex, DataPoint dataPoint, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutChartDataPoint");
            }
            // verify the required parameter 'dataPoint' is set
            if (dataPoint == null)
            {
                throw new ApiException(400, "Missing required parameter 'dataPoint' when calling PutChartDataPoint");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/series/{seriesIndex}/dataPoints/{pointIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "seriesIndex", seriesIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "pointIndex", pointIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dataPoint); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update a data point in a chart series. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutChartDataPointRequest" /></param> 
        /// <returns><see cref="Chart"/></returns>            
        [System.Obsolete("Use UpdateChartDataPoint method")]
        public Chart PutChartDataPoint(PutChartDataPointRequest request)
        {
            return UpdateChartDataPoint(request.Name, request.SlideIndex, request.ShapeIndex, request.SeriesIndex, request.PointIndex, request.DataPoint, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update a series in a chart. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index (must be a chart).</param> 
        /// <param name="seriesIndex">Series index.</param> 
        /// <param name="series">Series DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart UpdateChartSeries(string name, int slideIndex, int shapeIndex, int seriesIndex, Series series, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutChartSeries");
            }
            // verify the required parameter 'series' is set
            if (series == null)
            {
                throw new ApiException(400, "Missing required parameter 'series' when calling PutChartSeries");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/series/{seriesIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "seriesIndex", seriesIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(series); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update a series in a chart. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutChartSeriesRequest" /></param> 
        /// <returns><see cref="Chart"/></returns>            
        [System.Obsolete("Use UpdateChartSeries method")]
        public Chart PutChartSeries(PutChartSeriesRequest request)
        {
            return UpdateChartSeries(request.Name, request.SlideIndex, request.ShapeIndex, request.SeriesIndex, request.Series, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Index of shape starting from 1</param> 
        /// <param name="format">Export picture format.</param> 
        /// <param name="outPath">Path to save result.</param> 
        /// <param name="scaleX">X scale ratio.</param> 
        /// <param name="scaleY">Y scale ratio.</param> 
        /// <param name="bounds">Shape thumbnail bounds type.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Fonts folder.</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveShapeOnline(System.IO.Stream document, int slideIndex, int shapeIndex, ShapeExportFormat format, string outPath, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PutExportShape");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutExportShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/shapes/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            InvokeVoidStreamApi(resourcePath, "PUT", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutExportShapeRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use SaveShapeOnline method")]
        public void PutExportShape(PutExportShapeRequest request)
        {
            SaveShapeOnline(request.Document, request.SlideIndex, request.ShapeIndex, request.Format, request.OutPath, request.ScaleX, request.ScaleY, request.Bounds, request.Password, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="outPath">Path to save result.</param> 
        /// <param name="width">Output file width; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="height">Output file height; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveSlideOnline(System.IO.Stream document, int slideIndex, SlideExportFormat format, string outPath, int? width = null, int? height = null, string password = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PutExportSlide");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutExportSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            InvokeVoidStreamApi(resourcePath, "PUT", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutExportSlideRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use SaveSlideOnline method")]
        public void PutExportSlide(PutExportSlideRequest request)
        {
            SaveSlideOnline(request.Document, request.SlideIndex, request.Format, request.OutPath, request.Width, request.Height, request.Password, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Update a layoutSlide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="slideDto">Slide update data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="LayoutSlide"/></returns>            
        public LayoutSlide UpdateLayoutSlide(string name, int slideIndex, LayoutSlide slideDto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutLayoutSlide");
            }
            // verify the required parameter 'slideDto' is set
            if (slideDto == null)
            {
                throw new ApiException(400, "Missing required parameter 'slideDto' when calling PutLayoutSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides/{slideIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(slideDto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<LayoutSlide>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update a layoutSlide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutLayoutSlideRequest" /></param> 
        /// <returns><see cref="LayoutSlide"/></returns>            
        [System.Obsolete("Use UpdateLayoutSlide method")]
        public LayoutSlide PutLayoutSlide(PutLayoutSlideRequest request)
        {
            return UpdateLayoutSlide(request.Name, request.SlideIndex, request.SlideDto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Set header/footer the notes slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="dto">Header/footer to set.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="NotesSlideHeaderFooter"/></returns>            
        public NotesSlideHeaderFooter SetNotesSlideHeaderFooter(string name, int slideIndex, NotesSlideHeaderFooter dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutNotesSlideHeaderFooter");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutNotesSlideHeaderFooter");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/headerFooter");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<NotesSlideHeaderFooter>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set header/footer the notes slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutNotesSlideHeaderFooterRequest" /></param> 
        /// <returns><see cref="NotesSlideHeaderFooter"/></returns>            
        [System.Obsolete("Use SetNotesSlideHeaderFooter method")]
        public NotesSlideHeaderFooter PutNotesSlideHeaderFooter(PutNotesSlideHeaderFooterRequest request)
        {
            return SetNotesSlideHeaderFooter(request.Name, request.SlideIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="name">Presentation name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Index of shape starting from 1</param> 
        /// <param name="format">Export picture format.</param> 
        /// <param name="outPath">Output path.</param> 
        /// <param name="options">export options</param> 
        /// <param name="scaleX">X scale ratio.</param> 
        /// <param name="scaleY">Y scale ratio.</param> 
        /// <param name="bounds">Shape thumbnail bounds type.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Presentation folder.</param> 
        /// <param name="storage">Presentation storage.</param> 
        /// <param name="fontsFolder">Fonts folder.</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveNotesSlideShape(string name, int slideIndex, int shapeIndex, ShapeExportFormat format, string outPath, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutNotesSlideShapeSaveAs");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutNotesSlideShapeSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutNotesSlideShapeSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use SaveNotesSlideShape method")]
        public void PutNotesSlideShapeSaveAs(PutNotesSlideShapeSaveAsRequest request)
        {
            SaveNotesSlideShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Format, request.OutPath, request.Options, request.ScaleX, request.ScaleY, request.Bounds, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Merge the presentation with other presentations or some of their slides specified in the request parameter. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="request">OrderedMergeRequest with a list of presentations and slide indices to merge.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document OrderedMerge(string name, OrderedMergeRequest request, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutPresentationMerge");
            }
            // verify the required parameter 'request' is set
            if (request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling PutPresentationMerge");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/merge");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Document>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Merge the presentation with other presentations or some of their slides specified in the request parameter. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutPresentationMergeRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        [System.Obsolete("Use OrderedMerge method")]
        public Document PutPresentationMerge(PutPresentationMergeRequest request)
        {
            return OrderedMerge(request.Name, request.Request, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Splits PowerPoint presentation slides from the specified range into separate files and exports them in the specified file format. If the range is not provided all slides will be processed.  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="format">ExportFormat</param> 
        /// <param name="destFolder">Folder on storage where images are going to be uploaded. If not specified then images are uploaded to the root folder.</param> 
        /// <param name="width">Slide width.</param> 
        /// <param name="height">Slide height.</param> 
        /// <param name="from">The start slide number for splitting, if is not specified splitting starts from the first slide of the presentation.</param> 
        /// <param name="to">The last slide number for splitting, if is not specified splitting ends at the last slide of the document.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref="SplitDocumentResult"/></returns>            
        public SplitDocumentResult SplitAndSaveOnline(System.IO.Stream document, SlideExportFormat format, string destFolder = null, int? width = null, int? height = null, int? from = null, int? to = null, string password = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PutPresentationSplit");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/split/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFolder", destFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "from", from);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "to", to);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeStreamApi<SplitDocumentResult>(resourcePath, "PUT", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Splits PowerPoint presentation slides from the specified range into separate files and exports them in the specified file format. If the range is not provided all slides will be processed.  
        /// </summary>
        /// <param name="request">Request. <see cref="PutPresentationSplitRequest" /></param> 
        /// <returns><see cref="SplitDocumentResult"/></returns>            
        [System.Obsolete("Use SplitAndSaveOnline method")]
        public SplitDocumentResult PutPresentationSplit(PutPresentationSplitRequest request)
        {
            return SplitAndSaveOnline(request.Document, request.Format, request.DestFolder, request.Width, request.Height, request.From, request.To, request.Password, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Update section name. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="sectionIndex">The position of the section to be updated.</param> 
        /// <param name="sectionName">Section name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Sections"/></returns>            
        public Sections UpdateSection(string name, int sectionIndex, string sectionName, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSection");
            }
            // verify the required parameter 'sectionName' is set
            if (sectionName == null)
            {
                throw new ApiException(400, "Missing required parameter 'sectionName' when calling PutSection");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/sections/{sectionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sectionIndex", sectionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sectionName", sectionName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Sections>(resourcePath, "PUT", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update section name. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSectionRequest" /></param> 
        /// <returns><see cref="Sections"/></returns>            
        [System.Obsolete("Use UpdateSection method")]
        public Sections PutSection(PutSectionRequest request)
        {
            return UpdateSection(request.Name, request.SectionIndex, request.SectionName, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Replace existing presentation sections with the ones provided in the sections DTO. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="sections">Sections DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Sections"/></returns>            
        public Sections SetSections(string name, Sections sections, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSections");
            }
            // verify the required parameter 'sections' is set
            if (sections == null)
            {
                throw new ApiException(400, "Missing required parameter 'sections' when calling PutSections");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/sections");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(sections); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Sections>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Replace existing presentation sections with the ones provided in the sections DTO. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSectionsRequest" /></param> 
        /// <returns><see cref="Sections"/></returns>            
        [System.Obsolete("Use SetSections method")]
        public Sections PutSections(PutSectionsRequest request)
        {
            return SetSections(request.Name, request.Sections, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update portion properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion UpdatePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, Portion dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSetParagraphPortionProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSetParagraphPortionProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update portion properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSetParagraphPortionPropertiesRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        [System.Obsolete("Use UpdatePortion method")]
        public Portion PutSetParagraphPortionProperties(PutSetParagraphPortionPropertiesRequest request)
        {
            return UpdatePortion(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.PortionIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update paragraph properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph UpdateParagraph(string name, int slideIndex, int shapeIndex, int paragraphIndex, Paragraph dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSetParagraphProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSetParagraphProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update paragraph properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSetParagraphPropertiesRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        [System.Obsolete("Use UpdateParagraph method")]
        public Paragraph PutSetParagraphProperties(PutSetParagraphPropertiesRequest request)
        {
            return UpdateParagraph(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update portion properties (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion UpdateSubshapePortion(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, int portionIndex, Portion dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSetSubshapeParagraphPortionProperties");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutSetSubshapeParagraphPortionProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSetSubshapeParagraphPortionProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update portion properties (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSetSubshapeParagraphPortionPropertiesRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        [System.Obsolete("Use UpdateSubshapePortion method")]
        public Portion PutSetSubshapeParagraphPortionProperties(PutSetSubshapeParagraphPortionPropertiesRequest request)
        {
            return UpdateSubshapePortion(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.ParagraphIndex, request.PortionIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update paragraph properties (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph UpdateSubshapeParagraph(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, Paragraph dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSetSubshapeParagraphProperties");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutSetSubshapeParagraphProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSetSubshapeParagraphProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update paragraph properties (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSetSubshapeParagraphPropertiesRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        [System.Obsolete("Use UpdateSubshapeParagraph method")]
        public Paragraph PutSetSubshapeParagraphProperties(PutSetSubshapeParagraphPropertiesRequest request)
        {
            return UpdateSubshapeParagraph(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.ParagraphIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="name">Presentation name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Index of shape starting from 1</param> 
        /// <param name="format">Export picture format.</param> 
        /// <param name="outPath">Output path.</param> 
        /// <param name="options">export options</param> 
        /// <param name="scaleX">X scale ratio.</param> 
        /// <param name="scaleY">Y scale ratio.</param> 
        /// <param name="bounds">Shape thumbnail bounds type.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Presentation folder.</param> 
        /// <param name="storage">Presentation storage.</param> 
        /// <param name="fontsFolder">Fonts folder.</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveShape(string name, int slideIndex, int shapeIndex, ShapeExportFormat format, string outPath, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutShapeSaveAs");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutShapeSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutShapeSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use SaveShape method")]
        public void PutShapeSaveAs(PutShapeSaveAsRequest request)
        {
            SaveShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Format, request.OutPath, request.Options, request.ScaleX, request.ScaleY, request.Bounds, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Set slide animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="animation">Animation DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation SetAnimation(string name, int slideIndex, SlideAnimation animation, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideAnimation");
            }
            // verify the required parameter 'animation' is set
            if (animation == null)
            {
                throw new ApiException(400, "Missing required parameter 'animation' when calling PutSlideAnimation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(animation); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set slide animation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideAnimationRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use SetAnimation method")]
        public SlideAnimation PutSlideAnimation(PutSlideAnimationRequest request)
        {
            return SetAnimation(request.Name, request.SlideIndex, request.Animation, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Modify an animation effect for a slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="effectIndex">The position of the effect to be modified.</param> 
        /// <param name="effect">Animation effect DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation UpdateAnimationEffect(string name, int slideIndex, int effectIndex, Effect effect, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideAnimationEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling PutSlideAnimationEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/mainSequence/{effectIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", effectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(effect); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Modify an animation effect for a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideAnimationEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use UpdateAnimationEffect method")]
        public SlideAnimation PutSlideAnimationEffect(PutSlideAnimationEffectRequest request)
        {
            return UpdateAnimationEffect(request.Name, request.SlideIndex, request.EffectIndex, request.Effect, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Modify an animation effect for a slide interactive sequence. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="sequenceIndex">The position of the interactive sequence.</param> 
        /// <param name="effectIndex">The position of the effect to be modified.</param> 
        /// <param name="effect">Animation effect DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation UpdateAnimationInteractiveSequenceEffect(string name, int slideIndex, int sequenceIndex, int effectIndex, Effect effect, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideAnimationInteractiveSequenceEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling PutSlideAnimationInteractiveSequenceEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation/interactiveSequences/{sequenceIndex}/{effectIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", sequenceIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", effectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(effect); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Modify an animation effect for a slide interactive sequence. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideAnimationInteractiveSequenceEffectRequest" /></param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        [System.Obsolete("Use UpdateAnimationInteractiveSequenceEffect method")]
        public SlideAnimation PutSlideAnimationInteractiveSequenceEffect(PutSlideAnimationInteractiveSequenceEffectRequest request)
        {
            return UpdateAnimationInteractiveSequenceEffect(request.Name, request.SlideIndex, request.SequenceIndex, request.EffectIndex, request.Effect, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Set footer the slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">The position of the slide to be reordered.</param> 
        /// <param name="dto">Footer to set.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="HeaderFooter"/></returns>            
        public HeaderFooter SetSlideHeaderFooter(string name, int slideIndex, HeaderFooter dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideHeaderFooter");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSlideHeaderFooter");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/headerFooter");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<HeaderFooter>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set footer the slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideHeaderFooterRequest" /></param> 
        /// <returns><see cref="HeaderFooter"/></returns>            
        [System.Obsolete("Use SetSlideHeaderFooter method")]
        public HeaderFooter PutSlideHeaderFooter(PutSlideHeaderFooterRequest request)
        {
            return SetSlideHeaderFooter(request.Name, request.SlideIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="outPath">Path to upload the output file to.</param> 
        /// <param name="options">Export options.</param> 
        /// <param name="width">Output file width; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="height">Output file height; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveSlide(string name, int slideIndex, SlideExportFormat format, string outPath, ExportOptions options = null, int? width = null, int? height = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideSaveAs");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutSlideSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use SaveSlide method")]
        public void PutSlideSaveAs(PutSlideSaveAsRequest request)
        {
            SaveSlide(request.Name, request.SlideIndex, request.Format, request.OutPath, request.Options, request.Width, request.Height, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Update shape properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase UpdateShape(string name, int slideIndex, int shapeIndex, ShapeBase dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideShapeInfo");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSlideShapeInfo");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideShapeInfoRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        [System.Obsolete("Use UpdateShape method")]
        public ShapeBase PutSlideShapeInfo(PutSlideShapeInfoRequest request)
        {
            return UpdateShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update shape properties (for smart art and group shapes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase UpdateSubshape(string name, int slideIndex, string path, int shapeIndex, ShapeBase dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlideSubshapeInfo");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutSlideSubshapeInfo");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSlideSubshapeInfo");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update shape properties (for smart art and group shapes). 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlideSubshapeInfoRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        [System.Obsolete("Use UpdateSubshape method")]
        public ShapeBase PutSlideSubshapeInfo(PutSlideSubshapeInfoRequest request)
        {
            return UpdateSubshape(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Convert presentation from request content to format specified. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="format">Export format.</param> 
        /// <param name="outPath">Path to save result.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref=""/></returns>            
        public void ConvertAndSave(System.IO.Stream document, ExportFormat format, string outPath, string password = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PutSlidesConvert");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutSlidesConvert");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/convert/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            InvokeVoidStreamApi(resourcePath, "PUT", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Convert presentation from request content to format specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesConvertRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use ConvertAndSave method")]
        public void PutSlidesConvert(PutSlidesConvertRequest request)
        {
            ConvertAndSave(request.Document, request.Format, request.OutPath, request.Password, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Set footers for all slides in a presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="dto">HeaderFooter instance.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document SetPresentationHeaderFooter(string name, HeaderFooter dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesHeaderFooter");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSlidesHeaderFooter");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/headerFooter");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Document>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set footers for all slides in a presentation. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesHeaderFooterRequest" /></param> 
        /// <returns><see cref="Document"/></returns>            
        [System.Obsolete("Use SetPresentationHeaderFooter method")]
        public Document PutSlidesHeaderFooter(PutSlidesHeaderFooterRequest request)
        {
            return SetPresentationHeaderFooter(request.Name, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Merges the presentation with other presentations or some of their slides specified in the request parameter. Puts result in the storage.  
        /// </summary>
        /// <param name="outPath">Path to save result.</param> 
        /// <param name="files">Files to merge</param> 
        /// <param name="request">Merge request.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref=""/></returns>            
        public void MergeAndSaveOnline(string outPath, List<FileInfo> files = null, OrderedMergeRequest request = null, string password = null, string storage = null)
        {
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutSlidesMerge");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/merge");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (files != null) 
            {
                requestFiles.AddRange(files);
            }
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Merges the presentation with other presentations or some of their slides specified in the request parameter. Puts result in the storage.  
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesMergeRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use MergeAndSaveOnline method")]
        public void PutSlidesMerge(PutSlidesMergeRequest request)
        {
            MergeAndSaveOnline(request.OutPath, request.Files, request.Request, request.Password, request.Storage);
        }

        /// <summary>
        /// Updates presentation protection properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="dto">Protection properties.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ProtectionProperties"/></returns>            
        public ProtectionProperties SetProtection(string name, ProtectionProperties dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesProtectionProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSlidesProtectionProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/protection");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ProtectionProperties>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Updates presentation protection properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesProtectionPropertiesRequest" /></param> 
        /// <returns><see cref="ProtectionProperties"/></returns>            
        [System.Obsolete("Use SetProtection method")]
        public ProtectionProperties PutSlidesProtectionProperties(PutSlidesProtectionPropertiesRequest request)
        {
            return SetProtection(request.Name, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Sets presentation protection options.  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="dto">Protection properties.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream SetProtectionOnline(System.IO.Stream document, ProtectionProperties dto, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PutSlidesProtectionPropertiesOnline");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSlidesProtectionPropertiesOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/protection");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Sets presentation protection options.  
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesProtectionPropertiesOnlineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        [System.Obsolete("Use SetProtectionOnline method")]
        public System.IO.Stream PutSlidesProtectionPropertiesOnline(PutSlidesProtectionPropertiesOnlineRequest request)
        {
            return SetProtectionOnline(request.Document, request.Dto, request.Password);
        }

        /// <summary>
        /// Save a presentation to a specified format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="format">Export format.</param> 
        /// <param name="outPath">Output path.</param> 
        /// <param name="options">Export options.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref=""/></returns>            
        public void SavePresentation(string name, ExportFormat format, string outPath, ExportOptions options = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSaveAs");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutSlidesSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Save a presentation to a specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use SavePresentation method")]
        public void PutSlidesSaveAs(PutSlidesSaveAsRequest request)
        {
            SavePresentation(request.Name, request.Format, request.OutPath, request.Options, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Set document property. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="propertyName">The property name.</param> 
        /// <param name="property">Property with the value.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="DocumentProperty"/></returns>            
        public DocumentProperty SetDocumentProperty(string name, string propertyName, DocumentProperty property, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSetDocumentProperty");
            }
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PutSlidesSetDocumentProperty");
            }
            // verify the required parameter 'property' is set
            if (property == null)
            {
                throw new ApiException(400, "Missing required parameter 'property' when calling PutSlidesSetDocumentProperty");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/documentproperties/{propertyName}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", propertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(property); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<DocumentProperty>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSetDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentProperty"/></returns>            
        [System.Obsolete("Use SetDocumentProperty method")]
        public DocumentProperty PutSlidesSetDocumentProperty(PutSlidesSetDocumentPropertyRequest request)
        {
            return SetDocumentProperty(request.Name, request.PropertyName, request.Property, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update a slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="slideDto">Slide update data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Slide"/></returns>            
        public Slide UpdateSlide(string name, int slideIndex, Slide slideDto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSlide");
            }
            // verify the required parameter 'slideDto' is set
            if (slideDto == null)
            {
                throw new ApiException(400, "Missing required parameter 'slideDto' when calling PutSlidesSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(slideDto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Slide>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideRequest" /></param> 
        /// <returns><see cref="Slide"/></returns>            
        [System.Obsolete("Use UpdateSlide method")]
        public Slide PutSlidesSlide(PutSlidesSlideRequest request)
        {
            return UpdateSlide(request.Name, request.SlideIndex, request.SlideDto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Set background for a slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="background">Slide background update data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        public SlideBackground SetBackground(string name, int slideIndex, SlideBackground background, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSlideBackground");
            }
            // verify the required parameter 'background' is set
            if (background == null)
            {
                throw new ApiException(400, "Missing required parameter 'background' when calling PutSlidesSlideBackground");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/background");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(background); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideBackground>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set background for a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideBackgroundRequest" /></param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        [System.Obsolete("Use SetBackground method")]
        public SlideBackground PutSlidesSlideBackground(PutSlidesSlideBackgroundRequest request)
        {
            return SetBackground(request.Name, request.SlideIndex, request.Background, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Set background color for a slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="color">Slide background target color in RRGGBB format.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        public SlideBackground SetBackgroundColor(string name, int slideIndex, string color, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSlideBackgroundColor");
            }
            // verify the required parameter 'color' is set
            if (color == null)
            {
                throw new ApiException(400, "Missing required parameter 'color' when calling PutSlidesSlideBackgroundColor");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/backgroundColor");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "color", color);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideBackground>(resourcePath, "PUT", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set background color for a slide. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlideBackgroundColorRequest" /></param> 
        /// <returns><see cref="SlideBackground"/></returns>            
        [System.Obsolete("Use SetBackgroundColor method")]
        public SlideBackground PutSlidesSlideBackgroundColor(PutSlidesSlideBackgroundColorRequest request)
        {
            return SetBackgroundColor(request.Name, request.SlideIndex, request.Color, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update presentation slide properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="dto">The view properties data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideProperties"/></returns>            
        public SlideProperties SetSlideProperties(string name, SlideProperties dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesSlideProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSlidesSlideProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slideProperties");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideProperties>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update presentation slide properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesSlidePropertiesRequest" /></param> 
        /// <returns><see cref="SlideProperties"/></returns>            
        [System.Obsolete("Use SetSlideProperties method")]
        public SlideProperties PutSlidesSlideProperties(PutSlidesSlidePropertiesRequest request)
        {
            return SetSlideProperties(request.Name, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update presentation document properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="dto">The view properties data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ViewProperties"/></returns>            
        public ViewProperties SetViewProperties(string name, ViewProperties dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSlidesViewProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutSlidesViewProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/viewProperties");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ViewProperties>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update presentation document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSlidesViewPropertiesRequest" /></param> 
        /// <returns><see cref="ViewProperties"/></returns>            
        [System.Obsolete("Use SetViewProperties method")]
        public ViewProperties PutSlidesViewProperties(PutSlidesViewPropertiesRequest request)
        {
            return SetViewProperties(request.Name, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="name">Presentation name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="path">Shape path (for smart art and group shapes).</param> 
        /// <param name="shapeIndex">Index of shape starting from 1</param> 
        /// <param name="format">Export picture format.</param> 
        /// <param name="outPath">Output path.</param> 
        /// <param name="options">export options</param> 
        /// <param name="scaleX">X scale ratio.</param> 
        /// <param name="scaleY">Y scale ratio.</param> 
        /// <param name="bounds">Shape thumbnail bounds type.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Presentation folder.</param> 
        /// <param name="storage">Presentation storage.</param> 
        /// <param name="fontsFolder">Fonts folder.</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveSubshape(string name, int slideIndex, string path, int shapeIndex, ShapeExportFormat format, string outPath, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutSubshapeSaveAs");
            }
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling PutSubshapeSaveAs");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling PutSubshapeSaveAs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{path}/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutSubshapeSaveAsRequest" /></param> 
        /// <returns><see cref=""/></returns>            
        [System.Obsolete("Use SaveSubshape method")]
        public void PutSubshapeSaveAs(PutSubshapeSaveAsRequest request)
        {
            SaveSubshape(request.Name, request.SlideIndex, request.Path, request.ShapeIndex, request.Format, request.OutPath, request.Options, request.ScaleX, request.ScaleY, request.Bounds, request.Password, request.Folder, request.Storage, request.FontsFolder);
        }

        /// <summary>
        /// Update notes slide properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="dto">A NotesSlide object with notes slide data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        public NotesSlide UpdateNotesSlide(string name, int slideIndex, NotesSlide dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlide");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutUpdateNotesSlide");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<NotesSlide>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update notes slide properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideRequest" /></param> 
        /// <returns><see cref="NotesSlide"/></returns>            
        [System.Obsolete("Use UpdateNotesSlide method")]
        public NotesSlide PutUpdateNotesSlide(PutUpdateNotesSlideRequest request)
        {
            return UpdateNotesSlide(request.Name, request.SlideIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update shape properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase UpdateNotesSlideShape(string name, int slideIndex, int shapeIndex, ShapeBase dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlideShape");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutUpdateNotesSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update shape properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideShapeRequest" /></param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        [System.Obsolete("Use UpdateNotesSlideShape method")]
        public ShapeBase PutUpdateNotesSlideShape(PutUpdateNotesSlideShapeRequest request)
        {
            return UpdateNotesSlideShape(request.Name, request.SlideIndex, request.ShapeIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update paragraph properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph UpdateNotesSlideParagraph(string name, int slideIndex, int shapeIndex, int paragraphIndex, Paragraph dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlideShapeParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutUpdateNotesSlideShapeParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update paragraph properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideShapeParagraphRequest" /></param> 
        /// <returns><see cref="Paragraph"/></returns>            
        [System.Obsolete("Use UpdateNotesSlideParagraph method")]
        public Paragraph PutUpdateNotesSlideShapeParagraph(PutUpdateNotesSlideShapeParagraphRequest request)
        {
            return UpdateNotesSlideParagraph(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Update portion properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion UpdateNotesSlidePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, Portion dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateNotesSlideShapePortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling PutUpdateNotesSlideShapePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/notesSlide/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update portion properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutUpdateNotesSlideShapePortionRequest" /></param> 
        /// <returns><see cref="Portion"/></returns>            
        [System.Obsolete("Use UpdateNotesSlidePortion method")]
        public Portion PutUpdateNotesSlideShapePortion(PutUpdateNotesSlideShapePortionRequest request)
        {
            return UpdateNotesSlidePortion(request.Name, request.SlideIndex, request.ShapeIndex, request.ParagraphIndex, request.PortionIndex, request.Dto, request.Password, request.Folder, request.Storage);
        }

        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <param name="storageName">Storage name</param> 
        /// <returns><see cref="StorageExist"/></returns>            
        public StorageExist StorageExists(string storageName)
        {
            // verify the required parameter 'storageName' is set
            if (storageName == null)
            {
                throw new ApiException(400, "Missing required parameter 'storageName' when calling StorageExists");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/{storageName}/exist");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", storageName);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<StorageExist>(resourcePath, "GET", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param> 
        /// <returns><see cref="StorageExist"/></returns>            
        [System.Obsolete("Use StorageExists method")]
        public StorageExist StorageExists(StorageExistsRequest request)
        {
            return StorageExists(request.StorageName);
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="path">Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.             </param> 
        /// <param name="file">File to upload</param> 
        /// <param name="storageName">Storage name</param> 
        /// <returns><see cref="FilesUploadResult"/></returns>            
        public FilesUploadResult UploadFile(string path, System.IO.Stream file, string storageName = null)
        {
            // verify the required parameter 'path' is set
            if (path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling UploadFile");
            }
            // verify the required parameter 'file' is set
            if (file == null)
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling UploadFile");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/storage/file/{path}");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", storageName);
            var requestFiles = new List<FileInfo>();
            if (file != null) 
            {
                requestFiles.Add(new FileInfo { Name = "file", Content = file });
            }
            return InvokeStreamApi<FilesUploadResult>(resourcePath, "PUT", null, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param> 
        /// <returns><see cref="FilesUploadResult"/></returns>            
        [System.Obsolete("Use UploadFile method")]
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
            return UploadFile(request.Path, request.File, request.StorageName);
        }
    }
}