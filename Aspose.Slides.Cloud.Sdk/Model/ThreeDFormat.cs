// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ThreeDFormat.cs">
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
    /// ThreeDFormat
    /// </summary>  
    public class ThreeDFormat 
    {                       
        /// <summary>
        /// Material
        /// </summary>
        /// <value>Material</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MaterialEnum
        {
            
            /// <summary>
            /// Enum Clear for "Clear"
            /// </summary>
            Clear,
            
            /// <summary>
            /// Enum DkEdge for "DkEdge"
            /// </summary>
            DkEdge,
            
            /// <summary>
            /// Enum Flat for "Flat"
            /// </summary>
            Flat,
            
            /// <summary>
            /// Enum LegacyMatte for "LegacyMatte"
            /// </summary>
            LegacyMatte,
            
            /// <summary>
            /// Enum LegacyMetal for "LegacyMetal"
            /// </summary>
            LegacyMetal,
            
            /// <summary>
            /// Enum LegacyPlastic for "LegacyPlastic"
            /// </summary>
            LegacyPlastic,
            
            /// <summary>
            /// Enum LegacyWireframe for "LegacyWireframe"
            /// </summary>
            LegacyWireframe,
            
            /// <summary>
            /// Enum Matte for "Matte"
            /// </summary>
            Matte,
            
            /// <summary>
            /// Enum Metal for "Metal"
            /// </summary>
            Metal,
            
            /// <summary>
            /// Enum Plastic for "Plastic"
            /// </summary>
            Plastic,
            
            /// <summary>
            /// Enum Powder for "Powder"
            /// </summary>
            Powder,
            
            /// <summary>
            /// Enum SoftEdge for "SoftEdge"
            /// </summary>
            SoftEdge,
            
            /// <summary>
            /// Enum Softmetal for "Softmetal"
            /// </summary>
            Softmetal,
            
            /// <summary>
            /// Enum TranslucentPowder for "TranslucentPowder"
            /// </summary>
            TranslucentPowder,
            
            /// <summary>
            /// Enum WarmMatte for "WarmMatte"
            /// </summary>
            WarmMatte,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Material
        /// </summary>
        public MaterialEnum? Material { get; set; }

        /// <summary>
        /// Type of a bottom 3D bevel.             
        /// </summary>
        public ShapeBevel BevelBottom { get; set; }

        /// <summary>
        /// Type of a top 3D bevel.             
        /// </summary>
        public ShapeBevel BevelTop { get; set; }

        /// <summary>
        /// Camera
        /// </summary>
        public Camera Camera { get; set; }

        /// <summary>
        /// Contour color
        /// </summary>
        public string ContourColor { get; set; }

        /// <summary>
        /// Contour width
        /// </summary>
        public double? ContourWidth { get; set; }

        /// <summary>
        /// Depth
        /// </summary>
        public double? Depth { get; set; }

        /// <summary>
        /// Extrusion color
        /// </summary>
        public string ExtrusionColor { get; set; }

        /// <summary>
        /// Extrusion height
        /// </summary>
        public double? ExtrusionHeight { get; set; }

        /// <summary>
        /// Light rig
        /// </summary>
        public LightRig LightRig { get; set; }


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
        public ThreeDFormat() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ThreeDFormat {\n");
            sb.Append("  BevelBottom: ").Append(this.BevelBottom).Append("\n");
            sb.Append("  BevelTop: ").Append(this.BevelTop).Append("\n");
            sb.Append("  Camera: ").Append(this.Camera).Append("\n");
            sb.Append("  ContourColor: ").Append(this.ContourColor).Append("\n");
            sb.Append("  ContourWidth: ").Append(this.ContourWidth).Append("\n");
            sb.Append("  Depth: ").Append(this.Depth).Append("\n");
            sb.Append("  ExtrusionColor: ").Append(this.ExtrusionColor).Append("\n");
            sb.Append("  ExtrusionHeight: ").Append(this.ExtrusionHeight).Append("\n");
            sb.Append("  LightRig: ").Append(this.LightRig).Append("\n");
            sb.Append("  Material: ").Append(this.Material).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
