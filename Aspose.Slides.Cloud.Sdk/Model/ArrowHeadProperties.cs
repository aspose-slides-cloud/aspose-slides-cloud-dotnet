// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ArrowHeadProperties.cs">
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
    /// Arrow head properties.
    /// </summary>  
    public class ArrowHeadProperties 
    {                       
        /// <summary>
        /// Length.
        /// </summary>
        /// <value>Length.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LengthEnum
        {
            
            /// <summary>
            /// Enum Short for "Short"
            /// </summary>
            Short,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>
            Medium,
            
            /// <summary>
            /// Enum Long for "Long"
            /// </summary>
            Long,
            
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
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Triangle for "Triangle"
            /// </summary>
            Triangle,
            
            /// <summary>
            /// Enum Stealth for "Stealth"
            /// </summary>
            Stealth,
            
            /// <summary>
            /// Enum Diamond for "Diamond"
            /// </summary>
            Diamond,
            
            /// <summary>
            /// Enum Oval for "Oval"
            /// </summary>
            Oval,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            Open,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Width.
        /// </summary>
        /// <value>Width.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WidthEnum
        {
            
            /// <summary>
            /// Enum Narrow for "Narrow"
            /// </summary>
            Narrow,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>
            Medium,
            
            /// <summary>
            /// Enum Wide for "Wide"
            /// </summary>
            Wide,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Length.
        /// </summary>
        public LengthEnum? Length { get; set; }

        /// <summary>
        /// Style.
        /// </summary>
        public StyleEnum? Style { get; set; }

        /// <summary>
        /// Width.
        /// </summary>
        public WidthEnum? Width { get; set; }


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
        public ArrowHeadProperties() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ArrowHeadProperties {\n");
            sb.Append("  Length: ").Append(this.Length).Append("\n");
            sb.Append("  Style: ").Append(this.Style).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
