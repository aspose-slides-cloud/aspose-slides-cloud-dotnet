
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutSlidesProtectionPropertiesOnlineRequest.cs">
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
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PutSlidesProtectionPropertiesOnline" /> operation.
  /// </summary>  
  public class PutSlidesProtectionPropertiesOnlineRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesProtectionPropertiesOnlineRequest"/> class.
        /// </summary>        
        public PutSlidesProtectionPropertiesOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesProtectionPropertiesOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">Document data.</param>
        /// <param name="dto">Protection properties.</param>
        /// <param name="password">Document password.</param>
        public PutSlidesProtectionPropertiesOnlineRequest(System.IO.Stream document, ProtectionProperties dto, string password = null)
        {
            this.Document = document;
            this.Dto = dto;
            this.Password = password;
        }

        /// <summary>
        /// Document data.
        /// </summary>  
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Protection properties.
        /// </summary>  
        public ProtectionProperties Dto { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }
  }
}