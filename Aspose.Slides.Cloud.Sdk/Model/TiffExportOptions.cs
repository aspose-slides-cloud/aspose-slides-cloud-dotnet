// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TiffExportOptions.cs">
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
    /// Provides options that control how a presentation is saved in TIFF format.
    /// </summary>  
    public class TiffExportOptions : ImageExportOptionsBase 
    {                       
        /// <summary>
        /// Compression type.
        /// </summary>
        /// <value>Compression type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            Default,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum CCITT3 for "CCITT3"
            /// </summary>
            CCITT3,
            
            /// <summary>
            /// Enum CCITT4 for "CCITT4"
            /// </summary>
            CCITT4,
            
            /// <summary>
            /// Enum LZW for "LZW"
            /// </summary>
            LZW,
            
            /// <summary>
            /// Enum RLE for "RLE"
            /// </summary>
            RLE
        }

        /// <summary>
        /// Specifies the pixel format for the generated images. Read/write ImagePixelFormat.
        /// </summary>
        /// <value>Specifies the pixel format for the generated images. Read/write ImagePixelFormat.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PixelFormatEnum
        {
            
            /// <summary>
            /// Enum Format1bppIndexed for "Format1bppIndexed"
            /// </summary>
            Format1bppIndexed,
            
            /// <summary>
            /// Enum Format4bppIndexed for "Format4bppIndexed"
            /// </summary>
            Format4bppIndexed,
            
            /// <summary>
            /// Enum Format8bppIndexed for "Format8bppIndexed"
            /// </summary>
            Format8bppIndexed,
            
            /// <summary>
            /// Enum Format24bppRgb for "Format24bppRgb"
            /// </summary>
            Format24bppRgb,
            
            /// <summary>
            /// Enum Format32bppArgb for "Format32bppArgb"
            /// </summary>
            Format32bppArgb
        }

        /// <summary>
        /// Specifies the algorithm for converting a color image into a black and white image. This option will applied only if Aspose.Slides.Export.TiffOptions.CompressionType is set to Aspose.Slides.Export.TiffCompressionTypes.CCITT4 or Aspose.Slides.Export.TiffCompressionTypes.CCITT3.
        /// </summary>
        /// <value>Specifies the algorithm for converting a color image into a black and white image. This option will applied only if Aspose.Slides.Export.TiffOptions.CompressionType is set to Aspose.Slides.Export.TiffCompressionTypes.CCITT4 or Aspose.Slides.Export.TiffCompressionTypes.CCITT3.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BwConversionModeEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            Default,
            
            /// <summary>
            /// Enum Dithering for "Dithering"
            /// </summary>
            Dithering,
            
            /// <summary>
            /// Enum DitheringFloydSteinberg for "DitheringFloydSteinberg"
            /// </summary>
            DitheringFloydSteinberg,
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>
            Auto,
            
            /// <summary>
            /// Enum AutoOtsu for "AutoOtsu"
            /// </summary>
            AutoOtsu,
            
            /// <summary>
            /// Enum Threshold25 for "Threshold25"
            /// </summary>
            Threshold25,
            
            /// <summary>
            /// Enum Threshold50 for "Threshold50"
            /// </summary>
            Threshold50,
            
            /// <summary>
            /// Enum Threshold75 for "Threshold75"
            /// </summary>
            Threshold75
        }

        /// <summary>
        /// Compression type.
        /// </summary>
        public CompressionEnum? Compression { get; set; }

        /// <summary>
        /// Specifies the pixel format for the generated images. Read/write ImagePixelFormat.
        /// </summary>
        public PixelFormatEnum? PixelFormat { get; set; }

        /// <summary>
        /// Specifies the algorithm for converting a color image into a black and white image. This option will applied only if Aspose.Slides.Export.TiffOptions.CompressionType is set to Aspose.Slides.Export.TiffCompressionTypes.CCITT4 or Aspose.Slides.Export.TiffCompressionTypes.CCITT3.
        /// </summary>
        public BwConversionModeEnum? BwConversionMode { get; set; }

        /// <summary>
        /// Horizontal resolution, in dots per inch.
        /// </summary>
        public int? DpiX { get; set; }

        /// <summary>
        /// Vertical resolution, in dots per inch.
        /// </summary>
        public int? DpiY { get; set; }

        /// <summary>
        /// Specifies whether the generated document should include hidden slides or not. Default is false. 
        /// </summary>
        public bool? ShowHiddenSlides { get; set; }

        /// <summary>
        /// Slides layouting options
        /// </summary>
        public SlidesLayoutOptions SlidesLayoutOptions { get; set; }


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
                    s_typeDeterminers.Add("Format", "tiff");
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public TiffExportOptions() : base()
        {
            Format = "tiff";
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TiffExportOptions {\n");
            sb.Append("  DefaultRegularFont: ").Append(this.DefaultRegularFont).Append("\n");
            sb.Append("  DeleteEmbeddedBinaryObjects: ").Append(this.DeleteEmbeddedBinaryObjects).Append("\n");
            sb.Append("  GradientStyle: ").Append(this.GradientStyle).Append("\n");
            sb.Append("  FontFallbackRules: ").Append(this.FontFallbackRules).Append("\n");
            sb.Append("  FontSubstRules: ").Append(this.FontSubstRules).Append("\n");
            sb.Append("  SkipJavaScriptLinks: ").Append(this.SkipJavaScriptLinks).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Compression: ").Append(this.Compression).Append("\n");
            sb.Append("  DpiX: ").Append(this.DpiX).Append("\n");
            sb.Append("  DpiY: ").Append(this.DpiY).Append("\n");
            sb.Append("  ShowHiddenSlides: ").Append(this.ShowHiddenSlides).Append("\n");
            sb.Append("  PixelFormat: ").Append(this.PixelFormat).Append("\n");
            sb.Append("  SlidesLayoutOptions: ").Append(this.SlidesLayoutOptions).Append("\n");
            sb.Append("  BwConversionMode: ").Append(this.BwConversionMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
