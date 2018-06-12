// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Paragraph.cs">
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
  /// Represents paragraph resource
  /// </summary>  
  public class Paragraph : ResourceBase 
  {                       
        /// <summary>
        /// Gets or sets MarginLeft
        /// </summary>
        public double? MarginLeft { get; set; }

        /// <summary>
        /// Gets or sets MarginRight
        /// </summary>
        public double? MarginRight { get; set; }

        /// <summary>
        /// Gets or sets SpaceBefore
        /// </summary>
        public double? SpaceBefore { get; set; }

        /// <summary>
        /// Gets or sets SpaceAfter
        /// </summary>
        public double? SpaceAfter { get; set; }

        /// <summary>
        /// Gets or sets SpaceWithin
        /// </summary>
        public double? SpaceWithin { get; set; }

        /// <summary>
        /// Gets or sets Indent
        /// </summary>
        public double? Indent { get; set; }

        /// <summary>
        /// Gets or sets Alignment
        /// </summary>
        public TextAlignment Alignment { get; set; }

        /// <summary>
        /// Gets or sets FontAlignment
        /// </summary>
        public FontAlignment FontAlignment { get; set; }

        /// <summary>
        /// Gets or sets DefaultTabSize
        /// </summary>
        public double? DefaultTabSize { get; set; }

        /// <summary>
        /// Gets or sets Depth
        /// </summary>
        public int? Depth { get; set; }

        /// <summary>
        /// Gets or sets BulletChar
        /// </summary>
        public string BulletChar { get; set; }

        /// <summary>
        /// Gets or sets BulletHeight
        /// </summary>
        public double? BulletHeight { get; set; }

        /// <summary>
        /// Gets or sets BulletType
        /// </summary>
        public BulletType BulletType { get; set; }

        /// <summary>
        /// Gets or sets NumberedBulletStartWith
        /// </summary>
        public int? NumberedBulletStartWith { get; set; }

        /// <summary>
        /// Gets or sets NumberedBulletStyle
        /// </summary>
        public NumberedBulletStyle NumberedBulletStyle { get; set; }

        /// <summary>
        /// Gets or sets HangingPunctuation
        /// </summary>
        public bool? HangingPunctuation { get; set; }

        /// <summary>
        /// Gets or sets EastAsianLineBreak
        /// </summary>
        public bool? EastAsianLineBreak { get; set; }

        /// <summary>
        /// Gets or sets LatinLineBreak
        /// </summary>
        public bool? LatinLineBreak { get; set; }

        /// <summary>
        /// Gets or sets RightToLeft
        /// </summary>
        public bool? RightToLeft { get; set; }

        /// <summary>
        /// Gets or sets PortionList
        /// </summary>
        public List<ResourceUriElement> PortionList { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Paragraph {\n");
          sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
          sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
          sb.Append("  Links: ").Append(this.Links).Append("\n");
          sb.Append("  MarginLeft: ").Append(this.MarginLeft).Append("\n");
          sb.Append("  MarginRight: ").Append(this.MarginRight).Append("\n");
          sb.Append("  SpaceBefore: ").Append(this.SpaceBefore).Append("\n");
          sb.Append("  SpaceAfter: ").Append(this.SpaceAfter).Append("\n");
          sb.Append("  SpaceWithin: ").Append(this.SpaceWithin).Append("\n");
          sb.Append("  Indent: ").Append(this.Indent).Append("\n");
          sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
          sb.Append("  FontAlignment: ").Append(this.FontAlignment).Append("\n");
          sb.Append("  DefaultTabSize: ").Append(this.DefaultTabSize).Append("\n");
          sb.Append("  Depth: ").Append(this.Depth).Append("\n");
          sb.Append("  BulletChar: ").Append(this.BulletChar).Append("\n");
          sb.Append("  BulletHeight: ").Append(this.BulletHeight).Append("\n");
          sb.Append("  BulletType: ").Append(this.BulletType).Append("\n");
          sb.Append("  NumberedBulletStartWith: ").Append(this.NumberedBulletStartWith).Append("\n");
          sb.Append("  NumberedBulletStyle: ").Append(this.NumberedBulletStyle).Append("\n");
          sb.Append("  HangingPunctuation: ").Append(this.HangingPunctuation).Append("\n");
          sb.Append("  EastAsianLineBreak: ").Append(this.EastAsianLineBreak).Append("\n");
          sb.Append("  LatinLineBreak: ").Append(this.LatinLineBreak).Append("\n");
          sb.Append("  RightToLeft: ").Append(this.RightToLeft).Append("\n");
          sb.Append("  PortionList: ").Append(this.PortionList).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
