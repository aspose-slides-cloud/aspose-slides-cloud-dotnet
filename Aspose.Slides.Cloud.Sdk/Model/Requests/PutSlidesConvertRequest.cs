// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutSlidesConvertRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.DocumentApi.PutSlidesConvert" /> operation.
  /// </summary>  
  public class PutSlidesConvertRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesConvertRequest"/> class.
        /// </summary>        
        public PutSlidesConvertRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesConvertRequest"/> class.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="document"></param>
        /// <param name="password">The document password.</param>
        /// <param name="outPath">Path to save result</param>
        /// <param name="fontsFolder">The optional custom fonts folder.</param>
        public PutSlidesConvertRequest(ExportFormat format, Stream document = null, string password = null, string outPath = null, string fontsFolder = null)
        {
            this.Format = format;
            this.Document = document;
            this.Password = password;
            this.OutPath = outPath;
            this.FontsFolder = fontsFolder;
        }

        /// <summary>
        /// The format.
        /// </summary>  
        public ExportFormat Format { get; set; }

        /// <summary>
        /// Gets or sets Document
        /// </summary>  
        public Stream Document { get; set; }

        /// <summary>
        /// The document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Path to save result
        /// </summary>  
        public string OutPath { get; set; }

        /// <summary>
        /// The optional custom fonts folder.
        /// </summary>  
        public string FontsFolder { get; set; }
  }
}
