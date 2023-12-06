// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeTests.cs">
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
using System.Threading;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing animation API
    /// </summary>
    [TestFixture]
    public class AsyncApiTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void AsyncConvert()
        {
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            string operationId = TestUtils.SlidesAsyncApi.StartConvert(file, c_format, c_password);

            Operation operation = null;

            for (int i = 0; i < c_maxTries; i++)
            {
                Thread.Sleep(c_sleepTimeout);
                operation = TestUtils.SlidesAsyncApi.GetOperationStatus(operationId);
                if (operation.Status != Operation.StatusEnum.Created
                    && operation.Status != Operation.StatusEnum.Enqueued
                    && operation.Status != Operation.StatusEnum.Started)
                {
                    break;
                }
            }
            Assert.AreEqual(Operation.StatusEnum.Finished, operation.Status);
            Assert.IsNull(operation.Error);

            Stream converted = TestUtils.SlidesAsyncApi.GetOperationResult(operationId);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void AsyncDownloadPresentation()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            string operationId = TestUtils.SlidesAsyncApi.StartDownloadPresentation(c_fileName, c_format, null, c_password, c_folderName);

            Operation operation = null;
            for (int i = 0; i < c_maxTries; i++)
            {
                Thread.Sleep(c_sleepTimeout);
                operation = TestUtils.SlidesAsyncApi.GetOperationStatus(operationId);
                if (operation.Status != Operation.StatusEnum.Created
                    && operation.Status != Operation.StatusEnum.Enqueued
                    && operation.Status != Operation.StatusEnum.Started)
                {
                    break;
                }
            }
            Assert.AreEqual(Operation.StatusEnum.Finished, operation.Status);
            Assert.IsNull(operation.Error);

            Stream converted = TestUtils.SlidesAsyncApi.GetOperationResult(operationId);
            Assert.IsNotNull(converted);
            Assert.Greater(converted.Length, 0);
            Assert.IsTrue(converted.CanRead);
        }

        [Test]
        public void AsyncConvertAndSave()
        {
            TestUtils.DeleteFile(c_outPath);
            Stream file = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            string operationId = TestUtils.SlidesAsyncApi.StartConvertAndSave(file, c_format, c_outPath, c_password);

            Operation operation = null;

            for (int i = 0; i < c_maxTries; i++)
            {
                Thread.Sleep(c_sleepTimeout);
                operation = TestUtils.SlidesAsyncApi.GetOperationStatus(operationId);
                if (operation.Status != Operation.StatusEnum.Created
                    && operation.Status != Operation.StatusEnum.Enqueued
                    && operation.Status != Operation.StatusEnum.Started)
                {
                    break;
                }
            }
            Assert.AreEqual(Operation.StatusEnum.Finished, operation.Status);
            Assert.IsNull(operation.Error);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void AsyncSavePresentation()
        {
            TestUtils.DeleteFile(c_outPath);
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            string operationId = TestUtils.SlidesAsyncApi.StartSavePresentation(c_fileName, c_format, c_outPath, null, c_password, c_folderName);

            Operation operation = null;

            for (int i = 0; i < c_maxTries; i++)
            {
                Thread.Sleep(c_sleepTimeout);
                operation = TestUtils.SlidesAsyncApi.GetOperationStatus(operationId);
                if (operation.Status != Operation.StatusEnum.Created
                    && operation.Status != Operation.StatusEnum.Enqueued
                    && operation.Status != Operation.StatusEnum.Started)
                {
                    break;
                }
            }
            Assert.AreEqual(Operation.StatusEnum.Finished, operation.Status);
            Assert.IsNull(operation.Error);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void AsyncMerge()
        {
            FileInfo file1 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName2)) };
            FileInfo file2 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName2)) };

            string operationId = TestUtils.SlidesAsyncApi.StartMerge(new List<FileInfo> { file1, file2 });

            Operation operation = null;

            for (int i = 0; i < c_maxTries; i++)
            {
                Thread.Sleep(c_sleepTimeout);
                operation = TestUtils.SlidesAsyncApi.GetOperationStatus(operationId);
                if (operation.Status != Operation.StatusEnum.Created
                    && operation.Status != Operation.StatusEnum.Enqueued
                    && operation.Status != Operation.StatusEnum.Started)
                {
                    break;
                }
            }
            Assert.AreEqual(Operation.StatusEnum.Finished, operation.Status);
            Assert.IsNotNull(operation.Progress);
            Assert.AreEqual(2, operation.Progress.StepCount);
            Assert.AreEqual(operation.Progress.StepCount, operation.Progress.StepIndex);
            Assert.IsNull(operation.Error);

            Stream merged = TestUtils.SlidesAsyncApi.GetOperationResult(operationId);
            Assert.IsNotNull(merged);
            Assert.Greater(merged.Length, 0);
            Assert.IsTrue(merged.CanRead);
        }

        [Test]
        public void AsyncMergeAndSave()
        {
            TestUtils.DeleteFile(c_outPath);

            FileInfo file1 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName2)) };
            FileInfo file2 = new FileInfo { Content = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName2)) };

            string operationId = TestUtils.SlidesAsyncApi.StartMergeAndSave(c_outPath, new List<FileInfo> { file1, file2 });

            Operation operation = null;

            for (int i = 0; i < c_maxTries; i++)
            {
                Thread.Sleep(c_sleepTimeout);
                operation = TestUtils.SlidesAsyncApi.GetOperationStatus(operationId);
                if (operation.Status != Operation.StatusEnum.Created
                    && operation.Status != Operation.StatusEnum.Enqueued
                    && operation.Status != Operation.StatusEnum.Started)
                {
                    break;
                }
            }
            Assert.AreEqual(Operation.StatusEnum.Finished, operation.Status);
            Assert.IsNotNull(operation.Progress);
            Assert.AreEqual(2, operation.Progress.StepCount);
            Assert.AreEqual(operation.Progress.StepCount, operation.Progress.StepIndex);
            Assert.IsNull(operation.Error);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(c_outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void AsyncBadOperation()
        {
            string operationId = TestUtils.SlidesAsyncApi.StartDownloadPresentation("IDoNotExist.pptx", c_format);

            Operation operation = null;
            for (int i = 0; i < c_maxTries; i++)
            {
                Thread.Sleep(c_sleepTimeout);
                operation = TestUtils.SlidesAsyncApi.GetOperationStatus(operationId);
                if (operation.Status != Operation.StatusEnum.Started)
                {
                    break;
                }
            }
            Assert.AreEqual(Operation.StatusEnum.Failed, operation.Status);
            Assert.IsNotNull(operation.Error);
        }

        const ExportFormat c_format = ExportFormat.Pdf;
        const int c_sleepTimeout = 3000;
        const int c_maxTries = 10;
        const string c_fileName2 = "test-unprotected.pptx";
        const string c_outPath = c_folderName + "/converted.pdf";
    }
}
