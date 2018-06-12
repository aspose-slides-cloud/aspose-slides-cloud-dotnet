// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Series.cs">
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
  /// A chart series.
  /// </summary>  
  public class Series 
  {                       
        /// <summary>
        /// Data point type.
        /// </summary>
        public ChartDataPointType DataPointType { get; set; }

        /// <summary>
        /// Series type.
        /// </summary>
        public ChartType Type { get; set; }

        /// <summary>
        /// Series name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// True if each data marker in the series has a different color.
        /// </summary>
        public bool? IsColorVaried { get; set; }

        /// <summary>
        /// Invert solid color for the series.
        /// </summary>
        public string InvertedSolidFillColor { get; set; }

        /// <summary>
        /// True if curve smoothing is turned on. Applies only to line and scatter connected by lines charts.
        /// </summary>
        public bool? Smooth { get; set; }

        /// <summary>
        /// True if the series is plotted on second value axis.
        /// </summary>
        public bool? PlotOnSecondAxis { get; set; }

        /// <summary>
        /// Series order.
        /// </summary>
        public int? Order { get; set; }

        /// <summary>
        /// The number format for the series y values.
        /// </summary>
        public string NumberFormatOfYValues { get; set; }

        /// <summary>
        /// The number format for the series x values.
        /// </summary>
        public string NumberFormatOfXValues { get; set; }

        /// <summary>
        /// The number format for the series values.
        /// </summary>
        public string NumberFormatOfValues { get; set; }

        /// <summary>
        /// The number format for the series bubble sizes.
        /// </summary>
        public string NumberFormatOfBubbleSizes { get; set; }

        /// <summary>
        /// True if the series shall invert its colors if the value is negative. Applies to bar, column and bubble series.
        /// </summary>
        public bool? InvertIfNegative { get; set; }

        /// <summary>
        /// The distance of an open pie slice from the center of the pie chart is expressed as a percentage of the pie diameter.
        /// </summary>
        public int? Explosion { get; set; }

        /// <summary>
        /// Series marker.
        /// </summary>
        public SeriesMarker Marker { get; set; }

        /// <summary>
        /// Fill properties set for the series.
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Effect properties set for the series.
        /// </summary>
        public EffectFormat EffectFormat { get; set; }

        /// <summary>
        /// Line properties set for the series.
        /// </summary>
        public LineFormat LineFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Series {\n");
          sb.Append("  DataPointType: ").Append(this.DataPointType).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  IsColorVaried: ").Append(this.IsColorVaried).Append("\n");
          sb.Append("  InvertedSolidFillColor: ").Append(this.InvertedSolidFillColor).Append("\n");
          sb.Append("  Smooth: ").Append(this.Smooth).Append("\n");
          sb.Append("  PlotOnSecondAxis: ").Append(this.PlotOnSecondAxis).Append("\n");
          sb.Append("  Order: ").Append(this.Order).Append("\n");
          sb.Append("  NumberFormatOfYValues: ").Append(this.NumberFormatOfYValues).Append("\n");
          sb.Append("  NumberFormatOfXValues: ").Append(this.NumberFormatOfXValues).Append("\n");
          sb.Append("  NumberFormatOfValues: ").Append(this.NumberFormatOfValues).Append("\n");
          sb.Append("  NumberFormatOfBubbleSizes: ").Append(this.NumberFormatOfBubbleSizes).Append("\n");
          sb.Append("  InvertIfNegative: ").Append(this.InvertIfNegative).Append("\n");
          sb.Append("  Explosion: ").Append(this.Explosion).Append("\n");
          sb.Append("  Marker: ").Append(this.Marker).Append("\n");
          sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
          sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
          sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
