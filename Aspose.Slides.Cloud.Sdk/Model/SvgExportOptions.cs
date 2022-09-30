// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SvgExportOptions.cs">
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
    /// Provides options that control how a presentation is saved in SVG format.
    /// </summary>  
    public class SvgExportOptions : ExportOptions 
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
        /// Determines a way of handling externally loaded fonts.
        /// </summary>
        /// <value>Determines a way of handling externally loaded fonts.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExternalFontsHandlingEnum
        {
            
            /// <summary>
            /// Enum AddLinksToFontFiles for "AddLinksToFontFiles"
            /// </summary>
            AddLinksToFontFiles,
            
            /// <summary>
            /// Enum Embed for "Embed"
            /// </summary>
            Embed,
            
            /// <summary>
            /// Enum Vectorize for "Vectorize"
            /// </summary>
            Vectorize
        }

        /// <summary>
        /// Represents the pictures compression level
        /// </summary>
        public PicturesCompressionEnum? PicturesCompression { get; set; }

        /// <summary>
        /// Determines a way of handling externally loaded fonts.
        /// </summary>
        public ExternalFontsHandlingEnum? ExternalFontsHandling { get; set; }

        /// <summary>
        /// Determines whether the text on a slide will be saved as graphics.
        /// </summary>
        public bool? VectorizeText { get; set; }

        /// <summary>
        /// Returns or sets the lower resolution limit for metafile rasterization.
        /// </summary>
        public int? MetafileRasterizationDpi { get; set; }

        /// <summary>
        /// Determines whether the 3D text is disabled in SVG.
        /// </summary>
        public bool? Disable3DText { get; set; }

        /// <summary>
        /// Disables splitting FromCornerX and FromCenter gradients.
        /// </summary>
        public bool? DisableGradientSplit { get; set; }

        /// <summary>
        /// SVG 1.1 lacks ability to define insets for markers. Aspose.Slides SVG writing engine has workaround for that problem: it crops end of line with arrow, so, line doesn't overlap markers. This option switches off such behavior.
        /// </summary>
        public bool? DisableLineEndCropping { get; set; }

        /// <summary>
        /// Determines JPEG encoding quality.
        /// </summary>
        public int? JpegQuality { get; set; }

        /// <summary>
        /// A boolean flag indicates if the cropped parts remain as part of the document. If true the cropped  parts will removed, if false they will be serialized in the document (which can possible lead to a  larger file)
        /// </summary>
        public bool? DeletePicturesCroppedAreas { get; set; }


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
                    s_typeDeterminers.Add("Format", "svg");
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SvgExportOptions() : base()
        {
            Format = "svg";
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class SvgExportOptions {\n");
            sb.Append("  DefaultRegularFont: ").Append(this.DefaultRegularFont).Append("\n");
            sb.Append("  FontFallbackRules: ").Append(this.FontFallbackRules).Append("\n");
            sb.Append("  FontSubstRules: ").Append(this.FontSubstRules).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  VectorizeText: ").Append(this.VectorizeText).Append("\n");
            sb.Append("  MetafileRasterizationDpi: ").Append(this.MetafileRasterizationDpi).Append("\n");
            sb.Append("  Disable3DText: ").Append(this.Disable3DText).Append("\n");
            sb.Append("  DisableGradientSplit: ").Append(this.DisableGradientSplit).Append("\n");
            sb.Append("  DisableLineEndCropping: ").Append(this.DisableLineEndCropping).Append("\n");
            sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
            sb.Append("  PicturesCompression: ").Append(this.PicturesCompression).Append("\n");
            sb.Append("  DeletePicturesCroppedAreas: ").Append(this.DeletePicturesCroppedAreas).Append("\n");
            sb.Append("  ExternalFontsHandling: ").Append(this.ExternalFontsHandling).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
