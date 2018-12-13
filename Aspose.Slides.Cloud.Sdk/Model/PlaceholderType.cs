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
        /// Enum Title for "Title"
        /// </summary>
        Title,
        
        /// <summary>
        /// Enum Body for "Body"
        /// </summary>
        Body,
        
        /// <summary>
        /// Enum CenteredTitle for "CenteredTitle"
        /// </summary>
        CenteredTitle,
        
        /// <summary>
        /// Enum Subtitle for "Subtitle"
        /// </summary>
        Subtitle,
        
        /// <summary>
        /// Enum DateAndTime for "DateAndTime"
        /// </summary>
        DateAndTime,
        
        /// <summary>
        /// Enum SlideNumber for "SlideNumber"
        /// </summary>
        SlideNumber,
        
        /// <summary>
        /// Enum Footer for "Footer"
        /// </summary>
        Footer,
        
        /// <summary>
        /// Enum Header for "Header"
        /// </summary>
        Header,
        
        /// <summary>
        /// Enum Object for "Object"
        /// </summary>
        Object,
        
        /// <summary>
        /// Enum Chart for "Chart"
        /// </summary>
        Chart,
        
        /// <summary>
        /// Enum Table for "Table"
        /// </summary>
        Table,
        
        /// <summary>
        /// Enum ClipArt for "ClipArt"
        /// </summary>
        ClipArt,
        
        /// <summary>
        /// Enum Diagram for "Diagram"
        /// </summary>
        Diagram,
        
        /// <summary>
        /// Enum Media for "Media"
        /// </summary>
        Media,
        
        /// <summary>
        /// Enum SlideImage for "SlideImage"
        /// </summary>
        SlideImage,
        
        /// <summary>
        /// Enum Picture for "Picture"
        /// </summary>
        Picture
    }

}
