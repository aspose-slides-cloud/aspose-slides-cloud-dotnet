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

using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;
using System.Collections.Generic;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Pipeline Api
    /// </summary>
    [TestFixture]
    public class PipelineTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void TemplateInput()
        {
            Pipeline pipeline = new Pipeline
            {
                Input = new Input
                {
                    TemplateData = new RequestInputFile { Index = 0 },
                    Template = new RequestInputFile { Index = 1 }
                },
                Tasks = new List<Task>
                {
                    new Save
                    {
                        Format = Save.FormatEnum.Pptx,
                        Output = new ResponseOutputFile()
                    }
                }
            };
            List<FileInfo>  files = new List<FileInfo>
            {
                TestUtils.GetLocalFile("TemplatingCVDataWithBase64.xml", "text/xml"),
                TestUtils.GetLocalFile("TemplateCV.pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation")
            };
            object response = TestUtils.SlidesApi.Pipeline(pipeline, files);
            Assert.IsNotNull(response);
        }
    }
}
