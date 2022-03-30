// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="VideoExportOptions.cs">
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
    /// Provides options that control how a presentation is saved in an video format.
    /// </summary>  
    public class VideoExportOptions : ExportOptions 
    {                       
        /// <summary>
        /// Video resolution type
        /// </summary>
        /// <value>Video resolution type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VideoResolutionTypeEnum
        {
            
            /// <summary>
            /// Enum FullHD for "FullHD"
            /// </summary>
            FullHD,
            
            /// <summary>
            /// Enum SD for "SD"
            /// </summary>
            SD,
            
            /// <summary>
            /// Enum HD for "HD"
            /// </summary>
            HD,
            
            /// <summary>
            /// Enum QHD for "QHD"
            /// </summary>
            QHD
        }

        /// <summary>
        /// Video resolution type
        /// </summary>
        public VideoResolutionTypeEnum? VideoResolutionType { get; set; }

        /// <summary>
        /// Transition duration.
        /// </summary>
        public int? TransitionDuration { get; set; }


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
                    s_typeDeterminers.Add("Format", "mpeg4");
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public VideoExportOptions() : base()
        {
            Format = "mpeg4";
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class VideoExportOptions {\n");
            sb.Append("  DefaultRegularFont: ").Append(this.DefaultRegularFont).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  FontFallbackRules: ").Append(this.FontFallbackRules).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  TransitionDuration: ").Append(this.TransitionDuration).Append("\n");
            sb.Append("  VideoResolutionType: ").Append(this.VideoResolutionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
