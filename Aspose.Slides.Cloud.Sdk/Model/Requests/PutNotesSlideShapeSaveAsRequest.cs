
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutNotesSlideShapeSaveAsRequest.cs">
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
using System.IO;
using Aspose.Slides.Cloud.Sdk.Model;

namespace Aspose.Slides.Cloud.Sdk.Model.Requests 
{
  /// <summary>
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PutNotesSlideShapeSaveAs" /> operation.
  /// </summary>  
  public class PutNotesSlideShapeSaveAsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutNotesSlideShapeSaveAsRequest"/> class.
        /// </summary>        
        public PutNotesSlideShapeSaveAsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutNotesSlideShapeSaveAsRequest"/> class.
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
        public PutNotesSlideShapeSaveAsRequest(string name, int slideIndex, int shapeIndex, ShapeExportFormat format, string outPath, IShapeExportOptions options = null, double? scaleX = null, double? scaleY = null, ShapeThumbnailBounds? bounds = null, string password = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.ShapeIndex = shapeIndex;
            this.Format = format;
            this.OutPath = outPath;
            this.Options = options;
            this.ScaleX = scaleX;
            this.ScaleY = scaleY;
            this.Bounds = bounds;
            this.Password = password;
            this.Folder = folder;
            this.Storage = storage;
            this.FontsFolder = fontsFolder;
        }

        /// <summary>
        /// Presentation name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Slide index.
        /// </summary>  
        public int SlideIndex { get; set; }

        /// <summary>
        /// Index of shape starting from 1
        /// </summary>  
        public int ShapeIndex { get; set; }

        /// <summary>
        /// Export picture format.
        /// </summary>  
        public ShapeExportFormat Format { get; set; }

        /// <summary>
        /// Output path.
        /// </summary>  
        public string OutPath { get; set; }

        /// <summary>
        /// export options
        /// </summary>  
        public IShapeExportOptions Options { get; set; }

        /// <summary>
        /// X scale ratio.
        /// </summary>  
        public double? ScaleX { get; set; }

        /// <summary>
        /// Y scale ratio.
        /// </summary>  
        public double? ScaleY { get; set; }

        /// <summary>
        /// Shape thumbnail bounds type.
        /// </summary>  
        public ShapeThumbnailBounds? Bounds { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Presentation folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Presentation storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Fonts folder.
        /// </summary>  
        public string FontsFolder { get; set; }
  }
}