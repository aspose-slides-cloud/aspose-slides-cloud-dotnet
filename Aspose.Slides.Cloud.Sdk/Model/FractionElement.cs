// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FractionElement.cs">
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
    /// Specifies the fraction object, consisting of a numerator and denominator separated by a fraction bar.
    /// </summary>  
    public class FractionElement : MathElement 
    {                       
        /// <summary>
        /// Fraction type
        /// </summary>
        /// <value>Fraction type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FractionTypeEnum
        {
            
            /// <summary>
            /// Enum Bar for "Bar"
            /// </summary>
            Bar,
            
            /// <summary>
            /// Enum Skewed for "Skewed"
            /// </summary>
            Skewed,
            
            /// <summary>
            /// Enum Linear for "Linear"
            /// </summary>
            Linear,
            
            /// <summary>
            /// Enum NoBar for "NoBar"
            /// </summary>
            NoBar
        }

        /// <summary>
        /// Fraction type
        /// </summary>
        public FractionTypeEnum? FractionType { get; set; }

        /// <summary>
        /// Numerator
        /// </summary>
        public MathElement Numerator { get; set; }

        /// <summary>
        /// Denominator
        /// </summary>
        public MathElement Denominator { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.Fraction);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public FractionElement() : base()
        {
            Type = TypeEnum.Fraction;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class FractionElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  FractionType: ").Append(this.FractionType).Append("\n");
            sb.Append("  Numerator: ").Append(this.Numerator).Append("\n");
            sb.Append("  Denominator: ").Append(this.Denominator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
