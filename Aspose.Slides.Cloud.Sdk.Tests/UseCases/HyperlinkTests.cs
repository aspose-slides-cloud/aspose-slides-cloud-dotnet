// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartTests.cs">
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
using System.Collections.Generic;
using System.IO;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing math methods & objects
    /// </summary>
    [TestFixture]
    public class HyperlinkTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void HyperlinkGetShape()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase shape = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, c_password, c_folderName);
            Assert.IsNotNull(shape.HyperlinkClick);
            Assert.AreEqual(Hyperlink.ActionTypeEnum.Hyperlink, shape.HyperlinkClick.ActionType);
            Assert.IsNull(shape.HyperlinkMouseOver);
        }

        [Test]
        public void HyperlinkGetPortion()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion portion = TestUtils.SlidesApi.GetPortion(c_fileName, c_slideIndex, c_hoverShapeIndex, c_paragraphIndex, c_portionIndex, c_password, c_folderName);
            Assert.IsNull(portion.HyperlinkClick);
            Assert.IsNotNull(portion.HyperlinkMouseOver);
            Assert.AreEqual(Hyperlink.ActionTypeEnum.JumpLastSlide, portion.HyperlinkMouseOver.ActionType);
        }

        [Test]
        public void HyperlinkCreateShape()
        {
            const int slideIndex = 1;
            const int shapeIndex = 1;
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shape shape = new Shape
            {
                HyperlinkClick = new Hyperlink { ActionType = Hyperlink.ActionTypeEnum.Hyperlink, ExternalUrl = "https://docs.aspose.cloud/slides" }
            };
            Shape updatedShape = (Shape)TestUtils.SlidesApi.UpdateShape(
                c_fileName, slideIndex, shapeIndex, shape, password: c_password, folder: c_folderName);
            Assert.IsNotNull(updatedShape.HyperlinkClick);
            Assert.AreEqual(shape.HyperlinkClick.ExternalUrl, updatedShape.HyperlinkClick.ExternalUrl);
        }

        [Test]
        public void HyperlinkCreatePortion()
        {
            const int slideIndex = 1;
            const int shapeIndex = 1;
            const int paragraphIndex = 1;
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion dto = new Portion
            {
                Text = "Link text",
                HyperlinkMouseOver = new Hyperlink { ActionType = Hyperlink.ActionTypeEnum.JumpLastSlide }
            };
            Portion updatedPortion = TestUtils.SlidesApi.CreatePortion(
                c_fileName, slideIndex, shapeIndex, paragraphIndex, dto, password: c_password, folder: c_folderName);
            Assert.IsNotNull(updatedPortion.HyperlinkMouseOver);
            Assert.AreEqual(dto.HyperlinkMouseOver.ActionType, updatedPortion.HyperlinkMouseOver.ActionType);
        }

        [Test]
        public void HyperlinkDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PictureFrame shape = new PictureFrame
            {
                HyperlinkClick = new Hyperlink { IsDisabled = true }
            };
            ShapeBase updatedShape = TestUtils.SlidesApi.UpdateShape(
                c_fileName, c_slideIndex, c_shapeIndex, shape, password: c_password, folder: c_folderName);
            Assert.IsNull(updatedShape.HyperlinkClick);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 2;
        const int c_shapeIndex = 2;
        const int c_hoverShapeIndex = 1;
        const int c_paragraphIndex = 1;
        const int c_portionIndex = 2;
    }
}
