// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Configuration.cs">
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

namespace Aspose.Slides.Cloud.Sdk
{
    /// <summary>
    /// Represents a set of configuration settings.
    /// </summary>
    public class Configuration
    {
        public Configuration()
        {
            AuthBaseUrl = ApiBaseUrl = "https://api.aspose.cloud";
            Version = "v3.0";
            DebugMode = false;
            CustomHeaders = new Dictionary<string, string>();
            HttpRequestTimeout = 300;
        }

        /// <summary>
        /// Aspose Cloud API base URL.
        /// </summary>
        public string ApiBaseUrl { get; set; }

        /// <summary>
        /// Aspose Cloud API base URL.
        /// </summary>
        public string AuthBaseUrl { get; set; }

        /// <summary>
        /// Aspose Cloud API version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the Client Id.
        /// </summary>
        public string AppSid { get; set; }

        /// <summary>
        /// Gets or sets the Client Secret.
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// Gets or sets the auth token.
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// Gets or sets slides operaion timeout in seconds. 0 stands for no timeout.
        /// The timeout applies to the Slides operation, not to the HTTP request.
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Gets or sets HTTP Request timeout in seconds. 0 stands for default .NET timeout.
        /// </summary>
        public int HttpRequestTimeout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether debug mode.
        /// </summary>
        public bool DebugMode { get; set; }

        /// <summary>
        /// Custom HTTP request header keys and values
        /// </summary>
        public Dictionary<string, string> CustomHeaders { get; set; }

        public string GetApiRootUrl()
        {
            var result = ApiBaseUrl + "/" + Version;
            return result.EndsWith("/") ? result.Substring(0, result.Length - 1) : result;
        }
    }
}
