// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Axes.cs">
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
  /// Represents chart axes
  /// </summary>  
  public class Axes 
  {                       
        /// <summary>
        /// Gets or sets the horizontal axis.
        /// </summary>
        public Axis HorizontalAxis { get; set; }

        /// <summary>
        /// Gets or sets the vertical axis.
        /// </summary>
        public Axis VerticalAxis { get; set; }

        /// <summary>
        /// Gets or sets the secondary horizontal axis.
        /// </summary>
        public Axis SecondaryHorizontalAxis { get; set; }

        /// <summary>
        /// Gets or sets the secondary vertical axis.
        /// </summary>
        public Axis SecondaryVerticalAxis { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public Axes() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Axes {\n");
          sb.Append("  HorizontalAxis: ").Append(this.HorizontalAxis).Append("\n");
          sb.Append("  VerticalAxis: ").Append(this.VerticalAxis).Append("\n");
          sb.Append("  SecondaryHorizontalAxis: ").Append(this.SecondaryHorizontalAxis).Append("\n");
          sb.Append("  SecondaryVerticalAxis: ").Append(this.SecondaryVerticalAxis).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
