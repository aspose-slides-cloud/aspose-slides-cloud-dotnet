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
    ///  Class for testing property methods
    /// </summary>
    [TestFixture]
    public class PropertyTests : BaseTests
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
            DocumentProperty documentProperty = TestUtils.SlidesApi.GetDocumentProperty(
                c_fileName, c_builtinPropertyName, c_password, c_folderName);
            Assert.AreEqual(c_builtinPropertyName, documentProperty.Name);
            Assert.IsTrue(documentProperty.BuiltIn.Value);
            DocumentProperty property = new DocumentProperty { Value = c_updatedPropertyValue };
            DocumentProperty updatedProperty = TestUtils.SlidesApi.SetDocumentProperty(
                c_fileName, c_builtinPropertyName, property, c_password, c_folderName);
            Assert.IsTrue(updatedProperty.BuiltIn.Value);
            Assert.AreEqual(c_updatedPropertyValue, updatedProperty.Value);
            TestUtils.SlidesApi.DeleteDocumentProperty(c_fileName, c_builtinPropertyName, c_password, c_folderName);
            //built-in property is not actually deleted
            documentProperty = TestUtils.SlidesApi.GetDocumentProperty(c_fileName, c_builtinPropertyName, c_password, c_folderName);
            Assert.AreEqual(c_builtinPropertyName, documentProperty.Name);
            Assert.IsTrue(documentProperty.BuiltIn.Value);
            Assert.AreNotEqual(c_updatedPropertyValue, documentProperty.Value);
        }

        [Test]
        public void DocumentPropertiesCustom()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DocumentProperty property = new DocumentProperty { Value = c_updatedPropertyValue };
            DocumentProperty updatedProperty = TestUtils.SlidesApi.SetDocumentProperty(
                c_fileName, c_customPropertyName, property, c_password, c_folderName);
            Assert.IsFalse(updatedProperty.BuiltIn.Value);
            Assert.AreEqual(c_updatedPropertyValue, updatedProperty.Value);
            TestUtils.SlidesApi.DeleteDocumentProperty(c_fileName, c_customPropertyName, c_password, c_folderName);
            Assert.IsNull(TestUtils.SlidesApi.GetDocumentProperty(c_fileName, c_customPropertyName, c_password, c_folderName));
        }

        [Test]
        public void DocumentPropertiesBulkUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int count = TestUtils.SlidesApi.GetDocumentProperties(c_fileName, c_password, c_folderName).List.Count;
            DocumentProperties properties = new DocumentProperties
            {
                List = new List<DocumentProperty>
                {
                    new DocumentProperty { Name = c_builtinPropertyName, Value = c_updatedPropertyValue },
                    new DocumentProperty { Name = c_customPropertyName, Value = c_updatedPropertyValue }
                }
            };
            Assert.AreEqual(count + 1, TestUtils.SlidesApi.SetDocumentProperties(c_fileName, properties, c_password, c_folderName).List.Count);
            //One custom property was contained in the original presentation; it also must be deleted
            Assert.AreEqual(count - 1, TestUtils.SlidesApi.DeleteDocumentProperties(c_fileName, c_password, c_folderName).List.Count);
        }

        [Test]
        public void SlideProperties()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideProperties slideProperties = TestUtils.SlidesApi.GetSlideProperties(c_fileName, c_password, c_folderName);
            SlideProperties dto = new SlideProperties { FirstSlideNumber = slideProperties.FirstSlideNumber + 2 };
            SlideProperties updatedProperties = TestUtils.SlidesApi.SetSlideProperties(c_fileName, dto, c_password, c_folderName);
            Assert.AreNotEqual(slideProperties.FirstSlideNumber, updatedProperties.FirstSlideNumber);
            Assert.AreEqual(slideProperties.Orientation, updatedProperties.Orientation);
        }

        [Test]
        public void SlideSizePreset()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideProperties dto = new SlideProperties { SizeType = Model.SlideProperties.SizeTypeEnum.B4IsoPaper };
            SlideProperties updatedProperties = TestUtils.SlidesApi.SetSlideProperties(c_fileName, dto, c_password, c_folderName);
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
            SlideProperties dto = new SlideProperties { Width = c_width, Height = c_height };
            SlideProperties updatedProperties = TestUtils.SlidesApi.SetSlideProperties(c_fileName, dto, c_password, c_folderName);
            Assert.AreEqual(Model.SlideProperties.SizeTypeEnum.Custom, updatedProperties.SizeType);
            Assert.AreEqual(c_width, updatedProperties.Width);
            Assert.AreEqual(c_height, updatedProperties.Height);
        }

        [Test]
        public void Protection()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ProtectionProperties protectionProperties = TestUtils.SlidesApi.GetProtectionProperties(c_fileName, c_password, c_folderName);
            ProtectionProperties dto = new ProtectionProperties { ReadOnlyRecommended = !protectionProperties.ReadOnlyRecommended };
            ProtectionProperties updatedProperties = TestUtils.SlidesApi.SetProtection(c_fileName, dto, c_password, c_folderName);
            Assert.AreNotEqual(protectionProperties.ReadOnlyRecommended, updatedProperties.ReadOnlyRecommended);
            Assert.AreEqual(protectionProperties.EncryptDocumentProperties, updatedProperties.EncryptDocumentProperties);
        }

        [Test]
        public void DeleteProtection()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ProtectionProperties protectionProperties = TestUtils.SlidesApi.DeleteProtection(c_fileName, c_password, c_folderName);
            Assert.IsFalse(protectionProperties.ReadOnlyRecommended.Value);
            Assert.IsFalse(protectionProperties.IsEncrypted.Value);
            Assert.IsNull(protectionProperties.ReadPassword);
        }

        [Test]
        public void ProtectOnline()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            ProtectionProperties dto = new ProtectionProperties { ReadPassword = "newPassword" };
            Stream outputDocument = TestUtils.SlidesApi.SetProtectionOnline(document, dto, c_password);
            Assert.AreNotEqual(document.Length, outputDocument.Length);
        }

        [Test]
        public void UnprotectOnline()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream outputDocument = TestUtils.SlidesApi.DeleteProtectionOnline(document, c_password);
            Assert.AreNotEqual(document.Length, outputDocument.Length);
        }
        
        [Test]
        public void GetViewProperties()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ViewProperties response = TestUtils.SlidesApi.GetViewProperties(c_fileName, c_password, c_folderName);
            Assert.AreEqual(ViewProperties.ShowCommentsEnum.True, response.ShowComments);
        }
        
        [Test]
        public void SetViewProperties()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ViewProperties dto = new ViewProperties()
            {
              ShowComments = ViewProperties.ShowCommentsEnum.False,
              SlideViewProperties = new CommonSlideViewProperties()
              {
                  Scale = 50
              }
            };
 
            ViewProperties response = TestUtils.SlidesApi.SetViewProperties( c_fileName, dto, c_password, c_folderName);
            
            Assert.AreEqual(ViewProperties.ShowCommentsEnum.False, response.ShowComments);
            Assert.AreEqual(50, response.SlideViewProperties.Scale);
        }

        [Test]
        public void ProtectionCheck()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ProtectionProperties protectionProperties = TestUtils.SlidesApi.GetProtectionProperties(c_fileName, null, c_folderName);
            Assert.IsTrue(protectionProperties.IsEncrypted.Value);
            Assert.IsNull(protectionProperties.ReadPassword);
            
            protectionProperties = TestUtils.SlidesApi.GetProtectionProperties(c_fileName, c_password, c_folderName);
            Assert.IsTrue(protectionProperties.IsEncrypted.Value);
            Assert.IsNotNull(protectionProperties.ReadPassword);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const string c_builtinPropertyName = "Author";
        const string c_customPropertyName = "CustomProperty2";
        const string c_updatedPropertyValue = "New Value";
    }
}
