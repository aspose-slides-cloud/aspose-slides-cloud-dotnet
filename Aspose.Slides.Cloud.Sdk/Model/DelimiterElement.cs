// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DelimiterElement.cs">
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
    /// Delimiter element
    /// </summary>  
    public class DelimiterElement : MathElement 
    {                       
        /// <summary>
        /// Delimiter shape
        /// </summary>
        /// <value>Delimiter shape</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DelimiterShapeEnum
        {
            
            /// <summary>
            /// Enum Centered for "Centered"
            /// </summary>
            Centered,
            
            /// <summary>
            /// Enum Match for "Match"
            /// </summary>
            Match
        }

        /// <summary>
        /// Delimiter shape
        /// </summary>
        public DelimiterShapeEnum? DelimiterShape { get; set; }

        /// <summary>
        /// Arguments
        /// </summary>
        public List<MathElement> Arguments { get; set; }

        /// <summary>
        /// Beginning character
        /// </summary>
        public string BeginningCharacter { get; set; }

        /// <summary>
        /// Separator character
        /// </summary>
        public string SeparatorCharacter { get; set; }

        /// <summary>
        /// Ending character
        /// </summary>
        public string EndingCharacter { get; set; }

        /// <summary>
        /// Grow to match operand height
        /// </summary>
        public bool? GrowToMatchOperandHeight { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.Delimiter);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public DelimiterElement() : base()
        {
            Type = TypeEnum.Delimiter;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class DelimiterElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Arguments: ").Append(this.Arguments).Append("\n");
            sb.Append("  BeginningCharacter: ").Append(this.BeginningCharacter).Append("\n");
            sb.Append("  SeparatorCharacter: ").Append(this.SeparatorCharacter).Append("\n");
            sb.Append("  EndingCharacter: ").Append(this.EndingCharacter).Append("\n");
            sb.Append("  GrowToMatchOperandHeight: ").Append(this.GrowToMatchOperandHeight).Append("\n");
            sb.Append("  DelimiterShape: ").Append(this.DelimiterShape).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
