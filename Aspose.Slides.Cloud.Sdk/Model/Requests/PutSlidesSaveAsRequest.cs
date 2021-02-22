// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutSlidesSaveAsRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PutSlidesSaveAs" /> operation.
  /// </summary>  
  public class PutSlidesSaveAsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesSaveAsRequest"/> class.
        /// </summary>        
        public PutSlidesSaveAsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesSaveAsRequest"/> class.
        /// </summary>
        /// <param name="name">Document name.</param>
        /// <param name="outPath">Output path.</param>
        /// <param name="format">Export format.</param>
        /// <param name="options">Export options.</param>
        /// <param name="password">Document password.</param>
        /// <param name="storage">Document storage.</param>
        /// <param name="folder">Document folder.</param>
        /// <param name="fontsFolder">Custom fonts folder.</param>
        public PutSlidesSaveAsRequest(string name, string outPath, ExportFormat format, ExportOptions options = null, string password = null, string storage = null, string folder = null, string fontsFolder = null)
        {
            this.Name = name;
            this.OutPath = outPath;
            this.Format = format;
            this.Options = options;
            this.Password = password;
            this.Storage = storage;
            this.Folder = folder;
            this.FontsFolder = fontsFolder;
        }

        /// <summary>
        /// Document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Output path.
        /// </summary>  
        public string OutPath { get; set; }

        /// <summary>
        /// Export format.
        /// </summary>  
        public ExportFormat Format { get; set; }

        /// <summary>
        /// Export options.
        /// </summary>  
        public ExportOptions Options { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Custom fonts folder.
        /// </summary>  
        public string FontsFolder { get; set; }
  }
}
