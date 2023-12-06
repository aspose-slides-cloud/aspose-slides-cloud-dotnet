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
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;
using Aspose.Slides.Cloud.Sdk.Model;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    [TestFixture]
    public class SlideTest : BaseTests
    {
        [Test]
        public void GetSlides()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Model.Slides slides = TestUtils.SlidesApi.GetSlides(c_fileName, c_password, c_folderName);
            Assert.AreEqual(c_slideCount, slides.SlideList.Count);
        }

        [Test]
        public void GetSlide()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Slide slide = TestUtils.SlidesApi.GetSlide(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.IsNotNull(slide);
        }

        [Test]
        public void CreateSlide()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            Model.Slides slides =
                TestUtils.SlidesApi.CreateSlide(c_fileName, c_layoutSlidePath, 1, c_password, c_folderName);
            Assert.AreEqual(c_slideCount + 1, slides.SlideList.Count);

            slides = TestUtils.SlidesApi.CreateSlide(c_fileName, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_slideCount + 2, slides.SlideList.Count);
        }

        [Test]
        public void CopySlide()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            Model.Slides slides =
                TestUtils.SlidesApi.CopySlide(c_fileName, 3, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_slideCount + 1, slides.SlideList.Count);
        }

        [Test]
        public void CopySlideFromSource()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.Upload(c_sourceFileName, c_folderName + "/" + c_sourceFileName);

            Model.Slides slides = TestUtils.SlidesApi.CopySlide(c_fileName, c_slideIndex, 1, $"{c_folderName}/{c_sourceFileName}",
                password: c_password, folder: c_folderName);
            Assert.AreEqual(c_slideCount + 1, slides.SlideList.Count);
        }

        [Test]
        public void MoveSlide()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Model.Slides slides = TestUtils.SlidesApi.MoveSlide(c_fileName, c_slideIndex, 2, c_password, c_folderName);
            Assert.AreEqual(c_slideCount, slides.SlideList.Count);
        }

        [Test]
        public void ReorderSlides()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            List<int> oldPositions = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> newPositions = new List<int>() { 6, 5, 4, 3, 2, 1 };

            Model.Slides slides =
                TestUtils.SlidesApi.ReorderSlides(c_fileName, oldPositions, newPositions, c_password, c_folderName);
            Assert.AreEqual(c_slideCount, slides.SlideList.Count);
        }
        
        [Test]
        public void UpdateSlide()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Slide dto = new Slide()
            {
                LayoutSlide = new ResourceUri()
                {
                    Href = c_layoutSlidePath
                }
            };
            
            Slide slide = TestUtils.SlidesApi.UpdateSlide(c_fileName, c_slideIndex, dto, c_password, c_folderName);
            Assert.IsTrue(slide.LayoutSlide.Href.Contains(c_layoutSlidePath));
        }

        [Test]
        public void SetSlideTransition()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Slide dto = new Slide
            {
                SlideShowTransition = new SlideShowTransition
                {
                    Type = SlideShowTransition.TypeEnum.Circle,
                    Speed = SlideShowTransition.SpeedEnum.Medium
                }
            };

            Slide slide = TestUtils.SlidesApi.UpdateSlide(c_fileName, c_slideIndex, dto, c_password, c_folderName);
            Assert.AreEqual(dto.SlideShowTransition.Type, slide.SlideShowTransition.Type);
        }

        [Test]
        public void DeleteSlides()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Model.Slides slides = TestUtils.SlidesApi.DeleteSlides(c_fileName, null, c_password, c_folderName);
            Assert.AreEqual(1, slides.SlideList.Count);
        }
        
        [Test]
        public void DeleteSlidesByIndexes()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            List<int> indexes = new List<int>{1,3,5};
            Model.Slides slides = TestUtils.SlidesApi.DeleteSlides(c_fileName, indexes, c_password, c_folderName);
            Assert.AreEqual(c_slideCount - 3, slides.SlideList.Count);
        }
        
        [Test]
        public void DeleteSlide()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Model.Slides slides = TestUtils.SlidesApi.DeleteSlide(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.AreEqual(c_slideCount - 1, slides.SlideList.Count);
        }
        
        [Test]
        public void GetBackground()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 5;
            SlideBackground response = TestUtils.SlidesApi.GetBackground(c_fileName, slideIndex, c_password, c_folderName);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
        }
        
        [Test]
        public void SetBackground()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            SlideBackground dto = new SlideBackground()
            {
                FillFormat = new SolidFill()
                {
                    Color = c_color
                }
            };
            
            SlideBackground response = TestUtils.SlidesApi.SetBackground(c_fileName, c_slideIndex, dto, c_password, c_folderName);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
            Assert.AreEqual(c_color, ((SolidFill)response.FillFormat).Color);
        }
        
        [Test]
        public void SetBackgroundColor()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            SlideBackground response = TestUtils.SlidesApi.SetBackgroundColor(c_fileName, c_slideIndex, c_color, c_password, c_folderName);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
            Assert.AreEqual(c_color, ((SolidFill)response.FillFormat).Color);
        }
        
        [Test]
        public void DeleteBackground()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 5;
            SlideBackground response = TestUtils.SlidesApi.DeleteBackground(c_fileName, slideIndex, c_password, c_folderName);
            Assert.IsInstanceOf<NoFill>(response.FillFormat);
        }

        const string c_sourceFileName = "TemplateCV.pptx";
        const int c_slideIndex = 1;
        const int c_slideCount = 9;
        const string c_layoutSlidePath = "layoutSlides/3";
        const string c_color = "#FFF5FF8A";
    }
}