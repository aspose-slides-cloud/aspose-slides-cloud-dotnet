// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SectionTests.cs">
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
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing section methods
    /// </summary>
    [TestFixture]
    public class SectionTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void SectionsGet()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Sections sections = TestUtils.SlidesApi.GetSections(c_fileName, c_password, c_folderName);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount, sections.SectionList.Count);
        }

        [Test]
        public void SectionsPut()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Sections dto = new Sections
            {
                SectionList = new List<Section>
                {
                    new Section { Name = "Section1", FirstSlideIndex = 1 },
                    new Section { Name = "Section2", FirstSlideIndex = 3 }
                }
            };
            Sections sections = TestUtils.SlidesApi.SetSections(c_fileName, dto, c_password, c_folderName);
            Assert.IsNotNull(sections);
            Assert.AreEqual(dto.SectionList.Count, sections.SectionList.Count);
            Assert.AreEqual(
                dto.SectionList[1].FirstSlideIndex - dto.SectionList[0].FirstSlideIndex,
                sections.SectionList[0].SlideList.Count);
        }

        [Test]
        public void SectionPost()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Sections sections = TestUtils.SlidesApi.CreateSection(c_fileName, "NewSection", 5, c_password, c_folderName);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount + 1, sections.SectionList.Count);
        }

        [Test]
        public void SectionPut()
        {
            const string sectionName = "NewSection";
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Sections sections = TestUtils.SlidesApi.UpdateSection(c_fileName, 2, sectionName, c_password, c_folderName);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount, sections.SectionList.Count);
            Assert.AreEqual(sectionName, sections.SectionList[1].Name);
        }

        [Test]
        public void SectionMove()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Sections sections = TestUtils.SlidesApi.MoveSection(c_fileName, 1, 2, c_password, c_folderName);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount, sections.SectionList.Count);
        }

        [Test]
        public void SectionsClear()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Sections sections = TestUtils.SlidesApi.DeleteSections(c_fileName, password: c_password, folder: c_folderName);
            Assert.IsNotNull(sections);
            Assert.AreEqual(0, sections.SectionList.Count);
        }

        [Test]
        public void SectionsDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            List<int> indexes = new List<int> { 2, 3 };
            Sections sections = TestUtils.SlidesApi.DeleteSections(c_fileName, indexes, password: c_password, folder: c_folderName);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount - 2, sections.SectionList.Count);
        }

        [Test]
        public void SectionDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Sections sections = TestUtils.SlidesApi.DeleteSection(c_fileName, 2, password: c_password, folder: c_folderName);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount - 1, sections.SectionList.Count);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_sectionCount = 3;
    }
}
