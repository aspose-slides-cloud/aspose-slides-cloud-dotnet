// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Portion.cs">
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
  /// Represents portion resource
  /// </summary>  
  public class Portion : ResourceBase 
  {                       
        /// <summary>
        /// Gets or Sets FontBold
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontBoldEnum
        {
            
            /// <summary>
            /// Enum False for "False"
            /// </summary>
            False,
            
            /// <summary>
            /// Enum True for "True"
            /// </summary>
            True,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or Sets FontItalic
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontItalicEnum
        {
            
            /// <summary>
            /// Enum False for "False"
            /// </summary>
            False,
            
            /// <summary>
            /// Enum True for "True"
            /// </summary>
            True,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or Sets FontUnderline
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontUnderlineEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Words for "Words"
            /// </summary>
            Words,
            
            /// <summary>
            /// Enum Single for "Single"
            /// </summary>
            Single,
            
            /// <summary>
            /// Enum Double for "Double"
            /// </summary>
            Double,
            
            /// <summary>
            /// Enum Heavy for "Heavy"
            /// </summary>
            Heavy,
            
            /// <summary>
            /// Enum Dotted for "Dotted"
            /// </summary>
            Dotted,
            
            /// <summary>
            /// Enum HeavyDotted for "HeavyDotted"
            /// </summary>
            HeavyDotted,
            
            /// <summary>
            /// Enum Dashed for "Dashed"
            /// </summary>
            Dashed,
            
            /// <summary>
            /// Enum HeavyDashed for "HeavyDashed"
            /// </summary>
            HeavyDashed,
            
            /// <summary>
            /// Enum LongDashed for "LongDashed"
            /// </summary>
            LongDashed,
            
            /// <summary>
            /// Enum HeavyLongDashed for "HeavyLongDashed"
            /// </summary>
            HeavyLongDashed,
            
            /// <summary>
            /// Enum DotDash for "DotDash"
            /// </summary>
            DotDash,
            
            /// <summary>
            /// Enum HeavyDotDash for "HeavyDotDash"
            /// </summary>
            HeavyDotDash,
            
            /// <summary>
            /// Enum DotDotDash for "DotDotDash"
            /// </summary>
            DotDotDash,
            
            /// <summary>
            /// Enum HeavyDotDotDash for "HeavyDotDotDash"
            /// </summary>
            HeavyDotDotDash,
            
            /// <summary>
            /// Enum Wavy for "Wavy"
            /// </summary>
            Wavy,
            
            /// <summary>
            /// Enum HeavyWavy for "HeavyWavy"
            /// </summary>
            HeavyWavy,
            
            /// <summary>
            /// Enum DoubleWavy for "DoubleWavy"
            /// </summary>
            DoubleWavy,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or Sets StrikethroughType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StrikethroughTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Single for "Single"
            /// </summary>
            Single,
            
            /// <summary>
            /// Enum Double for "Double"
            /// </summary>
            Double,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or Sets TextCapType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextCapTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Small for "Small"
            /// </summary>
            Small,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            All,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or Sets NormaliseHeight
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NormaliseHeightEnum
        {
            
            /// <summary>
            /// Enum False for "False"
            /// </summary>
            False,
            
            /// <summary>
            /// Enum True for "True"
            /// </summary>
            True,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or Sets ProofDisabled
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProofDisabledEnum
        {
            
            /// <summary>
            /// Enum False for "False"
            /// </summary>
            False,
            
            /// <summary>
            /// Enum True for "True"
            /// </summary>
            True,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or Sets Kumimoji
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KumimojiEnum
        {
            
            /// <summary>
            /// Enum False for "False"
            /// </summary>
            False,
            
            /// <summary>
            /// Enum True for "True"
            /// </summary>
            True,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or Sets IsHardUnderlineFill
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IsHardUnderlineFillEnum
        {
            
            /// <summary>
            /// Enum False for "False"
            /// </summary>
            False,
            
            /// <summary>
            /// Enum True for "True"
            /// </summary>
            True,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or Sets IsHardUnderlineLine
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IsHardUnderlineLineEnum
        {
            
            /// <summary>
            /// Enum False for "False"
            /// </summary>
            False,
            
            /// <summary>
            /// Enum True for "True"
            /// </summary>
            True,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or sets FontBold
        /// </summary>
        public FontBoldEnum? FontBold { get; set; }

        /// <summary>
        /// Gets or sets FontItalic
        /// </summary>
        public FontItalicEnum? FontItalic { get; set; }

        /// <summary>
        /// Gets or sets FontUnderline
        /// </summary>
        public FontUnderlineEnum? FontUnderline { get; set; }

        /// <summary>
        /// Gets or sets StrikethroughType
        /// </summary>
        public StrikethroughTypeEnum? StrikethroughType { get; set; }

        /// <summary>
        /// Gets or sets TextCapType
        /// </summary>
        public TextCapTypeEnum? TextCapType { get; set; }

        /// <summary>
        /// Gets or sets NormaliseHeight
        /// </summary>
        public NormaliseHeightEnum? NormaliseHeight { get; set; }

        /// <summary>
        /// Gets or sets ProofDisabled
        /// </summary>
        public ProofDisabledEnum? ProofDisabled { get; set; }

        /// <summary>
        /// Gets or sets Kumimoji
        /// </summary>
        public KumimojiEnum? Kumimoji { get; set; }

        /// <summary>
        /// Gets or sets IsHardUnderlineFill
        /// </summary>
        public IsHardUnderlineFillEnum? IsHardUnderlineFill { get; set; }

        /// <summary>
        /// Gets or sets IsHardUnderlineLine
        /// </summary>
        public IsHardUnderlineLineEnum? IsHardUnderlineLine { get; set; }

        /// <summary>
        /// Gets or sets Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets Escapement
        /// </summary>
        public double? Escapement { get; set; }

        /// <summary>
        /// Gets or sets Spacing
        /// </summary>
        public double? Spacing { get; set; }

        /// <summary>
        /// Gets or sets FontColor
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Gets or sets HighlightColor
        /// </summary>
        public string HighlightColor { get; set; }

        /// <summary>
        /// Gets or sets FontHeight
        /// </summary>
        public double? FontHeight { get; set; }

        /// <summary>
        /// Gets or sets SmartTagClean
        /// </summary>
        public bool? SmartTagClean { get; set; }

        /// <summary>
        /// Gets or sets KerningMinimalSize
        /// </summary>
        public double? KerningMinimalSize { get; set; }

        /// <summary>
        /// Gets or sets LanguageId
        /// </summary>
        public string LanguageId { get; set; }

        /// <summary>
        /// Gets or sets AlternativeLanguageId
        /// </summary>
        public string AlternativeLanguageId { get; set; }

        /// <summary>
        /// Gets or sets FillFormat
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Gets or sets EffectFormat
        /// </summary>
        public EffectFormat EffectFormat { get; set; }

        /// <summary>
        /// Gets or sets LineFormat
        /// </summary>
        public LineFormat LineFormat { get; set; }

        /// <summary>
        /// Gets or sets UnderlineFillFormat
        /// </summary>
        public FillFormat UnderlineFillFormat { get; set; }

        /// <summary>
        /// Gets or sets UnderlineLineFormat
        /// </summary>
        public LineFormat UnderlineLineFormat { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public Portion() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Portion {\n");
          sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
          sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  FontBold: ").Append(this.FontBold).Append("\n");
          sb.Append("  FontItalic: ").Append(this.FontItalic).Append("\n");
          sb.Append("  FontUnderline: ").Append(this.FontUnderline).Append("\n");
          sb.Append("  StrikethroughType: ").Append(this.StrikethroughType).Append("\n");
          sb.Append("  TextCapType: ").Append(this.TextCapType).Append("\n");
          sb.Append("  Escapement: ").Append(this.Escapement).Append("\n");
          sb.Append("  Spacing: ").Append(this.Spacing).Append("\n");
          sb.Append("  FontColor: ").Append(this.FontColor).Append("\n");
          sb.Append("  HighlightColor: ").Append(this.HighlightColor).Append("\n");
          sb.Append("  FontHeight: ").Append(this.FontHeight).Append("\n");
          sb.Append("  NormaliseHeight: ").Append(this.NormaliseHeight).Append("\n");
          sb.Append("  ProofDisabled: ").Append(this.ProofDisabled).Append("\n");
          sb.Append("  SmartTagClean: ").Append(this.SmartTagClean).Append("\n");
          sb.Append("  KerningMinimalSize: ").Append(this.KerningMinimalSize).Append("\n");
          sb.Append("  Kumimoji: ").Append(this.Kumimoji).Append("\n");
          sb.Append("  LanguageId: ").Append(this.LanguageId).Append("\n");
          sb.Append("  AlternativeLanguageId: ").Append(this.AlternativeLanguageId).Append("\n");
          sb.Append("  IsHardUnderlineFill: ").Append(this.IsHardUnderlineFill).Append("\n");
          sb.Append("  IsHardUnderlineLine: ").Append(this.IsHardUnderlineLine).Append("\n");
          sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
          sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
          sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
          sb.Append("  UnderlineFillFormat: ").Append(this.UnderlineFillFormat).Append("\n");
          sb.Append("  UnderlineLineFormat: ").Append(this.UnderlineLineFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
