// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SlideProperties.cs">
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
    /// Slide properties.
    /// </summary>  
    public class SlideProperties : ResourceBase 
    {                       
        /// <summary>
        /// Slide orientation.
        /// </summary>
        /// <value>Slide orientation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            
            /// <summary>
            /// Enum Landscape for "Landscape"
            /// </summary>
            Landscape,
            
            /// <summary>
            /// Enum Portrait for "Portrait"
            /// </summary>
            Portrait
        }

        /// <summary>
        /// Scale type.
        /// </summary>
        /// <value>Scale type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScaleTypeEnum
        {
            
            /// <summary>
            /// Enum DoNotScale for "DoNotScale"
            /// </summary>
            DoNotScale,
            
            /// <summary>
            /// Enum EnsureFit for "EnsureFit"
            /// </summary>
            EnsureFit,
            
            /// <summary>
            /// Enum Maximize for "Maximize"
            /// </summary>
            Maximize
        }

        /// <summary>
        /// Size type.
        /// </summary>
        /// <value>Size type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SizeTypeEnum
        {
            
            /// <summary>
            /// Enum OnScreen for "OnScreen"
            /// </summary>
            OnScreen,
            
            /// <summary>
            /// Enum LetterPaper for "LetterPaper"
            /// </summary>
            LetterPaper,
            
            /// <summary>
            /// Enum A4Paper for "A4Paper"
            /// </summary>
            A4Paper,
            
            /// <summary>
            /// Enum Slide35mm for "Slide35mm"
            /// </summary>
            Slide35mm,
            
            /// <summary>
            /// Enum Overhead for "Overhead"
            /// </summary>
            Overhead,
            
            /// <summary>
            /// Enum Banner for "Banner"
            /// </summary>
            Banner,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            Custom,
            
            /// <summary>
            /// Enum Ledger for "Ledger"
            /// </summary>
            Ledger,
            
            /// <summary>
            /// Enum A3Paper for "A3Paper"
            /// </summary>
            A3Paper,
            
            /// <summary>
            /// Enum B4IsoPaper for "B4IsoPaper"
            /// </summary>
            B4IsoPaper,
            
            /// <summary>
            /// Enum B5IsoPaper for "B5IsoPaper"
            /// </summary>
            B5IsoPaper,
            
            /// <summary>
            /// Enum B4JisPaper for "B4JisPaper"
            /// </summary>
            B4JisPaper,
            
            /// <summary>
            /// Enum B5JisPaper for "B5JisPaper"
            /// </summary>
            B5JisPaper,
            
            /// <summary>
            /// Enum HagakiCard for "HagakiCard"
            /// </summary>
            HagakiCard,
            
            /// <summary>
            /// Enum OnScreen16x9 for "OnScreen16x9"
            /// </summary>
            OnScreen16x9,
            
            /// <summary>
            /// Enum OnScreen16x10 for "OnScreen16x10"
            /// </summary>
            OnScreen16x10,
            
            /// <summary>
            /// Enum Widescreen for "Widescreen"
            /// </summary>
            Widescreen
        }

        /// <summary>
        /// Slide orientation.
        /// </summary>
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Scale type.
        /// </summary>
        public ScaleTypeEnum? ScaleType { get; set; }

        /// <summary>
        /// Size type.
        /// </summary>
        public SizeTypeEnum? SizeType { get; set; }

        /// <summary>
        /// First slide number.
        /// </summary>
        public int? FirstSlideNumber { get; set; }

        /// <summary>
        /// Width.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Height.
        /// </summary>
        public int? Height { get; set; }


        /// <summary>
        /// Property values to determine the type when deserializing from Json
        /// </summary>
        public static new Dictionary<string, object> TypeDeterminers
        {
            get
            {
                if (s_typeDeterminers == null)
                {
                    s_typeDeterminers = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SlideProperties() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class SlideProperties {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  FirstSlideNumber: ").Append(this.FirstSlideNumber).Append("\n");
            sb.Append("  Orientation: ").Append(this.Orientation).Append("\n");
            sb.Append("  ScaleType: ").Append(this.ScaleType).Append("\n");
            sb.Append("  SizeType: ").Append(this.SizeType).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
