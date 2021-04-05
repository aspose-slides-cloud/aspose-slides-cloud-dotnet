
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostAlignShapesRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PostAlignShapes" /> operation.
  /// </summary>  
  public class PostAlignShapesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAlignShapesRequest"/> class.
        /// </summary>        
        public PostAlignShapesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAlignShapesRequest"/> class.
        /// </summary>
        /// <param name="name">Document name.</param>
        /// <param name="slideIndex">Slide index.</param>
        /// <param name="alignmentType">Alignment type that will be applied to the shapes.</param>
        /// <param name="alignToSlide">If true, shapes will be aligned relative to the slide edges.</param>
        /// <param name="shapes">Shapes indexes.</param>
        /// <param name="password">Document password.</param>
        /// <param name="folder">Document folder.</param>
        /// <param name="storage">Document storage.</param>
        public PostAlignShapesRequest(string name, int slideIndex, ShapesAlignmentType alignmentType, bool? alignToSlide = null, List<int> shapes = null, string password = null, string folder = null, string storage = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.AlignmentType = alignmentType;
            this.AlignToSlide = alignToSlide;
            this.Shapes = shapes;
            this.Password = password;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// Document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Slide index.
        /// </summary>  
        public int SlideIndex { get; set; }

        /// <summary>
        /// Alignment type that will be applied to the shapes.
        /// </summary>  
        public ShapesAlignmentType AlignmentType { get; set; }

        /// <summary>
        /// If true, shapes will be aligned relative to the slide edges.
        /// </summary>  
        public bool? AlignToSlide { get; set; }

        /// <summary>
        /// Shapes indexes.
        /// </summary>  
        public List<int> Shapes { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Document storage.
        /// </summary>  
        public string Storage { get; set; }
  }
}