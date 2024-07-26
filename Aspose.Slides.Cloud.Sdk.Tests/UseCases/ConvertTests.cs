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

using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing conversion methods
    /// </summary>
    [TestFixture]
    public class ConvertTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void ConvertRequestToRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream converted = TestUtils.SlidesApi.Convert(file, c_format, c_password);
            Stream convertedSlides = TestUtils.SlidesApi.Convert(file, c_format, c_password, slides: new List<int> { 2, 4 });
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.Greater(convertedSlides.Length, 0);
            Assert.Greater(converted.Length, convertedSlides.Length);
            Assert.IsTrue(converted.CanRead);
            Assert.IsTrue(convertedSlides.CanRead);
        }

        [Test]
        public void ConvertRequestToStorage()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            TestUtils.SlidesApi.ConvertAndSave(file, c_format, c_outPath, c_password);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertStorageToRequest()
        {
            const string fileName = "test.pdf";
            TestUtils.Upload(fileName, c_folderName + "/" + fileName);
            Stream converted = TestUtils.SlidesApi.DownloadPresentation(fileName, ExportFormat.Html5, folder: c_folderName);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertStorageToStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.SavePresentation(c_fileName, c_format, c_outPath, password: c_password, folder: c_folderName);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertRequestWithOptions()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream converted = TestUtils.SlidesApi.Convert(file, c_format, password: c_password);
            ExportOptions options = new PdfExportOptions { DrawSlidesFrame = true };
            Stream convertedWithOptions = TestUtils.SlidesApi.Convert(file, c_format, c_password, options: options);
            Assert.AreNotEqual(converted.Length, convertedWithOptions.Length);
        }

        [Test]
        public void ConvertStorageWithOptions()
        {
            ExportFormat format = ExportFormat.Png;
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream converted = TestUtils.SlidesApi.DownloadPresentation(c_fileName, format, password: c_password, folder: c_folderName);
            ExportOptions options = new ImageExportOptions { Width = 480, Height = 360 };
            Stream convertedWithOptions = TestUtils.SlidesApi.DownloadPresentation(c_fileName, format, options, c_password, c_folderName);
            Assert.Greater(converted.Length, convertedWithOptions.Length);
        }

        [Test]
        public void ConvertSlideRequestToRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream converted = TestUtils.SlidesApi.DownloadSlideOnline(file, c_slideIndex, c_slideFormat, password: c_password);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertSlideRequestToStorage()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            TestUtils.SlidesApi.SaveSlideOnline(file, c_slideIndex, c_slideFormat, c_outPath, password: c_password);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertSlideStorageToRequest()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream converted = TestUtils.SlidesApi.DownloadSlide(
                c_fileName, c_slideIndex, c_slideFormat, password: c_password, folder: c_folderName);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertSlideStorageToStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.SaveSlide(c_fileName, c_slideIndex, c_slideFormat, c_outPath, password: c_password, folder: c_folderName);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertSlideRequestWithOptions()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream converted = TestUtils.SlidesApi.DownloadSlideOnline(file, c_slideIndex, c_slideFormat, password: c_password);
            ExportOptions options = new PdfExportOptions { DrawSlidesFrame = true };
            Stream convertedWithOptions = TestUtils.SlidesApi.DownloadSlideOnline(
                file, c_slideIndex, c_slideFormat, password: c_password, options: options);
            Assert.AreNotEqual(converted.Length, convertedWithOptions.Length);
        }

        [Test]
        public void ConvertSlideStorageWithOptions()
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
        public void ConvertShapeRequestToRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream converted = TestUtils.SlidesApi.DownloadShapeOnline(
                file, c_slideIndex, c_shapeIndex, c_shapeFormat, password: c_password);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertShapeRequestToStorage()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            TestUtils.SlidesApi.SaveShapeOnline(file, c_slideIndex, c_shapeIndex, c_shapeFormat, c_outPath, password: c_password);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertShapeStorageToRequest()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream converted = TestUtils.SlidesApi.DownloadShape(
                c_fileName, c_slideIndex, c_shapeIndex, c_shapeFormat, password: c_password, folder: c_folderName);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertSubShapeStorageToRequest()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream converted = TestUtils.SlidesApi.DownloadShape(
                c_fileName, c_slideIndex, 4, c_shapeFormat, password: c_password, folder: c_folderName, subShape:"1");
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertShapeStorageToStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.SaveShape(
                c_fileName, c_slideIndex, c_shapeIndex, c_shapeFormat, c_outPath, password: c_password, folder: c_folderName);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }
        
        [Test]
        public void ConvertSubShapeStorageToStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.SaveShape(
                c_fileName, c_slideIndex, 4, c_shapeFormat, c_outPath, password: c_password,
                folder: c_folderName, subShape: "1");
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }
        
        [Test]
        public void ConvertWithFontFallBackRules()
        {
            List<FontFallbackRule> fontRules = new List<FontFallbackRule>();
            fontRules.Add(new FontFallbackRule()
            {
                RangeStartIndex = c_startUnicodeIndex,
                RangeEndIndex = c_endUnicodeIndex,
                FallbackFontList = new List<string>() { "Vijaya" }
            });

            fontRules.Add(new FontFallbackRule()
            {
                RangeStartIndex = c_startUnicodeIndex,
                RangeEndIndex = c_endUnicodeIndex,
                FallbackFontList = new List<string>() { "Segoe UI Emoji", "Segoe UI Symbol", "Arial" }
            });

            ImageExportOptions exportOptions = new ImageExportOptions()
            {
                FontFallbackRules = fontRules
            };
            
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            
            Stream response = TestUtils.SlidesApi.DownloadPresentation(c_fileName, ExportFormat.Png, exportOptions,
                c_password, c_folderName);
            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }

        [Test]
        public void ConvertWithSlideLayoutOptions()
        {
            PdfExportOptions exportOptions = new PdfExportOptions
            {
                SlidesLayoutOptions = new HandoutLayoutingOptions
                {
                    Handout = HandoutLayoutingOptions.HandoutEnum.Handouts2,
                    PrintSlideNumbers = true
                }
            };
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream response = TestUtils.SlidesApi.DownloadPresentation(
                c_fileName, ExportFormat.Pdf, exportOptions, c_password, c_folderName);
            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }

        [Test]
        public void ConvertWithCustomHtml5Templates()
        {
            const string templatesPath = "Html5Templates";
            const string templateFileName = "pictureFrame.html";
            TestUtils.SlidesApi.CreateFolder(templatesPath);
            TestUtils.Upload(templateFileName, templatesPath + "/" + templateFileName);
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Html5ExportOptions exportOptions = new Html5ExportOptions
            {
                TemplatesPath = templatesPath,
                AnimateTransitions = true
            };
            Stream response = TestUtils.SlidesApi.DownloadPresentation(
                c_fileName, ExportFormat.Html5, exportOptions, c_password, c_folderName);
            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }

        [Test]
        public void GetHtml5Templates()
        {
            Stream response = TestUtils.SlidesApi.GetHtml5Templates();
            Assert.IsNotNull(response);
            Assert.Greater(response.Length, 0);
        }

        const string c_outPath = c_folderName + "/converted.pdf";
        const ExportFormat c_format = ExportFormat.Pdf;
        const SlideExportFormat c_slideFormat = SlideExportFormat.Pdf;
        const ShapeExportFormat c_shapeFormat = ShapeExportFormat.Svg;
        const int c_slideIndex = 1;
        const int c_shapeIndex = 3;
        int c_startUnicodeIndex = 0x0B80;
        int c_endUnicodeIndex = 0x0BFF;
    }
}
