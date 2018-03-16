
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutUpdateNotesSlideShapeRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.NotesSlideShapesApi.PutUpdateNotesSlideShape" /> operation.
  /// </summary>  
  public class PutUpdateNotesSlideShapeRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutUpdateNotesSlideShapeRequest"/> class.
        /// </summary>        
        public PutUpdateNotesSlideShapeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutUpdateNotesSlideShapeRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slideIndex"></param>
        /// <param name="path"></param>
        /// <param name="dto"></param>
        /// <param name="folder"></param>
        /// <param name="storage"></param>
        public PutUpdateNotesSlideShapeRequest(string name, int slideIndex, string path, ResourceBase dto = null, string folder = null, string storage = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.Path = path;
            this.Dto = dto;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets SlideIndex
        /// </summary>  
        public int SlideIndex { get; set; }

        /// <summary>
        /// Gets or sets Path
        /// </summary>  
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets Dto
        /// </summary>  
        public ResourceBase Dto { get; set; }

        /// <summary>
        /// Gets or sets Folder
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets Storage
        /// </summary>  
        public string Storage { get; set; }
  }
}
