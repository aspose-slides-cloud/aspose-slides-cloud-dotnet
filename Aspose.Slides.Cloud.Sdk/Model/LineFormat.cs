// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LineFormat.cs">
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
  public class LineFormat 
  {                       
        /// <summary>
        /// Gets or sets Alignment
        /// </summary>
        public LineAlignment Alignment { get; set; }

        /// <summary>
        /// Gets or sets CapStyle
        /// </summary>
        public LineCapStyle CapStyle { get; set; }

        /// <summary>
        /// Gets or sets DashStyle
        /// </summary>
        public LineDashStyle DashStyle { get; set; }

        /// <summary>
        /// Gets or sets JoinStyle
        /// </summary>
        public LineJoinStyle JoinStyle { get; set; }

        /// <summary>
        /// Gets or sets Style
        /// </summary>
        public LineStyle Style { get; set; }

        /// <summary>
        /// Gets or sets BeginArrowHead
        /// </summary>
        public ArrowHeadProperties BeginArrowHead { get; set; }

        /// <summary>
        /// Gets or sets EndArrowHead
        /// </summary>
        public ArrowHeadProperties EndArrowHead { get; set; }

        /// <summary>
        /// Gets or sets CustomDashPattern
        /// </summary>
        public CustomDashPattern CustomDashPattern { get; set; }

        /// <summary>
        /// Gets or sets FillFormat
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Gets or sets MiterLimit
        /// </summary>
        public double? MiterLimit { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class LineFormat {\n");
          sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
          sb.Append("  CapStyle: ").Append(this.CapStyle).Append("\n");
          sb.Append("  DashStyle: ").Append(this.DashStyle).Append("\n");
          sb.Append("  JoinStyle: ").Append(this.JoinStyle).Append("\n");
          sb.Append("  Style: ").Append(this.Style).Append("\n");
          sb.Append("  BeginArrowHead: ").Append(this.BeginArrowHead).Append("\n");
          sb.Append("  EndArrowHead: ").Append(this.EndArrowHead).Append("\n");
          sb.Append("  CustomDashPattern: ").Append(this.CustomDashPattern).Append("\n");
          sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
          sb.Append("  MiterLimit: ").Append(this.MiterLimit).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
