// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LightRig.cs">
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
    /// Light rig
    /// </summary>  
    public class LightRig 
    {                       
        /// <summary>
        /// Light direction
        /// </summary>
        /// <value>Light direction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum TopLeft for "TopLeft"
            /// </summary>
            TopLeft,
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>
            Top,
            
            /// <summary>
            /// Enum TopRight for "TopRight"
            /// </summary>
            TopRight,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            Right,
            
            /// <summary>
            /// Enum BottomRight for "BottomRight"
            /// </summary>
            BottomRight,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>
            Bottom,
            
            /// <summary>
            /// Enum BottomLeft for "BottomLeft"
            /// </summary>
            BottomLeft,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            Left,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Light type
        /// </summary>
        /// <value>Light type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LightTypeEnum
        {
            
            /// <summary>
            /// Enum Balanced for "Balanced"
            /// </summary>
            Balanced,
            
            /// <summary>
            /// Enum BrightRoom for "BrightRoom"
            /// </summary>
            BrightRoom,
            
            /// <summary>
            /// Enum Chilly for "Chilly"
            /// </summary>
            Chilly,
            
            /// <summary>
            /// Enum Contrasting for "Contrasting"
            /// </summary>
            Contrasting,
            
            /// <summary>
            /// Enum Flat for "Flat"
            /// </summary>
            Flat,
            
            /// <summary>
            /// Enum Flood for "Flood"
            /// </summary>
            Flood,
            
            /// <summary>
            /// Enum Freezing for "Freezing"
            /// </summary>
            Freezing,
            
            /// <summary>
            /// Enum Glow for "Glow"
            /// </summary>
            Glow,
            
            /// <summary>
            /// Enum Harsh for "Harsh"
            /// </summary>
            Harsh,
            
            /// <summary>
            /// Enum LegacyFlat1 for "LegacyFlat1"
            /// </summary>
            LegacyFlat1,
            
            /// <summary>
            /// Enum LegacyFlat2 for "LegacyFlat2"
            /// </summary>
            LegacyFlat2,
            
            /// <summary>
            /// Enum LegacyFlat3 for "LegacyFlat3"
            /// </summary>
            LegacyFlat3,
            
            /// <summary>
            /// Enum LegacyFlat4 for "LegacyFlat4"
            /// </summary>
            LegacyFlat4,
            
            /// <summary>
            /// Enum LegacyHarsh1 for "LegacyHarsh1"
            /// </summary>
            LegacyHarsh1,
            
            /// <summary>
            /// Enum LegacyHarsh2 for "LegacyHarsh2"
            /// </summary>
            LegacyHarsh2,
            
            /// <summary>
            /// Enum LegacyHarsh3 for "LegacyHarsh3"
            /// </summary>
            LegacyHarsh3,
            
            /// <summary>
            /// Enum LegacyHarsh4 for "LegacyHarsh4"
            /// </summary>
            LegacyHarsh4,
            
            /// <summary>
            /// Enum LegacyNormal1 for "LegacyNormal1"
            /// </summary>
            LegacyNormal1,
            
            /// <summary>
            /// Enum LegacyNormal2 for "LegacyNormal2"
            /// </summary>
            LegacyNormal2,
            
            /// <summary>
            /// Enum LegacyNormal3 for "LegacyNormal3"
            /// </summary>
            LegacyNormal3,
            
            /// <summary>
            /// Enum LegacyNormal4 for "LegacyNormal4"
            /// </summary>
            LegacyNormal4,
            
            /// <summary>
            /// Enum Morning for "Morning"
            /// </summary>
            Morning,
            
            /// <summary>
            /// Enum Soft for "Soft"
            /// </summary>
            Soft,
            
            /// <summary>
            /// Enum Sunrise for "Sunrise"
            /// </summary>
            Sunrise,
            
            /// <summary>
            /// Enum Sunset for "Sunset"
            /// </summary>
            Sunset,
            
            /// <summary>
            /// Enum ThreePt for "ThreePt"
            /// </summary>
            ThreePt,
            
            /// <summary>
            /// Enum TwoPt for "TwoPt"
            /// </summary>
            TwoPt,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Light direction
        /// </summary>
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        /// Light type
        /// </summary>
        public LightTypeEnum? LightType { get; set; }

        /// <summary>
        /// XRotation
        /// </summary>
        public double? XRotation { get; set; }

        /// <summary>
        /// YRotation
        /// </summary>
        public double? YRotation { get; set; }

        /// <summary>
        /// ZRotation
        /// </summary>
        public double? ZRotation { get; set; }


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
        public LightRig() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class LightRig {\n");
            sb.Append("  Direction: ").Append(this.Direction).Append("\n");
            sb.Append("  LightType: ").Append(this.LightType).Append("\n");
            sb.Append("  XRotation: ").Append(this.XRotation).Append("\n");
            sb.Append("  YRotation: ").Append(this.YRotation).Append("\n");
            sb.Append("  ZRotation: ").Append(this.ZRotation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
