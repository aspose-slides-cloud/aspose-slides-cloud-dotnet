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

using System;
using System.Collections.Generic;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    [TestFixture]
    public class VbaTests: BaseTests
    {
        [Test]
        public void CreateVbaModule()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            
            VbaModule response = TestUtils.SlidesApi.CreateVbaModule(c_fileName, m_vbaModule, c_password, c_folderName);
            Assert.AreEqual(m_vbaModule.Name, response.Name);
        }
        
        [Test]
        public void DeleteVbaModule()
        {
            TestUtils.Upload(c_macrosFileName, c_folderName + "/" + c_macrosFileName);
            int moduleIndex = 1;
            var response = TestUtils.SlidesApi.DeleteVbaModule(c_macrosFileName, moduleIndex, null, c_folderName);
            Assert.AreEqual(0, response.Modules.Count);
        }
        
        [Test]
        public void GetVbaModule()
        {
            TestUtils.Upload(c_macrosFileName, c_folderName + "/" + c_macrosFileName);
            int moduleIndex = 1;
            var response = TestUtils.SlidesApi.GetVbaModule(c_macrosFileName, moduleIndex, null, c_folderName);
            Assert.AreEqual(m_vbaModule.Name, response.Name);
        }

        [Test]
        public void GetVbaProject()
        {
            TestUtils.Upload(c_macrosFileName, c_folderName + "/" + c_macrosFileName);
            var response = TestUtils.SlidesApi.GetVbaProject(c_macrosFileName, null, c_folderName);
            Assert.AreEqual(1, response.Modules.Count);
        }

        [Test]
        public void UpdateVbaModule()
        {
            TestUtils.Upload(c_macrosFileName, c_folderName + "/" + c_macrosFileName);
            var dto = new VbaModule()
            {
                SourceCode = @"Sub Test() MsgBox ""Test"" End Sub"
            };
            int moduleIndex = 1;
            VbaModule response = TestUtils.SlidesApi.UpdateVbaModule(c_macrosFileName, moduleIndex, dto, c_password, c_folderName);
            Assert.AreEqual(m_vbaModule.Name, response.Name);
        }

        private readonly VbaModule m_vbaModule = new VbaModule()
        {
            Name = c_moduleName,
            SourceCode = @"Sub Test() MsgBox ""Test"" End Sub",
            References = new List<VbaReference>()
            {
                new VbaReference()
                {
                    Name = "stdole",
                    LibId = "*\\G{00020430-0000-0000-C000-000000000046}#2.0#0#C:\\Windows\\system32\\stdole2.tlb#OLE Automation"
                },
                new VbaReference()
                {
                    Name = "Office",
                    LibId = "*\\G{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}#2.0#0#C:\\Program Files\\Common Files\\Microsoft Shared\\OFFICE14\\MSO.DLL#Microsoft Office 14.0 Object Library"
                }
            }
        };
        
        private const string c_moduleName = "Module1";
        private const string c_macrosFileName = "macros.pptm";
    }
}