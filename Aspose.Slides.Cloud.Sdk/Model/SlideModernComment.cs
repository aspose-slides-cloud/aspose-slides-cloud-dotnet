// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SlideModernComment.cs">
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
    /// Represents modern comment of slide
    /// </summary>  
    public class SlideModernComment : SlideCommentBase 
    {                       
        /// <summary>
        /// Returns or sets the status of the comment. Read/write ModernCommentStatus.
        /// </summary>
        /// <value>Returns or sets the status of the comment. Read/write ModernCommentStatus.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            Active,
            
            /// <summary>
            /// Enum Resolved for "Resolved"
            /// </summary>
            Resolved,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            Closed
        }

        /// <summary>
        /// Returns or sets the status of the comment. Read/write ModernCommentStatus.
        /// </summary>
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Returns or sets starting position of text selection in text frame if the comment associated with AutoShape. Read/write Int32.
        /// </summary>
        public int? TextSelectionStart { get; set; }

        /// <summary>
        /// Returns or sets text selection length in text frame if the comment associated with AutoShape. Read/write Int32.
        /// </summary>
        public int? TextSelectionLength { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.Modern);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SlideModernComment() : base()
        {
            Type = TypeEnum.Modern;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class SlideModernComment {\n");
            sb.Append("  Author: ").Append(this.Author).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
            sb.Append("  CreatedTime: ").Append(this.CreatedTime).Append("\n");
            sb.Append("  ChildComments: ").Append(this.ChildComments).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  TextSelectionStart: ").Append(this.TextSelectionStart).Append("\n");
            sb.Append("  TextSelectionLength: ").Append(this.TextSelectionLength).Append("\n");
            sb.Append("  Status: ").Append(this.Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
