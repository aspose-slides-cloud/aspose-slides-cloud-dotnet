// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HtmlExportOptions.cs">
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
    /// Provides options that control how a presentation is saved in Html format.
    /// </summary>  
    public class HtmlExportOptions : ExportOptions 
    {                       
        /// <summary>
        /// Represents the pictures compression level
        /// </summary>
        /// <value>Represents the pictures compression level</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PicturesCompressionEnum
        {
            
            /// <summary>
            /// Enum Dpi330 for "Dpi330"
            /// </summary>
            Dpi330,
            
            /// <summary>
            /// Enum Dpi220 for "Dpi220"
            /// </summary>
            Dpi220,
            
            /// <summary>
            /// Enum Dpi150 for "Dpi150"
            /// </summary>
            Dpi150,
            
            /// <summary>
            /// Enum Dpi96 for "Dpi96"
            /// </summary>
            Dpi96,
            
            /// <summary>
            /// Enum Dpi72 for "Dpi72"
            /// </summary>
            Dpi72,
            
            /// <summary>
            /// Enum DocumentResolution for "DocumentResolution"
            /// </summary>
            DocumentResolution
        }

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
        /// Represents the pictures compression level
        /// </summary>
        public PicturesCompressionEnum? PicturesCompression { get; set; }

        /// <summary>
        /// Gets or sets the position of the notes on the page.
        /// </summary>
        public NotesPositionEnum? NotesPosition { get; set; }

        /// <summary>
        /// Gets or sets the position of the comments on the page.
        /// </summary>
        public CommentsPositionEnum? CommentsPosition { get; set; }

        /// <summary>
        /// Get or sets flag for save presentation as zip file
        /// </summary>
        public bool? SaveAsZip { get; set; }

        /// <summary>
        /// Get or set name of subdirectory in zip-file for store external files
        /// </summary>
        public string SubDirectoryName { get; set; }

        /// <summary>
        /// Specifies whether the generated document should include hidden slides or not. Default is false. 
        /// </summary>
        public bool? ShowHiddenSlides { get; set; }

        /// <summary>
        /// True to make layout responsive by excluding width and height attributes from svg container.
        /// </summary>
        public bool? SvgResponsiveLayout { get; set; }

        /// <summary>
        /// Returns or sets a value determining the quality of the JPEG images inside PDF document.
        /// </summary>
        public int? JpegQuality { get; set; }

        /// <summary>
        /// A boolean flag indicates if the cropped parts remain as part of the document. If true the cropped  parts will removed, if false they will be serialized in the document (which can possible lead to a  larger file)
        /// </summary>
        public bool? DeletePicturesCroppedAreas { get; set; }

        /// <summary>
        /// Gets or sets the width of the comment output area in pixels (Applies only if comments are displayed on the right).
        /// </summary>
        public int? CommentsAreaWidth { get; set; }

        /// <summary>
        /// Gets or sets the color of comments area (Applies only if comments are displayed on the right).
        /// </summary>
        public string CommentsAreaColor { get; set; }

        /// <summary>
        /// True if comments that have no author are displayed. (Applies only if comments are displayed).
        /// </summary>
        public bool? ShowCommentsByNoAuthor { get; set; }


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
                    s_typeDeterminers.Add("Format", "html");
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public HtmlExportOptions() : base()
        {
            Format = "html";
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlExportOptions {\n");
            sb.Append("  DefaultRegularFont: ").Append(this.DefaultRegularFont).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  FontFallbackRules: ").Append(this.FontFallbackRules).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  SaveAsZip: ").Append(this.SaveAsZip).Append("\n");
            sb.Append("  SubDirectoryName: ").Append(this.SubDirectoryName).Append("\n");
            sb.Append("  ShowHiddenSlides: ").Append(this.ShowHiddenSlides).Append("\n");
            sb.Append("  SvgResponsiveLayout: ").Append(this.SvgResponsiveLayout).Append("\n");
            sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
            sb.Append("  PicturesCompression: ").Append(this.PicturesCompression).Append("\n");
            sb.Append("  DeletePicturesCroppedAreas: ").Append(this.DeletePicturesCroppedAreas).Append("\n");
            sb.Append("  NotesPosition: ").Append(this.NotesPosition).Append("\n");
            sb.Append("  CommentsPosition: ").Append(this.CommentsPosition).Append("\n");
            sb.Append("  CommentsAreaWidth: ").Append(this.CommentsAreaWidth).Append("\n");
            sb.Append("  CommentsAreaColor: ").Append(this.CommentsAreaColor).Append("\n");
            sb.Append("  ShowCommentsByNoAuthor: ").Append(this.ShowCommentsByNoAuthor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
