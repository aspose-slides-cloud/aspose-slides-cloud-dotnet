// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AuthTests.cs">
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

using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Timeout config parameter
    /// </summary>
    [TestFixture]
    public class AuthTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void GoodCredentials()
        {
            new SlidesApi(TestUtils.Configuration).GetApiInfo();
        }

        [Test]
        public void BadCredentials()
        {
            Configuration config = TestUtils.GetConfiguration();
            config.AppSid = "invalid";
            try
            {
                new SlidesApi(config).GetApiInfo();
                Assert.Fail("Must have failed");
            }
            catch (ApiException ex)
            {
                Assert.AreEqual(401, ex.ErrorCode);
            }
        }

        [Test]
        public void GoodAuthToken()
        {
            Configuration config = TestUtils.GetConfiguration();
            new SlidesApi(config).GetApiInfo();
            config.AppSid = "invalid";
            new SlidesApi(config).GetApiInfo();
        }

        [Test]
        public void BadAuthToken()
        {
            Configuration config = TestUtils.GetConfiguration();
            config.AuthToken = "invalid";
            new SlidesApi(config).GetApiInfo();
        }
    }
}
