
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSlidesDocumentRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.DocumentApi.PostSlidesDocument" /> operation.
  /// </summary>  
  public class PostSlidesDocumentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesDocumentRequest"/> class.
        /// </summary>        
        public PostSlidesDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesDocumentRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="data"></param>
        /// <param name="templatePath">Template file path.</param>
        /// <param name="templateStorage">Template storage name.</param>
        /// <param name="isImageDataEmbeeded">Is Image Data Embeeded</param>
        /// <param name="password">The document password.</param>
        /// <param name="storage">Document&#39;s storage.</param>
        /// <param name="folder">Document&#39;s folder.</param>
        public PostSlidesDocumentRequest(string name, string data, string templatePath, string templateStorage = null, bool? isImageDataEmbeeded = null, string password = null, string storage = null, string folder = null)
        {
            this.Name = name;
            this.Data = data;
            this.TemplatePath = templatePath;
            this.TemplateStorage = templateStorage;
            this.IsImageDataEmbeeded = isImageDataEmbeeded;
            this.Password = password;
            this.Storage = storage;
            this.Folder = folder;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Data
        /// </summary>  
        public string Data { get; set; }

        /// <summary>
        /// Template file path.
        /// </summary>  
        public string TemplatePath { get; set; }

        /// <summary>
        /// Template storage name.
        /// </summary>  
        public string TemplateStorage { get; set; }

        /// <summary>
        /// Is Image Data Embeeded
        /// </summary>  
        public bool? IsImageDataEmbeeded { get; set; }

        /// <summary>
        /// The document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Document's storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Document's folder.
        /// </summary>  
        public string Folder { get; set; }
  }
}