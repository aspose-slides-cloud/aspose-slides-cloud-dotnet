// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ThemeApi.cs">
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
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk.RequestHandlers;

namespace Aspose.Slides.Cloud.Sdk
{
    /// <summary>
    /// Aspose.Slides for Cloud API.
    /// </summary>
    public class ThemeApi : ApiBase
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeApi"/> class.
        /// </summary>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        public ThemeApi(string appSid, string appKey) : base(appSid, appKey)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ThemeApi(Configuration configuration) : base(configuration)
        {
        }

        /// <summary>
        /// Read slide theme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeRequest" /></param> 
        /// <returns><see cref="ThemeResponse"/></returns>            
        public ThemeResponse GetSlidesTheme(GetSlidesThemeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesTheme");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ThemeResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide theme color scheme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeColorSchemeRequest" /></param> 
        /// <returns><see cref="ColorSchemeResponse"/></returns>            
        public ColorSchemeResponse GetSlidesThemeColorScheme(GetSlidesThemeColorSchemeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesThemeColorScheme");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme/colorScheme");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<ColorSchemeResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide theme font scheme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeFontSchemeRequest" /></param> 
        /// <returns><see cref="FontSchemeResponse"/></returns>            
        public FontSchemeResponse GetSlidesThemeFontScheme(GetSlidesThemeFontSchemeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesThemeFontScheme");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme/fontScheme");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<FontSchemeResponse>(resourcePath, "GET", null, null, files, contentType);
        }

        /// <summary>
        /// Read slide theme color scheme info. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSlidesThemeFormatSchemeRequest" /></param> 
        /// <returns><see cref="FormatSchemeResponse"/></returns>            
        public FormatSchemeResponse GetSlidesThemeFormatScheme(GetSlidesThemeFormatSchemeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSlidesThemeFormatScheme");
            }

            // create path and map variables
            string resourcePath = GetResourceUrl("/slides/{name}/slides/{slideIndex}/theme/formatScheme");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "slideIndex", request.SlideIndex);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            string contentType = "application/json";
            var files = new List<FileInfo>();
            PickFiles(files, request);
            return InvokeApi<FormatSchemeResponse>(resourcePath, "GET", null, null, files, contentType);
        }
    }
}