// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SizeType.cs">
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
    /// Slide size preset.
    /// </summary>
    /// <value>Slide size preset.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SizeType
    {
        
        /// <summary>
        /// Enum OnScreen for "OnScreen"
        /// </summary>
        OnScreen,
        
        /// <summary>
        /// Enum LetterPaper for "LetterPaper"
        /// </summary>
        LetterPaper,
        
        /// <summary>
        /// Enum A4Paper for "A4Paper"
        /// </summary>
        A4Paper,
        
        /// <summary>
        /// Enum Slide35mm for "Slide35mm"
        /// </summary>
        Slide35mm,
        
        /// <summary>
        /// Enum Overhead for "Overhead"
        /// </summary>
        Overhead,
        
        /// <summary>
        /// Enum Banner for "Banner"
        /// </summary>
        Banner,
        
        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        Custom,
        
        /// <summary>
        /// Enum Ledger for "Ledger"
        /// </summary>
        Ledger,
        
        /// <summary>
        /// Enum A3Paper for "A3Paper"
        /// </summary>
        A3Paper,
        
        /// <summary>
        /// Enum B4IsoPaper for "B4IsoPaper"
        /// </summary>
        B4IsoPaper,
        
        /// <summary>
        /// Enum B5IsoPaper for "B5IsoPaper"
        /// </summary>
        B5IsoPaper,
        
        /// <summary>
        /// Enum B4JisPaper for "B4JisPaper"
        /// </summary>
        B4JisPaper,
        
        /// <summary>
        /// Enum B5JisPaper for "B5JisPaper"
        /// </summary>
        B5JisPaper,
        
        /// <summary>
        /// Enum HagakiCard for "HagakiCard"
        /// </summary>
        HagakiCard,
        
        /// <summary>
        /// Enum OnScreen16x9 for "OnScreen16x9"
        /// </summary>
        OnScreen16x9,
        
        /// <summary>
        /// Enum OnScreen16x10 for "OnScreen16x10"
        /// </summary>
        OnScreen16x10
    }

}
