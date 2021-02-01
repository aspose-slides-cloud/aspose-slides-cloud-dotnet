// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ViewProperties.cs">
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
    /// Slides document properties.
    /// </summary>  
    public class ViewProperties : ResourceBase 
    {                       
        /// <summary>
        /// Last used view mode.
        /// </summary>
        /// <value>Last used view mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LastViewEnum
        {
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined,
            
            /// <summary>
            /// Enum SlideView for "SlideView"
            /// </summary>
            SlideView,
            
            /// <summary>
            /// Enum SlideMasterView for "SlideMasterView"
            /// </summary>
            SlideMasterView,
            
            /// <summary>
            /// Enum NotesView for "NotesView"
            /// </summary>
            NotesView,
            
            /// <summary>
            /// Enum HandoutView for "HandoutView"
            /// </summary>
            HandoutView,
            
            /// <summary>
            /// Enum NotesMasterView for "NotesMasterView"
            /// </summary>
            NotesMasterView,
            
            /// <summary>
            /// Enum OutlineView for "OutlineView"
            /// </summary>
            OutlineView,
            
            /// <summary>
            /// Enum SlideSorterView for "SlideSorterView"
            /// </summary>
            SlideSorterView,
            
            /// <summary>
            /// Enum SlideThumbnailView for "SlideThumbnailView"
            /// </summary>
            SlideThumbnailView
        }

        /// <summary>
        /// Horizontal bar state.
        /// </summary>
        /// <value>Horizontal bar state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HorizontalBarStateEnum
        {
            
            /// <summary>
            /// Enum Minimized for "Minimized"
            /// </summary>
            Minimized,
            
            /// <summary>
            /// Enum Restored for "Restored"
            /// </summary>
            Restored,
            
            /// <summary>
            /// Enum Maximized for "Maximized"
            /// </summary>
            Maximized
        }

        /// <summary>
        /// Vertical bar state.
        /// </summary>
        /// <value>Vertical bar state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalBarStateEnum
        {
            
            /// <summary>
            /// Enum Minimized for "Minimized"
            /// </summary>
            Minimized,
            
            /// <summary>
            /// Enum Restored for "Restored"
            /// </summary>
            Restored,
            
            /// <summary>
            /// Enum Maximized for "Maximized"
            /// </summary>
            Maximized
        }

        /// <summary>
        /// True if the comments should be shown.
        /// </summary>
        /// <value>True if the comments should be shown.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShowCommentsEnum
        {
            
            /// <summary>
            /// Enum False for "False"
            /// </summary>
            False,
            
            /// <summary>
            /// Enum True for "True"
            /// </summary>
            True,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Last used view mode.
        /// </summary>
        public LastViewEnum? LastView { get; set; }

        /// <summary>
        /// Horizontal bar state.
        /// </summary>
        public HorizontalBarStateEnum? HorizontalBarState { get; set; }

        /// <summary>
        /// Vertical bar state.
        /// </summary>
        public VerticalBarStateEnum? VerticalBarState { get; set; }

        /// <summary>
        /// True if the comments should be shown.
        /// </summary>
        public ShowCommentsEnum? ShowComments { get; set; }

        /// <summary>
        /// True to prefer single view.
        /// </summary>
        public bool? PreferSingleView { get; set; }

        /// <summary>
        /// The sizing of the side content region of the normal view, when the region is of a variable restored size.
        /// </summary>
        public NormalViewRestoredProperties RestoredLeft { get; set; }

        /// <summary>
        /// The sizing of the top slide region of the normal view, when the region is of a variable restored size.
        /// </summary>
        public NormalViewRestoredProperties RestoredTop { get; set; }

        /// <summary>
        /// Slide view mode properties.
        /// </summary>
        public CommonSlideViewProperties SlideViewProperties { get; set; }

        /// <summary>
        /// Notes view mode properties.
        /// </summary>
        public CommonSlideViewProperties NotesViewProperties { get; set; }


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
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public ViewProperties() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ViewProperties {\n");
            sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
            sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
            sb.Append("  LastView: ").Append(this.LastView).Append("\n");
            sb.Append("  HorizontalBarState: ").Append(this.HorizontalBarState).Append("\n");
            sb.Append("  VerticalBarState: ").Append(this.VerticalBarState).Append("\n");
            sb.Append("  PreferSingleView: ").Append(this.PreferSingleView).Append("\n");
            sb.Append("  RestoredLeft: ").Append(this.RestoredLeft).Append("\n");
            sb.Append("  RestoredTop: ").Append(this.RestoredTop).Append("\n");
            sb.Append("  SlideViewProperties: ").Append(this.SlideViewProperties).Append("\n");
            sb.Append("  NotesViewProperties: ").Append(this.NotesViewProperties).Append("\n");
            sb.Append("  ShowComments: ").Append(this.ShowComments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
