
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostPresentationSplitRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PostPresentationSplit" /> operation.
  /// </summary>  
  public class PostPresentationSplitRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostPresentationSplitRequest"/> class.
        /// </summary>        
        public PostPresentationSplitRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPresentationSplitRequest"/> class.
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
        public PostPresentationSplitRequest(System.IO.Stream document, SlideExportFormat format, int? width = null, int? height = null, int? from = null, int? to = null, string password = null, string storage = null, string fontsFolder = null)
        {
            this.Document = document;
            this.Format = format;
            this.Width = width;
            this.Height = height;
            this.From = from;
            this.To = to;
            this.Password = password;
            this.Storage = storage;
            this.FontsFolder = fontsFolder;
        }

        /// <summary>
        /// Document data.
        /// </summary>  
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// ExportFormat
        /// </summary>  
        public SlideExportFormat Format { get; set; }

        /// <summary>
        /// Slide width.
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Slide height.
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// The start slide number for splitting, if is not specified splitting starts from the first slide of the presentation.
        /// </summary>  
        public int? From { get; set; }

        /// <summary>
        /// The last slide number for splitting, if is not specified splitting ends at the last slide of the document.
        /// </summary>  
        public int? To { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Custom fonts folder.
        /// </summary>  
        public string FontsFolder { get; set; }
  }
}