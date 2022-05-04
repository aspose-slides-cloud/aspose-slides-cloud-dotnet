// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AccessPermissions.cs">
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
    /// A set of properties specifying which access permissions should be granted when the document is opened with user access.
    /// </summary>  
    public class AccessPermissions 
    {                       
        /// <summary>
        /// The user may print the document (possibly not at the highest quality level, depending on whether bit HighQualityPrint is also set).
        /// </summary>
        public bool? PrintDocument { get; set; }

        /// <summary>
        /// The user may modify the contents of the document by operations other than those controlled by bits AddOrModifyFields, FillExistingFields, AssembleDocument.
        /// </summary>
        public bool? ModifyContent { get; set; }

        /// <summary>
        /// The user may copy or otherwise extract text and graphics from the document by operations other than that controlled by bit ExtractTextAndGraphics.
        /// </summary>
        public bool? CopyTextAndGraphics { get; set; }

        /// <summary>
        /// The user may add or modify text annotations, fill in interactive form fields, and, if bit ModifyContent is also set, create or modify interactive form fields (including signature fields).
        /// </summary>
        public bool? AddOrModifyFields { get; set; }

        /// <summary>
        /// The user may fill in existing interactive form fields (including signature fields), even if bit AddOrModifyFields is clear.
        /// </summary>
        public bool? FillExistingFields { get; set; }

        /// <summary>
        /// The user may extract text and graphics in support of accessibility to users with disabilities or for other purposes.
        /// </summary>
        public bool? ExtractTextAndGraphics { get; set; }

        /// <summary>
        /// The user may assemble the document (insert, rotate, or delete pages and create bookmarks or thumbnail images), even if bit ModifyContent is clear.
        /// </summary>
        public bool? AssembleDocument { get; set; }

        /// <summary>
        /// The user may print the document to a representation from which a faithful digital copy of the PDF content could be generated. When this bit is clear (and bit PrintDocument is set), printing is limited to a low-level representation of the appearance, possibly of degraded quality.
        /// </summary>
        public bool? HighQualityPrint { get; set; }


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
        public AccessPermissions() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class AccessPermissions {\n");
            sb.Append("  PrintDocument: ").Append(this.PrintDocument).Append("\n");
            sb.Append("  ModifyContent: ").Append(this.ModifyContent).Append("\n");
            sb.Append("  CopyTextAndGraphics: ").Append(this.CopyTextAndGraphics).Append("\n");
            sb.Append("  AddOrModifyFields: ").Append(this.AddOrModifyFields).Append("\n");
            sb.Append("  FillExistingFields: ").Append(this.FillExistingFields).Append("\n");
            sb.Append("  ExtractTextAndGraphics: ").Append(this.ExtractTextAndGraphics).Append("\n");
            sb.Append("  AssembleDocument: ").Append(this.AssembleDocument).Append("\n");
            sb.Append("  HighQualityPrint: ").Append(this.HighQualityPrint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
