// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NotesSlideTests.cs">
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
using System.IO;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing notes slide methods
    /// </summary>
    [TestFixture]
    public class NotesSlideTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void NotesSlideGetStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            NotesSlide notesSlide = TestUtils.SlidesApi.GetNotesSlide(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.IsNotNull(notesSlide);
        }

        [Test]
        public void NotesSlideExistsStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            EntityExists exists = TestUtils.SlidesApi.NotesSlideExists(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void NotesSlideDownloadStorage()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Stream notesSlide = TestUtils.SlidesApi.DownloadNotesSlide(
                c_fileName, c_slideIndex, c_format, password: c_password, folder: c_folderName);
            Assert.IsNotNull(notesSlide);
            Assert.Greater(notesSlide.Length, 0);
            Assert.IsTrue(notesSlide.CanRead);
        }

        [Test]
        public void NotesSlideGetRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            NotesSlide notesSlide = TestUtils.SlidesApi.GetNotesSlideOnline(document, c_slideIndex, c_password);
            Assert.IsNotNull(notesSlide);
        }

        [Test]
        public void NotesSlideExistsRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            EntityExists exists = TestUtils.SlidesApi.NotesSlideExistsOnline(document, c_slideIndex, c_password);
            Assert.IsTrue(exists.Exists.Value);
        }

        [Test]
        public void NotesSlideDownloadRequest()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream notesSlide = TestUtils.SlidesApi.DownloadNotesSlideOnline(document, c_slideIndex, c_format, password: c_password);
            Assert.IsNotNull(notesSlide);
            Assert.Greater(notesSlide.Length, 0);
            Assert.IsTrue(notesSlide.CanRead);
        }

        [Test]
        public void NotesSlideShapes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes shapes = TestUtils.SlidesApi.GetSpecialSlideShapes(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_password, c_folderName);
            Assert.AreEqual(c_shapeCount, shapes.ShapesLinks.Count);

            Shape dto = new Shape
            {
                X = 100,
                Y = 100,
                Width = 500,
                Height = 200,
                ShapeType = GeometryShape.ShapeTypeEnum.Rectangle,
                Text = "New shape"
            };
            Shape shape = (Shape)TestUtils.SlidesApi.CreateSpecialSlideShape(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(dto.Text, shape.Text);
            shapes = TestUtils.SlidesApi.GetSpecialSlideShapes(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_password, c_folderName);
            Assert.AreEqual(c_shapeCount + 1, shapes.ShapesLinks.Count);

            dto.Text = "Updated shape";
            shape = (Shape)TestUtils.SlidesApi.UpdateSpecialSlideShape(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeCount + 1, dto, c_password, c_folderName);
            Assert.AreEqual(dto.Text, shape.Text);
            shapes = TestUtils.SlidesApi.GetSpecialSlideShapes(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_password, c_folderName);
            Assert.AreEqual(c_shapeCount + 1, shapes.ShapesLinks.Count);

            TestUtils.SlidesApi.DeleteSpecialSlideShape(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeCount + 1, c_password, c_folderName);
            shapes = TestUtils.SlidesApi.GetSpecialSlideShapes(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_password, c_folderName);
            Assert.AreEqual(c_shapeCount, shapes.ShapesLinks.Count);
        }

        [Test]
        public void NotesSlideParagraphs()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs paragraphs = TestUtils.SlidesApi.GetSpecialSlideParagraphs(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(c_paragraphCount, paragraphs.ParagraphLinks.Count);

            Paragraph dto = new Paragraph
            {
                Alignment = Paragraph.AlignmentEnum.Right,
                PortionList = new List<Portion> { new Portion { Text = "New paragraph" } }
            };
            Paragraph paragraph = TestUtils.SlidesApi.CreateSpecialSlideParagraph(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(dto.Alignment, paragraph.Alignment);
            paragraphs = TestUtils.SlidesApi.GetSpecialSlideParagraphs(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(c_paragraphCount + 1, paragraphs.ParagraphLinks.Count);

            dto = new Paragraph { Alignment = Paragraph.AlignmentEnum.Center };
            paragraph = TestUtils.SlidesApi.UpdateSpecialSlideParagraph(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_paragraphCount + 1, dto, c_password, c_folderName);
            Assert.AreEqual(dto.Alignment, paragraph.Alignment);
            paragraphs = TestUtils.SlidesApi.GetSpecialSlideParagraphs(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(c_paragraphCount + 1, paragraphs.ParagraphLinks.Count);

            TestUtils.SlidesApi.DeleteSpecialSlideParagraph(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_paragraphCount + 1, c_password, c_folderName);
            paragraphs = TestUtils.SlidesApi.GetSpecialSlideParagraphs(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(c_paragraphCount, paragraphs.ParagraphLinks.Count);
        }

        [Test]
        public void NotesSlidePortions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions portions = TestUtils.SlidesApi.GetSpecialSlidePortions(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(c_portionCount, portions.Items.Count);

            Portion dto = new Portion
            {
                FontBold = Portion.FontBoldEnum.True,
                Text = "New portion"
            };
            Portion portion = TestUtils.SlidesApi.CreateSpecialSlidePortion(
                c_fileName,
                c_slideIndex,
                SpecialSlideType.NotesSlide,
                c_shapeIndex,
                c_paragraphIndex,
                dto,
                password: c_password,
                folder: c_folderName);
            Assert.AreEqual(dto.FontBold, portion.FontBold);
            Assert.AreEqual(dto.Text, portion.Text);
            portions = TestUtils.SlidesApi.GetSpecialSlidePortions(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(c_portionCount + 1, portions.Items.Count);

            Portion dto2 = new Portion
            {
                FontHeight = 22,
                Text = "Updated portion"
            };
            portion = TestUtils.SlidesApi.UpdateSpecialSlidePortion(
                c_fileName,
                c_slideIndex,
                SpecialSlideType.NotesSlide,
                c_shapeIndex,
                c_paragraphIndex,
                c_portionCount + 1,
                dto2,
                c_password,
                c_folderName);
            Assert.AreEqual(dto.FontBold, portion.FontBold);
            Assert.AreEqual(dto2.FontHeight, portion.FontHeight);
            Assert.AreEqual(dto2.Text, portion.Text);
            portions = TestUtils.SlidesApi.GetSpecialSlidePortions(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(c_portionCount + 1, portions.Items.Count);

            TestUtils.SlidesApi.DeleteSpecialSlidePortion(
                c_fileName,
                c_slideIndex,
                SpecialSlideType.NotesSlide,
                c_shapeIndex,
                c_paragraphIndex,
                c_portionCount + 1,
                c_password,
                c_folderName);
            portions = TestUtils.SlidesApi.GetSpecialSlidePortions(
                c_fileName, c_slideIndex, SpecialSlideType.NotesSlide, c_shapeIndex, c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(c_portionCount, portions.Items.Count);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 1;
        const NotesSlideExportFormat c_format = NotesSlideExportFormat.Png;
        const int c_shapeIndex = 2;
        const int c_shapeCount = 3;
        const int c_paragraphIndex = 1;
        const int c_paragraphCount = 1;
        const int c_portionCount = 1;
    }
}
