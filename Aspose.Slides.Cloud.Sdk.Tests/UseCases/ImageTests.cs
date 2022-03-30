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
    ///  Class for testing image methods
    /// </summary>
    [TestFixture]
    public class ImageTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void ImagesGet()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Images images = TestUtils.SlidesApi.GetPresentationImages(c_fileName, c_password, c_folderName);
            Images slideImages = TestUtils.SlidesApi.GetSlideImages(c_fileName, 1, c_password, c_folderName);
            Assert.Less(slideImages.List.Count, images.List.Count);
        }

        [Test]
        public void ImagesDownloadStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream images = TestUtils.SlidesApi.DownloadImagesDefaultFormat(c_fileName, c_password, c_folderName);
            Stream imagesPng = TestUtils.SlidesApi.DownloadImages(c_fileName, ImageExportFormat.Png, c_password, c_folderName);
            Assert.IsTrue(images.CanRead);
            Assert.IsTrue(imagesPng.CanRead);
            Assert.AreNotEqual(images.Length, imagesPng.Length);
            using (ZipArchive zip = new ZipArchive(images))
            using (ZipArchive zipPng = new ZipArchive(imagesPng))
            {
                Assert.AreEqual(zip.Entries.Count, zipPng.Entries.Count);
            }
        }

        [Test]
        public void ImagesDownloadRequest()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream images = TestUtils.SlidesApi.DownloadImagesDefaultFormatOnline(file, c_password);
            Stream imagesPng = TestUtils.SlidesApi.DownloadImagesOnline(file, ImageExportFormat.Png, c_password);
            Assert.IsTrue(images.CanRead);
            Assert.IsTrue(imagesPng.CanRead);
            Assert.AreNotEqual(images.Length, imagesPng.Length);
            using (ZipArchive zip = new ZipArchive(images))
            using (ZipArchive zipPng = new ZipArchive(imagesPng))
            {
                Assert.AreEqual(zip.Entries.Count, zipPng.Entries.Count);
            }
        }

        [Test]
        public void ImageDownloadStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream image = TestUtils.SlidesApi.DownloadImageDefaultFormat(c_fileName, c_imageIndex, c_password, c_folderName);
            Stream imagePng = TestUtils.SlidesApi.DownloadImage(c_fileName, c_imageIndex, ImageExportFormat.Png, c_password, c_folderName);
            Assert.IsTrue(image.CanRead);
            Assert.IsTrue(imagePng.CanRead);
            Assert.AreNotEqual(image.Length, imagePng.Length);
        }

        [Test]
        public void ImageDownloadRequest()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream image = TestUtils.SlidesApi.DownloadImageDefaultFormatOnline(file, c_imageIndex, c_password);
            Stream imagePng = TestUtils.SlidesApi.DownloadImageOnline(file, c_imageIndex, ImageExportFormat.Png, c_password);
            Assert.IsTrue(image.CanRead);
            Assert.IsTrue(imagePng.CanRead);
            Assert.AreNotEqual(image.Length, imagePng.Length);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_imageIndex = 1;
    }
}
