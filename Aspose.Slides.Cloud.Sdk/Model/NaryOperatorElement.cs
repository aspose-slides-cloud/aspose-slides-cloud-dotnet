// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NaryOperatorElement.cs">
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
    /// Specifies an N-ary mathematical object, such as Summation and Integral.
    /// </summary>  
    public class NaryOperatorElement : MathElement 
    {                       
        /// <summary>
        /// The location of limits (subscript and superscript)
        /// </summary>
        /// <value>The location of limits (subscript and superscript)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LimitLocationEnum
        {
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined,
            
            /// <summary>
            /// Enum UnderOver for "UnderOver"
            /// </summary>
            UnderOver,
            
            /// <summary>
            /// Enum SubscriptSuperscript for "SubscriptSuperscript"
            /// </summary>
            SubscriptSuperscript
        }

        /// <summary>
        /// The location of limits (subscript and superscript)
        /// </summary>
        public LimitLocationEnum? LimitLocation { get; set; }

        /// <summary>
        /// Base argument
        /// </summary>
        public MathElement Base { get; set; }

        /// <summary>
        /// Subscript argument
        /// </summary>
        public MathElement Subscript { get; set; }

        /// <summary>
        /// Superscript argument
        /// </summary>
        public MathElement Superscript { get; set; }

        /// <summary>
        /// Nary Operator Character
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// Operator Character grows vertically to match its operand height
        /// </summary>
        public bool? GrowToMatchOperandHeight { get; set; }

        /// <summary>
        /// Hide Subscript
        /// </summary>
        public bool? HideSubscript { get; set; }

        /// <summary>
        /// Hide Superscript
        /// </summary>
        public bool? HideSuperscript { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.NaryOperator);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public NaryOperatorElement() : base()
        {
            Type = TypeEnum.NaryOperator;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class NaryOperatorElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Base: ").Append(this.Base).Append("\n");
            sb.Append("  Subscript: ").Append(this.Subscript).Append("\n");
            sb.Append("  Superscript: ").Append(this.Superscript).Append("\n");
            sb.Append("  Operator: ").Append(this.Operator).Append("\n");
            sb.Append("  LimitLocation: ").Append(this.LimitLocation).Append("\n");
            sb.Append("  GrowToMatchOperandHeight: ").Append(this.GrowToMatchOperandHeight).Append("\n");
            sb.Append("  HideSubscript: ").Append(this.HideSubscript).Append("\n");
            sb.Append("  HideSuperscript: ").Append(this.HideSuperscript).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
