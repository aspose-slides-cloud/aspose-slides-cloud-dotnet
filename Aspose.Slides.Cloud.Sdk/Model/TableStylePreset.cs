// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableStylePreset.cs">
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
    public enum TableStylePreset
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        None,
        
        /// <summary>
        /// Enum MediumStyle2Accent1 for "MediumStyle2Accent1"
        /// </summary>
        MediumStyle2Accent1,
        
        /// <summary>
        /// Enum MediumStyle2 for "MediumStyle2"
        /// </summary>
        MediumStyle2,
        
        /// <summary>
        /// Enum NoStyleNoGrid for "NoStyleNoGrid"
        /// </summary>
        NoStyleNoGrid,
        
        /// <summary>
        /// Enum ThemedStyle1Accent1 for "ThemedStyle1Accent1"
        /// </summary>
        ThemedStyle1Accent1,
        
        /// <summary>
        /// Enum ThemedStyle1Accent2 for "ThemedStyle1Accent2"
        /// </summary>
        ThemedStyle1Accent2,
        
        /// <summary>
        /// Enum ThemedStyle1Accent3 for "ThemedStyle1Accent3"
        /// </summary>
        ThemedStyle1Accent3,
        
        /// <summary>
        /// Enum ThemedStyle1Accent4 for "ThemedStyle1Accent4"
        /// </summary>
        ThemedStyle1Accent4,
        
        /// <summary>
        /// Enum ThemedStyle1Accent5 for "ThemedStyle1Accent5"
        /// </summary>
        ThemedStyle1Accent5,
        
        /// <summary>
        /// Enum ThemedStyle1Accent6 for "ThemedStyle1Accent6"
        /// </summary>
        ThemedStyle1Accent6,
        
        /// <summary>
        /// Enum NoStyleTableGrid for "NoStyleTableGrid"
        /// </summary>
        NoStyleTableGrid,
        
        /// <summary>
        /// Enum ThemedStyle2Accent1 for "ThemedStyle2Accent1"
        /// </summary>
        ThemedStyle2Accent1,
        
        /// <summary>
        /// Enum ThemedStyle2Accent2 for "ThemedStyle2Accent2"
        /// </summary>
        ThemedStyle2Accent2,
        
        /// <summary>
        /// Enum ThemedStyle2Accent3 for "ThemedStyle2Accent3"
        /// </summary>
        ThemedStyle2Accent3,
        
        /// <summary>
        /// Enum ThemedStyle2Accent4 for "ThemedStyle2Accent4"
        /// </summary>
        ThemedStyle2Accent4,
        
        /// <summary>
        /// Enum ThemedStyle2Accent5 for "ThemedStyle2Accent5"
        /// </summary>
        ThemedStyle2Accent5,
        
        /// <summary>
        /// Enum ThemedStyle2Accent6 for "ThemedStyle2Accent6"
        /// </summary>
        ThemedStyle2Accent6,
        
        /// <summary>
        /// Enum LightStyle1 for "LightStyle1"
        /// </summary>
        LightStyle1,
        
        /// <summary>
        /// Enum LightStyle1Accent1 for "LightStyle1Accent1"
        /// </summary>
        LightStyle1Accent1,
        
        /// <summary>
        /// Enum LightStyle1Accent2 for "LightStyle1Accent2"
        /// </summary>
        LightStyle1Accent2,
        
        /// <summary>
        /// Enum LightStyle1Accent3 for "LightStyle1Accent3"
        /// </summary>
        LightStyle1Accent3,
        
        /// <summary>
        /// Enum LightStyle1Accent4 for "LightStyle1Accent4"
        /// </summary>
        LightStyle1Accent4,
        
        /// <summary>
        /// Enum LightStyle2Accent5 for "LightStyle2Accent5"
        /// </summary>
        LightStyle2Accent5,
        
        /// <summary>
        /// Enum LightStyle1Accent6 for "LightStyle1Accent6"
        /// </summary>
        LightStyle1Accent6,
        
        /// <summary>
        /// Enum LightStyle2 for "LightStyle2"
        /// </summary>
        LightStyle2,
        
        /// <summary>
        /// Enum LightStyle2Accent1 for "LightStyle2Accent1"
        /// </summary>
        LightStyle2Accent1,
        
        /// <summary>
        /// Enum LightStyle2Accent2 for "LightStyle2Accent2"
        /// </summary>
        LightStyle2Accent2,
        
        /// <summary>
        /// Enum LightStyle2Accent3 for "LightStyle2Accent3"
        /// </summary>
        LightStyle2Accent3,
        
        /// <summary>
        /// Enum MediumStyle2Accent3 for "MediumStyle2Accent3"
        /// </summary>
        MediumStyle2Accent3,
        
        /// <summary>
        /// Enum MediumStyle2Accent4 for "MediumStyle2Accent4"
        /// </summary>
        MediumStyle2Accent4,
        
        /// <summary>
        /// Enum MediumStyle2Accent5 for "MediumStyle2Accent5"
        /// </summary>
        MediumStyle2Accent5,
        
        /// <summary>
        /// Enum LightStyle2Accent6 for "LightStyle2Accent6"
        /// </summary>
        LightStyle2Accent6,
        
        /// <summary>
        /// Enum LightStyle2Accent4 for "LightStyle2Accent4"
        /// </summary>
        LightStyle2Accent4,
        
        /// <summary>
        /// Enum LightStyle3 for "LightStyle3"
        /// </summary>
        LightStyle3,
        
        /// <summary>
        /// Enum LightStyle3Accent1 for "LightStyle3Accent1"
        /// </summary>
        LightStyle3Accent1,
        
        /// <summary>
        /// Enum MediumStyle2Accent2 for "MediumStyle2Accent2"
        /// </summary>
        MediumStyle2Accent2,
        
        /// <summary>
        /// Enum LightStyle3Accent2 for "LightStyle3Accent2"
        /// </summary>
        LightStyle3Accent2,
        
        /// <summary>
        /// Enum LightStyle3Accent3 for "LightStyle3Accent3"
        /// </summary>
        LightStyle3Accent3,
        
        /// <summary>
        /// Enum LightStyle3Accent4 for "LightStyle3Accent4"
        /// </summary>
        LightStyle3Accent4,
        
        /// <summary>
        /// Enum LightStyle3Accent5 for "LightStyle3Accent5"
        /// </summary>
        LightStyle3Accent5,
        
        /// <summary>
        /// Enum LightStyle3Accent6 for "LightStyle3Accent6"
        /// </summary>
        LightStyle3Accent6,
        
        /// <summary>
        /// Enum MediumStyle1 for "MediumStyle1"
        /// </summary>
        MediumStyle1,
        
        /// <summary>
        /// Enum MediumStyle1Accent1 for "MediumStyle1Accent1"
        /// </summary>
        MediumStyle1Accent1,
        
        /// <summary>
        /// Enum MediumStyle1Accent2 for "MediumStyle1Accent2"
        /// </summary>
        MediumStyle1Accent2,
        
        /// <summary>
        /// Enum MediumStyle1Accent3 for "MediumStyle1Accent3"
        /// </summary>
        MediumStyle1Accent3,
        
        /// <summary>
        /// Enum MediumStyle1Accent4 for "MediumStyle1Accent4"
        /// </summary>
        MediumStyle1Accent4,
        
        /// <summary>
        /// Enum MediumStyle1Accent5 for "MediumStyle1Accent5"
        /// </summary>
        MediumStyle1Accent5,
        
        /// <summary>
        /// Enum MediumStyle1Accent6 for "MediumStyle1Accent6"
        /// </summary>
        MediumStyle1Accent6,
        
        /// <summary>
        /// Enum MediumStyle2Accent6 for "MediumStyle2Accent6"
        /// </summary>
        MediumStyle2Accent6,
        
        /// <summary>
        /// Enum MediumStyle3 for "MediumStyle3"
        /// </summary>
        MediumStyle3,
        
        /// <summary>
        /// Enum MediumStyle3Accent1 for "MediumStyle3Accent1"
        /// </summary>
        MediumStyle3Accent1,
        
        /// <summary>
        /// Enum MediumStyle3Accent2 for "MediumStyle3Accent2"
        /// </summary>
        MediumStyle3Accent2,
        
        /// <summary>
        /// Enum MediumStyle3Accent3 for "MediumStyle3Accent3"
        /// </summary>
        MediumStyle3Accent3,
        
        /// <summary>
        /// Enum MediumStyle3Accent4 for "MediumStyle3Accent4"
        /// </summary>
        MediumStyle3Accent4,
        
        /// <summary>
        /// Enum MediumStyle3Accent5 for "MediumStyle3Accent5"
        /// </summary>
        MediumStyle3Accent5,
        
        /// <summary>
        /// Enum MediumStyle3Accent6 for "MediumStyle3Accent6"
        /// </summary>
        MediumStyle3Accent6,
        
        /// <summary>
        /// Enum MediumStyle4 for "MediumStyle4"
        /// </summary>
        MediumStyle4,
        
        /// <summary>
        /// Enum MediumStyle4Accent1 for "MediumStyle4Accent1"
        /// </summary>
        MediumStyle4Accent1,
        
        /// <summary>
        /// Enum MediumStyle4Accent2 for "MediumStyle4Accent2"
        /// </summary>
        MediumStyle4Accent2,
        
        /// <summary>
        /// Enum MediumStyle4Accent3 for "MediumStyle4Accent3"
        /// </summary>
        MediumStyle4Accent3,
        
        /// <summary>
        /// Enum MediumStyle4Accent4 for "MediumStyle4Accent4"
        /// </summary>
        MediumStyle4Accent4,
        
        /// <summary>
        /// Enum MediumStyle4Accent5 for "MediumStyle4Accent5"
        /// </summary>
        MediumStyle4Accent5,
        
        /// <summary>
        /// Enum MediumStyle4Accent6 for "MediumStyle4Accent6"
        /// </summary>
        MediumStyle4Accent6,
        
        /// <summary>
        /// Enum DarkStyle1 for "DarkStyle1"
        /// </summary>
        DarkStyle1,
        
        /// <summary>
        /// Enum DarkStyle1Accent1 for "DarkStyle1Accent1"
        /// </summary>
        DarkStyle1Accent1,
        
        /// <summary>
        /// Enum DarkStyle1Accent2 for "DarkStyle1Accent2"
        /// </summary>
        DarkStyle1Accent2,
        
        /// <summary>
        /// Enum DarkStyle1Accent3 for "DarkStyle1Accent3"
        /// </summary>
        DarkStyle1Accent3,
        
        /// <summary>
        /// Enum DarkStyle1Accent4 for "DarkStyle1Accent4"
        /// </summary>
        DarkStyle1Accent4,
        
        /// <summary>
        /// Enum DarkStyle1Accent5 for "DarkStyle1Accent5"
        /// </summary>
        DarkStyle1Accent5,
        
        /// <summary>
        /// Enum DarkStyle1Accent6 for "DarkStyle1Accent6"
        /// </summary>
        DarkStyle1Accent6,
        
        /// <summary>
        /// Enum DarkStyle2 for "DarkStyle2"
        /// </summary>
        DarkStyle2,
        
        /// <summary>
        /// Enum DarkStyle2Accent1Accent2 for "DarkStyle2Accent1Accent2"
        /// </summary>
        DarkStyle2Accent1Accent2,
        
        /// <summary>
        /// Enum DarkStyle2Accent3Accent4 for "DarkStyle2Accent3Accent4"
        /// </summary>
        DarkStyle2Accent3Accent4,
        
        /// <summary>
        /// Enum DarkStyle2Accent5Accent6 for "DarkStyle2Accent5Accent6"
        /// </summary>
        DarkStyle2Accent5Accent6,
        
        /// <summary>
        /// Enum LightStyle1Accent5 for "LightStyle1Accent5"
        /// </summary>
        LightStyle1Accent5,
        
        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        Custom
    }

}
