// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutSlidesDocumentFromHtmlTestInitializer.cs">
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
    [Method("PutSlidesDocumentFromHtml")]
    internal class PutSlidesDocumentFromHtmlTestInitializer : TestInitializer
    {
        public override bool OKToNotFail { get { return m_okToNotFail; } }

        public PutSlidesDocumentFromHtmlTestInitializer(string invalidPropertyName) : base(invalidPropertyName)
        {
            //TODO: a temporary solution to work around the bug with GetSlidesDocument password. Remove after fix
            m_okToNotFail = invalidPropertyName == null
                || invalidPropertyName.Equals("folder", System.StringComparison.InvariantCultureIgnoreCase);
                //|| invalidPropertyName.Equals("password", System.StringComparison.InvariantCultureIgnoreCase);
        }

        private readonly bool m_okToNotFail;
    }
}
