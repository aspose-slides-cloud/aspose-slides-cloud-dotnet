// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableCell.cs">
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
    /// Represents one cell of table.
    /// </summary>  
    public class TableCell 
    {                       
        /// <summary>
        /// Text anchor type.
        /// </summary>
        /// <value>Text anchor type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextAnchorTypeEnum
        {
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            Center,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>
            Bottom,
            
            /// <summary>
            /// Enum Justified for "Justified"
            /// </summary>
            Justified,
            
            /// <summary>
            /// Enum Distributed for "Distributed"
            /// </summary>
            Distributed,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// The type of vertical text.
        /// </summary>
        /// <value>The type of vertical text.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextVerticalTypeEnum
        {
            
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>
            Horizontal,
            
            /// <summary>
            /// Enum Vertical for "Vertical"
            /// </summary>
            Vertical,
            
            /// <summary>
            /// Enum Vertical270 for "Vertical270"
            /// </summary>
            Vertical270,
            
            /// <summary>
            /// Enum WordArtVertical for "WordArtVertical"
            /// </summary>
            WordArtVertical,
            
            /// <summary>
            /// Enum EastAsianVertical for "EastAsianVertical"
            /// </summary>
            EastAsianVertical,
            
            /// <summary>
            /// Enum MongolianVertical for "MongolianVertical"
            /// </summary>
            MongolianVertical,
            
            /// <summary>
            /// Enum WordArtVerticalRightToLeft for "WordArtVerticalRightToLeft"
            /// </summary>
            WordArtVerticalRightToLeft,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Text anchor type.
        /// </summary>
        public TextAnchorTypeEnum? TextAnchorType { get; set; }

        /// <summary>
        /// The type of vertical text.
        /// </summary>
        public TextVerticalTypeEnum? TextVerticalType { get; set; }

        /// <summary>
        /// Cell text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The number of rows spanned by a merged cell.
        /// </summary>
        public int? RowSpan { get; set; }

        /// <summary>
        /// The number of columns spanned by a merged cell.
        /// </summary>
        public int? ColSpan { get; set; }

        /// <summary>
        /// The top margin of the cell.
        /// </summary>
        public double? MarginTop { get; set; }

        /// <summary>
        /// The right margin of the cell.
        /// </summary>
        public double? MarginRight { get; set; }

        /// <summary>
        /// The left margin of the cell.
        /// </summary>
        public double? MarginLeft { get; set; }

        /// <summary>
        /// The bottom margin of the cell.
        /// </summary>
        public double? MarginBottom { get; set; }

        /// <summary>
        /// Fill properties set of the cell.
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Line properties set for the top border of the cell.
        /// </summary>
        public LineFormat BorderTop { get; set; }

        /// <summary>
        /// Line properties set for the right border of the cell.
        /// </summary>
        public LineFormat BorderRight { get; set; }

        /// <summary>
        /// Line properties set for the left border of the cell.
        /// </summary>
        public LineFormat BorderLeft { get; set; }

        /// <summary>
        /// Line properties set for the bottom border of the cell.
        /// </summary>
        public LineFormat BorderBottom { get; set; }

        /// <summary>
        /// Line properties set for the diagonal up border of the cell.
        /// </summary>
        public LineFormat BorderDiagonalUp { get; set; }

        /// <summary>
        /// Line properties set for the diagonal down border of the cell.
        /// </summary>
        public LineFormat BorderDiagonalDown { get; set; }


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
        public TableCell() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TableCell {\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  RowSpan: ").Append(this.RowSpan).Append("\n");
            sb.Append("  ColSpan: ").Append(this.ColSpan).Append("\n");
            sb.Append("  MarginTop: ").Append(this.MarginTop).Append("\n");
            sb.Append("  MarginRight: ").Append(this.MarginRight).Append("\n");
            sb.Append("  MarginLeft: ").Append(this.MarginLeft).Append("\n");
            sb.Append("  MarginBottom: ").Append(this.MarginBottom).Append("\n");
            sb.Append("  TextAnchorType: ").Append(this.TextAnchorType).Append("\n");
            sb.Append("  TextVerticalType: ").Append(this.TextVerticalType).Append("\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  BorderTop: ").Append(this.BorderTop).Append("\n");
            sb.Append("  BorderRight: ").Append(this.BorderRight).Append("\n");
            sb.Append("  BorderLeft: ").Append(this.BorderLeft).Append("\n");
            sb.Append("  BorderBottom: ").Append(this.BorderBottom).Append("\n");
            sb.Append("  BorderDiagonalUp: ").Append(this.BorderDiagonalUp).Append("\n");
            sb.Append("  BorderDiagonalDown: ").Append(this.BorderDiagonalDown).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
