// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TiffExportOptions.cs">
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Xml.Serialization;

namespace Aspose.Slides.Cloud.Sdk.Model
{
  /// <summary>
  /// 
  /// </summary>  
  public class TiffExportOptions : ExportOptions 
  {                       
        /// <summary>
        /// Gets or sets Compression
        /// </summary>
        public TiffCompressionType Compression { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets DpiX
        /// </summary>
        public int? DpiX { get; set; }

        /// <summary>
        /// Gets or sets DpiY
        /// </summary>
        public int? DpiY { get; set; }

        /// <summary>
        /// Specifies whether the generated document should include hidden slides or not. Default is false. 
        /// </summary>
        public bool? ShowHiddenSlides { get; set; }

        /// <summary>
        /// Specifies the pixel format for the generated images. Read/write .
        /// </summary>
        public ImagePixelFormat PixelFormat { get; set; }

        /// <summary>
        /// Gets or sets the position of the notes on the page.
        /// </summary>
        public NotesPositions NotesPosition { get; set; }

        /// <summary>
        /// Gets or sets the position of the comments on the page.
        /// </summary>
        public CommentsPositions CommentsPosition { get; set; }

        /// <summary>
        /// Gets or sets the width of the comment output area in pixels (Applies only if comments are displayed on the right).
        /// </summary>
        public int? CommentsAreaWidth { get; set; }

        /// <summary>
        /// Gets or sets the color of comments area (Applies only if comments are displayed on the right).
        /// </summary>
        public string CommentsAreaColor { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public TiffExportOptions() : base()
        {
          Format = "tiff";
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TiffExportOptions {\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  Compression: ").Append(this.Compression).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  DpiX: ").Append(this.DpiX).Append("\n");
          sb.Append("  DpiY: ").Append(this.DpiY).Append("\n");
          sb.Append("  ShowHiddenSlides: ").Append(this.ShowHiddenSlides).Append("\n");
          sb.Append("  PixelFormat: ").Append(this.PixelFormat).Append("\n");
          sb.Append("  NotesPosition: ").Append(this.NotesPosition).Append("\n");
          sb.Append("  CommentsPosition: ").Append(this.CommentsPosition).Append("\n");
          sb.Append("  CommentsAreaWidth: ").Append(this.CommentsAreaWidth).Append("\n");
          sb.Append("  CommentsAreaColor: ").Append(this.CommentsAreaColor).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
