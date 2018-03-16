
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSlidesSlideReplaceTextRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.TextApi.PostSlidesSlideReplaceText" /> operation.
  /// </summary>  
  public class PostSlidesSlideReplaceTextRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesSlideReplaceTextRequest"/> class.
        /// </summary>        
        public PostSlidesSlideReplaceTextRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlidesSlideReplaceTextRequest"/> class.
        /// </summary>
        /// <param name="name">Presentation name.</param>
        /// <param name="slideIndex">Slide&#39;s index.</param>
        /// <param name="oldValue">Text to replace.</param>
        /// <param name="newValue">New text value.</param>
        /// <param name="ignoreCase">Is case must be ignored.</param>
        /// <param name="folder">Presentation folder.</param>
        /// <param name="storage">Presentation storage.</param>
        public PostSlidesSlideReplaceTextRequest(string name, int slideIndex, string oldValue, string newValue, bool? ignoreCase = null, string folder = null, string storage = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.OldValue = oldValue;
            this.NewValue = newValue;
            this.IgnoreCase = ignoreCase;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// Presentation name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Slide's index.
        /// </summary>  
        public int SlideIndex { get; set; }

        /// <summary>
        /// Text to replace.
        /// </summary>  
        public string OldValue { get; set; }

        /// <summary>
        /// New text value.
        /// </summary>  
        public string NewValue { get; set; }

        /// <summary>
        /// Is case must be ignored.
        /// </summary>  
        public bool? IgnoreCase { get; set; }

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
