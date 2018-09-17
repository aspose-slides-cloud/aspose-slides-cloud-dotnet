// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveSlide.cs">
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
  /// Save slide task.
  /// </summary>  
  public class SaveSlide : Task 
  {                       
        /// <summary>
        /// Output to save the slide to.
        /// </summary>
        public OutputFile Output { get; set; }

        /// <summary>
        /// Save format.
        /// </summary>
        public SlideExportFormat Format { get; set; }

        /// <summary>
        /// Save options.
        /// </summary>
        public ExportOptions Options { get; set; }

        /// <summary>
        /// Result width for saving to an image format.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Result height for saving to an image format.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Slide index.
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SaveSlide() : base()
        {
          Type = Model.TaskType.SaveSlide;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveSlide {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Output: ").Append(this.Output).Append("\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  Options: ").Append(this.Options).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Position: ").Append(this.Position).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
