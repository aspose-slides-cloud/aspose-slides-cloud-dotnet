// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SmartArtLayoutType.cs">
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
    /// Represents layout type of a SmartArt diagram.
    /// </summary>
    /// <value>Represents layout type of a SmartArt diagram.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmartArtLayoutType
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
        Custom
    }

}
