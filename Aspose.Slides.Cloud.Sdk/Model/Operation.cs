// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Operation.cs">
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
    public class Operation 
    {                       
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            
            /// <summary>
            /// Enum Convert for "Convert"
            /// </summary>
            Convert,
            
            /// <summary>
            /// Enum DownloadPresentation for "DownloadPresentation"
            /// </summary>
            DownloadPresentation
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Created for "Created"
            /// </summary>
            Created,
            
            /// <summary>
            /// Enum Enqueued for "Enqueued"
            /// </summary>
            Enqueued,
            
            /// <summary>
            /// Enum Started for "Started"
            /// </summary>
            Started,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            Failed,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            Canceled,
            
            /// <summary>
            /// Enum Finished for "Finished"
            /// </summary>
            Finished
        }

        /// <summary>
        /// Gets or sets Method
        /// </summary>
        public MethodEnum? Method { get; set; }

        /// <summary>
        /// Gets or sets Status
        /// </summary>
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets Enqueued
        /// </summary>
        public DateTime? Enqueued { get; set; }

        /// <summary>
        /// Gets or sets Started
        /// </summary>
        public DateTime? Started { get; set; }

        /// <summary>
        /// Gets or sets Failed
        /// </summary>
        public DateTime? Failed { get; set; }

        /// <summary>
        /// Gets or sets Canceled
        /// </summary>
        public DateTime? Canceled { get; set; }

        /// <summary>
        /// Gets or sets Finished
        /// </summary>
        public DateTime? Finished { get; set; }

        /// <summary>
        /// Gets or sets Error
        /// </summary>
        public string Error { get; set; }


        /// <summary>
        /// Property values to determine the type when deserializing from Json
        /// </summary>
        public static Dictionary<string, object> TypeDeterminers
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
        public Operation() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Operation {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Method: ").Append(this.Method).Append("\n");
            sb.Append("  Status: ").Append(this.Status).Append("\n");
            sb.Append("  Created: ").Append(this.Created).Append("\n");
            sb.Append("  Enqueued: ").Append(this.Enqueued).Append("\n");
            sb.Append("  Started: ").Append(this.Started).Append("\n");
            sb.Append("  Failed: ").Append(this.Failed).Append("\n");
            sb.Append("  Canceled: ").Append(this.Canceled).Append("\n");
            sb.Append("  Finished: ").Append(this.Finished).Append("\n");
            sb.Append("  Error: ").Append(this.Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
