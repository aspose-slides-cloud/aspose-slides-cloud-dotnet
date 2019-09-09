// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageExportOptions.cs">
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
    /// Provides options that control how a presentation is saved in an image format.
    /// </summary>  
    public class ImageExportOptions : ExportOptions 
    {                       
        /// <summary>
        /// Gets or sets the position of the notes on the page.
        /// </summary>
        /// <value>Gets or sets the position of the notes on the page.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NotesPositionEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum BottomFull for "BottomFull"
            /// </summary>
            BottomFull,
            
            /// <summary>
            /// Enum BottomTruncated for "BottomTruncated"
            /// </summary>
            BottomTruncated
        }

        /// <summary>
        /// Gets or sets the position of the comments on the page.
        /// </summary>
        /// <value>Gets or sets the position of the comments on the page.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommentsPositionEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>
            Bottom,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            Right
        }

        /// <summary>
        /// Gets or sets the position of the notes on the page.
        /// </summary>
        public NotesPositionEnum? NotesPosition { get; set; }

        /// <summary>
        /// Gets or sets the position of the comments on the page.
        /// </summary>
        public CommentsPositionEnum? CommentsPosition { get; set; }

        /// <summary>
        /// Gets or sets the width of the comment output area in pixels (Applies only if comments are displayed on the right).
        /// </summary>
        public int? CommentsAreaWidth { get; set; }

        /// <summary>
        /// Gets or sets the color of comments area (Applies only if comments are displayed on the right).
        /// </summary>
        public string CommentsAreaColor { get; set; }


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
                    s_typeDeterminers.Add("Format", "image");
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public ImageExportOptions() : base()
        {
            Format = "image";
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ImageExportOptions {\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  NotesPosition: ").Append(this.NotesPosition).Append("\n");
            sb.Append("  CommentsPosition: ").Append(this.CommentsPosition).Append("\n");
            sb.Append("  CommentsAreaWidth: ").Append(this.CommentsAreaWidth).Append("\n");
            sb.Append("  CommentsAreaColor: ").Append(this.CommentsAreaColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
