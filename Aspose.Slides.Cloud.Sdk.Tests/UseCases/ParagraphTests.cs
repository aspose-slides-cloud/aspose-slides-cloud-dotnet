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
using System.Collections.Generic;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    [TestFixture]
    public class ParagraphTests : BaseTests
    {
        [Test]
        public void GetParagraph()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraph response =
                TestUtils.SlidesApi.GetParagraph(c_fileName, c_slideIndex, c_shapeIndex, 1, c_password, c_folderName);
            Assert.AreEqual(2, response.PortionList.Count);
        }

        [Test]
        public void GetParagraphs()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs response =
                TestUtils.SlidesApi.GetParagraphs(c_fileName, c_slideIndex, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(2, response.ParagraphLinks.Count);
        }

        [Test]
        public void GetSubShapeParagraph()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraph response = TestUtils.SlidesApi.GetParagraph(c_fileName, c_slideIndex,
                3, 1, c_password, c_folderName, subShape: "1");
            Assert.AreEqual(2, response.PortionList.Count);
        }

        [Test]
        public void GetSubShapeParagraphs()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs response = TestUtils.SlidesApi.GetParagraphs(c_fileName, c_slideIndex,
                3, c_password, c_folderName, subShape: "1");
            Assert.AreEqual(2, response.ParagraphLinks.Count);
        }

        [Test]
        public void CreateParagraph()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            Paragraph dto = new Paragraph()
            {
                MarginLeft = 2,
                MarginRight = 2,
                Alignment = Paragraph.AlignmentEnum.Center
            };

            Paragraph response = TestUtils.SlidesApi.CreateParagraph(c_fileName, c_slideIndex, c_shapeIndex, dto,
                null, c_password, c_folderName);

            Assert.AreEqual(dto.MarginLeft, response.MarginLeft);
            Assert.AreEqual(dto.MarginRight, response.MarginRight);
            Assert.AreEqual(Paragraph.AlignmentEnum.Center, response.Alignment);
        }

        [Test]
        public void CreateParagraphWithPortions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            Paragraph dto = new Paragraph()
            {
                PortionList = new List<Portion>()
                {
                    new Portion()
                    {
                        Text = "Portion1"
                    },
                    new Portion()
                    {
                        Text = "Portion2",
                        FontBold = Portion.FontBoldEnum.True
                    }
                }
            };

            Paragraph response = TestUtils.SlidesApi.CreateParagraph(c_fileName, c_slideIndex, c_shapeIndex, dto,
                null, c_password, c_folderName);

            Assert.AreEqual(response.PortionList.Count, 2);
        }

        [Test]
        public void CreateSubShapeParagraph()
        {
            Paragraph dto = new Paragraph()
            {
                MarginLeft = 2,
                MarginRight = 2,
                Alignment = Paragraph.AlignmentEnum.Center
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraph response = TestUtils.SlidesApi.CreateParagraph(c_fileName, c_slideIndex,
                3, dto, null, c_password, c_folderName, subShape: "1");

            Assert.AreEqual(dto.MarginLeft, response.MarginLeft);
            Assert.AreEqual(dto.MarginRight, response.MarginLeft);
            Assert.AreEqual(Paragraph.AlignmentEnum.Center, response.Alignment);
        }

        [Test]
        public void UpdateParagraph()
        {
            Paragraph dto = new Paragraph()
            {
                MarginLeft = 2,
                MarginRight = 2,
                Alignment = Paragraph.AlignmentEnum.Center
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            Paragraph response = TestUtils.SlidesApi.UpdateParagraph(c_fileName, c_slideIndex, c_shapeIndex, 1, dto,
                c_password, c_folderName);

            Assert.AreEqual(dto.MarginLeft, response.MarginLeft);
            Assert.AreEqual(dto.MarginRight, response.MarginLeft);
            Assert.AreEqual(Paragraph.AlignmentEnum.Center, response.Alignment);
        }

        [Test]
        public void UpdateSubShapeParagraph()
        {
            Paragraph dto = new Paragraph()
            {
                MarginLeft = 2,
                MarginRight = 2,
                Alignment = Paragraph.AlignmentEnum.Center
            };

            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraph response = TestUtils.SlidesApi.UpdateParagraph(c_fileName, c_slideIndex,
                3, 1, dto, c_password, c_folderName, subShape: "1");

            Assert.AreEqual(dto.MarginLeft, response.MarginLeft);
            Assert.AreEqual(dto.MarginRight, response.MarginLeft);
            Assert.AreEqual(Paragraph.AlignmentEnum.Center, response.Alignment);
        }

        [Test]
        public void DeleteParagraphs()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs response = TestUtils.SlidesApi.DeleteParagraphs(c_fileName, c_slideIndex, c_shapeIndex, null,
                c_password, c_folderName);
            Assert.AreEqual(0, response.ParagraphLinks.Count);
        }

        [Test]
        public void DeleteParagraphsByIndexes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs response = TestUtils.SlidesApi.DeleteParagraphs(c_fileName, c_slideIndex, c_shapeIndex,
                new List<int> { 2 }, c_password, c_folderName);
            Assert.AreEqual(1, response.ParagraphLinks.Count);
        }

        [Test]
        public void DeleteSubShapeParagraphs()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs response = TestUtils.SlidesApi.DeleteParagraphs(c_fileName, c_slideIndex, 3,
                null, c_password, c_folderName, subShape:"1");
            Assert.AreEqual(0, response.ParagraphLinks.Count);
        }

        [Test]
        public void DeleteSubShapeParagraphsByIndexes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs response = TestUtils.SlidesApi.DeleteParagraphs(c_fileName, c_slideIndex, 3, 
                new List<int> { 1 }, c_password, c_folderName, subShape: "1");
            Assert.AreEqual(1, response.ParagraphLinks.Count);
        }

        [Test]
        public void DeleteParagraph()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs response = TestUtils.SlidesApi.DeleteParagraph(c_fileName, c_slideIndex, c_shapeIndex, 1,
                c_password, c_folderName);
            Assert.AreEqual(1, response.ParagraphLinks.Count);
        }

        [Test]
        public void DeleteSubShapeParagraph()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs response = TestUtils.SlidesApi.DeleteParagraph(c_fileName, c_slideIndex, 3,
                1, c_password, c_folderName, subShape: "1");
            Assert.AreEqual(1, response.ParagraphLinks.Count);
        }

        [Test]
        public void GetParagraphRectangle()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TextBounds response =TestUtils.SlidesApi.GetParagraphRectangle(c_fileName, c_slideIndex, c_shapeIndex, 1, c_password,
                c_folderName);
                
            Assert.IsNotNull(response);
            Assert.Greater(response.X, 0);
            Assert.Greater(response.Y, 0);
            Assert.Greater(response.Width, 0);
            Assert.Greater(response.Height, 0);
        }
        
        [Test]
        public void ParagraphDefaultPortionFormat()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            Paragraph dto = new Paragraph()
            {
                DefaultPortionFormat = new PortionFormat()
                {
                  FontHeight  = 20,
                  LatinFont = "Arial"
                },
                PortionList = new List<Portion>()
                {
                    new Portion()
                    {
                        Text = "Portion1"
                    },
                    new Portion()
                    {
                        Text = "Portion2"
                    }
                }
            };
            
            Paragraph response = TestUtils.SlidesApi.CreateParagraph(c_fileName, c_slideIndex, c_shapeIndex, dto,
                null, c_password, c_folderName);
            Assert.AreEqual(response.PortionList.Count, 2);
            Assert.IsNotNull(response.DefaultPortionFormat);
            Assert.AreEqual(response.DefaultPortionFormat.LatinFont, dto.DefaultPortionFormat.LatinFont);
            Assert.AreEqual(response.DefaultPortionFormat.FontHeight, dto.DefaultPortionFormat.FontHeight);
        }
        
        [Test]
        public void GetParagraphEffective()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraph response =
                TestUtils.SlidesApi.GetParagraphEffective(c_fileName, c_slideIndex, c_shapeIndex, 1, c_password, c_folderName);
            Assert.AreEqual(72, response.DefaultTabSize);
        }

        [Test]
        public void GetSubShapeParagraphEffective()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraph response = TestUtils.SlidesApi.GetParagraphEffective(c_fileName, c_slideIndex, 3,
                1, c_password, c_folderName, subShape: "1");
            Assert.AreEqual(72, response.DefaultTabSize);
        }

        const int c_slideIndex = 6;
        const int c_shapeIndex = 2;
    }
}