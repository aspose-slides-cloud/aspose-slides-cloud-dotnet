// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PatternFill.cs">
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
    /// Represents Pattern Fill
    /// </summary>  
    public class PatternFill : FillFormat 
    {                       
        /// <summary>
        /// Gets or sets the style of pattern fill.
        /// </summary>
        /// <value>Gets or sets the style of pattern fill.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StyleEnum
        {
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            Unknown,
            
            /// <summary>
            /// Enum Percent05 for "Percent05"
            /// </summary>
            Percent05,
            
            /// <summary>
            /// Enum Percent10 for "Percent10"
            /// </summary>
            Percent10,
            
            /// <summary>
            /// Enum Percent20 for "Percent20"
            /// </summary>
            Percent20,
            
            /// <summary>
            /// Enum Percent25 for "Percent25"
            /// </summary>
            Percent25,
            
            /// <summary>
            /// Enum Percent30 for "Percent30"
            /// </summary>
            Percent30,
            
            /// <summary>
            /// Enum Percent40 for "Percent40"
            /// </summary>
            Percent40,
            
            /// <summary>
            /// Enum Percent50 for "Percent50"
            /// </summary>
            Percent50,
            
            /// <summary>
            /// Enum Percent60 for "Percent60"
            /// </summary>
            Percent60,
            
            /// <summary>
            /// Enum Percent70 for "Percent70"
            /// </summary>
            Percent70,
            
            /// <summary>
            /// Enum Percent75 for "Percent75"
            /// </summary>
            Percent75,
            
            /// <summary>
            /// Enum Percent80 for "Percent80"
            /// </summary>
            Percent80,
            
            /// <summary>
            /// Enum Percent90 for "Percent90"
            /// </summary>
            Percent90,
            
            /// <summary>
            /// Enum DarkHorizontal for "DarkHorizontal"
            /// </summary>
            DarkHorizontal,
            
            /// <summary>
            /// Enum DarkVertical for "DarkVertical"
            /// </summary>
            DarkVertical,
            
            /// <summary>
            /// Enum DarkDownwardDiagonal for "DarkDownwardDiagonal"
            /// </summary>
            DarkDownwardDiagonal,
            
            /// <summary>
            /// Enum DarkUpwardDiagonal for "DarkUpwardDiagonal"
            /// </summary>
            DarkUpwardDiagonal,
            
            /// <summary>
            /// Enum SmallCheckerBoard for "SmallCheckerBoard"
            /// </summary>
            SmallCheckerBoard,
            
            /// <summary>
            /// Enum Trellis for "Trellis"
            /// </summary>
            Trellis,
            
            /// <summary>
            /// Enum LightHorizontal for "LightHorizontal"
            /// </summary>
            LightHorizontal,
            
            /// <summary>
            /// Enum LightVertical for "LightVertical"
            /// </summary>
            LightVertical,
            
            /// <summary>
            /// Enum LightDownwardDiagonal for "LightDownwardDiagonal"
            /// </summary>
            LightDownwardDiagonal,
            
            /// <summary>
            /// Enum LightUpwardDiagonal for "LightUpwardDiagonal"
            /// </summary>
            LightUpwardDiagonal,
            
            /// <summary>
            /// Enum SmallGrid for "SmallGrid"
            /// </summary>
            SmallGrid,
            
            /// <summary>
            /// Enum DottedDiamond for "DottedDiamond"
            /// </summary>
            DottedDiamond,
            
            /// <summary>
            /// Enum WideDownwardDiagonal for "WideDownwardDiagonal"
            /// </summary>
            WideDownwardDiagonal,
            
            /// <summary>
            /// Enum WideUpwardDiagonal for "WideUpwardDiagonal"
            /// </summary>
            WideUpwardDiagonal,
            
            /// <summary>
            /// Enum DashedUpwardDiagonal for "DashedUpwardDiagonal"
            /// </summary>
            DashedUpwardDiagonal,
            
            /// <summary>
            /// Enum DashedDownwardDiagonal for "DashedDownwardDiagonal"
            /// </summary>
            DashedDownwardDiagonal,
            
            /// <summary>
            /// Enum NarrowVertical for "NarrowVertical"
            /// </summary>
            NarrowVertical,
            
            /// <summary>
            /// Enum NarrowHorizontal for "NarrowHorizontal"
            /// </summary>
            NarrowHorizontal,
            
            /// <summary>
            /// Enum DashedVertical for "DashedVertical"
            /// </summary>
            DashedVertical,
            
            /// <summary>
            /// Enum DashedHorizontal for "DashedHorizontal"
            /// </summary>
            DashedHorizontal,
            
            /// <summary>
            /// Enum LargeConfetti for "LargeConfetti"
            /// </summary>
            LargeConfetti,
            
            /// <summary>
            /// Enum LargeGrid for "LargeGrid"
            /// </summary>
            LargeGrid,
            
            /// <summary>
            /// Enum HorizontalBrick for "HorizontalBrick"
            /// </summary>
            HorizontalBrick,
            
            /// <summary>
            /// Enum LargeCheckerBoard for "LargeCheckerBoard"
            /// </summary>
            LargeCheckerBoard,
            
            /// <summary>
            /// Enum SmallConfetti for "SmallConfetti"
            /// </summary>
            SmallConfetti,
            
            /// <summary>
            /// Enum Zigzag for "Zigzag"
            /// </summary>
            Zigzag,
            
            /// <summary>
            /// Enum SolidDiamond for "SolidDiamond"
            /// </summary>
            SolidDiamond,
            
            /// <summary>
            /// Enum DiagonalBrick for "DiagonalBrick"
            /// </summary>
            DiagonalBrick,
            
            /// <summary>
            /// Enum OutlinedDiamond for "OutlinedDiamond"
            /// </summary>
            OutlinedDiamond,
            
            /// <summary>
            /// Enum Plaid for "Plaid"
            /// </summary>
            Plaid,
            
            /// <summary>
            /// Enum Sphere for "Sphere"
            /// </summary>
            Sphere,
            
            /// <summary>
            /// Enum Weave for "Weave"
            /// </summary>
            Weave,
            
            /// <summary>
            /// Enum DottedGrid for "DottedGrid"
            /// </summary>
            DottedGrid,
            
            /// <summary>
            /// Enum Divot for "Divot"
            /// </summary>
            Divot,
            
            /// <summary>
            /// Enum Shingle for "Shingle"
            /// </summary>
            Shingle,
            
            /// <summary>
            /// Enum Wave for "Wave"
            /// </summary>
            Wave,
            
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>
            Horizontal,
            
            /// <summary>
            /// Enum Vertical for "Vertical"
            /// </summary>
            Vertical,
            
            /// <summary>
            /// Enum Cross for "Cross"
            /// </summary>
            Cross,
            
            /// <summary>
            /// Enum DownwardDiagonal for "DownwardDiagonal"
            /// </summary>
            DownwardDiagonal,
            
            /// <summary>
            /// Enum UpwardDiagonal for "UpwardDiagonal"
            /// </summary>
            UpwardDiagonal,
            
            /// <summary>
            /// Enum DiagonalCross for "DiagonalCross"
            /// </summary>
            DiagonalCross,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or sets the style of pattern fill.
        /// </summary>
        public StyleEnum? Style { get; set; }

        /// <summary>
        /// Gets or sets the back color of the pattern fill.
        /// </summary>
        public string BackColor { get; set; }

        /// <summary>
        /// Gets or sets the fore color of the pattern fill.
        /// </summary>
        public string ForeColor { get; set; }


        /// <summary>
        /// Property values to determine the type when deserializing from Json
        /// </summary>
        public static new Dictionary<string, object> TypeDeterminers
        {
            get
            {
                if (s_typeDeterminers == null)
                {
                    s_typeDeterminers = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                    s_typeDeterminers.Add("Type", TypeEnum.Pattern);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public PatternFill() : base()
        {
            Type = TypeEnum.Pattern;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class PatternFill {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  BackColor: ").Append(this.BackColor).Append("\n");
            sb.Append("  ForeColor: ").Append(this.ForeColor).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
