// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ReplaceText.cs">
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
    /// Replace text task.
    /// </summary>  
    public class ReplaceText : Task 
    {                       
        /// <summary>
        /// Text to be replaced.
        /// </summary>
        public string OldText { get; set; }

        /// <summary>
        /// Text to replace with.
        /// </summary>
        public string NewText { get; set; }

        /// <summary>
        /// True to ignore case in replace pattern search.
        /// </summary>
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// One-based position of the slide to perform the replace in. 0 to make the replace throughout the presentation.
        /// </summary>
        public int? SlidePosition { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.ReplaceText);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public ReplaceText() : base()
        {
            Type = TypeEnum.ReplaceText;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaceText {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  OldText: ").Append(this.OldText).Append("\n");
            sb.Append("  NewText: ").Append(this.NewText).Append("\n");
            sb.Append("  IgnoreCase: ").Append(this.IgnoreCase).Append("\n");
            sb.Append("  SlidePosition: ").Append(this.SlidePosition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
