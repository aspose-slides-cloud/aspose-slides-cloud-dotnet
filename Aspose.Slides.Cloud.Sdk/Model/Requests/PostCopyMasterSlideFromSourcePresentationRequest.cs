// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostCopyMasterSlideFromSourcePresentationRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.MasterSlidesApi.PostCopyMasterSlideFromSourcePresentation" /> operation.
  /// </summary>  
  public class PostCopyMasterSlideFromSourcePresentationRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCopyMasterSlideFromSourcePresentationRequest"/> class.
        /// </summary>        
        public PostCopyMasterSlideFromSourcePresentationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCopyMasterSlideFromSourcePresentationRequest"/> class.
        /// </summary>
        /// <param name="name">The presentation name.</param>
        /// <param name="cloneFrom">Source presentation to clone masterSlide from.</param>
        /// <param name="cloneFromPosition">Position of cloning master slide.</param>
        /// <param name="cloneFromPassword">Source presentation password.</param>
        /// <param name="cloneFromStorage">Storage source presentation to clone masterSlide from.</param>
        /// <param name="applyToAll">Apply cloned master slide to every existed slide. Optional parameter, false by default</param>
        /// <param name="password">The presentation password.</param>
        /// <param name="folder">The presentation folder.</param>
        /// <param name="storage">Presentation storage.</param>
        public PostCopyMasterSlideFromSourcePresentationRequest(string name, string cloneFrom, int cloneFromPosition, string cloneFromPassword = null, string cloneFromStorage = null, bool? applyToAll = null, string password = null, string folder = null, string storage = null)
        {
            this.Name = name;
            this.CloneFrom = cloneFrom;
            this.CloneFromPosition = cloneFromPosition;
            this.CloneFromPassword = cloneFromPassword;
            this.CloneFromStorage = cloneFromStorage;
            this.ApplyToAll = applyToAll;
            this.Password = password;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The presentation name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Source presentation to clone masterSlide from.
        /// </summary>  
        public string CloneFrom { get; set; }

        /// <summary>
        /// Position of cloning master slide.
        /// </summary>  
        public int CloneFromPosition { get; set; }

        /// <summary>
        /// Source presentation password.
        /// </summary>  
        public string CloneFromPassword { get; set; }

        /// <summary>
        /// Storage source presentation to clone masterSlide from.
        /// </summary>  
        public string CloneFromStorage { get; set; }

        /// <summary>
        /// Apply cloned master slide to every existed slide. Optional parameter, false by default
        /// </summary>  
        public bool? ApplyToAll { get; set; }

        /// <summary>
        /// The presentation password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// The presentation folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Presentation storage.
        /// </summary>  
        public string Storage { get; set; }
  }
}
