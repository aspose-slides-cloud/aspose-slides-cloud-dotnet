// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CombinedShapeType.cs">
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
    /// <value></value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CombinedShapeType
    {
        
        /// <summary>
        /// Enum Custom for 0
        /// </summary>
        Custom,
        
        /// <summary>
        /// Enum Line for 1
        /// </summary>
        Line,
        
        /// <summary>
        /// Enum LineInverse for 2
        /// </summary>
        LineInverse,
        
        /// <summary>
        /// Enum Triangle for 3
        /// </summary>
        Triangle,
        
        /// <summary>
        /// Enum RightTriangle for 4
        /// </summary>
        RightTriangle,
        
        /// <summary>
        /// Enum Rectangle for 5
        /// </summary>
        Rectangle,
        
        /// <summary>
        /// Enum Diamond for 6
        /// </summary>
        Diamond,
        
        /// <summary>
        /// Enum Parallelogram for 7
        /// </summary>
        Parallelogram,
        
        /// <summary>
        /// Enum Trapezoid for 8
        /// </summary>
        Trapezoid,
        
        /// <summary>
        /// Enum NonIsoscelesTrapezoid for 9
        /// </summary>
        NonIsoscelesTrapezoid,
        
        /// <summary>
        /// Enum Pentagon for 10
        /// </summary>
        Pentagon,
        
        /// <summary>
        /// Enum Hexagon for 11
        /// </summary>
        Hexagon,
        
        /// <summary>
        /// Enum Heptagon for 12
        /// </summary>
        Heptagon,
        
        /// <summary>
        /// Enum Octagon for 13
        /// </summary>
        Octagon,
        
        /// <summary>
        /// Enum Decagon for 14
        /// </summary>
        Decagon,
        
        /// <summary>
        /// Enum Dodecagon for 15
        /// </summary>
        Dodecagon,
        
        /// <summary>
        /// Enum FourPointedStar for 16
        /// </summary>
        FourPointedStar,
        
        /// <summary>
        /// Enum FivePointedStar for 17
        /// </summary>
        FivePointedStar,
        
        /// <summary>
        /// Enum SixPointedStar for 18
        /// </summary>
        SixPointedStar,
        
        /// <summary>
        /// Enum SevenPointedStar for 19
        /// </summary>
        SevenPointedStar,
        
        /// <summary>
        /// Enum EightPointedStar for 20
        /// </summary>
        EightPointedStar,
        
        /// <summary>
        /// Enum TenPointedStar for 21
        /// </summary>
        TenPointedStar,
        
        /// <summary>
        /// Enum TwelvePointedStar for 22
        /// </summary>
        TwelvePointedStar,
        
        /// <summary>
        /// Enum SixteenPointedStar for 23
        /// </summary>
        SixteenPointedStar,
        
        /// <summary>
        /// Enum TwentyFourPointedStar for 24
        /// </summary>
        TwentyFourPointedStar,
        
        /// <summary>
        /// Enum ThirtyTwoPointedStar for 25
        /// </summary>
        ThirtyTwoPointedStar,
        
        /// <summary>
        /// Enum RoundCornerRectangle for 26
        /// </summary>
        RoundCornerRectangle,
        
        /// <summary>
        /// Enum OneRoundCornerRectangle for 27
        /// </summary>
        OneRoundCornerRectangle,
        
        /// <summary>
        /// Enum TwoSamesideRoundCornerRectangle for 28
        /// </summary>
        TwoSamesideRoundCornerRectangle,
        
        /// <summary>
        /// Enum TwoDiagonalRoundCornerRectangle for 29
        /// </summary>
        TwoDiagonalRoundCornerRectangle,
        
        /// <summary>
        /// Enum OneSnipOneRoundCornerRectangle for 30
        /// </summary>
        OneSnipOneRoundCornerRectangle,
        
        /// <summary>
        /// Enum OneSnipCornerRectangle for 31
        /// </summary>
        OneSnipCornerRectangle,
        
        /// <summary>
        /// Enum TwoSamesideSnipCornerRectangle for 32
        /// </summary>
        TwoSamesideSnipCornerRectangle,
        
        /// <summary>
        /// Enum TwoDiagonalSnipCornerRectangle for 33
        /// </summary>
        TwoDiagonalSnipCornerRectangle,
        
        /// <summary>
        /// Enum Plaque for 34
        /// </summary>
        Plaque,
        
        /// <summary>
        /// Enum Ellipse for 35
        /// </summary>
        Ellipse,
        
        /// <summary>
        /// Enum Teardrop for 36
        /// </summary>
        Teardrop,
        
        /// <summary>
        /// Enum HomePlate for 37
        /// </summary>
        HomePlate,
        
        /// <summary>
        /// Enum Chevron for 38
        /// </summary>
        Chevron,
        
        /// <summary>
        /// Enum PieWedge for 39
        /// </summary>
        PieWedge,
        
        /// <summary>
        /// Enum Pie for 40
        /// </summary>
        Pie,
        
        /// <summary>
        /// Enum BlockArc for 41
        /// </summary>
        BlockArc,
        
        /// <summary>
        /// Enum Donut for 42
        /// </summary>
        Donut,
        
        /// <summary>
        /// Enum NoSmoking for 43
        /// </summary>
        NoSmoking,
        
        /// <summary>
        /// Enum RightArrow for 44
        /// </summary>
        RightArrow,
        
        /// <summary>
        /// Enum LeftArrow for 45
        /// </summary>
        LeftArrow,
        
        /// <summary>
        /// Enum UpArrow for 46
        /// </summary>
        UpArrow,
        
        /// <summary>
        /// Enum DownArrow for 47
        /// </summary>
        DownArrow,
        
        /// <summary>
        /// Enum StripedRightArrow for 48
        /// </summary>
        StripedRightArrow,
        
        /// <summary>
        /// Enum NotchedRightArrow for 49
        /// </summary>
        NotchedRightArrow,
        
        /// <summary>
        /// Enum BentUpArrow for 50
        /// </summary>
        BentUpArrow,
        
        /// <summary>
        /// Enum LeftRightArrow for 51
        /// </summary>
        LeftRightArrow,
        
        /// <summary>
        /// Enum UpDownArrow for 52
        /// </summary>
        UpDownArrow,
        
        /// <summary>
        /// Enum LeftUpArrow for 53
        /// </summary>
        LeftUpArrow,
        
        /// <summary>
        /// Enum LeftRightUpArrow for 54
        /// </summary>
        LeftRightUpArrow,
        
        /// <summary>
        /// Enum QuadArrow for 55
        /// </summary>
        QuadArrow,
        
        /// <summary>
        /// Enum CalloutLeftArrow for 56
        /// </summary>
        CalloutLeftArrow,
        
        /// <summary>
        /// Enum CalloutRightArrow for 57
        /// </summary>
        CalloutRightArrow,
        
        /// <summary>
        /// Enum CalloutUpArrow for 58
        /// </summary>
        CalloutUpArrow,
        
        /// <summary>
        /// Enum CalloutDownArrow for 59
        /// </summary>
        CalloutDownArrow,
        
        /// <summary>
        /// Enum CalloutLeftRightArrow for 60
        /// </summary>
        CalloutLeftRightArrow,
        
        /// <summary>
        /// Enum CalloutUpDownArrow for 61
        /// </summary>
        CalloutUpDownArrow,
        
        /// <summary>
        /// Enum CalloutQuadArrow for 62
        /// </summary>
        CalloutQuadArrow,
        
        /// <summary>
        /// Enum BentArrow for 63
        /// </summary>
        BentArrow,
        
        /// <summary>
        /// Enum UTurnArrow for 64
        /// </summary>
        UTurnArrow,
        
        /// <summary>
        /// Enum CircularArrow for 65
        /// </summary>
        CircularArrow,
        
        /// <summary>
        /// Enum LeftCircularArrow for 66
        /// </summary>
        LeftCircularArrow,
        
        /// <summary>
        /// Enum LeftRightCircularArrow for 67
        /// </summary>
        LeftRightCircularArrow,
        
        /// <summary>
        /// Enum CurvedRightArrow for 68
        /// </summary>
        CurvedRightArrow,
        
        /// <summary>
        /// Enum CurvedLeftArrow for 69
        /// </summary>
        CurvedLeftArrow,
        
        /// <summary>
        /// Enum CurvedUpArrow for 70
        /// </summary>
        CurvedUpArrow,
        
        /// <summary>
        /// Enum CurvedDownArrow for 71
        /// </summary>
        CurvedDownArrow,
        
        /// <summary>
        /// Enum SwooshArrow for 72
        /// </summary>
        SwooshArrow,
        
        /// <summary>
        /// Enum Cube for 73
        /// </summary>
        Cube,
        
        /// <summary>
        /// Enum Can for 74
        /// </summary>
        Can,
        
        /// <summary>
        /// Enum LightningBolt for 75
        /// </summary>
        LightningBolt,
        
        /// <summary>
        /// Enum Heart for 76
        /// </summary>
        Heart,
        
        /// <summary>
        /// Enum Sun for 77
        /// </summary>
        Sun,
        
        /// <summary>
        /// Enum Moon for 78
        /// </summary>
        Moon,
        
        /// <summary>
        /// Enum SmileyFace for 79
        /// </summary>
        SmileyFace,
        
        /// <summary>
        /// Enum IrregularSeal1 for 80
        /// </summary>
        IrregularSeal1,
        
        /// <summary>
        /// Enum IrregularSeal2 for 81
        /// </summary>
        IrregularSeal2,
        
        /// <summary>
        /// Enum FoldedCorner for 82
        /// </summary>
        FoldedCorner,
        
        /// <summary>
        /// Enum Bevel for 83
        /// </summary>
        Bevel,
        
        /// <summary>
        /// Enum Frame for 84
        /// </summary>
        Frame,
        
        /// <summary>
        /// Enum HalfFrame for 85
        /// </summary>
        HalfFrame,
        
        /// <summary>
        /// Enum Corner for 86
        /// </summary>
        Corner,
        
        /// <summary>
        /// Enum DiagonalStripe for 87
        /// </summary>
        DiagonalStripe,
        
        /// <summary>
        /// Enum Chord for 88
        /// </summary>
        Chord,
        
        /// <summary>
        /// Enum CurvedArc for 89
        /// </summary>
        CurvedArc,
        
        /// <summary>
        /// Enum LeftBracket for 90
        /// </summary>
        LeftBracket,
        
        /// <summary>
        /// Enum RightBracket for 91
        /// </summary>
        RightBracket,
        
        /// <summary>
        /// Enum LeftBrace for 92
        /// </summary>
        LeftBrace,
        
        /// <summary>
        /// Enum RightBrace for 93
        /// </summary>
        RightBrace,
        
        /// <summary>
        /// Enum BracketPair for 94
        /// </summary>
        BracketPair,
        
        /// <summary>
        /// Enum BracePair for 95
        /// </summary>
        BracePair,
        
        /// <summary>
        /// Enum StraightConnector1 for 96
        /// </summary>
        StraightConnector1,
        
        /// <summary>
        /// Enum BentConnector2 for 97
        /// </summary>
        BentConnector2,
        
        /// <summary>
        /// Enum BentConnector3 for 98
        /// </summary>
        BentConnector3,
        
        /// <summary>
        /// Enum BentConnector4 for 99
        /// </summary>
        BentConnector4,
        
        /// <summary>
        /// Enum BentConnector5 for 100
        /// </summary>
        BentConnector5,
        
        /// <summary>
        /// Enum CurvedConnector2 for 101
        /// </summary>
        CurvedConnector2,
        
        /// <summary>
        /// Enum CurvedConnector3 for 102
        /// </summary>
        CurvedConnector3,
        
        /// <summary>
        /// Enum CurvedConnector4 for 103
        /// </summary>
        CurvedConnector4,
        
        /// <summary>
        /// Enum CurvedConnector5 for 104
        /// </summary>
        CurvedConnector5,
        
        /// <summary>
        /// Enum Callout1 for 105
        /// </summary>
        Callout1,
        
        /// <summary>
        /// Enum Callout2 for 106
        /// </summary>
        Callout2,
        
        /// <summary>
        /// Enum Callout3 for 107
        /// </summary>
        Callout3,
        
        /// <summary>
        /// Enum Callout1WithAccent for 108
        /// </summary>
        Callout1WithAccent,
        
        /// <summary>
        /// Enum Callout2WithAccent for 109
        /// </summary>
        Callout2WithAccent,
        
        /// <summary>
        /// Enum Callout3WithAccent for 110
        /// </summary>
        Callout3WithAccent,
        
        /// <summary>
        /// Enum Callout1WithBorder for 111
        /// </summary>
        Callout1WithBorder,
        
        /// <summary>
        /// Enum Callout2WithBorder for 112
        /// </summary>
        Callout2WithBorder,
        
        /// <summary>
        /// Enum Callout3WithBorder for 113
        /// </summary>
        Callout3WithBorder,
        
        /// <summary>
        /// Enum Callout1WithBorderAndAccent for 114
        /// </summary>
        Callout1WithBorderAndAccent,
        
        /// <summary>
        /// Enum Callout2WithBorderAndAccent for 115
        /// </summary>
        Callout2WithBorderAndAccent,
        
        /// <summary>
        /// Enum Callout3WithBorderAndAccent for 116
        /// </summary>
        Callout3WithBorderAndAccent,
        
        /// <summary>
        /// Enum CalloutWedgeRectangle for 117
        /// </summary>
        CalloutWedgeRectangle,
        
        /// <summary>
        /// Enum CalloutWedgeRoundRectangle for 118
        /// </summary>
        CalloutWedgeRoundRectangle,
        
        /// <summary>
        /// Enum CalloutWedgeEllipse for 119
        /// </summary>
        CalloutWedgeEllipse,
        
        /// <summary>
        /// Enum CalloutCloud for 120
        /// </summary>
        CalloutCloud,
        
        /// <summary>
        /// Enum Cloud for 121
        /// </summary>
        Cloud,
        
        /// <summary>
        /// Enum Ribbon for 122
        /// </summary>
        Ribbon,
        
        /// <summary>
        /// Enum Ribbon2 for 123
        /// </summary>
        Ribbon2,
        
        /// <summary>
        /// Enum EllipseRibbon for 124
        /// </summary>
        EllipseRibbon,
        
        /// <summary>
        /// Enum EllipseRibbon2 for 125
        /// </summary>
        EllipseRibbon2,
        
        /// <summary>
        /// Enum LeftRightRibbon for 126
        /// </summary>
        LeftRightRibbon,
        
        /// <summary>
        /// Enum VerticalScroll for 127
        /// </summary>
        VerticalScroll,
        
        /// <summary>
        /// Enum HorizontalScroll for 128
        /// </summary>
        HorizontalScroll,
        
        /// <summary>
        /// Enum Wave for 129
        /// </summary>
        Wave,
        
        /// <summary>
        /// Enum DoubleWave for 130
        /// </summary>
        DoubleWave,
        
        /// <summary>
        /// Enum Plus for 131
        /// </summary>
        Plus,
        
        /// <summary>
        /// Enum ProcessFlow for 132
        /// </summary>
        ProcessFlow,
        
        /// <summary>
        /// Enum DecisionFlow for 133
        /// </summary>
        DecisionFlow,
        
        /// <summary>
        /// Enum InputOutputFlow for 134
        /// </summary>
        InputOutputFlow,
        
        /// <summary>
        /// Enum PredefinedProcessFlow for 135
        /// </summary>
        PredefinedProcessFlow,
        
        /// <summary>
        /// Enum InternalStorageFlow for 136
        /// </summary>
        InternalStorageFlow,
        
        /// <summary>
        /// Enum DocumentFlow for 137
        /// </summary>
        DocumentFlow,
        
        /// <summary>
        /// Enum MultiDocumentFlow for 138
        /// </summary>
        MultiDocumentFlow,
        
        /// <summary>
        /// Enum TerminatorFlow for 139
        /// </summary>
        TerminatorFlow,
        
        /// <summary>
        /// Enum PreparationFlow for 140
        /// </summary>
        PreparationFlow,
        
        /// <summary>
        /// Enum ManualInputFlow for 141
        /// </summary>
        ManualInputFlow,
        
        /// <summary>
        /// Enum ManualOperationFlow for 142
        /// </summary>
        ManualOperationFlow,
        
        /// <summary>
        /// Enum ConnectorFlow for 143
        /// </summary>
        ConnectorFlow,
        
        /// <summary>
        /// Enum PunchedCardFlow for 144
        /// </summary>
        PunchedCardFlow,
        
        /// <summary>
        /// Enum PunchedTapeFlow for 145
        /// </summary>
        PunchedTapeFlow,
        
        /// <summary>
        /// Enum SummingJunctionFlow for 146
        /// </summary>
        SummingJunctionFlow,
        
        /// <summary>
        /// Enum OrFlow for 147
        /// </summary>
        OrFlow,
        
        /// <summary>
        /// Enum CollateFlow for 148
        /// </summary>
        CollateFlow,
        
        /// <summary>
        /// Enum SortFlow for 149
        /// </summary>
        SortFlow,
        
        /// <summary>
        /// Enum ExtractFlow for 150
        /// </summary>
        ExtractFlow,
        
        /// <summary>
        /// Enum MergeFlow for 151
        /// </summary>
        MergeFlow,
        
        /// <summary>
        /// Enum OfflineStorageFlow for 152
        /// </summary>
        OfflineStorageFlow,
        
        /// <summary>
        /// Enum OnlineStorageFlow for 153
        /// </summary>
        OnlineStorageFlow,
        
        /// <summary>
        /// Enum MagneticTapeFlow for 154
        /// </summary>
        MagneticTapeFlow,
        
        /// <summary>
        /// Enum MagneticDiskFlow for 155
        /// </summary>
        MagneticDiskFlow,
        
        /// <summary>
        /// Enum MagneticDrumFlow for 156
        /// </summary>
        MagneticDrumFlow,
        
        /// <summary>
        /// Enum DisplayFlow for 157
        /// </summary>
        DisplayFlow,
        
        /// <summary>
        /// Enum DelayFlow for 158
        /// </summary>
        DelayFlow,
        
        /// <summary>
        /// Enum AlternateProcessFlow for 159
        /// </summary>
        AlternateProcessFlow,
        
        /// <summary>
        /// Enum OffPageConnectorFlow for 160
        /// </summary>
        OffPageConnectorFlow,
        
        /// <summary>
        /// Enum BlankButton for 161
        /// </summary>
        BlankButton,
        
        /// <summary>
        /// Enum HomeButton for 162
        /// </summary>
        HomeButton,
        
        /// <summary>
        /// Enum HelpButton for 163
        /// </summary>
        HelpButton,
        
        /// <summary>
        /// Enum InformationButton for 164
        /// </summary>
        InformationButton,
        
        /// <summary>
        /// Enum ForwardOrNextButton for 165
        /// </summary>
        ForwardOrNextButton,
        
        /// <summary>
        /// Enum BackOrPreviousButton for 166
        /// </summary>
        BackOrPreviousButton,
        
        /// <summary>
        /// Enum EndButton for 167
        /// </summary>
        EndButton,
        
        /// <summary>
        /// Enum BeginningButton for 168
        /// </summary>
        BeginningButton,
        
        /// <summary>
        /// Enum ReturnButton for 169
        /// </summary>
        ReturnButton,
        
        /// <summary>
        /// Enum DocumentButton for 170
        /// </summary>
        DocumentButton,
        
        /// <summary>
        /// Enum SoundButton for 171
        /// </summary>
        SoundButton,
        
        /// <summary>
        /// Enum MovieButton for 172
        /// </summary>
        MovieButton,
        
        /// <summary>
        /// Enum Gear6 for 173
        /// </summary>
        Gear6,
        
        /// <summary>
        /// Enum Gear9 for 174
        /// </summary>
        Gear9,
        
        /// <summary>
        /// Enum Funnel for 175
        /// </summary>
        Funnel,
        
        /// <summary>
        /// Enum PlusMath for 176
        /// </summary>
        PlusMath,
        
        /// <summary>
        /// Enum MinusMath for 177
        /// </summary>
        MinusMath,
        
        /// <summary>
        /// Enum MultiplyMath for 178
        /// </summary>
        MultiplyMath,
        
        /// <summary>
        /// Enum DivideMath for 179
        /// </summary>
        DivideMath,
        
        /// <summary>
        /// Enum EqualMath for 180
        /// </summary>
        EqualMath,
        
        /// <summary>
        /// Enum NotEqualMath for 181
        /// </summary>
        NotEqualMath,
        
        /// <summary>
        /// Enum CornerTabs for 182
        /// </summary>
        CornerTabs,
        
        /// <summary>
        /// Enum SquareTabs for 183
        /// </summary>
        SquareTabs,
        
        /// <summary>
        /// Enum PlaqueTabs for 184
        /// </summary>
        PlaqueTabs,
        
        /// <summary>
        /// Enum ChartX for 185
        /// </summary>
        ChartX,
        
        /// <summary>
        /// Enum ChartStar for 186
        /// </summary>
        ChartStar,
        
        /// <summary>
        /// Enum ChartPlus for 187
        /// </summary>
        ChartPlus,
        
        /// <summary>
        /// Enum Chart for 188
        /// </summary>
        Chart,
        
        /// <summary>
        /// Enum Table for 189
        /// </summary>
        Table,
        
        /// <summary>
        /// Enum PictureFrame for 190
        /// </summary>
        PictureFrame,
        
        /// <summary>
        /// Enum VideoFrame for 191
        /// </summary>
        VideoFrame,
        
        /// <summary>
        /// Enum AudioFrame for 192
        /// </summary>
        AudioFrame,
        
        /// <summary>
        /// Enum Diagram for 193
        /// </summary>
        Diagram,
        
        /// <summary>
        /// Enum OleObjectFrame for 194
        /// </summary>
        OleObjectFrame,
        
        /// <summary>
        /// Enum GroupShape for 195
        /// </summary>
        GroupShape,
        
        /// <summary>
        /// Enum GraphicalObject for 196
        /// </summary>
        GraphicalObject,
        
        /// <summary>
        /// Enum NotDefined for -1
        /// </summary>
        NotDefined
    }

}
