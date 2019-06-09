// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ColorScheme.cs">
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
  /// Slide&#39;s color scheme DTO
  /// </summary>  
  public class ColorScheme : ResourceBase 
  {                       
        /// <summary>
        /// Gets or sets Accent1
        /// </summary>
        public string Accent1 { get; set; }

        /// <summary>
        /// Gets or sets Accent2
        /// </summary>
        public string Accent2 { get; set; }

        /// <summary>
        /// Gets or sets Accent3
        /// </summary>
        public string Accent3 { get; set; }

        /// <summary>
        /// Gets or sets Accent4
        /// </summary>
        public string Accent4 { get; set; }

        /// <summary>
        /// Gets or sets Accent5
        /// </summary>
        public string Accent5 { get; set; }

        /// <summary>
        /// Gets or sets Accent6
        /// </summary>
        public string Accent6 { get; set; }

        /// <summary>
        /// Gets or sets Dark1
        /// </summary>
        public string Dark1 { get; set; }

        /// <summary>
        /// Gets or sets Dark2
        /// </summary>
        public string Dark2 { get; set; }

        /// <summary>
        /// Gets or sets FollowedHyperlink
        /// </summary>
        public string FollowedHyperlink { get; set; }

        /// <summary>
        /// Gets or sets Hyperlink
        /// </summary>
        public string Hyperlink { get; set; }

        /// <summary>
        /// Gets or sets Light1
        /// </summary>
        public string Light1 { get; set; }

        /// <summary>
        /// Gets or sets Light2
        /// </summary>
        public string Light2 { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public ColorScheme() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ColorScheme {\n");
          sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
          sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
          sb.Append("  Accent1: ").Append(this.Accent1).Append("\n");
          sb.Append("  Accent2: ").Append(this.Accent2).Append("\n");
          sb.Append("  Accent3: ").Append(this.Accent3).Append("\n");
          sb.Append("  Accent4: ").Append(this.Accent4).Append("\n");
          sb.Append("  Accent5: ").Append(this.Accent5).Append("\n");
          sb.Append("  Accent6: ").Append(this.Accent6).Append("\n");
          sb.Append("  Dark1: ").Append(this.Dark1).Append("\n");
          sb.Append("  Dark2: ").Append(this.Dark2).Append("\n");
          sb.Append("  FollowedHyperlink: ").Append(this.FollowedHyperlink).Append("\n");
          sb.Append("  Hyperlink: ").Append(this.Hyperlink).Append("\n");
          sb.Append("  Light1: ").Append(this.Light1).Append("\n");
          sb.Append("  Light2: ").Append(this.Light2).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
