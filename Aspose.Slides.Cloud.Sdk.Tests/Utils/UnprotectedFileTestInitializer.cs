// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutSlidesConvertTestInitializer.cs">
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

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    //A workaround for SLIDESCLOUD-470 issue. The class should be removed after the bug is fixed.
    [Method("PutSlidesSlide")]
    [Method("DeleteSlidesCleanSlidesList")]
    [Method("PostSlidesReorderPosition")]
    internal class UnprotectedFileTestInitializer : TestInitializer
    {
        public UnprotectedFileTestInitializer(string invalidPropertyName) : base(invalidPropertyName)
        {
        }

        protected override string GetName()
        {
            return "test-unprotected.ppt";
        }

        protected override string GetPassword()
        {
            return null;
        }
    }
}
