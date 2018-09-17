// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AddMasterSlide.cs">
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
  public class AddMasterSlide : Task 
  {                       
        /// <summary>
        /// Gets or sets CloneFromFile
        /// </summary>
        public InputFile CloneFromFile { get; set; }

        /// <summary>
        /// Gets or sets CloneFromPosition
        /// </summary>
        public int? CloneFromPosition { get; set; }

        /// <summary>
        /// Gets or sets ApplyToAll
        /// </summary>
        public bool? ApplyToAll { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public AddMasterSlide() : base()
        {
          Type = Model.TaskType.AddMasterSlide;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AddMasterSlide {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  CloneFromFile: ").Append(this.CloneFromFile).Append("\n");
          sb.Append("  CloneFromPosition: ").Append(this.CloneFromPosition).Append("\n");
          sb.Append("  ApplyToAll: ").Append(this.ApplyToAll).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
