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
  /// 
  /// </summary>  
  public class Axis 
  {                       
        /// <summary>
        /// Gets or sets IsVisible
        /// </summary>
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or sets HasTitle
        /// </summary>
        public bool? HasTitle { get; set; }

        /// <summary>
        /// Gets or sets Position
        /// </summary>
        public AxisPositionType Position { get; set; }

        /// <summary>
        /// Gets or sets DisplayUnit
        /// </summary>
        public DisplayUnitType DisplayUnit { get; set; }

        /// <summary>
        /// Gets or sets BaseUnitScale
        /// </summary>
        public TimeUnitType BaseUnitScale { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticMajorUnit
        /// </summary>
        public bool? IsAutomaticMajorUnit { get; set; }

        /// <summary>
        /// Gets or sets MajorUnit
        /// </summary>
        public double? MajorUnit { get; set; }

        /// <summary>
        /// Gets or sets MajorUnitScale
        /// </summary>
        public TimeUnitType MajorUnitScale { get; set; }

        /// <summary>
        /// Gets or sets MajorTickMark
        /// </summary>
        public TickMarkType MajorTickMark { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticMinorUnit
        /// </summary>
        public bool? IsAutomaticMinorUnit { get; set; }

        /// <summary>
        /// Gets or sets MinorUnit
        /// </summary>
        public double? MinorUnit { get; set; }

        /// <summary>
        /// Gets or sets MinorUnitScale
        /// </summary>
        public TimeUnitType MinorUnitScale { get; set; }

        /// <summary>
        /// Gets or sets MinorTickMark
        /// </summary>
        public TickMarkType MinorTickMark { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticMaxValue
        /// </summary>
        public bool? IsAutomaticMaxValue { get; set; }

        /// <summary>
        /// Gets or sets MaxValue
        /// </summary>
        public double? MaxValue { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticMinValue
        /// </summary>
        public bool? IsAutomaticMinValue { get; set; }

        /// <summary>
        /// Gets or sets MinValue
        /// </summary>
        public double? MinValue { get; set; }

        /// <summary>
        /// Gets or sets IsLogarithmic
        /// </summary>
        public bool? IsLogarithmic { get; set; }

        /// <summary>
        /// Gets or sets LogBase
        /// </summary>
        public double? LogBase { get; set; }

        /// <summary>
        /// Gets or sets CategoryAxisType
        /// </summary>
        public CategoryAxisType CategoryAxisType { get; set; }

        /// <summary>
        /// Gets or sets AxisBetweenCategories
        /// </summary>
        public bool? AxisBetweenCategories { get; set; }

        /// <summary>
        /// Gets or sets LabelOffset
        /// </summary>
        public int? LabelOffset { get; set; }

        /// <summary>
        /// Gets or sets IsPlotOrderReversed
        /// </summary>
        public bool? IsPlotOrderReversed { get; set; }

        /// <summary>
        /// Gets or sets IsNumberFormatLinkedToSource
        /// </summary>
        public bool? IsNumberFormatLinkedToSource { get; set; }

        /// <summary>
        /// Gets or sets NumberFormat
        /// </summary>
        public string NumberFormat { get; set; }

        /// <summary>
        /// Gets or sets CrossType
        /// </summary>
        public CrossesType CrossType { get; set; }

        /// <summary>
        /// Gets or sets CrossAt
        /// </summary>
        public double? CrossAt { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticTickMarksSpacing
        /// </summary>
        public bool? IsAutomaticTickMarksSpacing { get; set; }

        /// <summary>
        /// Gets or sets TickMarksSpacing
        /// </summary>
        public int? TickMarksSpacing { get; set; }

        /// <summary>
        /// Gets or sets IsAutomaticTickLabelSpacing
        /// </summary>
        public bool? IsAutomaticTickLabelSpacing { get; set; }

        /// <summary>
        /// Gets or sets TickLabelSpacing
        /// </summary>
        public int? TickLabelSpacing { get; set; }

        /// <summary>
        /// Gets or sets TickLabelPosition
        /// </summary>
        public TickLabelPositionType TickLabelPosition { get; set; }

        /// <summary>
        /// Gets or sets TickLabelRotationAngle
        /// </summary>
        public double? TickLabelRotationAngle { get; set; }

        /// <summary>
        /// Gets or sets FillFormat
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Gets or sets EffectFormat
        /// </summary>
        public EffectFormat EffectFormat { get; set; }

        /// <summary>
        /// Gets or sets LineFormat
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
