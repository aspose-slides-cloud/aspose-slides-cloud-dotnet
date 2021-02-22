// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSlidesCopyRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PostSlidesCopy" /> operation.
  /// </summary>  
  public class PostSlidesCopyRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesCopyRequest"/> class.
        /// </summary>        
        public PostSlidesCopyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesCopyRequest"/> class.
        /// </summary>
        /// <param name="name">Document name.</param>
        /// <param name="slideToCopy">The index of the slide to be copied from the source presentation.</param>
        /// <param name="position">The target position at which to copy the slide. Copy to the end by default.</param>
        /// <param name="source">Name of the document to copy a slide from.</param>
        /// <param name="sourcePassword">Password for the document to copy a slide from.</param>
        /// <param name="sourceStorage">Template storage name.</param>
        /// <param name="password">Document password.</param>
        /// <param name="folder">Document folder.</param>
        /// <param name="storage">Document storage.</param>
        public PostSlidesCopyRequest(string name, int slideToCopy, int? position = null, string source = null, string sourcePassword = null, string sourceStorage = null, string password = null, string folder = null, string storage = null)
        {
            this.Name = name;
            this.SlideToCopy = slideToCopy;
            this.Position = position;
            this.Source = source;
            this.SourcePassword = sourcePassword;
            this.SourceStorage = sourceStorage;
            this.Password = password;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// Document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The index of the slide to be copied from the source presentation.
        /// </summary>  
        public int SlideToCopy { get; set; }

        /// <summary>
        /// The target position at which to copy the slide. Copy to the end by default.
        /// </summary>  
        public int? Position { get; set; }

        /// <summary>
        /// Name of the document to copy a slide from.
        /// </summary>  
        public string Source { get; set; }

        /// <summary>
        /// Password for the document to copy a slide from.
        /// </summary>  
        public string SourcePassword { get; set; }

        /// <summary>
        /// Template storage name.
        /// </summary>  
        public string SourceStorage { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Document storage.
        /// </summary>  
        public string Storage { get; set; }
  }
}
