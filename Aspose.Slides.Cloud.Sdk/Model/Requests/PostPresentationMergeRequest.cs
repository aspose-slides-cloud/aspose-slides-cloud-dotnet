
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostPresentationMergeRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PostPresentationMerge" /> operation.
  /// </summary>  
  public class PostPresentationMergeRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostPresentationMergeRequest"/> class.
        /// </summary>        
        public PostPresentationMergeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPresentationMergeRequest"/> class.
        /// </summary>
        /// <param name="name">Document name.</param>
        /// <param name="request">PresentationsMergeRequest with a list of presentations to merge.</param>
        /// <param name="password">Document password.</param>
        /// <param name="storage">Document storage.</param>
        /// <param name="folder">Document folder.</param>
        public PostPresentationMergeRequest(string name, PresentationsMergeRequest request, string password = null, string storage = null, string folder = null)
        {
            this.Name = name;
            this.Request = request;
            this.Password = password;
            this.Storage = storage;
            this.Folder = folder;
        }

        /// <summary>
        /// Document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// PresentationsMergeRequest with a list of presentations to merge.
        /// </summary>  
        public PresentationsMergeRequest Request { get; set; }

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
  }
}