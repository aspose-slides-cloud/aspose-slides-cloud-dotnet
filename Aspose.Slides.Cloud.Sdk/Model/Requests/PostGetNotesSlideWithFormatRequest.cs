
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostGetNotesSlideWithFormatRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PostGetNotesSlideWithFormat" /> operation.
  /// </summary>  
  public class PostGetNotesSlideWithFormatRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostGetNotesSlideWithFormatRequest"/> class.
        /// </summary>        
        public PostGetNotesSlideWithFormatRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostGetNotesSlideWithFormatRequest"/> class.
        /// </summary>
        /// <param name="document">Document data.</param>
        /// <param name="slideIndex">Slide index.</param>
        /// <param name="format">Output file format.</param>
        /// <param name="width">Output file width.</param>
        /// <param name="height">Output file height.</param>
        /// <param name="password">Document password.</param>
        /// <param name="fontsFolder">Storage folder containing custom fonts to be used with the document.</param>
        public PostGetNotesSlideWithFormatRequest(System.IO.Stream document, int slideIndex, NotesSlideExportFormat format, int? width = null, int? height = null, string password = null, string fontsFolder = null)
        {
            this.Document = document;
            this.SlideIndex = slideIndex;
            this.Format = format;
            this.Width = width;
            this.Height = height;
            this.Password = password;
            this.FontsFolder = fontsFolder;
        }

        /// <summary>
        /// Document data.
        /// </summary>  
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Slide index.
        /// </summary>  
        public int SlideIndex { get; set; }

        /// <summary>
        /// Output file format.
        /// </summary>  
        public NotesSlideExportFormat Format { get; set; }

        /// <summary>
        /// Output file width.
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Output file height.
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Storage folder containing custom fonts to be used with the document.
        /// </summary>  
        public string FontsFolder { get; set; }
  }
}