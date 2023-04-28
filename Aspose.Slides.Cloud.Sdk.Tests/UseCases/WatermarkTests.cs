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
using System;
using System.IO;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing watermark methods
    /// </summary>
    [TestFixture]
    public class WatermarkTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void WatermarkTextStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int shapeCount = TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count;

            TestUtils.SlidesApi.CreateWatermark(c_fileName, text: c_watermarkText, password: c_password, folder: c_folderName);
            Assert.AreEqual(shapeCount + 1, TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count);
            Assert.AreEqual(c_watermarkText, ((Shape)TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, shapeCount + 1, c_password, c_folderName)).Text);
            Assert.AreEqual(c_watermarkName, ((Shape)TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, shapeCount + 1, c_password, c_folderName)).Name);

            TestUtils.SlidesApi.DeleteWatermark(c_fileName, password: c_password, folder: c_folderName);
            Assert.AreEqual(shapeCount, TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count);
        }

        [Test]
        public void WatermarkTextDtoStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int shapeCount = TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count;

            TestUtils.SlidesApi.CreateWatermark(c_fileName, new Shape { Text = c_watermarkText }, password: c_password, folder: c_folderName);
            Assert.AreEqual(shapeCount + 1, TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count);
            Assert.AreEqual(c_watermarkText, ((Shape)TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, shapeCount + 1, c_password, c_folderName)).Text);
            Assert.AreEqual(c_watermarkName, ((Shape)TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, shapeCount + 1, c_password, c_folderName)).Name);

            TestUtils.SlidesApi.DeleteWatermark(c_fileName, password: c_password, folder: c_folderName);
            Assert.AreEqual(shapeCount, TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count);
        }

        [Test]
        public void WatermarkImageStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int shapeCount = TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count;

            Stream watermarkFile = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_watermarkFileName));
            TestUtils.SlidesApi.CreateImageWatermark(c_fileName, watermarkFile, password: c_password, folder: c_folderName);
            Assert.AreEqual(shapeCount + 1, TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count);
            Assert.AreEqual(c_watermarkName, ((Shape)TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, shapeCount + 1, c_password, c_folderName)).Name);

            TestUtils.SlidesApi.DeleteWatermark(c_fileName, password: c_password, folder: c_folderName);
            Assert.AreEqual(shapeCount, TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count);
        }

        [Test]
        public void WatermarkImageDtoStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int shapeCount = TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count;

            string base64Data = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(TestUtils.TestDataPath, c_watermarkFileName)));
            PictureFrame pictureFrame = new PictureFrame { FillFormat = new PictureFill { Base64Data = base64Data } };
            TestUtils.SlidesApi.CreateImageWatermark(c_fileName, pictureFrame: pictureFrame, password: c_password, folder: c_folderName);
            Assert.AreEqual(shapeCount + 1, TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count);
            Assert.AreEqual(c_watermarkName, ((Shape)TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, shapeCount + 1, c_password, c_folderName)).Name);

            TestUtils.SlidesApi.DeleteWatermark(c_fileName, password: c_password, folder: c_folderName);
            Assert.AreEqual(shapeCount, TestUtils.SlidesApi.GetShapes(c_fileName, c_slideIndex, c_password, c_folderName).ShapesLinks.Count);
        }

        [Test]
        public void WatermarkTextRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream documentWithWatermarks = TestUtils.SlidesApi.CreateWatermarkOnline(document, text: c_watermarkText, password: c_password);
            Stream documentWithNoWatermarks = TestUtils.SlidesApi.DeleteWatermarkOnline(document, password: c_password);
            Assert.AreNotEqual(document.Length, documentWithWatermarks.Length);
            Assert.Less(documentWithNoWatermarks.Length, documentWithWatermarks.Length);
        }

        [Test]
        public void WatermarkTextDtoRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream documentWithWatermarks = TestUtils.SlidesApi.CreateWatermarkOnline(document, new Shape { Text = c_watermarkText }, password: c_password);
            Stream documentWithNoWatermarks = TestUtils.SlidesApi.DeleteWatermarkOnline(document, password: c_password);
            Assert.AreNotEqual(document.Length, documentWithWatermarks.Length);
            Assert.Less(documentWithNoWatermarks.Length, documentWithWatermarks.Length);
        }

        [Test]
        public void WatermarkImageRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream watermarkFile = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_watermarkFileName));
            Stream documentWithWatermarks = TestUtils.SlidesApi.CreateImageWatermarkOnline(document, watermarkFile, password: c_password);
            Stream documentWithNoWatermarks = TestUtils.SlidesApi.DeleteWatermarkOnline(document, password: c_password);
            Assert.AreNotEqual(document.Length, documentWithWatermarks.Length);
            Assert.Less(documentWithNoWatermarks.Length, documentWithWatermarks.Length);
        }

        [Test]
        public void WatermarkImageDtoRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            string base64Data = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(TestUtils.TestDataPath, c_watermarkFileName)));
            PictureFrame pictureFrame = new PictureFrame { FillFormat = new PictureFill { Base64Data = base64Data } };
            Stream documentWithWatermarks = TestUtils.SlidesApi.CreateImageWatermarkOnline(document, pictureFrame: pictureFrame, password: c_password);
            Stream documentWithNoWatermarks = TestUtils.SlidesApi.DeleteWatermarkOnline(document, password: c_password);
            Assert.AreNotEqual(document.Length, documentWithWatermarks.Length);
            Assert.Less(documentWithNoWatermarks.Length, documentWithWatermarks.Length);
        }

        const string c_watermarkName = "watermark";
        const string c_watermarkText = "watermarkText";
        const string c_watermarkFileName = "watermark.png";
        const int c_slideIndex = 3;
    }
}
