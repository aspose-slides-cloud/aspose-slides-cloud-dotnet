// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutNewPresentationTestInitializer.cs">
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

using System.IO;

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    [Method("PutNewPresentation")]
    internal class PutNewPresentationTestInitializer : TestInitializer
    {
        public override bool OKToNotFail { get { return m_okToNotFail; } }

        public PutNewPresentationTestInitializer(string invalidPropertyName) : base(invalidPropertyName)
        {
            m_okToNotFail = invalidPropertyName == null
                || invalidPropertyName.Equals("folder", System.StringComparison.InvariantCultureIgnoreCase)
                || invalidPropertyName.Equals("password", System.StringComparison.InvariantCultureIgnoreCase);
        }

        public override void Initialize()
        {
            TestUtils.Upload(base.GetName(), GetPath(Folder, base.GetName()));
            TestUtils.DeleteFile(GetPath(Folder, GetName()));
            TestUtils.DeleteFile(GetPath(Folder + "invalidValue", GetName()));
        }

        protected override string GetName()
        {
            return "changed" + base.GetName();
        }

        protected override Stream GetStream()
        {
            return File.OpenRead(Path.Combine(TestUtils.TestDataPath, Name));
        }

        private readonly bool m_okToNotFail;
    }
}
