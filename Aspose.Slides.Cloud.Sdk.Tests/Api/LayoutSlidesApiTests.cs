// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LayoutSlidesApiTests.cs">
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

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Model.Requests;

using Aspose.Slides.Cloud.Sdk.Tests.Utils;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing LayoutSlidesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LayoutSlidesApiTests
    {
        private LayoutSlidesApi m_instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            m_instance = new LayoutSlidesApi(TestUtils.Configuration);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        
        /// <summary>
        /// Test GetLayoutSlide
        /// </summary>
        [Test]
        public void GetLayoutSlide()
        {
            GeneralTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new GeneralTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse>("GetLayoutSlide");
            GetLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void GetLayoutSlideInvalidName()
        {
            InvalidPropertyTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse>("GetLayoutSlide", "Name");
            GetLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void GetLayoutSlideInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse>("GetLayoutSlide", "SlideIndex");
            GetLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void GetLayoutSlideInvalidFolder()
        {
            InvalidPropertyTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse>("GetLayoutSlide", "Folder");
            GetLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void GetLayoutSlideInvalidStorage()
        {
            InvalidPropertyTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetLayoutSlideRequest, LayoutSlideResponse>("GetLayoutSlide", "Storage");
            GetLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        
        /// <summary>
        /// Test GetLayoutSlidesList
        /// </summary>
        [Test]
        public void GetLayoutSlidesList()
        {
            GeneralTestExecutor<GetLayoutSlidesListRequest, LayoutSlideListResponse> testExecutor =
                new GeneralTestExecutor<GetLayoutSlidesListRequest, LayoutSlideListResponse>("GetLayoutSlidesList");
            GetLayoutSlidesListRequest request = testExecutor.PrepareRequest();
            LayoutSlideListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetLayoutSlidesList(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void GetLayoutSlidesListInvalidName()
        {
            InvalidPropertyTestExecutor<GetLayoutSlidesListRequest, LayoutSlideListResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetLayoutSlidesListRequest, LayoutSlideListResponse>("GetLayoutSlidesList", "Name");
            GetLayoutSlidesListRequest request = testExecutor.PrepareRequest();
            LayoutSlideListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetLayoutSlidesList(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void GetLayoutSlidesListInvalidFolder()
        {
            InvalidPropertyTestExecutor<GetLayoutSlidesListRequest, LayoutSlideListResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetLayoutSlidesListRequest, LayoutSlideListResponse>("GetLayoutSlidesList", "Folder");
            GetLayoutSlidesListRequest request = testExecutor.PrepareRequest();
            LayoutSlideListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetLayoutSlidesList(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void GetLayoutSlidesListInvalidStorage()
        {
            InvalidPropertyTestExecutor<GetLayoutSlidesListRequest, LayoutSlideListResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetLayoutSlidesListRequest, LayoutSlideListResponse>("GetLayoutSlidesList", "Storage");
            GetLayoutSlidesListRequest request = testExecutor.PrepareRequest();
            LayoutSlideListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetLayoutSlidesList(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        
        /// <summary>
        /// Test PostCopyLayoutSlideFromSourcePresentation
        /// </summary>
        [Test]
        public void PostCopyLayoutSlideFromSourcePresentation()
        {
            GeneralTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse> testExecutor =
                new GeneralTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse>("PostCopyLayoutSlideFromSourcePresentation");
            PostCopyLayoutSlideFromSourcePresentationRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostCopyLayoutSlideFromSourcePresentation(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PostCopyLayoutSlideFromSourcePresentationInvalidName()
        {
            InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse>("PostCopyLayoutSlideFromSourcePresentation", "Name");
            PostCopyLayoutSlideFromSourcePresentationRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostCopyLayoutSlideFromSourcePresentation(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PostCopyLayoutSlideFromSourcePresentationInvalidCloneFrom()
        {
            InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse>("PostCopyLayoutSlideFromSourcePresentation", "CloneFrom");
            PostCopyLayoutSlideFromSourcePresentationRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostCopyLayoutSlideFromSourcePresentation(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PostCopyLayoutSlideFromSourcePresentationInvalidCloneFromPosition()
        {
            InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse>("PostCopyLayoutSlideFromSourcePresentation", "CloneFromPosition");
            PostCopyLayoutSlideFromSourcePresentationRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostCopyLayoutSlideFromSourcePresentation(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PostCopyLayoutSlideFromSourcePresentationInvalidCloneFromStorage()
        {
            InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse>("PostCopyLayoutSlideFromSourcePresentation", "CloneFromStorage");
            PostCopyLayoutSlideFromSourcePresentationRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostCopyLayoutSlideFromSourcePresentation(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PostCopyLayoutSlideFromSourcePresentationInvalidFolder()
        {
            InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse>("PostCopyLayoutSlideFromSourcePresentation", "Folder");
            PostCopyLayoutSlideFromSourcePresentationRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostCopyLayoutSlideFromSourcePresentation(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PostCopyLayoutSlideFromSourcePresentationInvalidStorage()
        {
            InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostCopyLayoutSlideFromSourcePresentationRequest, LayoutSlideResponse>("PostCopyLayoutSlideFromSourcePresentation", "Storage");
            PostCopyLayoutSlideFromSourcePresentationRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostCopyLayoutSlideFromSourcePresentation(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        
        /// <summary>
        /// Test PutLayoutSlide
        /// </summary>
        [Test]
        public void PutLayoutSlide()
        {
            GeneralTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new GeneralTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse>("PutLayoutSlide");
            PutLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PutLayoutSlideInvalidName()
        {
            InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse>("PutLayoutSlide", "Name");
            PutLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PutLayoutSlideInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse>("PutLayoutSlide", "SlideIndex");
            PutLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PutLayoutSlideInvalidSlideDto()
        {
            InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse>("PutLayoutSlide", "SlideDto");
            PutLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PutLayoutSlideInvalidFolder()
        {
            InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse>("PutLayoutSlide", "Folder");
            PutLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void PutLayoutSlideInvalidStorage()
        {
            InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutLayoutSlideRequest, LayoutSlideResponse>("PutLayoutSlide", "Storage");
            PutLayoutSlideRequest request = testExecutor.PrepareRequest();
            LayoutSlideResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutLayoutSlide(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        
    }
}
