// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NullableFieldTests.cs">
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
using NUnit.Framework;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing nullable fields
    /// </summary>
    [TestFixture]
    public class NullableFieldTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void DefaultChartValues()
        {
            const string folderName = "TempSlidesSDK";
            const string fileName = "test.pptx";
            const int slideIndex = 1;
            const int shapeIndex = 5;
            const double min1  = 44.3;
            const double min2 = 12;
            const double max1 = 104.3;
            const double max2 = 87;
            TestUtils.Upload(fileName, folderName + "/" + fileName);
            Chart dto = new Chart
            {
                ChartType = Chart.ChartTypeEnum.Line,
                Width = 400,
                Height = 300,
                HasTitle = true,
                Title = new ChartTitle { Text = "MyTitle" },
                Series = new List<Series>
                {
                    new OneValueSeries
                    {
                        Type = Series.TypeEnum.ClusteredColumn,
                        Name = "Series1",
                        DataPoints = new List<OneValueChartDataPoint> { new OneValueChartDataPoint { Value = 40 }, new OneValueChartDataPoint { Value = 50 } }
                    }
                },
                Axes = new Axes { HorizontalAxis = new Axis { IsAutomaticMinValue = false, MinValue = min1, IsAutomaticMaxValue = false, MaxValue = max1 } }
            };
            ShapeBase shape = TestUtils.SlidesApi.CreateShape(fileName, slideIndex, dto, password: "password", folder: folderName);
            Assert.IsInstanceOf<Chart>(shape);
            shape = TestUtils.SlidesApi.GetShape(fileName, slideIndex, shapeIndex, "password", folderName);
            Assert.AreEqual(min1, ((Chart)shape).Axes.HorizontalAxis.MinValue);
            Assert.AreEqual(max1, ((Chart)shape).Axes.HorizontalAxis.MaxValue);
            dto = new Chart { Axes = new Axes { HorizontalAxis = new Axis { MinValue = min2 } } };
            shape = TestUtils.SlidesApi.UpdateShape(fileName, slideIndex, shapeIndex, dto, "password", folderName);
            Assert.IsInstanceOf<Chart>(shape);
            shape = TestUtils.SlidesApi.GetShape(fileName, slideIndex, shapeIndex, "password", folderName);
            Assert.AreEqual(min2, ((Chart)shape).Axes.HorizontalAxis.MinValue);
            Assert.AreEqual(max1, ((Chart)shape).Axes.HorizontalAxis.MaxValue);
            dto.Axes = new Axes { HorizontalAxis = new Axis { MaxValue = max2 } };
            shape = TestUtils.SlidesApi.UpdateShape(fileName, slideIndex, shapeIndex, dto, "password", folderName);
            Assert.IsInstanceOf<Chart>(shape);
            shape = TestUtils.SlidesApi.GetShape(fileName, slideIndex, shapeIndex, "password", folderName);
            Assert.AreEqual(min2, ((Chart)shape).Axes.HorizontalAxis.MinValue);
            Assert.AreEqual(max2, ((Chart)shape).Axes.HorizontalAxis.MaxValue);
        }
    }
}
