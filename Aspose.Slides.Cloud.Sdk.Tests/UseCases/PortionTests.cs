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

using System.Collections.Generic;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    [TestFixture]
    public class PortionTests : BaseTests
    {
        [Test]
        public void GetPortions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions response = TestUtils.SlidesApi.GetPortions(c_fileName, c_slideIndex, c_shapeIndex,
                c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(2, response.Items.Count);
        }

        [Test]
        public void GetSubshapePortions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions response = TestUtils.SlidesApi.GetSubshapePortions(c_fileName, c_slideIndex, c_shapePath, 1,
                c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(2, response.Items.Count);
        }

        [Test]
        public void GetPortion()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion response = TestUtils.SlidesApi.GetPortion(c_fileName, c_slideIndex, c_shapeIndex, c_paragraphIndex,
                c_portionIndex, c_password, c_folderName);
            Assert.IsTrue(response.Text.Contains(c_portionText));
        }

        [Test]
        public void GetSubshapePortion()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion response = TestUtils.SlidesApi.GetSubshapePortion(c_fileName, c_slideIndex, c_shapePath, 1,
                c_paragraphIndex, c_portionIndex, c_password, c_folderName);
            Assert.IsTrue(response.Text.Contains(c_portionText));
        }

        [Test]
        public void CreatePortion()
        {
            Portion dto = new Portion()
            {
                Text = c_newPortionText,
                FontBold = Portion.FontBoldEnum.True,
                FontHeight = 20,
                LatinFont = c_fontName,
                FillFormat = new SolidFill()
                {
                    Color = c_fontColor
                }
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion response = TestUtils.SlidesApi.CreatePortion(c_fileName, c_slideIndex, c_shapeIndex, 1, dto,
                null, c_password, c_folderName);

            Assert.AreEqual(dto.Text, response.Text);
            Assert.AreEqual(dto.FontBold, response.FontBold);
            Assert.AreEqual(dto.FontHeight, response.FontHeight);
            Assert.AreEqual(dto.LatinFont, c_fontName);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
        }

        [Test]
        public void CreateSubshapePortion()
        {
            Portion dto = new Portion()
            {
                Text = c_newPortionText,
                FontBold = Portion.FontBoldEnum.True,
                FontHeight = 20,
                LatinFont = c_fontName,
                FillFormat = new SolidFill()
                {
                    Color = c_fontColor
                }
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion response = TestUtils.SlidesApi.CreateSubshapePortion(c_fileName, c_slideIndex, c_shapePath,
                c_shapeIndex, 1, dto,
                null, c_password, c_folderName);

            Assert.AreEqual(dto.Text, response.Text);
            Assert.AreEqual(dto.FontBold, response.FontBold);
            Assert.AreEqual(dto.FontHeight, response.FontHeight);
            Assert.AreEqual(dto.LatinFont, c_fontName);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
        }

        [Test]
        public void UpdatePortion()
        {
            Portion dto = new Portion()
            {
                Text = c_newPortionText,
                FontBold = Portion.FontBoldEnum.True,
                FontHeight = 20,
                LatinFont = c_fontName,
                FillFormat = new SolidFill()
                {
                    Color = c_fontColor
                }
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion response = TestUtils.SlidesApi.UpdatePortion(c_fileName, c_slideIndex, c_shapeIndex, 1,
                1, dto, c_password, c_folderName);

            Assert.AreEqual(dto.Text, response.Text);
            Assert.AreEqual(dto.FontBold, response.FontBold);
            Assert.AreEqual(dto.FontHeight, response.FontHeight);
            Assert.AreEqual(dto.LatinFont, c_fontName);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
        }

        [Test]
        public void UpdateSubshapePortion()
        {
            Portion dto = new Portion()
            {
                Text = c_newPortionText,
                FontBold = Portion.FontBoldEnum.True,
                FontHeight = 20,
                LatinFont = c_fontName,
                FillFormat = new SolidFill()
                {
                    Color = c_fontColor
                }
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion response = TestUtils.SlidesApi.UpdateSubshapePortion(c_fileName, c_slideIndex, c_shapePath,
                c_shapeIndex, 1,
                1, dto, c_password, c_folderName);

            Assert.AreEqual(dto.Text, response.Text);
            Assert.AreEqual(dto.FontBold, response.FontBold);
            Assert.AreEqual(dto.FontHeight, response.FontHeight);
            Assert.AreEqual(dto.LatinFont, c_fontName);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
        }

        [Test]
        public void DeletePortions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions response = TestUtils.SlidesApi.DeletePortions(c_fileName, c_slideIndex, c_shapeIndex,
                c_paragraphIndex, null, c_password, c_folderName);
            Assert.AreEqual(0, response.Items.Count);
        }

        [Test]
        public void DeletePortionsIndexes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions response = TestUtils.SlidesApi.DeletePortions(c_fileName, c_slideIndex, c_shapeIndex,
                c_paragraphIndex, new List<int> { 1 }, c_password, c_folderName);
            Assert.AreEqual(1, response.Items.Count);
        }

        [Test]
        public void DeleteSubshapePortions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions response = TestUtils.SlidesApi.DeleteSubshapePortions(c_fileName, c_slideIndex, c_shapePath,
                1, c_paragraphIndex, null, c_password, c_folderName);
            Assert.AreEqual(0, response.Items.Count);
        }

        [Test]
        public void DeleteSubshapePortionsIndexes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions response = TestUtils.SlidesApi.DeleteSubshapePortions(c_fileName, c_slideIndex, c_shapePath,
                1, c_paragraphIndex, new List<int> { 1 }, c_password, c_folderName);
            Assert.AreEqual(1, response.Items.Count);
        }

        [Test]
        public void DeletePortion()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions response = TestUtils.SlidesApi.DeletePortion(c_fileName, c_slideIndex, c_shapeIndex,
                c_paragraphIndex, c_portionIndex, c_password, c_folderName);
            Assert.AreEqual(1, response.Items.Count);
        }

        [Test]
        public void DeleteSubshapePortion()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions response = TestUtils.SlidesApi.DeleteSubshapePortion(c_fileName, c_slideIndex, c_shapePath,
                1, c_paragraphIndex, c_portionIndex, c_password, c_folderName);
            Assert.AreEqual(1, response.Items.Count);
        }

        [Test]
        public void GetPortionRect()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TextBounds response = TestUtils.SlidesApi.GetPortionRectangle(c_fileName, c_slideIndex, c_shapeIndex,
                c_paragraphIndex, c_portionIndex, c_password,
                c_folderName);

            Assert.IsNotNull(response);
            Assert.Greater(response.X, 0);
            Assert.Greater(response.Y, 0);
            Assert.Greater(response.Width, 0);
            Assert.Greater(response.Height, 0);
        }
        
        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 6;
        const int c_shapeIndex = 2;
        const int c_paragraphIndex = 1;
        const int c_portionIndex = 1;
        const string c_portionText = "portion 1";
        const string c_newPortionText = "new portion text";
        const string c_fontColor = "#FFF5FF8A";
        const string c_shapePath = "3/shapes";
        const string c_fontName = "Arial";
    }
}