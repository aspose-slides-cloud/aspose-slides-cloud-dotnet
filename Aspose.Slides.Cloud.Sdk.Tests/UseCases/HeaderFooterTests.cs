// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="HeaderFooterTests.cs">
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
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Timeout config parameter
    /// </summary>
    [TestFixture]
    public class HeaderFooterTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void SlidesFooter()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutSlidesHeaderFooterRequest putRequest = new PutSlidesHeaderFooterRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                Dto = new HeaderFooter
                {
                    IsFooterVisible = true,
                    FooterText = "footer",
                    IsDateTimeVisible = false
                }
            };
            Document document = TestUtils.SlidesApi.PutSlidesHeaderFooter(putRequest);
            Assert.IsNotNull(document);
            GetSlideHeaderFooterRequest getRequest = new GetSlideHeaderFooterRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex
            };
            HeaderFooter headerFooter = TestUtils.SlidesApi.GetSlideHeaderFooter(getRequest);
            Assert.IsNotNull(headerFooter);
            Assert.IsTrue(headerFooter.IsFooterVisible.Value);
            Assert.IsFalse(headerFooter.IsDateTimeVisible.Value);
        }

        [Test]
        public void SlideFooter()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutSlideHeaderFooterRequest putRequest = new PutSlideHeaderFooterRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new HeaderFooter
                {
                    IsFooterVisible = true,
                    FooterText = "footer",
                    IsDateTimeVisible = false
                }
            };
            HeaderFooter headerFooter = TestUtils.SlidesApi.PutSlideHeaderFooter(putRequest);
            Assert.IsNotNull(headerFooter);
            Assert.IsTrue(headerFooter.IsFooterVisible.Value);
            Assert.IsFalse(headerFooter.IsDateTimeVisible.Value);
            GetSlideHeaderFooterRequest getRequest = new GetSlideHeaderFooterRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex
            };
            headerFooter = TestUtils.SlidesApi.GetSlideHeaderFooter(getRequest);
            Assert.IsNotNull(headerFooter);
            Assert.IsTrue(headerFooter.IsFooterVisible.Value);
            Assert.IsFalse(headerFooter.IsDateTimeVisible.Value);
        }

        [Test]
        public void NotesSlideFooter()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutNotesSlideHeaderFooterRequest putRequest = new PutNotesSlideHeaderFooterRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new NotesSlideHeaderFooter
                {
                    IsHeaderVisible = true,
                    HeaderText = "header",
                    IsDateTimeVisible = false
                }
            };
            NotesSlideHeaderFooter headerFooter = TestUtils.SlidesApi.PutNotesSlideHeaderFooter(putRequest);
            Assert.IsNotNull(headerFooter);
            Assert.IsTrue(headerFooter.IsHeaderVisible.Value);
            Assert.IsFalse(headerFooter.IsDateTimeVisible.Value);
            GetNotesSlideHeaderFooterRequest getRequest = new GetNotesSlideHeaderFooterRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex
            };
            headerFooter = TestUtils.SlidesApi.GetNotesSlideHeaderFooter(getRequest);
            Assert.IsNotNull(headerFooter);
            Assert.IsTrue(headerFooter.IsHeaderVisible.Value);
            Assert.IsFalse(headerFooter.IsDateTimeVisible.Value);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 1;
        const NotesSlideExportFormat c_format = NotesSlideExportFormat.Png;
    }
}
