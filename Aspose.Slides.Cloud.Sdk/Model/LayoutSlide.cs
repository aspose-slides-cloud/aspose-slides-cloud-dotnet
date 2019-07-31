// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LayoutSlide.cs">
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
  /// Layout slide.
  /// </summary>  
  public class LayoutSlide : ResourceBase 
  {                       
        /// <summary>
        /// Layout slide type.
        /// </summary>
        /// <value>Layout slide type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Title for "Title"
            /// </summary>
            Title,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            Text,
            
            /// <summary>
            /// Enum TwoColumnText for "TwoColumnText"
            /// </summary>
            TwoColumnText,
            
            /// <summary>
            /// Enum Table for "Table"
            /// </summary>
            Table,
            
            /// <summary>
            /// Enum TextAndChart for "TextAndChart"
            /// </summary>
            TextAndChart,
            
            /// <summary>
            /// Enum ChartAndText for "ChartAndText"
            /// </summary>
            ChartAndText,
            
            /// <summary>
            /// Enum Diagram for "Diagram"
            /// </summary>
            Diagram,
            
            /// <summary>
            /// Enum Chart for "Chart"
            /// </summary>
            Chart,
            
            /// <summary>
            /// Enum TextAndClipArt for "TextAndClipArt"
            /// </summary>
            TextAndClipArt,
            
            /// <summary>
            /// Enum ClipArtAndText for "ClipArtAndText"
            /// </summary>
            ClipArtAndText,
            
            /// <summary>
            /// Enum TitleOnly for "TitleOnly"
            /// </summary>
            TitleOnly,
            
            /// <summary>
            /// Enum Blank for "Blank"
            /// </summary>
            Blank,
            
            /// <summary>
            /// Enum TextAndObject for "TextAndObject"
            /// </summary>
            TextAndObject,
            
            /// <summary>
            /// Enum ObjectAndText for "ObjectAndText"
            /// </summary>
            ObjectAndText,
            
            /// <summary>
            /// Enum Object for "Object"
            /// </summary>
            Object,
            
            /// <summary>
            /// Enum TitleAndObject for "TitleAndObject"
            /// </summary>
            TitleAndObject,
            
            /// <summary>
            /// Enum TextAndMedia for "TextAndMedia"
            /// </summary>
            TextAndMedia,
            
            /// <summary>
            /// Enum MediaAndText for "MediaAndText"
            /// </summary>
            MediaAndText,
            
            /// <summary>
            /// Enum ObjectOverText for "ObjectOverText"
            /// </summary>
            ObjectOverText,
            
            /// <summary>
            /// Enum TextOverObject for "TextOverObject"
            /// </summary>
            TextOverObject,
            
            /// <summary>
            /// Enum TextAndTwoObjects for "TextAndTwoObjects"
            /// </summary>
            TextAndTwoObjects,
            
            /// <summary>
            /// Enum TwoObjectsAndText for "TwoObjectsAndText"
            /// </summary>
            TwoObjectsAndText,
            
            /// <summary>
            /// Enum TwoObjectsOverText for "TwoObjectsOverText"
            /// </summary>
            TwoObjectsOverText,
            
            /// <summary>
            /// Enum FourObjects for "FourObjects"
            /// </summary>
            FourObjects,
            
            /// <summary>
            /// Enum VerticalText for "VerticalText"
            /// </summary>
            VerticalText,
            
            /// <summary>
            /// Enum ClipArtAndVerticalText for "ClipArtAndVerticalText"
            /// </summary>
            ClipArtAndVerticalText,
            
            /// <summary>
            /// Enum VerticalTitleAndText for "VerticalTitleAndText"
            /// </summary>
            VerticalTitleAndText,
            
            /// <summary>
            /// Enum VerticalTitleAndTextOverChart for "VerticalTitleAndTextOverChart"
            /// </summary>
            VerticalTitleAndTextOverChart,
            
            /// <summary>
            /// Enum TwoObjects for "TwoObjects"
            /// </summary>
            TwoObjects,
            
            /// <summary>
            /// Enum ObjectAndTwoObject for "ObjectAndTwoObject"
            /// </summary>
            ObjectAndTwoObject,
            
            /// <summary>
            /// Enum TwoObjectsAndObject for "TwoObjectsAndObject"
            /// </summary>
            TwoObjectsAndObject,
            
            /// <summary>
            /// Enum SectionHeader for "SectionHeader"
            /// </summary>
            SectionHeader,
            
            /// <summary>
            /// Enum TwoTextAndTwoObjects for "TwoTextAndTwoObjects"
            /// </summary>
            TwoTextAndTwoObjects,
            
            /// <summary>
            /// Enum TitleObjectAndCaption for "TitleObjectAndCaption"
            /// </summary>
            TitleObjectAndCaption,
            
            /// <summary>
            /// Enum PictureAndCaption for "PictureAndCaption"
            /// </summary>
            PictureAndCaption,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            Custom
        }

        /// <summary>
        /// Layout slide type.
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Master slide link.
        /// </summary>
        public ResourceUriElement MasterSlide { get; set; }

        /// <summary>
        /// List of depending slides.
        /// </summary>
        public List<ResourceUriElement> DependingSlides { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public LayoutSlide() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class LayoutSlide {\n");
          sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
          sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  MasterSlide: ").Append(this.MasterSlide).Append("\n");
          sb.Append("  DependingSlides: ").Append(this.DependingSlides).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
