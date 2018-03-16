// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableCell.cs">
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
  /// Represents one cell of table.
  /// </summary>  
  public class TableCell 
  {                       
        /// <summary>
        /// Gets or sets Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets RowSpan
        /// </summary>
        public int? RowSpan { get; set; }

        /// <summary>
        /// Gets or sets ColSpan
        /// </summary>
        public int? ColSpan { get; set; }

        /// <summary>
        /// Gets or sets MarginTop
        /// </summary>
        public double? MarginTop { get; set; }

        /// <summary>
        /// Gets or sets MarginRight
        /// </summary>
        public double? MarginRight { get; set; }

        /// <summary>
        /// Gets or sets MarginLeft
        /// </summary>
        public double? MarginLeft { get; set; }

        /// <summary>
        /// Gets or sets MarginBottom
        /// </summary>
        public double? MarginBottom { get; set; }

        /// <summary>
        /// Gets or sets TextAnchorType
        /// </summary>
        public TextAnchorType TextAnchorType { get; set; }

        /// <summary>
        /// Gets or sets TextVerticalType
        /// </summary>
        public TextVerticalType TextVerticalType { get; set; }

        /// <summary>
        /// Gets or sets FillFormat
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Gets or sets BorderTop
        /// </summary>
        public LineFormat BorderTop { get; set; }

        /// <summary>
        /// Gets or sets BorderRight
        /// </summary>
        public LineFormat BorderRight { get; set; }

        /// <summary>
        /// Gets or sets BorderLeft
        /// </summary>
        public LineFormat BorderLeft { get; set; }

        /// <summary>
        /// Gets or sets BorderBottom
        /// </summary>
        public LineFormat BorderBottom { get; set; }

        /// <summary>
        /// Gets or sets BorderDiagonalUp
        /// </summary>
        public LineFormat BorderDiagonalUp { get; set; }

        /// <summary>
        /// Gets or sets BorderDiagonalDown
        /// </summary>
        public LineFormat BorderDiagonalDown { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableCell {\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  RowSpan: ").Append(this.RowSpan).Append("\n");
          sb.Append("  ColSpan: ").Append(this.ColSpan).Append("\n");
          sb.Append("  MarginTop: ").Append(this.MarginTop).Append("\n");
          sb.Append("  MarginRight: ").Append(this.MarginRight).Append("\n");
          sb.Append("  MarginLeft: ").Append(this.MarginLeft).Append("\n");
          sb.Append("  MarginBottom: ").Append(this.MarginBottom).Append("\n");
          sb.Append("  TextAnchorType: ").Append(this.TextAnchorType).Append("\n");
          sb.Append("  TextVerticalType: ").Append(this.TextVerticalType).Append("\n");
          sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
          sb.Append("  BorderTop: ").Append(this.BorderTop).Append("\n");
          sb.Append("  BorderRight: ").Append(this.BorderRight).Append("\n");
          sb.Append("  BorderLeft: ").Append(this.BorderLeft).Append("\n");
          sb.Append("  BorderBottom: ").Append(this.BorderBottom).Append("\n");
          sb.Append("  BorderDiagonalUp: ").Append(this.BorderDiagonalUp).Append("\n");
          sb.Append("  BorderDiagonalDown: ").Append(this.BorderDiagonalDown).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
