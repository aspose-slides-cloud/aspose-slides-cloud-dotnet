// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeTests.cs">
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
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing shape methods
    /// </summary>
    [TestFixture]
    public class ShapeTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void GetShapes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes shapes = TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.AreEqual(2, shapes.ShapesLinks.Count);
        }

        [Test]
        public void GetShapesByType()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes shapes = TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName, null,
                ShapeType.Chart);
            Assert.AreEqual(2, shapes.ShapesLinks.Count);
        }

        [Test]
        public void GetSubShapes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes shapes = TestUtils.SlidesApi.GetShapes(c_fileName, 1, c_password, c_folderName, subShape: "4");
            Assert.AreEqual(2, shapes.ShapesLinks.Count);
        }

        [Test]
        public void GetShape()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, 1, c_password, c_folderName);
            Assert.AreEqual(ShapeBase.TypeEnum.Chart, shape.Type);
        }

        [Test]
        public void GetSubShape()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape = TestUtils.SlidesApi.GetShape(c_fileName, 1, 4, c_password, c_folderName, subShape: "1");
            Assert.AreEqual(ShapeBase.TypeEnum.Shape, shape.Type);
        }

        [Test]
        public void ShapeAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shape dto = new Shape { ShapeType = GeometryShape.ShapeTypeEnum.Callout1 };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
        }

        [Test]
        public void ShapeEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            //Cannot create shape with no ShapeType specified
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new Shape(), password: c_password, folder: c_folderName));
        }

        [Test]
        public void GraphicalObjectEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            //Cannot create a graphical object
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new GraphicalObject(), password: c_password, folder: c_folderName));
        }

        [Test]
        public void PictureFrameAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new PictureFrame
            {
                PictureFillFormat = new PictureFill
                {
                    Base64Data =
                        "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY5g+ffp/AAZTAsWGL27gAAAAAElFTkSuQmCC"
                }
            };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<PictureFrame>(shape);
        }

        [Test]
        public void PictureFrameEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            //Cannot create picture with no data specified
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new PictureFrame(), password: c_password, folder: c_folderName));
        }

        [Test]
        public void AudioFrameAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new AudioFrame { Base64Data = "bXAzc2FtcGxl" };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<AudioFrame>(shape);
        }

        [Test]
        public void AudioFrameEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            //Cannot create audio with no data specified
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new AudioFrame(), password: c_password, folder: c_folderName));
        }

        [Test]
        public void VideoFrameAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new VideoFrame { Base64Data = "bXAzc2FtcGxl" };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<VideoFrame>(shape);
        }

        [Test]
        public void VideoFrameEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            //Cannot create video with no data specified
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new VideoFrame(), password: c_password, folder: c_folderName));
        }

        [Test]
        public void OleObjectFrameEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            //Cannot create an OleObjectFrame
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new OleObjectFrame(), password: c_password, folder: c_folderName));
        }

        [Test]
        public void SmartArtAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new SmartArt
            {
                X = 0,
                Y = 0,
                Width = 300,
                Height = 200,
                Layout = SmartArt.LayoutEnum.BasicProcess,
                QuickStyle = SmartArt.QuickStyleEnum.SimpleFill,
                ColorStyle = SmartArt.ColorStyleEnum.ColoredFillAccent1,
                Nodes = new List<SmartArtNode>
                {
                    new SmartArtNode
                    {
                        Text = "First",
                        OrgChartLayout = SmartArtNode.OrgChartLayoutEnum.Initial,
                        Nodes = new List<SmartArtNode>
                        {
                            new SmartArtNode
                                { Text = "SubFirst", OrgChartLayout = SmartArtNode.OrgChartLayoutEnum.Initial }
                        }
                    },
                    new SmartArtNode { Text = "Second", OrgChartLayout = SmartArtNode.OrgChartLayoutEnum.Initial }
                }
            };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<SmartArt>(shape);
        }

        [Test]
        public void SmartArtTextFormatting()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion portion = new Portion()
            {
                Text = "New text",
                FontHeight = 24,
                FontBold = Portion.FontBoldEnum.True,
                Spacing = 3,
                FillFormat = new SolidFill() { Color = "#FFFFFF00" }
            };

            string targetNodePath = "1/nodes/2";
            int slideIndex = 7;
            Portion response = TestUtils.SlidesApi.UpdatePortion(c_fileName, slideIndex, 1, 1,
                1, portion,
                c_password, c_folderName, subShape: targetNodePath);

            Assert.IsNotNull(response);
            Assert.AreEqual(portion.Text, response.Text);
            Assert.AreEqual(portion.FontHeight, response.FontHeight);
            Assert.AreEqual(portion.FontBold, response.FontBold);
            Assert.AreEqual(portion.Spacing, response.Spacing);
            Assert.AreEqual(((SolidFill)portion.FillFormat).Color, ((SolidFill)response.FillFormat).Color);
        }

        [Test]
        public void SmartArtEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new SmartArt(), password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<SmartArt>(shape);
        }

        [Test] //See ChartTests for non-empty chart examples
        public void ChartEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new Chart(), password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Chart>(shape);
        }

        [Test]
        public void TableAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new Table
            {
                X = 30,
                Y = 20,
                Style = Table.StyleEnum.MediumStyle2Accent1,
                Rows = new List<TableRow>
                {
                    new TableRow
                    {
                        Cells = new List<TableCell>
                        {
                            new TableCell { Text = "0.1" },
                            new TableCell { Text = "0.2" },
                            new TableCell { Text = "0.3" },
                            new TableCell { Text = "0.4" }
                        }
                    },
                    new TableRow
                    {
                        MinimalHeight = 60,
                        Cells = new List<TableCell>
                        {
                            new TableCell { Text = "1" },
                            new TableCell { Text = "2-3", ColSpan = 2, RowSpan = 2 },
                            new TableCell { Text = "4" }
                        }
                    },
                    new TableRow
                    {
                        Cells = new List<TableCell>
                            { new TableCell { Text = "first" }, new TableCell { Text = "last" } }
                    },
                    new TableRow
                    {
                        Cells = new List<TableCell>
                        {
                            new TableCell { Text = "3.1" },
                            new TableCell { Text = "3.2" },
                            new TableCell { Text = "3.3" },
                            new TableCell { Text = "3.4" }
                        }
                    },
                    new TableRow
                    {
                        Cells = new List<TableCell>
                        {
                            new TableCell { Text = "4.1" },
                            new TableCell { Text = "4.2" },
                            new TableCell { Text = "4.3" },
                            new TableCell { Text = "4.4" }
                        }
                    }
                },
                Columns = new List<TableColumn>
                {
                    new TableColumn { Width = 100 },
                    new TableColumn { Width = 100 },
                    new TableColumn { Width = 100 },
                    new TableColumn { Width = 100 }
                },
                FirstRow = true,
                HorizontalBanding = true
            };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<Table>(shape);
        }

        [Test]
        public void TableEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new Table(), password: c_password, folder: c_folderName));
        }

        [Test]
        public void GroupShapeEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new GroupShape(), password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<GroupShape>(shape);
        }

        [Test]
        public void ConnectorAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new Connector
            {
                ShapeType = GeometryShape.ShapeTypeEnum.BentConnector3,
                StartShapeConnectedTo = new ResourceUri
                    { Href = "https://api.aspose.cloud/v3.0/slides/myPresentation.pptx/slides/1/shapes/1" },
                EndShapeConnectedTo = new ResourceUri
                    { Href = "https://api.aspose.cloud/v3.0/slides/myPresentation.pptx/slides/1/shapes/2" }
            };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<Connector>(shape);
        }

        [Test]
        public void ConnectorEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, new Connector(), password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Connector>(shape);
        }

        [Test]
        public void CreateSubShape()
        {
            Shape dto = new Shape()
            {
                ShapeType = GeometryShape.ShapeTypeEnum.Rectangle,
                X = 200,
                Y = 200,
                Width = 50,
                Height = 50
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase response = TestUtils.SlidesApi.CreateShape(c_fileName, 1, dto, password: c_password,
                folder: c_folderName, subShape: "4");

            Assert.IsInstanceOf<Shape>(response);
        }

        [Test]
        public void UpdateShape()
        {
            Shape dto = new Shape()
            {
                Width = 200,
                Height = 200,
                FillFormat = new SolidFill()
                {
                    Color = c_color
                }
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            ShapeBase response = TestUtils.SlidesApi.UpdateShape(c_fileName, 1, 3, dto, c_password,
                c_folderName);

            Assert.IsInstanceOf<Shape>(response);
            Assert.AreEqual(dto.Width, response.Width);
            Assert.AreEqual(dto.Height, response.Height);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
        }

        [Test]
        public void UpdateSubShape()
        {
            Shape dto = new Shape()
            {
                Width = 200,
                Height = 200,
                FillFormat = new GradientFill()
                {
                    Shape = GradientFill.ShapeEnum.Linear,
                    Direction = GradientFill.DirectionEnum.FromCorner1,
                    Stops = new List<GradientFillStop>
                    {
                        new GradientFillStop()
                        {
                            Color = c_color,
                            Position = 0
                        },
                        new GradientFillStop()
                        {
                            Color = c_color,
                            Position = 1
                        }
                    }
                }
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            ShapeBase response = TestUtils.SlidesApi.UpdateShape(c_fileName, 1, 4, dto, c_password,
                c_folderName, subShape: "1");

            Assert.IsInstanceOf<Shape>(response);
            Assert.AreEqual(dto.Width, response.Width);
            Assert.AreEqual(dto.Height, response.Height);
            Assert.IsInstanceOf<GradientFill>(response.FillFormat);
        }

        [Test]
        public void DeleteShapes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes shapes = TestUtils.SlidesApi.DeleteShapes(c_fileName, c_slideIndex, null, c_password, c_folderName);
            Assert.AreEqual(0, shapes.ShapesLinks.Count);
        }

        [Test]
        public void DeleteShapesIndexes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes response = TestUtils.SlidesApi.DeleteShapes(c_fileName, c_slideIndex, new List<int> { 2 },
                c_password, c_folderName);
            Assert.AreEqual(1, response.ShapesLinks.Count);
        }

        [Test]
        public void DeleteSubShapes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes response = TestUtils.SlidesApi.DeleteShapes(c_fileName, 1, null, c_password,
                c_folderName, subShape: "4");
            Assert.AreEqual(0, response.ShapesLinks.Count);
        }

        [Test]
        public void DeleteSubShapesIndexes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes response = TestUtils.SlidesApi.DeleteShapes(c_fileName, 1, new List<int> { 2 }, c_password,
                c_folderName, subShape: "4");
            Assert.AreEqual(1, response.ShapesLinks.Count);
        }

        [Test]
        public void DeleteShape()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes response = TestUtils.SlidesApi.DeleteShape(c_fileName, 1, 4, c_password, c_folderName);
            Assert.AreEqual(3, response.ShapesLinks.Count);
        }

        [Test]
        public void DeleteSubShape()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes response =
                TestUtils.SlidesApi.DeleteShape(c_fileName, 1, 4, c_password, c_folderName, subShape: "1");
            Assert.AreEqual(1, response.ShapesLinks.Count);
        }

        [Test]
        public void ShapesAlign()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape1 = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, 1, c_password, c_folderName);
            ShapeBase shape2 = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, 2, c_password, c_folderName);
            Assert.AreNotEqual(shape1.X, shape2.X);
            Assert.AreNotEqual(shape1.Y, shape2.Y);

            TestUtils.SlidesApi.AlignShapes(
                c_fileName, c_slideIndex, ShapesAlignmentType.AlignTop, null, null, c_password, c_folderName);
            shape1 = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, 1, c_password, c_folderName);
            shape2 = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, 2, c_password, c_folderName);
            Assert.AreNotEqual(shape1.X, shape2.X);
            Assert.AreEqual(shape1.Y.Value, shape2.Y.Value, 1.0);

            TestUtils.SlidesApi.AlignShapes(
                c_fileName, c_slideIndex, ShapesAlignmentType.AlignLeft, true, new List<int> { 1, 2 }, c_password,
                c_folderName);
            shape1 = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, 1, c_password, c_folderName);
            shape2 = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, 2, c_password, c_folderName);
            Assert.AreEqual(shape1.X, shape2.X);
            Assert.AreEqual(shape1.Y.Value, shape2.Y.Value, 1.0);
            Assert.AreEqual(0, shape1.X.Value, 1.0);
        }

        [Test]
        public void ShapesAlignGroup()
        {
            const int slideIndex = 1;
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape1 =
                TestUtils.SlidesApi.GetShape(c_fileName, slideIndex, 4, c_password, c_folderName, subShape: "1");
            ShapeBase shape2 =
                TestUtils.SlidesApi.GetShape(c_fileName, slideIndex, 4, c_password, c_folderName, subShape: "2");
            Assert.AreNotEqual(shape1.X, shape2.X);
            Assert.AreNotEqual(shape1.Y, shape2.Y);

            TestUtils.SlidesApi.AlignShapes(
                c_fileName, slideIndex, ShapesAlignmentType.AlignTop, null, null, c_password, c_folderName, subShape: "4");
            shape1 = TestUtils.SlidesApi.GetShape(c_fileName, slideIndex, 4, c_password, c_folderName, subShape: "1");
            shape2 = TestUtils.SlidesApi.GetShape(c_fileName, slideIndex, 4, c_password, c_folderName, subShape: "2");
            Assert.AreNotEqual(shape1.X, shape2.X);
            Assert.AreEqual(shape1.Y.Value, shape2.Y.Value, 1.0);

            TestUtils.SlidesApi.AlignShapes(
                c_fileName, slideIndex, ShapesAlignmentType.AlignLeft, true, new List<int> { 1, 2 },
                c_password, c_folderName, subShape: "4");
            shape1 = TestUtils.SlidesApi.GetShape(c_fileName, slideIndex, 4, c_password, c_folderName, subShape: "1");
            shape2 = TestUtils.SlidesApi.GetShape(c_fileName, slideIndex, 4, c_password, c_folderName, subShape: "2");
            Assert.AreEqual(shape1.X.Value, shape2.X.Value, 1.0);
            Assert.AreEqual(shape1.Y.Value, shape2.Y.Value, 1.0);
            Assert.AreEqual(0, shape1.X.Value, 1.0);
        }

        [Test]
        public void ShapeGeometryGet()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            GeometryPaths paths = TestUtils.SlidesApi.GetShapeGeometryPath(c_fileName, 4, 2, c_password, c_folderName);
            Assert.IsNotNull(paths.Paths);
            Assert.AreEqual(1, paths.Paths.Count);
        }

        [Test]
        public void ShapeGeometrySet()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            GeometryPaths dto = new GeometryPaths
            {
                Paths = new List<GeometryPath>
                {
                    new GeometryPath
                    {
                        PathData = new List<PathSegment>
                        {
                            new MoveToPathSegment { X = 0, Y = 0 },
                            new LineToPathSegment { X = 0, Y = 200 },
                            new LineToPathSegment { X = 200, Y = 300 },
                            new LineToPathSegment { X = 400, Y = 200 },
                            new LineToPathSegment { X = 400, Y = 0 },
                            new ClosePathSegment()
                        }
                    }
                }
            };
            ShapeBase shape = TestUtils.SlidesApi.SetShapeGeometryPath(c_fileName, 4, 1, dto, c_password, c_folderName);
            Assert.IsNotNull(shape);
        }

        [Test]
        public void ZoomFrameAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ZoomFrame dto = new ZoomFrame()
            {
                X = 20,
                Y = 20,
                Width = 200,
                Height = 100,
                TargetSlideIndex = 2
            };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<ZoomFrame>(shape);
            Assert.AreEqual(((ZoomFrame)shape).TargetSlideIndex, 2);
        }

        [Test]
        public void SectionZoomFrameAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SectionZoomFrame dto = new SectionZoomFrame()
            {
                X = 20,
                Y = 20,
                Width = 200,
                Height = 100,
                TargetSectionIndex = 2
            };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<SectionZoomFrame>(shape);
            Assert.AreEqual(((SectionZoomFrame)shape).TargetSectionIndex, 2);
        }

        [Test]
        public void OleObjectFrameAddByLink()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            OleObjectFrame dto = new OleObjectFrame()
            {
                X = 100,
                Y = 100,
                Width = 200,
                Height = 200,
                LinkPath = c_oleObjectFileName,
                ObjectProgId = "Excel.Sheet.8"
            };

            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<OleObjectFrame>(shape);
            Assert.AreEqual(((OleObjectFrame)shape).LinkPath, dto.LinkPath);
        }

        [Test]
        public void OleObjectFrameAddEmbedded()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_oleObjectFileName));
            byte[] buffer = new byte[file.Length];
            file.Read(buffer, 0, buffer.Length);

            OleObjectFrame dto = new OleObjectFrame()
            {
                X = 100,
                Y = 100,
                Width = 200,
                Height = 200,
                EmbeddedFileBase64Data = Convert.ToBase64String(buffer),
                EmbeddedFileExtension = "xlsx"
            };

            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password,
                folder: c_folderName);
            Assert.IsInstanceOf<OleObjectFrame>(shape);
            Assert.IsNotNull(((OleObjectFrame)shape).EmbeddedFileBase64Data);
            Assert.IsNotEmpty(((OleObjectFrame)shape).EmbeddedFileBase64Data);
        }

        [Test]
        public void GroupShapeAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 5;

            Shapes shapes =
                TestUtils.SlidesApi.GetShapes(c_fileName, slideIndex, password: c_password, folder: c_folderName);
            Assert.AreEqual(0, shapes.ShapesLinks.Count);

            //add GroupShape
            GroupShape dto = new GroupShape();
            TestUtils.SlidesApi.CreateShape(c_fileName, slideIndex, dto, password: c_password, folder: c_folderName);

            //add sub-shapes
            Shape shape1 = new Shape
                { ShapeType = GeometryShape.ShapeTypeEnum.Rectangle, X = 50, Y = 400, Width = 50, Height = 50 };
            Shape shape2 = new Shape
                { ShapeType = GeometryShape.ShapeTypeEnum.Ellipse, X = 150, Y = 400, Width = 50, Height = 50 };
            Shape shape3 = new Shape
                { ShapeType = GeometryShape.ShapeTypeEnum.Triangle, X = 250, Y = 400, Width = 50, Height = 50 };

            TestUtils.SlidesApi.CreateShape(c_fileName, slideIndex, shape1, password: c_password,
                folder: c_folderName, subShape: "1");
            TestUtils.SlidesApi.CreateShape(c_fileName, slideIndex, shape2, password: c_password,
                folder: c_folderName, subShape: "1");
            TestUtils.SlidesApi.CreateShape(c_fileName, slideIndex, shape3, password: c_password,
                folder: c_folderName, subShape: "1");

            shapes = TestUtils.SlidesApi.GetShapes(c_fileName, slideIndex, c_password, c_folderName);
            Assert.AreEqual(1, shapes.ShapesLinks.Count);

            shapes = TestUtils.SlidesApi.GetShapes(c_fileName, slideIndex, c_password, c_folderName, subShape: "1");
            Assert.AreEqual(3, shapes.ShapesLinks.Count);
        }

        [Test]
        public void ImportShapesFromSvg()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_svgFileName));
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 5;

            Shapes response = TestUtils.SlidesApi.ImportShapesFromSvg(c_fileName, slideIndex, file, 50, 50, 300, 300,
                new List<int> { 1, 3, 5 }, false, c_password, c_folderName);
            Assert.AreEqual(3, response.ShapesLinks.Count);
        }


        [Test]
        public void CreateSmartArtNode()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 7;
            int smartArtIndex = 1;
            string newNodeText = "New root node";
            SmartArt response = TestUtils.SlidesApi.CreateSmartArtNode(c_fileName, slideIndex, smartArtIndex, null,
                newNodeText, null, c_password, c_folderName);
            Assert.AreEqual(2, response.Nodes.Count);
            Assert.AreEqual(newNodeText, response.Nodes[1].Text);
        }

        [Test]
        public void CreateSmartArtSubNode()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 7;
            int smartArtIndex = 1;
            string subNodePath = "1";
            string newSubNodeText = "New sub-node";
            SmartArt response = TestUtils.SlidesApi.CreateSmartArtNode(c_fileName, slideIndex, smartArtIndex,
                subNodePath, newSubNodeText, 1, c_password, c_folderName);
            Assert.AreEqual(5, response.Nodes[0].Nodes.Count);
            Assert.AreEqual(newSubNodeText, response.Nodes[0].Nodes[0].Text);
        }

        [Test]
        public void CreateSmartArtSubSubNode()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 7;
            int smartArtIndex = 1;
            string subSubNodePath = "1/nodes/1";
            string newSubNodeText = "New sub-sub-node";
            SmartArt response = TestUtils.SlidesApi.CreateSmartArtNode(c_fileName, slideIndex, smartArtIndex, subSubNodePath,
                newSubNodeText, null, c_password, c_folderName);
            Assert.AreEqual(1, response.Nodes[0].Nodes[0].Nodes.Count);
            Assert.AreEqual(newSubNodeText, response.Nodes[0].Nodes[0].Nodes[0].Text);
        }

        [Test]
        public void DeleteSmartArtNode()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 7;
            int smartArtIndex = 2;
            int nodeIndex = 1;
            SmartArt response = TestUtils.SlidesApi.DeleteSmartArtNode(c_fileName, slideIndex, smartArtIndex, nodeIndex, null,
                c_password, c_folderName);
                
            Assert.AreEqual(2, response.Nodes.Count);
        }

        [Test]
        public void DeleteSmartArtSubNode()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 7;
            int smartArtIndex = 1;
            int nodeIndex = 1;
            string subNodePath = "2";
            SmartArt response = TestUtils.SlidesApi.DeleteSmartArtNode(c_fileName, slideIndex, smartArtIndex, nodeIndex,
                subNodePath, c_password, c_folderName);
            Assert.AreEqual(3, response.Nodes[0].Nodes.Count);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_svgFileName = "shapes.svg";
        const string c_oleObjectFileName = "oleObject.xlsx";
        const string c_password = "password";
        const int c_slideIndex = 3;
        const string c_color = "#FFF5FF8A";
    }
}