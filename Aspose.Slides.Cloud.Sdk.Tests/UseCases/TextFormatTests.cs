// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PropertyTests.cs">
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
    [TestFixture]
    public class TextFormatTests : BaseTests
    {
        [Test]
        public void TextFormat3D()
        {
            Shape dto = new Shape()
            {
                ShapeType = GeometryShape.ShapeTypeEnum.Rectangle,
                X = 100, Y = 100, Height = 100, Width = 200,
                Text = "Sample text"
            };
            
            dto.TextFrameFormat = new TextFrameFormat
            {
                Transform = TextFrameFormat.TransformEnum.ArchUpPour,
                ThreeDFormat = new ThreeDFormat
                {
                    BevelBottom = new ShapeBevel()
                    {
                        BevelType = ShapeBevel.BevelTypeEnum.Circle,
                        Height = 3.5,
                        Width = 3.5
                    },
                    
                    BevelTop = new ShapeBevel()
                    {
                        BevelType = ShapeBevel.BevelTypeEnum.Circle,
                        Height = 4,
                        Width = 4
                    },
                    ExtrusionColor = "#FF008000",
                    ExtrusionHeight = 6,
                    
                    ContourColor = "#FF25353D",
                    ContourWidth = 1.5,
                    Depth = 3,
                    Material = ThreeDFormat.MaterialEnum.Plastic,
                    
                    LightRig = new LightRig()
                    {
                        LightType = LightRig.LightTypeEnum.Balanced,
                        Direction = LightRig.DirectionEnum.Top,
                        XRotation = 0,
                        YRotation = 0,
                        ZRotation = 40
                    },
                    Camera = new Camera()
                    {
                        CameraType = Camera.CameraTypeEnum.PerspectiveContrastingRightFacing
                    }
                }
            };
            
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
        }
        
        [Test]
        public void TextFrameFormatTest()
        {
            Shape dto = new Shape()
            {
                ShapeType = GeometryShape.ShapeTypeEnum.Rectangle,
                X = 100, Y = 100, Height = 100, Width = 200,
                Text = "Sample text"
            };
            
            dto.TextFrameFormat = new TextFrameFormat()
            {
                MarginLeft = 2,
                MarginRight = 2,
                MarginTop = 2,
                MarginBottom = 2,
                CenterText = TextFrameFormat.CenterTextEnum.True,
                DefaultParagraphFormat = new ParagraphFormat()
                {
                    BulletFillFormat = new SolidFill()
                    {
                        Color = "#FF0000"
                    }
                }
            };
            
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(c_fileName, c_slideIndex, dto, password: c_password, folder: c_folderName);
            Assert.IsInstanceOf<Shape>(shape);
        }
        
        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 1;
    }
}