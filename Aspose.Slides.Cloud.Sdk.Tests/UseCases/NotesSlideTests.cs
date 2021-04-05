// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NotesSlideTests.cs">
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
    public class NotesSlideTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void NotesSlideGetStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            NotesSlide notesSlide = TestUtils.SlidesApi.GetNotesSlide(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.IsNotNull(notesSlide);
        }

        [Test]
        public void NotesSlideExistsStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            EntityExists exists = TestUtils.SlidesApi.NotesSlideExists(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void NotesSlideDownloadStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream notesSlide = TestUtils.SlidesApi.DownloadNotesSlide(
                c_fileName, c_slideIndex, c_format, password: c_password, folder: c_folderName);
            Assert.IsNotNull(notesSlide);
            Assert.Greater(notesSlide.Length, 0);
            Assert.IsTrue(notesSlide.CanRead);
        }

        [Test]
        public void NotesSlideGetRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            NotesSlide notesSlide = TestUtils.SlidesApi.GetNotesSlideOnline(document, c_slideIndex, c_password);
            Assert.IsNotNull(notesSlide);
        }

        [Test]
        public void NotesSlideExistsRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            EntityExists exists = TestUtils.SlidesApi.NotesSlideExistsOnline(document, c_slideIndex, c_password);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void NotesSlideDownloadRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream notesSlide = TestUtils.SlidesApi.DownloadNotesSlideOnline(document, c_slideIndex, c_format, password: c_password);
            Assert.IsNotNull(notesSlide);
            Assert.Greater(notesSlide.Length, 0);
            Assert.IsTrue(notesSlide.CanRead);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 1;
        const NotesSlideExportFormat c_format = NotesSlideExportFormat.Png;
    }
}
