// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetNotesSlideShapeWithFormatRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.NotesSlideShapesApi.GetNotesSlideShapeWithFormat" /> operation.
  /// </summary>  
  public class GetNotesSlideShapeWithFormatRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotesSlideShapeWithFormatRequest"/> class.
        /// </summary>        
        public GetNotesSlideShapeWithFormatRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNotesSlideShapeWithFormatRequest"/> class.
        /// </summary>
        /// <param name="name">Presentation name.</param>
        /// <param name="slideIndex">Slide index.</param>
        /// <param name="shapeIndex">Index of shape starting from 1</param>
        /// <param name="format">Export picture format.</param>
        /// <param name="folder">Presentation folder.</param>
        /// <param name="storage">Presentation storage.</param>
        /// <param name="scaleX">X scale ratio.</param>
        /// <param name="scaleY">Y scale ratio.</param>
        /// <param name="bounds">Shape thumbnail bounds type.</param>
        public GetNotesSlideShapeWithFormatRequest(string name, int slideIndex, int shapeIndex, ShapeExportFormat format, string folder = null, string storage = null, double? scaleX = null, double? scaleY = null, string bounds = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.ShapeIndex = shapeIndex;
            this.Format = format;
            this.Folder = folder;
            this.Storage = storage;
            this.ScaleX = scaleX;
            this.ScaleY = scaleY;
            this.Bounds = bounds;
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
        /// Presentation folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Presentation storage.
        /// </summary>  
        public string Storage { get; set; }

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
        public string Bounds { get; set; }
  }
}
