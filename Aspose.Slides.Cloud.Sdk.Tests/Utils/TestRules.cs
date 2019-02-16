// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestInitializer.cs">
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
    internal class TestRules
    {
        public FileRule[] Files { get; set; }
        public ValueRule[] Values { get; set; }
        public OKToNotFailRule[] OKToNotFail { get; set; }
        public ResultRule[] Results { get; set; }
    }

    internal abstract class TestRule
    {
        public string Method { get; set; }
        public string Parameter { get; set; }
        public string Language { get; set; }
        public bool? Invalid { get; set; }
    }

    internal enum FileAction { Put, Delete }

    internal class FileRule : TestRule
    {
        public FileAction Action { get; set; }
        public string File { get; set; }
        public string ActualName { get; set; }
        public string Folder { get; set; }
        public string Path { get; set; }
    }

    internal class ValueRule : TestRule
    {
        private object m_value;
        public bool IsValueSet { get; private set; }
        public object Value
        {
            get { return m_value; }
            set
            {
                IsValueSet = true;
                m_value = value;
            }
        }

        private object m_invalidValue;
        public bool IsInvalidValueSet { get; private set; }
        public object InvalidValue
        {
            get { return m_invalidValue; }
            set
            {
                IsInvalidValueSet = true;
                m_invalidValue = value;
            }
        }

        public string Type { get; set; }
    }

    internal class OKToNotFailRule : TestRule
    {
    }

    internal class ResultRule : TestRule
    {
        public int? Code { get; set; }
        public string Message { get; set; }
    }
}
