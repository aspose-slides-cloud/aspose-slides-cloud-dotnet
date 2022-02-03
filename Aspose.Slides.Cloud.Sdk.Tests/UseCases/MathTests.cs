// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ChartTests.cs">
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
    ///  Class for testing math methods & objects
    /// </summary>
    [TestFixture]
    public class MathTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void MathGet()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion portion = TestUtils.SlidesApi.GetPortion(
                c_fileName, c_slideIndex, c_shapeIndex, c_paragraphIndex, c_portionIndex, c_password, c_folderName);
            Assert.IsNotNull(portion.MathParagraph);
            Assert.IsNotNull(portion.MathParagraph.MathBlockList);
            Assert.AreEqual(1, portion.MathParagraph.MathBlockList.Count);
            Assert.IsNotNull(portion.MathParagraph.MathBlockList[0].MathElementList);
            Assert.AreEqual(3, portion.MathParagraph.MathBlockList[0].MathElementList.Count);
            Assert.IsInstanceOf<FractionElement>(portion.MathParagraph.MathBlockList[0].MathElementList[2]);
        }

        [Test]
        public void MathGetNull()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion portion = TestUtils.SlidesApi.GetPortion(
                c_fileName, c_slideIndex, c_notMathShapeIndex, c_paragraphIndex, c_portionIndex, c_password, c_folderName);
            Assert.IsNull(portion.MathParagraph);
        }

        [Test]
        public void MathCreate()
        {
            const int slideIndex = 1;
            const int shapeIndex = 1;
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion dto = new Portion
            {
                MathParagraph = new MathParagraph
                {
                    MathBlockList = new List<BlockElement>
                    {
                        new BlockElement
                        {
                            MathElementList = new List<MathElement>
                            {
                                new FunctionElement
                                {
                                    Name = new LimitElement { Base = new TextElement { Value = "lim" }, Limit = new TextElement { Value = "x->0" } },
                                    Base = new FractionElement
                                    {
                                        Numerator = new FunctionElement { Name = new TextElement { Value = "sin" }, Base = new TextElement { Value = "x" } },
                                        Denominator = new TextElement { Value = "x" }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            Portion portion = TestUtils.SlidesApi.CreatePortion(
                c_fileName, slideIndex, shapeIndex, c_paragraphIndex, dto, password: c_password, folder: c_folderName);
            Assert.IsNotNull(portion.MathParagraph);
            portion = TestUtils.SlidesApi.GetPortion(c_fileName, slideIndex, shapeIndex, c_paragraphIndex, 2, c_password, c_folderName);
            Assert.IsNotNull(portion.MathParagraph);
            Assert.IsNotNull(portion.MathParagraph.MathBlockList);
            Assert.AreEqual(1, portion.MathParagraph.MathBlockList.Count);
            Assert.IsNotNull(portion.MathParagraph.MathBlockList[0].MathElementList);
            Assert.AreEqual(1, portion.MathParagraph.MathBlockList[0].MathElementList.Count);
            Assert.IsInstanceOf<FunctionElement>(portion.MathParagraph.MathBlockList[0].MathElementList[0]);
        }

        [Test]
        public void MathUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portion dto = new Portion
            {
                MathParagraph = new MathParagraph
                {
                    MathBlockList = new List<BlockElement>
                    {
                        new BlockElement
                        {
                            MathElementList = new List<MathElement>
                            {
                                new FunctionElement
                                {
                                    Name = new LimitElement { Base = new TextElement { Value = "lim" }, Limit = new TextElement { Value = "x->0" } },
                                    Base = new FractionElement
                                    {
                                        Numerator = new FunctionElement { Name = new TextElement { Value = "sin" }, Base = new TextElement { Value = "x" } },
                                        Denominator = new TextElement { Value = "x" }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            Portion portion = TestUtils.SlidesApi.UpdatePortion(
                c_fileName, c_slideIndex, c_shapeIndex, c_paragraphIndex, c_portionIndex, dto, password: c_password, folder: c_folderName);
            Assert.IsNotNull(portion.MathParagraph);
            portion = TestUtils.SlidesApi.GetPortion(
                c_fileName, c_slideIndex, c_shapeIndex, c_paragraphIndex, c_portionIndex, c_password, c_folderName);
            Assert.IsNotNull(portion.MathParagraph);
            Assert.IsNotNull(portion.MathParagraph.MathBlockList);
            Assert.AreEqual(1, portion.MathParagraph.MathBlockList.Count);
            Assert.IsNotNull(portion.MathParagraph.MathBlockList[0].MathElementList);
            Assert.AreEqual(1, portion.MathParagraph.MathBlockList[0].MathElementList.Count);
            Assert.IsInstanceOf<FunctionElement>(portion.MathParagraph.MathBlockList[0].MathElementList[0]);
        }

        [Test]
        public void MathDownload()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream mathMl = TestUtils.SlidesApi.DownloadPortionAsMathMl(
                c_fileName, c_slideIndex, c_shapeIndex, c_paragraphIndex, c_portionIndex, c_password, c_folderName);
            Assert.IsNotNull(mathMl);
            Assert.Greater(mathMl.Length, 0);
            Assert.IsTrue(mathMl.CanRead);
        }

        [Test]
        public void MathDownloadNull()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.DownloadPortionAsMathMl(
                c_fileName, c_slideIndex, c_notMathShapeIndex, c_paragraphIndex, c_portionIndex, c_password, c_folderName));
        }

        [Test]
        public void MathSave()
        {
            const string outPath = c_folderName + "/mathml.xml";
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.SavePortionAsMathMl(
                c_fileName, c_slideIndex, c_shapeIndex, c_paragraphIndex, c_portionIndex, outPath, c_password, c_folderName);
            ObjectExist exists = TestUtils.SlidesApi.ObjectExists(outPath);
            Assert.IsTrue(exists.Exists.Value);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 2;
        const int c_shapeIndex = 3;
        const int c_notMathShapeIndex = 1;
        const int c_paragraphIndex = 1;
        const int c_portionIndex = 1;
    }
}
