// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeBevel.cs">
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
    /// ShapeBevel
    /// </summary>  
    public class ShapeBevel 
    {                       
        /// <summary>
        /// Bevel type
        /// </summary>
        /// <value>Bevel type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BevelTypeEnum
        {
            
            /// <summary>
            /// Enum Angle for "Angle"
            /// </summary>
            Angle,
            
            /// <summary>
            /// Enum ArtDeco for "ArtDeco"
            /// </summary>
            ArtDeco,
            
            /// <summary>
            /// Enum Circle for "Circle"
            /// </summary>
            Circle,
            
            /// <summary>
            /// Enum Convex for "Convex"
            /// </summary>
            Convex,
            
            /// <summary>
            /// Enum CoolSlant for "CoolSlant"
            /// </summary>
            CoolSlant,
            
            /// <summary>
            /// Enum Cross for "Cross"
            /// </summary>
            Cross,
            
            /// <summary>
            /// Enum Divot for "Divot"
            /// </summary>
            Divot,
            
            /// <summary>
            /// Enum HardEdge for "HardEdge"
            /// </summary>
            HardEdge,
            
            /// <summary>
            /// Enum RelaxedInset for "RelaxedInset"
            /// </summary>
            RelaxedInset,
            
            /// <summary>
            /// Enum Riblet for "Riblet"
            /// </summary>
            Riblet,
            
            /// <summary>
            /// Enum Slope for "Slope"
            /// </summary>
            Slope,
            
            /// <summary>
            /// Enum SoftRound for "SoftRound"
            /// </summary>
            SoftRound,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Bevel type
        /// </summary>
        public BevelTypeEnum? BevelType { get; set; }

        /// <summary>
        /// Bevel width
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// Bevel height
        /// </summary>
        public double? Height { get; set; }


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
        public ShapeBevel() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ShapeBevel {\n");
            sb.Append("  BevelType: ").Append(this.BevelType).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
