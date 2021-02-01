// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UrlHelper.cs">
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

using System.Collections;
using System.Collections.Generic;

#if NETFRAMEWORK
using System;
using System.Web;
using System.Collections.Specialized;
#endif

namespace Aspose.Slides.Cloud.Sdk
{
    internal class UrlHelper
    {
        public static string AddPathParameter(string url, string parameterName, object parameterValue)
        {
            if (parameterValue == null || string.IsNullOrEmpty(parameterValue.ToString()))
            {
                return url.Replace("/{" + parameterName + "}", string.Empty);
            }
            return url.Replace("{" + parameterName + "}", parameterValue.ToString());
        }        

        public static string AddQueryParameterToUrl(string url, string parameterName, object parameterValue)
        {
            if (url.Contains("{" + parameterName + "}"))
            {               
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }

            if (url.Contains("%7B" + parameterName + "%7D"))
            {
                url = url.Replace("%7B", "{").Replace("%7D", "}");
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }
           
            if (parameterValue == null)
            {
                return url;
            }

#if NETFRAMEWORK
            UriBuilder uriBuilder = new UriBuilder(url);
            NameValueCollection query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query.Add(parameterName, GetValue(parameterValue));
            uriBuilder.Query = query.ToString();
            return uriBuilder.ToString();
#else
            return Microsoft.AspNetCore.WebUtilities.QueryHelpers.AddQueryString(url, parameterName, GetValue(parameterValue));
#endif
        }
        public static void AddHeaderParameter(Dictionary<string, string> parameters, string parameterName, object parameterValue)
        {
            if (parameterValue != null && !string.IsNullOrEmpty(parameterValue.ToString()))
            {
                parameters.Add(parameterName, parameterValue.ToString());
            }
        }

        public static string GetValue(object value)
        {
            string stringValue = value as string;
            if (stringValue != null)
            {
                return stringValue;
            }
            IEnumerable values = value as IEnumerable;
            if (values != null)
            {
                string result = string.Empty;
                string separator = string.Empty;
                foreach (object item in values)
                {
                    result += separator + item;
                    separator = ",";
                }
                return result;
            }
            return value.ToString();
        }
    }
}