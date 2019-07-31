// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FormatScheme.cs">
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
  /// Represents Format Scheme for slide&#39;s theme
  /// </summary>  
  public class FormatScheme : ResourceBase 
  {                       
        /// <summary>
        /// Background style links.
        /// </summary>
        public List<ResourceUri> BackgroundStyles { get; set; }

        /// <summary>
        /// Effect style links.
        /// </summary>
        public List<ResourceUri> EffectStyles { get; set; }

        /// <summary>
        /// Fill style links.
        /// </summary>
        public List<ResourceUri> FillStyles { get; set; }

        /// <summary>
        /// Line style links.
        /// </summary>
        public List<ResourceUri> LineStyles { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public FormatScheme() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormatScheme {\n");
          sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
          sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
          sb.Append("  BackgroundStyles: ").Append(this.BackgroundStyles).Append("\n");
          sb.Append("  EffectStyles: ").Append(this.EffectStyles).Append("\n");
          sb.Append("  FillStyles: ").Append(this.FillStyles).Append("\n");
          sb.Append("  LineStyles: ").Append(this.LineStyles).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
