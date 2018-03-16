// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PlaceholderType.cs">
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
    public enum PlaceholderType
    {
        
        /// <summary>
        /// Enum Title for 0
        /// </summary>
        Title,
        
        /// <summary>
        /// Enum Body for 1
        /// </summary>
        Body,
        
        /// <summary>
        /// Enum CenteredTitle for 2
        /// </summary>
        CenteredTitle,
        
        /// <summary>
        /// Enum Subtitle for 3
        /// </summary>
        Subtitle,
        
        /// <summary>
        /// Enum DateAndTime for 4
        /// </summary>
        DateAndTime,
        
        /// <summary>
        /// Enum SlideNumber for 5
        /// </summary>
        SlideNumber,
        
        /// <summary>
        /// Enum Footer for 6
        /// </summary>
        Footer,
        
        /// <summary>
        /// Enum Header for 7
        /// </summary>
        Header,
        
        /// <summary>
        /// Enum Object for 8
        /// </summary>
        Object,
        
        /// <summary>
        /// Enum Chart for 9
        /// </summary>
        Chart,
        
        /// <summary>
        /// Enum Table for 10
        /// </summary>
        Table,
        
        /// <summary>
        /// Enum ClipArt for 11
        /// </summary>
        ClipArt,
        
        /// <summary>
        /// Enum Diagram for 12
        /// </summary>
        Diagram,
        
        /// <summary>
        /// Enum Media for 13
        /// </summary>
        Media,
        
        /// <summary>
        /// Enum SlideImage for 14
        /// </summary>
        SlideImage,
        
        /// <summary>
        /// Enum Picture for 15
        /// </summary>
        Picture
    }

}
