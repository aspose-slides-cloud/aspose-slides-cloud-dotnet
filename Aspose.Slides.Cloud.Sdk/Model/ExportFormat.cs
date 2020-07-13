// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExportFormat.cs">
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
    /// Available export formats
    /// </summary>
    /// <value>Available export formats</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportFormat
    {
        
        /// <summary>
        /// Enum Pdf for "Pdf"
        /// </summary>
        Pdf,
        
        /// <summary>
        /// Enum Xps for "Xps"
        /// </summary>
        Xps,
        
        /// <summary>
        /// Enum Tiff for "Tiff"
        /// </summary>
        Tiff,
        
        /// <summary>
        /// Enum Pptx for "Pptx"
        /// </summary>
        Pptx,
        
        /// <summary>
        /// Enum Odp for "Odp"
        /// </summary>
        Odp,
        
        /// <summary>
        /// Enum Otp for "Otp"
        /// </summary>
        Otp,
        
        /// <summary>
        /// Enum Ppt for "Ppt"
        /// </summary>
        Ppt,
        
        /// <summary>
        /// Enum Pps for "Pps"
        /// </summary>
        Pps,
        
        /// <summary>
        /// Enum Ppsx for "Ppsx"
        /// </summary>
        Ppsx,
        
        /// <summary>
        /// Enum Pptm for "Pptm"
        /// </summary>
        Pptm,
        
        /// <summary>
        /// Enum Ppsm for "Ppsm"
        /// </summary>
        Ppsm,
        
        /// <summary>
        /// Enum Pot for "Pot"
        /// </summary>
        Pot,
        
        /// <summary>
        /// Enum Potx for "Potx"
        /// </summary>
        Potx,
        
        /// <summary>
        /// Enum Potm for "Potm"
        /// </summary>
        Potm,
        
        /// <summary>
        /// Enum Html for "Html"
        /// </summary>
        Html,
        
        /// <summary>
        /// Enum Swf for "Swf"
        /// </summary>
        Swf,
        
        /// <summary>
        /// Enum Svg for "Svg"
        /// </summary>
        Svg,
        
        /// <summary>
        /// Enum Jpeg for "Jpeg"
        /// </summary>
        Jpeg,
        
        /// <summary>
        /// Enum Png for "Png"
        /// </summary>
        Png,
        
        /// <summary>
        /// Enum Gif for "Gif"
        /// </summary>
        Gif,
        
        /// <summary>
        /// Enum Bmp for "Bmp"
        /// </summary>
        Bmp,
        
        /// <summary>
        /// Enum Fodp for "Fodp"
        /// </summary>
        Fodp
    }

}
