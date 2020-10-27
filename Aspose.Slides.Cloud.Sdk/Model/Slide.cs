// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Slide.cs">
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
    /// Presentation slide.
    /// </summary>  
    public class Slide : ResourceBase 
    {                       
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// Specifies if shapes of the master slide should be shown on the slide. True by default.
        /// </summary>
        public bool? ShowMasterShapes { get; set; }

        /// <summary>
        /// Gets or sets the  link to the layout slide.
        /// </summary>
        public ResourceUri LayoutSlide { get; set; }

        /// <summary>
        /// Gets or sets the  link to list of top-level shapes.
        /// </summary>
        public ResourceUri Shapes { get; set; }

        /// <summary>
        /// Gets or sets the link to theme.
        /// </summary>
        public ResourceUri Theme { get; set; }

        /// <summary>
        /// Gets or sets the  link to placeholders.
        /// </summary>
        public ResourceUri Placeholders { get; set; }

        /// <summary>
        /// Gets or sets the link to images.
        /// </summary>
        public ResourceUri Images { get; set; }

        /// <summary>
        /// Gets or sets the link to comments.
        /// </summary>
        public ResourceUri Comments { get; set; }

        /// <summary>
        /// Get or sets the link to slide's background
        /// </summary>
        public ResourceUri Background { get; set; }

        /// <summary>
        /// Get or sets the link to notes slide.
        /// </summary>
        public ResourceUri NotesSlide { get; set; }


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
        public Slide() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Slide {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  ShowMasterShapes: ").Append(this.ShowMasterShapes).Append("\n");
            sb.Append("  LayoutSlide: ").Append(this.LayoutSlide).Append("\n");
            sb.Append("  Shapes: ").Append(this.Shapes).Append("\n");
            sb.Append("  Theme: ").Append(this.Theme).Append("\n");
            sb.Append("  Placeholders: ").Append(this.Placeholders).Append("\n");
            sb.Append("  Images: ").Append(this.Images).Append("\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  Background: ").Append(this.Background).Append("\n");
            sb.Append("  NotesSlide: ").Append(this.NotesSlide).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
