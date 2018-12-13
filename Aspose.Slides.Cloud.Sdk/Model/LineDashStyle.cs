// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LineDashStyle.cs">
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
    /// Dash style of a line.
    /// </summary>
    /// <value>Dash style of a line.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LineDashStyle
    {
        
        /// <summary>
        /// Enum Solid for "Solid"
        /// </summary>
        Solid,
        
        /// <summary>
        /// Enum Dot for "Dot"
        /// </summary>
        Dot,
        
        /// <summary>
        /// Enum Dash for "Dash"
        /// </summary>
        Dash,
        
        /// <summary>
        /// Enum LargeDash for "LargeDash"
        /// </summary>
        LargeDash,
        
        /// <summary>
        /// Enum DashDot for "DashDot"
        /// </summary>
        DashDot,
        
        /// <summary>
        /// Enum LargeDashDot for "LargeDashDot"
        /// </summary>
        LargeDashDot,
        
        /// <summary>
        /// Enum LargeDashDotDot for "LargeDashDotDot"
        /// </summary>
        LargeDashDotDot,
        
        /// <summary>
        /// Enum SystemDash for "SystemDash"
        /// </summary>
        SystemDash,
        
        /// <summary>
        /// Enum SystemDot for "SystemDot"
        /// </summary>
        SystemDot,
        
        /// <summary>
        /// Enum SystemDashDot for "SystemDashDot"
        /// </summary>
        SystemDashDot,
        
        /// <summary>
        /// Enum SystemDashDotDot for "SystemDashDotDot"
        /// </summary>
        SystemDashDotDot,
        
        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        Custom,
        
        /// <summary>
        /// Enum NotDefined for "NotDefined"
        /// </summary>
        NotDefined
    }

}
