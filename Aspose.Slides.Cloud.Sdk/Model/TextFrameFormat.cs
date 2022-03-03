// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextFrameFormat.cs">
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
    /// Contains the TextFrame&#39;s formatting properties.
    /// </summary>  
    public class TextFrameFormat 
    {                       
        /// <summary>
        /// Gets or sets text wrapping shape.
        /// </summary>
        /// <value>Gets or sets text wrapping shape.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransformEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Plain for "Plain"
            /// </summary>
            Plain,
            
            /// <summary>
            /// Enum Stop for "Stop"
            /// </summary>
            Stop,
            
            /// <summary>
            /// Enum Triangle for "Triangle"
            /// </summary>
            Triangle,
            
            /// <summary>
            /// Enum TriangleInverted for "TriangleInverted"
            /// </summary>
            TriangleInverted,
            
            /// <summary>
            /// Enum Chevron for "Chevron"
            /// </summary>
            Chevron,
            
            /// <summary>
            /// Enum ChevronInverted for "ChevronInverted"
            /// </summary>
            ChevronInverted,
            
            /// <summary>
            /// Enum RingInside for "RingInside"
            /// </summary>
            RingInside,
            
            /// <summary>
            /// Enum RingOutside for "RingOutside"
            /// </summary>
            RingOutside,
            
            /// <summary>
            /// Enum ArchUp for "ArchUp"
            /// </summary>
            ArchUp,
            
            /// <summary>
            /// Enum ArchDown for "ArchDown"
            /// </summary>
            ArchDown,
            
            /// <summary>
            /// Enum Circle for "Circle"
            /// </summary>
            Circle,
            
            /// <summary>
            /// Enum Button for "Button"
            /// </summary>
            Button,
            
            /// <summary>
            /// Enum ArchUpPour for "ArchUpPour"
            /// </summary>
            ArchUpPour,
            
            /// <summary>
            /// Enum ArchDownPour for "ArchDownPour"
            /// </summary>
            ArchDownPour,
            
            /// <summary>
            /// Enum CirclePour for "CirclePour"
            /// </summary>
            CirclePour,
            
            /// <summary>
            /// Enum ButtonPour for "ButtonPour"
            /// </summary>
            ButtonPour,
            
            /// <summary>
            /// Enum CurveUp for "CurveUp"
            /// </summary>
            CurveUp,
            
            /// <summary>
            /// Enum CurveDown for "CurveDown"
            /// </summary>
            CurveDown,
            
            /// <summary>
            /// Enum CanUp for "CanUp"
            /// </summary>
            CanUp,
            
            /// <summary>
            /// Enum CanDown for "CanDown"
            /// </summary>
            CanDown,
            
            /// <summary>
            /// Enum Wave1 for "Wave1"
            /// </summary>
            Wave1,
            
            /// <summary>
            /// Enum Wave2 for "Wave2"
            /// </summary>
            Wave2,
            
            /// <summary>
            /// Enum DoubleWave1 for "DoubleWave1"
            /// </summary>
            DoubleWave1,
            
            /// <summary>
            /// Enum Wave4 for "Wave4"
            /// </summary>
            Wave4,
            
            /// <summary>
            /// Enum Inflate for "Inflate"
            /// </summary>
            Inflate,
            
            /// <summary>
            /// Enum Deflate for "Deflate"
            /// </summary>
            Deflate,
            
            /// <summary>
            /// Enum InflateBottom for "InflateBottom"
            /// </summary>
            InflateBottom,
            
            /// <summary>
            /// Enum DeflateBottom for "DeflateBottom"
            /// </summary>
            DeflateBottom,
            
            /// <summary>
            /// Enum InflateTop for "InflateTop"
            /// </summary>
            InflateTop,
            
            /// <summary>
            /// Enum DeflateTop for "DeflateTop"
            /// </summary>
            DeflateTop,
            
            /// <summary>
            /// Enum DeflateInflate for "DeflateInflate"
            /// </summary>
            DeflateInflate,
            
            /// <summary>
            /// Enum DeflateInflateDeflate for "DeflateInflateDeflate"
            /// </summary>
            DeflateInflateDeflate,
            
            /// <summary>
            /// Enum FadeRight for "FadeRight"
            /// </summary>
            FadeRight,
            
            /// <summary>
            /// Enum FadeLeft for "FadeLeft"
            /// </summary>
            FadeLeft,
            
            /// <summary>
            /// Enum FadeUp for "FadeUp"
            /// </summary>
            FadeUp,
            
            /// <summary>
            /// Enum FadeDown for "FadeDown"
            /// </summary>
            FadeDown,
            
            /// <summary>
            /// Enum SlantUp for "SlantUp"
            /// </summary>
            SlantUp,
            
            /// <summary>
            /// Enum SlantDown for "SlantDown"
            /// </summary>
            SlantDown,
            
            /// <summary>
            /// Enum CascadeUp for "CascadeUp"
            /// </summary>
            CascadeUp,
            
            /// <summary>
            /// Enum CascadeDown for "CascadeDown"
            /// </summary>
            CascadeDown,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            Custom,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or sets text wrapping shape.
        /// </summary>
        public TransformEnum? Transform { get; set; }

        /// <summary>
        /// Represents 3d effect properties for a text.
        /// </summary>
        public ThreeDFormat ThreeDFormat { get; set; }


        /// <summary>
        /// Property values to determine the type when deserializing from Json
        /// </summary>
        public static Dictionary<string, object> TypeDeterminers
        {
            get
            {
                if (s_typeDeterminers == null)
                {
                    s_typeDeterminers = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public TextFrameFormat() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TextFrameFormat {\n");
            sb.Append("  ThreeDFormat: ").Append(this.ThreeDFormat).Append("\n");
            sb.Append("  Transform: ").Append(this.Transform).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
