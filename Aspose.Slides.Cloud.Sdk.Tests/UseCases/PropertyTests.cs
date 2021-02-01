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
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;
using System.Collections.Generic;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Timeout config parameter
    /// </summary>
    [TestFixture]
    public class PropertyTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void DocumentPropertiesBuiltin()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            GetSlidesDocumentPropertyRequest getRequest = new GetSlidesDocumentPropertyRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                PropertyName = c_builtinPropertyName
            };
            DocumentProperty documentProperty = TestUtils.SlidesApi.GetSlidesDocumentProperty(getRequest);
            Assert.AreEqual(c_builtinPropertyName, documentProperty.Name);
            Assert.IsTrue(documentProperty.BuiltIn);
            PutSlidesSetDocumentPropertyRequest putRequest = new PutSlidesSetDocumentPropertyRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                PropertyName = c_builtinPropertyName,
                Property = new DocumentProperty { Value = c_updatedPropertyValue }
            };
            DocumentProperty updatedProperty = TestUtils.SlidesApi.PutSlidesSetDocumentProperty(putRequest);
            Assert.IsTrue(updatedProperty.BuiltIn);
            Assert.AreEqual(c_updatedPropertyValue, updatedProperty.Value);
            DeleteSlidesDocumentPropertyRequest deleteRequest = new DeleteSlidesDocumentPropertyRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                PropertyName = c_builtinPropertyName
            };
            TestUtils.SlidesApi.DeleteSlidesDocumentProperty(deleteRequest);
            //built-in property is not actually deleted
            documentProperty = TestUtils.SlidesApi.GetSlidesDocumentProperty(getRequest);
            Assert.AreEqual(c_builtinPropertyName, documentProperty.Name);
            Assert.IsTrue(documentProperty.BuiltIn);
            Assert.AreNotEqual(c_updatedPropertyValue, documentProperty.Value);
        }

        [Test]
        public void DocumentPropertiesCustom()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutSlidesSetDocumentPropertyRequest putRequest = new PutSlidesSetDocumentPropertyRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                PropertyName = c_customPropertyName,
                Property = new DocumentProperty { Value = c_updatedPropertyValue }
            };
            DocumentProperty updatedProperty = TestUtils.SlidesApi.PutSlidesSetDocumentProperty(putRequest);
            Assert.IsFalse(updatedProperty.BuiltIn);
            Assert.AreEqual(c_updatedPropertyValue, updatedProperty.Value);
            DeleteSlidesDocumentPropertyRequest deleteRequest = new DeleteSlidesDocumentPropertyRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                PropertyName = c_customPropertyName
            };
            TestUtils.SlidesApi.DeleteSlidesDocumentProperty(deleteRequest);
            GetSlidesDocumentPropertyRequest getRequest = new GetSlidesDocumentPropertyRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                PropertyName = c_customPropertyName
            };
            Assert.IsNull(TestUtils.SlidesApi.GetSlidesDocumentProperty(getRequest));
        }

        [Test]
        public void DocumentPropertiesBulkUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            GetSlidesDocumentPropertiesRequest getRequest = new GetSlidesDocumentPropertiesRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password
            };
            int count = TestUtils.SlidesApi.GetSlidesDocumentProperties(getRequest).List.Count;
            PostSlidesSetDocumentPropertiesRequest postRequest = new PostSlidesSetDocumentPropertiesRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                Properties = new DocumentProperties
                {
                    List = new List<DocumentProperty>
                    {
                        new DocumentProperty { Name = c_builtinPropertyName, Value = c_updatedPropertyValue },
                        new DocumentProperty { Name = c_customPropertyName, Value = c_updatedPropertyValue }
                    }
                }
            };
            Assert.AreEqual(count + 1, TestUtils.SlidesApi.PostSlidesSetDocumentProperties(postRequest).List.Count);
            DeleteSlidesDocumentPropertiesRequest deleteRequest = new DeleteSlidesDocumentPropertiesRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password
            };
            //One custom property was contained in the original presentation; it also must be deleted
            Assert.AreEqual(count - 1, TestUtils.SlidesApi.DeleteSlidesDocumentProperties(deleteRequest).List.Count);
        }

        [Test]
        public void SlideProperties()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            GetSlidesSlidePropertiesRequest getRequest = new GetSlidesSlidePropertiesRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password
            };
            SlideProperties slideProperties = TestUtils.SlidesApi.GetSlidesSlideProperties(getRequest);
            PutSlidesSlidePropertiesRequest putRequest = new PutSlidesSlidePropertiesRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                Dto = new SlideProperties { FirstSlideNumber = slideProperties.FirstSlideNumber + 2 }
            };
            SlideProperties updatedProperties = TestUtils.SlidesApi.PutSlidesSlideProperties(putRequest);
            Assert.AreNotEqual(slideProperties.FirstSlideNumber, updatedProperties.FirstSlideNumber);
            Assert.AreEqual(slideProperties.Orientation, updatedProperties.Orientation);
        }

        [Test]
        public void SlideSizePreset()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutSlidesSlidePropertiesRequest putRequest = new PutSlidesSlidePropertiesRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                Dto = new SlideProperties { SizeType = Model.SlideProperties.SizeTypeEnum.B4IsoPaper }
            };
            SlideProperties updatedProperties = TestUtils.SlidesApi.PutSlidesSlideProperties(putRequest);
            Assert.AreEqual(Model.SlideProperties.SizeTypeEnum.B4IsoPaper, updatedProperties.SizeType);
            Assert.AreEqual(852, updatedProperties.Width);
            Assert.AreEqual(639, updatedProperties.Height);
        }

        [Test]
        public void SlideSizeCustom()
        {
            const int c_width = 800;
            const int c_height = 500;
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutSlidesSlidePropertiesRequest putRequest = new PutSlidesSlidePropertiesRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                Dto = new SlideProperties { Width = c_width, Height = c_height }
            };
            SlideProperties updatedProperties = TestUtils.SlidesApi.PutSlidesSlideProperties(putRequest);
            Assert.AreEqual(Model.SlideProperties.SizeTypeEnum.Custom, updatedProperties.SizeType);
            Assert.AreEqual(c_width, updatedProperties.Width);
            Assert.AreEqual(c_height, updatedProperties.Height);
        }

        [Test]
        public void ProtectionProperties()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            GetSlidesProtectionPropertiesRequest getRequest = new GetSlidesProtectionPropertiesRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password
            };
            ProtectionProperties protectionProperties = TestUtils.SlidesApi.GetSlidesProtectionProperties(getRequest);
            PutSlidesProtectionPropertiesRequest putRequest = new PutSlidesProtectionPropertiesRequest
            {
                Folder = c_folderName,
                Name = c_fileName,
                Password = c_password,
                Dto = new ProtectionProperties { ReadOnlyRecommended = !protectionProperties.ReadOnlyRecommended }
            };
            ProtectionProperties updatedProperties = TestUtils.SlidesApi.PutSlidesProtectionProperties(putRequest);
            Assert.AreNotEqual(protectionProperties.ReadOnlyRecommended, updatedProperties.ReadOnlyRecommended);
            Assert.AreEqual(protectionProperties.EncryptDocumentProperties, updatedProperties.EncryptDocumentProperties);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const string c_builtinPropertyName = "Author";
        const string c_customPropertyName = "CustomProperty2";
        const string c_updatedPropertyValue = "New Value";
    }
}
