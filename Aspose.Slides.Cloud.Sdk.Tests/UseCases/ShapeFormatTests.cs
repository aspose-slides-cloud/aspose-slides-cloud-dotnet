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

using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing shape formats
    /// </summary>
    [TestFixture]
    public class ShapeFormatTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void ShapeFormatLine()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shape dto = new Shape
            {
                LineFormat = new LineFormat { Style = LineFormat.StyleEnum.ThickThin, Width = 7, DashStyle = LineFormat.DashStyleEnum.Dash }
            };
            ShapeBase shape = TestUtils.SlidesApi.UpdateShape(c_fileName, c_slideIndex, c_shapeIndex, dto, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
            shape = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
            Assert.AreEqual(dto.LineFormat.Width, shape.LineFormat.Width);
        }

        [Test]
        public void ShapeFormatFill()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shape dto = new Shape
            {
                FillFormat = new SolidFill { Color = "#FFFFFF00" }
            };
            ShapeBase shape = TestUtils.SlidesApi.UpdateShape(c_fileName, c_slideIndex, c_shapeIndex, dto, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
            shape = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
            Assert.IsInstanceOf<SolidFill>(shape.FillFormat);
            Assert.AreEqual(((SolidFill)dto.FillFormat).Color, ((SolidFill)shape.FillFormat).Color);
        }

        [Test]
        public void ShapeFormatEffect()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shape dto = new Shape
            {
                EffectFormat = new EffectFormat
                {
                    InnerShadow = new InnerShadowEffect { Direction = 35, BlurRadius = 30, Distance = 40, ShadowColor = "#FFFFFF00" }
                }
            };
            ShapeBase shape = TestUtils.SlidesApi.UpdateShape(c_fileName, c_slideIndex, c_shapeIndex, dto, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
            shape = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
            Assert.AreEqual(dto.EffectFormat.InnerShadow.Direction, shape.EffectFormat.InnerShadow.Direction);
        }

        [Test]
        public void ShapeFormat3D()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shape dto = new Shape
            {
                ThreeDFormat = new ThreeDFormat
                {
                    Depth = 4,
                    BevelTop = new ShapeBevel { BevelType = ShapeBevel.BevelTypeEnum.Circle, Height = 6, Width = 6 },
                    Camera = new Camera { CameraType = Camera.CameraTypeEnum.OrthographicFront },
                    LightRig = new LightRig { LightType = LightRig.LightTypeEnum.ThreePt, Direction = LightRig.DirectionEnum.Top }
                }
            };
            ShapeBase shape = TestUtils.SlidesApi.UpdateShape(c_fileName, c_slideIndex, c_shapeIndex, dto, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
            shape = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
            Assert.AreEqual(dto.ThreeDFormat.Depth, shape.ThreeDFormat.Depth);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 1;
        const int c_shapeIndex = 1;
    }
}
