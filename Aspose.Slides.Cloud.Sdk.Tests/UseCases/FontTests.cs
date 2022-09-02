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
    [TestFixture]
    public class FontTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }
        
        [Test]
        public void GetFonts()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            FontsData response = TestUtils.SlidesApi.GetFonts(c_fileName, c_password, c_folderName);
            Assert.AreEqual(3, response.List.Count);
        }
        
        [Test]
        public void GetFontsOnline()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            FontsData response = TestUtils.SlidesApi.GetFontsOnline(file, c_password);
            Assert.AreEqual(3, response.List.Count);
        }
        
        [Test]
        public void SetEmbeddedFont()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            FontsData response = TestUtils.SlidesApi.SetEmbeddedFont(c_fileName, c_fontName, false, c_password, c_folderName);
            Assert.AreEqual(3, response.List.Count);
            Assert.IsTrue(response.List[0].IsEmbedded.HasValue);
            Assert.IsFalse(response.List[1].IsEmbedded.HasValue);
            Assert.AreEqual(c_fontName, response.List[2].FontName);
            Assert.IsTrue(response.List[2].IsEmbedded.HasValue);
        }
        
        [Test]
        public void SetEmbeddedFontOnline()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream response = TestUtils.SlidesApi.SetEmbeddedFontOnline(file, c_fontName, false, c_password);
            Assert.Greater(response.Length, file.Length);
        }
        
        [Test]
        public void DeleteEmbeddedFont()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            FontsData response = TestUtils.SlidesApi.SetEmbeddedFont(c_fileName, c_fontName, false, c_password, c_folderName);
            Assert.IsTrue(response.List[2].IsEmbedded.Value);
            response = TestUtils.SlidesApi.DeleteEmbeddedFont(c_fileName, c_fontName, c_password, c_folderName);
            Assert.IsFalse(response.List[2].IsEmbedded.HasValue);
        }
        
        [Test]
        public void DeleteEmbeddedFontOnline()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream resultEmbedded = TestUtils.SlidesApi.SetEmbeddedFontOnline(file, c_fontName, false, c_password);
            Assert.Greater(resultEmbedded.Length, file.Length);
            Stream resultDeleted = TestUtils.SlidesApi.DeleteEmbeddedFontOnline(resultEmbedded, c_fontName, c_password);
            Assert.Less(resultDeleted.Length, resultEmbedded.Length);
        }
        
        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const string c_fontName = "Calibri";
    }
}