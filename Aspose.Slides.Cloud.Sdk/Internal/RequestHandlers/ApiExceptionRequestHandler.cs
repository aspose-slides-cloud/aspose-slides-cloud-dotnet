// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiExceptionRequestHandler.cs">
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

namespace Aspose.Slides.Cloud.Sdk.RequestHandlers
{
    using System;
    using System.IO;
    using System.Net;

    internal class ApiExceptionRequestHandler : IRequestHandler
    {
        public void BeforeSend(WebRequest request, Stream streamToSend)
        {            
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (response.StatusCode >= HttpStatusCode.Ambiguous)
            {
                try
                {
                    resultStream.Position = 0;
                    ExceptionInfo exception = (ExceptionInfo)SerializationHelper.Deserialize(resultStream, response.ContentType, typeof(ExceptionInfo));
                    string message = exception.Message == null && exception.Error != null ? exception.Error.Message : exception.Message;
                    throw new ApiException((int)response.StatusCode, message);
                }
                catch (ApiException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw new ApiException((int)response.StatusCode, response.StatusDescription);
                }
            }
        }
    }
}
