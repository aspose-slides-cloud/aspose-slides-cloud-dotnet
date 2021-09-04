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
using System.Threading;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Timeout config parameter
    /// </summary>
    [TestFixture]
    public class TextTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void TextGet()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TextItems presentationItems = TestUtils.SlidesApi.GetPresentationTextItems(c_fileName, null, c_password, c_folderName);
            TextItems presentationItemsWithEmpty = TestUtils.SlidesApi.GetPresentationTextItems(c_fileName, true, c_password, c_folderName);
            TextItems slideItems = TestUtils.SlidesApi.GetSlideTextItems(c_fileName, c_slideIndex, null, c_password, c_folderName);
            TextItems slideItemsWithEmpty = TestUtils.SlidesApi.GetSlideTextItems(c_fileName, c_slideIndex, true, c_password, c_folderName);
            Assert.Less(presentationItems.Items.Count, presentationItemsWithEmpty.Items.Count);
            Assert.Less(slideItems.Items.Count, presentationItems.Items.Count);
            Assert.Less(slideItems.Items.Count, slideItemsWithEmpty.Items.Count);
        }

        [Test]
        public void TextReplaceStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DocumentReplaceResult result = TestUtils.SlidesApi.ReplacePresentationText(
                c_fileName, c_oldValue, c_newValue, null, c_password, c_folderName);

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DocumentReplaceResult resultIgnoreCase = TestUtils.SlidesApi.ReplacePresentationText(
                c_fileName, c_oldValue, c_newValue, true, c_password, c_folderName);

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideReplaceResult slideResult = TestUtils.SlidesApi.ReplaceSlideText(
                c_fileName, c_slideIndex, c_oldValue, c_newValue, null, c_password, c_folderName);

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideReplaceResult slideResultIgnoreCase = TestUtils.SlidesApi.ReplaceSlideText(
                c_fileName, c_slideIndex, c_oldValue, c_newValue, true, c_password, c_folderName);

            Assert.Less(result.Matches, resultIgnoreCase.Matches);
            Assert.Less(slideResult.Matches, result.Matches);
            Assert.Less(slideResult.Matches, slideResultIgnoreCase.Matches);
        }

        [Test]
        public void TextReplaceRequest()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream result = TestUtils.SlidesApi.ReplacePresentationTextOnline(file, c_oldValue, c_newValue, null, c_password);
            Stream resultIgnoreCase = TestUtils.SlidesApi.ReplacePresentationTextOnline(file, c_oldValue, c_newValue, true, c_password);
            Stream slideResult = TestUtils.SlidesApi.ReplaceSlideTextOnline(file, c_slideIndex, c_oldValue, c_newValue, null, c_password);
            Stream slideResultIgnoreCase = TestUtils.SlidesApi.ReplaceSlideTextOnline(
                file, c_slideIndex, c_oldValue, c_newValue, true, c_password);
            Assert.IsTrue(result.CanRead);
            Assert.IsTrue(resultIgnoreCase.CanRead);
            Assert.IsTrue(slideResult.CanRead);
            Assert.IsTrue(slideResultIgnoreCase.CanRead);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const string c_oldValue = "text";
        const string c_newValue = "new_text";
        const int c_slideIndex = 1;
    }
}
