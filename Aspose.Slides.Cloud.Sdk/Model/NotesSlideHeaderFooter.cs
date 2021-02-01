// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NotesSlideHeaderFooter.cs">
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
    /// Represents header/footer info of notes slide
    /// </summary>  
    public class NotesSlideHeaderFooter : ResourceBase 
    {                       
        /// <summary>
        /// True if date is displayed in the footer
        /// </summary>
        public bool? IsDateTimeVisible { get; set; }

        /// <summary>
        /// Text to be displayed as date in the footer
        /// </summary>
        public string DateTimeText { get; set; }

        /// <summary>
        /// True if footer is displayed
        /// </summary>
        public bool? IsFooterVisible { get; set; }

        /// <summary>
        /// Text to be displayed in the footer
        /// </summary>
        public string FooterText { get; set; }

        /// <summary>
        /// True if header is displayed
        /// </summary>
        public bool? IsHeaderVisible { get; set; }

        /// <summary>
        /// Text to be displayed in the header
        /// </summary>
        public string HeaderText { get; set; }

        /// <summary>
        /// True if slide number is displayed in the footer
        /// </summary>
        public bool? IsSlideNumberVisible { get; set; }


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
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public NotesSlideHeaderFooter() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class NotesSlideHeaderFooter {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  IsDateTimeVisible: ").Append(this.IsDateTimeVisible).Append("\n");
            sb.Append("  DateTimeText: ").Append(this.DateTimeText).Append("\n");
            sb.Append("  IsFooterVisible: ").Append(this.IsFooterVisible).Append("\n");
            sb.Append("  FooterText: ").Append(this.FooterText).Append("\n");
            sb.Append("  IsHeaderVisible: ").Append(this.IsHeaderVisible).Append("\n");
            sb.Append("  HeaderText: ").Append(this.HeaderText).Append("\n");
            sb.Append("  IsSlideNumberVisible: ").Append(this.IsSlideNumberVisible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
