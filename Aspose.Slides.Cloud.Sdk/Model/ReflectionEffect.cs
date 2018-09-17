// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ReflectionEffect.cs">
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
  /// Represents reflection effect 
  /// </summary>  
  public class ReflectionEffect 
  {                       
        /// <summary>
        /// direction
        /// </summary>
        public double? Direction { get; set; }

        /// <summary>
        /// fade direction
        /// </summary>
        public double? FadeDirection { get; set; }

        /// <summary>
        /// distance
        /// </summary>
        public double? Distance { get; set; }

        /// <summary>
        /// blur radius
        /// </summary>
        public double? BlurRadius { get; set; }

        /// <summary>
        /// scale horizontal
        /// </summary>
        public double? ScaleHorizontal { get; set; }

        /// <summary>
        /// scale vertical
        /// </summary>
        public double? ScaleVertical { get; set; }

        /// <summary>
        /// skew horizontal
        /// </summary>
        public double? SkewHorizontal { get; set; }

        /// <summary>
        /// skew vertical
        /// </summary>
        public double? SkewVertical { get; set; }

        /// <summary>
        /// start pos alpha
        /// </summary>
        public double? StartPosAlpha { get; set; }

        /// <summary>
        /// end pos alpha
        /// </summary>
        public double? EndPosAlpha { get; set; }

        /// <summary>
        /// start reflection opacity
        /// </summary>
        public double? StartReflectionOpacity { get; set; }

        /// <summary>
        /// end reflection opacity
        /// </summary>
        public double? EndReflectionOpacity { get; set; }

        /// <summary>
        /// rectangle alignment
        /// </summary>
        public RectangleAlignment RectangleAlign { get; set; }

        /// <summary>
        /// true if the reflection should rotate with the shape when the shape is rotated
        /// </summary>
        public bool? RotateShadowWithShape { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public ReflectionEffect() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ReflectionEffect {\n");
          sb.Append("  Direction: ").Append(this.Direction).Append("\n");
          sb.Append("  FadeDirection: ").Append(this.FadeDirection).Append("\n");
          sb.Append("  Distance: ").Append(this.Distance).Append("\n");
          sb.Append("  BlurRadius: ").Append(this.BlurRadius).Append("\n");
          sb.Append("  ScaleHorizontal: ").Append(this.ScaleHorizontal).Append("\n");
          sb.Append("  ScaleVertical: ").Append(this.ScaleVertical).Append("\n");
          sb.Append("  SkewHorizontal: ").Append(this.SkewHorizontal).Append("\n");
          sb.Append("  SkewVertical: ").Append(this.SkewVertical).Append("\n");
          sb.Append("  StartPosAlpha: ").Append(this.StartPosAlpha).Append("\n");
          sb.Append("  EndPosAlpha: ").Append(this.EndPosAlpha).Append("\n");
          sb.Append("  StartReflectionOpacity: ").Append(this.StartReflectionOpacity).Append("\n");
          sb.Append("  EndReflectionOpacity: ").Append(this.EndReflectionOpacity).Append("\n");
          sb.Append("  RectangleAlign: ").Append(this.RectangleAlign).Append("\n");
          sb.Append("  RotateShadowWithShape: ").Append(this.RotateShadowWithShape).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
