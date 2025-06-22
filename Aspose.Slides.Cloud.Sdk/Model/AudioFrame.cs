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
        /// Returns or sets the audio play mode.
        /// </summary>
        /// <value>Returns or sets the audio play mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlayModeEnum
        {
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>
            Auto,
            
            /// <summary>
            /// Enum OnClick for "OnClick"
            /// </summary>
            OnClick,
            
            /// <summary>
            /// Enum AllSlides for "AllSlides"
            /// </summary>
            AllSlides,
            
            /// <summary>
            /// Enum InClickSequence for "InClickSequence"
            /// </summary>
            InClickSequence,
            
            /// <summary>
            /// Enum Mixed for "Mixed"
            /// </summary>
            Mixed
        }

        /// <summary>
        /// Returns or sets the audio volume.
        /// </summary>
        /// <value>Returns or sets the audio volume.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VolumeEnum
        {
            
            /// <summary>
            /// Enum Mute for "Mute"
            /// </summary>
            Mute,
            
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>
            Low,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>
            Medium,
            
            /// <summary>
            /// Enum Loud for "Loud"
            /// </summary>
            Loud,
            
            /// <summary>
            /// Enum Mixed for "Mixed"
            /// </summary>
            Mixed
        }

        /// <summary>
        /// Returns or sets the audio play mode.
        /// </summary>
        public PlayModeEnum? PlayMode { get; set; }

        /// <summary>
        /// Returns or sets the audio volume.
        /// </summary>
        public VolumeEnum? Volume { get; set; }

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
        /// Audio volume percent.
        /// </summary>
        public double? VolumeValue { get; set; }

        /// <summary>
        /// Audio data encoded in base64.
        /// </summary>
        public string Base64Data { get; set; }

        /// <summary>
        /// Determines whether an audio is playing across the slides.
        /// </summary>
        public bool? PlayAcrossSlides { get; set; }

        /// <summary>
        /// Determines whether audio is automatically rewound to start after playing.
        /// </summary>
        public bool? RewindAudio { get; set; }

        /// <summary>
        /// Time duration for the initial fade-in of the media in milliseconds.
        /// </summary>
        public double? FadeInDuration { get; set; }

        /// <summary>
        /// Time duration for the ending fade-out of the media in milliseconds.
        /// </summary>
        public double? FadeOutDuration { get; set; }

        /// <summary>
        /// Time duration to be removed from the beginning of the media during playback in milliseconds.
        /// </summary>
        public double? TrimFromStart { get; set; }

        /// <summary>
        /// Time duration to be removed from the end of the media during playback in milliseconds.
        /// </summary>
        public double? TrimFromEnd { get; set; }

        /// <summary>
        /// Picture fill format.
        /// </summary>
        public PictureFill PictureFillFormat { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.AudioFrame);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public AudioFrame() : base()
        {
            Type = TypeEnum.AudioFrame;
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
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  AlternativeText: ").Append(this.AlternativeText).Append("\n");
            sb.Append("  AlternativeTextTitle: ").Append(this.AlternativeTextTitle).Append("\n");
            sb.Append("  Hidden: ").Append(this.Hidden).Append("\n");
            sb.Append("  IsDecorative: ").Append(this.IsDecorative).Append("\n");
            sb.Append("  X: ").Append(this.X).Append("\n");
            sb.Append("  Y: ").Append(this.Y).Append("\n");
            sb.Append("  ZOrderPosition: ").Append(this.ZOrderPosition).Append("\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
            sb.Append("  ThreeDFormat: ").Append(this.ThreeDFormat).Append("\n");
            sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
            sb.Append("  HyperlinkClick: ").Append(this.HyperlinkClick).Append("\n");
            sb.Append("  HyperlinkMouseOver: ").Append(this.HyperlinkMouseOver).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ShapeType: ").Append(this.ShapeType).Append("\n");
            sb.Append("  AudioCdEndTrack: ").Append(this.AudioCdEndTrack).Append("\n");
            sb.Append("  AudioCdEndTrackTime: ").Append(this.AudioCdEndTrackTime).Append("\n");
            sb.Append("  AudioCdStartTrack: ").Append(this.AudioCdStartTrack).Append("\n");
            sb.Append("  AudioCdStartTrackTime: ").Append(this.AudioCdStartTrackTime).Append("\n");
            sb.Append("  Embedded: ").Append(this.Embedded).Append("\n");
            sb.Append("  HideAtShowing: ").Append(this.HideAtShowing).Append("\n");
            sb.Append("  PlayLoopMode: ").Append(this.PlayLoopMode).Append("\n");
            sb.Append("  PlayMode: ").Append(this.PlayMode).Append("\n");
            sb.Append("  Volume: ").Append(this.Volume).Append("\n");
            sb.Append("  VolumeValue: ").Append(this.VolumeValue).Append("\n");
            sb.Append("  Base64Data: ").Append(this.Base64Data).Append("\n");
            sb.Append("  PlayAcrossSlides: ").Append(this.PlayAcrossSlides).Append("\n");
            sb.Append("  RewindAudio: ").Append(this.RewindAudio).Append("\n");
            sb.Append("  FadeInDuration: ").Append(this.FadeInDuration).Append("\n");
            sb.Append("  FadeOutDuration: ").Append(this.FadeOutDuration).Append("\n");
            sb.Append("  TrimFromStart: ").Append(this.TrimFromStart).Append("\n");
            sb.Append("  TrimFromEnd: ").Append(this.TrimFromEnd).Append("\n");
            sb.Append("  PictureFillFormat: ").Append(this.PictureFillFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
