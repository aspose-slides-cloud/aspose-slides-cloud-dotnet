// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SwfExportOptions.cs">
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
  /// Provides options that control how a presentation is saved in SWF format.
  /// </summary>  
  public class SwfExportOptions : ExportOptions 
  {                       
        /// <summary>
        /// Specifies whether the generated document should include hidden slides or not. Default is false. 
        /// </summary>
        public bool? ShowHiddenSlides { get; set; }

        /// <summary>
        /// Specifies whether the generated SWF document should be compressed or not. Default is true. 
        /// </summary>
        public bool? Compressed { get; set; }

        /// <summary>
        /// Specifies whether the generated SWF document should include the integrated document viewer or not. Default is true. 
        /// </summary>
        public bool? ViewerIncluded { get; set; }

        /// <summary>
        /// Specifies whether border around pages should be shown. Default is true. 
        /// </summary>
        public bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Show/hide fullscreen button. Can be overridden in flashvars. Default is true. 
        /// </summary>
        public bool? ShowFullScreen { get; set; }

        /// <summary>
        /// Show/hide page stepper. Can be overridden in flashvars. Default is true. 
        /// </summary>
        public bool? ShowPageStepper { get; set; }

        /// <summary>
        /// Show/hide search section. Can be overridden in flashvars. Default is true. 
        /// </summary>
        public bool? ShowSearch { get; set; }

        /// <summary>
        /// Show/hide whole top pane. Can be overridden in flashvars. Default is true. 
        /// </summary>
        public bool? ShowTopPane { get; set; }

        /// <summary>
        /// Show/hide bottom pane. Can be overridden in flashvars. Default is true. 
        /// </summary>
        public bool? ShowBottomPane { get; set; }

        /// <summary>
        /// Show/hide left pane. Can be overridden in flashvars. Default is true. 
        /// </summary>
        public bool? ShowLeftPane { get; set; }

        /// <summary>
        /// Start with opened left pane. Can be overridden in flashvars. Default is false. 
        /// </summary>
        public bool? StartOpenLeftPane { get; set; }

        /// <summary>
        /// Enable/disable context menu. Default is true. 
        /// </summary>
        public bool? EnableContextMenu { get; set; }

        /// <summary>
        /// Image that will be displayed as logo in the top right corner of the viewer. The image data is a base 64 string. Image should be 32x64 pixels PNG image, otherwise logo can be displayed improperly. 
        /// </summary>
        public string LogoImage { get; set; }

        /// <summary>
        /// Gets or sets the full hyperlink address for a logo. Has an effect only if a  is specified. 
        /// </summary>
        public string LogoLink { get; set; }

        /// <summary>
        /// Specifies the quality of JPEG images. Default is 95.
        /// </summary>
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Gets or sets the position of the notes on the page.
        /// </summary>
        public NotesPositions NotesPosition { get; set; }

        /// <summary>
        /// Gets or sets the position of the comments on the page.
        /// </summary>
        public CommentsPositions CommentsPosition { get; set; }

        /// <summary>
        /// Gets or sets the width of the comment output area in pixels (Applies only if comments are displayed on the right).
        /// </summary>
        public int? CommentsAreaWidth { get; set; }

        /// <summary>
        /// Gets or sets the color of comments area (Applies only if comments are displayed on the right).
        /// </summary>
        public string CommentsAreaColor { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SwfExportOptions() : base()
        {
          Format = "swf";
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SwfExportOptions {\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  ShowHiddenSlides: ").Append(this.ShowHiddenSlides).Append("\n");
          sb.Append("  Compressed: ").Append(this.Compressed).Append("\n");
          sb.Append("  ViewerIncluded: ").Append(this.ViewerIncluded).Append("\n");
          sb.Append("  ShowPageBorder: ").Append(this.ShowPageBorder).Append("\n");
          sb.Append("  ShowFullScreen: ").Append(this.ShowFullScreen).Append("\n");
          sb.Append("  ShowPageStepper: ").Append(this.ShowPageStepper).Append("\n");
          sb.Append("  ShowSearch: ").Append(this.ShowSearch).Append("\n");
          sb.Append("  ShowTopPane: ").Append(this.ShowTopPane).Append("\n");
          sb.Append("  ShowBottomPane: ").Append(this.ShowBottomPane).Append("\n");
          sb.Append("  ShowLeftPane: ").Append(this.ShowLeftPane).Append("\n");
          sb.Append("  StartOpenLeftPane: ").Append(this.StartOpenLeftPane).Append("\n");
          sb.Append("  EnableContextMenu: ").Append(this.EnableContextMenu).Append("\n");
          sb.Append("  LogoImage: ").Append(this.LogoImage).Append("\n");
          sb.Append("  LogoLink: ").Append(this.LogoLink).Append("\n");
          sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
          sb.Append("  NotesPosition: ").Append(this.NotesPosition).Append("\n");
          sb.Append("  CommentsPosition: ").Append(this.CommentsPosition).Append("\n");
          sb.Append("  CommentsAreaWidth: ").Append(this.CommentsAreaWidth).Append("\n");
          sb.Append("  CommentsAreaColor: ").Append(this.CommentsAreaColor).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
