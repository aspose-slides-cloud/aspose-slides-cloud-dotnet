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
        public void GetAvailableFonts()
        {
            FontsData systemFonts = TestUtils.SlidesApi.GetAvailableFonts();
            Assert.IsTrue(systemFonts.List.Count > 1);
            Assert.IsFalse(systemFonts.List[0].IsCustom.HasValue);
        }

        [Test]
        public void GetFonts()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            FontsData response = TestUtils.SlidesApi.GetFonts(c_fileName, c_password, c_folderName);
            Assert.AreEqual(4, response.List.Count);
        }
        
        [Test]
        public void GetFontsOnline()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            FontsData response = TestUtils.SlidesApi.GetFontsOnline(file, c_password);
            Assert.AreEqual(4, response.List.Count);
        }
        
        [Test]
        public void SetEmbeddedFont()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            FontsData response = TestUtils.SlidesApi.SetEmbeddedFont(c_fileName, c_fontNameCalibri, false, c_password, c_folderName);
            Assert.AreEqual(4, response.List.Count);
            Assert.IsFalse(response.List[0].IsEmbedded.HasValue);
            Assert.IsTrue(response.List[1].IsEmbedded.HasValue);
            Assert.AreEqual(c_fontNameCalibri, response.List[2].FontName);
            Assert.IsTrue(response.List[2].IsEmbedded.HasValue);
        }
        
        [Test]
        public void SetEmbeddedFontOnline()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream response = TestUtils.SlidesApi.SetEmbeddedFontOnline(file, c_fontNameCalibri, false, c_password);
            Assert.Greater(response.Length, file.Length);
        }
        
        [Test]
        public void SetEmbeddedFontFromRequest()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream fontFile = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fontFileName));
            FontsData response = TestUtils.SlidesApi.SetEmbeddedFontFromRequest(fontFile, c_fileName, false, c_password, c_folderName);
            Assert.AreEqual(4, response.List.Count);
            Assert.IsFalse(response.List[0].IsEmbedded.HasValue);
            Assert.IsTrue(response.List[1].IsEmbedded.HasValue);
            Assert.AreEqual(c_fontNameCalibri, response.List[2].FontName);
            Assert.IsTrue(response.List[2].IsEmbedded.HasValue);
        }
        
        [Test]
        public void SetEmbeddedFontFromRequestOnline()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream fontFile = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fontFileName));
            Stream response = TestUtils.SlidesApi.SetEmbeddedFontFromRequestOnline(file, fontFile, false, c_password);
            Assert.Greater(response.Length, file.Length);
        }

        [Test]
        public void CompressEmbeddedFonts()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            FontsData response = TestUtils.SlidesApi.SetEmbeddedFont(c_fileName, c_fontNameCalibri, false, c_password, c_folderName);
            Assert.IsTrue(response.List[2].IsEmbedded.Value);
            //In a real world example, you would rather get the same result by calling SetEmbeddedFont with onlyUsed = true
            TestUtils.SlidesApi.CompressEmbeddedFonts(c_fileName, c_password, c_folderName);
            Assert.IsTrue(response.List[2].IsEmbedded.HasValue);
        }

        [Test]
        public void CompressEmbeddedFontsOnline()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream resultEmbedded = TestUtils.SlidesApi.SetEmbeddedFontOnline(file, c_fontNameCalibri, false, c_password);
            Assert.Greater(resultEmbedded.Length, file.Length);
            //In a real world example, you would rather get the same result by calling SetEmbeddedFont with onlyUsed = true
            Stream resultDeleted = TestUtils.SlidesApi.CompressEmbeddedFontsOnline(resultEmbedded, c_password);
            Assert.Less(resultDeleted.Length, resultEmbedded.Length);
        }

        [Test]
        public void DeleteEmbeddedFont()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            FontsData response = TestUtils.SlidesApi.SetEmbeddedFont(c_fileName, c_fontNameCalibri, false, c_password, c_folderName);
            Assert.IsTrue(response.List[2].IsEmbedded.Value);
            response = TestUtils.SlidesApi.DeleteEmbeddedFont(c_fileName, c_fontNameCalibri, c_password, c_folderName);
            Assert.IsFalse(response.List[2].IsEmbedded.HasValue);
        }
        
        [Test]
        public void DeleteEmbeddedFontOnline()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream resultEmbedded = TestUtils.SlidesApi.SetEmbeddedFontOnline(file, c_fontNameCalibri, false, c_password);
            Assert.Greater(resultEmbedded.Length, file.Length);
            Stream resultDeleted = TestUtils.SlidesApi.DeleteEmbeddedFontOnline(resultEmbedded, c_fontNameCalibri, c_password);
            Assert.Less(resultDeleted.Length, resultEmbedded.Length);
        }
        
        [Test]
        public void ReplaceFont()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            FontsData result = TestUtils.SlidesApi.ReplaceFont(c_fileName, c_fontNameCalibri, c_fontNameTimes, true, 
                c_password, c_folderName);
            Assert.AreEqual(c_fontNameTimes, result.List[2].FontName);
            Assert.IsTrue(result.List[2].IsEmbedded.Value);
        }
        
        [Test]
        public void ReplaceFontOnline()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream result = TestUtils.SlidesApi.ReplaceFontOnline(file, c_fontNameCalibri, c_fontNameTimes, true, 
                c_password);
            Assert.Greater(result.Length, file.Length);
        }
        
        [Test]
        public void FontSubstitution()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            
            List<FontSubstRule> fontRules = new List<FontSubstRule>();
            fontRules.Add(new FontSubstRule()
            {
                SourceFont = "Arial",
                TargetFont = "Times New Roman",
                NotFoundOnly = false
            });
            fontRules.Add(new FontSubstRule()
            {
                SourceFont = "Calibri",
                TargetFont = "Times New Roman"
            });

            ImageExportOptions exportOptions = new ImageExportOptions()
            {
                FontSubstRules = fontRules
            };

            Stream response = TestUtils.SlidesApi.DownloadPresentation(c_fileName, ExportFormat.Png, exportOptions,
                c_password, c_folderName);
            Assert.True(response.Length > 0);
        }
        
        const string c_fontFileName = "calibri.ttf";
        const string c_fontNameCalibri = "Calibri";
        const string c_fontNameTimes = "Times New Roman";
    }
}