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

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing chart API
    /// </summary>
    [TestFixture]
    public class ChartTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void ChartGet()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart = TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, c_password, c_folderName) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void ChartCreate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new Chart
            {
                ChartType = Chart.ChartTypeEnum.ClusteredColumn,
                Width = 400,
                Height = 300,
                Categories = new List<ChartCategory>
                {
                    new ChartCategory { Value = "Category1" },
                    new ChartCategory { Value = "Category2" },
                    new ChartCategory { Value = "Category3" }
                },
                Series = new List<Series>
                {
                    new OneValueSeries
                    {
                        Name = "Series1",
                        DataPoints = new List<OneValueChartDataPoint>
                        {
                            new OneValueChartDataPoint { Value = 40 },
                            new OneValueChartDataPoint { Value = 50 },
                            new OneValueChartDataPoint { Value = 70 }
                        }
                    },
                    new OneValueSeries
                    {
                        Name = "Series2",
                        DataPoints = new List<OneValueChartDataPoint>
                        {
                            new OneValueChartDataPoint { Value = 55 },
                            new OneValueChartDataPoint { Value = 35 },
                            new OneValueChartDataPoint { Value = 90 }
                        }
                    }
                }
            };
            Chart chart = TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, dto, password: c_password, folder: c_folderName) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(2, chart.Series.Count);
            Assert.AreEqual(3, chart.Categories.Count);
        }

        [Test]
        public void ChartUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new Chart
            {
                ChartType = Chart.ChartTypeEnum.ClusteredColumn,
                Width = 400,
                Height = 300,
                Categories = new List<ChartCategory>
                {
                    new ChartCategory { Value = "Category1" },
                    new ChartCategory { Value = "Category2" },
                    new ChartCategory { Value = "Category3" }
                },
                Series = new List<Series>
                {
                    new OneValueSeries
                    {
                        Name = "Series1",
                        DataPoints = new List<OneValueChartDataPoint>
                        {
                            new OneValueChartDataPoint { Value = 40 },
                            new OneValueChartDataPoint { Value = 50 },
                            new OneValueChartDataPoint { Value = 70 }
                        }
                    },
                    new OneValueSeries
                    {
                        Name = "Series2",
                        DataPoints = new List<OneValueChartDataPoint>
                        {
                            new OneValueChartDataPoint { Value = 55 },
                            new OneValueChartDataPoint { Value = 35 },
                            new OneValueChartDataPoint { Value = 90 }
                        }
                    }
                }
            };
            Chart chart = TestUtils.SlidesApi.UpdateShape(c_fileName, c_slideIndex, c_shapeIndex, dto, c_password, c_folderName) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(2, chart.Series.Count);
            Assert.AreEqual(3, chart.Categories.Count);
        }

        [Test]
        public void ChartSeriesCreate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Series series = new OneValueSeries
            {
                Name = "Series1",
                DataPoints = new List<OneValueChartDataPoint>
                {
                    new OneValueChartDataPoint { Value = 40 },
                    new OneValueChartDataPoint { Value = 50 },
                    new OneValueChartDataPoint { Value = 14 },
                    new OneValueChartDataPoint { Value = 70 }
                }
            };
            Chart chart = TestUtils.SlidesApi.CreateChartSeries(c_fileName, c_slideIndex, c_shapeIndex, series, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount + 1, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void ChartSeriesUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Series series = new OneValueSeries
            {
                DataPoints = new List<OneValueChartDataPoint>
                {
                    new OneValueChartDataPoint { Value = 40 },
                    new OneValueChartDataPoint { Value = 50 },
                    new OneValueChartDataPoint { Value = 14 },
                    new OneValueChartDataPoint { Value = 70 }
                }
            };
            Chart chart = TestUtils.SlidesApi.UpdateChartSeries(
                c_fileName, c_slideIndex, c_shapeIndex, c_seriesIndex, series, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void ChartSeriesDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart = TestUtils.SlidesApi.DeleteChartSeries(
                c_fileName, c_slideIndex, c_shapeIndex, c_seriesIndex, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount - 1, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void ChartCategoryCreate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ChartCategory category = new ChartCategory
            {
                Value = "NewCategory",
                DataPoints = new List<OneValueChartDataPoint>
                {
                    new OneValueChartDataPoint { Value = 40 },
                    new OneValueChartDataPoint { Value = 50 },
                    new OneValueChartDataPoint { Value = 14 }
                }
            };
            Chart chart = TestUtils.SlidesApi.CreateChartCategory(c_fileName, c_slideIndex, c_shapeIndex, category, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount + 1, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount + 1, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
            Assert.AreEqual(category.DataPoints[0].Value, ((OneValueSeries)chart.Series[0]).DataPoints[c_categoryCount].Value);
        }

        [Test]
        public void ChartCategoryUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ChartCategory category = new ChartCategory
            {
                Value = "NewCategory",
                DataPoints = new List<OneValueChartDataPoint>
                {
                    new OneValueChartDataPoint { Value = 40 },
                    new OneValueChartDataPoint { Value = 50 },
                    new OneValueChartDataPoint { Value = 14 }
                }
            };
            Chart chart = TestUtils.SlidesApi.UpdateChartCategory(
                c_fileName, c_slideIndex, c_shapeIndex, c_categoryIndex, category, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
            Assert.AreEqual(category.DataPoints[0].Value, ((OneValueSeries)chart.Series[0]).DataPoints[c_categoryIndex - 1].Value);
        }

        [Test]
        public void ChartCategoryDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart = TestUtils.SlidesApi.DeleteChartCategory(
                c_fileName, c_slideIndex, c_shapeIndex, c_categoryIndex, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount - 1, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount - 1, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
        }

        [Test]
        public void ChartDataPointCreate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DataPoint dataPoint = new OneValueChartDataPoint { Value = 40 };
            //Must throw ApiException because adding data points only works with Scatter & Bubble charts.
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.CreateChartDataPoint(
                c_fileName, c_slideIndex, c_shapeIndex, c_seriesIndex, dataPoint, c_password, c_folderName));
        }

        [Test]
        public void ChartDataPointUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            OneValueChartDataPoint dataPoint = new OneValueChartDataPoint { Value = 40 };
            Chart chart = TestUtils.SlidesApi.UpdateChartDataPoint(
                c_fileName, c_slideIndex, c_shapeIndex, c_seriesIndex, c_categoryIndex, dataPoint, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
            Assert.AreEqual(dataPoint.Value, ((OneValueSeries)chart.Series[c_seriesIndex - 1]).DataPoints[c_categoryIndex - 1].Value);
        }

        [Test]
        public void ChartDataPointDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart = TestUtils.SlidesApi.DeleteChartDataPoint(
                c_fileName, c_slideIndex, c_shapeIndex, c_seriesIndex, c_categoryIndex, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
            Assert.IsNull(((OneValueSeries)chart.Series[c_seriesIndex - 1]).DataPoints[c_categoryIndex - 1]);
        }

        [Test]
        public void SunburstChart()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new Chart
            {
                ChartType = Chart.ChartTypeEnum.Sunburst,
                Width = 400,
                Height = 300,
                Categories = new List<ChartCategory>
                {
                    new ChartCategory { Value = "Leaf1", ParentCategories = new List<string> { "Branch1", "Stem1" } },
                    new ChartCategory { Value = "Leaf2", ParentCategories = new List<string> { "Branch1", "Stem1" } },
                    new ChartCategory { Value = "Branch2", ParentCategories = new List<string> { "Stem1" } },
                    new ChartCategory { Value = "Stem2" }
                },
                Series = new List<Series>
                {
                    new OneValueSeries
                    {
                        Name = "Series1",
                        DataPoints = new List<OneValueChartDataPoint>
                        {
                            new OneValueChartDataPoint { Value = 40 },
                            new OneValueChartDataPoint { Value = 50 },
                            new OneValueChartDataPoint { Value = 70 },
                            new OneValueChartDataPoint { Value = 80 }
                        }
                    }
                }
            };
            Chart chart = TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, dto, password: c_password, folder: c_folderName) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(1, chart.Series.Count);
            Assert.AreEqual(4, chart.Categories.Count);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 3;
        const int c_shapeIndex = 1;
        const int c_seriesIndex = 2;
        const int c_categoryIndex = 2;
        const int c_seriesCount = 3;
        const int c_categoryCount = 4;
    }
}
