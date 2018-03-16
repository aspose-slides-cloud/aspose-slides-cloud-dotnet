
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSlidesReorderPositionRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PostSlidesReorderPosition" /> operation.
  /// </summary>  
  public class PostSlidesReorderPositionRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesReorderPositionRequest"/> class.
        /// </summary>        
        public PostSlidesReorderPositionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesReorderPositionRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="oldPosition"></param>
        /// <param name="newPosition"></param>
        /// <param name="slideToCopy"></param>
        /// <param name="position"></param>
        /// <param name="slideToClone"></param>
        /// <param name="source"></param>
        /// <param name="folder"></param>
        /// <param name="storage"></param>
        /// <param name="layoutAlias"></param>
        public PostSlidesReorderPositionRequest(string name, int? oldPosition = null, int? newPosition = null, int? slideToCopy = null, int? position = null, int? slideToClone = null, string source = null, string folder = null, string storage = null, string layoutAlias = null)
        {
            this.Name = name;
            this.OldPosition = oldPosition;
            this.NewPosition = newPosition;
            this.SlideToCopy = slideToCopy;
            this.Position = position;
            this.SlideToClone = slideToClone;
            this.Source = source;
            this.Folder = folder;
            this.Storage = storage;
            this.LayoutAlias = layoutAlias;
        }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets OldPosition
        /// </summary>  
        public int? OldPosition { get; set; }

        /// <summary>
        /// Gets or sets NewPosition
        /// </summary>  
        public int? NewPosition { get; set; }

        /// <summary>
        /// Gets or sets SlideToCopy
        /// </summary>  
        public int? SlideToCopy { get; set; }

        /// <summary>
        /// Gets or sets Position
        /// </summary>  
        public int? Position { get; set; }

        /// <summary>
        /// Gets or sets SlideToClone
        /// </summary>  
        public int? SlideToClone { get; set; }

        /// <summary>
        /// Gets or sets Source
        /// </summary>  
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets Folder
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets Storage
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets LayoutAlias
        /// </summary>  
        public string LayoutAlias { get; set; }
  }
}