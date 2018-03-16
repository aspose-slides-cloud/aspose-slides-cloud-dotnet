
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
        /// <param name="name"></param>
        /// <param name="format"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="destFolder"></param>
        /// <param name="storage"></param>
        /// <param name="folder"></param>
        public PostSlidesSplitRequest(string name, SlideExportFormat? format = null, int? width = null, int? height = null, int? to = null, int? from = null, string destFolder = null, string storage = null, string folder = null)
        {
            this.Name = name;
            this.Format = format;
            this.Width = width;
            this.Height = height;
            this.To = to;
            this.From = from;
            this.DestFolder = destFolder;
            this.Storage = storage;
            this.Folder = folder;
        }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Format
        /// </summary>  
        public SlideExportFormat? Format { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets To
        /// </summary>  
        public int? To { get; set; }

        /// <summary>
        /// Gets or sets From
        /// </summary>  
        public int? From { get; set; }

        /// <summary>
        /// Gets or sets DestFolder
        /// </summary>  
        public string DestFolder { get; set; }

        /// <summary>
        /// Gets or sets Storage
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets Folder
        /// </summary>  
        public string Folder { get; set; }
  }
}