// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HandoutLayoutingOptions.cs">
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
    /// Handout layouting options
    /// </summary>  
    public class HandoutLayoutingOptions : SlidesLayoutOptions 
    {                       
        /// <summary>
        /// Specified how many pages and in what sequence will be placed on the page.
        /// </summary>
        /// <value>Specified how many pages and in what sequence will be placed on the page.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HandoutEnum
        {
            
            /// <summary>
            /// Enum Handouts1 for "Handouts1"
            /// </summary>
            Handouts1,
            
            /// <summary>
            /// Enum Handouts2 for "Handouts2"
            /// </summary>
            Handouts2,
            
            /// <summary>
            /// Enum Handouts3 for "Handouts3"
            /// </summary>
            Handouts3,
            
            /// <summary>
            /// Enum Handouts4Horizontal for "Handouts4Horizontal"
            /// </summary>
            Handouts4Horizontal,
            
            /// <summary>
            /// Enum Handouts4Vertical for "Handouts4Vertical"
            /// </summary>
            Handouts4Vertical,
            
            /// <summary>
            /// Enum Handouts6Horizontal for "Handouts6Horizontal"
            /// </summary>
            Handouts6Horizontal,
            
            /// <summary>
            /// Enum Handouts6Vertical for "Handouts6Vertical"
            /// </summary>
            Handouts6Vertical,
            
            /// <summary>
            /// Enum Handouts9Horizontal for "Handouts9Horizontal"
            /// </summary>
            Handouts9Horizontal,
            
            /// <summary>
            /// Enum Handouts9Vertical for "Handouts9Vertical"
            /// </summary>
            Handouts9Vertical
        }

        /// <summary>
        /// Specified how many pages and in what sequence will be placed on the page.
        /// </summary>
        public HandoutEnum? Handout { get; set; }

        /// <summary>
        /// True to print the displayed slide numbers.
        /// </summary>
        public bool? PrintSlideNumbers { get; set; }

        /// <summary>
        /// True to display comments on slide.
        /// </summary>
        public bool? PrintComments { get; set; }

        /// <summary>
        /// True to draw frames around the displayed slides.
        /// </summary>
        public bool? PrintFrameSlide { get; set; }


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
                    s_typeDeterminers.Add("LayoutType", LayoutTypeEnum.Handout);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public HandoutLayoutingOptions() : base()
        {
            LayoutType = LayoutTypeEnum.Handout;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class HandoutLayoutingOptions {\n");
            sb.Append("  LayoutType: ").Append(this.LayoutType).Append("\n");
            sb.Append("  Handout: ").Append(this.Handout).Append("\n");
            sb.Append("  PrintSlideNumbers: ").Append(this.PrintSlideNumbers).Append("\n");
            sb.Append("  PrintComments: ").Append(this.PrintComments).Append("\n");
            sb.Append("  PrintFrameSlide: ").Append(this.PrintFrameSlide).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
