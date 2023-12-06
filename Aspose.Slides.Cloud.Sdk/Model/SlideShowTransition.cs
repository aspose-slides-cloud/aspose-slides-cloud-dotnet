// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SlideShowTransition.cs">
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
    /// Slide Show Transition.
    /// </summary>  
    public class SlideShowTransition 
    {                       
        /// <summary>
        /// Transition Type
        /// </summary>
        /// <value>Transition Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Blinds for "Blinds"
            /// </summary>
            Blinds,
            
            /// <summary>
            /// Enum Checker for "Checker"
            /// </summary>
            Checker,
            
            /// <summary>
            /// Enum Circle for "Circle"
            /// </summary>
            Circle,
            
            /// <summary>
            /// Enum Comb for "Comb"
            /// </summary>
            Comb,
            
            /// <summary>
            /// Enum Cover for "Cover"
            /// </summary>
            Cover,
            
            /// <summary>
            /// Enum Cut for "Cut"
            /// </summary>
            Cut,
            
            /// <summary>
            /// Enum Diamond for "Diamond"
            /// </summary>
            Diamond,
            
            /// <summary>
            /// Enum Dissolve for "Dissolve"
            /// </summary>
            Dissolve,
            
            /// <summary>
            /// Enum Fade for "Fade"
            /// </summary>
            Fade,
            
            /// <summary>
            /// Enum Newsflash for "Newsflash"
            /// </summary>
            Newsflash,
            
            /// <summary>
            /// Enum Plus for "Plus"
            /// </summary>
            Plus,
            
            /// <summary>
            /// Enum Pull for "Pull"
            /// </summary>
            Pull,
            
            /// <summary>
            /// Enum Push for "Push"
            /// </summary>
            Push,
            
            /// <summary>
            /// Enum Random for "Random"
            /// </summary>
            Random,
            
            /// <summary>
            /// Enum RandomBar for "RandomBar"
            /// </summary>
            RandomBar,
            
            /// <summary>
            /// Enum Split for "Split"
            /// </summary>
            Split,
            
            /// <summary>
            /// Enum Strips for "Strips"
            /// </summary>
            Strips,
            
            /// <summary>
            /// Enum Wedge for "Wedge"
            /// </summary>
            Wedge,
            
            /// <summary>
            /// Enum Wheel for "Wheel"
            /// </summary>
            Wheel,
            
            /// <summary>
            /// Enum Wipe for "Wipe"
            /// </summary>
            Wipe,
            
            /// <summary>
            /// Enum Zoom for "Zoom"
            /// </summary>
            Zoom,
            
            /// <summary>
            /// Enum Vortex for "Vortex"
            /// </summary>
            Vortex,
            
            /// <summary>
            /// Enum Switch for "Switch"
            /// </summary>
            Switch,
            
            /// <summary>
            /// Enum Flip for "Flip"
            /// </summary>
            Flip,
            
            /// <summary>
            /// Enum Ripple for "Ripple"
            /// </summary>
            Ripple,
            
            /// <summary>
            /// Enum Honeycomb for "Honeycomb"
            /// </summary>
            Honeycomb,
            
            /// <summary>
            /// Enum Cube for "Cube"
            /// </summary>
            Cube,
            
            /// <summary>
            /// Enum Box for "Box"
            /// </summary>
            Box,
            
            /// <summary>
            /// Enum Rotate for "Rotate"
            /// </summary>
            Rotate,
            
            /// <summary>
            /// Enum Orbit for "Orbit"
            /// </summary>
            Orbit,
            
            /// <summary>
            /// Enum Doors for "Doors"
            /// </summary>
            Doors,
            
            /// <summary>
            /// Enum Window for "Window"
            /// </summary>
            Window,
            
            /// <summary>
            /// Enum Ferris for "Ferris"
            /// </summary>
            Ferris,
            
            /// <summary>
            /// Enum Gallery for "Gallery"
            /// </summary>
            Gallery,
            
            /// <summary>
            /// Enum Conveyor for "Conveyor"
            /// </summary>
            Conveyor,
            
            /// <summary>
            /// Enum Pan for "Pan"
            /// </summary>
            Pan,
            
            /// <summary>
            /// Enum Glitter for "Glitter"
            /// </summary>
            Glitter,
            
            /// <summary>
            /// Enum Warp for "Warp"
            /// </summary>
            Warp,
            
            /// <summary>
            /// Enum Flythrough for "Flythrough"
            /// </summary>
            Flythrough,
            
            /// <summary>
            /// Enum Flash for "Flash"
            /// </summary>
            Flash,
            
            /// <summary>
            /// Enum Shred for "Shred"
            /// </summary>
            Shred,
            
            /// <summary>
            /// Enum Reveal for "Reveal"
            /// </summary>
            Reveal,
            
            /// <summary>
            /// Enum WheelReverse for "WheelReverse"
            /// </summary>
            WheelReverse,
            
            /// <summary>
            /// Enum FallOver for "FallOver"
            /// </summary>
            FallOver,
            
            /// <summary>
            /// Enum Drape for "Drape"
            /// </summary>
            Drape,
            
            /// <summary>
            /// Enum Curtains for "Curtains"
            /// </summary>
            Curtains,
            
            /// <summary>
            /// Enum Wind for "Wind"
            /// </summary>
            Wind,
            
            /// <summary>
            /// Enum Prestige for "Prestige"
            /// </summary>
            Prestige,
            
            /// <summary>
            /// Enum Fracture for "Fracture"
            /// </summary>
            Fracture,
            
            /// <summary>
            /// Enum Crush for "Crush"
            /// </summary>
            Crush,
            
            /// <summary>
            /// Enum PeelOff for "PeelOff"
            /// </summary>
            PeelOff,
            
            /// <summary>
            /// Enum PageCurlDouble for "PageCurlDouble"
            /// </summary>
            PageCurlDouble,
            
            /// <summary>
            /// Enum PageCurlSingle for "PageCurlSingle"
            /// </summary>
            PageCurlSingle,
            
            /// <summary>
            /// Enum Airplane for "Airplane"
            /// </summary>
            Airplane,
            
            /// <summary>
            /// Enum Origami for "Origami"
            /// </summary>
            Origami,
            
            /// <summary>
            /// Enum Morph for "Morph"
            /// </summary>
            Morph
        }

        /// <summary>
        /// Sound Mode
        /// </summary>
        /// <value>Sound Mode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SoundModeEnum
        {
            
            /// <summary>
            /// Enum StartSound for "StartSound"
            /// </summary>
            StartSound,
            
            /// <summary>
            /// Enum StopPrevoiusSound for "StopPrevoiusSound"
            /// </summary>
            StopPrevoiusSound,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Speed
        /// </summary>
        /// <value>Speed</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SpeedEnum
        {
            
            /// <summary>
            /// Enum Fast for "Fast"
            /// </summary>
            Fast,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>
            Medium,
            
            /// <summary>
            /// Enum Slow for "Slow"
            /// </summary>
            Slow
        }

        /// <summary>
        /// Corner Direction.
        /// </summary>
        /// <value>Corner Direction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CornerDirectionEnum
        {
            
            /// <summary>
            /// Enum LeftDown for "LeftDown"
            /// </summary>
            LeftDown,
            
            /// <summary>
            /// Enum LeftUp for "LeftUp"
            /// </summary>
            LeftUp,
            
            /// <summary>
            /// Enum RightDown for "RightDown"
            /// </summary>
            RightDown,
            
            /// <summary>
            /// Enum RightUp for "RightUp"
            /// </summary>
            RightUp
        }

        /// <summary>
        /// Eight Direction.
        /// </summary>
        /// <value>Eight Direction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EightDirectionEnum
        {
            
            /// <summary>
            /// Enum LeftDown for "LeftDown"
            /// </summary>
            LeftDown,
            
            /// <summary>
            /// Enum LeftUp for "LeftUp"
            /// </summary>
            LeftUp,
            
            /// <summary>
            /// Enum RightDown for "RightDown"
            /// </summary>
            RightDown,
            
            /// <summary>
            /// Enum RightUp for "RightUp"
            /// </summary>
            RightUp,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            Left,
            
            /// <summary>
            /// Enum Up for "Up"
            /// </summary>
            Up,
            
            /// <summary>
            /// Enum Down for "Down"
            /// </summary>
            Down,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            Right
        }

        /// <summary>
        /// In/Out Direction.
        /// </summary>
        /// <value>In/Out Direction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InOutDirectionEnum
        {
            
            /// <summary>
            /// Enum In for "In"
            /// </summary>
            In,
            
            /// <summary>
            /// Enum Out for "Out"
            /// </summary>
            Out
        }

        /// <summary>
        /// Side Direction.
        /// </summary>
        /// <value>Side Direction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SideDirectionEnum
        {
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            Left,
            
            /// <summary>
            /// Enum Up for "Up"
            /// </summary>
            Up,
            
            /// <summary>
            /// Enum Down for "Down"
            /// </summary>
            Down,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            Right
        }

        /// <summary>
        /// Pattern.
        /// </summary>
        /// <value>Pattern.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PatternEnum
        {
            
            /// <summary>
            /// Enum Diamond for "Diamond"
            /// </summary>
            Diamond,
            
            /// <summary>
            /// Enum Hexagon for "Hexagon"
            /// </summary>
            Hexagon
        }

        /// <summary>
        /// Left/Right Direction.
        /// </summary>
        /// <value>Left/Right Direction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LeftRightDirectionEnum
        {
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            Left,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            Right
        }

        /// <summary>
        /// Morph Type.
        /// </summary>
        /// <value>Morph Type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MorphTypeEnum
        {
            
            /// <summary>
            /// Enum ByObject for "ByObject"
            /// </summary>
            ByObject,
            
            /// <summary>
            /// Enum ByWord for "ByWord"
            /// </summary>
            ByWord,
            
            /// <summary>
            /// Enum ByChar for "ByChar"
            /// </summary>
            ByChar
        }

        /// <summary>
        /// Orientation Direction.
        /// </summary>
        /// <value>Orientation Direction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationDirectionEnum
        {
            
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>
            Horizontal,
            
            /// <summary>
            /// Enum Vertical for "Vertical"
            /// </summary>
            Vertical
        }

        /// <summary>
        /// Orientation.
        /// </summary>
        /// <value>Orientation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CornerAndCenterDirectionEnum
        {
            
            /// <summary>
            /// Enum LeftDown for "LeftDown"
            /// </summary>
            LeftDown,
            
            /// <summary>
            /// Enum LeftUp for "LeftUp"
            /// </summary>
            LeftUp,
            
            /// <summary>
            /// Enum RightDown for "RightDown"
            /// </summary>
            RightDown,
            
            /// <summary>
            /// Enum RightUp for "RightUp"
            /// </summary>
            RightUp,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            Center
        }

        /// <summary>
        /// Shred Pattern.
        /// </summary>
        /// <value>Shred Pattern.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShredPatternEnum
        {
            
            /// <summary>
            /// Enum Strip for "Strip"
            /// </summary>
            Strip,
            
            /// <summary>
            /// Enum Rectangle for "Rectangle"
            /// </summary>
            Rectangle
        }

        /// <summary>
        /// Orientation.
        /// </summary>
        /// <value>Orientation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>
            Horizontal,
            
            /// <summary>
            /// Enum Vertical for "Vertical"
            /// </summary>
            Vertical
        }

        /// <summary>
        /// Transition Type
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Sound Mode
        /// </summary>
        public SoundModeEnum? SoundMode { get; set; }

        /// <summary>
        /// Speed
        /// </summary>
        public SpeedEnum? Speed { get; set; }

        /// <summary>
        /// Corner Direction.
        /// </summary>
        public CornerDirectionEnum? CornerDirection { get; set; }

        /// <summary>
        /// Eight Direction.
        /// </summary>
        public EightDirectionEnum? EightDirection { get; set; }

        /// <summary>
        /// In/Out Direction.
        /// </summary>
        public InOutDirectionEnum? InOutDirection { get; set; }

        /// <summary>
        /// Side Direction.
        /// </summary>
        public SideDirectionEnum? SideDirection { get; set; }

        /// <summary>
        /// Pattern.
        /// </summary>
        public PatternEnum? Pattern { get; set; }

        /// <summary>
        /// Left/Right Direction.
        /// </summary>
        public LeftRightDirectionEnum? LeftRightDirection { get; set; }

        /// <summary>
        /// Morph Type.
        /// </summary>
        public MorphTypeEnum? MorphType { get; set; }

        /// <summary>
        /// Orientation Direction.
        /// </summary>
        public OrientationDirectionEnum? OrientationDirection { get; set; }

        /// <summary>
        /// Orientation.
        /// </summary>
        public CornerAndCenterDirectionEnum? CornerAndCenterDirection { get; set; }

        /// <summary>
        /// Shred Pattern.
        /// </summary>
        public ShredPatternEnum? ShredPattern { get; set; }

        /// <summary>
        /// Orientation.
        /// </summary>
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Advance After
        /// </summary>
        public bool? AdvanceAfter { get; set; }

        /// <summary>
        /// Advance After Time
        /// </summary>
        public int? AdvanceAfterTime { get; set; }

        /// <summary>
        /// Advance On Click
        /// </summary>
        public bool? AdvanceOnClick { get; set; }

        /// <summary>
        /// Sound Is Built In
        /// </summary>
        public bool? SoundIsBuiltIn { get; set; }

        /// <summary>
        /// Sound Loop
        /// </summary>
        public bool? SoundLoop { get; set; }

        /// <summary>
        /// Sound Name
        /// </summary>
        public string SoundName { get; set; }

        /// <summary>
        /// Has Bounce.
        /// </summary>
        public bool? HasBounce { get; set; }

        /// <summary>
        /// From Black.
        /// </summary>
        public bool? FromBlack { get; set; }

        /// <summary>
        /// Through Black.
        /// </summary>
        public bool? ThroughBlack { get; set; }

        /// <summary>
        /// Spokes.
        /// </summary>
        public int? Spokes { get; set; }


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
        public SlideShowTransition() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class SlideShowTransition {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  AdvanceAfter: ").Append(this.AdvanceAfter).Append("\n");
            sb.Append("  AdvanceAfterTime: ").Append(this.AdvanceAfterTime).Append("\n");
            sb.Append("  AdvanceOnClick: ").Append(this.AdvanceOnClick).Append("\n");
            sb.Append("  SoundIsBuiltIn: ").Append(this.SoundIsBuiltIn).Append("\n");
            sb.Append("  SoundLoop: ").Append(this.SoundLoop).Append("\n");
            sb.Append("  SoundMode: ").Append(this.SoundMode).Append("\n");
            sb.Append("  SoundName: ").Append(this.SoundName).Append("\n");
            sb.Append("  Speed: ").Append(this.Speed).Append("\n");
            sb.Append("  CornerDirection: ").Append(this.CornerDirection).Append("\n");
            sb.Append("  EightDirection: ").Append(this.EightDirection).Append("\n");
            sb.Append("  InOutDirection: ").Append(this.InOutDirection).Append("\n");
            sb.Append("  HasBounce: ").Append(this.HasBounce).Append("\n");
            sb.Append("  SideDirection: ").Append(this.SideDirection).Append("\n");
            sb.Append("  Pattern: ").Append(this.Pattern).Append("\n");
            sb.Append("  LeftRightDirection: ").Append(this.LeftRightDirection).Append("\n");
            sb.Append("  MorphType: ").Append(this.MorphType).Append("\n");
            sb.Append("  FromBlack: ").Append(this.FromBlack).Append("\n");
            sb.Append("  OrientationDirection: ").Append(this.OrientationDirection).Append("\n");
            sb.Append("  ThroughBlack: ").Append(this.ThroughBlack).Append("\n");
            sb.Append("  CornerAndCenterDirection: ").Append(this.CornerAndCenterDirection).Append("\n");
            sb.Append("  ShredPattern: ").Append(this.ShredPattern).Append("\n");
            sb.Append("  Orientation: ").Append(this.Orientation).Append("\n");
            sb.Append("  Spokes: ").Append(this.Spokes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
