// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageExportFormat.cs">
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
    /// Represents a format for image export.
    /// </summary>
    /// <value>Represents a format for image export.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageExportFormat
    {
        
        /// <summary>
        /// Enum Jpeg for 0
        /// </summary>
        Jpeg,
        
        /// <summary>
        /// Enum Png for 1
        /// </summary>
        Png,
        
        /// <summary>
        /// Enum Gif for 2
        /// </summary>
        Gif,
        
        /// <summary>
        /// Enum Bmp for 3
        /// </summary>
        Bmp,
        
        /// <summary>
        /// Enum Tiff for 4
        /// </summary>
        Tiff
    }

}
