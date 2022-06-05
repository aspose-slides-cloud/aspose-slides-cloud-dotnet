// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeBase.cs">
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
    /// Slide shape.
    /// </summary>  
    public class ShapeBase : ResourceBase 
    {                       
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Shape for "Shape"
            /// </summary>
            Shape,
            
            /// <summary>
            /// Enum Chart for "Chart"
            /// </summary>
            Chart,
            
            /// <summary>
            /// Enum Table for "Table"
            /// </summary>
            Table,
            
            /// <summary>
            /// Enum PictureFrame for "PictureFrame"
            /// </summary>
            PictureFrame,
            
            /// <summary>
            /// Enum VideoFrame for "VideoFrame"
            /// </summary>
            VideoFrame,
            
            /// <summary>
            /// Enum AudioFrame for "AudioFrame"
            /// </summary>
            AudioFrame,
            
            /// <summary>
            /// Enum SmartArt for "SmartArt"
            /// </summary>
            SmartArt,
            
            /// <summary>
            /// Enum OleObjectFrame for "OleObjectFrame"
            /// </summary>
            OleObjectFrame,
            
            /// <summary>
            /// Enum GroupShape for "GroupShape"
            /// </summary>
            GroupShape,
            
            /// <summary>
            /// Enum GraphicalObject for "GraphicalObject"
            /// </summary>
            GraphicalObject,
            
            /// <summary>
            /// Enum Connector for "Connector"
            /// </summary>
            Connector,
            
            /// <summary>
            /// Enum SmartArtShape for "SmartArtShape"
            /// </summary>
            SmartArtShape,
            
            /// <summary>
            /// Enum ZoomFrame for "ZoomFrame"
            /// </summary>
            ZoomFrame,
            
            /// <summary>
            /// Enum SectionZoomFrame for "SectionZoomFrame"
            /// </summary>
            SectionZoomFrame,
            
            /// <summary>
            /// Enum SummaryZoomFrame for "SummaryZoomFrame"
            /// </summary>
            SummaryZoomFrame,
            
            /// <summary>
            /// Enum SummaryZoomSection for "SummaryZoomSection"
            /// </summary>
            SummaryZoomSection
        }

        /// <summary>
        /// Gets or sets Type
        /// </summary>
        public TypeEnum? Type { get; protected set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// Gets or sets the alternative text.
        /// </summary>
        public string AlternativeText { get; set; }

        /// <summary>
        /// The title of alternative text associated with the shape.
        /// </summary>
        public string AlternativeTextTitle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this ShapeBase is hidden.
        /// </summary>
        public bool? Hidden { get; set; }

        /// <summary>
        /// Gets or sets the X
        /// </summary>
        public double? X { get; set; }

        /// <summary>
        /// Gets or sets the Y.
        /// </summary>
        public double? Y { get; set; }

        /// <summary>
        /// Gets z-order position of shape
        /// </summary>
        public int? ZOrderPosition { get; set; }

        /// <summary>
        /// Gets or sets the fill format.
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Gets or sets the effect format.
        /// </summary>
        public EffectFormat EffectFormat { get; set; }

        /// <summary>
        /// Gets or sets the 3D format
        /// </summary>
        public ThreeDFormat ThreeDFormat { get; set; }

        /// <summary>
        /// Gets or sets the line format.
        /// </summary>
        public LineFormat LineFormat { get; set; }

        /// <summary>
        /// Hyperlink defined for mouse click.
        /// </summary>
        public Hyperlink HyperlinkClick { get; set; }

        /// <summary>
        /// Hyperlink defined for mouse over.
        /// </summary>
        public Hyperlink HyperlinkMouseOver { get; set; }


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
        public ShapeBase() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ShapeBase {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  AlternativeText: ").Append(this.AlternativeText).Append("\n");
            sb.Append("  AlternativeTextTitle: ").Append(this.AlternativeTextTitle).Append("\n");
            sb.Append("  Hidden: ").Append(this.Hidden).Append("\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
