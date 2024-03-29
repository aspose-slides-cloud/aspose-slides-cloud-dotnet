// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OneValueSeries.cs">
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
    /// One value series.
    /// </summary>  
    public class OneValueSeries : Series 
    {                       
        /// <summary>
        /// Quartile method. Applied to BoxAndWhisker series only.
        /// </summary>
        /// <value>Quartile method. Applied to BoxAndWhisker series only.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QuartileMethodEnum
        {
            
            /// <summary>
            /// Enum Exclusive for "Exclusive"
            /// </summary>
            Exclusive,
            
            /// <summary>
            /// Enum Inclusive for "Inclusive"
            /// </summary>
            Inclusive
        }

        /// <summary>
        /// Quartile method. Applied to BoxAndWhisker series only.
        /// </summary>
        public QuartileMethodEnum? QuartileMethod { get; set; }

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        public List<OneValueChartDataPoint> DataPoints { get; set; }

        /// <summary>
        /// The number format for the series values.
        /// </summary>
        public string NumberFormatOfValues { get; set; }

        /// <summary>
        /// Data source type for values.
        /// </summary>
        public DataSource DataSourceForValues { get; set; }

        /// <summary>
        /// True if inner points are shown. Applied to Waterfall series only.
        /// </summary>
        public bool? ShowConnectorLines { get; set; }

        /// <summary>
        /// True if inner points are shown. Applied to BoxAndWhisker series only.
        /// </summary>
        public bool? ShowInnerPoints { get; set; }

        /// <summary>
        /// True if mean line is shown. Applied to BoxAndWhisker series only.
        /// </summary>
        public bool? ShowMeanLine { get; set; }

        /// <summary>
        /// True if mean markers are shown. Applied to BoxAndWhisker series only.
        /// </summary>
        public bool? ShowMeanMarkers { get; set; }

        /// <summary>
        /// True if outlier points are shown. Applied to BoxAndWhisker series only.
        /// </summary>
        public bool? ShowOutlierPoints { get; set; }


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
                    s_typeDeterminers.Add("DataPointType", DataPointTypeEnum.OneValue);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public OneValueSeries() : base()
        {
            DataPointType = DataPointTypeEnum.OneValue;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class OneValueSeries {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  DataSourceForSeriesName: ").Append(this.DataSourceForSeriesName).Append("\n");
            sb.Append("  IsColorVaried: ").Append(this.IsColorVaried).Append("\n");
            sb.Append("  InvertedSolidFillColor: ").Append(this.InvertedSolidFillColor).Append("\n");
            sb.Append("  Smooth: ").Append(this.Smooth).Append("\n");
            sb.Append("  PlotOnSecondAxis: ").Append(this.PlotOnSecondAxis).Append("\n");
            sb.Append("  Order: ").Append(this.Order).Append("\n");
            sb.Append("  InvertIfNegative: ").Append(this.InvertIfNegative).Append("\n");
            sb.Append("  Explosion: ").Append(this.Explosion).Append("\n");
            sb.Append("  Marker: ").Append(this.Marker).Append("\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
            sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
            sb.Append("  DataPointType: ").Append(this.DataPointType).Append("\n");
            sb.Append("  DataPoints: ").Append(this.DataPoints).Append("\n");
            sb.Append("  NumberFormatOfValues: ").Append(this.NumberFormatOfValues).Append("\n");
            sb.Append("  DataSourceForValues: ").Append(this.DataSourceForValues).Append("\n");
            sb.Append("  ShowConnectorLines: ").Append(this.ShowConnectorLines).Append("\n");
            sb.Append("  QuartileMethod: ").Append(this.QuartileMethod).Append("\n");
            sb.Append("  ShowInnerPoints: ").Append(this.ShowInnerPoints).Append("\n");
            sb.Append("  ShowMeanLine: ").Append(this.ShowMeanLine).Append("\n");
            sb.Append("  ShowMeanMarkers: ").Append(this.ShowMeanMarkers).Append("\n");
            sb.Append("  ShowOutlierPoints: ").Append(this.ShowOutlierPoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
