// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SummaryZoomFrame.cs">
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
    /// Summary zoom frame.
    /// </summary>  
    public class SummaryZoomFrame : ShapeBase 
    {                       
        /// <summary>
        /// Zoom layout type
        /// </summary>
        /// <value>Zoom layout type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ZoomLayoutEnum
        {
            
            /// <summary>
            /// Enum GridLayout for "GridLayout"
            /// </summary>
            GridLayout,
            
            /// <summary>
            /// Enum FixedLayout for "FixedLayout"
            /// </summary>
            FixedLayout
        }

        /// <summary>
        /// Zoom layout type
        /// </summary>
        public ZoomLayoutEnum? ZoomLayout { get; set; }

        /// <summary>
        /// Zoom frame sections
        /// </summary>
        public List<SummaryZoomSection> Sections { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.SummaryZoomFrame);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SummaryZoomFrame() : base()
        {
            Type = TypeEnum.SummaryZoomFrame;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryZoomFrame {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  AlternativeText: ").Append(this.AlternativeText).Append("\n");
            sb.Append("  AlternativeTextTitle: ").Append(this.AlternativeTextTitle).Append("\n");
            sb.Append("  Hidden: ").Append(this.Hidden).Append("\n");
            sb.Append("  IsDecorative: ").Append(this.IsDecorative).Append("\n");
            sb.Append("  X: ").Append(this.X).Append("\n");
            sb.Append("  Y: ").Append(this.Y).Append("\n");
            sb.Append("  ZOrderPosition: ").Append(this.ZOrderPosition).Append("\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
            sb.Append("  ThreeDFormat: ").Append(this.ThreeDFormat).Append("\n");
            sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
            sb.Append("  HyperlinkClick: ").Append(this.HyperlinkClick).Append("\n");
            sb.Append("  HyperlinkMouseOver: ").Append(this.HyperlinkMouseOver).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ZoomLayout: ").Append(this.ZoomLayout).Append("\n");
            sb.Append("  Sections: ").Append(this.Sections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
