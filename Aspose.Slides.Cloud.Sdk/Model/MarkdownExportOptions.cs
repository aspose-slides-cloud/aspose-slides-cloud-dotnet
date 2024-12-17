// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MarkdownExportOptions.cs">
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
    /// Provides options that control how a presentation is saved in Html5 format.
    /// </summary>  
    public class MarkdownExportOptions : ExportOptions 
    {                       
        /// <summary>
        /// Specifies markdown specification to convert presentation. Default is TextOnly.
        /// </summary>
        /// <value>Specifies markdown specification to convert presentation. Default is TextOnly.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportTypeEnum
        {
            
            /// <summary>
            /// Enum Sequential for "Sequential"
            /// </summary>
            Sequential,
            
            /// <summary>
            /// Enum TextOnly for "TextOnly"
            /// </summary>
            TextOnly,
            
            /// <summary>
            /// Enum Visual for "Visual"
            /// </summary>
            Visual
        }

        /// <summary>
        /// Specifies markdown specification to convert presentation. Default is MultiMarkdown.
        /// </summary>
        /// <value>Specifies markdown specification to convert presentation. Default is MultiMarkdown.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlavorEnum
        {
            
            /// <summary>
            /// Enum Github for "Github"
            /// </summary>
            Github,
            
            /// <summary>
            /// Enum Gruber for "Gruber"
            /// </summary>
            Gruber,
            
            /// <summary>
            /// Enum MultiMarkdown for "MultiMarkdown"
            /// </summary>
            MultiMarkdown,
            
            /// <summary>
            /// Enum CommonMark for "CommonMark"
            /// </summary>
            CommonMark,
            
            /// <summary>
            /// Enum MarkdownExtra for "MarkdownExtra"
            /// </summary>
            MarkdownExtra,
            
            /// <summary>
            /// Enum Pandoc for "Pandoc"
            /// </summary>
            Pandoc,
            
            /// <summary>
            /// Enum Kramdown for "Kramdown"
            /// </summary>
            Kramdown,
            
            /// <summary>
            /// Enum Markua for "Markua"
            /// </summary>
            Markua,
            
            /// <summary>
            /// Enum Maruku for "Maruku"
            /// </summary>
            Maruku,
            
            /// <summary>
            /// Enum Markdown2 for "Markdown2"
            /// </summary>
            Markdown2,
            
            /// <summary>
            /// Enum Remarkable for "Remarkable"
            /// </summary>
            Remarkable,
            
            /// <summary>
            /// Enum Showdown for "Showdown"
            /// </summary>
            Showdown,
            
            /// <summary>
            /// Enum Ghost for "Ghost"
            /// </summary>
            Ghost,
            
            /// <summary>
            /// Enum GitLab for "GitLab"
            /// </summary>
            GitLab,
            
            /// <summary>
            /// Enum Haroopad for "Haroopad"
            /// </summary>
            Haroopad,
            
            /// <summary>
            /// Enum IaWriter for "IaWriter"
            /// </summary>
            IaWriter,
            
            /// <summary>
            /// Enum Redcarpet for "Redcarpet"
            /// </summary>
            Redcarpet,
            
            /// <summary>
            /// Enum ScholarlyMarkdown for "ScholarlyMarkdown"
            /// </summary>
            ScholarlyMarkdown,
            
            /// <summary>
            /// Enum Taiga for "Taiga"
            /// </summary>
            Taiga,
            
            /// <summary>
            /// Enum Trello for "Trello"
            /// </summary>
            Trello,
            
            /// <summary>
            /// Enum S9ETextFormatter for "S9ETextFormatter"
            /// </summary>
            S9ETextFormatter,
            
            /// <summary>
            /// Enum XWiki for "XWiki"
            /// </summary>
            XWiki,
            
            /// <summary>
            /// Enum StackOverflow for "StackOverflow"
            /// </summary>
            StackOverflow,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            Default
        }

        /// <summary>
        /// Specifies whether the generated document should have new lines of \\\\r(Macintosh), \\\\n(Unix) or \\\\r\\\\n(Windows). Default is Unix.
        /// </summary>
        /// <value>Specifies whether the generated document should have new lines of \\\\r(Macintosh), \\\\n(Unix) or \\\\r\\\\n(Windows). Default is Unix.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NewLineTypeEnum
        {
            
            /// <summary>
            /// Enum Windows for "Windows"
            /// </summary>
            Windows,
            
            /// <summary>
            /// Enum Unix for "Unix"
            /// </summary>
            Unix,
            
            /// <summary>
            /// Enum Mac for "Mac"
            /// </summary>
            Mac
        }

        /// <summary>
        /// Specifies markdown specification to convert presentation. Default is TextOnly.
        /// </summary>
        public ExportTypeEnum? ExportType { get; set; }

        /// <summary>
        /// Specifies markdown specification to convert presentation. Default is MultiMarkdown.
        /// </summary>
        public FlavorEnum? Flavor { get; set; }

        /// <summary>
        /// Specifies whether the generated document should have new lines of \\\\r(Macintosh), \\\\n(Unix) or \\\\r\\\\n(Windows). Default is Unix.
        /// </summary>
        public NewLineTypeEnum? NewLineType { get; set; }

        /// <summary>
        /// Specifies folder name to save images. Default is Images. 
        /// </summary>
        public string ImagesSaveFolderName { get; set; }

        /// <summary>
        /// Specifies whether the generated document should include slide number. Default is false. 
        /// </summary>
        public bool? ShowSlideNumber { get; set; }

        /// <summary>
        /// Specifies whether the generated document should include comments. Default is false. 
        /// </summary>
        public bool? ShowComments { get; set; }

        /// <summary>
        /// Specifies whether the generated document should include hidden slides. Default is false. 
        /// </summary>
        public bool? ShowHiddenSlides { get; set; }


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
                    s_typeDeterminers.Add("Format", "md");
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public MarkdownExportOptions() : base()
        {
            Format = "md";
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class MarkdownExportOptions {\n");
            sb.Append("  DefaultRegularFont: ").Append(this.DefaultRegularFont).Append("\n");
            sb.Append("  DeleteEmbeddedBinaryObjects: ").Append(this.DeleteEmbeddedBinaryObjects).Append("\n");
            sb.Append("  GradientStyle: ").Append(this.GradientStyle).Append("\n");
            sb.Append("  FontFallbackRules: ").Append(this.FontFallbackRules).Append("\n");
            sb.Append("  FontSubstRules: ").Append(this.FontSubstRules).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  ExportType: ").Append(this.ExportType).Append("\n");
            sb.Append("  Flavor: ").Append(this.Flavor).Append("\n");
            sb.Append("  NewLineType: ").Append(this.NewLineType).Append("\n");
            sb.Append("  ImagesSaveFolderName: ").Append(this.ImagesSaveFolderName).Append("\n");
            sb.Append("  ShowSlideNumber: ").Append(this.ShowSlideNumber).Append("\n");
            sb.Append("  ShowComments: ").Append(this.ShowComments).Append("\n");
            sb.Append("  ShowHiddenSlides: ").Append(this.ShowHiddenSlides).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
