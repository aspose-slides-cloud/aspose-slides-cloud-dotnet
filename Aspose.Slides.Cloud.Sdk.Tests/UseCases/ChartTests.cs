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
    public class ChartTests : BaseTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void GetChart()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart =
                TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, c_password, c_folderName) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void CreateChartAutoDataSource()
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
        public void CreateChartWorkbook()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new Chart
            {
                ChartType = Chart.ChartTypeEnum.ClusteredColumn,
                Width = 400,
                Height = 300,
                DataSourceForCategories = new Workbook()
                {
                    WorksheetIndex = 1,
                    ColumnIndex = 1,
                    RowIndex = 2
                },
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
                        DataSourceForSeriesName = new Workbook()
                        {
                            WorksheetIndex = 1,
                            ColumnIndex = 2,
                            RowIndex = 1
                        },
                        DataSourceForValues = new Workbook()
                        {
                            WorksheetIndex = 1,
                            ColumnIndex = 2,
                            RowIndex = 2
                        },
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
                        DataSourceForSeriesName = new Workbook()
                        {
                            WorksheetIndex = 1,
                            ColumnIndex = 3,
                            RowIndex = 1
                        },
                        DataSourceForValues = new Workbook()
                        {
                            WorksheetIndex = 1,
                            ColumnIndex = 3,
                            RowIndex = 2
                        },
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
        public void CreateChartLiterals()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new Chart
            {
                ChartType = Chart.ChartTypeEnum.ClusteredColumn,
                Width = 400,
                Height = 300,
                DataSourceForCategories = new Literals(),
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
                        DataSourceForSeriesName = new Literals(),
                        DataSourceForValues = new Literals(),
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
                        DataSourceForSeriesName = new Literals(),
                        DataSourceForValues = new Literals(),
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
        public void UpdateChart()
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
            Chart chart =
                TestUtils.SlidesApi.UpdateShape(c_fileName, c_slideIndex, c_shapeIndex, dto, c_password, c_folderName)
                    as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(2, chart.Series.Count);
            Assert.AreEqual(3, chart.Categories.Count);
        }

        [Test]
        public void CreateChartSeries()
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
            Chart chart = TestUtils.SlidesApi.CreateChartSeries(c_fileName, c_slideIndex, c_shapeIndex, series,
                c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount + 1, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void UpdateChartSeries()
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
        public void DeleteChartSeries()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart = TestUtils.SlidesApi.DeleteChartSeries(
                c_fileName, c_slideIndex, c_shapeIndex, c_seriesIndex, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount - 1, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
        }

        [Test]
        public void CreateChartCategory()
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
            Chart chart = TestUtils.SlidesApi.CreateChartCategory(c_fileName, c_slideIndex, c_shapeIndex, category,
                c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount + 1, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount + 1, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
            Assert.AreEqual(category.DataPoints[0].Value,
                ((OneValueSeries)chart.Series[0]).DataPoints[c_categoryCount].Value);
        }

        [Test]
        public void UpdateChartCategory()
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
            Assert.AreEqual(category.DataPoints[0].Value,
                ((OneValueSeries)chart.Series[0]).DataPoints[c_categoryIndex - 1].Value);
        }

        [Test]
        public void DeleteChartCategory()
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
        public void CreateChartDataPoint()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            DataPoint dataPoint = new OneValueChartDataPoint { Value = 40 };
            //Must throw ApiException because adding data points only works with Scatter & Bubble charts.
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.CreateChartDataPoint(
                c_fileName, c_slideIndex, c_shapeIndex, c_seriesIndex, dataPoint, c_password, c_folderName));
        }

        [Test]
        public void UpdateChartDataPoint()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            OneValueChartDataPoint dataPoint = new OneValueChartDataPoint { Value = 40 };
            Chart chart = TestUtils.SlidesApi.UpdateChartDataPoint(
                c_fileName, c_slideIndex, c_shapeIndex, c_seriesIndex, c_dataPointIndex, dataPoint, c_password,
                c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
            Assert.AreEqual(c_categoryCount, ((OneValueSeries)chart.Series[0]).DataPoints.Count);
            Assert.AreEqual(dataPoint.Value,
                ((OneValueSeries)chart.Series[c_seriesIndex - 1]).DataPoints[c_dataPointIndex - 1].Value);
        }

        [Test]
        public void DeleteChartDataPoint()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart = TestUtils.SlidesApi.DeleteChartDataPoint(
                c_fileName, c_slideIndex, c_shapeIndex, c_seriesIndex, c_dataPointIndex, c_password, c_folderName);
            Assert.IsNotNull(chart);
            Assert.AreEqual(c_seriesCount, chart.Series.Count);
            Assert.AreEqual(c_categoryCount, chart.Categories.Count);
            Assert.IsNull(((OneValueSeries)chart.Series[c_seriesIndex - 1]).DataPoints[c_dataPointIndex - 1]);
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

        [Test]
        public void MultiLevelChartCategory()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);

            ShapeBase dto = new Chart()
            {
                X = 100,
                Y = 100,
                Width = 500,
                Height = 400,
                ChartType = Chart.ChartTypeEnum.ClusteredColumn,
                Series = new List<Series>()
                {
                    new OneValueSeries()
                    {
                        Type = Series.TypeEnum.ClusteredColumn,
                        DataPoints = new List<OneValueChartDataPoint>()
                        {
                            new OneValueChartDataPoint() { Value = 1 },
                            new OneValueChartDataPoint() { Value = 2 },
                            new OneValueChartDataPoint() { Value = 3 },
                            new OneValueChartDataPoint() { Value = 4 },
                            new OneValueChartDataPoint() { Value = 5 },
                            new OneValueChartDataPoint() { Value = 6 },
                            new OneValueChartDataPoint() { Value = 7 },
                            new OneValueChartDataPoint() { Value = 8 }
                        }
                    }
                },

                Categories = new List<ChartCategory>()
                {
                    new ChartCategory
                        { Value = "Category1", ParentCategories = new List<string> { "Sub-category 1", "Root 1" } },
                    new ChartCategory { Value = "Category2" },
                    new ChartCategory { Value = "Category3", ParentCategories = new List<string> { "Sub-category 2" } },
                    new ChartCategory { Value = "Category4" },
                    new ChartCategory
                        { Value = "Category5", ParentCategories = new List<string> { "Sub-category 3", "Root 2" } },
                    new ChartCategory { Value = "Category6" },
                    new ChartCategory { Value = "Category7", ParentCategories = new List<string> { "Sub-category 4" } },
                    new ChartCategory { Value = "Category8" }
                }
            };
            Chart chart = TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, dto, password: c_password, folder: c_folderName) as Chart;

            Assert.AreEqual(Chart.ChartTypeEnum.ClusteredColumn, chart.ChartType);
            Assert.AreEqual(1, chart.Series.Count);
            Assert.AreEqual(8, chart.Categories.Count);
            Assert.AreEqual(2, chart.Categories[0].ParentCategories.Count);
        }

        [Test]
        public void HideChartLegend()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart =
                (Chart)TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, c_password, c_folderName);
            chart.Legend.HasLegend = false;

            chart = (Chart)TestUtils.SlidesApi.UpdateShape(c_fileName, c_slideIndex, c_shapeIndex, chart, c_password,
                c_folderName);
            Assert.IsTrue(chart.Legend.HasLegend.HasValue);
            Assert.IsFalse(chart.Legend.HasLegend.Value);
        }

        [Test]
        public void ChartAxisGridLinesFormat()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart =
                (Chart)TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, c_password, c_folderName);
            chart.Axes = new Axes
            {
                HorizontalAxis = new Axis
                {
                    MajorGridLinesFormat = new ChartLinesFormat()
                    {
                        LineFormat = new LineFormat()
                        {
                            FillFormat = new NoFill()
                        }
                    },
                    MinorGridLinesFormat = new ChartLinesFormat()
                    {
                        LineFormat = new LineFormat()
                        {
                            FillFormat = new SolidFill()
                            {
                                Color = "Black"
                            }
                        }
                    }
                },
                VerticalAxis = new Axis
                {
                    MajorGridLinesFormat = new ChartLinesFormat()
                    {
                        LineFormat = new LineFormat()
                        {
                            FillFormat = new GradientFill()
                            {
                                Direction = GradientFill.DirectionEnum.FromCorner1,
                                Stops = new List<GradientFillStop>()
                                {
                                    new GradientFillStop()
                                    {
                                        Color = "White",
                                        Position = 0
                                    },
                                    new GradientFillStop()
                                    {
                                        Color = "Black",
                                        Position = 1
                                    }
                                }
                            }
                        }
                    },
                    MinorGridLinesFormat = new ChartLinesFormat()
                    {
                        LineFormat = new LineFormat()
                        {
                            FillFormat = new NoFill()
                        }
                    }
                }
            };

            chart = (Chart)TestUtils.SlidesApi.UpdateShape(c_fileName, c_slideIndex, c_shapeIndex, chart, c_password,
                c_folderName);

            Assert.IsInstanceOf<NoFill>(chart.Axes.HorizontalAxis.MajorGridLinesFormat.LineFormat.FillFormat);
            Assert.IsInstanceOf<SolidFill>(chart.Axes.HorizontalAxis.MinorGridLinesFormat.LineFormat.FillFormat);
            Assert.IsInstanceOf<GradientFill>(chart.Axes.VerticalAxis.MajorGridLinesFormat.LineFormat.FillFormat);
            Assert.IsInstanceOf<NoFill>(chart.Axes.VerticalAxis.MinorGridLinesFormat.LineFormat.FillFormat);
        }

        [Test]
        public void ChartSeriesGroups()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Chart chart =
                (Chart)TestUtils.SlidesApi.GetShape(c_fileName, c_slideIndex, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(1, chart.SeriesGroups.Count);
            ChartSeriesGroup seriesGroup = chart.SeriesGroups[0];
            seriesGroup.Overlap = 10;
            chart = TestUtils.SlidesApi.SetChartSeriesGroup(c_fileName, c_slideIndex, c_shapeIndex,
                c_seriesGroupIndex, seriesGroup, c_password, c_folderName);
            Assert.AreEqual(10, chart.SeriesGroups[0].Overlap);
        }

        [Test]
        public void SetChartLegend()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Legend legendDto = new Legend();
            legendDto.Overlay = true;
            legendDto.FillFormat = new SolidFill()
            {
                Color = c_fillColor
            };

            Legend response = TestUtils.SlidesApi.SetChartLegend(c_fileName, c_slideIndex, c_shapeIndex, legendDto,
                c_password, c_folderName);

            Assert.True(response.Overlay.Value);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
        }

        [Test]
        public void SetChartAxis()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Axis axisDto = new Axis();
            axisDto.HasTitle = true;
            axisDto.IsAutomaticMaxValue = false;
            axisDto.MaxValue = 10;

            Axis response = TestUtils.SlidesApi.SetChartAxis(c_fileName, c_slideIndex, c_shapeIndex,
                AxisType.VerticalAxis, axisDto, c_password, c_folderName);
            Assert.True(response.HasTitle.Value);
            Assert.False(response.IsAutomaticMaxValue.Value);
            Assert.AreEqual(axisDto.MaxValue.Value, response.MaxValue.Value);
        }

        [Test]
        public void SetChartWall()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 8, shapeIndex = 2;
            ChartWall wallDto = new ChartWall();
            wallDto.FillFormat = new SolidFill() { Color = c_fillColor };
            ChartWall response = TestUtils.SlidesApi.SetChartWall(c_fileName, slideIndex, shapeIndex,
                ChartWallType.BackWall, wallDto, c_password, c_folderName);
            Assert.IsInstanceOf<SolidFill>(response.FillFormat);
        }
        
        [Test]
        public void UpdateChartDataPointFormat()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int slideIndex = 8, shapeIndex = 2;
            
            OneValueChartDataPoint dto = new OneValueChartDataPoint
            {
                Value = 40,
                FillFormat = new SolidFill(){ Color = c_fillColor },
                LineFormat = new LineFormat()
                {
                    FillFormat = new SolidFill() { Color = c_lineColor }
                },
                EffectFormat = new EffectFormat()
                {
                    Blur = new BlurEffect()
                    {
                        Grow = true,
                        Radius = 5
                    }
                }
            };
            
            Chart chart = TestUtils.SlidesApi.UpdateChartDataPoint(
                c_fileName, slideIndex, shapeIndex, c_seriesIndex, c_dataPointIndex, dto, c_password,
                c_folderName);
            OneValueChartDataPoint dataPoint = ((OneValueSeries)chart.Series[c_seriesIndex - 1]).DataPoints[c_dataPointIndex - 1];
            Assert.IsInstanceOf<SolidFill>(dataPoint.FillFormat);
            Assert.IsInstanceOf<SolidFill>(dataPoint.LineFormat.FillFormat);
            Assert.IsNotNull(dataPoint.EffectFormat.Blur);
        }
        
        [Test]
        public void ChartWorkbookFormulas()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            ShapeBase dto = new Chart
            {
                ChartType = Chart.ChartTypeEnum.ClusteredColumn,
                Width = 400,
                Height = 300,
                DataSourceForCategories = new Workbook()
                {
                    WorksheetIndex = 1,
                    ColumnIndex = 1,
                    RowIndex = 2
                },
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
                        DataSourceForValues = new Workbook()
                        {
                            WorksheetIndex = 1,
                            ColumnIndex = 2,
                            RowIndex = 2
                        },
                        DataPoints = new List<OneValueChartDataPoint>
                        {
                            new OneValueChartDataPoint { Value = 40 },
                            new OneValueChartDataPoint { Value = 50 },
                            new OneValueChartDataPoint
                            {
                                ValueFormula = "SUM(B2:B3)"
                            }
                        }
                    }
                }
            };
            Chart chart = TestUtils.SlidesApi.CreateShape(
                c_fileName, c_slideIndex, dto, password: c_password, folder: c_folderName) as Chart;
            Assert.IsNotNull(chart);
            Assert.AreEqual(90, (chart.Series[0] as OneValueSeries).DataPoints[2].Value);
        }

        const string c_fillColor = "#77CEF9";
        const string c_lineColor = "#E85052";
        const int c_slideIndex = 3;
        const int c_shapeIndex = 1;
        const int c_seriesIndex = 2;
        const int c_categoryIndex = 2;
        const int c_dataPointIndex = 2;
        const int c_seriesCount = 3;
        const int c_categoryCount = 4;
        const int c_seriesGroupIndex = 1;
    }
}