// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarElement.cs">
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
    /// Specifies the bar function, consisting of a base argument and an overbar or underbar
    /// </summary>  
    public class BarElement : MathElement 
    {                       
        /// <summary>
        /// Position of the bar line.             
        /// </summary>
        /// <value>Position of the bar line.             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PositionEnum
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
            /// Enum Bottom for "Bottom"
            /// </summary>
            Bottom
        }

        /// <summary>
        /// Position of the bar line.             
        /// </summary>
        public PositionEnum? Position { get; set; }

        /// <summary>
        /// Base
        /// </summary>
        public MathElement Base { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.Bar);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public BarElement() : base()
        {
            Type = TypeEnum.Bar;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class BarElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Base: ").Append(this.Base).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
