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
            PostSlidesConvertRequest request = new PostSlidesConvertRequest
            {
                Document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName)),
                Password = c_password,
                Format = c_format
            };
            Stream converted = TestUtils.SlidesApi.PostSlidesConvert(request);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertPutFromRequest()
        {
            PutSlidesConvertRequest putRequest = new PutSlidesConvertRequest
            {
                Document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName)),
                Password = c_password,
                Format = c_format,
                OutPath = c_outPath
            };
            TestUtils.SlidesApi.PutSlidesConvert(putRequest);
            PutSlidesConvertRequest existsRequest = new PutSlidesConvertRequest
            {
                Password = c_password,
                Format = c_format,
                OutPath = c_outPath
            };
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(new ObjectExistsRequest { Path = c_outPath });
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertPostFromStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostSlidesSaveAsRequest request = new PostSlidesSaveAsRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                Format = c_format
            };
            Stream converted = TestUtils.SlidesApi.PostSlidesSaveAs(request);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void ConvertPutFromStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutSlidesSaveAsRequest request = new PutSlidesSaveAsRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                Format = c_format,
                OutPath = c_outPath
            };
            TestUtils.SlidesApi.PutSlidesSaveAs(request);
            PutSlidesConvertRequest existsRequest = new PutSlidesConvertRequest
            {
                Password = c_password,
                Format = c_format,
                OutPath = c_outPath
            };
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(new ObjectExistsRequest { Path = c_outPath });
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void ConvertWithOptions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostSlidesSaveAsRequest request = new PostSlidesSaveAsRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                Format = c_format
            };
            Stream converted = TestUtils.SlidesApi.PostSlidesSaveAs(request);
            request = new PostSlidesSaveAsRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                Format = c_format,
                Options = new PdfExportOptions { TextCompression = PdfExportOptions.TextCompressionEnum.Flate }
            };
            Stream convertedWithOptions = TestUtils.SlidesApi.PostSlidesSaveAs(request);
            Assert.AreNotEqual(converted.Length, convertedWithOptions.Length);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.ppt";
        const string c_password = "password";
        const string c_outPath = c_folderName + "/converted.pdf";
        const ExportFormat c_format = ExportFormat.Pdf;
    }
}
