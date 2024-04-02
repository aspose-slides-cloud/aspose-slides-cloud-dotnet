// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SmartArt.cs">
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
    /// Represents SmartArt shape resource.
    /// </summary>  
    public class SmartArt : ShapeBase 
    {                       
        /// <summary>
        /// Layout type.
        /// </summary>
        /// <value>Layout type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayoutEnum
        {
            
            /// <summary>
            /// Enum AccentProcess for "AccentProcess"
            /// </summary>
            AccentProcess,
            
            /// <summary>
            /// Enum AccentedPicture for "AccentedPicture"
            /// </summary>
            AccentedPicture,
            
            /// <summary>
            /// Enum AlternatingFlow for "AlternatingFlow"
            /// </summary>
            AlternatingFlow,
            
            /// <summary>
            /// Enum AlternatingHexagons for "AlternatingHexagons"
            /// </summary>
            AlternatingHexagons,
            
            /// <summary>
            /// Enum AlternatingPictureBlocks for "AlternatingPictureBlocks"
            /// </summary>
            AlternatingPictureBlocks,
            
            /// <summary>
            /// Enum AlternatingPictureCircles for "AlternatingPictureCircles"
            /// </summary>
            AlternatingPictureCircles,
            
            /// <summary>
            /// Enum ArrowRibbon for "ArrowRibbon"
            /// </summary>
            ArrowRibbon,
            
            /// <summary>
            /// Enum AscendingPictureAccentProcess for "AscendingPictureAccentProcess"
            /// </summary>
            AscendingPictureAccentProcess,
            
            /// <summary>
            /// Enum Balance for "Balance"
            /// </summary>
            Balance,
            
            /// <summary>
            /// Enum BasicBendingProcess for "BasicBendingProcess"
            /// </summary>
            BasicBendingProcess,
            
            /// <summary>
            /// Enum BasicBlockList for "BasicBlockList"
            /// </summary>
            BasicBlockList,
            
            /// <summary>
            /// Enum BasicChevronProcess for "BasicChevronProcess"
            /// </summary>
            BasicChevronProcess,
            
            /// <summary>
            /// Enum BasicCycle for "BasicCycle"
            /// </summary>
            BasicCycle,
            
            /// <summary>
            /// Enum BasicMatrix for "BasicMatrix"
            /// </summary>
            BasicMatrix,
            
            /// <summary>
            /// Enum BasicPie for "BasicPie"
            /// </summary>
            BasicPie,
            
            /// <summary>
            /// Enum BasicProcess for "BasicProcess"
            /// </summary>
            BasicProcess,
            
            /// <summary>
            /// Enum BasicPyramid for "BasicPyramid"
            /// </summary>
            BasicPyramid,
            
            /// <summary>
            /// Enum BasicRadial for "BasicRadial"
            /// </summary>
            BasicRadial,
            
            /// <summary>
            /// Enum BasicTarget for "BasicTarget"
            /// </summary>
            BasicTarget,
            
            /// <summary>
            /// Enum BasicTimeline for "BasicTimeline"
            /// </summary>
            BasicTimeline,
            
            /// <summary>
            /// Enum BasicVenn for "BasicVenn"
            /// </summary>
            BasicVenn,
            
            /// <summary>
            /// Enum BendingPictureAccentList for "BendingPictureAccentList"
            /// </summary>
            BendingPictureAccentList,
            
            /// <summary>
            /// Enum BendingPictureBlocks for "BendingPictureBlocks"
            /// </summary>
            BendingPictureBlocks,
            
            /// <summary>
            /// Enum BendingPictureCaption for "BendingPictureCaption"
            /// </summary>
            BendingPictureCaption,
            
            /// <summary>
            /// Enum BendingPictureCaptionList for "BendingPictureCaptionList"
            /// </summary>
            BendingPictureCaptionList,
            
            /// <summary>
            /// Enum BendingPictureSemiTransparentText for "BendingPictureSemiTransparentText"
            /// </summary>
            BendingPictureSemiTransparentText,
            
            /// <summary>
            /// Enum BlockCycle for "BlockCycle"
            /// </summary>
            BlockCycle,
            
            /// <summary>
            /// Enum BubblePictureList for "BubblePictureList"
            /// </summary>
            BubblePictureList,
            
            /// <summary>
            /// Enum CaptionedPictures for "CaptionedPictures"
            /// </summary>
            CaptionedPictures,
            
            /// <summary>
            /// Enum ChevronList for "ChevronList"
            /// </summary>
            ChevronList,
            
            /// <summary>
            /// Enum CircleAccentTimeline for "CircleAccentTimeline"
            /// </summary>
            CircleAccentTimeline,
            
            /// <summary>
            /// Enum CircleArrowProcess for "CircleArrowProcess"
            /// </summary>
            CircleArrowProcess,
            
            /// <summary>
            /// Enum CirclePictureHierarchy for "CirclePictureHierarchy"
            /// </summary>
            CirclePictureHierarchy,
            
            /// <summary>
            /// Enum CircleRelationship for "CircleRelationship"
            /// </summary>
            CircleRelationship,
            
            /// <summary>
            /// Enum CircularBendingProcess for "CircularBendingProcess"
            /// </summary>
            CircularBendingProcess,
            
            /// <summary>
            /// Enum CircularPictureCallout for "CircularPictureCallout"
            /// </summary>
            CircularPictureCallout,
            
            /// <summary>
            /// Enum ClosedChevronProcess for "ClosedChevronProcess"
            /// </summary>
            ClosedChevronProcess,
            
            /// <summary>
            /// Enum ContinuousArrowProcess for "ContinuousArrowProcess"
            /// </summary>
            ContinuousArrowProcess,
            
            /// <summary>
            /// Enum ContinuousBlockProcess for "ContinuousBlockProcess"
            /// </summary>
            ContinuousBlockProcess,
            
            /// <summary>
            /// Enum ContinuousCycle for "ContinuousCycle"
            /// </summary>
            ContinuousCycle,
            
            /// <summary>
            /// Enum ContinuousPictureList for "ContinuousPictureList"
            /// </summary>
            ContinuousPictureList,
            
            /// <summary>
            /// Enum ConvergingArrows for "ConvergingArrows"
            /// </summary>
            ConvergingArrows,
            
            /// <summary>
            /// Enum ConvergingRadial for "ConvergingRadial"
            /// </summary>
            ConvergingRadial,
            
            /// <summary>
            /// Enum CounterbalanceArrows for "CounterbalanceArrows"
            /// </summary>
            CounterbalanceArrows,
            
            /// <summary>
            /// Enum CycleMatrix for "CycleMatrix"
            /// </summary>
            CycleMatrix,
            
            /// <summary>
            /// Enum DescendingBlockList for "DescendingBlockList"
            /// </summary>
            DescendingBlockList,
            
            /// <summary>
            /// Enum DescendingProcess for "DescendingProcess"
            /// </summary>
            DescendingProcess,
            
            /// <summary>
            /// Enum DetailedProcess for "DetailedProcess"
            /// </summary>
            DetailedProcess,
            
            /// <summary>
            /// Enum DivergingArrows for "DivergingArrows"
            /// </summary>
            DivergingArrows,
            
            /// <summary>
            /// Enum DivergingRadial for "DivergingRadial"
            /// </summary>
            DivergingRadial,
            
            /// <summary>
            /// Enum Equation for "Equation"
            /// </summary>
            Equation,
            
            /// <summary>
            /// Enum FramedTextPicture for "FramedTextPicture"
            /// </summary>
            FramedTextPicture,
            
            /// <summary>
            /// Enum Funnel for "Funnel"
            /// </summary>
            Funnel,
            
            /// <summary>
            /// Enum Gear for "Gear"
            /// </summary>
            Gear,
            
            /// <summary>
            /// Enum GridMatrix for "GridMatrix"
            /// </summary>
            GridMatrix,
            
            /// <summary>
            /// Enum GroupedList for "GroupedList"
            /// </summary>
            GroupedList,
            
            /// <summary>
            /// Enum HalfCircleOrganizationChart for "HalfCircleOrganizationChart"
            /// </summary>
            HalfCircleOrganizationChart,
            
            /// <summary>
            /// Enum HexagonCluster for "HexagonCluster"
            /// </summary>
            HexagonCluster,
            
            /// <summary>
            /// Enum Hierarchy for "Hierarchy"
            /// </summary>
            Hierarchy,
            
            /// <summary>
            /// Enum HierarchyList for "HierarchyList"
            /// </summary>
            HierarchyList,
            
            /// <summary>
            /// Enum HorizontalBulletList for "HorizontalBulletList"
            /// </summary>
            HorizontalBulletList,
            
            /// <summary>
            /// Enum HorizontalHierarchy for "HorizontalHierarchy"
            /// </summary>
            HorizontalHierarchy,
            
            /// <summary>
            /// Enum HorizontalLabeledHierarchy for "HorizontalLabeledHierarchy"
            /// </summary>
            HorizontalLabeledHierarchy,
            
            /// <summary>
            /// Enum HorizontalMultiLevelHierarchy for "HorizontalMultiLevelHierarchy"
            /// </summary>
            HorizontalMultiLevelHierarchy,
            
            /// <summary>
            /// Enum HorizontalOrganizationChart for "HorizontalOrganizationChart"
            /// </summary>
            HorizontalOrganizationChart,
            
            /// <summary>
            /// Enum HorizontalPictureList for "HorizontalPictureList"
            /// </summary>
            HorizontalPictureList,
            
            /// <summary>
            /// Enum IncreasingArrowsProcess for "IncreasingArrowsProcess"
            /// </summary>
            IncreasingArrowsProcess,
            
            /// <summary>
            /// Enum IncreasingCircleProcess for "IncreasingCircleProcess"
            /// </summary>
            IncreasingCircleProcess,
            
            /// <summary>
            /// Enum InvertedPyramid for "InvertedPyramid"
            /// </summary>
            InvertedPyramid,
            
            /// <summary>
            /// Enum LabeledHierarchy for "LabeledHierarchy"
            /// </summary>
            LabeledHierarchy,
            
            /// <summary>
            /// Enum LinearVenn for "LinearVenn"
            /// </summary>
            LinearVenn,
            
            /// <summary>
            /// Enum LinedList for "LinedList"
            /// </summary>
            LinedList,
            
            /// <summary>
            /// Enum MultidirectionalCycle for "MultidirectionalCycle"
            /// </summary>
            MultidirectionalCycle,
            
            /// <summary>
            /// Enum NameandTitleOrganizationChart for "NameandTitleOrganizationChart"
            /// </summary>
            NameandTitleOrganizationChart,
            
            /// <summary>
            /// Enum NestedTarget for "NestedTarget"
            /// </summary>
            NestedTarget,
            
            /// <summary>
            /// Enum NondirectionalCycle for "NondirectionalCycle"
            /// </summary>
            NondirectionalCycle,
            
            /// <summary>
            /// Enum OpposingArrows for "OpposingArrows"
            /// </summary>
            OpposingArrows,
            
            /// <summary>
            /// Enum OpposingIdeas for "OpposingIdeas"
            /// </summary>
            OpposingIdeas,
            
            /// <summary>
            /// Enum OrganizationChart for "OrganizationChart"
            /// </summary>
            OrganizationChart,
            
            /// <summary>
            /// Enum PhasedProcess for "PhasedProcess"
            /// </summary>
            PhasedProcess,
            
            /// <summary>
            /// Enum PictureAccentBlocks for "PictureAccentBlocks"
            /// </summary>
            PictureAccentBlocks,
            
            /// <summary>
            /// Enum PictureAccentList for "PictureAccentList"
            /// </summary>
            PictureAccentList,
            
            /// <summary>
            /// Enum PictureAccentProcess for "PictureAccentProcess"
            /// </summary>
            PictureAccentProcess,
            
            /// <summary>
            /// Enum PictureCaptionList for "PictureCaptionList"
            /// </summary>
            PictureCaptionList,
            
            /// <summary>
            /// Enum PictureGrid for "PictureGrid"
            /// </summary>
            PictureGrid,
            
            /// <summary>
            /// Enum PictureLineup for "PictureLineup"
            /// </summary>
            PictureLineup,
            
            /// <summary>
            /// Enum PictureStrips for "PictureStrips"
            /// </summary>
            PictureStrips,
            
            /// <summary>
            /// Enum PieProcess for "PieProcess"
            /// </summary>
            PieProcess,
            
            /// <summary>
            /// Enum PlusandMinus for "PlusandMinus"
            /// </summary>
            PlusandMinus,
            
            /// <summary>
            /// Enum ProcessArrows for "ProcessArrows"
            /// </summary>
            ProcessArrows,
            
            /// <summary>
            /// Enum ProcessList for "ProcessList"
            /// </summary>
            ProcessList,
            
            /// <summary>
            /// Enum PyramidList for "PyramidList"
            /// </summary>
            PyramidList,
            
            /// <summary>
            /// Enum RadialCluster for "RadialCluster"
            /// </summary>
            RadialCluster,
            
            /// <summary>
            /// Enum RadialCycle for "RadialCycle"
            /// </summary>
            RadialCycle,
            
            /// <summary>
            /// Enum RadialList for "RadialList"
            /// </summary>
            RadialList,
            
            /// <summary>
            /// Enum RadialVenn for "RadialVenn"
            /// </summary>
            RadialVenn,
            
            /// <summary>
            /// Enum RandomToResultProcess for "RandomToResultProcess"
            /// </summary>
            RandomToResultProcess,
            
            /// <summary>
            /// Enum RepeatingBendingProcess for "RepeatingBendingProcess"
            /// </summary>
            RepeatingBendingProcess,
            
            /// <summary>
            /// Enum ReverseList for "ReverseList"
            /// </summary>
            ReverseList,
            
            /// <summary>
            /// Enum SegmentedCycle for "SegmentedCycle"
            /// </summary>
            SegmentedCycle,
            
            /// <summary>
            /// Enum SegmentedProcess for "SegmentedProcess"
            /// </summary>
            SegmentedProcess,
            
            /// <summary>
            /// Enum SegmentedPyramid for "SegmentedPyramid"
            /// </summary>
            SegmentedPyramid,
            
            /// <summary>
            /// Enum SnapshotPictureList for "SnapshotPictureList"
            /// </summary>
            SnapshotPictureList,
            
            /// <summary>
            /// Enum SpiralPicture for "SpiralPicture"
            /// </summary>
            SpiralPicture,
            
            /// <summary>
            /// Enum SquareAccentList for "SquareAccentList"
            /// </summary>
            SquareAccentList,
            
            /// <summary>
            /// Enum StackedList for "StackedList"
            /// </summary>
            StackedList,
            
            /// <summary>
            /// Enum StackedVenn for "StackedVenn"
            /// </summary>
            StackedVenn,
            
            /// <summary>
            /// Enum StaggeredProcess for "StaggeredProcess"
            /// </summary>
            StaggeredProcess,
            
            /// <summary>
            /// Enum StepDownProcess for "StepDownProcess"
            /// </summary>
            StepDownProcess,
            
            /// <summary>
            /// Enum StepUpProcess for "StepUpProcess"
            /// </summary>
            StepUpProcess,
            
            /// <summary>
            /// Enum SubStepProcess for "SubStepProcess"
            /// </summary>
            SubStepProcess,
            
            /// <summary>
            /// Enum TableHierarchy for "TableHierarchy"
            /// </summary>
            TableHierarchy,
            
            /// <summary>
            /// Enum TableList for "TableList"
            /// </summary>
            TableList,
            
            /// <summary>
            /// Enum TargetList for "TargetList"
            /// </summary>
            TargetList,
            
            /// <summary>
            /// Enum TextCycle for "TextCycle"
            /// </summary>
            TextCycle,
            
            /// <summary>
            /// Enum TitlePictureLineup for "TitlePictureLineup"
            /// </summary>
            TitlePictureLineup,
            
            /// <summary>
            /// Enum TitledMatrix for "TitledMatrix"
            /// </summary>
            TitledMatrix,
            
            /// <summary>
            /// Enum TitledPictureAccentList for "TitledPictureAccentList"
            /// </summary>
            TitledPictureAccentList,
            
            /// <summary>
            /// Enum TitledPictureBlocks for "TitledPictureBlocks"
            /// </summary>
            TitledPictureBlocks,
            
            /// <summary>
            /// Enum TrapezoidList for "TrapezoidList"
            /// </summary>
            TrapezoidList,
            
            /// <summary>
            /// Enum UpwardArrow for "UpwardArrow"
            /// </summary>
            UpwardArrow,
            
            /// <summary>
            /// Enum VerticalAccentList for "VerticalAccentList"
            /// </summary>
            VerticalAccentList,
            
            /// <summary>
            /// Enum VerticalArrowList for "VerticalArrowList"
            /// </summary>
            VerticalArrowList,
            
            /// <summary>
            /// Enum VerticalBendingProcess for "VerticalBendingProcess"
            /// </summary>
            VerticalBendingProcess,
            
            /// <summary>
            /// Enum VerticalBlockList for "VerticalBlockList"
            /// </summary>
            VerticalBlockList,
            
            /// <summary>
            /// Enum VerticalBoxList for "VerticalBoxList"
            /// </summary>
            VerticalBoxList,
            
            /// <summary>
            /// Enum VerticalBulletList for "VerticalBulletList"
            /// </summary>
            VerticalBulletList,
            
            /// <summary>
            /// Enum VerticalChevronList for "VerticalChevronList"
            /// </summary>
            VerticalChevronList,
            
            /// <summary>
            /// Enum VerticalCircleList for "VerticalCircleList"
            /// </summary>
            VerticalCircleList,
            
            /// <summary>
            /// Enum VerticalCurvedList for "VerticalCurvedList"
            /// </summary>
            VerticalCurvedList,
            
            /// <summary>
            /// Enum VerticalEquation for "VerticalEquation"
            /// </summary>
            VerticalEquation,
            
            /// <summary>
            /// Enum VerticalPictureAccentList for "VerticalPictureAccentList"
            /// </summary>
            VerticalPictureAccentList,
            
            /// <summary>
            /// Enum VerticalPictureList for "VerticalPictureList"
            /// </summary>
            VerticalPictureList,
            
            /// <summary>
            /// Enum VerticalProcess for "VerticalProcess"
            /// </summary>
            VerticalProcess,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            Custom,
            
            /// <summary>
            /// Enum PictureOrganizationChart for "PictureOrganizationChart"
            /// </summary>
            PictureOrganizationChart
        }

        /// <summary>
        /// Quick style.
        /// </summary>
        /// <value>Quick style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QuickStyleEnum
        {
            
            /// <summary>
            /// Enum SimpleFill for "SimpleFill"
            /// </summary>
            SimpleFill,
            
            /// <summary>
            /// Enum WhiteOutline for "WhiteOutline"
            /// </summary>
            WhiteOutline,
            
            /// <summary>
            /// Enum SubtleEffect for "SubtleEffect"
            /// </summary>
            SubtleEffect,
            
            /// <summary>
            /// Enum ModerateEffect for "ModerateEffect"
            /// </summary>
            ModerateEffect,
            
            /// <summary>
            /// Enum IntenceEffect for "IntenceEffect"
            /// </summary>
            IntenceEffect,
            
            /// <summary>
            /// Enum Polished for "Polished"
            /// </summary>
            Polished,
            
            /// <summary>
            /// Enum Inset for "Inset"
            /// </summary>
            Inset,
            
            /// <summary>
            /// Enum Cartoon for "Cartoon"
            /// </summary>
            Cartoon,
            
            /// <summary>
            /// Enum Powder for "Powder"
            /// </summary>
            Powder,
            
            /// <summary>
            /// Enum BrickScene for "BrickScene"
            /// </summary>
            BrickScene,
            
            /// <summary>
            /// Enum FlatScene for "FlatScene"
            /// </summary>
            FlatScene,
            
            /// <summary>
            /// Enum MetallicScene for "MetallicScene"
            /// </summary>
            MetallicScene,
            
            /// <summary>
            /// Enum SunsetScene for "SunsetScene"
            /// </summary>
            SunsetScene,
            
            /// <summary>
            /// Enum BirdsEyeScene for "BirdsEyeScene"
            /// </summary>
            BirdsEyeScene
        }

        /// <summary>
        /// Color style.
        /// </summary>
        /// <value>Color style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorStyleEnum
        {
            
            /// <summary>
            /// Enum Dark1Outline for "Dark1Outline"
            /// </summary>
            Dark1Outline,
            
            /// <summary>
            /// Enum Dark2Outline for "Dark2Outline"
            /// </summary>
            Dark2Outline,
            
            /// <summary>
            /// Enum DarkFill for "DarkFill"
            /// </summary>
            DarkFill,
            
            /// <summary>
            /// Enum ColorfulAccentColors for "ColorfulAccentColors"
            /// </summary>
            ColorfulAccentColors,
            
            /// <summary>
            /// Enum ColorfulAccentColors2to3 for "ColorfulAccentColors2to3"
            /// </summary>
            ColorfulAccentColors2to3,
            
            /// <summary>
            /// Enum ColorfulAccentColors3to4 for "ColorfulAccentColors3to4"
            /// </summary>
            ColorfulAccentColors3to4,
            
            /// <summary>
            /// Enum ColorfulAccentColors4to5 for "ColorfulAccentColors4to5"
            /// </summary>
            ColorfulAccentColors4to5,
            
            /// <summary>
            /// Enum ColorfulAccentColors5to6 for "ColorfulAccentColors5to6"
            /// </summary>
            ColorfulAccentColors5to6,
            
            /// <summary>
            /// Enum ColoredOutlineAccent1 for "ColoredOutlineAccent1"
            /// </summary>
            ColoredOutlineAccent1,
            
            /// <summary>
            /// Enum ColoredFillAccent1 for "ColoredFillAccent1"
            /// </summary>
            ColoredFillAccent1,
            
            /// <summary>
            /// Enum GradientRangeAccent1 for "GradientRangeAccent1"
            /// </summary>
            GradientRangeAccent1,
            
            /// <summary>
            /// Enum GradientLoopAccent1 for "GradientLoopAccent1"
            /// </summary>
            GradientLoopAccent1,
            
            /// <summary>
            /// Enum TransparentGradientRangeAccent1 for "TransparentGradientRangeAccent1"
            /// </summary>
            TransparentGradientRangeAccent1,
            
            /// <summary>
            /// Enum ColoredOutlineAccent2 for "ColoredOutlineAccent2"
            /// </summary>
            ColoredOutlineAccent2,
            
            /// <summary>
            /// Enum ColoredFillAccent2 for "ColoredFillAccent2"
            /// </summary>
            ColoredFillAccent2,
            
            /// <summary>
            /// Enum GradientRangeAccent2 for "GradientRangeAccent2"
            /// </summary>
            GradientRangeAccent2,
            
            /// <summary>
            /// Enum GradientLoopAccent2 for "GradientLoopAccent2"
            /// </summary>
            GradientLoopAccent2,
            
            /// <summary>
            /// Enum TransparentGradientRangeAccent2 for "TransparentGradientRangeAccent2"
            /// </summary>
            TransparentGradientRangeAccent2,
            
            /// <summary>
            /// Enum ColoredOutlineAccent3 for "ColoredOutlineAccent3"
            /// </summary>
            ColoredOutlineAccent3,
            
            /// <summary>
            /// Enum ColoredFillAccent3 for "ColoredFillAccent3"
            /// </summary>
            ColoredFillAccent3,
            
            /// <summary>
            /// Enum GradientRangeAccent3 for "GradientRangeAccent3"
            /// </summary>
            GradientRangeAccent3,
            
            /// <summary>
            /// Enum GradientLoopAccent3 for "GradientLoopAccent3"
            /// </summary>
            GradientLoopAccent3,
            
            /// <summary>
            /// Enum TransparentGradientRangeAccent3 for "TransparentGradientRangeAccent3"
            /// </summary>
            TransparentGradientRangeAccent3,
            
            /// <summary>
            /// Enum ColoredOutlineAccent4 for "ColoredOutlineAccent4"
            /// </summary>
            ColoredOutlineAccent4,
            
            /// <summary>
            /// Enum ColoredFillAccent4 for "ColoredFillAccent4"
            /// </summary>
            ColoredFillAccent4,
            
            /// <summary>
            /// Enum GradientRangeAccent4 for "GradientRangeAccent4"
            /// </summary>
            GradientRangeAccent4,
            
            /// <summary>
            /// Enum GradientLoopAccent4 for "GradientLoopAccent4"
            /// </summary>
            GradientLoopAccent4,
            
            /// <summary>
            /// Enum TransparentGradientRangeAccent4 for "TransparentGradientRangeAccent4"
            /// </summary>
            TransparentGradientRangeAccent4,
            
            /// <summary>
            /// Enum ColoredOutlineAccent5 for "ColoredOutlineAccent5"
            /// </summary>
            ColoredOutlineAccent5,
            
            /// <summary>
            /// Enum ColoredFillAccent5 for "ColoredFillAccent5"
            /// </summary>
            ColoredFillAccent5,
            
            /// <summary>
            /// Enum GradientRangeAccent5 for "GradientRangeAccent5"
            /// </summary>
            GradientRangeAccent5,
            
            /// <summary>
            /// Enum GradientLoopAccent5 for "GradientLoopAccent5"
            /// </summary>
            GradientLoopAccent5,
            
            /// <summary>
            /// Enum TransparentGradientRangeAccent5 for "TransparentGradientRangeAccent5"
            /// </summary>
            TransparentGradientRangeAccent5,
            
            /// <summary>
            /// Enum ColoredOutlineAccent6 for "ColoredOutlineAccent6"
            /// </summary>
            ColoredOutlineAccent6,
            
            /// <summary>
            /// Enum ColoredFillAccent6 for "ColoredFillAccent6"
            /// </summary>
            ColoredFillAccent6,
            
            /// <summary>
            /// Enum GradientRangeAccent6 for "GradientRangeAccent6"
            /// </summary>
            GradientRangeAccent6,
            
            /// <summary>
            /// Enum GradientLoopAccent6 for "GradientLoopAccent6"
            /// </summary>
            GradientLoopAccent6,
            
            /// <summary>
            /// Enum TransparentGradientRangeAccent6 for "TransparentGradientRangeAccent6"
            /// </summary>
            TransparentGradientRangeAccent6
        }

        /// <summary>
        /// Layout type.
        /// </summary>
        public LayoutEnum? Layout { get; set; }

        /// <summary>
        /// Quick style.
        /// </summary>
        public QuickStyleEnum? QuickStyle { get; set; }

        /// <summary>
        /// Color style.
        /// </summary>
        public ColorStyleEnum? ColorStyle { get; set; }

        /// <summary>
        /// Collection of nodes in SmartArt object.             
        /// </summary>
        public List<SmartArtNode> Nodes { get; set; }

        /// <summary>
        /// The state of the SmartArt diagram with regard to (left-to-right) LTR or (right-to-left) RTL, if the diagram supports reversal.
        /// </summary>
        public bool? IsReversed { get; set; }


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
                    s_typeDeterminers.Add("Type", TypeEnum.SmartArt);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SmartArt() : base()
        {
            Type = TypeEnum.SmartArt;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class SmartArt {\n");
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
            sb.Append("  Layout: ").Append(this.Layout).Append("\n");
            sb.Append("  QuickStyle: ").Append(this.QuickStyle).Append("\n");
            sb.Append("  ColorStyle: ").Append(this.ColorStyle).Append("\n");
            sb.Append("  Nodes: ").Append(this.Nodes).Append("\n");
            sb.Append("  IsReversed: ").Append(this.IsReversed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
