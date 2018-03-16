// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NumberedBulletStyle.cs">
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
    /// 
    /// </summary>
    /// <value></value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NumberedBulletStyle
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

}
