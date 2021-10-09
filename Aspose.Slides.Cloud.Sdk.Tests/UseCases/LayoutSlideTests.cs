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
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Timeout config parameter
    /// </summary>
    [TestFixture]
    public class LayoutSlideTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void LayoutSlides()
        {
            const string sourceFile = "TemplateCV.pptx";
            string sourcePath = c_folderName + "/" + sourceFile;
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.Upload(sourceFile, sourcePath);

            LayoutSlides layoutSlides = TestUtils.SlidesApi.GetLayoutSlides(c_fileName, c_password, c_folderName);
            Assert.AreEqual(11, layoutSlides.SlideList.Count);

            LayoutSlide layoutSlide = TestUtils.SlidesApi.GetLayoutSlide(c_fileName, 1, c_password, c_folderName);
            Assert.AreEqual("Title Slide", layoutSlide.Name);

            layoutSlide = TestUtils.SlidesApi.CopyLayoutSlide(
                c_fileName, sourcePath, 2, password: c_password, folder: c_folderName);
            Assert.AreEqual("Title and Content", layoutSlide.Name);

            layoutSlides = TestUtils.SlidesApi.GetLayoutSlides(c_fileName, c_password, c_folderName);
            Assert.AreEqual(12, layoutSlides.SlideList.Count);
        }

        [Test]
        public void LayoutSlideShapes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Shapes shapes = TestUtils.SlidesApi.GetSpecialSlideShapes(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_password, c_folderName);
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
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(dto.Text, shape.Text);
            shapes = TestUtils.SlidesApi.GetSpecialSlideShapes(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_password, c_folderName);
            Assert.AreEqual(c_shapeCount + 1, shapes.ShapesLinks.Count);

            dto.Text = "Updated shape";
            shape = (Shape)TestUtils.SlidesApi.UpdateSpecialSlideShape(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeCount + 1, dto, c_password, c_folderName);
            Assert.AreEqual(dto.Text, shape.Text);
            shapes = TestUtils.SlidesApi.GetSpecialSlideShapes(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_password, c_folderName);
            Assert.AreEqual(c_shapeCount + 1, shapes.ShapesLinks.Count);

            TestUtils.SlidesApi.DeleteSpecialSlideShape(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeCount + 1, c_password, c_folderName);
            shapes = TestUtils.SlidesApi.GetSpecialSlideShapes(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_password, c_folderName);
            Assert.AreEqual(c_shapeCount, shapes.ShapesLinks.Count);
        }

        [Test]
        public void LayoutSlideParagraphs()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Paragraphs paragraphs = TestUtils.SlidesApi.GetSpecialSlideParagraphs(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(c_paragraphCount, paragraphs.ParagraphLinks.Count);

            Paragraph dto = new Paragraph
            {
                Alignment = Paragraph.AlignmentEnum.Right,
                PortionList = new List<Portion> { new Portion { Text = "New paragraph" } }
            };
            Paragraph paragraph = TestUtils.SlidesApi.CreateSpecialSlideParagraph(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(dto.Alignment, paragraph.Alignment);
            paragraphs = TestUtils.SlidesApi.GetSpecialSlideParagraphs(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(c_paragraphCount + 1, paragraphs.ParagraphLinks.Count);

            dto = new Paragraph { Alignment = Paragraph.AlignmentEnum.Center };
            paragraph = TestUtils.SlidesApi.UpdateSpecialSlideParagraph(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_paragraphCount + 1, dto, c_password, c_folderName);
            Assert.AreEqual(dto.Alignment, paragraph.Alignment);
            paragraphs = TestUtils.SlidesApi.GetSpecialSlideParagraphs(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(c_paragraphCount + 1, paragraphs.ParagraphLinks.Count);

            TestUtils.SlidesApi.DeleteSpecialSlideParagraph(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_paragraphCount + 1, c_password, c_folderName);
            paragraphs = TestUtils.SlidesApi.GetSpecialSlideParagraphs(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(c_paragraphCount, paragraphs.ParagraphLinks.Count);
        }

        [Test]
        public void LayoutSlidePortions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Portions portions = TestUtils.SlidesApi.GetSpecialSlidePortions(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(c_portionCount, portions.Items.Count);

            Portion dto = new Portion
            {
                FontBold = Portion.FontBoldEnum.True,
                Text = "New portion"
            };
            Portion portion = TestUtils.SlidesApi.CreateSpecialSlidePortion(
                c_fileName,
                c_slideIndex,
                SpecialSlideType.LayoutSlide,
                c_shapeIndex,
                c_paragraphIndex,
                dto,
                password: c_password,
                folder: c_folderName);
            Assert.AreEqual(dto.FontBold, portion.FontBold);
            Assert.AreEqual(dto.Text, portion.Text);
            portions = TestUtils.SlidesApi.GetSpecialSlidePortions(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(c_portionCount + 1, portions.Items.Count);

            Portion dto2 = new Portion
            {
                FontHeight = 22,
                Text = "Updated portion"
            };
            portion = TestUtils.SlidesApi.UpdateSpecialSlidePortion(
                c_fileName,
                c_slideIndex,
                SpecialSlideType.LayoutSlide,
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
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(c_portionCount + 1, portions.Items.Count);

            TestUtils.SlidesApi.DeleteSpecialSlidePortion(
                c_fileName,
                c_slideIndex,
                SpecialSlideType.LayoutSlide,
                c_shapeIndex,
                c_paragraphIndex,
                c_portionCount + 1,
                c_password,
                c_folderName);
            portions = TestUtils.SlidesApi.GetSpecialSlidePortions(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_shapeIndex, c_paragraphIndex, c_password, c_folderName);
            Assert.AreEqual(c_portionCount, portions.Items.Count);
        }

        [Test]
        public void LayoutSlideAnimation()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideAnimation animation = TestUtils.SlidesApi.GetSpecialSlideAnimation(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, null, c_password, c_folderName);
            Assert.AreEqual(1, animation.MainSequence.Count);

            SlideAnimation dto = new SlideAnimation
            {
                MainSequence = new List<Effect>
                {
                    new Effect
                    {
                        Type = Effect.TypeEnum.Blink,
                        ShapeIndex = 2
                    },
                    new Effect
                    {
                        Type = Effect.TypeEnum.Appear,
                        ShapeIndex = 3
                    }
                }
            };
            animation = TestUtils.SlidesApi.SetSpecialSlideAnimation(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, dto, c_password, c_folderName);
            Assert.AreEqual(dto.MainSequence.Count, animation.MainSequence.Count);
            animation = TestUtils.SlidesApi.GetSpecialSlideAnimation(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, 3, c_password, c_folderName);
            Assert.AreEqual(1, animation.MainSequence.Count);

            animation = TestUtils.SlidesApi.DeleteSpecialSlideAnimationEffect(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, 2, c_password, c_folderName);
            Assert.AreEqual(dto.MainSequence.Count - 1, animation.MainSequence.Count);
            animation = TestUtils.SlidesApi.GetSpecialSlideAnimation(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, 3, c_password, c_folderName);
            Assert.AreEqual(0, animation.MainSequence.Count);

            animation = TestUtils.SlidesApi.DeleteSpecialSlideAnimation(
                c_fileName, c_slideIndex, SpecialSlideType.LayoutSlide, c_password, c_folderName);
            Assert.AreEqual(0, animation.MainSequence.Count);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 1;
        const int c_shapeIndex = 2;
        const int c_shapeCount = 6;
        const int c_paragraphIndex = 1;
        const int c_paragraphCount = 1;
        const int c_portionCount = 1;
    }
}
