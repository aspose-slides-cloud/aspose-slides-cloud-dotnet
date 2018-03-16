// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GradientFill.cs">
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
  /// Represents gradient fill format
  /// </summary>  
  public class GradientFill : FillFormat 
  {                       
        /// <summary>
        /// Gets or sets Direction
        /// </summary>
        public GradientDirection Direction { get; set; }

        /// <summary>
        /// Gets or sets Shape
        /// </summary>
        public GradientShapeType Shape { get; set; }

        /// <summary>
        /// Gets or sets Stops
        /// </summary>
        public List<GradientFillStop> Stops { get; set; }

        /// <summary>
        /// Gets or sets LinearAngle
        /// </summary>
        public double? LinearAngle { get; set; }

        /// <summary>
        /// Gets or sets IsScaled
        /// </summary>
        public bool? IsScaled { get; set; }

        /// <summary>
        /// Gets or sets TileFlip
        /// </summary>
        public GradientTileFlip TileFlip { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class GradientFill {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Direction: ").Append(this.Direction).Append("\n");
          sb.Append("  Shape: ").Append(this.Shape).Append("\n");
          sb.Append("  Stops: ").Append(this.Stops).Append("\n");
          sb.Append("  LinearAngle: ").Append(this.LinearAngle).Append("\n");
          sb.Append("  IsScaled: ").Append(this.IsScaled).Append("\n");
          sb.Append("  TileFlip: ").Append(this.TileFlip).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
