// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExportOptions.cs">
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
    /// Represents export options for whole presentation.
    /// </summary>  
    public class ExportOptions 
    {                       
        /// <summary>
        /// Default regular font for rendering the presentation. 
        /// </summary>
        /// <value>Default regular font for rendering the presentation. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GradientStyleEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            Default,
            
            /// <summary>
            /// Enum PowerPointUI for "PowerPointUI"
            /// </summary>
            PowerPointUI
        }

        /// <summary>
        /// Default regular font for rendering the presentation. 
        /// </summary>
        public GradientStyleEnum? GradientStyle { get; set; }

        /// <summary>
        /// Default regular font for rendering the presentation. 
        /// </summary>
        public string DefaultRegularFont { get; set; }

        /// <summary>
        /// Gets of sets list of font fallback rules.
        /// </summary>
        public List<FontFallbackRule> FontFallbackRules { get; set; }

        /// <summary>
        /// Gets of sets list of font substitution rules.
        /// </summary>
        public List<FontSubstRule> FontSubstRules { get; set; }

        /// <summary>
        /// Gets or sets Format
        /// </summary>
        public string Format { get; protected set; }


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
        public ExportOptions() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ExportOptions {\n");
            sb.Append("  DefaultRegularFont: ").Append(this.DefaultRegularFont).Append("\n");
            sb.Append("  GradientStyle: ").Append(this.GradientStyle).Append("\n");
            sb.Append("  FontFallbackRules: ").Append(this.FontFallbackRules).Append("\n");
            sb.Append("  FontSubstRules: ").Append(this.FontSubstRules).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
