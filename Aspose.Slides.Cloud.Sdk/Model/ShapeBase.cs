// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeBase.cs">
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
  public class ShapeBase : ResourceBase 
  {                       
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Shape for "Shape"
            /// </summary>
            Shape,
            
            /// <summary>
            /// Enum Chart for "Chart"
            /// </summary>
            Chart,
            
            /// <summary>
            /// Enum Table for "Table"
            /// </summary>
            Table,
            
            /// <summary>
            /// Enum PictureFrame for "PictureFrame"
            /// </summary>
            PictureFrame,
            
            /// <summary>
            /// Enum VideoFrame for "VideoFrame"
            /// </summary>
            VideoFrame,
            
            /// <summary>
            /// Enum AudioFrame for "AudioFrame"
            /// </summary>
            AudioFrame,
            
            /// <summary>
            /// Enum SmartArt for "SmartArt"
            /// </summary>
            SmartArt,
            
            /// <summary>
            /// Enum OleObjectFrame for "OleObjectFrame"
            /// </summary>
            OleObjectFrame,
            
            /// <summary>
            /// Enum GroupShape for "GroupShape"
            /// </summary>
            GroupShape,
            
            /// <summary>
            /// Enum GraphicalObject for "GraphicalObject"
            /// </summary>
            GraphicalObject,
            
            /// <summary>
            /// Enum Connector for "Connector"
            /// </summary>
            Connector,
            
            /// <summary>
            /// Enum SmartArtShape for "SmartArtShape"
            /// </summary>
            SmartArtShape
        }

        /// <summary>
        /// Gets or Sets ShapeType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShapeTypeEnum
        {
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            Custom,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            Line,
            
            /// <summary>
            /// Enum LineInverse for "LineInverse"
            /// </summary>
            LineInverse,
            
            /// <summary>
            /// Enum Triangle for "Triangle"
            /// </summary>
            Triangle,
            
            /// <summary>
            /// Enum RightTriangle for "RightTriangle"
            /// </summary>
            RightTriangle,
            
            /// <summary>
            /// Enum Rectangle for "Rectangle"
            /// </summary>
            Rectangle,
            
            /// <summary>
            /// Enum Diamond for "Diamond"
            /// </summary>
            Diamond,
            
            /// <summary>
            /// Enum Parallelogram for "Parallelogram"
            /// </summary>
            Parallelogram,
            
            /// <summary>
            /// Enum Trapezoid for "Trapezoid"
            /// </summary>
            Trapezoid,
            
            /// <summary>
            /// Enum NonIsoscelesTrapezoid for "NonIsoscelesTrapezoid"
            /// </summary>
            NonIsoscelesTrapezoid,
            
            /// <summary>
            /// Enum Pentagon for "Pentagon"
            /// </summary>
            Pentagon,
            
            /// <summary>
            /// Enum Hexagon for "Hexagon"
            /// </summary>
            Hexagon,
            
            /// <summary>
            /// Enum Heptagon for "Heptagon"
            /// </summary>
            Heptagon,
            
            /// <summary>
            /// Enum Octagon for "Octagon"
            /// </summary>
            Octagon,
            
            /// <summary>
            /// Enum Decagon for "Decagon"
            /// </summary>
            Decagon,
            
            /// <summary>
            /// Enum Dodecagon for "Dodecagon"
            /// </summary>
            Dodecagon,
            
            /// <summary>
            /// Enum FourPointedStar for "FourPointedStar"
            /// </summary>
            FourPointedStar,
            
            /// <summary>
            /// Enum FivePointedStar for "FivePointedStar"
            /// </summary>
            FivePointedStar,
            
            /// <summary>
            /// Enum SixPointedStar for "SixPointedStar"
            /// </summary>
            SixPointedStar,
            
            /// <summary>
            /// Enum SevenPointedStar for "SevenPointedStar"
            /// </summary>
            SevenPointedStar,
            
            /// <summary>
            /// Enum EightPointedStar for "EightPointedStar"
            /// </summary>
            EightPointedStar,
            
            /// <summary>
            /// Enum TenPointedStar for "TenPointedStar"
            /// </summary>
            TenPointedStar,
            
            /// <summary>
            /// Enum TwelvePointedStar for "TwelvePointedStar"
            /// </summary>
            TwelvePointedStar,
            
            /// <summary>
            /// Enum SixteenPointedStar for "SixteenPointedStar"
            /// </summary>
            SixteenPointedStar,
            
            /// <summary>
            /// Enum TwentyFourPointedStar for "TwentyFourPointedStar"
            /// </summary>
            TwentyFourPointedStar,
            
            /// <summary>
            /// Enum ThirtyTwoPointedStar for "ThirtyTwoPointedStar"
            /// </summary>
            ThirtyTwoPointedStar,
            
            /// <summary>
            /// Enum RoundCornerRectangle for "RoundCornerRectangle"
            /// </summary>
            RoundCornerRectangle,
            
            /// <summary>
            /// Enum OneRoundCornerRectangle for "OneRoundCornerRectangle"
            /// </summary>
            OneRoundCornerRectangle,
            
            /// <summary>
            /// Enum TwoSamesideRoundCornerRectangle for "TwoSamesideRoundCornerRectangle"
            /// </summary>
            TwoSamesideRoundCornerRectangle,
            
            /// <summary>
            /// Enum TwoDiagonalRoundCornerRectangle for "TwoDiagonalRoundCornerRectangle"
            /// </summary>
            TwoDiagonalRoundCornerRectangle,
            
            /// <summary>
            /// Enum OneSnipOneRoundCornerRectangle for "OneSnipOneRoundCornerRectangle"
            /// </summary>
            OneSnipOneRoundCornerRectangle,
            
            /// <summary>
            /// Enum OneSnipCornerRectangle for "OneSnipCornerRectangle"
            /// </summary>
            OneSnipCornerRectangle,
            
            /// <summary>
            /// Enum TwoSamesideSnipCornerRectangle for "TwoSamesideSnipCornerRectangle"
            /// </summary>
            TwoSamesideSnipCornerRectangle,
            
            /// <summary>
            /// Enum TwoDiagonalSnipCornerRectangle for "TwoDiagonalSnipCornerRectangle"
            /// </summary>
            TwoDiagonalSnipCornerRectangle,
            
            /// <summary>
            /// Enum Plaque for "Plaque"
            /// </summary>
            Plaque,
            
            /// <summary>
            /// Enum Ellipse for "Ellipse"
            /// </summary>
            Ellipse,
            
            /// <summary>
            /// Enum Teardrop for "Teardrop"
            /// </summary>
            Teardrop,
            
            /// <summary>
            /// Enum HomePlate for "HomePlate"
            /// </summary>
            HomePlate,
            
            /// <summary>
            /// Enum Chevron for "Chevron"
            /// </summary>
            Chevron,
            
            /// <summary>
            /// Enum PieWedge for "PieWedge"
            /// </summary>
            PieWedge,
            
            /// <summary>
            /// Enum Pie for "Pie"
            /// </summary>
            Pie,
            
            /// <summary>
            /// Enum BlockArc for "BlockArc"
            /// </summary>
            BlockArc,
            
            /// <summary>
            /// Enum Donut for "Donut"
            /// </summary>
            Donut,
            
            /// <summary>
            /// Enum NoSmoking for "NoSmoking"
            /// </summary>
            NoSmoking,
            
            /// <summary>
            /// Enum RightArrow for "RightArrow"
            /// </summary>
            RightArrow,
            
            /// <summary>
            /// Enum LeftArrow for "LeftArrow"
            /// </summary>
            LeftArrow,
            
            /// <summary>
            /// Enum UpArrow for "UpArrow"
            /// </summary>
            UpArrow,
            
            /// <summary>
            /// Enum DownArrow for "DownArrow"
            /// </summary>
            DownArrow,
            
            /// <summary>
            /// Enum StripedRightArrow for "StripedRightArrow"
            /// </summary>
            StripedRightArrow,
            
            /// <summary>
            /// Enum NotchedRightArrow for "NotchedRightArrow"
            /// </summary>
            NotchedRightArrow,
            
            /// <summary>
            /// Enum BentUpArrow for "BentUpArrow"
            /// </summary>
            BentUpArrow,
            
            /// <summary>
            /// Enum LeftRightArrow for "LeftRightArrow"
            /// </summary>
            LeftRightArrow,
            
            /// <summary>
            /// Enum UpDownArrow for "UpDownArrow"
            /// </summary>
            UpDownArrow,
            
            /// <summary>
            /// Enum LeftUpArrow for "LeftUpArrow"
            /// </summary>
            LeftUpArrow,
            
            /// <summary>
            /// Enum LeftRightUpArrow for "LeftRightUpArrow"
            /// </summary>
            LeftRightUpArrow,
            
            /// <summary>
            /// Enum QuadArrow for "QuadArrow"
            /// </summary>
            QuadArrow,
            
            /// <summary>
            /// Enum CalloutLeftArrow for "CalloutLeftArrow"
            /// </summary>
            CalloutLeftArrow,
            
            /// <summary>
            /// Enum CalloutRightArrow for "CalloutRightArrow"
            /// </summary>
            CalloutRightArrow,
            
            /// <summary>
            /// Enum CalloutUpArrow for "CalloutUpArrow"
            /// </summary>
            CalloutUpArrow,
            
            /// <summary>
            /// Enum CalloutDownArrow for "CalloutDownArrow"
            /// </summary>
            CalloutDownArrow,
            
            /// <summary>
            /// Enum CalloutLeftRightArrow for "CalloutLeftRightArrow"
            /// </summary>
            CalloutLeftRightArrow,
            
            /// <summary>
            /// Enum CalloutUpDownArrow for "CalloutUpDownArrow"
            /// </summary>
            CalloutUpDownArrow,
            
            /// <summary>
            /// Enum CalloutQuadArrow for "CalloutQuadArrow"
            /// </summary>
            CalloutQuadArrow,
            
            /// <summary>
            /// Enum BentArrow for "BentArrow"
            /// </summary>
            BentArrow,
            
            /// <summary>
            /// Enum UTurnArrow for "UTurnArrow"
            /// </summary>
            UTurnArrow,
            
            /// <summary>
            /// Enum CircularArrow for "CircularArrow"
            /// </summary>
            CircularArrow,
            
            /// <summary>
            /// Enum LeftCircularArrow for "LeftCircularArrow"
            /// </summary>
            LeftCircularArrow,
            
            /// <summary>
            /// Enum LeftRightCircularArrow for "LeftRightCircularArrow"
            /// </summary>
            LeftRightCircularArrow,
            
            /// <summary>
            /// Enum CurvedRightArrow for "CurvedRightArrow"
            /// </summary>
            CurvedRightArrow,
            
            /// <summary>
            /// Enum CurvedLeftArrow for "CurvedLeftArrow"
            /// </summary>
            CurvedLeftArrow,
            
            /// <summary>
            /// Enum CurvedUpArrow for "CurvedUpArrow"
            /// </summary>
            CurvedUpArrow,
            
            /// <summary>
            /// Enum CurvedDownArrow for "CurvedDownArrow"
            /// </summary>
            CurvedDownArrow,
            
            /// <summary>
            /// Enum SwooshArrow for "SwooshArrow"
            /// </summary>
            SwooshArrow,
            
            /// <summary>
            /// Enum Cube for "Cube"
            /// </summary>
            Cube,
            
            /// <summary>
            /// Enum Can for "Can"
            /// </summary>
            Can,
            
            /// <summary>
            /// Enum LightningBolt for "LightningBolt"
            /// </summary>
            LightningBolt,
            
            /// <summary>
            /// Enum Heart for "Heart"
            /// </summary>
            Heart,
            
            /// <summary>
            /// Enum Sun for "Sun"
            /// </summary>
            Sun,
            
            /// <summary>
            /// Enum Moon for "Moon"
            /// </summary>
            Moon,
            
            /// <summary>
            /// Enum SmileyFace for "SmileyFace"
            /// </summary>
            SmileyFace,
            
            /// <summary>
            /// Enum IrregularSeal1 for "IrregularSeal1"
            /// </summary>
            IrregularSeal1,
            
            /// <summary>
            /// Enum IrregularSeal2 for "IrregularSeal2"
            /// </summary>
            IrregularSeal2,
            
            /// <summary>
            /// Enum FoldedCorner for "FoldedCorner"
            /// </summary>
            FoldedCorner,
            
            /// <summary>
            /// Enum Bevel for "Bevel"
            /// </summary>
            Bevel,
            
            /// <summary>
            /// Enum Frame for "Frame"
            /// </summary>
            Frame,
            
            /// <summary>
            /// Enum HalfFrame for "HalfFrame"
            /// </summary>
            HalfFrame,
            
            /// <summary>
            /// Enum Corner for "Corner"
            /// </summary>
            Corner,
            
            /// <summary>
            /// Enum DiagonalStripe for "DiagonalStripe"
            /// </summary>
            DiagonalStripe,
            
            /// <summary>
            /// Enum Chord for "Chord"
            /// </summary>
            Chord,
            
            /// <summary>
            /// Enum CurvedArc for "CurvedArc"
            /// </summary>
            CurvedArc,
            
            /// <summary>
            /// Enum LeftBracket for "LeftBracket"
            /// </summary>
            LeftBracket,
            
            /// <summary>
            /// Enum RightBracket for "RightBracket"
            /// </summary>
            RightBracket,
            
            /// <summary>
            /// Enum LeftBrace for "LeftBrace"
            /// </summary>
            LeftBrace,
            
            /// <summary>
            /// Enum RightBrace for "RightBrace"
            /// </summary>
            RightBrace,
            
            /// <summary>
            /// Enum BracketPair for "BracketPair"
            /// </summary>
            BracketPair,
            
            /// <summary>
            /// Enum BracePair for "BracePair"
            /// </summary>
            BracePair,
            
            /// <summary>
            /// Enum StraightConnector1 for "StraightConnector1"
            /// </summary>
            StraightConnector1,
            
            /// <summary>
            /// Enum BentConnector2 for "BentConnector2"
            /// </summary>
            BentConnector2,
            
            /// <summary>
            /// Enum BentConnector3 for "BentConnector3"
            /// </summary>
            BentConnector3,
            
            /// <summary>
            /// Enum BentConnector4 for "BentConnector4"
            /// </summary>
            BentConnector4,
            
            /// <summary>
            /// Enum BentConnector5 for "BentConnector5"
            /// </summary>
            BentConnector5,
            
            /// <summary>
            /// Enum CurvedConnector2 for "CurvedConnector2"
            /// </summary>
            CurvedConnector2,
            
            /// <summary>
            /// Enum CurvedConnector3 for "CurvedConnector3"
            /// </summary>
            CurvedConnector3,
            
            /// <summary>
            /// Enum CurvedConnector4 for "CurvedConnector4"
            /// </summary>
            CurvedConnector4,
            
            /// <summary>
            /// Enum CurvedConnector5 for "CurvedConnector5"
            /// </summary>
            CurvedConnector5,
            
            /// <summary>
            /// Enum Callout1 for "Callout1"
            /// </summary>
            Callout1,
            
            /// <summary>
            /// Enum Callout2 for "Callout2"
            /// </summary>
            Callout2,
            
            /// <summary>
            /// Enum Callout3 for "Callout3"
            /// </summary>
            Callout3,
            
            /// <summary>
            /// Enum Callout1WithAccent for "Callout1WithAccent"
            /// </summary>
            Callout1WithAccent,
            
            /// <summary>
            /// Enum Callout2WithAccent for "Callout2WithAccent"
            /// </summary>
            Callout2WithAccent,
            
            /// <summary>
            /// Enum Callout3WithAccent for "Callout3WithAccent"
            /// </summary>
            Callout3WithAccent,
            
            /// <summary>
            /// Enum Callout1WithBorder for "Callout1WithBorder"
            /// </summary>
            Callout1WithBorder,
            
            /// <summary>
            /// Enum Callout2WithBorder for "Callout2WithBorder"
            /// </summary>
            Callout2WithBorder,
            
            /// <summary>
            /// Enum Callout3WithBorder for "Callout3WithBorder"
            /// </summary>
            Callout3WithBorder,
            
            /// <summary>
            /// Enum Callout1WithBorderAndAccent for "Callout1WithBorderAndAccent"
            /// </summary>
            Callout1WithBorderAndAccent,
            
            /// <summary>
            /// Enum Callout2WithBorderAndAccent for "Callout2WithBorderAndAccent"
            /// </summary>
            Callout2WithBorderAndAccent,
            
            /// <summary>
            /// Enum Callout3WithBorderAndAccent for "Callout3WithBorderAndAccent"
            /// </summary>
            Callout3WithBorderAndAccent,
            
            /// <summary>
            /// Enum CalloutWedgeRectangle for "CalloutWedgeRectangle"
            /// </summary>
            CalloutWedgeRectangle,
            
            /// <summary>
            /// Enum CalloutWedgeRoundRectangle for "CalloutWedgeRoundRectangle"
            /// </summary>
            CalloutWedgeRoundRectangle,
            
            /// <summary>
            /// Enum CalloutWedgeEllipse for "CalloutWedgeEllipse"
            /// </summary>
            CalloutWedgeEllipse,
            
            /// <summary>
            /// Enum CalloutCloud for "CalloutCloud"
            /// </summary>
            CalloutCloud,
            
            /// <summary>
            /// Enum Cloud for "Cloud"
            /// </summary>
            Cloud,
            
            /// <summary>
            /// Enum Ribbon for "Ribbon"
            /// </summary>
            Ribbon,
            
            /// <summary>
            /// Enum Ribbon2 for "Ribbon2"
            /// </summary>
            Ribbon2,
            
            /// <summary>
            /// Enum EllipseRibbon for "EllipseRibbon"
            /// </summary>
            EllipseRibbon,
            
            /// <summary>
            /// Enum EllipseRibbon2 for "EllipseRibbon2"
            /// </summary>
            EllipseRibbon2,
            
            /// <summary>
            /// Enum LeftRightRibbon for "LeftRightRibbon"
            /// </summary>
            LeftRightRibbon,
            
            /// <summary>
            /// Enum VerticalScroll for "VerticalScroll"
            /// </summary>
            VerticalScroll,
            
            /// <summary>
            /// Enum HorizontalScroll for "HorizontalScroll"
            /// </summary>
            HorizontalScroll,
            
            /// <summary>
            /// Enum Wave for "Wave"
            /// </summary>
            Wave,
            
            /// <summary>
            /// Enum DoubleWave for "DoubleWave"
            /// </summary>
            DoubleWave,
            
            /// <summary>
            /// Enum Plus for "Plus"
            /// </summary>
            Plus,
            
            /// <summary>
            /// Enum ProcessFlow for "ProcessFlow"
            /// </summary>
            ProcessFlow,
            
            /// <summary>
            /// Enum DecisionFlow for "DecisionFlow"
            /// </summary>
            DecisionFlow,
            
            /// <summary>
            /// Enum InputOutputFlow for "InputOutputFlow"
            /// </summary>
            InputOutputFlow,
            
            /// <summary>
            /// Enum PredefinedProcessFlow for "PredefinedProcessFlow"
            /// </summary>
            PredefinedProcessFlow,
            
            /// <summary>
            /// Enum InternalStorageFlow for "InternalStorageFlow"
            /// </summary>
            InternalStorageFlow,
            
            /// <summary>
            /// Enum DocumentFlow for "DocumentFlow"
            /// </summary>
            DocumentFlow,
            
            /// <summary>
            /// Enum MultiDocumentFlow for "MultiDocumentFlow"
            /// </summary>
            MultiDocumentFlow,
            
            /// <summary>
            /// Enum TerminatorFlow for "TerminatorFlow"
            /// </summary>
            TerminatorFlow,
            
            /// <summary>
            /// Enum PreparationFlow for "PreparationFlow"
            /// </summary>
            PreparationFlow,
            
            /// <summary>
            /// Enum ManualInputFlow for "ManualInputFlow"
            /// </summary>
            ManualInputFlow,
            
            /// <summary>
            /// Enum ManualOperationFlow for "ManualOperationFlow"
            /// </summary>
            ManualOperationFlow,
            
            /// <summary>
            /// Enum ConnectorFlow for "ConnectorFlow"
            /// </summary>
            ConnectorFlow,
            
            /// <summary>
            /// Enum PunchedCardFlow for "PunchedCardFlow"
            /// </summary>
            PunchedCardFlow,
            
            /// <summary>
            /// Enum PunchedTapeFlow for "PunchedTapeFlow"
            /// </summary>
            PunchedTapeFlow,
            
            /// <summary>
            /// Enum SummingJunctionFlow for "SummingJunctionFlow"
            /// </summary>
            SummingJunctionFlow,
            
            /// <summary>
            /// Enum OrFlow for "OrFlow"
            /// </summary>
            OrFlow,
            
            /// <summary>
            /// Enum CollateFlow for "CollateFlow"
            /// </summary>
            CollateFlow,
            
            /// <summary>
            /// Enum SortFlow for "SortFlow"
            /// </summary>
            SortFlow,
            
            /// <summary>
            /// Enum ExtractFlow for "ExtractFlow"
            /// </summary>
            ExtractFlow,
            
            /// <summary>
            /// Enum MergeFlow for "MergeFlow"
            /// </summary>
            MergeFlow,
            
            /// <summary>
            /// Enum OfflineStorageFlow for "OfflineStorageFlow"
            /// </summary>
            OfflineStorageFlow,
            
            /// <summary>
            /// Enum OnlineStorageFlow for "OnlineStorageFlow"
            /// </summary>
            OnlineStorageFlow,
            
            /// <summary>
            /// Enum MagneticTapeFlow for "MagneticTapeFlow"
            /// </summary>
            MagneticTapeFlow,
            
            /// <summary>
            /// Enum MagneticDiskFlow for "MagneticDiskFlow"
            /// </summary>
            MagneticDiskFlow,
            
            /// <summary>
            /// Enum MagneticDrumFlow for "MagneticDrumFlow"
            /// </summary>
            MagneticDrumFlow,
            
            /// <summary>
            /// Enum DisplayFlow for "DisplayFlow"
            /// </summary>
            DisplayFlow,
            
            /// <summary>
            /// Enum DelayFlow for "DelayFlow"
            /// </summary>
            DelayFlow,
            
            /// <summary>
            /// Enum AlternateProcessFlow for "AlternateProcessFlow"
            /// </summary>
            AlternateProcessFlow,
            
            /// <summary>
            /// Enum OffPageConnectorFlow for "OffPageConnectorFlow"
            /// </summary>
            OffPageConnectorFlow,
            
            /// <summary>
            /// Enum BlankButton for "BlankButton"
            /// </summary>
            BlankButton,
            
            /// <summary>
            /// Enum HomeButton for "HomeButton"
            /// </summary>
            HomeButton,
            
            /// <summary>
            /// Enum HelpButton for "HelpButton"
            /// </summary>
            HelpButton,
            
            /// <summary>
            /// Enum InformationButton for "InformationButton"
            /// </summary>
            InformationButton,
            
            /// <summary>
            /// Enum ForwardOrNextButton for "ForwardOrNextButton"
            /// </summary>
            ForwardOrNextButton,
            
            /// <summary>
            /// Enum BackOrPreviousButton for "BackOrPreviousButton"
            /// </summary>
            BackOrPreviousButton,
            
            /// <summary>
            /// Enum EndButton for "EndButton"
            /// </summary>
            EndButton,
            
            /// <summary>
            /// Enum BeginningButton for "BeginningButton"
            /// </summary>
            BeginningButton,
            
            /// <summary>
            /// Enum ReturnButton for "ReturnButton"
            /// </summary>
            ReturnButton,
            
            /// <summary>
            /// Enum DocumentButton for "DocumentButton"
            /// </summary>
            DocumentButton,
            
            /// <summary>
            /// Enum SoundButton for "SoundButton"
            /// </summary>
            SoundButton,
            
            /// <summary>
            /// Enum MovieButton for "MovieButton"
            /// </summary>
            MovieButton,
            
            /// <summary>
            /// Enum Gear6 for "Gear6"
            /// </summary>
            Gear6,
            
            /// <summary>
            /// Enum Gear9 for "Gear9"
            /// </summary>
            Gear9,
            
            /// <summary>
            /// Enum Funnel for "Funnel"
            /// </summary>
            Funnel,
            
            /// <summary>
            /// Enum PlusMath for "PlusMath"
            /// </summary>
            PlusMath,
            
            /// <summary>
            /// Enum MinusMath for "MinusMath"
            /// </summary>
            MinusMath,
            
            /// <summary>
            /// Enum MultiplyMath for "MultiplyMath"
            /// </summary>
            MultiplyMath,
            
            /// <summary>
            /// Enum DivideMath for "DivideMath"
            /// </summary>
            DivideMath,
            
            /// <summary>
            /// Enum EqualMath for "EqualMath"
            /// </summary>
            EqualMath,
            
            /// <summary>
            /// Enum NotEqualMath for "NotEqualMath"
            /// </summary>
            NotEqualMath,
            
            /// <summary>
            /// Enum CornerTabs for "CornerTabs"
            /// </summary>
            CornerTabs,
            
            /// <summary>
            /// Enum SquareTabs for "SquareTabs"
            /// </summary>
            SquareTabs,
            
            /// <summary>
            /// Enum PlaqueTabs for "PlaqueTabs"
            /// </summary>
            PlaqueTabs,
            
            /// <summary>
            /// Enum ChartX for "ChartX"
            /// </summary>
            ChartX,
            
            /// <summary>
            /// Enum ChartStar for "ChartStar"
            /// </summary>
            ChartStar,
            
            /// <summary>
            /// Enum ChartPlus for "ChartPlus"
            /// </summary>
            ChartPlus,
            
            /// <summary>
            /// Enum Chart for "Chart"
            /// </summary>
            Chart,
            
            /// <summary>
            /// Enum Table for "Table"
            /// </summary>
            Table,
            
            /// <summary>
            /// Enum PictureFrame for "PictureFrame"
            /// </summary>
            PictureFrame,
            
            /// <summary>
            /// Enum VideoFrame for "VideoFrame"
            /// </summary>
            VideoFrame,
            
            /// <summary>
            /// Enum AudioFrame for "AudioFrame"
            /// </summary>
            AudioFrame,
            
            /// <summary>
            /// Enum Diagram for "Diagram"
            /// </summary>
            Diagram,
            
            /// <summary>
            /// Enum OleObjectFrame for "OleObjectFrame"
            /// </summary>
            OleObjectFrame,
            
            /// <summary>
            /// Enum GroupShape for "GroupShape"
            /// </summary>
            GroupShape,
            
            /// <summary>
            /// Enum GraphicalObject for "GraphicalObject"
            /// </summary>
            GraphicalObject,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Gets or sets Type
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or sets ShapeType
        /// </summary>
        public ShapeTypeEnum? ShapeType { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// Gets or sets the alternative text.
        /// </summary>
        public string AlternativeText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this ShapeBase is hidden.
        /// </summary>
        public bool? Hidden { get; set; }

        /// <summary>
        /// Gets or sets the X
        /// </summary>
        public double? X { get; set; }

        /// <summary>
        /// Gets or sets the Y.
        /// </summary>
        public double? Y { get; set; }

        /// <summary>
        /// Gets z-order position of shape
        /// </summary>
        public int? ZOrderPosition { get; set; }

        /// <summary>
        /// Gets or sets the link to shapes.
        /// </summary>
        public ResourceUriElement Shapes { get; set; }

        /// <summary>
        /// Gets or sets the fill format.
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Gets or sets the effect format.
        /// </summary>
        public EffectFormat EffectFormat { get; set; }

        /// <summary>
        /// Gets or sets the line format.
        /// </summary>
        public LineFormat LineFormat { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public ShapeBase() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ShapeBase {\n");
          sb.Append("  SelfUri: ").Append(this.SelfUri).Append("\n");
          sb.Append("  AlternateLinks: ").Append(this.AlternateLinks).Append("\n");
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
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  ShapeType: ").Append(this.ShapeType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
