// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="InvalidPropertyTestExecutor.cs">
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
using NUnit.Framework;
using System;

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    internal class InvalidPropertyTestExecutor<TRequest, TResponse> : TestExecutor<TRequest, TResponse> where TRequest : class, new()
    {
        public InvalidPropertyTestExecutor(string methodName, string invalidPropertyName) : base(methodName, invalidPropertyName)
        {
            //TODO: check this condition more carefully. It may be not exact
            m_isCreate = methodName.StartsWith("Put");
            m_isSave = m_isCreate || methodName.StartsWith("Post");
            m_invalidPropertyName = invalidPropertyName;
        }

        protected override void Initialize()
        {
            //TODO: consider placing this to teardown
            TestUtils.DeleteFolder("TempSlidesSDKinvalidValue");
            Initializer.Initialize();
        }

        public override void AssertResult(TResponse response)
        {
            if (Initializer.OKToNotFail
                //if the property is just being created it is not invalid yet
                || m_invalidPropertyName.Equals("propertyName", StringComparison.InvariantCultureIgnoreCase) && m_isCreate)
            {
                return;
            }
            if (Is404())
            {
                Assert.IsNull(response);
            }
            else if (!m_invalidPropertyName.Equals("bounds", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("fontsFolder", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("outPath", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("height", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("width", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("jpegQuality", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("scaleX", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("scaleY", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("format", StringComparison.InvariantCultureIgnoreCase)
                //TODO: not actually OK to have an invalid value
                && !m_invalidPropertyName.Equals("shapeToClone", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("slideToClone", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("slideToCopy", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("oldValue", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("newValue", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("scaleType", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("sizeType", StringComparison.InvariantCultureIgnoreCase)
                //TODO: check nullable value
                && !m_invalidPropertyName.Equals("position", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("oldPosition", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("newPosition", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("source", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("destFolder", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("layoutAlias", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("options", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("from", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("to", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("stream", StringComparison.InvariantCultureIgnoreCase)
                && !m_invalidPropertyName.Equals("html", StringComparison.InvariantCultureIgnoreCase)
                && !Initializer.InvalidPropertyType.IsEnum
                && !(Initializer.InvalidPropertyType == typeof(bool?))
                && !(Initializer.InvalidPropertyType == typeof(NotesSlide)))
            {
                if (m_invalidPropertyName.Equals("slideIndex", StringComparison.InvariantCultureIgnoreCase)
                    || m_invalidPropertyName.Equals("storage", StringComparison.InvariantCultureIgnoreCase))
                {
                    //TODO: check the correct type & message of the thrown exception
                    Assert.Fail();
                }
                else
                {
                    Assert.Fail();
                }
            }
        }

        public override void AssertException(Exception exception)
        {
            if (Initializer.OKToFail)
            {
                return;
            }
            if (Is404())
            {
                if (m_isSave)
                {
                    return;
                }
                throw exception;
            }
            else if (Initializer.InvalidPropertyType == typeof(PresentationsMergeRequest))
            {
                //TODO: check the message
                return;
            }
            else if (m_invalidPropertyName.Equals("format", StringComparison.InvariantCultureIgnoreCase)
                && exception.Message.StartsWith("The request is invalid"))
            {
                //TODO: check the message
                return;
            }
            else if (m_invalidPropertyName.Equals("index", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    Assert.IsTrue(ex.Message.StartsWith("Specified argument was out of the range of valid values."));
                    return;
                }
            }
            else if (m_invalidPropertyName.Equals("slideIndex", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("slides", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("cloneFromPosition", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    Assert.IsTrue(ex.Message.StartsWith("Wrong slide index.")
                        || ex.Message.StartsWith("Invalid index:")
                        || ex.Message.StartsWith("Placeholder with specified index doesn't exist"));
                    return;
                }
            }
            else if (m_invalidPropertyName.Equals("shapeIndex", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("shapes", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    Assert.IsTrue(ex.Message.StartsWith("Wrong shape index."));
                    return;
                }
            }
            else if (m_invalidPropertyName.Equals("paragraphIndex", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("paragraphs", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    Assert.IsTrue(ex.Message.StartsWith("Wrong paragraph index.") || ex.Message.StartsWith("Paragraph index out of bounds"));
                    return;
                }
            }
            else if (m_invalidPropertyName.Equals("portionIndex", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("portions", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    Assert.IsTrue(ex.Message.StartsWith("Wrong portion index.") || ex.Message.StartsWith("Portion index out of bounds"));
                    return;
                }
            }
            else if (m_invalidPropertyName.Equals("placeholderIndex", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    Assert.IsTrue(ex.Message.StartsWith("Placeholder with specified index doesn't exist."));
                    return;
                }
            }
            else if (m_invalidPropertyName.Equals("storage", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("cloneFromStorage", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    //TODO: investigate why the messages differ
                    Assert.IsTrue(ex.Message.StartsWith("The specified storage was not found or is not associated with the application.")
                        || ex.Message.StartsWith("Object reference not set to an instance of an object."));
                    return;
                }
            }
            else if (m_invalidPropertyName.Equals("shapePath", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("path", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    //TODO: only the first message is actually expected
                    Assert.IsTrue(ex.Message.StartsWith("Unexpected Shapes subnode")
                        || ex.Message.StartsWith("An error has occurred")
                        || ex.Message.StartsWith("Shape index out of bounds"));
                    return;
                }
            }
            else if (m_invalidPropertyName.Equals("color", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    Assert.IsTrue(ex.Message.StartsWith("Color must be in format #FF000000"));
                    return;
                }
            }
            else if (m_invalidPropertyName.EndsWith("password", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException ex)
                {
                    if (Initializer is UnprotectedFileTestInitializer)
                    {
                        Assert.IsTrue(ex.Message.StartsWith("An attempt was made to move the position before the beginning of the stream."));
                        return;
                    }
                    //TODO: only the first message is actually expected
                    Assert.IsTrue(ex.Message.StartsWith("Invalid password")
                        || ex.Message.StartsWith("Object reference not set to an instance of an object."));
                    return;
                }
            }
            else if (m_invalidPropertyName.Equals("data", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.EndsWith("properties", StringComparison.InvariantCultureIgnoreCase)
                //TODO: 404 exception is expected here
                || m_invalidPropertyName.EndsWith("templatePath", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.EndsWith("templateStorage", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("pipeline", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("request", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("document", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("paragraph", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("portion", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("property", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("height", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("width", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.EndsWith("Dto", StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    throw exception;
                }
                catch (ApiException)
                {
                    //TODO: check message
                    return;
                }
            }
            else
            {
                throw exception;
            }
        }

        private bool Is404()
        {
            return m_invalidPropertyName.Equals("folder", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("cloneFrom", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("propertyName", StringComparison.InvariantCultureIgnoreCase)
                || m_invalidPropertyName.Equals("name", StringComparison.InvariantCultureIgnoreCase);
        }

        private readonly bool m_isSave;
        private readonly bool m_isCreate;
        private readonly string m_invalidPropertyName;
    }
}
