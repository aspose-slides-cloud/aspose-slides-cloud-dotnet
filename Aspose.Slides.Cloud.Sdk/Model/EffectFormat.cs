// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EffectFormat.cs">
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
  /// Effect format
  /// </summary>  
  public class EffectFormat 
  {                       
        /// <summary>
        /// blur effect
        /// </summary>
        public BlurEffect Blur { get; set; }

        /// <summary>
        /// glow effect
        /// </summary>
        public GlowEffect Glow { get; set; }

        /// <summary>
        /// inner shadow effect
        /// </summary>
        public InnerShadowEffect InnerShadow { get; set; }

        /// <summary>
        /// outer shadow effect
        /// </summary>
        public OuterShadowEffect OuterShadow { get; set; }

        /// <summary>
        /// preset shadow effect
        /// </summary>
        public PresetShadowEffect PresetShadow { get; set; }

        /// <summary>
        /// soft edge effect
        /// </summary>
        public SoftEdgeEffect SoftEdge { get; set; }

        /// <summary>
        /// reflection effect
        /// </summary>
        public ReflectionEffect Reflection { get; set; }

        /// <summary>
        /// fill overlay effect
        /// </summary>
        public FillOverlayEffect FillOverlay { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EffectFormat {\n");
          sb.Append("  Blur: ").Append(this.Blur).Append("\n");
          sb.Append("  Glow: ").Append(this.Glow).Append("\n");
          sb.Append("  InnerShadow: ").Append(this.InnerShadow).Append("\n");
          sb.Append("  OuterShadow: ").Append(this.OuterShadow).Append("\n");
          sb.Append("  PresetShadow: ").Append(this.PresetShadow).Append("\n");
          sb.Append("  SoftEdge: ").Append(this.SoftEdge).Append("\n");
          sb.Append("  Reflection: ").Append(this.Reflection).Append("\n");
          sb.Append("  FillOverlay: ").Append(this.FillOverlay).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
