// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PipelineTests.cs">
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
            GetSlideShapeRequest request = new GetSlideShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex
            };
            Chart chart = TestUtils.SlidesApi.GetSlideShape(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void ChartCreate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new Chart
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
                }
            };
            Chart chart = TestUtils.SlidesApi.PostAddNewShape(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(2, chart.Series.Count);
            Assert.AreEqual(3, chart.Categories.Count);
        }

        [Test]
        public void ChartUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutSlideShapeInfoRequest request = new PutSlideShapeInfoRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                Dto = new Chart
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
                }
            };
            Chart chart = TestUtils.SlidesApi.PutSlideShapeInfo(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(2, chart.Series.Count);
            Assert.AreEqual(3, chart.Categories.Count);
        }

        [Test]
        public void ChartSeriesCreate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostChartSeriesRequest request = new PostChartSeriesRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                Series = new OneValueSeries
                {
                    Name = "Series1",
                    DataPoints = new List<OneValueChartDataPoint>
                    {
                        new OneValueChartDataPoint { Value = 40 },
                        new OneValueChartDataPoint { Value = 50 },
                        new OneValueChartDataPoint { Value = 14 },
                        new OneValueChartDataPoint { Value = 70 }
                    }
                }
            };
            Chart chart = TestUtils.SlidesApi.PostChartSeries(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount + 1, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void ChartSeriesUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutChartSeriesRequest request = new PutChartSeriesRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                SeriesIndex = c_seriesIndex,
                Series = new OneValueSeries
                {
                    DataPoints = new List<OneValueChartDataPoint>
                    {
                        new OneValueChartDataPoint { Value = 40 },
                        new OneValueChartDataPoint { Value = 50 },
                        new OneValueChartDataPoint { Value = 14 },
                        new OneValueChartDataPoint { Value = 70 }
                    }
                }
            };
            Chart chart = TestUtils.SlidesApi.PutChartSeries(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void ChartSeriesDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DeleteChartSeriesRequest request = new DeleteChartSeriesRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                SeriesIndex = c_seriesIndex
            };
            Chart chart = TestUtils.SlidesApi.DeleteChartSeries(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount - 1, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void ChartCategoryCreate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostChartCategoryRequest request = new PostChartCategoryRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                Category = new ChartCategory
                {
                    Value = "NewCategory",
                    DataPoints = new List<OneValueChartDataPoint>
                    {
                        new OneValueChartDataPoint { Value = 40 },
                        new OneValueChartDataPoint { Value = 50 },
                        new OneValueChartDataPoint { Value = 14 }
                    }
                }
            };
            Chart chart = TestUtils.SlidesApi.PostChartCategory(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount + 1, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount + 1, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
            Assert.AreEqual(request.Category.DataPoints[0].Value, ((OneValueSeries)chart.Series[0]).DataPoints[c_categoryCount].Value);
        }

        [Test]
        public void ChartCategoryUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutChartCategoryRequest request = new PutChartCategoryRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                CategoryIndex = c_categoryIndex,
                Category = new ChartCategory
                {
                    Value = "NewCategory",
                    DataPoints = new List<OneValueChartDataPoint>
                    {
                        new OneValueChartDataPoint { Value = 40 },
                        new OneValueChartDataPoint { Value = 50 },
                        new OneValueChartDataPoint { Value = 14 }
                    }
                }
            };
            Chart chart = TestUtils.SlidesApi.PutChartCategory(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
            Assert.AreEqual(request.Category.DataPoints[0].Value, ((OneValueSeries)chart.Series[0]).DataPoints[c_categoryIndex - 1].Value);
        }

        [Test]
        public void ChartCategoryDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DeleteChartCategoryRequest request = new DeleteChartCategoryRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                CategoryIndex = c_categoryIndex
            };
            Chart chart = TestUtils.SlidesApi.DeleteChartCategory(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount - 1, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount - 1, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
        }

        [Test]
        [ExpectedException(typeof(ApiException))]
        public void ChartDataPointCreate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostChartDataPointRequest request = new PostChartDataPointRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                SeriesIndex = c_seriesIndex,
                DataPoint = new OneValueChartDataPoint { Value = 40 }
            };
            //Must throw ApiException because adding data points only works with Scatter & Bubble charts.
            TestUtils.SlidesApi.PostChartDataPoint(request);
        }

        [Test]
        public void ChartDataPointUpdate()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PutChartDataPointRequest request = new PutChartDataPointRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                SeriesIndex = c_seriesIndex,
                PointIndex = c_categoryIndex,
                DataPoint = new OneValueChartDataPoint { Value = 40 }
            };
            Chart chart = TestUtils.SlidesApi.PutChartDataPoint(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
            Assert.AreEqual(((OneValueChartDataPoint)request.DataPoint).Value, ((OneValueSeries)chart.Series[c_seriesIndex - 1]).DataPoints[c_categoryIndex - 1].Value);
        }

        [Test]
        public void ChartDataPointDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DeleteChartDataPointRequest request = new DeleteChartDataPointRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                ShapeIndex = c_shapeIndex,
                SeriesIndex = c_seriesIndex,
                PointIndex = c_categoryIndex
            };
            Chart chart = TestUtils.SlidesApi.DeleteChartDataPoint(request) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
            Assert.IsNull(((OneValueSeries)chart.Series[c_seriesIndex - 1]).DataPoints[c_categoryIndex - 1]);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "ChartTest.pptx";
        const string c_password = "password";
        const int c_slideIndex = 1;
        const int c_shapeIndex = 2;
        const int c_seriesIndex = 2;
        const int c_categoryIndex = 2;
        const int c_seriesCount = 3;
        const int c_categoryCount = 4;
        const ShapeExportFormat c_format = ShapeExportFormat.Png;
    }
}
