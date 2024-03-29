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
using System.Collections.Generic;
using System.IO;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing merge methods
    /// </summary>
    [TestFixture]
    public class MergeTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void Merge()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.Upload(c_fileName2, c_folderName + "/" + c_fileName2);
            TestUtils.Upload(c_pdfFileName, c_folderName + "/" + c_pdfFileName);
            PresentationsMergeRequest request = new PresentationsMergeRequest
            {
                PresentationPaths = new List<string> { c_folderName + "/" + c_fileName2, c_folderName + "/" + c_pdfFileName }
            };
            Document result = TestUtils.SlidesApi.Merge(c_fileName, request, c_password, c_folderName);
            Assert.IsNotNull(result);
        }

        [Test]
        public void OrderedMerge()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.Upload(c_fileName2, c_folderName + "/" + c_fileName2);
            OrderedMergeRequest request = new OrderedMergeRequest
            {
                Presentations = new List<PresentationToMerge>
                {
                    new PresentationToMerge { Path = c_folderName + "/" + c_fileName2, Slides = new List<int> { 2, 1 } }
                }
            };
            Document result = TestUtils.SlidesApi.OrderedMerge(c_fileName, request, c_password, c_folderName);
            Assert.IsNotNull(result);
        }

        [Test]
        public void MergeOnline()
        {
            FileInfo file1 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName2)) };
            FileInfo file2 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName2)) };

            Stream result = TestUtils.SlidesApi.MergeOnline(new List<FileInfo> { file1, file2 });
            Assert.IsNotNull(result);
            Assert.IsTrue(result.CanRead);
        }

        [Test]
        public void MergeAndSaveOnline()
        {
            FileInfo file1 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName2)) };
            FileInfo file2 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName2)) };

            TestUtils.SlidesApi.MergeAndSaveOnline(c_outpath, new List<FileInfo> { file1, file2 });
            Assert.IsTrue(TestUtils.SlidesApi.ObjectExists(c_outpath).Exists.Value);
        }

        [Test]
        public void MergeOnlineWithRequest()
        {
            FileInfo file1 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName2)), Name = "file1.pptx" };
            FileInfo file2 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName)), Name = "file2.pptx" };

            OrderedMergeRequest request = new OrderedMergeRequest
            {
                Presentations = new List<PresentationToMerge>
                {
                    new PresentationToMerge { Path = "file1.pptx" },
                    new PresentationToMerge { Path = "file2.pptx", Password = c_password, Slides = new List<int> { 1, 2 } }
                }
            };

            Stream result = TestUtils.SlidesApi.MergeOnline(new List<FileInfo> { file1, file2 }, request);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.CanRead);
        }

        [Test]
        public void MergeOnlineCombined()
        {
            FileInfo file1 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName)), Name="file1.pptx" };
            TestUtils.Upload(c_fileName2, c_folderName + "/" + c_fileName2);

            OrderedMergeRequest request = new OrderedMergeRequest
            {
                Presentations = new List<PresentationToMerge>
                {
                    new PresentationToMerge { Path = "file1.pptx", Password = c_password },
                    new PresentationToMerge
                    {
                        Slides = new List<int> { 1, 2 },
                        Source = PresentationToMerge.SourceEnum.Storage,
                        Path = c_folderName + "/" + c_fileName2
                    }
                }
            };

            Stream result = TestUtils.SlidesApi.MergeOnline(new List<FileInfo> { file1 }, request);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.CanRead);
        }
        
        [Test]
        public void MergeOnlineUrl()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            OrderedMergeRequest request = new OrderedMergeRequest
            {
                Presentations = new List<PresentationToMerge>
                {
                    new PresentationToMerge
                    {
                        Slides = new List<int> { 1, 2 },
                        Source = PresentationToMerge.SourceEnum.Storage,
                        Path = c_folderName + "/" + c_fileName,
                        Password = c_password
                    },
                    new PresentationToMerge()
                    {
                        Slides = new List<int> { 1 },
                        Source = PresentationToMerge.SourceEnum.Url,
                        Path = c_urlPath
                    }
                }
            };
            Stream result = TestUtils.SlidesApi.MergeOnline(null, request);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.CanRead);
        }

        const string c_urlPath = "https://drive.google.com/uc?export=download&id=1ycMzd7e--Ro9H8eH2GL5fPP7-2HjX4My";
        const string c_pdfFileName = "test.pdf";
        const string c_fileName2 = "test-unprotected.pptx";
        const string c_outpath = "merged.pptx";
    }
}
