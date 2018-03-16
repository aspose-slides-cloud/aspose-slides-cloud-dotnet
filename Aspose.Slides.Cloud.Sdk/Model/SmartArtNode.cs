// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SmartArtNode.cs">
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
  public class SmartArtNode 
  {                       
        /// <summary>
        /// Gets or sets Nodes
        /// </summary>
        public List<SmartArtNode> Nodes { get; set; }

        /// <summary>
        /// Gets or sets Shapes
        /// </summary>
        public ResourceUriElement Shapes { get; set; }

        /// <summary>
        /// Gets or sets IsAssistant
        /// </summary>
        public bool? IsAssistant { get; set; }

        /// <summary>
        /// Gets or sets Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets OrgChartLayout
        /// </summary>
        public OrganizationChartLayoutType OrgChartLayout { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SmartArtNode {\n");
          sb.Append("  Nodes: ").Append(this.Nodes).Append("\n");
          sb.Append("  Shapes: ").Append(this.Shapes).Append("\n");
          sb.Append("  IsAssistant: ").Append(this.IsAssistant).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  OrgChartLayout: ").Append(this.OrgChartLayout).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
