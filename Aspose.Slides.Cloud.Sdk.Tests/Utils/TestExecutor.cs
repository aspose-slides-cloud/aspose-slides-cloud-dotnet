// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestExecutor.cs">
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
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    internal class TestExecutor<TResponse> : VoidTestExecutor
    {
        public TestExecutor(string methodName, string invalidPropertyName) : base(methodName, invalidPropertyName)
        {
        }

        public void AssertResult(TResponse response)
        {
            if (InvalidPropertyName == null)
            {
                foreach (OKToReturnNullRule rule in EnumerateRules(Rules.OKToReturnNull, InvalidPropertyName))
                {
                    return;
                }
                Assert.IsNotNull(response);
                Stream stream = response as Stream;
                if (stream != null)
                {
                    Assert.IsTrue(stream.CanRead);
                    Assert.IsTrue(stream.CanSeek);
                    Assert.AreEqual(0, stream.Position);
                }
            }
            else
            {
                foreach (OKToNotFailRule rule in EnumerateRules(Rules.OKToNotFail, InvalidPropertyName))
                {
                    return;
                }
                if (ExpectedCode == 404)
                {
                    Assert.IsNull(response);
                }
                else
                {
                    Assert.Fail("Must have failed");
                }
            }
        }
    }
}
