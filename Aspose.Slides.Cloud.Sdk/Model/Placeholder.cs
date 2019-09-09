// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Placeholder.cs">
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
    /// Represents placeholder
    /// </summary>  
    public class Placeholder : ResourceBase 
    {                       
        /// <summary>
        /// Orientation.
        /// </summary>
        /// <value>Orientation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>
            Horizontal,
            
            /// <summary>
            /// Enum Vertical for "Vertical"
            /// </summary>
            Vertical
        }

        /// <summary>
        /// Size.
        /// </summary>
        /// <value>Size.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SizeEnum
        {
            
            /// <summary>
            /// Enum Full for "Full"
            /// </summary>
            Full,
            
            /// <summary>
            /// Enum Half for "Half"
            /// </summary>
            Half,
            
            /// <summary>
            /// Enum Quarter for "Quarter"
            /// </summary>
            Quarter
        }

        /// <summary>
        /// Placeholder type.
        /// </summary>
        /// <value>Placeholder type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Title for "Title"
            /// </summary>
            Title,
            
            /// <summary>
            /// Enum Body for "Body"
            /// </summary>
            Body,
            
            /// <summary>
            /// Enum CenteredTitle for "CenteredTitle"
            /// </summary>
            CenteredTitle,
            
            /// <summary>
            /// Enum Subtitle for "Subtitle"
            /// </summary>
            Subtitle,
            
            /// <summary>
            /// Enum DateAndTime for "DateAndTime"
            /// </summary>
            DateAndTime,
            
            /// <summary>
            /// Enum SlideNumber for "SlideNumber"
            /// </summary>
            SlideNumber,
            
            /// <summary>
            /// Enum Footer for "Footer"
            /// </summary>
            Footer,
            
            /// <summary>
            /// Enum Header for "Header"
            /// </summary>
            Header,
            
            /// <summary>
            /// Enum Object for "Object"
            /// </summary>
            Object,
            
            /// <summary>
            /// Enum Chart for "Chart"
            /// </summary>
            Chart,
            
            /// <summary>
            /// Enum Table for "Table"
            /// </summary>
            Table,
            
            /// <summary>
            /// Enum ClipArt for "ClipArt"
            /// </summary>
            ClipArt,
            
            /// <summary>
            /// Enum Diagram for "Diagram"
            /// </summary>
            Diagram,
            
            /// <summary>
            /// Enum Media for "Media"
            /// </summary>
            Media,
            
            /// <summary>
            /// Enum SlideImage for "SlideImage"
            /// </summary>
            SlideImage,
            
            /// <summary>
            /// Enum Picture for "Picture"
            /// </summary>
            Picture
        }

        /// <summary>
        /// Orientation.
        /// </summary>
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Size.
        /// </summary>
        public SizeEnum? Size { get; set; }

        /// <summary>
        /// Placeholder type.
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Index.
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// Shape link.
        /// </summary>
        public ResourceUriElement Shape { get; set; }


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
        public Placeholder() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Placeholder {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            sb.Append("  Orientation: ").Append(this.Orientation).Append("\n");
            sb.Append("  Size: ").Append(this.Size).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Shape: ").Append(this.Shape).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
