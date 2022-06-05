// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageTransformEffect.cs">
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
    /// Image transform effect
    /// </summary>  
    public class ImageTransformEffect 
    {                       
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum AlphaBiLevel for "AlphaBiLevel"
            /// </summary>
            AlphaBiLevel,
            
            /// <summary>
            /// Enum AlphaCeiling for "AlphaCeiling"
            /// </summary>
            AlphaCeiling,
            
            /// <summary>
            /// Enum AlphaFloor for "AlphaFloor"
            /// </summary>
            AlphaFloor,
            
            /// <summary>
            /// Enum AlphaInverse for "AlphaInverse"
            /// </summary>
            AlphaInverse,
            
            /// <summary>
            /// Enum AlphaModulate for "AlphaModulate"
            /// </summary>
            AlphaModulate,
            
            /// <summary>
            /// Enum AlphaModulateFixed for "AlphaModulateFixed"
            /// </summary>
            AlphaModulateFixed,
            
            /// <summary>
            /// Enum AlphaReplace for "AlphaReplace"
            /// </summary>
            AlphaReplace,
            
            /// <summary>
            /// Enum BiLevel for "BiLevel"
            /// </summary>
            BiLevel,
            
            /// <summary>
            /// Enum Blur for "Blur"
            /// </summary>
            Blur,
            
            /// <summary>
            /// Enum ColorChange for "ColorChange"
            /// </summary>
            ColorChange,
            
            /// <summary>
            /// Enum ColorReplace for "ColorReplace"
            /// </summary>
            ColorReplace,
            
            /// <summary>
            /// Enum Duotone for "Duotone"
            /// </summary>
            Duotone,
            
            /// <summary>
            /// Enum FillOverlay for "FillOverlay"
            /// </summary>
            FillOverlay,
            
            /// <summary>
            /// Enum GrayScale for "GrayScale"
            /// </summary>
            GrayScale,
            
            /// <summary>
            /// Enum Hsl for "Hsl"
            /// </summary>
            Hsl,
            
            /// <summary>
            /// Enum Luminance for "Luminance"
            /// </summary>
            Luminance,
            
            /// <summary>
            /// Enum Tint for "Tint"
            /// </summary>
            Tint
        }

        /// <summary>
        /// Gets or sets Type
        /// </summary>
        public TypeEnum? Type { get; protected set; }


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
        public ImageTransformEffect() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ImageTransformEffect {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
