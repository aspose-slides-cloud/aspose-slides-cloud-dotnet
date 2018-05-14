// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Axis.cs">
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
  /// Represents a chart axis
  /// </summary>  
  public class Axis 
  {                       
        /// <summary>
        /// True if the axis is visible
        /// </summary>
        public bool? IsVisible { get; set; }

        /// <summary>
        /// True if the axis has a visible title
        /// </summary>
        public bool? HasTitle { get; set; }

        /// <summary>
        /// Axis position
        /// </summary>
        public AxisPositionType Position { get; set; }

        /// <summary>
        /// The scaling value of the display units for the value axis
        /// </summary>
        public DisplayUnitType DisplayUnit { get; set; }

        /// <summary>
        /// The smallest time unit that is represented on the date axis
        /// </summary>
        public TimeUnitType BaseUnitScale { get; set; }

        /// <summary>
        /// True the major unit of the axis is automatically assigned
        /// </summary>
        public bool? IsAutomaticMajorUnit { get; set; }

        /// <summary>
        /// The major units for the date or value axis
        /// </summary>
        public double? MajorUnit { get; set; }

        /// <summary>
        /// The major unit scale for the date axis
        /// </summary>
        public TimeUnitType MajorUnitScale { get; set; }

        /// <summary>
        /// The type of major tick mark for the specified axis
        /// </summary>
        public TickMarkType MajorTickMark { get; set; }

        /// <summary>
        /// True the minor unit of the axis is automatically assigned
        /// </summary>
        public bool? IsAutomaticMinorUnit { get; set; }

        /// <summary>
        /// The minor units for the date or value axis
        /// </summary>
        public double? MinorUnit { get; set; }

        /// <summary>
        /// The minor unit scale for the date axis
        /// </summary>
        public TimeUnitType MinorUnitScale { get; set; }

        /// <summary>
        /// The type of minor tick mark for the specified axis
        /// </summary>
        public TickMarkType MinorTickMark { get; set; }

        /// <summary>
        /// True if the max value is automatically assigned
        /// </summary>
        public bool? IsAutomaticMaxValue { get; set; }

        /// <summary>
        /// The maximum value on the value axis
        /// </summary>
        public double? MaxValue { get; set; }

        /// <summary>
        /// True if the min value is automatically assigned
        /// </summary>
        public bool? IsAutomaticMinValue { get; set; }

        /// <summary>
        /// The minimum value on the value axis
        /// </summary>
        public double? MinValue { get; set; }

        /// <summary>
        /// True if the value axis scale type is logarithmic
        /// </summary>
        public bool? IsLogarithmic { get; set; }

        /// <summary>
        /// The logarithmic base. Default value is 10
        /// </summary>
        public double? LogBase { get; set; }

        /// <summary>
        /// The type of the category axis
        /// </summary>
        public CategoryAxisType CategoryAxisType { get; set; }

        /// <summary>
        /// True if the value axis crosses the category axis between categories. This property applies only to category axes, and it doesn't apply to 3-D charts
        /// </summary>
        public bool? AxisBetweenCategories { get; set; }

        /// <summary>
        /// The distance of labels from the axis. Applied to category or date axis. Value must be between 0% and 1000%.             
        /// </summary>
        public int? LabelOffset { get; set; }

        /// <summary>
        /// True if MS PowerPoint plots data points from last to first
        /// </summary>
        public bool? IsPlotOrderReversed { get; set; }

        /// <summary>
        /// True if the format is linked to source data
        /// </summary>
        public bool? IsNumberFormatLinkedToSource { get; set; }

        /// <summary>
        /// the format string for the Axis Labels
        /// </summary>
        public string NumberFormat { get; set; }

        /// <summary>
        /// The CrossType on the specified axis where the other axis crosses
        /// </summary>
        public CrossesType CrossType { get; set; }

        /// <summary>
        /// The point on the axis where the perpendicular axis crosses it
        /// </summary>
        public double? CrossAt { get; set; }

        /// <summary>
        /// True for automatic tick marks spacing value
        /// </summary>
        public bool? IsAutomaticTickMarksSpacing { get; set; }

        /// <summary>
        /// Specifies how many tick marks shall be skipped before the next one shall be drawn. Applied to category or series axis.
        /// </summary>
        public int? TickMarksSpacing { get; set; }

        /// <summary>
        /// True for automatic tick label spacing value
        /// </summary>
        public bool? IsAutomaticTickLabelSpacing { get; set; }

        /// <summary>
        /// Specifies how many tick labels to skip between label that is drawn.
        /// </summary>
        public int? TickLabelSpacing { get; set; }

        /// <summary>
        /// The position of tick-mark labels on the specified axis.
        /// </summary>
        public TickLabelPositionType TickLabelPosition { get; set; }

        /// <summary>
        /// Represents the rotation angle of tick labels.
        /// </summary>
        public double? TickLabelRotationAngle { get; set; }

        /// <summary>
        /// Get or sets the fill format.
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Get or sets the effect format.
        /// </summary>
        public EffectFormat EffectFormat { get; set; }

        /// <summary>
        /// Get or sets the line format.
        /// </summary>
        public LineFormat LineFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Axis {\n");
          sb.Append("  IsVisible: ").Append(this.IsVisible).Append("\n");
          sb.Append("  HasTitle: ").Append(this.HasTitle).Append("\n");
          sb.Append("  Position: ").Append(this.Position).Append("\n");
          sb.Append("  DisplayUnit: ").Append(this.DisplayUnit).Append("\n");
          sb.Append("  BaseUnitScale: ").Append(this.BaseUnitScale).Append("\n");
          sb.Append("  IsAutomaticMajorUnit: ").Append(this.IsAutomaticMajorUnit).Append("\n");
          sb.Append("  MajorUnit: ").Append(this.MajorUnit).Append("\n");
          sb.Append("  MajorUnitScale: ").Append(this.MajorUnitScale).Append("\n");
          sb.Append("  MajorTickMark: ").Append(this.MajorTickMark).Append("\n");
          sb.Append("  IsAutomaticMinorUnit: ").Append(this.IsAutomaticMinorUnit).Append("\n");
          sb.Append("  MinorUnit: ").Append(this.MinorUnit).Append("\n");
          sb.Append("  MinorUnitScale: ").Append(this.MinorUnitScale).Append("\n");
          sb.Append("  MinorTickMark: ").Append(this.MinorTickMark).Append("\n");
          sb.Append("  IsAutomaticMaxValue: ").Append(this.IsAutomaticMaxValue).Append("\n");
          sb.Append("  MaxValue: ").Append(this.MaxValue).Append("\n");
          sb.Append("  IsAutomaticMinValue: ").Append(this.IsAutomaticMinValue).Append("\n");
          sb.Append("  MinValue: ").Append(this.MinValue).Append("\n");
          sb.Append("  IsLogarithmic: ").Append(this.IsLogarithmic).Append("\n");
          sb.Append("  LogBase: ").Append(this.LogBase).Append("\n");
          sb.Append("  CategoryAxisType: ").Append(this.CategoryAxisType).Append("\n");
          sb.Append("  AxisBetweenCategories: ").Append(this.AxisBetweenCategories).Append("\n");
          sb.Append("  LabelOffset: ").Append(this.LabelOffset).Append("\n");
          sb.Append("  IsPlotOrderReversed: ").Append(this.IsPlotOrderReversed).Append("\n");
          sb.Append("  IsNumberFormatLinkedToSource: ").Append(this.IsNumberFormatLinkedToSource).Append("\n");
          sb.Append("  NumberFormat: ").Append(this.NumberFormat).Append("\n");
          sb.Append("  CrossType: ").Append(this.CrossType).Append("\n");
          sb.Append("  CrossAt: ").Append(this.CrossAt).Append("\n");
          sb.Append("  IsAutomaticTickMarksSpacing: ").Append(this.IsAutomaticTickMarksSpacing).Append("\n");
          sb.Append("  TickMarksSpacing: ").Append(this.TickMarksSpacing).Append("\n");
          sb.Append("  IsAutomaticTickLabelSpacing: ").Append(this.IsAutomaticTickLabelSpacing).Append("\n");
          sb.Append("  TickLabelSpacing: ").Append(this.TickLabelSpacing).Append("\n");
          sb.Append("  TickLabelPosition: ").Append(this.TickLabelPosition).Append("\n");
          sb.Append("  TickLabelRotationAngle: ").Append(this.TickLabelRotationAngle).Append("\n");
          sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
          sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
          sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
