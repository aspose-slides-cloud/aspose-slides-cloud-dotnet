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

using System.Collections.Generic;
using System.IO;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing comments methods
    /// </summary>
    [TestFixture]
    public class CommentTest : BaseTests
    {
        [Test]
        public void CreateComment()
        {
            SlideComment dto = new SlideComment()
            {
                Text = c_commentText,
                Author = c_author,
                ChildComments = new List<SlideCommentBase>()
                {
                    new SlideComment()
                    {
                        Text = c_childCommentText,
                        Author = c_author
                    }
                }
            };
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideComments response = TestUtils.SlidesApi.CreateComment(c_fileName, 3, dto, null, c_password, c_folderName);
            
            Assert.AreEqual(1, response.List.Count);
            Assert.AreEqual(c_commentText, response.List[0].Text);
            Assert.AreEqual(c_author, response.List[0].Author);
            Assert.AreEqual(c_childCommentText, response.List[0].ChildComments[0].Text);
            Assert.AreEqual(c_author, response.List[0].ChildComments[0].Author);
        }
        
        [Test]
        public void CreateCommentOnline()
        {
            SlideComment dto = new SlideComment()
            {
                Text = c_commentText,
                Author = c_author,
                ChildComments = new List<SlideCommentBase>()
                {
                    new SlideComment()
                    {
                        Text = c_childCommentText,
                        Author = c_author
                    }
                }
            };
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream outputDocument = TestUtils.SlidesApi.CreateCommentOnline(document, 3, dto, null, c_password);
            Assert.AreNotEqual(document.Length, outputDocument.Length);
        }
        
        [Test]
        public void GetSlideComments()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideComments response = TestUtils.SlidesApi.GetSlideComments(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.AreEqual(2, response.List.Count);
            Assert.AreEqual(1, response.List[0].ChildComments.Count);
        }
        
        [Test]
        public void DeleteComments()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.DeleteComments(c_fileName, null, c_password, c_folderName);
            SlideComments response = TestUtils.SlidesApi.GetSlideComments(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.AreEqual(0, response.List.Count);
        }
        
        [Test]
        public void DeleteCommentsOnline()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream outputDocument = TestUtils.SlidesApi.DeleteCommentsOnline(document, null, c_password);
            Assert.AreNotEqual(document.Length, outputDocument.Length);
        }
        
        [Test]
        public void DeleteSlideComments()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            TestUtils.SlidesApi.DeleteSlideComments(c_fileName, c_slideIndex, null, c_password, c_folderName);
            SlideComments response = TestUtils.SlidesApi.GetSlideComments(c_fileName, c_slideIndex, c_password, c_folderName);
            Assert.AreEqual(0, response.List.Count);
        }
        
        [Test]
        public void DeleteSlideCommentsOnline()
        {
            Stream document = File.OpenRead(Path.Combine(TestUtils.TestDataPath, c_fileName));
            Stream outputDocument = TestUtils.SlidesApi.DeleteSlideCommentsOnline(document, c_slideIndex, null, c_password);
            Assert.AreNotEqual(document.Length, outputDocument.Length);
        }
        
        [Test]
        public void CreateModernComment()
        {
            int textSelectionStartIndex = 1;
            int textSelectionLength = 5;
            
            SlideModernComment childComment = new SlideModernComment()
            {
                Author = c_author,
                Text = c_childCommentText,
                Status = SlideModernComment.StatusEnum.Resolved
            };
            SlideModernComment comment = new SlideModernComment
            {
                Author = c_author,
                Text = c_commentText,
                Status  = SlideModernComment.StatusEnum.Active,
                TextSelectionStart = textSelectionStartIndex,
                TextSelectionLength = textSelectionLength,
                ChildComments = new List<SlideCommentBase>(){childComment}
            };
            
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideComments response = TestUtils.SlidesApi.CreateComment(c_fileName, 3, comment, null, c_password, c_folderName);
            Assert.AreEqual(1, response.List.Count);
            Assert.IsInstanceOf(typeof(SlideModernComment), response.List[0]);
        }
        
        [Test]
        public void CreateShapeModernComment()
        {
            int textSelectionStartIndex = 1;
            int textSelectionLength = 5;
            
            SlideModernComment childComment = new SlideModernComment()
            {
                Author = c_author,
                Text = c_childCommentText,
                Status = SlideModernComment.StatusEnum.Resolved
            };
            SlideModernComment comment = new SlideModernComment
            {
                Author = c_author,
                Text = c_commentText,
                Status  = SlideModernComment.StatusEnum.Active,
                TextSelectionStart = textSelectionStartIndex,
                TextSelectionLength = textSelectionLength,
                ChildComments = new List<SlideCommentBase>(){childComment}
            };
            
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideComments response = TestUtils.SlidesApi.CreateComment(c_fileName, 3, comment, c_shapeIndex, c_password, c_folderName);
            Assert.AreEqual(1, response.List.Count);
            Assert.IsInstanceOf(typeof(SlideModernComment), response.List[0]);
        }
        
        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const string c_author = "Test author";
        const string c_childCommentText = "Child comment text";
        const string c_commentText = "Comment text";  
        const int c_slideIndex = 1;
        const int c_shapeIndex = 1;
    }
}