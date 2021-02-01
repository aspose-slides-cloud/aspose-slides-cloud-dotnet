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
        /// Gradient style.
        /// </summary>
        /// <value>Gradient style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum FromCorner1 for "FromCorner1"
            /// </summary>
            FromCorner1,
            
            /// <summary>
            /// Enum FromCorner2 for "FromCorner2"
            /// </summary>
            FromCorner2,
            
            /// <summary>
            /// Enum FromCorner3 for "FromCorner3"
            /// </summary>
            FromCorner3,
            
            /// <summary>
            /// Enum FromCorner4 for "FromCorner4"
            /// </summary>
            FromCorner4,
            
            /// <summary>
            /// Enum FromCenter for "FromCenter"
            /// </summary>
            FromCenter,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gradient shape.
        /// </summary>
        /// <value>Gradient shape.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShapeEnum
        {
            
            /// <summary>
            /// Enum Linear for "Linear"
            /// </summary>
            Linear,
            
            /// <summary>
            /// Enum Rectangle for "Rectangle"
            /// </summary>
            Rectangle,
            
            /// <summary>
            /// Enum Radial for "Radial"
            /// </summary>
            Radial,
            
            /// <summary>
            /// Enum Path for "Path"
            /// </summary>
            Path,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gradient flipping mode.
        /// </summary>
        /// <value>Gradient flipping mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TileFlipEnum
        {
            
            /// <summary>
            /// Enum NoFlip for "NoFlip"
            /// </summary>
            NoFlip,
            
            /// <summary>
            /// Enum FlipX for "FlipX"
            /// </summary>
            FlipX,
            
            /// <summary>
            /// Enum FlipY for "FlipY"
            /// </summary>
            FlipY,
            
            /// <summary>
            /// Enum FlipBoth for "FlipBoth"
            /// </summary>
            FlipBoth,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gradient style.
        /// </summary>
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        /// Gradient shape.
        /// </summary>
        public ShapeEnum? Shape { get; set; }

        /// <summary>
        /// Gradient flipping mode.
        /// </summary>
        public TileFlipEnum? TileFlip { get; set; }

        /// <summary>
        /// Gradient stops.
        /// </summary>
        public List<GradientFillStop> Stops { get; set; }

        /// <summary>
        /// Gradient angle.
        /// </summary>
        public double? LinearAngle { get; set; }

        /// <summary>
        /// True if the gradient is scaled.
        /// </summary>
        public bool? IsScaled { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.Gradient);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public GradientFill() : base()
        {
            Type = TypeEnum.Gradient;
        }

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
