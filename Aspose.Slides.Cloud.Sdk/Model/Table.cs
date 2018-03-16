// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Table.cs">
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
  /// Represents Table resource.
  /// </summary>  
  public class Table : ShapeBase 
  {                       
        /// <summary>
        /// Gets or sets Style
        /// </summary>
        public TableStylePreset Style { get; set; }

        /// <summary>
        /// Gets or sets Rows
        /// </summary>
        public List<TableRow> Rows { get; set; }

        /// <summary>
        /// Gets or sets Columns
        /// </summary>
        public List<TableColumn> Columns { get; set; }

        /// <summary>
        /// Determines whether the first column of a table has to be drawn with a special formatting.
        /// </summary>
        public bool? FirstCol { get; set; }

        /// <summary>
        /// Determines whether the first row of a table has to be drawn with a special formatting.
        /// </summary>
        public bool? FirstRow { get; set; }

        /// <summary>
        /// Determines whether the even rows has to be drawn with a different formatting.
        /// </summary>
        public bool? HorizontalBanding { get; set; }

        /// <summary>
        /// Determines whether the last column of a table has to be drawn with a special formatting.
        /// </summary>
        public bool? LastCol { get; set; }

        /// <summary>
        /// Determines whether the last row of a table has to be drawn with a special formatting.
        /// </summary>
        public bool? LastRow { get; set; }

        /// <summary>
        /// Determines whether the table has right to left reading order.
        /// </summary>
        public bool? RightToLeft { get; set; }

        /// <summary>
        /// Determines whether the even columns has to be drawn with a different formatting.
        /// </summary>
        public bool? VerticalBanding { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Table {\n");
          sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
          sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
          sb.Append("  Links: ").Append(this.Links).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  ShapeType: ").Append(this.ShapeType).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  AlternativeText: ").Append(this.AlternativeText).Append("\n");
          sb.Append("  Hidden: ").Append(this.Hidden).Append("\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("  ZOrderPosition: ").Append(this.ZOrderPosition).Append("\n");
          sb.Append("  Shapes: ").Append(this.Shapes).Append("\n");
          sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
          sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
          sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
          sb.Append("  Style: ").Append(this.Style).Append("\n");
          sb.Append("  Rows: ").Append(this.Rows).Append("\n");
          sb.Append("  Columns: ").Append(this.Columns).Append("\n");
          sb.Append("  FirstCol: ").Append(this.FirstCol).Append("\n");
          sb.Append("  FirstRow: ").Append(this.FirstRow).Append("\n");
          sb.Append("  HorizontalBanding: ").Append(this.HorizontalBanding).Append("\n");
          sb.Append("  LastCol: ").Append(this.LastCol).Append("\n");
          sb.Append("  LastRow: ").Append(this.LastRow).Append("\n");
          sb.Append("  RightToLeft: ").Append(this.RightToLeft).Append("\n");
          sb.Append("  VerticalBanding: ").Append(this.VerticalBanding).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
