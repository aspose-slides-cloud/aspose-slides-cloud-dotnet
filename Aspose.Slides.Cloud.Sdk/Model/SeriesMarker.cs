// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SeriesMarker.cs">
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
  /// Represents a series marker
  /// </summary>  
  public class SeriesMarker 
  {                       
        /// <summary>
        /// symbol
        /// </summary>
        /// <value>symbol</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SymbolEnum
        {
            
            /// <summary>
            /// Enum Circle for "Circle"
            /// </summary>
            Circle,
            
            /// <summary>
            /// Enum Dash for "Dash"
            /// </summary>
            Dash,
            
            /// <summary>
            /// Enum Diamond for "Diamond"
            /// </summary>
            Diamond,
            
            /// <summary>
            /// Enum Dot for "Dot"
            /// </summary>
            Dot,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Picture for "Picture"
            /// </summary>
            Picture,
            
            /// <summary>
            /// Enum Plus for "Plus"
            /// </summary>
            Plus,
            
            /// <summary>
            /// Enum Square for "Square"
            /// </summary>
            Square,
            
            /// <summary>
            /// Enum Star for "Star"
            /// </summary>
            Star,
            
            /// <summary>
            /// Enum Triangle for "Triangle"
            /// </summary>
            Triangle,
            
            /// <summary>
            /// Enum X for "X"
            /// </summary>
            X,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// symbol
        /// </summary>
        public SymbolEnum? Symbol { get; set; }

        /// <summary>
        /// size
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Get or sets the fill format.
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Get or sets the effect format.
        /// </summary>
        public EffectFormat EffectFormat { get; set; }

        /// <summary>
        /// Get or sets the line format.
        /// </summary>
        public LineFormat LineFormat { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SeriesMarker() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SeriesMarker {\n");
          sb.Append("  Size: ").Append(this.Size).Append("\n");
          sb.Append("  Symbol: ").Append(this.Symbol).Append("\n");
          sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
          sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
          sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
