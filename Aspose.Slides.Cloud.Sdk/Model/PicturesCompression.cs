// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PicturesCompression.cs">
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
    /// Represents the pictures compression level
    /// </summary>
    /// <value>Represents the pictures compression level</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PicturesCompression
    {
        
        /// <summary>
        /// Enum Dpi330 for "Dpi330"
        /// </summary>
        Dpi330,
        
        /// <summary>
        /// Enum Dpi220 for "Dpi220"
        /// </summary>
        Dpi220,
        
        /// <summary>
        /// Enum Dpi150 for "Dpi150"
        /// </summary>
        Dpi150,
        
        /// <summary>
        /// Enum Dpi96 for "Dpi96"
        /// </summary>
        Dpi96,
        
        /// <summary>
        /// Enum Dpi72 for "Dpi72"
        /// </summary>
        Dpi72,
        
        /// <summary>
        /// Enum DocumentResolution for "DocumentResolution"
        /// </summary>
        DocumentResolution
    }

}
