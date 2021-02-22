// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LineFormat.cs">
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
    /// Line format.
    /// </summary>  
    public class LineFormat 
    {                       
        /// <summary>
        /// Alignment.
        /// </summary>
        /// <value>Alignment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlignmentEnum
        {
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            Center,
            
            /// <summary>
            /// Enum Inset for "Inset"
            /// </summary>
            Inset,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Cap style.
        /// </summary>
        /// <value>Cap style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CapStyleEnum
        {
            
            /// <summary>
            /// Enum Round for "Round"
            /// </summary>
            Round,
            
            /// <summary>
            /// Enum Square for "Square"
            /// </summary>
            Square,
            
            /// <summary>
            /// Enum Flat for "Flat"
            /// </summary>
            Flat,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Dash style.
        /// </summary>
        /// <value>Dash style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DashStyleEnum
        {
            
            /// <summary>
            /// Enum Solid for "Solid"
            /// </summary>
            Solid,
            
            /// <summary>
            /// Enum Dot for "Dot"
            /// </summary>
            Dot,
            
            /// <summary>
            /// Enum Dash for "Dash"
            /// </summary>
            Dash,
            
            /// <summary>
            /// Enum LargeDash for "LargeDash"
            /// </summary>
            LargeDash,
            
            /// <summary>
            /// Enum DashDot for "DashDot"
            /// </summary>
            DashDot,
            
            /// <summary>
            /// Enum LargeDashDot for "LargeDashDot"
            /// </summary>
            LargeDashDot,
            
            /// <summary>
            /// Enum LargeDashDotDot for "LargeDashDotDot"
            /// </summary>
            LargeDashDotDot,
            
            /// <summary>
            /// Enum SystemDash for "SystemDash"
            /// </summary>
            SystemDash,
            
            /// <summary>
            /// Enum SystemDot for "SystemDot"
            /// </summary>
            SystemDot,
            
            /// <summary>
            /// Enum SystemDashDot for "SystemDashDot"
            /// </summary>
            SystemDashDot,
            
            /// <summary>
            /// Enum SystemDashDotDot for "SystemDashDotDot"
            /// </summary>
            SystemDashDotDot,
            
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
        /// Join style.
        /// </summary>
        /// <value>Join style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JoinStyleEnum
        {
            
            /// <summary>
            /// Enum Round for "Round"
            /// </summary>
            Round,
            
            /// <summary>
            /// Enum Bevel for "Bevel"
            /// </summary>
            Bevel,
            
            /// <summary>
            /// Enum Miter for "Miter"
            /// </summary>
            Miter,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Style.
        /// </summary>
        /// <value>Style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StyleEnum
        {
            
            /// <summary>
            /// Enum Single for "Single"
            /// </summary>
            Single,
            
            /// <summary>
            /// Enum ThinThin for "ThinThin"
            /// </summary>
            ThinThin,
            
            /// <summary>
            /// Enum ThinThick for "ThinThick"
            /// </summary>
            ThinThick,
            
            /// <summary>
            /// Enum ThickThin for "ThickThin"
            /// </summary>
            ThickThin,
            
            /// <summary>
            /// Enum ThickBetweenThin for "ThickBetweenThin"
            /// </summary>
            ThickBetweenThin,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Sketch type.
        /// </summary>
        /// <value>Sketch type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SketchTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Curved for "Curved"
            /// </summary>
            Curved,
            
            /// <summary>
            /// Enum Freehand for "Freehand"
            /// </summary>
            Freehand,
            
            /// <summary>
            /// Enum Scribble for "Scribble"
            /// </summary>
            Scribble,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Alignment.
        /// </summary>
        public AlignmentEnum? Alignment { get; set; }

        /// <summary>
        /// Cap style.
        /// </summary>
        public CapStyleEnum? CapStyle { get; set; }

        /// <summary>
        /// Dash style.
        /// </summary>
        public DashStyleEnum? DashStyle { get; set; }

        /// <summary>
        /// Join style.
        /// </summary>
        public JoinStyleEnum? JoinStyle { get; set; }

        /// <summary>
        /// Style.
        /// </summary>
        public StyleEnum? Style { get; set; }

        /// <summary>
        /// Sketch type.
        /// </summary>
        public SketchTypeEnum? SketchType { get; set; }

        /// <summary>
        /// Begin arrowhead.
        /// </summary>
        public ArrowHeadProperties BeginArrowHead { get; set; }

        /// <summary>
        /// End arrowhead.
        /// </summary>
        public ArrowHeadProperties EndArrowHead { get; set; }

        /// <summary>
        /// Custom dash pattern.
        /// </summary>
        public CustomDashPattern CustomDashPattern { get; set; }

        /// <summary>
        /// Fill format.
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Miter limit.
        /// </summary>
        public double? MiterLimit { get; set; }

        /// <summary>
        /// Width.
        /// </summary>
        public double? Width { get; set; }


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
        public LineFormat() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class LineFormat {\n");
            sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
            sb.Append("  CapStyle: ").Append(this.CapStyle).Append("\n");
            sb.Append("  DashStyle: ").Append(this.DashStyle).Append("\n");
            sb.Append("  JoinStyle: ").Append(this.JoinStyle).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("  SketchType: ").Append(this.SketchType).Append("\n");
            sb.Append("  BeginArrowHead: ").Append(this.BeginArrowHead).Append("\n");
            sb.Append("  EndArrowHead: ").Append(this.EndArrowHead).Append("\n");
            sb.Append("  CustomDashPattern: ").Append(this.CustomDashPattern).Append("\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  MiterLimit: ").Append(this.MiterLimit).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
