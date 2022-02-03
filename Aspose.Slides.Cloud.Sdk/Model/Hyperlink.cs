// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Hyperlink.cs">
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
    /// Hyperlink
    /// </summary>  
    public class Hyperlink 
    {                       
        /// <summary>
        /// Type of HyperLink action             
        /// </summary>
        /// <value>Type of HyperLink action             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionTypeEnum
        {
            
            /// <summary>
            /// Enum NoAction for "NoAction"
            /// </summary>
            NoAction,
            
            /// <summary>
            /// Enum Hyperlink for "Hyperlink"
            /// </summary>
            Hyperlink,
            
            /// <summary>
            /// Enum JumpFirstSlide for "JumpFirstSlide"
            /// </summary>
            JumpFirstSlide,
            
            /// <summary>
            /// Enum JumpPreviousSlide for "JumpPreviousSlide"
            /// </summary>
            JumpPreviousSlide,
            
            /// <summary>
            /// Enum JumpNextSlide for "JumpNextSlide"
            /// </summary>
            JumpNextSlide,
            
            /// <summary>
            /// Enum JumpLastSlide for "JumpLastSlide"
            /// </summary>
            JumpLastSlide,
            
            /// <summary>
            /// Enum JumpEndShow for "JumpEndShow"
            /// </summary>
            JumpEndShow,
            
            /// <summary>
            /// Enum JumpLastViewedSlide for "JumpLastViewedSlide"
            /// </summary>
            JumpLastViewedSlide,
            
            /// <summary>
            /// Enum JumpSpecificSlide for "JumpSpecificSlide"
            /// </summary>
            JumpSpecificSlide,
            
            /// <summary>
            /// Enum StartCustomSlideShow for "StartCustomSlideShow"
            /// </summary>
            StartCustomSlideShow,
            
            /// <summary>
            /// Enum OpenFile for "OpenFile"
            /// </summary>
            OpenFile,
            
            /// <summary>
            /// Enum OpenPresentation for "OpenPresentation"
            /// </summary>
            OpenPresentation,
            
            /// <summary>
            /// Enum StartStopMedia for "StartStopMedia"
            /// </summary>
            StartStopMedia,
            
            /// <summary>
            /// Enum StartMacro for "StartMacro"
            /// </summary>
            StartMacro,
            
            /// <summary>
            /// Enum StartProgram for "StartProgram"
            /// </summary>
            StartProgram,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            Unknown
        }

        /// <summary>
        /// Represents the source of hyperlink color
        /// </summary>
        /// <value>Represents the source of hyperlink color</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorSourceEnum
        {
            
            /// <summary>
            /// Enum Styles for "Styles"
            /// </summary>
            Styles,
            
            /// <summary>
            /// Enum PortionFormat for "PortionFormat"
            /// </summary>
            PortionFormat
        }

        /// <summary>
        /// Type of HyperLink action             
        /// </summary>
        public ActionTypeEnum? ActionType { get; set; }

        /// <summary>
        /// Represents the source of hyperlink color
        /// </summary>
        public ColorSourceEnum? ColorSource { get; set; }

        /// <summary>
        /// If true Hypelink is not applied. 
        /// </summary>
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Specifies the external URL
        /// </summary>
        public string ExternalUrl { get; set; }

        /// <summary>
        /// Index of the target slide
        /// </summary>
        public int? TargetSlideIndex { get; set; }

        /// <summary>
        /// Target frame
        /// </summary>
        public string TargetFrame { get; set; }

        /// <summary>
        /// Hyperlink tooltip
        /// </summary>
        public string Tooltip { get; set; }

        /// <summary>
        /// Makes hyperlink viewed when it is invoked.             
        /// </summary>
        public bool? History { get; set; }

        /// <summary>
        /// Determines whether the hyperlink should be highlighted on click.
        /// </summary>
        public bool? HighlightClick { get; set; }

        /// <summary>
        /// Determines whether the sound should be stopped on hyperlink click
        /// </summary>
        public bool? StopSoundOnClick { get; set; }


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
        public Hyperlink() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Hyperlink {\n");
            sb.Append("  IsDisabled: ").Append(this.IsDisabled).Append("\n");
            sb.Append("  ActionType: ").Append(this.ActionType).Append("\n");
            sb.Append("  ExternalUrl: ").Append(this.ExternalUrl).Append("\n");
            sb.Append("  TargetSlideIndex: ").Append(this.TargetSlideIndex).Append("\n");
            sb.Append("  TargetFrame: ").Append(this.TargetFrame).Append("\n");
            sb.Append("  Tooltip: ").Append(this.Tooltip).Append("\n");
            sb.Append("  History: ").Append(this.History).Append("\n");
            sb.Append("  HighlightClick: ").Append(this.HighlightClick).Append("\n");
            sb.Append("  StopSoundOnClick: ").Append(this.StopSoundOnClick).Append("\n");
            sb.Append("  ColorSource: ").Append(this.ColorSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
