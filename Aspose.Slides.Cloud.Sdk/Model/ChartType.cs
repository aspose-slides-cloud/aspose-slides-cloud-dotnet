// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartType.cs">
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
    /// Represents a type of chart.
    /// </summary>
    /// <value>Represents a type of chart.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChartType
    {
        
        /// <summary>
        /// Enum ClusteredColumn for "ClusteredColumn"
        /// </summary>
        ClusteredColumn,
        
        /// <summary>
        /// Enum StackedColumn for "StackedColumn"
        /// </summary>
        StackedColumn,
        
        /// <summary>
        /// Enum PercentsStackedColumn for "PercentsStackedColumn"
        /// </summary>
        PercentsStackedColumn,
        
        /// <summary>
        /// Enum ClusteredColumn3D for "ClusteredColumn3D"
        /// </summary>
        ClusteredColumn3D,
        
        /// <summary>
        /// Enum StackedColumn3D for "StackedColumn3D"
        /// </summary>
        StackedColumn3D,
        
        /// <summary>
        /// Enum PercentsStackedColumn3D for "PercentsStackedColumn3D"
        /// </summary>
        PercentsStackedColumn3D,
        
        /// <summary>
        /// Enum Column3D for "Column3D"
        /// </summary>
        Column3D,
        
        /// <summary>
        /// Enum ClusteredCylinder for "ClusteredCylinder"
        /// </summary>
        ClusteredCylinder,
        
        /// <summary>
        /// Enum StackedCylinder for "StackedCylinder"
        /// </summary>
        StackedCylinder,
        
        /// <summary>
        /// Enum PercentsStackedCylinder for "PercentsStackedCylinder"
        /// </summary>
        PercentsStackedCylinder,
        
        /// <summary>
        /// Enum Cylinder3D for "Cylinder3D"
        /// </summary>
        Cylinder3D,
        
        /// <summary>
        /// Enum ClusteredCone for "ClusteredCone"
        /// </summary>
        ClusteredCone,
        
        /// <summary>
        /// Enum StackedCone for "StackedCone"
        /// </summary>
        StackedCone,
        
        /// <summary>
        /// Enum PercentsStackedCone for "PercentsStackedCone"
        /// </summary>
        PercentsStackedCone,
        
        /// <summary>
        /// Enum Cone3D for "Cone3D"
        /// </summary>
        Cone3D,
        
        /// <summary>
        /// Enum ClusteredPyramid for "ClusteredPyramid"
        /// </summary>
        ClusteredPyramid,
        
        /// <summary>
        /// Enum StackedPyramid for "StackedPyramid"
        /// </summary>
        StackedPyramid,
        
        /// <summary>
        /// Enum PercentsStackedPyramid for "PercentsStackedPyramid"
        /// </summary>
        PercentsStackedPyramid,
        
        /// <summary>
        /// Enum Pyramid3D for "Pyramid3D"
        /// </summary>
        Pyramid3D,
        
        /// <summary>
        /// Enum Line for "Line"
        /// </summary>
        Line,
        
        /// <summary>
        /// Enum StackedLine for "StackedLine"
        /// </summary>
        StackedLine,
        
        /// <summary>
        /// Enum PercentsStackedLine for "PercentsStackedLine"
        /// </summary>
        PercentsStackedLine,
        
        /// <summary>
        /// Enum LineWithMarkers for "LineWithMarkers"
        /// </summary>
        LineWithMarkers,
        
        /// <summary>
        /// Enum StackedLineWithMarkers for "StackedLineWithMarkers"
        /// </summary>
        StackedLineWithMarkers,
        
        /// <summary>
        /// Enum PercentsStackedLineWithMarkers for "PercentsStackedLineWithMarkers"
        /// </summary>
        PercentsStackedLineWithMarkers,
        
        /// <summary>
        /// Enum Line3D for "Line3D"
        /// </summary>
        Line3D,
        
        /// <summary>
        /// Enum Pie for "Pie"
        /// </summary>
        Pie,
        
        /// <summary>
        /// Enum Pie3D for "Pie3D"
        /// </summary>
        Pie3D,
        
        /// <summary>
        /// Enum PieOfPie for "PieOfPie"
        /// </summary>
        PieOfPie,
        
        /// <summary>
        /// Enum ExplodedPie for "ExplodedPie"
        /// </summary>
        ExplodedPie,
        
        /// <summary>
        /// Enum ExplodedPie3D for "ExplodedPie3D"
        /// </summary>
        ExplodedPie3D,
        
        /// <summary>
        /// Enum BarOfPie for "BarOfPie"
        /// </summary>
        BarOfPie,
        
        /// <summary>
        /// Enum PercentsStackedBar for "PercentsStackedBar"
        /// </summary>
        PercentsStackedBar,
        
        /// <summary>
        /// Enum ClusteredBar3D for "ClusteredBar3D"
        /// </summary>
        ClusteredBar3D,
        
        /// <summary>
        /// Enum ClusteredBar for "ClusteredBar"
        /// </summary>
        ClusteredBar,
        
        /// <summary>
        /// Enum StackedBar for "StackedBar"
        /// </summary>
        StackedBar,
        
        /// <summary>
        /// Enum StackedBar3D for "StackedBar3D"
        /// </summary>
        StackedBar3D,
        
        /// <summary>
        /// Enum PercentsStackedBar3D for "PercentsStackedBar3D"
        /// </summary>
        PercentsStackedBar3D,
        
        /// <summary>
        /// Enum ClusteredHorizontalCylinder for "ClusteredHorizontalCylinder"
        /// </summary>
        ClusteredHorizontalCylinder,
        
        /// <summary>
        /// Enum StackedHorizontalCylinder for "StackedHorizontalCylinder"
        /// </summary>
        StackedHorizontalCylinder,
        
        /// <summary>
        /// Enum PercentsStackedHorizontalCylinder for "PercentsStackedHorizontalCylinder"
        /// </summary>
        PercentsStackedHorizontalCylinder,
        
        /// <summary>
        /// Enum ClusteredHorizontalCone for "ClusteredHorizontalCone"
        /// </summary>
        ClusteredHorizontalCone,
        
        /// <summary>
        /// Enum StackedHorizontalCone for "StackedHorizontalCone"
        /// </summary>
        StackedHorizontalCone,
        
        /// <summary>
        /// Enum PercentsStackedHorizontalCone for "PercentsStackedHorizontalCone"
        /// </summary>
        PercentsStackedHorizontalCone,
        
        /// <summary>
        /// Enum ClusteredHorizontalPyramid for "ClusteredHorizontalPyramid"
        /// </summary>
        ClusteredHorizontalPyramid,
        
        /// <summary>
        /// Enum StackedHorizontalPyramid for "StackedHorizontalPyramid"
        /// </summary>
        StackedHorizontalPyramid,
        
        /// <summary>
        /// Enum PercentsStackedHorizontalPyramid for "PercentsStackedHorizontalPyramid"
        /// </summary>
        PercentsStackedHorizontalPyramid,
        
        /// <summary>
        /// Enum Area for "Area"
        /// </summary>
        Area,
        
        /// <summary>
        /// Enum StackedArea for "StackedArea"
        /// </summary>
        StackedArea,
        
        /// <summary>
        /// Enum PercentsStackedArea for "PercentsStackedArea"
        /// </summary>
        PercentsStackedArea,
        
        /// <summary>
        /// Enum Area3D for "Area3D"
        /// </summary>
        Area3D,
        
        /// <summary>
        /// Enum StackedArea3D for "StackedArea3D"
        /// </summary>
        StackedArea3D,
        
        /// <summary>
        /// Enum PercentsStackedArea3D for "PercentsStackedArea3D"
        /// </summary>
        PercentsStackedArea3D,
        
        /// <summary>
        /// Enum ScatterWithMarkers for "ScatterWithMarkers"
        /// </summary>
        ScatterWithMarkers,
        
        /// <summary>
        /// Enum ScatterWithSmoothLinesAndMarkers for "ScatterWithSmoothLinesAndMarkers"
        /// </summary>
        ScatterWithSmoothLinesAndMarkers,
        
        /// <summary>
        /// Enum ScatterWithSmoothLines for "ScatterWithSmoothLines"
        /// </summary>
        ScatterWithSmoothLines,
        
        /// <summary>
        /// Enum ScatterWithStraightLinesAndMarkers for "ScatterWithStraightLinesAndMarkers"
        /// </summary>
        ScatterWithStraightLinesAndMarkers,
        
        /// <summary>
        /// Enum ScatterWithStraightLines for "ScatterWithStraightLines"
        /// </summary>
        ScatterWithStraightLines,
        
        /// <summary>
        /// Enum HighLowClose for "HighLowClose"
        /// </summary>
        HighLowClose,
        
        /// <summary>
        /// Enum OpenHighLowClose for "OpenHighLowClose"
        /// </summary>
        OpenHighLowClose,
        
        /// <summary>
        /// Enum VolumeHighLowClose for "VolumeHighLowClose"
        /// </summary>
        VolumeHighLowClose,
        
        /// <summary>
        /// Enum VolumeOpenHighLowClose for "VolumeOpenHighLowClose"
        /// </summary>
        VolumeOpenHighLowClose,
        
        /// <summary>
        /// Enum Surface3D for "Surface3D"
        /// </summary>
        Surface3D,
        
        /// <summary>
        /// Enum WireframeSurface3D for "WireframeSurface3D"
        /// </summary>
        WireframeSurface3D,
        
        /// <summary>
        /// Enum Contour for "Contour"
        /// </summary>
        Contour,
        
        /// <summary>
        /// Enum WireframeContour for "WireframeContour"
        /// </summary>
        WireframeContour,
        
        /// <summary>
        /// Enum Doughnut for "Doughnut"
        /// </summary>
        Doughnut,
        
        /// <summary>
        /// Enum ExplodedDoughnut for "ExplodedDoughnut"
        /// </summary>
        ExplodedDoughnut,
        
        /// <summary>
        /// Enum Bubble for "Bubble"
        /// </summary>
        Bubble,
        
        /// <summary>
        /// Enum BubbleWith3D for "BubbleWith3D"
        /// </summary>
        BubbleWith3D,
        
        /// <summary>
        /// Enum Radar for "Radar"
        /// </summary>
        Radar,
        
        /// <summary>
        /// Enum RadarWithMarkers for "RadarWithMarkers"
        /// </summary>
        RadarWithMarkers,
        
        /// <summary>
        /// Enum FilledRadar for "FilledRadar"
        /// </summary>
        FilledRadar,
        
        /// <summary>
        /// Enum SeriesOfMixedTypes for "SeriesOfMixedTypes"
        /// </summary>
        SeriesOfMixedTypes
    }

}
