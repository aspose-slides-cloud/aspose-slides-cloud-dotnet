// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AudioFrame.cs">
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
  /// Represents AudioFrame resource.
  /// </summary>  
  public class AudioFrame : GeometryShape 
  {                       
        /// <summary>
        /// Returns or sets a last track index.
        /// </summary>
        public int? AudioCdEndTrack { get; set; }

        /// <summary>
        /// Returns or sets a last track time.
        /// </summary>
        public int? AudioCdEndTrackTime { get; set; }

        /// <summary>
        /// Returns or sets a start track index.
        /// </summary>
        public int? AudioCdStartTrack { get; set; }

        /// <summary>
        /// Returns or sets a start track time. 
        /// </summary>
        public int? AudioCdStartTrackTime { get; set; }

        /// <summary>
        /// Determines whether a sound is embedded to a presentation.
        /// </summary>
        public bool? Embedded { get; set; }

        /// <summary>
        /// Determines whether an AudioFrame is hidden.
        /// </summary>
        public bool? HideAtShowing { get; set; }

        /// <summary>
        /// Determines whether an audio is looped. 
        /// </summary>
        public bool? PlayLoopMode { get; set; }

        /// <summary>
        /// Returns or sets the audio play mode.
        /// </summary>
        public AudioPlayModePreset PlayMode { get; set; }

        /// <summary>
        /// Returns or sets the audio volume.
        /// </summary>
        public AudioVolumeMode Volume { get; set; }

        /// <summary>
        /// Audio data encoded in base64.
        /// </summary>
        public string Base64Data { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public AudioFrame() : base()
        {
          Type = Model.ShapeType.AudioFrame;
          ShapeType = Model.CombinedShapeType.AudioFrame;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AudioFrame {\n");
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
          sb.Append("  GeometryShapeType: ").Append(this.GeometryShapeType).Append("\n");
          sb.Append("  AudioCdEndTrack: ").Append(this.AudioCdEndTrack).Append("\n");
          sb.Append("  AudioCdEndTrackTime: ").Append(this.AudioCdEndTrackTime).Append("\n");
          sb.Append("  AudioCdStartTrack: ").Append(this.AudioCdStartTrack).Append("\n");
          sb.Append("  AudioCdStartTrackTime: ").Append(this.AudioCdStartTrackTime).Append("\n");
          sb.Append("  Embedded: ").Append(this.Embedded).Append("\n");
          sb.Append("  HideAtShowing: ").Append(this.HideAtShowing).Append("\n");
          sb.Append("  PlayLoopMode: ").Append(this.PlayLoopMode).Append("\n");
          sb.Append("  PlayMode: ").Append(this.PlayMode).Append("\n");
          sb.Append("  Volume: ").Append(this.Volume).Append("\n");
          sb.Append("  Base64Data: ").Append(this.Base64Data).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
