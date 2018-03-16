// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SmartArtQuickStyleType.cs">
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
    /// Represents style scheme of a SmartArt diagram.
    /// </summary>
    /// <value>Represents style scheme of a SmartArt diagram.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmartArtQuickStyleType
    {
        
        /// <summary>
        /// Enum SimpleFill for "SimpleFill"
        /// </summary>
        SimpleFill,
        
        /// <summary>
        /// Enum WhiteOutline for "WhiteOutline"
        /// </summary>
        WhiteOutline,
        
        /// <summary>
        /// Enum SubtleEffect for "SubtleEffect"
        /// </summary>
        SubtleEffect,
        
        /// <summary>
        /// Enum ModerateEffect for "ModerateEffect"
        /// </summary>
        ModerateEffect,
        
        /// <summary>
        /// Enum IntenceEffect for "IntenceEffect"
        /// </summary>
        IntenceEffect,
        
        /// <summary>
        /// Enum Polished for "Polished"
        /// </summary>
        Polished,
        
        /// <summary>
        /// Enum Inset for "Inset"
        /// </summary>
        Inset,
        
        /// <summary>
        /// Enum Cartoon for "Cartoon"
        /// </summary>
        Cartoon,
        
        /// <summary>
        /// Enum Powder for "Powder"
        /// </summary>
        Powder,
        
        /// <summary>
        /// Enum BrickScene for "BrickScene"
        /// </summary>
        BrickScene,
        
        /// <summary>
        /// Enum FlatScene for "FlatScene"
        /// </summary>
        FlatScene,
        
        /// <summary>
        /// Enum MetallicScene for "MetallicScene"
        /// </summary>
        MetallicScene,
        
        /// <summary>
        /// Enum SunsetScene for "SunsetScene"
        /// </summary>
        SunsetScene,
        
        /// <summary>
        /// Enum BirdsEyeScene for "BirdsEyeScene"
        /// </summary>
        BirdsEyeScene
    }

}
