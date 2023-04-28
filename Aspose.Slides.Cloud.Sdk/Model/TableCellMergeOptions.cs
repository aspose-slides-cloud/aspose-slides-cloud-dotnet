// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableCellMergeOptions.cs">
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
    /// Table cells merge options
    /// </summary>  
    public class TableCellMergeOptions 
    {                       
        /// <summary>
        /// Row index of the first cell
        /// </summary>
        public int? FirstRowIndex { get; set; }

        /// <summary>
        /// First cell index in the row
        /// </summary>
        public int? FirstCellIndex { get; set; }

        /// <summary>
        /// Row index of the last cell
        /// </summary>
        public int? LastRowIndex { get; set; }

        /// <summary>
        /// Last cell index in the row
        /// </summary>
        public int? LastCellIndex { get; set; }

        /// <summary>
        /// Allow splitting
        /// </summary>
        public bool? AllowSplitting { get; set; }


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
        public TableCellMergeOptions() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TableCellMergeOptions {\n");
            sb.Append("  FirstRowIndex: ").Append(this.FirstRowIndex).Append("\n");
            sb.Append("  FirstCellIndex: ").Append(this.FirstCellIndex).Append("\n");
            sb.Append("  LastRowIndex: ").Append(this.LastRowIndex).Append("\n");
            sb.Append("  LastCellIndex: ").Append(this.LastCellIndex).Append("\n");
            sb.Append("  AllowSplitting: ").Append(this.AllowSplitting).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
