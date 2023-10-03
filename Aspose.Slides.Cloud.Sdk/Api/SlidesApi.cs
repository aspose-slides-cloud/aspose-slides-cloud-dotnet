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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes AlignShapes(string name, int slideIndex, ShapesAlignmentType alignmentType, bool? alignToSlide = null, List<int> shapes = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AlignShapes");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Changes the placement of selected shapes on the master slide. Aligns shapes to the margins or the edge of the slide or aligns them relative to each other. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="alignmentType">Alignment type that will be applied to the shapes.</param> 
        /// <param name="alignToSlide">If true, shapes will be aligned relative to the slide edges.</param> 
        /// <param name="shapes">Shapes indexes.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes AlignSpecialSlideShapes(string name, int slideIndex, SpecialSlideType slideType, ShapesAlignmentType alignmentType, bool? alignToSlide = null, List<int> shapes = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AlignSpecialSlideShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/align/{alignmentType}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "alignmentType", alignmentType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "alignToSlide", alignToSlide);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Compresses embedded fonts by removing unused characters. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref=""/></returns>            
        public void CompressEmbeddedFonts(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CompressEmbeddedFonts");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fonts/embedded/compress");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Compresses embedded fonts by removing unused characters. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CompressEmbeddedFontsOnline(System.IO.Stream document, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling CompressEmbeddedFontsOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/fonts/embedded/compress");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Convert presentation from request content to format specified. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="format">Export format.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <param name="slides">The indices of the slides to be converted. If not specified, all slides are converted by default.</param> 
        /// <param name="options">Export options.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream Convert(System.IO.Stream document, ExportFormat format, string password = null, string storage = null, string fontsFolder = null, List<int> slides = null, ExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling Convert");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/convert/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", slides);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
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
        /// <param name="slides">The indices of the slides to be converted. If not specified, all slides are converted by default.</param> 
        /// <param name="options">Export options.</param> 
        /// <returns><see cref=""/></returns>            
        public void ConvertAndSave(System.IO.Stream document, ExportFormat format, string outPath, string password = null, string storage = null, string fontsFolder = null, List<int> slides = null, ExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling ConvertAndSave");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling ConvertAndSave");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/convert/{format}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", slides);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CopyLayoutSlide");
            }
            // verify the required parameter 'cloneFrom' is set
            if (cloneFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'cloneFrom' when calling CopyLayoutSlide");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CopyMasterSlide");
            }
            // verify the required parameter 'cloneFrom' is set
            if (cloneFrom == null)
            {
                throw new ApiException(400, "Missing required parameter 'cloneFrom' when calling CopyMasterSlide");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CopySlide");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateAnimationEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling CreateAnimationEffect");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateAnimationInteractiveSequence");
            }
            // verify the required parameter 'sequence' is set
            if (sequence == null)
            {
                throw new ApiException(400, "Missing required parameter 'sequence' when calling CreateAnimationInteractiveSequence");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateAnimationInteractiveSequenceEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling CreateAnimationInteractiveSequenceEffect");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateChartCategory");
            }
            // verify the required parameter 'category' is set
            if (category == null)
            {
                throw new ApiException(400, "Missing required parameter 'category' when calling CreateChartCategory");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateChartDataPoint");
            }
            // verify the required parameter 'dataPoint' is set
            if (dataPoint == null)
            {
                throw new ApiException(400, "Missing required parameter 'dataPoint' when calling CreateChartDataPoint");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateChartSeries");
            }
            // verify the required parameter 'series' is set
            if (series == null)
            {
                throw new ApiException(400, "Missing required parameter 'series' when calling CreateChartSeries");
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
        /// Adds the comment on the slide. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="dto">Comment DTO.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideComments"/></returns>            
        public SlideComments CreateComment(string name, int slideIndex, SlideCommentBase dto, int? shapeIndex = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateComment");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateComment");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/comments");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideComments>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Adds the comment on the slide. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="dto">Comment DTO.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream CreateCommentOnline(System.IO.Stream document, int slideIndex, SlideCommentBase dto, int? shapeIndex = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling CreateCommentOnline");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateCommentOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/comments");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeIndex", shapeIndex);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateImageWatermark");
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
                throw new ApiException(400, "Missing required parameter 'document' when calling CreateImageWatermarkOnline");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateNotesSlide");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateNotesSlide");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph CreateParagraph(string name, int slideIndex, int shapeIndex, Paragraph dto, int? position = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateParagraph");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion CreatePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, Portion dto, int? position = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreatePortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreatePortion");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create a presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="data">Source presentation binary data.</param> 
        /// <param name="inputPassword">The password for source presentation.</param> 
        /// <param name="password">The document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document CreatePresentation(string name, System.IO.Stream data = null, string inputPassword = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreatePresentation");
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
            return InvokeApi<Document>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create a presentation from an existing source. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="sourcePath">Source file path.</param> 
        /// <param name="sourcePassword">Source file password.</param> 
        /// <param name="sourceStorage">Source storage name.</param> 
        /// <param name="password">The document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document CreatePresentationFromSource(string name, string sourcePath = null, string sourcePassword = null, string sourceStorage = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreatePresentationFromSource");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreatePresentationFromTemplate");
            }
            // verify the required parameter 'templatePath' is set
            if (templatePath == null)
            {
                throw new ApiException(400, "Missing required parameter 'templatePath' when calling CreatePresentationFromTemplate");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateSection");
            }
            // verify the required parameter 'sectionName' is set
            if (sectionName == null)
            {
                throw new ApiException(400, "Missing required parameter 'sectionName' when calling CreateSection");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase CreateShape(string name, int slideIndex, ShapeBase dto = null, int? shapeToClone = null, int? position = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateShape");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateSlide");
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
        /// Add SmartArt node 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="smartArtIndex">Index of the object on the slide among the same type of objects.</param> 
        /// <param name="subNode">Sub-node path (e.g. \"3\", \"3/nodes/2).</param> 
        /// <param name="text">Node text.</param> 
        /// <param name="position">Position to insert a new node.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SmartArt"/></returns>            
        public SmartArt CreateSmartArtNode(string name, int slideIndex, int smartArtIndex, string subNode = null, string text = null, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateSmartArtNode");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/smartArts/{smartArtIndex}/nodes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "smartArtIndex", smartArtIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subNode", subNode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "text", text);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SmartArt>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Add an effect to special slide (master, layout, notes) animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="effect">Animation effect DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation CreateSpecialSlideAnimationEffect(string name, int slideIndex, SpecialSlideType slideType, Effect effect, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateSpecialSlideAnimationEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling CreateSpecialSlideAnimationEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/mainSequence");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(effect); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set special slide (master, layout, notes) animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="sequence">Animation sequence DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation CreateSpecialSlideAnimationInteractiveSequence(string name, int slideIndex, SpecialSlideType slideType, InteractiveSequence sequence, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateSpecialSlideAnimationInteractiveSequence");
            }
            // verify the required parameter 'sequence' is set
            if (sequence == null)
            {
                throw new ApiException(400, "Missing required parameter 'sequence' when calling CreateSpecialSlideAnimationInteractiveSequence");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/interactiveSequences");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(sequence); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Add an animation effect to a special slide (master, layout, notes) interactive sequence. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="sequenceIndex">The position of the interactive sequence.</param> 
        /// <param name="effect">Animation effect DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation CreateSpecialSlideAnimationInteractiveSequenceEffect(string name, int slideIndex, SpecialSlideType slideType, int sequenceIndex, Effect effect, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateSpecialSlideAnimationInteractiveSequenceEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling CreateSpecialSlideAnimationInteractiveSequenceEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/interactiveSequences/{sequenceIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", sequenceIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(effect); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates new paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="position">Position of the new paragraph in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph CreateSpecialSlideParagraph(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, Paragraph dto, int? position = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateSpecialSlideParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateSpecialSlideParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates new portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="position">Position of the new portion in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion CreateSpecialSlidePortion(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, int paragraphIndex, Portion dto, int? position = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateSpecialSlidePortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateSpecialSlidePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Create new shape. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <param name="shapeToClone">Optional index for clone shape instead of adding a new one.</param> 
        /// <param name="position">Position of the new shape in the list. Default is at the end of the list.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase CreateSpecialSlideShape(string name, int slideIndex, SpecialSlideType slideType, ShapeBase dto, int? shapeToClone = null, int? position = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateSpecialSlideShape");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateSpecialSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeToClone", shapeToClone);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "position", position);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates table cell paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph CreateTableCellParagraph(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, Paragraph dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateTableCellParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateTableCellParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates table cell portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion CreateTableCellPortion(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, int paragraphIndex, Portion dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateTableCellPortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateTableCellPortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Inserts the table row in the specified position. If position is not specified, the row add to the end of the table. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Table row data.</param> 
        /// <param name="position">Position.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="TableRow"/></returns>            
        public TableRow CreateTableRow(string name, int slideIndex, int shapeIndex, TableRow dto, int? position = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateTableRow");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling CreateTableRow");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows");
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
            return InvokeApi<TableRow>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Append module to VBA project              
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="moduleDto">VBA module DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="VbaModule"/></returns>            
        public VbaModule CreateVbaModule(string name, VbaModule moduleDto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateVbaModule");
            }
            // verify the required parameter 'moduleDto' is set
            if (moduleDto == null)
            {
                throw new ApiException(400, "Missing required parameter 'moduleDto' when calling CreateVbaModule");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/vbaProject/modules");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(moduleDto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<VbaModule>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateWatermark");
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
                throw new ApiException(400, "Missing required parameter 'document' when calling CreateWatermarkOnline");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAnimation");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAnimationEffect");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAnimationInteractiveSequence");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAnimationInteractiveSequenceEffect");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAnimationInteractiveSequences");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteAnimationMainSequence");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBackground");
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
        /// Removes comments of the specified author from the presentation. If author value is not provided all comments will be removed.  
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="author">Author of comments.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref=""/></returns>            
        public void DeleteComments(string name, string author = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteComments");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/comments");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "author", author);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Removes comments of the specified author from the presentation. If author value is not provided all comments will be removed.  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="author">Author of comments.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteCommentsOnline(System.IO.Stream document, string author = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DeleteCommentsOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/comments/delete");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "author", author);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentProperties");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentProperty");
            }
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling DeleteDocumentProperty");
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
        /// Removes specified embedded font and returns presentation fonts info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="fontName">Font name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="FontsData"/></returns>            
        public FontsData DeleteEmbeddedFont(string name, string fontName, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteEmbeddedFont");
            }
            // verify the required parameter 'fontName' is set
            if (fontName == null)
            {
                throw new ApiException(400, "Missing required parameter 'fontName' when calling DeleteEmbeddedFont");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fonts/embedded/{fontName}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fontName", fontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<FontsData>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Removes specified embedded font and returns presentation. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="fontName">Font name.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteEmbeddedFontOnline(System.IO.Stream document, string fontName, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DeleteEmbeddedFontOnline");
            }
            // verify the required parameter 'fontName' is set
            if (fontName == null)
            {
                throw new ApiException(400, "Missing required parameter 'fontName' when calling DeleteEmbeddedFontOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/fonts/embedded/{fontName}/delete");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fontName", fontName);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
        /// Remove a paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteParagraph(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null, string subShape = null)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of paragraphs. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphs">The indices of the paragraphs to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteParagraphs(string name, int slideIndex, int shapeIndex, List<int> paragraphs = null, string password = null, string folder = null, string storage = null, string subShape = null)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeletePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null, string subShape = null)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of portions. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portions">The indices of the portions to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeletePortions(string name, int slideIndex, int shapeIndex, int paragraphIndex, List<int> portions = null, string password = null, string folder = null, string storage = null, string subShape = null)
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteProtection");
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
        /// <param name="document">Document data.</param> 
        /// <param name="password">Presentation password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteProtectionOnline(System.IO.Stream document, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DeleteProtectionOnline");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
        /// Remove a shape. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteShape(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteShapes(string name, int slideIndex, List<int> shapes = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlide");
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
        /// Removes comments of the specified author from the slide. If author value is not provided all comments will be removed.  
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="author">Author of comments.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideComments"/></returns>            
        public SlideComments DeleteSlideComments(string name, int slideIndex, string author = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlideComments");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/comments");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "author", author);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideComments>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Removes comments of the specified author from the slide. If author value is not provided all comments will be removed.               
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex"></param> 
        /// <param name="author">Author of comments.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteSlideCommentsOnline(System.IO.Stream document, int slideIndex, string author = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DeleteSlideCommentsOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/slides/{slideIndex}/comments/delete");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "author", author);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSlides");
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
        /// Delete SmartArt node 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="smartArtIndex">Index of the object on the slide among the same type of objects.</param> 
        /// <param name="nodeIndex">Root level node index.</param> 
        /// <param name="subNode">Sub-node path (e.g. \"3\", \"3/nodes/2).</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SmartArt"/></returns>            
        public SmartArt DeleteSmartArtNode(string name, int slideIndex, int smartArtIndex, int nodeIndex, string subNode = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSmartArtNode");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/smartArts/{smartArtIndex}/nodes/{nodeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "smartArtIndex", smartArtIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "nodeIndex", nodeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subNode", subNode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SmartArt>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove animation from a special slide (master, layout, notes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSpecialSlideAnimation(string name, int slideIndex, SpecialSlideType slideType, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideAnimation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove an effect from special slide (master, layout, notes) animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="effectIndex">Index of the effect to be removed.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSpecialSlideAnimationEffect(string name, int slideIndex, SpecialSlideType slideType, int effectIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideAnimationEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/mainSequence/{effectIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", effectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove an interactive sequence from special slide (master, layout, notes) animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="sequenceIndex">The index of an interactive sequence to be deleted.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSpecialSlideAnimationInteractiveSequence(string name, int slideIndex, SpecialSlideType slideType, int sequenceIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideAnimationInteractiveSequence");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/interactiveSequences/{sequenceIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", sequenceIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove an effect from special slide (master, layout, notes) animation interactive sequence. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="sequenceIndex">Interactive sequence index.</param> 
        /// <param name="effectIndex">Index of the effect to be removed.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSpecialSlideAnimationInteractiveSequenceEffect(string name, int slideIndex, SpecialSlideType slideType, int sequenceIndex, int effectIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideAnimationInteractiveSequenceEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/interactiveSequences/{sequenceIndex}/{effectIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sequenceIndex", sequenceIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", effectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Clear all interactive sequences from special slide (master, layout, notes) animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSpecialSlideAnimationInteractiveSequences(string name, int slideIndex, SpecialSlideType slideType, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideAnimationInteractiveSequences");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/interactiveSequences");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Clear main sequence in special slide (master, layout, notes) animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation DeleteSpecialSlideAnimationMainSequence(string name, int slideIndex, SpecialSlideType slideType, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideAnimationMainSequence");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/mainSequence");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteSpecialSlideParagraph(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of paragraphs. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphs">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteSpecialSlideParagraphs(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, List<int> paragraphs = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphs", paragraphs);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteSpecialSlidePortion(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlidePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of portions. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portions">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteSpecialSlidePortions(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, int paragraphIndex, List<int> portions = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlidePortions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "portions", portions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a shape. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteSpecialSlideShape(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Remove a range of shapes. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapes">The indices of the shapes to be deleted; delete all by default.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes DeleteSpecialSlideShapes(string name, int slideIndex, SpecialSlideType slideType, List<int> shapes = null, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteSpecialSlideShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete cell paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs DeleteTableCellParagraph(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableCellParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete table ell portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions DeleteTableCellPortion(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableCellPortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Deletes the table row. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="withAttachedRows">Also delete all attached rows.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Table"/></returns>            
        public Table DeleteTableRow(string name, int slideIndex, int shapeIndex, int rowIndex, bool? withAttachedRows = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableRow");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withAttachedRows", withAttachedRows);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Table>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Removes unused layout slides. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="LayoutSlides"/></returns>            
        public LayoutSlides DeleteUnusedLayoutSlides(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteUnusedLayoutSlides");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/layoutSlides");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<LayoutSlides>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Removes unused layout slides. 
        /// </summary>
        /// <param name="document">Document data</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteUnusedLayoutSlidesOnline(System.IO.Stream document, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DeleteUnusedLayoutSlidesOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/layoutSlides/delete");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Removes unused master slides. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="ignorePreserveField">Determines, whether this method should remove unused master even if its             preserve property is set to true.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="MasterSlides"/></returns>            
        public MasterSlides DeleteUnusedMasterSlides(string name, bool? ignorePreserveField = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteUnusedMasterSlides");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/masterSlides");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignorePreserveField", ignorePreserveField);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<MasterSlides>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Removes unused master slides. 
        /// </summary>
        /// <param name="document">Document data</param> 
        /// <param name="ignorePreserveField">Determines, whether this method should remove unused master even if its             preserve property is set to true.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteUnusedMasterSlidesOnline(System.IO.Stream document, bool? ignorePreserveField = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DeleteUnusedMasterSlidesOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/masterSlides/delete");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignorePreserveField", ignorePreserveField);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Delete module from VBA project. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="moduleIndex">The index of the macros module to remove.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="VbaProject"/></returns>            
        public VbaProject DeleteVbaModule(string name, int moduleIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteVbaModule");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/vbaProject/modules/{moduleIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "moduleIndex", moduleIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<VbaProject>(resourcePath, "DELETE", null, headerParams, requestFiles, "application/json");
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
        /// <param name="document">Document data.</param> 
        /// <param name="shapeName">Name of the watermark shape. If null, default value \"watermark\"is used.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeleteWatermarkOnline(System.IO.Stream document, string shapeName = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DeleteWatermarkOnline");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadImage");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadImageDefaultFormat");
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
        /// <param name="document">Document data.</param> 
        /// <param name="index">Image index.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImageDefaultFormatOnline(System.IO.Stream document, int index, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DownloadImageDefaultFormatOnline");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'document' when calling DownloadImageOnline");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadImages");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadImagesDefaultFormat");
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
        /// <param name="document">Document data.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadImagesDefaultFormatOnline(System.IO.Stream document, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DownloadImagesDefaultFormatOnline");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'document' when calling DownloadImagesOnline");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Convert notes slide to the specified image format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="width">The width of the slide representation in the output format.</param> 
        /// <param name="height">The height of the slide representation in the output format</param> 
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadNotesSlide");
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
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="width">The width of the slide representation in the output format.</param> 
        /// <param name="height">The height of the slide representation in the output format.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadNotesSlideOnline(System.IO.Stream document, int slideIndex, NotesSlideExportFormat format, int? width = null, int? height = null, string password = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DownloadNotesSlideOnline");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Convert Mathematical Text to MathML Format 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadPortionAsMathMl(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadPortionAsMathMl");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}/mathml");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
        /// <param name="slides">The indices of the slides to be saved. If not specified, all slides are saved by default.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadPresentation(string name, ExportFormat format, ExportOptions options = null, string password = null, string folder = null, string storage = null, string fontsFolder = null, List<int> slides = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadPresentation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", slides);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadShape(string name, int slideIndex, int shapeIndex, ShapeExportFormat format, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadShape");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Creates the shape from the DTO and returns the result in the specified format. 
        /// </summary>
        /// <param name="format">Export format</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadShapeFromDto(ShapeExportFormat format, ShapeBase dto)
        {
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling DownloadShapeFromDto");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/shape/{format}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, requestFiles, "application/json");
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
        /// <param name="options">Export options.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadShapeOnline(System.IO.Stream document, int slideIndex, int shapeIndex, ShapeExportFormat format, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string storage = null, string fontsFolder = null, IShapeExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DownloadShapeOnline");
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
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="options">Export options.</param> 
        /// <param name="width">The width of the slide representation in the output format; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="height">The height of the slide representation in the output format; 0 to not adjust the size. Default is 0.</param> 
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
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadSlide");
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
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="width">The width of the slide representation in the output format; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="height">The height of the slide representation in the output format; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param> 
        /// <param name="options">Export options.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadSlideOnline(System.IO.Stream document, int slideIndex, SlideExportFormat format, int? width = null, int? height = null, string password = null, string storage = null, string fontsFolder = null, ExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling DownloadSlideOnline");
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
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="name">Presentation name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Index of shape starting from 1</param> 
        /// <param name="format">Export picture format.</param> 
        /// <param name="options">Export options</param> 
        /// <param name="scaleX">X scale ratio.</param> 
        /// <param name="scaleY">Y scale ratio.</param> 
        /// <param name="bounds">Shape thumbnail bounds type.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Presentation folder.</param> 
        /// <param name="storage">Presentation storage.</param> 
        /// <param name="fontsFolder">Fonts folder.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadSpecialSlideShape(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, ShapeExportFormat format, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DownloadSpecialSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide animation effects. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index. If specified, only effects related to that shape are returned.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation GetAnimation(string name, int slideIndex, int? shapeIndex = null, int? paragraphIndex = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetAnimation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/animation");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBackground");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetColorScheme");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperties");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperty");
            }
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling GetDocumentProperty");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFontScheme");
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
        /// Returns presentation fonts info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="FontsData"/></returns>            
        public FontsData GetFonts(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFonts");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fonts");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<FontsData>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Returns presentation fonts info. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="FontsData"/></returns>            
        public FontsData GetFontsOnline(System.IO.Stream document, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling GetFontsOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/fonts");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeApi<FontsData>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormatScheme");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetLayoutSlides");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetMasterSlides");
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
                throw new ApiException(400, "Missing required parameter 'document' when calling GetNotesSlideOnline");
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
            return InvokeApi<NotesSlide>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetParagraph(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraph");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read effective paragraph info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetParagraphEffective(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphEffective");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/effective");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Return coordinates of rect that bounds paragraph. The rect includes all the lines of text in paragraph, including empty ones. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="TextBounds"/></returns>            
        public TextBounds GetParagraphRectangle(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphRectangle");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/bounds");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<TextBounds>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs GetParagraphs(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPlaceholder");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPlaceholders");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetPortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPortion");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read effective portion info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetPortionEffective(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPortionEffective");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}/effective");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Return coordinates of rect that bounds paragraph. The rect includes all the lines of text in paragraph, including empty ones. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="TextBounds"/></returns>            
        public TextBounds GetPortionRectangle(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPortionRectangle");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}/bounds");
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
            return InvokeApi<TextBounds>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions GetPortions(string name, int slideIndex, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPortions");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPresentation");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPresentationImages");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPresentationTextItems");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetProtectionProperties");
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
        /// Read slide shape info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase GetShape(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Returns geometry path of the shape 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="GeometryPaths"/></returns>            
        public GeometryPaths GetShapeGeometryPath(string name, int slideIndex, int shapeIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetShapeGeometryPath");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/geometryPath");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<GeometryPaths>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read slide shapes info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="shapeType">Shape type.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes GetShapes(string name, int slideIndex, string password = null, string folder = null, string storage = null, ShapeType? shapeType = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeType", shapeType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlide");
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
        /// Read presentation slide comments. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideComments"/></returns>            
        public SlideComments GetSlideComments(string name, int slideIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideComments");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideImages");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideProperties");
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
        /// Read presentation slide show properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideShowProperties"/></returns>            
        public SlideShowProperties GetSlideShowProperties(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideShowProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slideShowProperties");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideShowProperties>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlideTextItems");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlides");
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
        /// Read special slide (master, layout, notes) animation effects. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index. If specified, only effects related to that shape are returned.</param> 
        /// <param name="paragraphIndex">Paragraph index. If specified, only effects related to that paragraph are returned.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation GetSpecialSlideAnimation(string name, int slideIndex, SpecialSlideType slideType, int? shapeIndex = null, int? paragraphIndex = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSpecialSlideAnimation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read shape paragraph info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetSpecialSlideParagraph(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSpecialSlideParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read special shape paragraphs info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs GetSpecialSlideParagraphs(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSpecialSlideParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read paragraph portion info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetSpecialSlidePortion(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSpecialSlidePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read paragraph portions info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions GetSpecialSlidePortions(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, int paragraphIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSpecialSlidePortions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read special slide shape info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase GetSpecialSlideShape(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSpecialSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read special slide shapes info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes GetSpecialSlideShapes(string name, int slideIndex, SpecialSlideType slideType, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSpecialSlideShapes");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shapes>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Returns paragraph info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph GetTableCellParagraph(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCellParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Returns table cell paragraphs. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraphs"/></returns>            
        public Paragraphs GetTableCellParagraphs(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCellParagraphs");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraphs>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Returns table cell portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion GetTableCellPortion(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, int paragraphIndex, int portionIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCellPortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Returns table cell portions. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portions"/></returns>            
        public Portions GetTableCellPortions(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, int paragraphIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCellPortions");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs/{paragraphIndex}/portions");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portions>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTheme");
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
        /// Get VBA module info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="moduleIndex">The index of the macros module to remove.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="VbaModule"/></returns>            
        public VbaModule GetVbaModule(string name, int moduleIndex, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetVbaModule");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/vbaProject/modules/{moduleIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "moduleIndex", moduleIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<VbaModule>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Get VBA project info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="VbaProject"/></returns>            
        public VbaProject GetVbaProject(string name, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetVbaProject");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/vbaProject");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<VbaProject>(resourcePath, "GET", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Read presentation view properties. 
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
                throw new ApiException(400, "Missing required parameter 'name' when calling GetViewProperties");
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
        /// Highlight all matches of sample in text frame text using specified color. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="regex">Regular expression.</param> 
        /// <param name="color">Highlighting color.</param> 
        /// <param name="wholeWordsOnly">Match only whole words.</param> 
        /// <param name="ignoreCase">True to search ignoring char case.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shape"/></returns>            
        public Shape HighlightShapeRegex(string name, int slideIndex, int shapeIndex, string regex, string color, bool? wholeWordsOnly = null, bool? ignoreCase = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling HighlightShapeRegex");
            }
            // verify the required parameter 'regex' is set
            if (regex == null)
            {
                throw new ApiException(400, "Missing required parameter 'regex' when calling HighlightShapeRegex");
            }
            // verify the required parameter 'color' is set
            if (color == null)
            {
                throw new ApiException(400, "Missing required parameter 'color' when calling HighlightShapeRegex");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/highlightRegex");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "regex", regex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "color", color);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "wholeWordsOnly", wholeWordsOnly);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreCase", ignoreCase);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shape>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Highlight all matches of sample in text frame text using specified color. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="text">Text sample to highlight.</param> 
        /// <param name="color">Highlighting color.</param> 
        /// <param name="wholeWordsOnly">Match only whole words.</param> 
        /// <param name="ignoreCase">True to search ignoring char case.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Shape"/></returns>            
        public Shape HighlightShapeText(string name, int slideIndex, int shapeIndex, string text, string color, bool? wholeWordsOnly = null, bool? ignoreCase = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling HighlightShapeText");
            }
            // verify the required parameter 'text' is set
            if (text == null)
            {
                throw new ApiException(400, "Missing required parameter 'text' when calling HighlightShapeText");
            }
            // verify the required parameter 'color' is set
            if (color == null)
            {
                throw new ApiException(400, "Missing required parameter 'color' when calling HighlightShapeText");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/highlightText");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "text", text);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "color", color);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "wholeWordsOnly", wholeWordsOnly);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreCase", ignoreCase);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Shape>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling ImportFromHtml");
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
        /// Create presentation document from pdf or append pdf to an existing presentation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="pdf">PDF data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document ImportFromPdf(string name, System.IO.Stream pdf, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ImportFromPdf");
            }
            // verify the required parameter 'pdf' is set
            if (pdf == null)
            {
                throw new ApiException(400, "Missing required parameter 'pdf' when calling ImportFromPdf");
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
            return InvokeApi<Document>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Imports shapes from SVG file. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="image">SVG image data.</param> 
        /// <param name="x">The X coordinate of the imported group of shapes (0 is default if not specified).</param> 
        /// <param name="y">The Y coordinate of the imported group of shapes (0 is default if not specified).</param> 
        /// <param name="width">The width of the imported group of shapes (default is SVG image width).</param> 
        /// <param name="height">The height of the imported group of shapes (default is SVG image width).</param> 
        /// <param name="shapes">Indexes of shapes to import. All shapes are imported if not specified.</param> 
        /// <param name="group">If true, the set of shapes will be imported as a one group shape.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Presentation folder.</param> 
        /// <param name="storage">Presentation storage.</param> 
        /// <returns><see cref="Shapes"/></returns>            
        public Shapes ImportShapesFromSvg(string name, int slideIndex, System.IO.Stream image = null, int? x = null, int? y = null, int? width = null, int? height = null, List<int> shapes = null, bool? group = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ImportShapesFromSvg");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/fromSvg");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "x", x);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "y", y);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "width", width);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "height", height);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "shapes", shapes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "group", group);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (image != null) 
            {
                requestFiles.Add(new FileInfo { Name = "image", Content = image });
            }
            return InvokeApi<Shapes>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling Merge");
            }
            // verify the required parameter 'request' is set
            if (request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling Merge");
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
        /// Merges presentations or some of their slides specified in the request parameter. Result will be save in the storage. 
        /// </summary>
        /// <param name="outPath">Path to save result.</param> 
        /// <param name="files">Files to merge</param> 
        /// <param name="request">Merge request.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref=""/></returns>            
        public void MergeAndSaveOnline(string outPath, List<FileInfo> files = null, OrderedMergeRequest request = null, string storage = null)
        {
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling MergeAndSaveOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/merge");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (files != null) 
            {
                requestFiles.AddRange(files);
            }
            InvokeVoidApi(resourcePath, "PUT", postBody, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Merges presentations or some of their slides specified in the request parameter. Returns result file in the response.  
        /// </summary>
        /// <param name="files">Files to merge</param> 
        /// <param name="request">Merge request.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream MergeOnline(List<FileInfo> files = null, OrderedMergeRequest request = null, string storage = null)
        {
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/merge");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            var postBody = SerializationHelper.Serialize(request); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (files != null) 
            {
                requestFiles.AddRange(files);
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, null, requestFiles, "application/json");
        }

        /// <summary>
        /// Merge table cells. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="tableCellMergeOptions">Merge settings.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Table"/></returns>            
        public Table MergeTableCells(string name, int slideIndex, int shapeIndex, TableCellMergeOptions tableCellMergeOptions, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling MergeTableCells");
            }
            // verify the required parameter 'tableCellMergeOptions' is set
            if (tableCellMergeOptions == null)
            {
                throw new ApiException(400, "Missing required parameter 'tableCellMergeOptions' when calling MergeTableCells");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/mergeCells");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(tableCellMergeOptions); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Table>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling MoveSection");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling MoveSlide");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling NotesSlideExists");
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
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="EntityExists"/></returns>            
        public EntityExists NotesSlideExistsOnline(System.IO.Stream document, int slideIndex, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling NotesSlideExistsOnline");
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
            return InvokeApi<EntityExists>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling OrderedMerge");
            }
            // verify the required parameter 'request' is set
            if (request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling OrderedMerge");
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
                throw new ApiException(400, "Missing required parameter 'pipeline' when calling Pipeline");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling ReorderSlides");
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
        /// Replaces specified font and returns presentation fonts info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="sourceFont">Source font name.</param> 
        /// <param name="targetFont">Target font name.</param> 
        /// <param name="embed">Embed target font.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref="FontsData"/></returns>            
        public FontsData ReplaceFont(string name, string sourceFont, string targetFont, bool? embed = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceFont");
            }
            // verify the required parameter 'sourceFont' is set
            if (sourceFont == null)
            {
                throw new ApiException(400, "Missing required parameter 'sourceFont' when calling ReplaceFont");
            }
            // verify the required parameter 'targetFont' is set
            if (targetFont == null)
            {
                throw new ApiException(400, "Missing required parameter 'targetFont' when calling ReplaceFont");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fonts/{sourceFont}/replace/{targetFont}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sourceFont", sourceFont);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "targetFont", targetFont);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "embed", embed);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<FontsData>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Replaces specified font and returns presentation. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="sourceFont">Source font name.</param> 
        /// <param name="targetFont">Target font name.</param> 
        /// <param name="embed">Embed target font.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ReplaceFontOnline(System.IO.Stream document, string sourceFont, string targetFont, bool? embed = null, string password = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling ReplaceFontOnline");
            }
            // verify the required parameter 'sourceFont' is set
            if (sourceFont == null)
            {
                throw new ApiException(400, "Missing required parameter 'sourceFont' when calling ReplaceFontOnline");
            }
            // verify the required parameter 'targetFont' is set
            if (targetFont == null)
            {
                throw new ApiException(400, "Missing required parameter 'targetFont' when calling ReplaceFontOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/fonts/{sourceFont}/replace/{targetFont}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "sourceFont", sourceFont);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "targetFont", targetFont);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "embed", embed);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Replaces image by the specified index. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="imageIndex">Image index.</param> 
        /// <param name="image">Image data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref=""/></returns>            
        public void ReplaceImage(string name, int imageIndex, System.IO.Stream image = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceImage");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/images/{imageIndex}/replace");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "imageIndex", imageIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (image != null) 
            {
                requestFiles.Add(new FileInfo { Name = "image", Content = image });
            }
            InvokeVoidStreamApi(resourcePath, "PUT", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Replaces image by the specified index and returns updated document.  
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="imageIndex">Image index.</param> 
        /// <param name="image">Image data.</param> 
        /// <param name="password">Password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ReplaceImageOnline(System.IO.Stream document, int imageIndex, System.IO.Stream image = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling ReplaceImageOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/images/{imageIndex}/replace");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "imageIndex", imageIndex);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            if (image != null) 
            {
                requestFiles.Add(new FileInfo { Name = "image", Content = image });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling ReplacePresentationText");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling ReplacePresentationText");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling ReplacePresentationText");
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
                throw new ApiException(400, "Missing required parameter 'document' when calling ReplacePresentationTextOnline");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling ReplacePresentationTextOnline");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling ReplacePresentationTextOnline");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceSlideText");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling ReplaceSlideText");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling ReplaceSlideText");
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
                throw new ApiException(400, "Missing required parameter 'document' when calling ReplaceSlideTextOnline");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling ReplaceSlideTextOnline");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling ReplaceSlideTextOnline");
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
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Finds and replaces text in presentation with given format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="oldValue">Text value to be replaced.</param> 
        /// <param name="newValue">Text value to replace with.</param> 
        /// <param name="portionFormat">Portion format.</param> 
        /// <param name="withMasters">Text replacement includes master slides.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Document"/></returns>            
        public Document ReplaceTextFormatting(string name, string oldValue, string newValue, PortionFormat portionFormat = null, bool? withMasters = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling ReplaceTextFormatting");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling ReplaceTextFormatting");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling ReplaceTextFormatting");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/replaceTextFormatting");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldValue", oldValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newValue", newValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withMasters", withMasters);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(portionFormat); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Document>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Finds and replaces text in presentation with given format. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="oldValue">Text value to be replaced.</param> 
        /// <param name="newValue">Text value to replace with.</param> 
        /// <param name="portionFormat">Portion format.</param> 
        /// <param name="withMasters">Text replacement includes master slides.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream ReplaceTextFormattingOnline(System.IO.Stream document, string oldValue, string newValue, PortionFormat portionFormat = null, bool? withMasters = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling ReplaceTextFormattingOnline");
            }
            // verify the required parameter 'oldValue' is set
            if (oldValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'oldValue' when calling ReplaceTextFormattingOnline");
            }
            // verify the required parameter 'newValue' is set
            if (newValue == null)
            {
                throw new ApiException(400, "Missing required parameter 'newValue' when calling ReplaceTextFormattingOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/replaceTextFormatting");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "oldValue", oldValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newValue", newValue);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withMasters", withMasters);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(portionFormat); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Convert Mathematical Text to MathML Format and saves result to the storage 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="outPath">Path to save result.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Presentation folder.</param> 
        /// <param name="storage">Presentation storage.</param> 
        /// <returns><see cref=""/></returns>            
        public void SavePortionAsMathMl(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, string outPath, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SavePortionAsMathMl");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling SavePortionAsMathMl");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}/mathml");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", null, headerParams, requestFiles, "application/json");
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
        /// <param name="slides">The indices of the slides to be saved. If not specified, all slides are saved by default.</param> 
        /// <returns><see cref=""/></returns>            
        public void SavePresentation(string name, ExportFormat format, string outPath, ExportOptions options = null, string password = null, string folder = null, string storage = null, string fontsFolder = null, List<int> slides = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SavePresentation");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling SavePresentation");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "slides", slides);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveShape(string name, int slideIndex, int shapeIndex, ShapeExportFormat format, string outPath, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SaveShape");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling SaveShape");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
        /// <param name="options">Export options.</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveShapeOnline(System.IO.Stream document, int slideIndex, int shapeIndex, ShapeExportFormat format, string outPath, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string storage = null, string fontsFolder = null, IShapeExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling SaveShapeOnline");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling SaveShapeOnline");
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
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Save a slide to a specified format. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="outPath">Path to upload the output file to.</param> 
        /// <param name="options">Export options.</param> 
        /// <param name="width">The width of the slide representation in the output format; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="height">The height of the slide representation in the output format; 0 to not adjust the size. Default is 0.</param> 
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SaveSlide");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling SaveSlide");
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
        /// <param name="document">Document data.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="format">Output file format.</param> 
        /// <param name="outPath">Path to save result.</param> 
        /// <param name="width">The width of the slide representation in the output format; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="height">The height of the slide representation in the output format; 0 to not adjust the size. Default is 0.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param> 
        /// <param name="options">Export options.</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveSlideOnline(System.IO.Stream document, int slideIndex, SlideExportFormat format, string outPath, int? width = null, int? height = null, string password = null, string storage = null, string fontsFolder = null, ExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling SaveSlideOnline");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling SaveSlideOnline");
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
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Render shape to specified picture format. 
        /// </summary>
        /// <param name="name">Presentation name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref=""/></returns>            
        public void SaveSpecialSlideShape(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, ShapeExportFormat format, string outPath, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SaveSpecialSlideShape");
            }
            // verify the required parameter 'outPath' is set
            if (outPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'outPath' when calling SaveSpecialSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/{format}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "format", format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleX", scaleX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scaleY", scaleY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bounds", bounds);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            InvokeVoidApi(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetAnimation");
            }
            // verify the required parameter 'animation' is set
            if (animation == null)
            {
                throw new ApiException(400, "Missing required parameter 'animation' when calling SetAnimation");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetBackground");
            }
            // verify the required parameter 'background' is set
            if (background == null)
            {
                throw new ApiException(400, "Missing required parameter 'background' when calling SetBackground");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetBackgroundColor");
            }
            // verify the required parameter 'color' is set
            if (color == null)
            {
                throw new ApiException(400, "Missing required parameter 'color' when calling SetBackgroundColor");
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
        /// Set chart axis. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="axisType">Axis type. Horizontal, Vertical, SecondaryHorizontal or SecondaryVertical.</param> 
        /// <param name="axis">Axis DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Axis"/></returns>            
        public Axis SetChartAxis(string name, int slideIndex, int shapeIndex, AxisType axisType, Axis axis, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SetChartAxis");
            }
            // verify the required parameter 'axis' is set
            if (axis == null)
            {
                throw new ApiException(400, "Missing required parameter 'axis' when calling SetChartAxis");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/{axisType}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "axisType", axisType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(axis); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Axis>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set chart axis. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="legend">Chart legend DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Legend"/></returns>            
        public Legend SetChartLegend(string name, int slideIndex, int shapeIndex, Legend legend, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SetChartLegend");
            }
            // verify the required parameter 'legend' is set
            if (legend == null)
            {
                throw new ApiException(400, "Missing required parameter 'legend' when calling SetChartLegend");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/legend");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(legend); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Legend>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set a series group in a chart. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index (must be a chart).</param> 
        /// <param name="seriesGroupIndex">Series group index.</param> 
        /// <param name="seriesGroup">Series group DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Chart"/></returns>            
        public Chart SetChartSeriesGroup(string name, int slideIndex, int shapeIndex, int seriesGroupIndex, ChartSeriesGroup seriesGroup, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SetChartSeriesGroup");
            }
            // verify the required parameter 'seriesGroup' is set
            if (seriesGroup == null)
            {
                throw new ApiException(400, "Missing required parameter 'seriesGroup' when calling SetChartSeriesGroup");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/seriesGroup/{seriesGroupIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "seriesGroupIndex", seriesGroupIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(seriesGroup); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Chart>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set 3D chart wall. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="chartWallType">Chart wall type: floor, sideWall or backWall.</param> 
        /// <param name="chartWall">Chart wall DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ChartWall"/></returns>            
        public ChartWall SetChartWall(string name, int slideIndex, int shapeIndex, ChartWallType chartWallType, ChartWall chartWall, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SetChartWall");
            }
            // verify the required parameter 'chartWall' is set
            if (chartWall == null)
            {
                throw new ApiException(400, "Missing required parameter 'chartWall' when calling SetChartWall");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/{chartWallType}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "chartWallType", chartWallType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(chartWall); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ChartWall>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetDocumentProperties");
            }
            // verify the required parameter 'properties' is set
            if (properties == null)
            {
                throw new ApiException(400, "Missing required parameter 'properties' when calling SetDocumentProperties");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetDocumentProperty");
            }
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling SetDocumentProperty");
            }
            // verify the required parameter 'property' is set
            if (property == null)
            {
                throw new ApiException(400, "Missing required parameter 'property' when calling SetDocumentProperty");
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
        /// Embeds specified font and returns presentation fonts info. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="fontName">Font name.</param> 
        /// <param name="onlyUsed">Only used characters will be embedded.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref="FontsData"/></returns>            
        public FontsData SetEmbeddedFont(string name, string fontName, bool? onlyUsed = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SetEmbeddedFont");
            }
            // verify the required parameter 'fontName' is set
            if (fontName == null)
            {
                throw new ApiException(400, "Missing required parameter 'fontName' when calling SetEmbeddedFont");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fonts/embedded/{fontName}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fontName", fontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "onlyUsed", onlyUsed);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<FontsData>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Embeds font from request and returns presentation fonts info. 
        /// </summary>
        /// <param name="font">Font data.</param> 
        /// <param name="name">Document name.</param> 
        /// <param name="onlyUsed">Only used characters will be embedded.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="FontsData"/></returns>            
        public FontsData SetEmbeddedFontFromRequest(System.IO.Stream font, string name, bool? onlyUsed = null, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'font' is set
            if (font == null)
            {
                throw new ApiException(400, "Missing required parameter 'font' when calling SetEmbeddedFontFromRequest");
            }
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SetEmbeddedFontFromRequest");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/fonts/embedded");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "onlyUsed", onlyUsed);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (font != null) 
            {
                requestFiles.Add(new FileInfo { Name = "font", Content = font });
            }
            return InvokeApi<FontsData>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Embeds font from request and returns presentation. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="font">Font data.</param> 
        /// <param name="onlyUsed">Only used characters will be embedded.</param> 
        /// <param name="password">Document password.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream SetEmbeddedFontFromRequestOnline(System.IO.Stream document, System.IO.Stream font, bool? onlyUsed = null, string password = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling SetEmbeddedFontFromRequestOnline");
            }
            // verify the required parameter 'font' is set
            if (font == null)
            {
                throw new ApiException(400, "Missing required parameter 'font' when calling SetEmbeddedFontFromRequestOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/fonts/embedded");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "onlyUsed", onlyUsed);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            if (font != null) 
            {
                requestFiles.Add(new FileInfo { Name = "font", Content = font });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Embeds specified font and returns presentation. 
        /// </summary>
        /// <param name="document">Document data.</param> 
        /// <param name="fontName">Font name.</param> 
        /// <param name="onlyUsed">Only used characters will be embedded.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="fontsFolder">Custom fonts folder.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream SetEmbeddedFontOnline(System.IO.Stream document, string fontName, bool? onlyUsed = null, string password = null, string fontsFolder = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling SetEmbeddedFontOnline");
            }
            // verify the required parameter 'fontName' is set
            if (fontName == null)
            {
                throw new ApiException(400, "Missing required parameter 'fontName' when calling SetEmbeddedFontOnline");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/fonts/embedded/{fontName}");
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "fontName", fontName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "onlyUsed", onlyUsed);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fontsFolder", fontsFolder);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetNotesSlideHeaderFooter");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling SetNotesSlideHeaderFooter");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetPresentationHeaderFooter");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling SetPresentationHeaderFooter");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetProtection");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling SetProtection");
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
                throw new ApiException(400, "Missing required parameter 'document' when calling SetProtectionOnline");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling SetProtectionOnline");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetSections");
            }
            // verify the required parameter 'sections' is set
            if (sections == null)
            {
                throw new ApiException(400, "Missing required parameter 'sections' when calling SetSections");
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
        /// Sets geometry path to the shape 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Geometry paths DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase SetShapeGeometryPath(string name, int slideIndex, int shapeIndex, GeometryPaths dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SetShapeGeometryPath");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling SetShapeGeometryPath");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/geometryPath");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetSlideHeaderFooter");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling SetSlideHeaderFooter");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetSlideProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling SetSlideProperties");
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
        /// Update presentation slide show properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="dto">The slide show properties data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideShowProperties"/></returns>            
        public SlideShowProperties SetSlideShowProperties(string name, SlideShowProperties dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SetSlideShowProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling SetSlideShowProperties");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slideShowProperties");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideShowProperties>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Set special slide (master, layout, notes) animation. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="animation">Animation DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation SetSpecialSlideAnimation(string name, int slideIndex, SpecialSlideType slideType, SlideAnimation animation, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SetSpecialSlideAnimation");
            }
            // verify the required parameter 'animation' is set
            if (animation == null)
            {
                throw new ApiException(400, "Missing required parameter 'animation' when calling SetSpecialSlideAnimation");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(animation); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update presentation view properties. 
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SetViewProperties");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling SetViewProperties");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling Split");
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
        /// <param name="options">Export options.</param> 
        /// <returns><see cref="SplitDocumentResult"/></returns>            
        public SplitDocumentResult SplitAndSaveOnline(System.IO.Stream document, SlideExportFormat format, string destFolder = null, int? width = null, int? height = null, int? from = null, int? to = null, string password = null, string storage = null, string fontsFolder = null, ExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling SplitAndSaveOnline");
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
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeApi<SplitDocumentResult>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
        /// <param name="options">Export options.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream SplitOnline(System.IO.Stream document, SlideExportFormat format, int? width = null, int? height = null, int? from = null, int? to = null, string password = null, string storage = null, string fontsFolder = null, ExportOptions options = null)
        {
            // verify the required parameter 'document' is set
            if (document == null)
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling SplitOnline");
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
            var postBody = SerializationHelper.Serialize(options); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            if (document != null) 
            {
                requestFiles.Add(new FileInfo { Name = "document", Content = document });
            }
            return InvokeBinaryApi(resourcePath, "POST", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Split table cell. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="splitType">Table cell split type (SplitByWidth, SplitByHeight,SplitByColSpan or SplitByRowSpan).</param> 
        /// <param name="value">Split value. In case of splitting by column or row span, the value must be an integer number.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Table"/></returns>            
        public Table SplitTableCell(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, TableCellSplitType splitType, double value, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SplitTableCell");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/{splitType}/{value}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "splitType", splitType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "value", value);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Table>(resourcePath, "POST", null, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateAnimationEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling UpdateAnimationEffect");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateAnimationInteractiveSequenceEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling UpdateAnimationInteractiveSequenceEffect");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateChartCategory");
            }
            // verify the required parameter 'category' is set
            if (category == null)
            {
                throw new ApiException(400, "Missing required parameter 'category' when calling UpdateChartCategory");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateChartDataPoint");
            }
            // verify the required parameter 'dataPoint' is set
            if (dataPoint == null)
            {
                throw new ApiException(400, "Missing required parameter 'dataPoint' when calling UpdateChartDataPoint");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateChartSeries");
            }
            // verify the required parameter 'series' is set
            if (series == null)
            {
                throw new ApiException(400, "Missing required parameter 'series' when calling UpdateChartSeries");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateLayoutSlide");
            }
            // verify the required parameter 'slideDto' is set
            if (slideDto == null)
            {
                throw new ApiException(400, "Missing required parameter 'slideDto' when calling UpdateLayoutSlide");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateNotesSlide");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateNotesSlide");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph UpdateParagraph(string name, int slideIndex, int shapeIndex, int paragraphIndex, Paragraph dto, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateParagraph");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion UpdatePortion(string name, int slideIndex, int shapeIndex, int paragraphIndex, int portionIndex, Portion dto, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdatePortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdatePortion");
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
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSection");
            }
            // verify the required parameter 'sectionName' is set
            if (sectionName == null)
            {
                throw new ApiException(400, "Missing required parameter 'sectionName' when calling UpdateSection");
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
        /// Update shape properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase UpdateShape(string name, int slideIndex, int shapeIndex, ShapeBase dto, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateShape");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSlide");
            }
            // verify the required parameter 'slideDto' is set
            if (slideDto == null)
            {
                throw new ApiException(400, "Missing required parameter 'slideDto' when calling UpdateSlide");
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
        /// Modify an animation effect for a special slide (master, layout, notes). 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="effectIndex">The position of the effect to be modified.</param> 
        /// <param name="effect">Animation effect DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation UpdateSpecialSlideAnimationEffect(string name, int slideIndex, SpecialSlideType slideType, int effectIndex, Effect effect, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSpecialSlideAnimationEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling UpdateSpecialSlideAnimationEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/mainSequence/{effectIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "effectIndex", effectIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(effect); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<SlideAnimation>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Modify an animation effect for a special slide (master, layout, notes) interactive sequence. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="sequenceIndex">The position of the interactive sequence.</param> 
        /// <param name="effectIndex">The position of the effect to be modified.</param> 
        /// <param name="effect">Animation effect DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="SlideAnimation"/></returns>            
        public SlideAnimation UpdateSpecialSlideAnimationInteractiveSequenceEffect(string name, int slideIndex, SpecialSlideType slideType, int sequenceIndex, int effectIndex, Effect effect, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSpecialSlideAnimationInteractiveSequenceEffect");
            }
            // verify the required parameter 'effect' is set
            if (effect == null)
            {
                throw new ApiException(400, "Missing required parameter 'effect' when calling UpdateSpecialSlideAnimationInteractiveSequenceEffect");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/animation/interactiveSequences/{sequenceIndex}/{effectIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
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
        /// Update paragraph properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph UpdateSpecialSlideParagraph(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, int paragraphIndex, Paragraph dto, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSpecialSlideParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateSpecialSlideParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update portion properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion UpdateSpecialSlidePortion(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, int paragraphIndex, int portionIndex, Portion dto, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSpecialSlidePortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateSpecialSlidePortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "portionIndex", portionIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Portion>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update shape properties. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Parent slide index.</param> 
        /// <param name="slideType">Slide type (master, layout or notes).</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="dto">Shape DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <param name="subShape">Sub-shape path (e.g. \"3\", \"3/shapes/2).</param> 
        /// <returns><see cref="ShapeBase"/></returns>            
        public ShapeBase UpdateSpecialSlideShape(string name, int slideIndex, SpecialSlideType slideType, int shapeIndex, ShapeBase dto, string password = null, string folder = null, string storage = null, string subShape = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSpecialSlideShape");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateSpecialSlideShape");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/{slideType}/shapes/{shapeIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideType", slideType);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "subShape", subShape);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<ShapeBase>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update the table cell. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="dto">Table cell data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="TableCell"/></returns>            
        public TableCell UpdateTableCell(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, TableCell dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableCell");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateTableCell");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<TableCell>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Updates table cell paragraph. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="dto">Paragraph DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Paragraph"/></returns>            
        public Paragraph UpdateTableCellParagraph(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, int paragraphIndex, Paragraph dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableCellParagraph");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateTableCellParagraph");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs/{paragraphIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "paragraphIndex", paragraphIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<Paragraph>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Updates table cell portion. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="cellIndex">Table cell index.</param> 
        /// <param name="paragraphIndex">Paragraph index.</param> 
        /// <param name="portionIndex">Portion index.</param> 
        /// <param name="dto">Portion DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="Portion"/></returns>            
        public Portion UpdateTableCellPortion(string name, int slideIndex, int shapeIndex, int rowIndex, int cellIndex, int paragraphIndex, int portionIndex, Portion dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableCellPortion");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateTableCellPortion");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}/cells/{cellIndex}/paragraphs/{paragraphIndex}/portions/{portionIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "cellIndex", cellIndex);
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
        /// Update the table row. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="slideIndex">Slide index.</param> 
        /// <param name="shapeIndex">Shape index.</param> 
        /// <param name="rowIndex">Row index.</param> 
        /// <param name="dto">Table cell data.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="TableRow"/></returns>            
        public TableRow UpdateTableRow(string name, int slideIndex, int shapeIndex, int rowIndex, TableRow dto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableRow");
            }
            // verify the required parameter 'dto' is set
            if (dto == null)
            {
                throw new ApiException(400, "Missing required parameter 'dto' when calling UpdateTableRow");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/shapes/{shapeIndex}/rows/{rowIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", slideIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "shapeIndex", shapeIndex);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "rowIndex", rowIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(dto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<TableRow>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
        }

        /// <summary>
        /// Update VBA module. 
        /// </summary>
        /// <param name="name">Document name.</param> 
        /// <param name="moduleIndex">The index of the macros module to remove.</param> 
        /// <param name="moduleDto">VBA module DTO.</param> 
        /// <param name="password">Document password.</param> 
        /// <param name="folder">Document folder.</param> 
        /// <param name="storage">Document storage.</param> 
        /// <returns><see cref="VbaModule"/></returns>            
        public VbaModule UpdateVbaModule(string name, int moduleIndex, VbaModule moduleDto, string password = null, string folder = null, string storage = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateVbaModule");
            }
            // verify the required parameter 'moduleDto' is set
            if (moduleDto == null)
            {
                throw new ApiException(400, "Missing required parameter 'moduleDto' when calling UpdateVbaModule");
            }
            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/vbaProject/modules/{moduleIndex}");
            var headerParams = new Dictionary<string, string>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "moduleIndex", moduleIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", storage);
            UrlHelper.AddHeaderParameter(headerParams, "password", password);
            var postBody = SerializationHelper.Serialize(moduleDto); // http body (model) parameter
            var requestFiles = new List<FileInfo>();
            return InvokeApi<VbaModule>(resourcePath, "PUT", postBody, headerParams, requestFiles, "application/json");
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
            return InvokeApi<FilesUploadResult>(resourcePath, "PUT", null, null, requestFiles, "application/json");
        }
    }
}
