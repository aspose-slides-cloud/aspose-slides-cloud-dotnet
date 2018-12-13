
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutSlidesSlideRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PutSlidesSlide" /> operation.
  /// </summary>  
  public class PutSlidesSlideRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesSlideRequest"/> class.
        /// </summary>        
        public PutSlidesSlideRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesSlideRequest"/> class.
        /// </summary>
        /// <param name="name">Name of the presentation.</param>
        /// <param name="slideIndex">Index of the slide update to.</param>
        /// <param name="slideDto">DTO of the slide.</param>
        /// <param name="password"></param>
        /// <param name="folder">The presentation folder.</param>
        /// <param name="storage">The presentation storage.</param>
        public PutSlidesSlideRequest(string name, int slideIndex, Slide slideDto = null, string password = null, string folder = null, string storage = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.SlideDto = slideDto;
            this.Password = password;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// Name of the presentation.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Index of the slide update to.
        /// </summary>  
        public int SlideIndex { get; set; }

        /// <summary>
        /// DTO of the slide.
        /// </summary>  
        public Slide SlideDto { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// The presentation folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// The presentation storage.
        /// </summary>  
        public string Storage { get; set; }
  }
}