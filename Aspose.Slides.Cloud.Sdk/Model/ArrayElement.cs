// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ArrayElement.cs">
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
    /// An array of elements.
    /// </summary>  
    public class ArrayElement : MathElement 
    {                       
        /// <summary>
        /// Specifies alignment of the array relative to surrounding text
        /// </summary>
        /// <value>Specifies alignment of the array relative to surrounding text</value>
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
        /// The type of vertical spacing between array elements
        /// </summary>
        /// <value>The type of vertical spacing between array elements</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RowSpacingRuleEnum
        {
            
            /// <summary>
            /// Enum SingleLineGap for "SingleLineGap"
            /// </summary>
            SingleLineGap,
            
            /// <summary>
            /// Enum OneAndAHalfLineGap for "OneAndAHalfLineGap"
            /// </summary>
            OneAndAHalfLineGap,
            
            /// <summary>
            /// Enum TwoLineGap for "TwoLineGap"
            /// </summary>
            TwoLineGap,
            
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
        /// Specifies alignment of the array relative to surrounding text
        /// </summary>
        public BaseJustificationEnum? BaseJustification { get; set; }

        /// <summary>
        /// The type of vertical spacing between array elements
        /// </summary>
        public RowSpacingRuleEnum? RowSpacingRule { get; set; }

        /// <summary>
        /// Arguments
        /// </summary>
        public List<MathElement> Arguments { get; set; }

        /// <summary>
        /// Maximum Distribution
        /// </summary>
        public bool? MaximumDistribution { get; set; }

        /// <summary>
        /// Object Distribution
        /// </summary>
        public bool? ObjectDistribution { get; set; }

        /// <summary>
        /// Spacing between rows of an array
        /// </summary>
        public int? RowSpacing { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.Array);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public ArrayElement() : base()
        {
            Type = TypeEnum.Array;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ArrayElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Arguments: ").Append(this.Arguments).Append("\n");
            sb.Append("  BaseJustification: ").Append(this.BaseJustification).Append("\n");
            sb.Append("  MaximumDistribution: ").Append(this.MaximumDistribution).Append("\n");
            sb.Append("  ObjectDistribution: ").Append(this.ObjectDistribution).Append("\n");
            sb.Append("  RowSpacingRule: ").Append(this.RowSpacingRule).Append("\n");
            sb.Append("  RowSpacing: ").Append(this.RowSpacing).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
