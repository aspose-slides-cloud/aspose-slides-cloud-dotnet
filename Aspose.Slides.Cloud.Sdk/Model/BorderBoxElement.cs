// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BorderBoxElement.cs">
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
    /// Rectangular or some other border around the MathElement. 
    /// </summary>  
    public class BorderBoxElement : MathElement 
    {                       
        /// <summary>
        /// Base
        /// </summary>
        public MathElement Base { get; set; }

        /// <summary>
        /// Hide Top Edge
        /// </summary>
        public bool? HideTop { get; set; }

        /// <summary>
        /// Hide Bottom Edge
        /// </summary>
        public bool? HideBottom { get; set; }

        /// <summary>
        /// Hide Left Edge
        /// </summary>
        public bool? HideLeft { get; set; }

        /// <summary>
        /// Hide Right Edge
        /// </summary>
        public bool? HideRight { get; set; }

        /// <summary>
        /// Strikethrough Horizontal
        /// </summary>
        public bool? StrikethroughHorizontal { get; set; }

        /// <summary>
        /// Strikethrough Vertical
        /// </summary>
        public bool? StrikethroughVertical { get; set; }

        /// <summary>
        /// Strikethrough Bottom-Left to Top-Right
        /// </summary>
        public bool? StrikethroughBottomLeftToTopRight { get; set; }

        /// <summary>
        /// Strikethrough Top-Left to Bottom-Right.
        /// </summary>
        public bool? StrikethroughTopLeftToBottomRight { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.BorderBox);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public BorderBoxElement() : base()
        {
            Type = TypeEnum.BorderBox;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class BorderBoxElement {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Base: ").Append(this.Base).Append("\n");
            sb.Append("  HideTop: ").Append(this.HideTop).Append("\n");
            sb.Append("  HideBottom: ").Append(this.HideBottom).Append("\n");
            sb.Append("  HideLeft: ").Append(this.HideLeft).Append("\n");
            sb.Append("  HideRight: ").Append(this.HideRight).Append("\n");
            sb.Append("  StrikethroughHorizontal: ").Append(this.StrikethroughHorizontal).Append("\n");
            sb.Append("  StrikethroughVertical: ").Append(this.StrikethroughVertical).Append("\n");
            sb.Append("  StrikethroughBottomLeftToTopRight: ").Append(this.StrikethroughBottomLeftToTopRight).Append("\n");
            sb.Append("  StrikethroughTopLeftToBottomRight: ").Append(this.StrikethroughTopLeftToBottomRight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
