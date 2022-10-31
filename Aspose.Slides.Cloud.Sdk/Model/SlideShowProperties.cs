// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SlideShowProperties.cs">
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
    /// Slide show properties.
    /// </summary>  
    public class SlideShowProperties : ResourceBase 
    {                       
        /// <summary>
        /// Slide show type.
        /// </summary>
        /// <value>Slide show type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SlideShowTypeEnum
        {
            
            /// <summary>
            /// Enum BrowsedAtKiosk for "BrowsedAtKiosk"
            /// </summary>
            BrowsedAtKiosk,
            
            /// <summary>
            /// Enum BrowsedByIndividual for "BrowsedByIndividual"
            /// </summary>
            BrowsedByIndividual,
            
            /// <summary>
            /// Enum PresentedBySpeaker for "PresentedBySpeaker"
            /// </summary>
            PresentedBySpeaker
        }

        /// <summary>
        /// Slide show type.
        /// </summary>
        public SlideShowTypeEnum? SlideShowType { get; set; }

        /// <summary>
        /// Loop slide show.
        /// </summary>
        public bool? Loop { get; set; }

        /// <summary>
        /// Start slide in the slide show.
        /// </summary>
        public int? StartSlide { get; set; }

        /// <summary>
        /// End slides in the slide show.
        /// </summary>
        public int? EndSlide { get; set; }

        /// <summary>
        /// Pen color.
        /// </summary>
        public string PenColor { get; set; }

        /// <summary>
        /// Show animation.
        /// </summary>
        public bool? ShowAnimation { get; set; }

        /// <summary>
        /// Show narrration.
        /// </summary>
        public bool? ShowNarration { get; set; }

        /// <summary>
        /// Use timings.
        /// </summary>
        public bool? UseTimings { get; set; }

        /// <summary>
        /// Show scroll bar. Applied with BrowsedByIndividual slide show type.
        /// </summary>
        public bool? ShowScrollbar { get; set; }


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
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SlideShowProperties() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class SlideShowProperties {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  Loop: ").Append(this.Loop).Append("\n");
            sb.Append("  StartSlide: ").Append(this.StartSlide).Append("\n");
            sb.Append("  EndSlide: ").Append(this.EndSlide).Append("\n");
            sb.Append("  PenColor: ").Append(this.PenColor).Append("\n");
            sb.Append("  ShowAnimation: ").Append(this.ShowAnimation).Append("\n");
            sb.Append("  ShowNarration: ").Append(this.ShowNarration).Append("\n");
            sb.Append("  UseTimings: ").Append(this.UseTimings).Append("\n");
            sb.Append("  SlideShowType: ").Append(this.SlideShowType).Append("\n");
            sb.Append("  ShowScrollbar: ").Append(this.ShowScrollbar).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
