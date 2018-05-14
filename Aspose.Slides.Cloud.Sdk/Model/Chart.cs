// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Chart.cs">
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
  /// Represents chart resource
  /// </summary>  
  public class Chart : ShapeBase 
  {                       
        /// <summary>
        /// Gets or sets the type of the chart.
        /// </summary>
        public ChartType ChartType { get; set; }

        /// <summary>
        /// Gets or sets the series of chart data values.
        /// </summary>
        public List<Series> Series { get; set; }

        /// <summary>
        /// Gets or sets the categories for chart data
        /// </summary>
        public List<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public ChartTitle Title { get; set; }

        /// <summary>
        /// Gets or sets the back wall.
        /// </summary>
        public ChartWall BackWall { get; set; }

        /// <summary>
        /// Gets or sets the side wall.
        /// </summary>
        public ChartWall SideWall { get; set; }

        /// <summary>
        /// Gets or sets the floor.
        /// </summary>
        public ChartWall Floor { get; set; }

        /// <summary>
        /// Gets or sets the legend.
        /// </summary>
        public Legend Legend { get; set; }

        /// <summary>
        /// Gets or sets the axes.
        /// </summary>
        public Axes Axes { get; set; }

        /// <summary>
        /// Gets or sets the plot area.
        /// </summary>
        public PlotArea PlotArea { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Chart {\n");
          sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
          sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
          sb.Append("  Links: ").Append(this.Links).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  ShapeType: ").Append(this.ShapeType).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  AlternativeText: ").Append(this.AlternativeText).Append("\n");
          sb.Append("  Hidden: ").Append(this.Hidden).Append("\n");
          sb.Append("  X: ").Append(this.X).Append("\n");
          sb.Append("  Y: ").Append(this.Y).Append("\n");
          sb.Append("  ZOrderPosition: ").Append(this.ZOrderPosition).Append("\n");
          sb.Append("  Shapes: ").Append(this.Shapes).Append("\n");
          sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
          sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
          sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
          sb.Append("  ChartType: ").Append(this.ChartType).Append("\n");
          sb.Append("  Series: ").Append(this.Series).Append("\n");
          sb.Append("  Categories: ").Append(this.Categories).Append("\n");
          sb.Append("  Title: ").Append(this.Title).Append("\n");
          sb.Append("  BackWall: ").Append(this.BackWall).Append("\n");
          sb.Append("  SideWall: ").Append(this.SideWall).Append("\n");
          sb.Append("  Floor: ").Append(this.Floor).Append("\n");
          sb.Append("  Legend: ").Append(this.Legend).Append("\n");
          sb.Append("  Axes: ").Append(this.Axes).Append("\n");
          sb.Append("  PlotArea: ").Append(this.PlotArea).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
