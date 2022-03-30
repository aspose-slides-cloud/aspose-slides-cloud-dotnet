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
using System.IO;
using System.IO.Compression;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing split methods
    /// </summary>
    [TestFixture]
    public class SplitTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void SplitStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SplitDocumentResult result = TestUtils.SlidesApi.Split(c_fileName, password: c_password, folder: c_folderName);
            SplitDocumentResult resultFromTo = TestUtils.SlidesApi.Split(
                c_fileName, from: 2, to: 3, password: c_password, folder: c_folderName);
            Assert.AreEqual(2, resultFromTo.Slides.Count);
            Assert.Greater(result.Slides.Count, resultFromTo.Slides.Count);

            string url = result.Slides[0].Href;
            string path = url.Substring(url.IndexOf("/storage/file/") + "/storage/file/".Length);
            Assert.IsTrue(TestUtils.SlidesApi.ObjectExists(path).Exists.Value);
        }

        [Test]
        public void SplitRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream result = TestUtils.SlidesApi.SplitOnline(file, SlideExportFormat.Png, password: c_password);
            Stream resultFromTo = TestUtils.SlidesApi.SplitOnline(file, SlideExportFormat.Png, from: 2, to: 3, password: c_password);
            using (ZipArchive zip = new ZipArchive(result))
            using (ZipArchive zipFromTo = new ZipArchive(resultFromTo))
            {
                Assert.AreEqual(2, zipFromTo.Entries.Count);
                Assert.Greater(zip.Entries.Count, zipFromTo.Entries.Count);
            }
        }

        [Test]
        public void SplitAndSaveRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            SplitDocumentResult result = TestUtils.SlidesApi.SplitAndSaveOnline(file, SlideExportFormat.Png, password: c_password);
            SplitDocumentResult resultFromTo = TestUtils.SlidesApi.SplitAndSaveOnline(
                file, SlideExportFormat.Png, from: 2, to: 3, password: c_password);
            Assert.AreEqual(2, resultFromTo.Slides.Count);
            Assert.Greater(result.Slides.Count, resultFromTo.Slides.Count);

            string url = result.Slides[0].Href;
            string path = url.Substring(url.IndexOf("/storage/file/") + "/storage/file/".Length);
            Assert.IsTrue(TestUtils.SlidesApi.ObjectExists(path).Exists.Value);
        }

        [Test]
        public void SplitWithOptions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ExportOptions options = new PdfExportOptions { JpegQuality = 50 };
            SplitDocumentResult result = TestUtils.SlidesApi.Split(
                c_fileName, options, SlideExportFormat.Pdf, password: c_password, folder: c_folderName);

            string url = result.Slides[0].Href;
            string path = url.Substring(url.IndexOf("/storage/file/") + "/storage/file/".Length);
            Assert.IsTrue(TestUtils.SlidesApi.ObjectExists(path).Exists.Value);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
    }
}
