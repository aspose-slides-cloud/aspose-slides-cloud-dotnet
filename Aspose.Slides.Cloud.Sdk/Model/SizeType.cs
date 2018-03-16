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
    /// 
    /// </summary>
    /// <value></value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SizeType
    {
        
        /// <summary>
        /// Enum OnScreen for 0
        /// </summary>
        OnScreen,
        
        /// <summary>
        /// Enum LetterPaper for 1
        /// </summary>
        LetterPaper,
        
        /// <summary>
        /// Enum A4Paper for 2
        /// </summary>
        A4Paper,
        
        /// <summary>
        /// Enum Slide35mm for 3
        /// </summary>
        Slide35mm,
        
        /// <summary>
        /// Enum Overhead for 4
        /// </summary>
        Overhead,
        
        /// <summary>
        /// Enum Banner for 5
        /// </summary>
        Banner,
        
        /// <summary>
        /// Enum Custom for 6
        /// </summary>
        Custom,
        
        /// <summary>
        /// Enum Ledger for 7
        /// </summary>
        Ledger,
        
        /// <summary>
        /// Enum A3Paper for 8
        /// </summary>
        A3Paper,
        
        /// <summary>
        /// Enum B4IsoPaper for 9
        /// </summary>
        B4IsoPaper,
        
        /// <summary>
        /// Enum B5IsoPaper for 10
        /// </summary>
        B5IsoPaper,
        
        /// <summary>
        /// Enum B4JisPaper for 11
        /// </summary>
        B4JisPaper,
        
        /// <summary>
        /// Enum B5JisPaper for 12
        /// </summary>
        B5JisPaper,
        
        /// <summary>
        /// Enum HagakiCard for 13
        /// </summary>
        HagakiCard,
        
        /// <summary>
        /// Enum OnScreen16x9 for 14
        /// </summary>
        OnScreen16x9,
        
        /// <summary>
        /// Enum OnScreen16x10 for 15
        /// </summary>
        OnScreen16x10
    }

}
