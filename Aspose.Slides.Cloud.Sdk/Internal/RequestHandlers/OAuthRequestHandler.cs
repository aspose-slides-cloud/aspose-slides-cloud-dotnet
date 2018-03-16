// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OAuthRequestHandler.cs">
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
    using System.Collections.Generic;
    using System.IO;
    using System.Net;    
    
    using Newtonsoft.Json;

    internal class OAuthRequestHandler : IRequestHandler
    {        
        public OAuthRequestHandler(Configuration configuration)
        {
            m_configuration = configuration;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new DebugLogRequestHandler(m_configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            m_apiInvoker = new StringToObjectApiInvoker<GetAccessTokenResult>(requestHandlers);
        }

        public string ProcessUrl(string url)
        {
            if (m_configuration.AuthType == AuthType.OAuth2 && string.IsNullOrEmpty(m_accessToken))
            {
                RequestToken();
            }
            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {            
            if (m_configuration.AuthType == AuthType.OAuth2)
            {
                request.Headers["Authorization"] = "Bearer " + m_accessToken;
            }
        }       

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (m_configuration.AuthType == AuthType.OAuth2 && response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshToken();
                throw new NeedRepeatRequestException();
            }
        }

        private void RefreshToken()
        {
            DoTokenRequest("grant_type=refresh_token&refresh_token=" + m_refreshToken);
        }

        private void RequestToken()
        {
            string postData = "grant_type=client_credentials&client_id="
                + m_configuration.AppSid
                + "&client_secret="
                + m_configuration.AppKey;
            DoTokenRequest(postData);
        }

        private void DoTokenRequest(string postData)
        {
            string requestUrl = m_configuration.ApiBaseUrl + "/oauth2/token";
            GetAccessTokenResult result = m_apiInvoker.InvokeApi(
                requestUrl, "POST", postData, null, null, "application/x-www-form-urlencoded");
            m_accessToken = result.AccessToken;
            m_refreshToken = result.RefreshToken;
        }

        private class GetAccessTokenResult
        {
            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }

            [JsonProperty(PropertyName = "refresh_token")]
            public string RefreshToken { get; set; }
        }

        private readonly Configuration m_configuration;
        private readonly StringToObjectApiInvoker<GetAccessTokenResult> m_apiInvoker;

        private string m_accessToken;
        private string m_refreshToken;
    }
}