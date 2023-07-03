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
    public class TableTests : BaseTests
    {
        [Test]
        public void UpdateTableCell()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 2;
            int cellIndex = 1;
            TableCell dto = new TableCell(){Text = "Test text"};
            TableCell response = TestUtils.SlidesApi.UpdateTableCell(c_fileName, c_slideIndex, c_shapeIndex, rowIndex,
                cellIndex, dto, c_password, c_folderName);
            Assert.AreEqual(response.Text, dto.Text);
        }
        
        [Test]
        public void CreateTableRow()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TableRow dto = new TableRow()
            {
                MinimalHeight = 30,
                Cells = new List<TableCell>()
                {
                    new TableCell {Text = "Cell 1"},
                    new TableCell {Text = "Cell 2"},
                    new TableCell {Text = "Cell 3"},
                    new TableCell {Text = "Cell 4"}
                }
            };
            TableRow response = TestUtils.SlidesApi.CreateTableRow(c_fileName, c_slideIndex, c_shapeIndex, dto, null,
                c_password, c_folderName);
            Assert.AreEqual(response.Cells.Count, dto.Cells.Count);
            Assert.AreEqual(response.MinimalHeight, dto.MinimalHeight);
        }
        
        [Test]
        public void DeleteTableRow()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 2;
            bool withAttachedRows = true;
            Table response = TestUtils.SlidesApi.DeleteTableRow(c_fileName, c_slideIndex, c_shapeIndex, rowIndex,
                withAttachedRows, c_password, c_folderName);
            Assert.AreEqual(2, response.Rows.Count);
        }
        
        [Test]
        public void UpdateTableRow()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            TableRow dto = new TableRow()
            {
                MinimalHeight = 30
            };
            TableRow response = TestUtils.SlidesApi.UpdateTableRow(c_fileName, c_slideIndex, c_shapeIndex, rowIndex, dto,
                c_password, c_folderName);
            Assert.AreEqual(response.MinimalHeight, dto.MinimalHeight);
        }
        
        [Test]
        public void MergeTableCells()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            var dto = new TableCellMergeOptions()
            {
                FirstRowIndex = 1,
                FirstCellIndex = 1,
                LastRowIndex = 2,
                LastCellIndex = 2,
                AllowSplitting = true
            };
            Table response = TestUtils.SlidesApi.MergeTableCells(c_fileName, c_slideIndex, c_shapeIndex, dto,
                c_password, c_folderName);
                
            Assert.AreEqual(2, response.Rows[0].Cells[0].ColSpan);
            Assert.AreEqual(2, response.Rows[0].Cells[0].RowSpan);
        }
        
        [Test]
        public void SplitTableCellByWidth()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int cellWidth = 10;
            Table response = TestUtils.SlidesApi.SplitTableCell(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, TableCellSplitType.SplitByWidth, cellWidth, c_password, c_folderName);
                
            Assert.AreEqual(5, response.Rows[0].Cells.Count);
        }
        
        [Test]
        public void SplitTableCellByHeight()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int cellHeight = 10;
            Table response = TestUtils.SlidesApi.SplitTableCell(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, TableCellSplitType.SplitByHeight, cellHeight, c_password, c_folderName);
            Assert.AreEqual(5, response.Rows.Count);
        }
        
        [Test]
        public void SplitTableCellByColSpan()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 3;
            int cellIndex = 1;
            int colSpan = 1;
            Table response = TestUtils.SlidesApi.SplitTableCell(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, TableCellSplitType.SplitByColSpan, colSpan, c_password, c_folderName);
                
            Assert.AreEqual(null, response.Rows[2].Cells[0].ColSpan);
        }
        
        [Test]
        public void SplitTableCellByRowSpan()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 2;
            int cellIndex = 3;
            int colSpan = 1;
            Table response = TestUtils.SlidesApi.SplitTableCell(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, TableCellSplitType.SplitByRowSpan, colSpan, c_password, c_folderName);
                
            Assert.AreEqual(null, response.Rows[1].Cells[2].RowSpan);
        }
        
        [Test]
        public void GetTableCellParagraphs()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            Paragraphs response = TestUtils.SlidesApi.GetTableCellParagraphs(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, c_password, c_folderName);
                
            Assert.AreEqual(1, response.ParagraphLinks.Count);
        }
        
        [Test]
        public void GetTableCellParagraph()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int paragraphIndex = 1;
            Paragraph response = TestUtils.SlidesApi.GetTableCellParagraph(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, paragraphIndex, c_password, c_folderName);
                
            Assert.AreEqual(2, response.PortionList.Count);
        }
        
        [Test]
        public void CreateTableCellParagraph()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            Paragraph dto = new Paragraph()
            {
                PortionList = new List<Portion>()
                {
                    new Portion {Text = "Portion 1"},
                    new Portion {Text = "Portion 2"},
                }
            };
            
            Paragraph response = TestUtils.SlidesApi.CreateTableCellParagraph(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, dto, c_password, c_folderName);
                
            Assert.AreEqual(2, response.PortionList.Count);
        }
        
        [Test]
        public void UpdateTableCellParagraph()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int paragraphIndex = 1;
            Paragraph dto = new Paragraph()
            {
                PortionList = new List<Portion>()
                {
                    new Portion {Text = "Portion 1"},
                    new Portion {Text = "Portion 2"},
                }
            };
            
            Paragraph response = TestUtils.SlidesApi.UpdateTableCellParagraph(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, paragraphIndex, dto, c_password, c_folderName);
                
            Assert.AreEqual(2, response.PortionList.Count);
        }
        
        [Test]
        public void DeleteTableCellParagraph()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int paragraphIndex = 1;
            Paragraphs response = TestUtils.SlidesApi.DeleteTableCellParagraph(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, paragraphIndex, c_password, c_folderName);
                
            Assert.AreEqual(0, response.ParagraphLinks.Count);
        }
        
        [Test]
        public void GetTableCellPortions()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int paragraphIndex = 1;
            Portions response = TestUtils.SlidesApi.GetTableCellPortions(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, paragraphIndex, c_password, c_folderName);
                
            Assert.AreEqual(2, response.Items.Count);
        }
        
        [Test]
        public void GetTableCellPortion()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int paragraphIndex = 1;
            int portionIndex = 1;
            Portion response = TestUtils.SlidesApi.GetTableCellPortion(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, paragraphIndex, portionIndex, c_password, c_folderName);
                
            Assert.AreEqual("Header", response.Text);
        }
        
        [Test]
        public void CreateTableCellPortion()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int paragraphIndex = 1;
            Portion dto = new Portion(){Text = "Portion 1"};
            Portion response = TestUtils.SlidesApi.CreateTableCellPortion(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, paragraphIndex, dto, c_password, c_folderName);
                
            Assert.AreEqual(dto.Text, response.Text);
        }
        
        [Test]
        public void UpdateTableCellPortion()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int paragraphIndex = 1;
            int portionIndex = 1;
            Portion dto = new Portion(){Text = "Portion 1"};
            Portion response = TestUtils.SlidesApi.UpdateTableCellPortion(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, paragraphIndex, portionIndex, dto, c_password, c_folderName);
                
            Assert.AreEqual(dto.Text, response.Text);
        }
        
        [Test]
        public void DeleteTableCellPortion()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            int rowIndex = 1;
            int cellIndex = 1;
            int paragraphIndex = 1;
            int portionIndex = 1;
            Portions response = TestUtils.SlidesApi.DeleteTableCellPortion(c_fileName, 
                c_slideIndex, c_shapeIndex, rowIndex, cellIndex, paragraphIndex, portionIndex, c_password, c_folderName);
                
            Assert.AreEqual(1, response.Items.Count);
        }
        
        private const int c_slideIndex = 9;
        private const int c_shapeIndex = 1;
    }
}