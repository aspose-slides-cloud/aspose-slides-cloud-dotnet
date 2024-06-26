// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ScatterChartDataPoint.cs">
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
    /// Scatter chart (two-dimensional) data point
    /// </summary>  
    public class ScatterChartDataPoint : DataPoint 
    {                       
        /// <summary>
        /// X-value
        /// </summary>
        public double? XValue { get; set; }

        /// <summary>
        /// Y-value
        /// </summary>
        public double? YValue { get; set; }

        /// <summary>
        /// Spreadsheet formula in A1-style.
        /// </summary>
        public string XValueFormula { get; set; }

        /// <summary>
        /// Spreadsheet formula in A1-style.
        /// </summary>
        public string YValueFormula { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.Scatter);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public ScatterChartDataPoint() : base()
        {
            Type = TypeEnum.Scatter;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ScatterChartDataPoint {\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
            sb.Append("  ThreeDFormat: ").Append(this.ThreeDFormat).Append("\n");
            sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
            sb.Append("  Marker: ").Append(this.Marker).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  XValue: ").Append(this.XValue).Append("\n");
            sb.Append("  YValue: ").Append(this.YValue).Append("\n");
            sb.Append("  XValueFormula: ").Append(this.XValueFormula).Append("\n");
            sb.Append("  YValueFormula: ").Append(this.YValueFormula).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
