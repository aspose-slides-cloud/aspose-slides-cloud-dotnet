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

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing image methods
    /// </summary>
    [TestFixture]
    public class VideoTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void CaptionTracks()
        {
            const int slideIndex = 3;
            const int shapeIndex = 3;
            const string track1Label = "track1";
            const string track2Label = "track2";
            const string track1Data = @"WEBVTT

00:00:00.000-- > 00:00:10.000
Caption 1 text.";
            const string track2Data = @"WEBVTT

00:00:00.000-- > 00:00:10.000
Caption 2 text.";
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new VideoFrame { Base64Data = "bXAzc2FtcGxl" };
            TestUtils.SlidesApi.CreateShape(c_fileName, slideIndex, dto, password: c_password, folder: c_folderName);
            CaptionTracks captions = TestUtils.SlidesApi.GetVideoCaptionTracks(
                c_fileName, slideIndex, shapeIndex, null, c_password, c_folderName);
            Assert.AreEqual(0, captions.Items.Count);

            TestUtils.SlidesApi.CreateVideoCaptionTrack(
                c_fileName, slideIndex, shapeIndex, track1Label, track1Data, c_password, c_folderName);
            TestUtils.SlidesApi.CreateVideoCaptionTrack(
                c_fileName, slideIndex, shapeIndex, track2Label, track2Data, c_password, c_folderName);
            captions = TestUtils.SlidesApi.GetVideoCaptionTracks(c_fileName, slideIndex, shapeIndex, true, c_password, c_folderName);
            Assert.AreEqual(2, captions.Items.Count);
            Assert.AreEqual(track1Label, captions.Items[0].Label);
            Assert.AreEqual(track1Data, captions.Items[0].DataAsString);
            Assert.AreEqual(track2Label, captions.Items[1].Label);
            Assert.AreEqual(track2Data, captions.Items[1].DataAsString);

            TestUtils.SlidesApi.DeleteVideoCaptionTrack(c_fileName, slideIndex, shapeIndex, 1, c_password, c_folderName);
            captions = TestUtils.SlidesApi.GetVideoCaptionTracks(c_fileName, slideIndex, shapeIndex, false, c_password, c_folderName);
            Assert.AreEqual(1, captions.Items.Count);
            Assert.AreEqual(track2Label, captions.Items[0].Label);
            Assert.AreEqual(null, captions.Items[0].DataAsString);

            TestUtils.SlidesApi.DeleteVideoCaptionTracks(c_fileName, slideIndex, shapeIndex, c_password, c_folderName);
            captions = TestUtils.SlidesApi.GetVideoCaptionTracks(c_fileName, slideIndex, shapeIndex, true, c_password, c_folderName);
            Assert.AreEqual(0, captions.Items.Count);
        }
    }
}
