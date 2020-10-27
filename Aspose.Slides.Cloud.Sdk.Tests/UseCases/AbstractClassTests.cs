// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AbstractClassTests.cs">
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
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Timeout config parameter
    /// </summary>
    [TestFixture]
    public class AbstractClassTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void ShapeType()
        {
            const string folderName = "TempSlidesSDK";
            const string fileName = "test.ppt";
            TestUtils.Upload(fileName, folderName + "/" + fileName);
            GetSlideShapeRequest request = new GetSlideShapeRequest
            {
                Name = fileName,
                Folder = folderName,
                Password = "password",
                SlideIndex = 1,
                ShapeIndex = 1
            };
            ShapeBase shape = TestUtils.SlidesApi.GetSlideShape(request);
            Assert.IsInstanceOf<Shape>(shape);
            Assert.IsNotNullOrEmpty(((Shape)shape).Text);
        }

        [Test]
        public void ChartType()
        {
            Chart chart = new Chart();
            Assert.AreEqual(ShapeBase.TypeEnum.Chart, chart.Type);
        }
    }
}
