// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeExportOptions.cs">
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
  /// Provides options that control how a shape is saved in thumbnail.
  /// </summary>  
  public class ShapeExportOptions 
  {                       
        /// <summary>
        /// Get or sets scaling ratio by X axis.
        /// </summary>
        public double? ScaleX { get; set; }

        /// <summary>
        /// Get or sets scaling ratio by Y axis.
        /// </summary>
        public double? ScaleY { get; set; }

        /// <summary>
        /// Get or sets thumbnail bounds
        /// </summary>
        public ShapeThumbnailBounds ThumbnailBounds { get; set; }

        /// <summary>
        /// Gets export format.
        /// </summary>
        public ShapeExportFormat Format { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ShapeExportOptions {\n");
          sb.Append("  ScaleX: ").Append(this.ScaleX).Append("\n");
          sb.Append("  ScaleY: ").Append(this.ScaleY).Append("\n");
          sb.Append("  ThumbnailBounds: ").Append(this.ThumbnailBounds).Append("\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
