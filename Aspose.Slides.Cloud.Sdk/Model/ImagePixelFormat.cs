// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagePixelFormat.cs">
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
    /// Specifies the pixel format for the generated images.
    /// </summary>
    /// <value>Specifies the pixel format for the generated images.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImagePixelFormat
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

}
