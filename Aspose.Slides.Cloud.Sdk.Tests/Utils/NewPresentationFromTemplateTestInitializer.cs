// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NewPresentationFromTemplateTestInitializer.cs">
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
    [Method("PostSlidesDocument")]
    [Method("PutNewPresentationFromStoredTemplate")]
    internal class NewPresentationFromTemplateTestInitializer : TestInitializer
    {
        public NewPresentationFromTemplateTestInitializer(string invalidPropertyName) : base(invalidPropertyName)
        {
            m_propertyName = invalidPropertyName;
        }

        public override void Initialize()
        {
            TestUtils.DeleteFile(GetName());
            TestUtils.DeleteFile(GetPath(Folder, GetName()));
            TestUtils.DeleteFile(GetPath(Folder + "invalidValue", GetName()));
            TestUtils.Upload(base.GetName(), GetPath(base.GetFolder(), base.GetName()));
        }

        protected override string GetName()
        {
            return "changed3" + Name;
        }

        protected override string GetFolder()
        {
            return null;
        }

        //TODO: a workaround for SLIDESCLOUD-365 bug. Remove this overriding after fix
        public override bool OKToFail { get { return m_propertyName == null || m_propertyName == "IsImageDataEmbeeded" || m_propertyName == "Password"; } }

        private string m_propertyName;
    }
}
