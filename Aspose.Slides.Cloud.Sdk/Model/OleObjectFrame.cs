// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OleObjectFrame.cs">
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
    /// Represents OleObjectFrame resource.
    /// </summary>  
    public class OleObjectFrame : ShapeBase 
    {                       
        /// <summary>
        /// True if an object is visible as icon.
        /// </summary>
        public bool? IsObjectIcon { get; set; }

        /// <summary>
        /// The title for OleObject icon.             
        /// </summary>
        public string SubstitutePictureTitle { get; set; }

        /// <summary>
        /// OleObject image fill properties.
        /// </summary>
        public PictureFill SubstitutePictureFormat { get; set; }

        /// <summary>
        /// Returns or sets the name of an object.
        /// </summary>
        public string ObjectName { get; set; }

        /// <summary>
        /// File data of embedded OLE object. 
        /// </summary>
        public string EmbeddedFileBase64Data { get; set; }

        /// <summary>
        /// File extension for the current embedded OLE object
        /// </summary>
        public string EmbeddedFileExtension { get; set; }

        /// <summary>
        /// ProgID of an object.
        /// </summary>
        public string ObjectProgId { get; set; }

        /// <summary>
        /// Full path to a linked file.
        /// </summary>
        public string LinkPath { get; set; }

        /// <summary>
        /// Determines if the linked embedded object is automatically updated when the presentation is opened or printed. Read/write Boolean.
        /// </summary>
        public bool? UpdateAutomatic { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.OleObjectFrame);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public OleObjectFrame() : base()
        {
            Type = TypeEnum.OleObjectFrame;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class OleObjectFrame {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  AlternativeText: ").Append(this.AlternativeText).Append("\n");
            sb.Append("  AlternativeTextTitle: ").Append(this.AlternativeTextTitle).Append("\n");
            sb.Append("  Hidden: ").Append(this.Hidden).Append("\n");
            sb.Append("  IsDecorative: ").Append(this.IsDecorative).Append("\n");
            sb.Append("  X: ").Append(this.X).Append("\n");
            sb.Append("  Y: ").Append(this.Y).Append("\n");
            sb.Append("  ZOrderPosition: ").Append(this.ZOrderPosition).Append("\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
            sb.Append("  ThreeDFormat: ").Append(this.ThreeDFormat).Append("\n");
            sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
            sb.Append("  HyperlinkClick: ").Append(this.HyperlinkClick).Append("\n");
            sb.Append("  HyperlinkMouseOver: ").Append(this.HyperlinkMouseOver).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  IsObjectIcon: ").Append(this.IsObjectIcon).Append("\n");
            sb.Append("  SubstitutePictureTitle: ").Append(this.SubstitutePictureTitle).Append("\n");
            sb.Append("  SubstitutePictureFormat: ").Append(this.SubstitutePictureFormat).Append("\n");
            sb.Append("  ObjectName: ").Append(this.ObjectName).Append("\n");
            sb.Append("  EmbeddedFileBase64Data: ").Append(this.EmbeddedFileBase64Data).Append("\n");
            sb.Append("  EmbeddedFileExtension: ").Append(this.EmbeddedFileExtension).Append("\n");
            sb.Append("  ObjectProgId: ").Append(this.ObjectProgId).Append("\n");
            sb.Append("  LinkPath: ").Append(this.LinkPath).Append("\n");
            sb.Append("  UpdateAutomatic: ").Append(this.UpdateAutomatic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
