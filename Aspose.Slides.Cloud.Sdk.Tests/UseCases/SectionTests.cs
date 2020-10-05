// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PipelineTests.cs">
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
    public class SectionTests
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
            GetSectionsRequest getRequest = new GetSectionsRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password
            };
            Sections sections = TestUtils.SlidesApi.GetSections(getRequest);
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
            PutSectionsRequest putRequest = new PutSectionsRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                Sections = dto
            };
            Sections sections = TestUtils.SlidesApi.PutSections(putRequest);
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
            PostSectionRequest postRequest = new PostSectionRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SectionName = "NewSection",
                SlideIndex = 4
            };
            Sections sections = TestUtils.SlidesApi.PostSection(postRequest);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount + 1, sections.SectionList.Count);
        }

        [Test]
        public void SectionPut()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutSectionRequest putRequest = new PutSectionRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SectionIndex = 2,
                SectionName = "UpdatedSection"
            };
            Sections sections = TestUtils.SlidesApi.PutSection(putRequest);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount, sections.SectionList.Count);
            Assert.AreEqual(putRequest.SectionName, sections.SectionList[1].Name);
        }

        [Test]
        public void SectionMove()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostSectionMoveRequest postRequest = new PostSectionMoveRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SectionIndex = 1,
                NewPosition = 2
            };
            Sections sections = TestUtils.SlidesApi.PostSectionMove(postRequest);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount, sections.SectionList.Count);
        }

        [Test]
        public void SectionsClear()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DeleteSectionsRequest deleteRequest = new DeleteSectionsRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password
            };
            Sections sections = TestUtils.SlidesApi.DeleteSections(deleteRequest);
            Assert.IsNotNull(sections);
            Assert.AreEqual(0, sections.SectionList.Count);
        }

        [Test]
        public void SectionsDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DeleteSectionsRequest deleteRequest = new DeleteSectionsRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                Sections = new List<int> { 2, 3 }
            };
            Sections sections = TestUtils.SlidesApi.DeleteSections(deleteRequest);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount - 2, sections.SectionList.Count);
        }

        [Test]
        public void SectionDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DeleteSectionRequest deleteRequest = new DeleteSectionRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SectionIndex = 2
            };
            Sections sections = TestUtils.SlidesApi.DeleteSection(deleteRequest);
            Assert.IsNotNull(sections);
            Assert.AreEqual(c_sectionCount - 1, sections.SectionList.Count);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "Sections.pptx";
        const string c_password = "password";
        const int c_sectionCount = 3;
    }
}
