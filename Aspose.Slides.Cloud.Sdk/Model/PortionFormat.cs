// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PortionFormat.cs">
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
    /// Represents portion format.
    /// </summary>  
    public class PortionFormat 
    {                       
        /// <summary>
        /// True for bold font.
        /// </summary>
        /// <value>True for bold font.</value>
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
        /// True for italic font.
        /// </summary>
        /// <value>True for italic font.</value>
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
        /// Text underline type.
        /// </summary>
        /// <value>Text underline type.</value>
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
        /// Text strikethrough type.
        /// </summary>
        /// <value>Text strikethrough type.</value>
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
        /// Text capitalization type.
        /// </summary>
        /// <value>Text capitalization type.</value>
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
        /// True to normalize the text.
        /// </summary>
        /// <value>True to normalize the text.</value>
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
        /// True if the text proof should be disabled.
        /// </summary>
        /// <value>True if the text proof should be disabled.</value>
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
        /// True if numbers should ignore East-Asian specific vertical text layout.
        /// </summary>
        /// <value>True if numbers should ignore East-Asian specific vertical text layout.</value>
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
        /// True if underline style has own FillFormat properties.
        /// </summary>
        /// <value>True if underline style has own FillFormat properties.</value>
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
        /// True if underline style has own LineFormat properties.
        /// </summary>
        /// <value>True if underline style has own LineFormat properties.</value>
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
        /// True for bold font.
        /// </summary>
        public FontBoldEnum? FontBold { get; set; }

        /// <summary>
        /// True for italic font.
        /// </summary>
        public FontItalicEnum? FontItalic { get; set; }

        /// <summary>
        /// Text underline type.
        /// </summary>
        public FontUnderlineEnum? FontUnderline { get; set; }

        /// <summary>
        /// Text strikethrough type.
        /// </summary>
        public StrikethroughTypeEnum? StrikethroughType { get; set; }

        /// <summary>
        /// Text capitalization type.
        /// </summary>
        public TextCapTypeEnum? TextCapType { get; set; }

        /// <summary>
        /// True to normalize the text.
        /// </summary>
        public NormaliseHeightEnum? NormaliseHeight { get; set; }

        /// <summary>
        /// True if the text proof should be disabled.
        /// </summary>
        public ProofDisabledEnum? ProofDisabled { get; set; }

        /// <summary>
        /// True if numbers should ignore East-Asian specific vertical text layout.
        /// </summary>
        public KumimojiEnum? Kumimoji { get; set; }

        /// <summary>
        /// True if underline style has own FillFormat properties.
        /// </summary>
        public IsHardUnderlineFillEnum? IsHardUnderlineFill { get; set; }

        /// <summary>
        /// True if underline style has own LineFormat properties.
        /// </summary>
        public IsHardUnderlineLineEnum? IsHardUnderlineLine { get; set; }

        /// <summary>
        /// Superscript or subscript of the text.
        /// </summary>
        public double? Escapement { get; set; }

        /// <summary>
        /// Intercharacter spacing increment.
        /// </summary>
        public double? Spacing { get; set; }

        /// <summary>
        /// Font color.
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Highlight color.
        /// </summary>
        public string HighlightColor { get; set; }

        /// <summary>
        /// Font height.
        /// </summary>
        public double? FontHeight { get; set; }

        /// <summary>
        /// True if smart tag should be cleaned.
        /// </summary>
        public bool? SmartTagClean { get; set; }

        /// <summary>
        /// Minimal font size for kerning.
        /// </summary>
        public double? KerningMinimalSize { get; set; }

        /// <summary>
        /// Proving language ID.
        /// </summary>
        public string LanguageId { get; set; }

        /// <summary>
        /// Alternative proving language ID.
        /// </summary>
        public string AlternativeLanguageId { get; set; }

        /// <summary>
        /// Fill format.
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Effect format.
        /// </summary>
        public EffectFormat EffectFormat { get; set; }

        /// <summary>
        /// Line format.
        /// </summary>
        public LineFormat LineFormat { get; set; }

        /// <summary>
        /// Underline fill format.
        /// </summary>
        public FillFormat UnderlineFillFormat { get; set; }

        /// <summary>
        /// Underline line format.
        /// </summary>
        public LineFormat UnderlineLineFormat { get; set; }

        /// <summary>
        /// Hyperlink defined for mouse click.
        /// </summary>
        public Hyperlink HyperlinkClick { get; set; }

        /// <summary>
        /// Hyperlink defined for mouse over.
        /// </summary>
        public Hyperlink HyperlinkMouseOver { get; set; }

        /// <summary>
        /// Returns or sets the Latin font info.
        /// </summary>
        public string LatinFont { get; set; }

        /// <summary>
        /// Returns or sets the East Asian font info.
        /// </summary>
        public string EastAsianFont { get; set; }

        /// <summary>
        /// Returns or sets the complex script font info.
        /// </summary>
        public string ComplexScriptFont { get; set; }


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
        public PortionFormat() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class PortionFormat {\n");
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
            sb.Append("  HyperlinkClick: ").Append(this.HyperlinkClick).Append("\n");
            sb.Append("  HyperlinkMouseOver: ").Append(this.HyperlinkMouseOver).Append("\n");
            sb.Append("  LatinFont: ").Append(this.LatinFont).Append("\n");
            sb.Append("  EastAsianFont: ").Append(this.EastAsianFont).Append("\n");
            sb.Append("  ComplexScriptFont: ").Append(this.ComplexScriptFont).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
