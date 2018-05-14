
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutUpdateNotesSlidePortionRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.NotesSlideShapesApi.PutUpdateNotesSlidePortion" /> operation.
  /// </summary>  
  public class PutUpdateNotesSlidePortionRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutUpdateNotesSlidePortionRequest"/> class.
        /// </summary>        
        public PutUpdateNotesSlidePortionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutUpdateNotesSlidePortionRequest"/> class.
        /// </summary>
        /// <param name="name">Presentation name.</param>
        /// <param name="slideIndex">Slide index.</param>
        /// <param name="path">Object path.</param>
        /// <param name="paragraphIndex"></param>
        /// <param name="portionIndex"></param>
        /// <param name="dto">Object dto.</param>
        /// <param name="folder">Presentation folder.</param>
        /// <param name="storage">Presentation storage.</param>
        public PutUpdateNotesSlidePortionRequest(string name, int slideIndex, string path, int paragraphIndex, int portionIndex, ResourceBase dto = null, string folder = null, string storage = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.Path = path;
            this.ParagraphIndex = paragraphIndex;
            this.PortionIndex = portionIndex;
            this.Dto = dto;
            this.Folder = folder;
            this.Storage = storage;
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
        /// Object path.
        /// </summary>  
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets ParagraphIndex
        /// </summary>  
        public int ParagraphIndex { get; set; }

        /// <summary>
        /// Gets or sets PortionIndex
        /// </summary>  
        public int PortionIndex { get; set; }

        /// <summary>
        /// Object dto.
        /// </summary>  
        public ResourceBase Dto { get; set; }

        /// <summary>
        /// Presentation folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Presentation storage.
        /// </summary>  
        public string Storage { get; set; }
  }
}