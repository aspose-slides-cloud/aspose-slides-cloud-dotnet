
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSlidesSplitRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.DocumentApi.PostSlidesSplit" /> operation.
  /// </summary>  
  public class PostSlidesSplitRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesSplitRequest"/> class.
        /// </summary>        
        public PostSlidesSplitRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesSplitRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="options">export options</param>
        /// <param name="format">The format. Default value is jpeg.</param>
        /// <param name="width">The width of created images.</param>
        /// <param name="height">The height of created images.</param>
        /// <param name="to">The last slide number for splitting, if is not specified splitting ends at the last slide of the document.</param>
        /// <param name="from">The start slide number for splitting, if is not specified splitting starts from the first slide of the presentation.</param>
        /// <param name="destFolder">Folder on storage where images are going to be uploaded. If not specified then images are uploaded to same folder as presentation.</param>
        /// <param name="password">The document password.</param>
        /// <param name="storage">The document storage.</param>
        /// <param name="folder">The document folder.</param>
        public PostSlidesSplitRequest(string name, ExportOptions options = null, SlideExportFormat? format = null, int? width = null, int? height = null, int? to = null, int? from = null, string destFolder = null, string password = null, string storage = null, string folder = null)
        {
            this.Name = name;
            this.Options = options;
            this.Format = format;
            this.Width = width;
            this.Height = height;
            this.To = to;
            this.From = from;
            this.DestFolder = destFolder;
            this.Password = password;
            this.Storage = storage;
            this.Folder = folder;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// export options
        /// </summary>  
        public ExportOptions Options { get; set; }

        /// <summary>
        /// The format. Default value is jpeg.
        /// </summary>  
        public SlideExportFormat? Format { get; set; }

        /// <summary>
        /// The width of created images.
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// The height of created images.
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// The last slide number for splitting, if is not specified splitting ends at the last slide of the document.
        /// </summary>  
        public int? To { get; set; }

        /// <summary>
        /// The start slide number for splitting, if is not specified splitting starts from the first slide of the presentation.
        /// </summary>  
        public int? From { get; set; }

        /// <summary>
        /// Folder on storage where images are going to be uploaded. If not specified then images are uploaded to same folder as presentation.
        /// </summary>  
        public string DestFolder { get; set; }

        /// <summary>
        /// The document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// The document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// The document folder.
        /// </summary>  
        public string Folder { get; set; }
  }
}