// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Paragraph.cs">
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
    /// Represents paragraph resource
    /// </summary>  
    public class Paragraph : ResourceBase 
    {                       
        /// <summary>
        /// Text alignment.
        /// </summary>
        /// <value>Text alignment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlignmentEnum
        {
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            Left,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            Center,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            Right,
            
            /// <summary>
            /// Enum Justify for "Justify"
            /// </summary>
            Justify,
            
            /// <summary>
            /// Enum JustifyLow for "JustifyLow"
            /// </summary>
            JustifyLow,
            
            /// <summary>
            /// Enum Distributed for "Distributed"
            /// </summary>
            Distributed,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Font alignment.
        /// </summary>
        /// <value>Font alignment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FontAlignmentEnum
        {
            
            /// <summary>
            /// Enum Automatic for "Automatic"
            /// </summary>
            Automatic,
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            Center,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>
            Bottom,
            
            /// <summary>
            /// Enum Baseline for "Baseline"
            /// </summary>
            Baseline,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            Default
        }

        /// <summary>
        /// Bullet type.
        /// </summary>
        /// <value>Bullet type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BulletTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Symbol for "Symbol"
            /// </summary>
            Symbol,
            
            /// <summary>
            /// Enum Numbered for "Numbered"
            /// </summary>
            Numbered,
            
            /// <summary>
            /// Enum Picture for "Picture"
            /// </summary>
            Picture,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Numbered bullet style.
        /// </summary>
        /// <value>Numbered bullet style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NumberedBulletStyleEnum
        {
            
            /// <summary>
            /// Enum BulletAlphaLCPeriod for "BulletAlphaLCPeriod"
            /// </summary>
            BulletAlphaLCPeriod,
            
            /// <summary>
            /// Enum BulletAlphaUCPeriod for "BulletAlphaUCPeriod"
            /// </summary>
            BulletAlphaUCPeriod,
            
            /// <summary>
            /// Enum BulletArabicParenRight for "BulletArabicParenRight"
            /// </summary>
            BulletArabicParenRight,
            
            /// <summary>
            /// Enum BulletArabicPeriod for "BulletArabicPeriod"
            /// </summary>
            BulletArabicPeriod,
            
            /// <summary>
            /// Enum BulletRomanLCParenBoth for "BulletRomanLCParenBoth"
            /// </summary>
            BulletRomanLCParenBoth,
            
            /// <summary>
            /// Enum BulletRomanLCParenRight for "BulletRomanLCParenRight"
            /// </summary>
            BulletRomanLCParenRight,
            
            /// <summary>
            /// Enum BulletRomanLCPeriod for "BulletRomanLCPeriod"
            /// </summary>
            BulletRomanLCPeriod,
            
            /// <summary>
            /// Enum BulletRomanUCPeriod for "BulletRomanUCPeriod"
            /// </summary>
            BulletRomanUCPeriod,
            
            /// <summary>
            /// Enum BulletAlphaLCParenBoth for "BulletAlphaLCParenBoth"
            /// </summary>
            BulletAlphaLCParenBoth,
            
            /// <summary>
            /// Enum BulletAlphaLCParenRight for "BulletAlphaLCParenRight"
            /// </summary>
            BulletAlphaLCParenRight,
            
            /// <summary>
            /// Enum BulletAlphaUCParenBoth for "BulletAlphaUCParenBoth"
            /// </summary>
            BulletAlphaUCParenBoth,
            
            /// <summary>
            /// Enum BulletAlphaUCParenRight for "BulletAlphaUCParenRight"
            /// </summary>
            BulletAlphaUCParenRight,
            
            /// <summary>
            /// Enum BulletArabicParenBoth for "BulletArabicParenBoth"
            /// </summary>
            BulletArabicParenBoth,
            
            /// <summary>
            /// Enum BulletArabicPlain for "BulletArabicPlain"
            /// </summary>
            BulletArabicPlain,
            
            /// <summary>
            /// Enum BulletRomanUCParenBoth for "BulletRomanUCParenBoth"
            /// </summary>
            BulletRomanUCParenBoth,
            
            /// <summary>
            /// Enum BulletRomanUCParenRight for "BulletRomanUCParenRight"
            /// </summary>
            BulletRomanUCParenRight,
            
            /// <summary>
            /// Enum BulletSimpChinPlain for "BulletSimpChinPlain"
            /// </summary>
            BulletSimpChinPlain,
            
            /// <summary>
            /// Enum BulletSimpChinPeriod for "BulletSimpChinPeriod"
            /// </summary>
            BulletSimpChinPeriod,
            
            /// <summary>
            /// Enum BulletCircleNumDBPlain for "BulletCircleNumDBPlain"
            /// </summary>
            BulletCircleNumDBPlain,
            
            /// <summary>
            /// Enum BulletCircleNumWDWhitePlain for "BulletCircleNumWDWhitePlain"
            /// </summary>
            BulletCircleNumWDWhitePlain,
            
            /// <summary>
            /// Enum BulletCircleNumWDBlackPlain for "BulletCircleNumWDBlackPlain"
            /// </summary>
            BulletCircleNumWDBlackPlain,
            
            /// <summary>
            /// Enum BulletTradChinPlain for "BulletTradChinPlain"
            /// </summary>
            BulletTradChinPlain,
            
            /// <summary>
            /// Enum BulletTradChinPeriod for "BulletTradChinPeriod"
            /// </summary>
            BulletTradChinPeriod,
            
            /// <summary>
            /// Enum BulletArabicAlphaDash for "BulletArabicAlphaDash"
            /// </summary>
            BulletArabicAlphaDash,
            
            /// <summary>
            /// Enum BulletArabicAbjadDash for "BulletArabicAbjadDash"
            /// </summary>
            BulletArabicAbjadDash,
            
            /// <summary>
            /// Enum BulletHebrewAlphaDash for "BulletHebrewAlphaDash"
            /// </summary>
            BulletHebrewAlphaDash,
            
            /// <summary>
            /// Enum BulletKanjiKoreanPlain for "BulletKanjiKoreanPlain"
            /// </summary>
            BulletKanjiKoreanPlain,
            
            /// <summary>
            /// Enum BulletKanjiKoreanPeriod for "BulletKanjiKoreanPeriod"
            /// </summary>
            BulletKanjiKoreanPeriod,
            
            /// <summary>
            /// Enum BulletArabicDBPlain for "BulletArabicDBPlain"
            /// </summary>
            BulletArabicDBPlain,
            
            /// <summary>
            /// Enum BulletArabicDBPeriod for "BulletArabicDBPeriod"
            /// </summary>
            BulletArabicDBPeriod,
            
            /// <summary>
            /// Enum BulletThaiAlphaPeriod for "BulletThaiAlphaPeriod"
            /// </summary>
            BulletThaiAlphaPeriod,
            
            /// <summary>
            /// Enum BulletThaiAlphaParenRight for "BulletThaiAlphaParenRight"
            /// </summary>
            BulletThaiAlphaParenRight,
            
            /// <summary>
            /// Enum BulletThaiAlphaParenBoth for "BulletThaiAlphaParenBoth"
            /// </summary>
            BulletThaiAlphaParenBoth,
            
            /// <summary>
            /// Enum BulletThaiNumPeriod for "BulletThaiNumPeriod"
            /// </summary>
            BulletThaiNumPeriod,
            
            /// <summary>
            /// Enum BulletThaiNumParenRight for "BulletThaiNumParenRight"
            /// </summary>
            BulletThaiNumParenRight,
            
            /// <summary>
            /// Enum BulletThaiNumParenBoth for "BulletThaiNumParenBoth"
            /// </summary>
            BulletThaiNumParenBoth,
            
            /// <summary>
            /// Enum BulletHindiAlphaPeriod for "BulletHindiAlphaPeriod"
            /// </summary>
            BulletHindiAlphaPeriod,
            
            /// <summary>
            /// Enum BulletHindiNumPeriod for "BulletHindiNumPeriod"
            /// </summary>
            BulletHindiNumPeriod,
            
            /// <summary>
            /// Enum BulletKanjiSimpChinDBPeriod for "BulletKanjiSimpChinDBPeriod"
            /// </summary>
            BulletKanjiSimpChinDBPeriod,
            
            /// <summary>
            /// Enum BulletHindiNumParenRight for "BulletHindiNumParenRight"
            /// </summary>
            BulletHindiNumParenRight,
            
            /// <summary>
            /// Enum BulletHindiAlpha1Period for "BulletHindiAlpha1Period"
            /// </summary>
            BulletHindiAlpha1Period,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// True if hanging punctuation is used with the paragraph.
        /// </summary>
        /// <value>True if hanging punctuation is used with the paragraph.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HangingPunctuationEnum
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
        /// True if East Asian line break is used with the paragraph.
        /// </summary>
        /// <value>True if East Asian line break is used with the paragraph.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EastAsianLineBreakEnum
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
        /// True if Latin line break is used with the paragraph.
        /// </summary>
        /// <value>True if Latin line break is used with the paragraph.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LatinLineBreakEnum
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
        /// True if right to left direction is used with the paragraph.
        /// </summary>
        /// <value>True if right to left direction is used with the paragraph.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RightToLeftEnum
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
        /// Text alignment.
        /// </summary>
        public AlignmentEnum? Alignment { get; set; }

        /// <summary>
        /// Font alignment.
        /// </summary>
        public FontAlignmentEnum? FontAlignment { get; set; }

        /// <summary>
        /// Bullet type.
        /// </summary>
        public BulletTypeEnum? BulletType { get; set; }

        /// <summary>
        /// Numbered bullet style.
        /// </summary>
        public NumberedBulletStyleEnum? NumberedBulletStyle { get; set; }

        /// <summary>
        /// True if hanging punctuation is used with the paragraph.
        /// </summary>
        public HangingPunctuationEnum? HangingPunctuation { get; set; }

        /// <summary>
        /// True if East Asian line break is used with the paragraph.
        /// </summary>
        public EastAsianLineBreakEnum? EastAsianLineBreak { get; set; }

        /// <summary>
        /// True if Latin line break is used with the paragraph.
        /// </summary>
        public LatinLineBreakEnum? LatinLineBreak { get; set; }

        /// <summary>
        /// True if right to left direction is used with the paragraph.
        /// </summary>
        public RightToLeftEnum? RightToLeft { get; set; }

        /// <summary>
        /// Left margin.
        /// </summary>
        public double? MarginLeft { get; set; }

        /// <summary>
        /// Right margin.
        /// </summary>
        public double? MarginRight { get; set; }

        /// <summary>
        /// Left spacing.
        /// </summary>
        public double? SpaceBefore { get; set; }

        /// <summary>
        /// Right spacing.
        /// </summary>
        public double? SpaceAfter { get; set; }

        /// <summary>
        /// Spacing between lines.
        /// </summary>
        public double? SpaceWithin { get; set; }

        /// <summary>
        /// First line indent.
        /// </summary>
        public double? Indent { get; set; }

        /// <summary>
        /// Default tabulation size.
        /// </summary>
        public double? DefaultTabSize { get; set; }

        /// <summary>
        /// Depth.
        /// </summary>
        public int? Depth { get; set; }

        /// <summary>
        /// Bullet char.
        /// </summary>
        public string BulletChar { get; set; }

        /// <summary>
        /// Bullet height.
        /// </summary>
        public double? BulletHeight { get; set; }

        /// <summary>
        /// Starting number for a numbered bullet.
        /// </summary>
        public int? NumberedBulletStartWith { get; set; }

        /// <summary>
        /// List of portion links.
        /// </summary>
        public List<Portion> PortionList { get; set; }

        /// <summary>
        /// Default portion format.
        /// </summary>
        public PortionFormat DefaultPortionFormat { get; set; }


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
        public Paragraph() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Paragraph {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  MarginLeft: ").Append(this.MarginLeft).Append("\n");
            sb.Append("  MarginRight: ").Append(this.MarginRight).Append("\n");
            sb.Append("  SpaceBefore: ").Append(this.SpaceBefore).Append("\n");
            sb.Append("  SpaceAfter: ").Append(this.SpaceAfter).Append("\n");
            sb.Append("  SpaceWithin: ").Append(this.SpaceWithin).Append("\n");
            sb.Append("  Indent: ").Append(this.Indent).Append("\n");
            sb.Append("  Alignment: ").Append(this.Alignment).Append("\n");
            sb.Append("  FontAlignment: ").Append(this.FontAlignment).Append("\n");
            sb.Append("  DefaultTabSize: ").Append(this.DefaultTabSize).Append("\n");
            sb.Append("  Depth: ").Append(this.Depth).Append("\n");
            sb.Append("  BulletChar: ").Append(this.BulletChar).Append("\n");
            sb.Append("  BulletHeight: ").Append(this.BulletHeight).Append("\n");
            sb.Append("  BulletType: ").Append(this.BulletType).Append("\n");
            sb.Append("  NumberedBulletStartWith: ").Append(this.NumberedBulletStartWith).Append("\n");
            sb.Append("  NumberedBulletStyle: ").Append(this.NumberedBulletStyle).Append("\n");
            sb.Append("  HangingPunctuation: ").Append(this.HangingPunctuation).Append("\n");
            sb.Append("  EastAsianLineBreak: ").Append(this.EastAsianLineBreak).Append("\n");
            sb.Append("  LatinLineBreak: ").Append(this.LatinLineBreak).Append("\n");
            sb.Append("  RightToLeft: ").Append(this.RightToLeft).Append("\n");
            sb.Append("  PortionList: ").Append(this.PortionList).Append("\n");
            sb.Append("  DefaultPortionFormat: ").Append(this.DefaultPortionFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
