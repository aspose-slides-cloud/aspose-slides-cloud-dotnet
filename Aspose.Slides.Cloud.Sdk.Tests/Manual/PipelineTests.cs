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
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;
using System.IO;

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
            PostSlidesPipelineRequest request = new PostSlidesPipelineRequest
            {
                Pipeline = new Pipeline
                {
                    Files = new FileInfo[]
                    {
                        TestUtils.GetLocalFile("TemplatingCVDataWithBase64.xml", "text/xml"),
                        TestUtils.GetLocalFile("TemplateCV.pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation")
                    },
                    Input = new Input
                    {
                        TemplateData = new RequestInputFile { Type = InputFileType.Request, Index = 0 },
                        Template = new RequestInputFile { Type = InputFileType.Request, Index = 1 }
                    },
                    Tasks = new System.Collections.Generic.List<Task>
                    {
                        new Save { Format = ExportFormat.Pptx, Output = new ResponseOutputFile { Type = OutputFileType.Response } }
                    }
                }
            };
            DocumentApi api = new DocumentApi(TestUtils.Configuration);
            Stream response = api.PostSlidesPipeline(request);
            Assert.IsNotNull(response);
        }
    }
}
