
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSlideSaveAsRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PostSlideSaveAs" /> operation.
  /// </summary>  
  public class PostSlideSaveAsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlideSaveAsRequest"/> class.
        /// </summary>        
        public PostSlideSaveAsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSlideSaveAsRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slideIndex"></param>
        /// <param name="format"></param>
        /// <param name="options">export options</param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="folder"></param>
        /// <param name="storage"></param>
        /// <param name="fontsFolder"></param>
        public PostSlideSaveAsRequest(string name, int slideIndex, SlideExportFormat format, ExportOptions options = null, int? width = null, int? height = null, string folder = null, string storage = null, string fontsFolder = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.Format = format;
            this.Options = options;
            this.Width = width;
            this.Height = height;
            this.Folder = folder;
            this.Storage = storage;
            this.FontsFolder = fontsFolder;
        }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets SlideIndex
        /// </summary>  
        public int SlideIndex { get; set; }

        /// <summary>
        /// Gets or sets Format
        /// </summary>  
        public SlideExportFormat Format { get; set; }

        /// <summary>
        /// export options
        /// </summary>  
        public ExportOptions Options { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets Folder
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets Storage
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets FontsFolder
        /// </summary>  
        public string FontsFolder { get; set; }
  }
}