// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartSeriesGroup.cs">
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
    /// Chart series group. Defines common properties for a group of series.
    /// </summary>  
    public class ChartSeriesGroup 
    {                       
        /// <summary>
        /// Returns a type of this series group.
        /// </summary>
        /// <value>Returns a type of this series group.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum BarOfPieChart for "BarOfPieChart"
            /// </summary>
            BarOfPieChart,
            
            /// <summary>
            /// Enum PieOfPieChart for "PieOfPieChart"
            /// </summary>
            PieOfPieChart,
            
            /// <summary>
            /// Enum DoughnutChart for "DoughnutChart"
            /// </summary>
            DoughnutChart,
            
            /// <summary>
            /// Enum PieChart for "PieChart"
            /// </summary>
            PieChart,
            
            /// <summary>
            /// Enum AreaChartArea for "AreaChartArea"
            /// </summary>
            AreaChartArea,
            
            /// <summary>
            /// Enum AreaChartPercentsStackedArea for "AreaChartPercentsStackedArea"
            /// </summary>
            AreaChartPercentsStackedArea,
            
            /// <summary>
            /// Enum AreaChartStackedArea for "AreaChartStackedArea"
            /// </summary>
            AreaChartStackedArea,
            
            /// <summary>
            /// Enum BarChartHorizClustered for "BarChartHorizClustered"
            /// </summary>
            BarChartHorizClustered,
            
            /// <summary>
            /// Enum BarChartHorizStacked for "BarChartHorizStacked"
            /// </summary>
            BarChartHorizStacked,
            
            /// <summary>
            /// Enum BarChartHorizPercentsStacked for "BarChartHorizPercentsStacked"
            /// </summary>
            BarChartHorizPercentsStacked,
            
            /// <summary>
            /// Enum BarChartVertClustered for "BarChartVertClustered"
            /// </summary>
            BarChartVertClustered,
            
            /// <summary>
            /// Enum BarChartVertStacked for "BarChartVertStacked"
            /// </summary>
            BarChartVertStacked,
            
            /// <summary>
            /// Enum BarChartVertPercentsStacked for "BarChartVertPercentsStacked"
            /// </summary>
            BarChartVertPercentsStacked,
            
            /// <summary>
            /// Enum LineChartLine for "LineChartLine"
            /// </summary>
            LineChartLine,
            
            /// <summary>
            /// Enum LineChartStackedLine for "LineChartStackedLine"
            /// </summary>
            LineChartStackedLine,
            
            /// <summary>
            /// Enum LineChartPercentsStackedLine for "LineChartPercentsStackedLine"
            /// </summary>
            LineChartPercentsStackedLine,
            
            /// <summary>
            /// Enum RadarChart for "RadarChart"
            /// </summary>
            RadarChart,
            
            /// <summary>
            /// Enum FilledRadarChart for "FilledRadarChart"
            /// </summary>
            FilledRadarChart,
            
            /// <summary>
            /// Enum StockHighLowClose for "StockHighLowClose"
            /// </summary>
            StockHighLowClose,
            
            /// <summary>
            /// Enum StockOpenHighLowClose for "StockOpenHighLowClose"
            /// </summary>
            StockOpenHighLowClose,
            
            /// <summary>
            /// Enum StockVolumeHighLowClose for "StockVolumeHighLowClose"
            /// </summary>
            StockVolumeHighLowClose,
            
            /// <summary>
            /// Enum StockVolumeOpenHighLowClose for "StockVolumeOpenHighLowClose"
            /// </summary>
            StockVolumeOpenHighLowClose,
            
            /// <summary>
            /// Enum ScatterStraightMarker for "ScatterStraightMarker"
            /// </summary>
            ScatterStraightMarker,
            
            /// <summary>
            /// Enum ScatterSmoothMarker for "ScatterSmoothMarker"
            /// </summary>
            ScatterSmoothMarker,
            
            /// <summary>
            /// Enum AreaChartArea3D for "AreaChartArea3D"
            /// </summary>
            AreaChartArea3D,
            
            /// <summary>
            /// Enum AreaChartStackedArea3D for "AreaChartStackedArea3D"
            /// </summary>
            AreaChartStackedArea3D,
            
            /// <summary>
            /// Enum AreaChartPercentsStackedArea3D for "AreaChartPercentsStackedArea3D"
            /// </summary>
            AreaChartPercentsStackedArea3D,
            
            /// <summary>
            /// Enum Line3DChart for "Line3DChart"
            /// </summary>
            Line3DChart,
            
            /// <summary>
            /// Enum Pie3DChart for "Pie3DChart"
            /// </summary>
            Pie3DChart,
            
            /// <summary>
            /// Enum Bar3DChartVert for "Bar3DChartVert"
            /// </summary>
            Bar3DChartVert,
            
            /// <summary>
            /// Enum Bar3DChartVertClustered for "Bar3DChartVertClustered"
            /// </summary>
            Bar3DChartVertClustered,
            
            /// <summary>
            /// Enum Bar3DChartVertPercentsStackedColumn3D for "Bar3DChartVertPercentsStackedColumn3D"
            /// </summary>
            Bar3DChartVertPercentsStackedColumn3D,
            
            /// <summary>
            /// Enum Bar3DChartVertPercentsStackedCone for "Bar3DChartVertPercentsStackedCone"
            /// </summary>
            Bar3DChartVertPercentsStackedCone,
            
            /// <summary>
            /// Enum Bar3DChartVertPercentsStackedCylinder for "Bar3DChartVertPercentsStackedCylinder"
            /// </summary>
            Bar3DChartVertPercentsStackedCylinder,
            
            /// <summary>
            /// Enum Bar3DChartVertPercentsStackedPyramid for "Bar3DChartVertPercentsStackedPyramid"
            /// </summary>
            Bar3DChartVertPercentsStackedPyramid,
            
            /// <summary>
            /// Enum Bar3DChartVertStackedColumn3D for "Bar3DChartVertStackedColumn3D"
            /// </summary>
            Bar3DChartVertStackedColumn3D,
            
            /// <summary>
            /// Enum Bar3DChartVertStackedCone for "Bar3DChartVertStackedCone"
            /// </summary>
            Bar3DChartVertStackedCone,
            
            /// <summary>
            /// Enum Bar3DChartVertStackedCylinder for "Bar3DChartVertStackedCylinder"
            /// </summary>
            Bar3DChartVertStackedCylinder,
            
            /// <summary>
            /// Enum Bar3DChartVertStackedPyramid for "Bar3DChartVertStackedPyramid"
            /// </summary>
            Bar3DChartVertStackedPyramid,
            
            /// <summary>
            /// Enum Bar3DChartHorizClustered for "Bar3DChartHorizClustered"
            /// </summary>
            Bar3DChartHorizClustered,
            
            /// <summary>
            /// Enum Bar3DChartHorizStackedBar3D for "Bar3DChartHorizStackedBar3D"
            /// </summary>
            Bar3DChartHorizStackedBar3D,
            
            /// <summary>
            /// Enum Bar3DChartHorizStackedCone for "Bar3DChartHorizStackedCone"
            /// </summary>
            Bar3DChartHorizStackedCone,
            
            /// <summary>
            /// Enum Bar3DChartHorizStackedCylinder for "Bar3DChartHorizStackedCylinder"
            /// </summary>
            Bar3DChartHorizStackedCylinder,
            
            /// <summary>
            /// Enum Bar3DChartHorizStackedPyramid for "Bar3DChartHorizStackedPyramid"
            /// </summary>
            Bar3DChartHorizStackedPyramid,
            
            /// <summary>
            /// Enum Bar3DChartHorizPercentsStackedBar3D for "Bar3DChartHorizPercentsStackedBar3D"
            /// </summary>
            Bar3DChartHorizPercentsStackedBar3D,
            
            /// <summary>
            /// Enum Bar3DChartHorizPercentsStackedCone for "Bar3DChartHorizPercentsStackedCone"
            /// </summary>
            Bar3DChartHorizPercentsStackedCone,
            
            /// <summary>
            /// Enum Bar3DChartHorizPercentsStackedCylinder for "Bar3DChartHorizPercentsStackedCylinder"
            /// </summary>
            Bar3DChartHorizPercentsStackedCylinder,
            
            /// <summary>
            /// Enum Bar3DChartHorizPercentsStackedPyramid for "Bar3DChartHorizPercentsStackedPyramid"
            /// </summary>
            Bar3DChartHorizPercentsStackedPyramid,
            
            /// <summary>
            /// Enum SurfaceChartContour for "SurfaceChartContour"
            /// </summary>
            SurfaceChartContour,
            
            /// <summary>
            /// Enum SurfaceChartWireframeContour for "SurfaceChartWireframeContour"
            /// </summary>
            SurfaceChartWireframeContour,
            
            /// <summary>
            /// Enum SurfaceChartSurface3D for "SurfaceChartSurface3D"
            /// </summary>
            SurfaceChartSurface3D,
            
            /// <summary>
            /// Enum SurfaceChartWireframeSurface3D for "SurfaceChartWireframeSurface3D"
            /// </summary>
            SurfaceChartWireframeSurface3D,
            
            /// <summary>
            /// Enum BubbleChart for "BubbleChart"
            /// </summary>
            BubbleChart,
            
            /// <summary>
            /// Enum HistogramChart for "HistogramChart"
            /// </summary>
            HistogramChart,
            
            /// <summary>
            /// Enum ParetoLineChart for "ParetoLineChart"
            /// </summary>
            ParetoLineChart,
            
            /// <summary>
            /// Enum BoxAndWhiskerChart for "BoxAndWhiskerChart"
            /// </summary>
            BoxAndWhiskerChart,
            
            /// <summary>
            /// Enum WaterfallChart for "WaterfallChart"
            /// </summary>
            WaterfallChart,
            
            /// <summary>
            /// Enum FunnelChart for "FunnelChart"
            /// </summary>
            FunnelChart,
            
            /// <summary>
            /// Enum TreemapChart for "TreemapChart"
            /// </summary>
            TreemapChart,
            
            /// <summary>
            /// Enum MapChart for "MapChart"
            /// </summary>
            MapChart,
            
            /// <summary>
            /// Enum SunburstChart for "SunburstChart"
            /// </summary>
            SunburstChart
        }

        /// <summary>
        /// Specifies how to determine which data points are in the second pie or bar  on a pie-of-pie or bar-of-pie chart.
        /// </summary>
        /// <value>Specifies how to determine which data points are in the second pie or bar  on a pie-of-pie or bar-of-pie chart.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PieSplitByEnum
        {
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            Default,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            Custom,
            
            /// <summary>
            /// Enum ByPercentage for "ByPercentage"
            /// </summary>
            ByPercentage,
            
            /// <summary>
            /// Enum ByPos for "ByPos"
            /// </summary>
            ByPos,
            
            /// <summary>
            /// Enum ByValue for "ByValue"
            /// </summary>
            ByValue
        }

        /// <summary>
        /// Specifies how the bubble size values are represented on the bubble chart. Read/write BubbleSizeRepresentationType.
        /// </summary>
        /// <value>Specifies how the bubble size values are represented on the bubble chart. Read/write BubbleSizeRepresentationType.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BubbleSizeRepresentationEnum
        {
            
            /// <summary>
            /// Enum Area for "Area"
            /// </summary>
            Area,
            
            /// <summary>
            /// Enum Width for "Width"
            /// </summary>
            Width
        }

        /// <summary>
        /// Returns a type of this series group.
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Specifies how to determine which data points are in the second pie or bar  on a pie-of-pie or bar-of-pie chart.
        /// </summary>
        public PieSplitByEnum? PieSplitBy { get; set; }

        /// <summary>
        /// Specifies how the bubble size values are represented on the bubble chart. Read/write BubbleSizeRepresentationType.
        /// </summary>
        public BubbleSizeRepresentationEnum? BubbleSizeRepresentation { get; set; }

        /// <summary>
        /// Specifies the space between bar or column clusters, as a percentage of the bar or column width.
        /// </summary>
        public int? GapWidth { get; set; }

        /// <summary>
        /// Returns or sets the distance, as a percentage of the marker width, between the data series in a 3D chart.
        /// </summary>
        public int? GapDepth { get; set; }

        /// <summary>
        /// Gets or sets the angle of the first pie or doughnut chart slice,  in degrees (clockwise from up, from 0 to 360 degrees).
        /// </summary>
        public int? FirstSliceAngle { get; set; }

        /// <summary>
        /// Specifies that each data marker in the series has a different color.
        /// </summary>
        public bool? IsColorVaried { get; set; }

        /// <summary>
        /// True if chart has series lines. Applied to stacked bar and OfPie charts.
        /// </summary>
        public bool? HasSeriesLines { get; set; }

        /// <summary>
        /// Specifies how much bars and columns shall overlap on 2-D charts (from -100 to 100).
        /// </summary>
        public int? Overlap { get; set; }

        /// <summary>
        /// Specifies the size of the second pie or bar of a pie-of-pie chart or  a bar-of-pie chart, as a percentage of the size of the first pie (can  be between 5 and 200 percents).
        /// </summary>
        public int? SecondPieSize { get; set; }

        /// <summary>
        /// Specifies a value that shall be used to determine which data points  are in the second pie or bar on a pie-of-pie or bar-of-pie chart.  Is used together with PieSplitBy property.
        /// </summary>
        public double? PieSplitPosition { get; set; }

        /// <summary>
        /// Specifies the size of the hole in a doughnut chart (can be between 10 and 90 percents  of the size of the plot area.).
        /// </summary>
        public int? DoughnutHoleSize { get; set; }

        /// <summary>
        /// Specifies the scale factor for the bubble chart (can be  between 0 and 300 percents of the default size). Read/write Int32.
        /// </summary>
        public int? BubbleSizeScale { get; set; }

        /// <summary>
        /// Specifies HiLowLines format.  HiLowLines applied with HiLowClose, OpenHiLowClose, VolumeHiLowClose and VolumeOpenHiLowClose chart types.
        /// </summary>
        public ChartLinesFormat HiLowLinesFormat { get; set; }


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
        public ChartSeriesGroup() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ChartSeriesGroup {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  GapWidth: ").Append(this.GapWidth).Append("\n");
            sb.Append("  GapDepth: ").Append(this.GapDepth).Append("\n");
            sb.Append("  FirstSliceAngle: ").Append(this.FirstSliceAngle).Append("\n");
            sb.Append("  IsColorVaried: ").Append(this.IsColorVaried).Append("\n");
            sb.Append("  HasSeriesLines: ").Append(this.HasSeriesLines).Append("\n");
            sb.Append("  Overlap: ").Append(this.Overlap).Append("\n");
            sb.Append("  SecondPieSize: ").Append(this.SecondPieSize).Append("\n");
            sb.Append("  PieSplitPosition: ").Append(this.PieSplitPosition).Append("\n");
            sb.Append("  PieSplitBy: ").Append(this.PieSplitBy).Append("\n");
            sb.Append("  DoughnutHoleSize: ").Append(this.DoughnutHoleSize).Append("\n");
            sb.Append("  BubbleSizeScale: ").Append(this.BubbleSizeScale).Append("\n");
            sb.Append("  HiLowLinesFormat: ").Append(this.HiLowLinesFormat).Append("\n");
            sb.Append("  BubbleSizeRepresentation: ").Append(this.BubbleSizeRepresentation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
