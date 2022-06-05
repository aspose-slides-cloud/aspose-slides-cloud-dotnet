// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MathElement.cs">
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
    /// Math element.
    /// </summary>  
    public class MathElement 
    {                       
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Accent for "Accent"
            /// </summary>
            Accent,
            
            /// <summary>
            /// Enum Array for "Array"
            /// </summary>
            Array,
            
            /// <summary>
            /// Enum Bar for "Bar"
            /// </summary>
            Bar,
            
            /// <summary>
            /// Enum Block for "Block"
            /// </summary>
            Block,
            
            /// <summary>
            /// Enum BorderBox for "BorderBox"
            /// </summary>
            BorderBox,
            
            /// <summary>
            /// Enum Box for "Box"
            /// </summary>
            Box,
            
            /// <summary>
            /// Enum Delimiter for "Delimiter"
            /// </summary>
            Delimiter,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            Text,
            
            /// <summary>
            /// Enum Fraction for "Fraction"
            /// </summary>
            Fraction,
            
            /// <summary>
            /// Enum Function for "Function"
            /// </summary>
            Function,
            
            /// <summary>
            /// Enum GroupingCharacter for "GroupingCharacter"
            /// </summary>
            GroupingCharacter,
            
            /// <summary>
            /// Enum LeftSubSuperscriptElement for "LeftSubSuperscriptElement"
            /// </summary>
            LeftSubSuperscriptElement,
            
            /// <summary>
            /// Enum Limit for "Limit"
            /// </summary>
            Limit,
            
            /// <summary>
            /// Enum Matrix for "Matrix"
            /// </summary>
            Matrix,
            
            /// <summary>
            /// Enum NaryOperator for "NaryOperator"
            /// </summary>
            NaryOperator,
            
            /// <summary>
            /// Enum Radical for "Radical"
            /// </summary>
            Radical,
            
            /// <summary>
            /// Enum RightSubSuperscriptElement for "RightSubSuperscriptElement"
            /// </summary>
            RightSubSuperscriptElement,
            
            /// <summary>
            /// Enum SubscriptElement for "SubscriptElement"
            /// </summary>
            SubscriptElement,
            
            /// <summary>
            /// Enum SuperscriptElement for "SuperscriptElement"
            /// </summary>
            SuperscriptElement
        }

        /// <summary>
        /// Gets or sets Type
        /// </summary>
        public TypeEnum? Type { get; protected set; }


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
        public MathElement() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class MathElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
