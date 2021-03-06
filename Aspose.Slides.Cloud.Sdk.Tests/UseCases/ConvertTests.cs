// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertTests.cs">
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

using System.IO;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Timeout config parameter
    /// </summary>
    [TestFixture]
    public class ConvertTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void ConvertPostFromRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream converted = TestUtils.SlidesApi.Convert(file, c_format, c_password);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertPutFromRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            TestUtils.SlidesApi.ConvertAndSave(file, c_format, c_outPath, c_password);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertPostFromStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream converted = TestUtils.SlidesApi.DownloadPresentation(c_fileName, c_format, password: c_password, folder: c_folderName);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertPutFromStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.SavePresentation(c_fileName, c_format, c_outPath, password: c_password, folder: c_folderName);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertWithOptions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream converted = TestUtils.SlidesApi.DownloadPresentation(c_fileName, c_format, password: c_password, folder: c_folderName);
            ExportOptions options = new PdfExportOptions { DrawSlidesFrame = true };
            Stream convertedWithOptions = TestUtils.SlidesApi.DownloadPresentation(c_fileName, c_format, options, c_password, c_folderName);
            Assert.AreNotEqual(converted.Length, convertedWithOptions.Length);
        }

        [Test]
        public void ConvertSlidePostFromRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream converted = TestUtils.SlidesApi.DownloadSlideOnline(file, c_slideIndex, c_slideFormat, password: c_password);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertSlidePutFromRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            TestUtils.SlidesApi.SaveSlideOnline(file, c_slideIndex, c_slideFormat, c_outPath, password: c_password);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertSlidePostFromStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream converted = TestUtils.SlidesApi.DownloadSlide(
                c_fileName, c_slideIndex, c_slideFormat, password: c_password, folder: c_folderName);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertSlidePutFromStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.SaveSlide(c_fileName, c_slideIndex, c_slideFormat, c_outPath, password: c_password, folder: c_folderName);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertSlideWithOptions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream converted = TestUtils.SlidesApi.DownloadSlide(
                c_fileName, c_slideIndex, c_slideFormat, password: c_password, folder: c_folderName);
            ExportOptions options = new PdfExportOptions { DrawSlidesFrame = true };
            Stream convertedWithOptions = TestUtils.SlidesApi.DownloadSlide(
                c_fileName, c_slideIndex, c_slideFormat, options, password: c_password, folder: c_folderName);
            Assert.AreNotEqual(converted.Length, convertedWithOptions.Length);
        }

        [Test]
        public void ConvertShapePostFromRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream converted = TestUtils.SlidesApi.DownloadShapeOnline(
                file, c_slideIndex, c_shapeIndex, c_shapeFormat, password: c_password);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertShapePutFromRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            TestUtils.SlidesApi.SaveShapeOnline(file, c_slideIndex, c_shapeIndex, c_shapeFormat, c_outPath, password: c_password);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertShapePostFromStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream converted = TestUtils.SlidesApi.DownloadShape(
                c_fileName, c_slideIndex, c_shapeIndex, c_shapeFormat, password: c_password, folder: c_folderName);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertShapePutFromStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.SaveShape(
                c_fileName, c_slideIndex, c_shapeIndex, c_shapeFormat, c_outPath, password: c_password, folder: c_folderName);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const string c_outPath = c_folderName + "/converted.pdf";
        const ExportFormat c_format = ExportFormat.Pdf;
        const SlideExportFormat c_slideFormat = SlideExportFormat.Pdf;
        const ShapeExportFormat c_shapeFormat = ShapeExportFormat.Svg;
        const int c_slideIndex = 1;
        const int c_shapeIndex = 3;
    }
}
