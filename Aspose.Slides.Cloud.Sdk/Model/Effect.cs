// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Effect.cs">
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
    /// Represents comment of slide
    /// </summary>  
    public class Effect 
    {                       
        /// <summary>
        /// Effect type.
        /// </summary>
        /// <value>Effect type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Appear for "Appear"
            /// </summary>
            Appear,
            
            /// <summary>
            /// Enum CurveUpDown for "CurveUpDown"
            /// </summary>
            CurveUpDown,
            
            /// <summary>
            /// Enum Ascend for "Ascend"
            /// </summary>
            Ascend,
            
            /// <summary>
            /// Enum Blast for "Blast"
            /// </summary>
            Blast,
            
            /// <summary>
            /// Enum Blinds for "Blinds"
            /// </summary>
            Blinds,
            
            /// <summary>
            /// Enum Blink for "Blink"
            /// </summary>
            Blink,
            
            /// <summary>
            /// Enum BoldFlash for "BoldFlash"
            /// </summary>
            BoldFlash,
            
            /// <summary>
            /// Enum BoldReveal for "BoldReveal"
            /// </summary>
            BoldReveal,
            
            /// <summary>
            /// Enum Boomerang for "Boomerang"
            /// </summary>
            Boomerang,
            
            /// <summary>
            /// Enum Bounce for "Bounce"
            /// </summary>
            Bounce,
            
            /// <summary>
            /// Enum Box for "Box"
            /// </summary>
            Box,
            
            /// <summary>
            /// Enum BrushOnColor for "BrushOnColor"
            /// </summary>
            BrushOnColor,
            
            /// <summary>
            /// Enum BrushOnUnderline for "BrushOnUnderline"
            /// </summary>
            BrushOnUnderline,
            
            /// <summary>
            /// Enum CenterRevolve for "CenterRevolve"
            /// </summary>
            CenterRevolve,
            
            /// <summary>
            /// Enum ChangeFillColor for "ChangeFillColor"
            /// </summary>
            ChangeFillColor,
            
            /// <summary>
            /// Enum ChangeFont for "ChangeFont"
            /// </summary>
            ChangeFont,
            
            /// <summary>
            /// Enum ChangeFontColor for "ChangeFontColor"
            /// </summary>
            ChangeFontColor,
            
            /// <summary>
            /// Enum ChangeFontSize for "ChangeFontSize"
            /// </summary>
            ChangeFontSize,
            
            /// <summary>
            /// Enum ChangeFontStyle for "ChangeFontStyle"
            /// </summary>
            ChangeFontStyle,
            
            /// <summary>
            /// Enum ChangeLineColor for "ChangeLineColor"
            /// </summary>
            ChangeLineColor,
            
            /// <summary>
            /// Enum Checkerboard for "Checkerboard"
            /// </summary>
            Checkerboard,
            
            /// <summary>
            /// Enum Circle for "Circle"
            /// </summary>
            Circle,
            
            /// <summary>
            /// Enum ColorBlend for "ColorBlend"
            /// </summary>
            ColorBlend,
            
            /// <summary>
            /// Enum ColorTypewriter for "ColorTypewriter"
            /// </summary>
            ColorTypewriter,
            
            /// <summary>
            /// Enum ColorWave for "ColorWave"
            /// </summary>
            ColorWave,
            
            /// <summary>
            /// Enum ComplementaryColor for "ComplementaryColor"
            /// </summary>
            ComplementaryColor,
            
            /// <summary>
            /// Enum ComplementaryColor2 for "ComplementaryColor2"
            /// </summary>
            ComplementaryColor2,
            
            /// <summary>
            /// Enum Compress for "Compress"
            /// </summary>
            Compress,
            
            /// <summary>
            /// Enum ContrastingColor for "ContrastingColor"
            /// </summary>
            ContrastingColor,
            
            /// <summary>
            /// Enum Crawl for "Crawl"
            /// </summary>
            Crawl,
            
            /// <summary>
            /// Enum Credits for "Credits"
            /// </summary>
            Credits,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            Custom,
            
            /// <summary>
            /// Enum Darken for "Darken"
            /// </summary>
            Darken,
            
            /// <summary>
            /// Enum Desaturate for "Desaturate"
            /// </summary>
            Desaturate,
            
            /// <summary>
            /// Enum Descend for "Descend"
            /// </summary>
            Descend,
            
            /// <summary>
            /// Enum Diamond for "Diamond"
            /// </summary>
            Diamond,
            
            /// <summary>
            /// Enum Dissolve for "Dissolve"
            /// </summary>
            Dissolve,
            
            /// <summary>
            /// Enum EaseInOut for "EaseInOut"
            /// </summary>
            EaseInOut,
            
            /// <summary>
            /// Enum Expand for "Expand"
            /// </summary>
            Expand,
            
            /// <summary>
            /// Enum Fade for "Fade"
            /// </summary>
            Fade,
            
            /// <summary>
            /// Enum FadedSwivel for "FadedSwivel"
            /// </summary>
            FadedSwivel,
            
            /// <summary>
            /// Enum FadedZoom for "FadedZoom"
            /// </summary>
            FadedZoom,
            
            /// <summary>
            /// Enum FlashBulb for "FlashBulb"
            /// </summary>
            FlashBulb,
            
            /// <summary>
            /// Enum FlashOnce for "FlashOnce"
            /// </summary>
            FlashOnce,
            
            /// <summary>
            /// Enum Flicker for "Flicker"
            /// </summary>
            Flicker,
            
            /// <summary>
            /// Enum Flip for "Flip"
            /// </summary>
            Flip,
            
            /// <summary>
            /// Enum Float for "Float"
            /// </summary>
            Float,
            
            /// <summary>
            /// Enum Fly for "Fly"
            /// </summary>
            Fly,
            
            /// <summary>
            /// Enum Fold for "Fold"
            /// </summary>
            Fold,
            
            /// <summary>
            /// Enum Glide for "Glide"
            /// </summary>
            Glide,
            
            /// <summary>
            /// Enum GrowAndTurn for "GrowAndTurn"
            /// </summary>
            GrowAndTurn,
            
            /// <summary>
            /// Enum GrowShrink for "GrowShrink"
            /// </summary>
            GrowShrink,
            
            /// <summary>
            /// Enum GrowWithColor for "GrowWithColor"
            /// </summary>
            GrowWithColor,
            
            /// <summary>
            /// Enum Lighten for "Lighten"
            /// </summary>
            Lighten,
            
            /// <summary>
            /// Enum LightSpeed for "LightSpeed"
            /// </summary>
            LightSpeed,
            
            /// <summary>
            /// Enum MediaPause for "MediaPause"
            /// </summary>
            MediaPause,
            
            /// <summary>
            /// Enum MediaPlay for "MediaPlay"
            /// </summary>
            MediaPlay,
            
            /// <summary>
            /// Enum MediaStop for "MediaStop"
            /// </summary>
            MediaStop,
            
            /// <summary>
            /// Enum Path4PointStar for "Path4PointStar"
            /// </summary>
            Path4PointStar,
            
            /// <summary>
            /// Enum Path5PointStar for "Path5PointStar"
            /// </summary>
            Path5PointStar,
            
            /// <summary>
            /// Enum Path6PointStar for "Path6PointStar"
            /// </summary>
            Path6PointStar,
            
            /// <summary>
            /// Enum Path8PointStar for "Path8PointStar"
            /// </summary>
            Path8PointStar,
            
            /// <summary>
            /// Enum PathArcDown for "PathArcDown"
            /// </summary>
            PathArcDown,
            
            /// <summary>
            /// Enum PathArcLeft for "PathArcLeft"
            /// </summary>
            PathArcLeft,
            
            /// <summary>
            /// Enum PathArcRight for "PathArcRight"
            /// </summary>
            PathArcRight,
            
            /// <summary>
            /// Enum PathArcUp for "PathArcUp"
            /// </summary>
            PathArcUp,
            
            /// <summary>
            /// Enum PathBean for "PathBean"
            /// </summary>
            PathBean,
            
            /// <summary>
            /// Enum PathBounceLeft for "PathBounceLeft"
            /// </summary>
            PathBounceLeft,
            
            /// <summary>
            /// Enum PathBounceRight for "PathBounceRight"
            /// </summary>
            PathBounceRight,
            
            /// <summary>
            /// Enum PathBuzzsaw for "PathBuzzsaw"
            /// </summary>
            PathBuzzsaw,
            
            /// <summary>
            /// Enum PathCircle for "PathCircle"
            /// </summary>
            PathCircle,
            
            /// <summary>
            /// Enum PathCrescentMoon for "PathCrescentMoon"
            /// </summary>
            PathCrescentMoon,
            
            /// <summary>
            /// Enum PathCurvedSquare for "PathCurvedSquare"
            /// </summary>
            PathCurvedSquare,
            
            /// <summary>
            /// Enum PathCurvedX for "PathCurvedX"
            /// </summary>
            PathCurvedX,
            
            /// <summary>
            /// Enum PathCurvyLeft for "PathCurvyLeft"
            /// </summary>
            PathCurvyLeft,
            
            /// <summary>
            /// Enum PathCurvyRight for "PathCurvyRight"
            /// </summary>
            PathCurvyRight,
            
            /// <summary>
            /// Enum PathCurvyStar for "PathCurvyStar"
            /// </summary>
            PathCurvyStar,
            
            /// <summary>
            /// Enum PathDecayingWave for "PathDecayingWave"
            /// </summary>
            PathDecayingWave,
            
            /// <summary>
            /// Enum PathDiagonalDownRight for "PathDiagonalDownRight"
            /// </summary>
            PathDiagonalDownRight,
            
            /// <summary>
            /// Enum PathDiagonalUpRight for "PathDiagonalUpRight"
            /// </summary>
            PathDiagonalUpRight,
            
            /// <summary>
            /// Enum PathDiamond for "PathDiamond"
            /// </summary>
            PathDiamond,
            
            /// <summary>
            /// Enum PathDown for "PathDown"
            /// </summary>
            PathDown,
            
            /// <summary>
            /// Enum PathEqualTriangle for "PathEqualTriangle"
            /// </summary>
            PathEqualTriangle,
            
            /// <summary>
            /// Enum PathFigure8Four for "PathFigure8Four"
            /// </summary>
            PathFigure8Four,
            
            /// <summary>
            /// Enum PathFootball for "PathFootball"
            /// </summary>
            PathFootball,
            
            /// <summary>
            /// Enum PathFunnel for "PathFunnel"
            /// </summary>
            PathFunnel,
            
            /// <summary>
            /// Enum PathHeart for "PathHeart"
            /// </summary>
            PathHeart,
            
            /// <summary>
            /// Enum PathHeartbeat for "PathHeartbeat"
            /// </summary>
            PathHeartbeat,
            
            /// <summary>
            /// Enum PathHexagon for "PathHexagon"
            /// </summary>
            PathHexagon,
            
            /// <summary>
            /// Enum PathHorizontalFigure8 for "PathHorizontalFigure8"
            /// </summary>
            PathHorizontalFigure8,
            
            /// <summary>
            /// Enum PathInvertedSquare for "PathInvertedSquare"
            /// </summary>
            PathInvertedSquare,
            
            /// <summary>
            /// Enum PathInvertedTriangle for "PathInvertedTriangle"
            /// </summary>
            PathInvertedTriangle,
            
            /// <summary>
            /// Enum PathLeft for "PathLeft"
            /// </summary>
            PathLeft,
            
            /// <summary>
            /// Enum PathLoopdeLoop for "PathLoopdeLoop"
            /// </summary>
            PathLoopdeLoop,
            
            /// <summary>
            /// Enum PathNeutron for "PathNeutron"
            /// </summary>
            PathNeutron,
            
            /// <summary>
            /// Enum PathOctagon for "PathOctagon"
            /// </summary>
            PathOctagon,
            
            /// <summary>
            /// Enum PathParallelogram for "PathParallelogram"
            /// </summary>
            PathParallelogram,
            
            /// <summary>
            /// Enum PathPeanut for "PathPeanut"
            /// </summary>
            PathPeanut,
            
            /// <summary>
            /// Enum PathPentagon for "PathPentagon"
            /// </summary>
            PathPentagon,
            
            /// <summary>
            /// Enum PathPlus for "PathPlus"
            /// </summary>
            PathPlus,
            
            /// <summary>
            /// Enum PathPointyStar for "PathPointyStar"
            /// </summary>
            PathPointyStar,
            
            /// <summary>
            /// Enum PathRight for "PathRight"
            /// </summary>
            PathRight,
            
            /// <summary>
            /// Enum PathRightTriangle for "PathRightTriangle"
            /// </summary>
            PathRightTriangle,
            
            /// <summary>
            /// Enum PathSCurve1 for "PathSCurve1"
            /// </summary>
            PathSCurve1,
            
            /// <summary>
            /// Enum PathSCurve2 for "PathSCurve2"
            /// </summary>
            PathSCurve2,
            
            /// <summary>
            /// Enum PathSineWave for "PathSineWave"
            /// </summary>
            PathSineWave,
            
            /// <summary>
            /// Enum PathSpiralLeft for "PathSpiralLeft"
            /// </summary>
            PathSpiralLeft,
            
            /// <summary>
            /// Enum PathSpiralRight for "PathSpiralRight"
            /// </summary>
            PathSpiralRight,
            
            /// <summary>
            /// Enum PathSpring for "PathSpring"
            /// </summary>
            PathSpring,
            
            /// <summary>
            /// Enum PathSquare for "PathSquare"
            /// </summary>
            PathSquare,
            
            /// <summary>
            /// Enum PathStairsDown for "PathStairsDown"
            /// </summary>
            PathStairsDown,
            
            /// <summary>
            /// Enum PathSwoosh for "PathSwoosh"
            /// </summary>
            PathSwoosh,
            
            /// <summary>
            /// Enum PathTeardrop for "PathTeardrop"
            /// </summary>
            PathTeardrop,
            
            /// <summary>
            /// Enum PathTrapezoid for "PathTrapezoid"
            /// </summary>
            PathTrapezoid,
            
            /// <summary>
            /// Enum PathTurnDown for "PathTurnDown"
            /// </summary>
            PathTurnDown,
            
            /// <summary>
            /// Enum PathTurnRight for "PathTurnRight"
            /// </summary>
            PathTurnRight,
            
            /// <summary>
            /// Enum PathTurnUp for "PathTurnUp"
            /// </summary>
            PathTurnUp,
            
            /// <summary>
            /// Enum PathTurnUpRight for "PathTurnUpRight"
            /// </summary>
            PathTurnUpRight,
            
            /// <summary>
            /// Enum PathUp for "PathUp"
            /// </summary>
            PathUp,
            
            /// <summary>
            /// Enum PathUser for "PathUser"
            /// </summary>
            PathUser,
            
            /// <summary>
            /// Enum PathVerticalFigure8 for "PathVerticalFigure8"
            /// </summary>
            PathVerticalFigure8,
            
            /// <summary>
            /// Enum PathWave for "PathWave"
            /// </summary>
            PathWave,
            
            /// <summary>
            /// Enum PathZigzag for "PathZigzag"
            /// </summary>
            PathZigzag,
            
            /// <summary>
            /// Enum Peek for "Peek"
            /// </summary>
            Peek,
            
            /// <summary>
            /// Enum Pinwheel for "Pinwheel"
            /// </summary>
            Pinwheel,
            
            /// <summary>
            /// Enum Plus for "Plus"
            /// </summary>
            Plus,
            
            /// <summary>
            /// Enum RandomBars for "RandomBars"
            /// </summary>
            RandomBars,
            
            /// <summary>
            /// Enum RandomEffects for "RandomEffects"
            /// </summary>
            RandomEffects,
            
            /// <summary>
            /// Enum RiseUp for "RiseUp"
            /// </summary>
            RiseUp,
            
            /// <summary>
            /// Enum Shimmer for "Shimmer"
            /// </summary>
            Shimmer,
            
            /// <summary>
            /// Enum Sling for "Sling"
            /// </summary>
            Sling,
            
            /// <summary>
            /// Enum Spin for "Spin"
            /// </summary>
            Spin,
            
            /// <summary>
            /// Enum Spinner for "Spinner"
            /// </summary>
            Spinner,
            
            /// <summary>
            /// Enum Spiral for "Spiral"
            /// </summary>
            Spiral,
            
            /// <summary>
            /// Enum Split for "Split"
            /// </summary>
            Split,
            
            /// <summary>
            /// Enum Stretch for "Stretch"
            /// </summary>
            Stretch,
            
            /// <summary>
            /// Enum Strips for "Strips"
            /// </summary>
            Strips,
            
            /// <summary>
            /// Enum StyleEmphasis for "StyleEmphasis"
            /// </summary>
            StyleEmphasis,
            
            /// <summary>
            /// Enum Swish for "Swish"
            /// </summary>
            Swish,
            
            /// <summary>
            /// Enum Swivel for "Swivel"
            /// </summary>
            Swivel,
            
            /// <summary>
            /// Enum Teeter for "Teeter"
            /// </summary>
            Teeter,
            
            /// <summary>
            /// Enum Thread for "Thread"
            /// </summary>
            Thread,
            
            /// <summary>
            /// Enum Transparency for "Transparency"
            /// </summary>
            Transparency,
            
            /// <summary>
            /// Enum Unfold for "Unfold"
            /// </summary>
            Unfold,
            
            /// <summary>
            /// Enum VerticalGrow for "VerticalGrow"
            /// </summary>
            VerticalGrow,
            
            /// <summary>
            /// Enum Wave for "Wave"
            /// </summary>
            Wave,
            
            /// <summary>
            /// Enum Wedge for "Wedge"
            /// </summary>
            Wedge,
            
            /// <summary>
            /// Enum Wheel for "Wheel"
            /// </summary>
            Wheel,
            
            /// <summary>
            /// Enum Whip for "Whip"
            /// </summary>
            Whip,
            
            /// <summary>
            /// Enum Wipe for "Wipe"
            /// </summary>
            Wipe,
            
            /// <summary>
            /// Enum Magnify for "Magnify"
            /// </summary>
            Magnify,
            
            /// <summary>
            /// Enum Zoom for "Zoom"
            /// </summary>
            Zoom,
            
            /// <summary>
            /// Enum OLEObjectShow for "OLEObjectShow"
            /// </summary>
            OLEObjectShow,
            
            /// <summary>
            /// Enum OLEObjectEdit for "OLEObjectEdit"
            /// </summary>
            OLEObjectEdit,
            
            /// <summary>
            /// Enum OLEObjectOpen for "OLEObjectOpen"
            /// </summary>
            OLEObjectOpen
        }

        /// <summary>
        /// Effect subtype.
        /// </summary>
        /// <value>Effect subtype.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubtypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            None,
            
            /// <summary>
            /// Enum Across for "Across"
            /// </summary>
            Across,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>
            Bottom,
            
            /// <summary>
            /// Enum BottomLeft for "BottomLeft"
            /// </summary>
            BottomLeft,
            
            /// <summary>
            /// Enum BottomRight for "BottomRight"
            /// </summary>
            BottomRight,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            Center,
            
            /// <summary>
            /// Enum Clockwise for "Clockwise"
            /// </summary>
            Clockwise,
            
            /// <summary>
            /// Enum CounterClockwise for "CounterClockwise"
            /// </summary>
            CounterClockwise,
            
            /// <summary>
            /// Enum GradualAndCycleClockwise for "GradualAndCycleClockwise"
            /// </summary>
            GradualAndCycleClockwise,
            
            /// <summary>
            /// Enum GradualAndCycleCounterClockwise for "GradualAndCycleCounterClockwise"
            /// </summary>
            GradualAndCycleCounterClockwise,
            
            /// <summary>
            /// Enum Down for "Down"
            /// </summary>
            Down,
            
            /// <summary>
            /// Enum DownLeft for "DownLeft"
            /// </summary>
            DownLeft,
            
            /// <summary>
            /// Enum DownRight for "DownRight"
            /// </summary>
            DownRight,
            
            /// <summary>
            /// Enum FontAllCaps for "FontAllCaps"
            /// </summary>
            FontAllCaps,
            
            /// <summary>
            /// Enum FontBold for "FontBold"
            /// </summary>
            FontBold,
            
            /// <summary>
            /// Enum FontItalic for "FontItalic"
            /// </summary>
            FontItalic,
            
            /// <summary>
            /// Enum FontShadow for "FontShadow"
            /// </summary>
            FontShadow,
            
            /// <summary>
            /// Enum FontStrikethrough for "FontStrikethrough"
            /// </summary>
            FontStrikethrough,
            
            /// <summary>
            /// Enum FontUnderline for "FontUnderline"
            /// </summary>
            FontUnderline,
            
            /// <summary>
            /// Enum Gradual for "Gradual"
            /// </summary>
            Gradual,
            
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>
            Horizontal,
            
            /// <summary>
            /// Enum HorizontalIn for "HorizontalIn"
            /// </summary>
            HorizontalIn,
            
            /// <summary>
            /// Enum HorizontalOut for "HorizontalOut"
            /// </summary>
            HorizontalOut,
            
            /// <summary>
            /// Enum In for "In"
            /// </summary>
            In,
            
            /// <summary>
            /// Enum InBottom for "InBottom"
            /// </summary>
            InBottom,
            
            /// <summary>
            /// Enum InCenter for "InCenter"
            /// </summary>
            InCenter,
            
            /// <summary>
            /// Enum InSlightly for "InSlightly"
            /// </summary>
            InSlightly,
            
            /// <summary>
            /// Enum Instant for "Instant"
            /// </summary>
            Instant,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            Left,
            
            /// <summary>
            /// Enum OrdinalMask for "OrdinalMask"
            /// </summary>
            OrdinalMask,
            
            /// <summary>
            /// Enum Out for "Out"
            /// </summary>
            Out,
            
            /// <summary>
            /// Enum OutBottom for "OutBottom"
            /// </summary>
            OutBottom,
            
            /// <summary>
            /// Enum OutCenter for "OutCenter"
            /// </summary>
            OutCenter,
            
            /// <summary>
            /// Enum OutSlightly for "OutSlightly"
            /// </summary>
            OutSlightly,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            Right,
            
            /// <summary>
            /// Enum Slightly for "Slightly"
            /// </summary>
            Slightly,
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>
            Top,
            
            /// <summary>
            /// Enum TopLeft for "TopLeft"
            /// </summary>
            TopLeft,
            
            /// <summary>
            /// Enum TopRight for "TopRight"
            /// </summary>
            TopRight,
            
            /// <summary>
            /// Enum Up for "Up"
            /// </summary>
            Up,
            
            /// <summary>
            /// Enum UpLeft for "UpLeft"
            /// </summary>
            UpLeft,
            
            /// <summary>
            /// Enum UpRight for "UpRight"
            /// </summary>
            UpRight,
            
            /// <summary>
            /// Enum Vertical for "Vertical"
            /// </summary>
            Vertical,
            
            /// <summary>
            /// Enum VerticalIn for "VerticalIn"
            /// </summary>
            VerticalIn,
            
            /// <summary>
            /// Enum VerticalOut for "VerticalOut"
            /// </summary>
            VerticalOut,
            
            /// <summary>
            /// Enum Wheel1 for "Wheel1"
            /// </summary>
            Wheel1,
            
            /// <summary>
            /// Enum Wheel2 for "Wheel2"
            /// </summary>
            Wheel2,
            
            /// <summary>
            /// Enum Wheel3 for "Wheel3"
            /// </summary>
            Wheel3,
            
            /// <summary>
            /// Enum Wheel4 for "Wheel4"
            /// </summary>
            Wheel4,
            
            /// <summary>
            /// Enum Wheel8 for "Wheel8"
            /// </summary>
            Wheel8
        }

        /// <summary>
        /// Preset class type.
        /// </summary>
        /// <value>Preset class type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PresetClassTypeEnum
        {
            
            /// <summary>
            /// Enum Entrance for "Entrance"
            /// </summary>
            Entrance,
            
            /// <summary>
            /// Enum Exit for "Exit"
            /// </summary>
            Exit,
            
            /// <summary>
            /// Enum Emphasis for "Emphasis"
            /// </summary>
            Emphasis,
            
            /// <summary>
            /// Enum Path for "Path"
            /// </summary>
            Path,
            
            /// <summary>
            /// Enum MediaCall for "MediaCall"
            /// </summary>
            MediaCall,
            
            /// <summary>
            /// Enum OLEActionVerbs for "OLEActionVerbs"
            /// </summary>
            OLEActionVerbs
        }

        /// <summary>
        /// Effect trigger type.
        /// </summary>
        /// <value>Effect trigger type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TriggerTypeEnum
        {
            
            /// <summary>
            /// Enum AfterPrevious for "AfterPrevious"
            /// </summary>
            AfterPrevious,
            
            /// <summary>
            /// Enum OnClick for "OnClick"
            /// </summary>
            OnClick,
            
            /// <summary>
            /// Enum WithPrevious for "WithPrevious"
            /// </summary>
            WithPrevious
        }

        /// <summary>
        /// The way for a effect to restart after complete.
        /// </summary>
        /// <value>The way for a effect to restart after complete.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RestartEnum
        {
            
            /// <summary>
            /// Enum Always for "Always"
            /// </summary>
            Always,
            
            /// <summary>
            /// Enum WhenNotActive for "WhenNotActive"
            /// </summary>
            WhenNotActive,
            
            /// <summary>
            /// Enum Never for "Never"
            /// </summary>
            Never,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Defined an after animation color for effect.
        /// </summary>
        /// <value>Defined an after animation color for effect.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AfterAnimationTypeEnum
        {
            
            /// <summary>
            /// Enum DoNotDim for "DoNotDim"
            /// </summary>
            DoNotDim,
            
            /// <summary>
            /// Enum Color for "Color"
            /// </summary>
            Color,
            
            /// <summary>
            /// Enum HideAfterAnimation for "HideAfterAnimation"
            /// </summary>
            HideAfterAnimation,
            
            /// <summary>
            /// Enum HideOnNextMouseClick for "HideOnNextMouseClick"
            /// </summary>
            HideOnNextMouseClick
        }

        /// <summary>
        /// Effect type.
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Effect subtype.
        /// </summary>
        public SubtypeEnum? Subtype { get; set; }

        /// <summary>
        /// Preset class type.
        /// </summary>
        public PresetClassTypeEnum? PresetClassType { get; set; }

        /// <summary>
        /// Effect trigger type.
        /// </summary>
        public TriggerTypeEnum? TriggerType { get; set; }

        /// <summary>
        /// The way for a effect to restart after complete.
        /// </summary>
        public RestartEnum? Restart { get; set; }

        /// <summary>
        /// Defined an after animation color for effect.
        /// </summary>
        public AfterAnimationTypeEnum? AfterAnimationType { get; set; }

        /// <summary>
        /// Shape index.
        /// </summary>
        public int? ShapeIndex { get; set; }

        /// <summary>
        /// Paragraph index.
        /// </summary>
        public int? ParagraphIndex { get; set; }

        /// <summary>
        /// The percentage of duration accelerate behavior effect.
        /// </summary>
        public double? Accelerate { get; set; }

        /// <summary>
        /// True to automatically play the animation in reverse after playing it in the forward direction.
        /// </summary>
        public bool? AutoReverse { get; set; }

        /// <summary>
        /// The percentage of duration decelerate behavior effect.
        /// </summary>
        public double? Decelerate { get; set; }

        /// <summary>
        /// The duration of animation effect.
        /// </summary>
        public double? Duration { get; set; }

        /// <summary>
        /// The number of times the effect should repeat.
        /// </summary>
        public double? RepeatCount { get; set; }

        /// <summary>
        /// The number of times the effect should repeat.
        /// </summary>
        public double? RepeatDuration { get; set; }

        /// <summary>
        /// The percentage by which to speed up (or slow down) the timing.
        /// </summary>
        public double? Speed { get; set; }

        /// <summary>
        /// Delay time after trigger.
        /// </summary>
        public double? TriggerDelayTime { get; set; }

        /// <summary>
        /// Specifies if the effect will repeat until the end of slide.
        /// </summary>
        public bool? RepeatUntilEndSlide { get; set; }

        /// <summary>
        /// Specifies if the effect will repeat until the next click.
        /// </summary>
        public bool? RepeatUntilNextClick { get; set; }

        /// <summary>
        /// This attribute specifies if the animation effect stops the previous sound.
        /// </summary>
        public bool? StopPreviousSound { get; set; }

        /// <summary>
        /// This attribute specifies if the effect will rewind when done playing.
        /// </summary>
        public bool? Rewind { get; set; }

        /// <summary>
        /// Defined an after animation color for effect. Applied when the AfterAnimationType property is set to Color.
        /// </summary>
        public string AfterAnimationColor { get; set; }


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
        public Effect() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Effect {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Subtype: ").Append(this.Subtype).Append("\n");
            sb.Append("  PresetClassType: ").Append(this.PresetClassType).Append("\n");
            sb.Append("  ShapeIndex: ").Append(this.ShapeIndex).Append("\n");
            sb.Append("  ParagraphIndex: ").Append(this.ParagraphIndex).Append("\n");
            sb.Append("  TriggerType: ").Append(this.TriggerType).Append("\n");
            sb.Append("  Accelerate: ").Append(this.Accelerate).Append("\n");
            sb.Append("  AutoReverse: ").Append(this.AutoReverse).Append("\n");
            sb.Append("  Decelerate: ").Append(this.Decelerate).Append("\n");
            sb.Append("  Duration: ").Append(this.Duration).Append("\n");
            sb.Append("  RepeatCount: ").Append(this.RepeatCount).Append("\n");
            sb.Append("  RepeatDuration: ").Append(this.RepeatDuration).Append("\n");
            sb.Append("  Restart: ").Append(this.Restart).Append("\n");
            sb.Append("  Speed: ").Append(this.Speed).Append("\n");
            sb.Append("  TriggerDelayTime: ").Append(this.TriggerDelayTime).Append("\n");
            sb.Append("  RepeatUntilEndSlide: ").Append(this.RepeatUntilEndSlide).Append("\n");
            sb.Append("  RepeatUntilNextClick: ").Append(this.RepeatUntilNextClick).Append("\n");
            sb.Append("  StopPreviousSound: ").Append(this.StopPreviousSound).Append("\n");
            sb.Append("  Rewind: ").Append(this.Rewind).Append("\n");
            sb.Append("  AfterAnimationType: ").Append(this.AfterAnimationType).Append("\n");
            sb.Append("  AfterAnimationColor: ").Append(this.AfterAnimationColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
