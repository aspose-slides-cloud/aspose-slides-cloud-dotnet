// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ProtectionProperties.cs">
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
    /// Protection properties.
    /// </summary>  
    public class ProtectionProperties : ResourceBase 
    {                       
        /// <summary>
        /// True if document properties are encrypted. Has effect only for password protected presentations.
        /// </summary>
        public bool? EncryptDocumentProperties { get; set; }

        /// <summary>
        /// True if the document should be opened as read-only.
        /// </summary>
        public bool? ReadOnlyRecommended { get; set; }

        /// <summary>
        /// Password for read protection.
        /// </summary>
        public string ReadPassword { get; set; }

        /// <summary>
        /// Password for write protection.
        /// </summary>
        public string WritePassword { get; set; }

        /// <summary>
        /// Returns true if the presentation protected for editing. 
        /// </summary>
        public bool? IsWriteProtected { get; set; }

        /// <summary>
        /// Returns true if the presentation protected for reading. 
        /// </summary>
        public bool? IsEncrypted { get; set; }


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
        public ProtectionProperties() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectionProperties {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  EncryptDocumentProperties: ").Append(this.EncryptDocumentProperties).Append("\n");
            sb.Append("  ReadOnlyRecommended: ").Append(this.ReadOnlyRecommended).Append("\n");
            sb.Append("  ReadPassword: ").Append(this.ReadPassword).Append("\n");
            sb.Append("  WritePassword: ").Append(this.WritePassword).Append("\n");
            sb.Append("  IsWriteProtected: ").Append(this.IsWriteProtected).Append("\n");
            sb.Append("  IsEncrypted: ").Append(this.IsEncrypted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
