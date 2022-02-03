// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BoxElement.cs">
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
    /// Box element.
    /// </summary>  
    public class BoxElement : MathElement 
    {                       
        /// <summary>
        /// Base
        /// </summary>
        public MathElement Base { get; set; }

        /// <summary>
        /// Operator emulator
        /// </summary>
        public bool? OperatorEmulator { get; set; }

        /// <summary>
        /// No break
        /// </summary>
        public bool? NoBreak { get; set; }

        /// <summary>
        /// Differential
        /// </summary>
        public bool? Differential { get; set; }

        /// <summary>
        /// Alignment point
        /// </summary>
        public bool? AlignmentPoint { get; set; }

        /// <summary>
        /// Explicit break
        /// </summary>
        public int? ExplicitBreak { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.Box);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public BoxElement() : base()
        {
            Type = TypeEnum.Box;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class BoxElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Base: ").Append(this.Base).Append("\n");
            sb.Append("  OperatorEmulator: ").Append(this.OperatorEmulator).Append("\n");
            sb.Append("  NoBreak: ").Append(this.NoBreak).Append("\n");
            sb.Append("  Differential: ").Append(this.Differential).Append("\n");
            sb.Append("  AlignmentPoint: ").Append(this.AlignmentPoint).Append("\n");
            sb.Append("  ExplicitBreak: ").Append(this.ExplicitBreak).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
