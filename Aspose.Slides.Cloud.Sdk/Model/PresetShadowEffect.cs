// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PresetShadowEffect.cs">
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
    /// Represents preset shadow effect 
    /// </summary>  
    public class PresetShadowEffect 
    {                       
        /// <summary>
        /// preset
        /// </summary>
        /// <value>preset</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PresetEnum
        {
            
            /// <summary>
            /// Enum TopLeftDropShadow for "TopLeftDropShadow"
            /// </summary>
            TopLeftDropShadow,
            
            /// <summary>
            /// Enum TopLeftLargeDropShadow for "TopLeftLargeDropShadow"
            /// </summary>
            TopLeftLargeDropShadow,
            
            /// <summary>
            /// Enum BackLeftLongPerspectiveShadow for "BackLeftLongPerspectiveShadow"
            /// </summary>
            BackLeftLongPerspectiveShadow,
            
            /// <summary>
            /// Enum BackRightLongPerspectiveShadow for "BackRightLongPerspectiveShadow"
            /// </summary>
            BackRightLongPerspectiveShadow,
            
            /// <summary>
            /// Enum TopLeftDoubleDropShadow for "TopLeftDoubleDropShadow"
            /// </summary>
            TopLeftDoubleDropShadow,
            
            /// <summary>
            /// Enum BottomRightSmallDropShadow for "BottomRightSmallDropShadow"
            /// </summary>
            BottomRightSmallDropShadow,
            
            /// <summary>
            /// Enum FrontLeftLongPerspectiveShadow for "FrontLeftLongPerspectiveShadow"
            /// </summary>
            FrontLeftLongPerspectiveShadow,
            
            /// <summary>
            /// Enum FrontRightLongPerspectiveShadow for "FrontRightLongPerspectiveShadow"
            /// </summary>
            FrontRightLongPerspectiveShadow,
            
            /// <summary>
            /// Enum OuterBoxShadow3D for "OuterBoxShadow3D"
            /// </summary>
            OuterBoxShadow3D,
            
            /// <summary>
            /// Enum InnerBoxShadow3D for "InnerBoxShadow3D"
            /// </summary>
            InnerBoxShadow3D,
            
            /// <summary>
            /// Enum BackCenterPerspectiveShadow for "BackCenterPerspectiveShadow"
            /// </summary>
            BackCenterPerspectiveShadow,
            
            /// <summary>
            /// Enum TopRightDropShadow for "TopRightDropShadow"
            /// </summary>
            TopRightDropShadow,
            
            /// <summary>
            /// Enum FrontBottomShadow for "FrontBottomShadow"
            /// </summary>
            FrontBottomShadow,
            
            /// <summary>
            /// Enum BackLeftPerspectiveShadow for "BackLeftPerspectiveShadow"
            /// </summary>
            BackLeftPerspectiveShadow,
            
            /// <summary>
            /// Enum BackRightPerspectiveShadow for "BackRightPerspectiveShadow"
            /// </summary>
            BackRightPerspectiveShadow,
            
            /// <summary>
            /// Enum BottomLeftDropShadow for "BottomLeftDropShadow"
            /// </summary>
            BottomLeftDropShadow,
            
            /// <summary>
            /// Enum BottomRightDropShadow for "BottomRightDropShadow"
            /// </summary>
            BottomRightDropShadow,
            
            /// <summary>
            /// Enum FrontLeftPerspectiveShadow for "FrontLeftPerspectiveShadow"
            /// </summary>
            FrontLeftPerspectiveShadow,
            
            /// <summary>
            /// Enum FrontRightPerspectiveShadow for "FrontRightPerspectiveShadow"
            /// </summary>
            FrontRightPerspectiveShadow,
            
            /// <summary>
            /// Enum TopLeftSmallDropShadow for "TopLeftSmallDropShadow"
            /// </summary>
            TopLeftSmallDropShadow
        }

        /// <summary>
        /// preset
        /// </summary>
        public PresetEnum? Preset { get; set; }

        /// <summary>
        /// direction
        /// </summary>
        public double? Direction { get; set; }

        /// <summary>
        /// distance
        /// </summary>
        public double? Distance { get; set; }

        /// <summary>
        /// shadow color
        /// </summary>
        public string ShadowColor { get; set; }


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
        public PresetShadowEffect() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class PresetShadowEffect {\n");
            sb.Append("  Direction: ").Append(this.Direction).Append("\n");
            sb.Append("  Distance: ").Append(this.Distance).Append("\n");
            sb.Append("  Preset: ").Append(this.Preset).Append("\n");
            sb.Append("  ShadowColor: ").Append(this.ShadowColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
