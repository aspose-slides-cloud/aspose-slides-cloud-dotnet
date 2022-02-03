// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MatrixElement.cs">
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
    /// Specifies the Matrix object,
    /// </summary>  
    public class MatrixElement : MathElement 
    {                       
        /// <summary>
        /// Specifies the vertical justification respect to surrounding text. 
        /// </summary>
        /// <value>Specifies the vertical justification respect to surrounding text. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BaseJustificationEnum
        {
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined,
            
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
            Bottom
        }

        /// <summary>
        /// The type of horizontal spacing between columns of a matrix.
        /// </summary>
        /// <value>The type of horizontal spacing between columns of a matrix.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColumnGapRuleEnum
        {
            
            /// <summary>
            /// Enum SingleSpacingGap for "SingleSpacingGap"
            /// </summary>
            SingleSpacingGap,
            
            /// <summary>
            /// Enum OneAndHalfSpacingGap for "OneAndHalfSpacingGap"
            /// </summary>
            OneAndHalfSpacingGap,
            
            /// <summary>
            /// Enum DoubleSpacingGap for "DoubleSpacingGap"
            /// </summary>
            DoubleSpacingGap,
            
            /// <summary>
            /// Enum Exactly for "Exactly"
            /// </summary>
            Exactly,
            
            /// <summary>
            /// Enum Multiple for "Multiple"
            /// </summary>
            Multiple
        }

        /// <summary>
        /// The type of vertical spacing between rows of a matrix
        /// </summary>
        /// <value>The type of vertical spacing between rows of a matrix</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RowGapRuleEnum
        {
            
            /// <summary>
            /// Enum SingleSpacingGap for "SingleSpacingGap"
            /// </summary>
            SingleSpacingGap,
            
            /// <summary>
            /// Enum OneAndHalfSpacingGap for "OneAndHalfSpacingGap"
            /// </summary>
            OneAndHalfSpacingGap,
            
            /// <summary>
            /// Enum DoubleSpacingGap for "DoubleSpacingGap"
            /// </summary>
            DoubleSpacingGap,
            
            /// <summary>
            /// Enum Exactly for "Exactly"
            /// </summary>
            Exactly,
            
            /// <summary>
            /// Enum Multiple for "Multiple"
            /// </summary>
            Multiple
        }

        /// <summary>
        /// Specifies the vertical justification respect to surrounding text. 
        /// </summary>
        public BaseJustificationEnum? BaseJustification { get; set; }

        /// <summary>
        /// The type of horizontal spacing between columns of a matrix.
        /// </summary>
        public ColumnGapRuleEnum? ColumnGapRule { get; set; }

        /// <summary>
        /// The type of vertical spacing between rows of a matrix
        /// </summary>
        public RowGapRuleEnum? RowGapRule { get; set; }

        /// <summary>
        /// Hide the placeholders for empty matrix elements
        /// </summary>
        public bool? HidePlaceholders { get; set; }

        /// <summary>
        /// Minimum column width in twips (1/20th of a point)
        /// </summary>
        public int? MinColumnWidth { get; set; }

        /// <summary>
        /// The value of horizontal spacing between columns of a matrix
        /// </summary>
        public int? ColumnGap { get; set; }

        /// <summary>
        /// The value of vertical spacing between rows of a matrix;             
        /// </summary>
        public int? RowGap { get; set; }

        /// <summary>
        /// Matrix items
        /// </summary>
        public List<List<MathElement>> Items { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.Matrix);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public MatrixElement() : base()
        {
            Type = TypeEnum.Matrix;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class MatrixElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  HidePlaceholders: ").Append(this.HidePlaceholders).Append("\n");
            sb.Append("  BaseJustification: ").Append(this.BaseJustification).Append("\n");
            sb.Append("  MinColumnWidth: ").Append(this.MinColumnWidth).Append("\n");
            sb.Append("  ColumnGapRule: ").Append(this.ColumnGapRule).Append("\n");
            sb.Append("  ColumnGap: ").Append(this.ColumnGap).Append("\n");
            sb.Append("  RowGapRule: ").Append(this.RowGapRule).Append("\n");
            sb.Append("  RowGap: ").Append(this.RowGap).Append("\n");
            sb.Append("  Items: ").Append(this.Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
