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
        /// Enum Pdf for 0
        /// </summary>
        Pdf,
        
        /// <summary>
        /// Enum Xps for 1
        /// </summary>
        Xps,
        
        /// <summary>
        /// Enum Tiff for 2
        /// </summary>
        Tiff,
        
        /// <summary>
        /// Enum Pptx for 3
        /// </summary>
        Pptx,
        
        /// <summary>
        /// Enum Odp for 4
        /// </summary>
        Odp,
        
        /// <summary>
        /// Enum Otp for 5
        /// </summary>
        Otp,
        
        /// <summary>
        /// Enum Ppt for 6
        /// </summary>
        Ppt,
        
        /// <summary>
        /// Enum Pps for 7
        /// </summary>
        Pps,
        
        /// <summary>
        /// Enum Ppsx for 8
        /// </summary>
        Ppsx,
        
        /// <summary>
        /// Enum Pptm for 9
        /// </summary>
        Pptm,
        
        /// <summary>
        /// Enum Ppsm for 10
        /// </summary>
        Ppsm,
        
        /// <summary>
        /// Enum Potx for 11
        /// </summary>
        Potx,
        
        /// <summary>
        /// Enum Potm for 12
        /// </summary>
        Potm,
        
        /// <summary>
        /// Enum Html for 13
        /// </summary>
        Html,
        
        /// <summary>
        /// Enum Swf for 14
        /// </summary>
        Swf
    }

}
