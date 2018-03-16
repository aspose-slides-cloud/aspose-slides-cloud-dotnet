// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SmartArtColorType.cs">
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
    /// Represents color scheme of a SmartArt diagram.
    /// </summary>
    /// <value>Represents color scheme of a SmartArt diagram.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmartArtColorType
    {
        
        /// <summary>
        /// Enum Dark1Outline for "Dark1Outline"
        /// </summary>
        Dark1Outline,
        
        /// <summary>
        /// Enum Dark2Outline for "Dark2Outline"
        /// </summary>
        Dark2Outline,
        
        /// <summary>
        /// Enum DarkFill for "DarkFill"
        /// </summary>
        DarkFill,
        
        /// <summary>
        /// Enum ColorfulAccentColors for "ColorfulAccentColors"
        /// </summary>
        ColorfulAccentColors,
        
        /// <summary>
        /// Enum ColorfulAccentColors2to3 for "ColorfulAccentColors2to3"
        /// </summary>
        ColorfulAccentColors2to3,
        
        /// <summary>
        /// Enum ColorfulAccentColors3to4 for "ColorfulAccentColors3to4"
        /// </summary>
        ColorfulAccentColors3to4,
        
        /// <summary>
        /// Enum ColorfulAccentColors4to5 for "ColorfulAccentColors4to5"
        /// </summary>
        ColorfulAccentColors4to5,
        
        /// <summary>
        /// Enum ColorfulAccentColors5to6 for "ColorfulAccentColors5to6"
        /// </summary>
        ColorfulAccentColors5to6,
        
        /// <summary>
        /// Enum ColoredOutlineAccent1 for "ColoredOutlineAccent1"
        /// </summary>
        ColoredOutlineAccent1,
        
        /// <summary>
        /// Enum ColoredFillAccent1 for "ColoredFillAccent1"
        /// </summary>
        ColoredFillAccent1,
        
        /// <summary>
        /// Enum GradientRangeAccent1 for "GradientRangeAccent1"
        /// </summary>
        GradientRangeAccent1,
        
        /// <summary>
        /// Enum GradientLoopAccent1 for "GradientLoopAccent1"
        /// </summary>
        GradientLoopAccent1,
        
        /// <summary>
        /// Enum TransparentGradientRangeAccent1 for "TransparentGradientRangeAccent1"
        /// </summary>
        TransparentGradientRangeAccent1,
        
        /// <summary>
        /// Enum ColoredOutlineAccent2 for "ColoredOutlineAccent2"
        /// </summary>
        ColoredOutlineAccent2,
        
        /// <summary>
        /// Enum ColoredFillAccent2 for "ColoredFillAccent2"
        /// </summary>
        ColoredFillAccent2,
        
        /// <summary>
        /// Enum GradientRangeAccent2 for "GradientRangeAccent2"
        /// </summary>
        GradientRangeAccent2,
        
        /// <summary>
        /// Enum GradientLoopAccent2 for "GradientLoopAccent2"
        /// </summary>
        GradientLoopAccent2,
        
        /// <summary>
        /// Enum TransparentGradientRangeAccent2 for "TransparentGradientRangeAccent2"
        /// </summary>
        TransparentGradientRangeAccent2,
        
        /// <summary>
        /// Enum ColoredOutlineAccent3 for "ColoredOutlineAccent3"
        /// </summary>
        ColoredOutlineAccent3,
        
        /// <summary>
        /// Enum ColoredFillAccent3 for "ColoredFillAccent3"
        /// </summary>
        ColoredFillAccent3,
        
        /// <summary>
        /// Enum GradientRangeAccent3 for "GradientRangeAccent3"
        /// </summary>
        GradientRangeAccent3,
        
        /// <summary>
        /// Enum GradientLoopAccent3 for "GradientLoopAccent3"
        /// </summary>
        GradientLoopAccent3,
        
        /// <summary>
        /// Enum TransparentGradientRangeAccent3 for "TransparentGradientRangeAccent3"
        /// </summary>
        TransparentGradientRangeAccent3,
        
        /// <summary>
        /// Enum ColoredOutlineAccent4 for "ColoredOutlineAccent4"
        /// </summary>
        ColoredOutlineAccent4,
        
        /// <summary>
        /// Enum ColoredFillAccent4 for "ColoredFillAccent4"
        /// </summary>
        ColoredFillAccent4,
        
        /// <summary>
        /// Enum GradientRangeAccent4 for "GradientRangeAccent4"
        /// </summary>
        GradientRangeAccent4,
        
        /// <summary>
        /// Enum GradientLoopAccent4 for "GradientLoopAccent4"
        /// </summary>
        GradientLoopAccent4,
        
        /// <summary>
        /// Enum TransparentGradientRangeAccent4 for "TransparentGradientRangeAccent4"
        /// </summary>
        TransparentGradientRangeAccent4,
        
        /// <summary>
        /// Enum ColoredOutlineAccent5 for "ColoredOutlineAccent5"
        /// </summary>
        ColoredOutlineAccent5,
        
        /// <summary>
        /// Enum ColoredFillAccent5 for "ColoredFillAccent5"
        /// </summary>
        ColoredFillAccent5,
        
        /// <summary>
        /// Enum GradientRangeAccent5 for "GradientRangeAccent5"
        /// </summary>
        GradientRangeAccent5,
        
        /// <summary>
        /// Enum GradientLoopAccent5 for "GradientLoopAccent5"
        /// </summary>
        GradientLoopAccent5,
        
        /// <summary>
        /// Enum TransparentGradientRangeAccent5 for "TransparentGradientRangeAccent5"
        /// </summary>
        TransparentGradientRangeAccent5,
        
        /// <summary>
        /// Enum ColoredOutlineAccent6 for "ColoredOutlineAccent6"
        /// </summary>
        ColoredOutlineAccent6,
        
        /// <summary>
        /// Enum ColoredFillAccent6 for "ColoredFillAccent6"
        /// </summary>
        ColoredFillAccent6,
        
        /// <summary>
        /// Enum GradientRangeAccent6 for "GradientRangeAccent6"
        /// </summary>
        GradientRangeAccent6,
        
        /// <summary>
        /// Enum GradientLoopAccent6 for "GradientLoopAccent6"
        /// </summary>
        GradientLoopAccent6,
        
        /// <summary>
        /// Enum TransparentGradientRangeAccent6 for "TransparentGradientRangeAccent6"
        /// </summary>
        TransparentGradientRangeAccent6
    }

}
