// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateTests.cs">
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
    public class CreateTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void CreateEmpty()
        {
            TestUtils.DeleteFile(c_folderName + "/" + c_fileName);
            PostSlidesDocumentRequest request = new PostSlidesDocumentRequest
            {
                Folder = c_folderName,
                Name = c_fileName
            };
            Document created = TestUtils.SlidesApi.PostSlidesDocument(request);
            Assert.IsNotNull(created);
        }

        [Test]
        public void CreateFromRequest()
        {
            TestUtils.DeleteFile(c_folderName + "/" + c_fileName);
            PostSlidesDocumentRequest request = new PostSlidesDocumentRequest
            {
                Data = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName)),
                InputPassword = c_password,
                Folder = c_folderName,
                Name = c_fileName
            };
            Document created = TestUtils.SlidesApi.PostSlidesDocument(request);
            Assert.IsNotNull(created);
        }

        [Test]
        public void CreateFromStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.DeleteFile(c_folderName + "/" + c_newFileName);
            PostSlidesDocumentFromSourceRequest request = new PostSlidesDocumentFromSourceRequest
            {
                SourcePath = c_folderName + "/" + c_fileName,
                SourcePassword = c_password,
                Folder = c_folderName,
                Name = c_newFileName
            };
            Document created = TestUtils.SlidesApi.PostSlidesDocumentFromSource(request);
            Assert.IsNotNull(created);
        }

        [Test]
        public void CreateFromTemplate()
        {
            TestUtils.DeleteFile(c_folderName + "/" + c_fileName);
            TestUtils.Upload(c_templateFileName, c_folderName + "/" + c_templateFileName);
            PostSlidesDocumentFromTemplateRequest request = new PostSlidesDocumentFromTemplateRequest
            {
                TemplatePath = c_folderName + "/" + c_templateFileName,
                Data = c_template,
                Folder = c_folderName,
                Name = c_fileName
            };
            Document created = TestUtils.SlidesApi.PostSlidesDocumentFromTemplate(request);
            Assert.IsNotNull(created);
        }

        [Test]
        public void CreateFromHtml()
        {
            TestUtils.DeleteFile(c_folderName + "/" + c_fileName);
            PostSlidesDocumentFromHtmlRequest request = new PostSlidesDocumentFromHtmlRequest
            {
                Html = c_html,
                Folder = c_folderName,
                Name = c_fileName
            };
            Document created = TestUtils.SlidesApi.PostSlidesDocumentFromHtml(request);
            Assert.IsNotNull(created);
        }

        [Test]
        public void AppendFromHtml()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            GetSlidesSlidesListRequest slidesRequest = new GetSlidesSlidesListRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password
            };
            int slideCount = TestUtils.SlidesApi.GetSlidesSlidesList(slidesRequest).SlideList.Count;
            PostSlidesDocumentFromHtmlRequest request = new PostSlidesDocumentFromHtmlRequest
            {
                Html = c_html,
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password
            };
            Document updated = TestUtils.SlidesApi.PostSlidesDocumentFromHtml(request);
            Assert.IsNotNull(updated);
            Assert.Greater(TestUtils.SlidesApi.GetSlidesSlidesList(slidesRequest).SlideList.Count, slideCount);
        }

        [Test]
        public void CreateFromPdf()
        {
            TestUtils.DeleteFile(c_folderName + "/" + c_fileName);
            PostSlidesDocumentFromPdfRequest request = new PostSlidesDocumentFromPdfRequest
            {
                Pdf = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_pdfFileName)),
                Folder = c_folderName,
                Name = c_fileName
            };
            Document created = TestUtils.SlidesApi.PostSlidesDocumentFromPdf(request);
            Assert.IsNotNull(created);
        }

        [Test]
        public void AppendFromPdf()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            GetSlidesSlidesListRequest slidesRequest = new GetSlidesSlidesListRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password
            };
            int slideCount = TestUtils.SlidesApi.GetSlidesSlidesList(slidesRequest).SlideList.Count;
            PostSlidesDocumentFromPdfRequest request = new PostSlidesDocumentFromPdfRequest
            {
                Pdf = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_pdfFileName)),
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password
            };
            Document updated = TestUtils.SlidesApi.PostSlidesDocumentFromPdf(request);
            Assert.IsNotNull(updated);
            Assert.Greater(TestUtils.SlidesApi.GetSlidesSlidesList(slidesRequest).SlideList.Count, slideCount);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_newFileName = "test2.pptx";
        const string c_templateFileName = "TemplateCV.pptx";
        const string c_pdfFileName = "test.pdf";
        const string c_password = "password";
        const string c_html = "<html><body>New Content</body></html>";
        const string c_template = "<staff><person><name>John Doe</name><address><line1>10 Downing Street</line1><line2>London</line2></address><phone>+457 123456</phone><bio>Hi, I'm John and this is my CV</bio><skills><skill><title>C#</title><level>Excellent</level></skill><skill><title>C++</title><level>Good</level></skill><skill><title>Java</title><level>Average</level></skill></skills></person></staff>";
    }
}
