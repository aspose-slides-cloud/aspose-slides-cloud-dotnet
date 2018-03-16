// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextUnderlineType.cs">
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
    public enum TextUnderlineType
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

}
