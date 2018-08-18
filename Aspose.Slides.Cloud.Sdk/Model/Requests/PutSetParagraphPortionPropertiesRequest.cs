// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutSetParagraphPortionPropertiesRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.ShapesApi.PutSetParagraphPortionProperties" /> operation.
  /// </summary>  
  public class PutSetParagraphPortionPropertiesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutSetParagraphPortionPropertiesRequest"/> class.
        /// </summary>        
        public PutSetParagraphPortionPropertiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSetParagraphPortionPropertiesRequest"/> class.
        /// </summary>
        /// <param name="name">Presentation name.</param>
        /// <param name="slideIndex">Slide index.</param>
        /// <param name="path">Object path.</param>
        /// <param name="shapeIndex">Shape index.</param>
        /// <param name="paragraphIndex">Paragraph index.</param>
        /// <param name="portionIndex">Portion index.</param>
        /// <param name="dto">Shape dto.</param>
        /// <param name="password">Document password.</param>
        /// <param name="folder">Presentation folder.</param>
        /// <param name="storage">Presentation storage.</param>
        public PutSetParagraphPortionPropertiesRequest(string name, int slideIndex, string path, int shapeIndex, int paragraphIndex, int portionIndex, Portion dto = null, string password = null, string folder = null, string storage = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.Path = path;
            this.ShapeIndex = shapeIndex;
            this.ParagraphIndex = paragraphIndex;
            this.PortionIndex = portionIndex;
            this.Dto = dto;
            this.Password = password;
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
        /// Shape index.
        /// </summary>  
        public int ShapeIndex { get; set; }

        /// <summary>
        /// Paragraph index.
        /// </summary>  
        public int ParagraphIndex { get; set; }

        /// <summary>
        /// Portion index.
        /// </summary>  
        public int PortionIndex { get; set; }

        /// <summary>
        /// Shape dto.
        /// </summary>  
        public Portion Dto { get; set; }

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
  }
}
