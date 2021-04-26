
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostWatermarkOnlineRequest.cs">
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

using System.Collections.Generic;
using System.IO;
using Aspose.Slides.Cloud.Sdk.Model;

namespace Aspose.Slides.Cloud.Sdk.Model.Requests 
{
  /// <summary>
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PostWatermarkOnline" /> operation.
  /// </summary>  
  public class PostWatermarkOnlineRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostWatermarkOnlineRequest"/> class.
        /// </summary>        
        public PostWatermarkOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWatermarkOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">Document data.</param>
        /// <param name="shape">Shape DTO</param>
        /// <param name="fontHeight">Watermark font height.</param>
        /// <param name="text">Watermark text.</param>
        /// <param name="fontName">Watermark font name.</param>
        /// <param name="fontColor">Watermark font color.</param>
        /// <param name="password">Document password.</param>
        public PostWatermarkOnlineRequest(System.IO.Stream document, Shape shape = null, double? fontHeight = null, string text = null, string fontName = null, string fontColor = null, string password = null)
        {
            this.Document = document;
            this.Shape = shape;
            this.FontHeight = fontHeight;
            this.Text = text;
            this.FontName = fontName;
            this.FontColor = fontColor;
            this.Password = password;
        }

        /// <summary>
        /// Document data.
        /// </summary>  
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Shape DTO
        /// </summary>  
        public Shape Shape { get; set; }

        /// <summary>
        /// Watermark font height.
        /// </summary>  
        public double? FontHeight { get; set; }

        /// <summary>
        /// Watermark text.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Watermark font name.
        /// </summary>  
        public string FontName { get; set; }

        /// <summary>
        /// Watermark font color.
        /// </summary>  
        public string FontColor { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }
  }
}