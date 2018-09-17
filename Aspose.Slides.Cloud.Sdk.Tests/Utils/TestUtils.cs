// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestUtils.cs">
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

using Com.Aspose.Storage.Api;
using System;
using System.Configuration;
using System.IO;

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    internal static class TestUtils
    {
        public static Configuration Configuration
        {
            get
            {

                return s_configuration
                    ?? (s_configuration = new Configuration
                    {
                        DebugMode = GetBoolConfigValue("DebugMode", true),
                        ApiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"] ?? "http://api-dev.aspose.cloud",
                        AuthType = GetEnumConfigValue("AuthType", AuthType.RequestSignature),
                        AppSid = ConfigurationManager.AppSettings["AppSid"],
                        AppKey = ConfigurationManager.AppSettings["AppKey"]
                    });
            }
        }

        public static void Upload(string localPath, string storagePath)
        {
            Stream file = File.OpenRead(Path.Combine(TestDataPath, localPath));
            byte[] fileBytes = new byte[file.Length];
            file.Read(fileBytes, 0, (int)file.Length);
            s_storageApi.PutCreate(storagePath, null, null, fileBytes);
        }

        public static void DeleteFolder(string path)
        {
            s_storageApi.DeleteFolder(path, null, true);
        }

        public static void DeleteFile(string storagePath)
        {
            s_storageApi.DeleteFile(storagePath, null, null);
        }

        public static FileInfo GetLocalFile(string path, string mimeType)
        {
            return new FileInfo
            {
                Name = Path.GetFileName(path), MimeType = mimeType, Content = File.OpenRead(Path.Combine(TestDataPath, path))
            };
        }

        internal const string TestDataPath = "../../../../TestData";

        private static Configuration s_configuration;
        private static TimeSpan m_timeout = new TimeSpan(0, 1, 0);
        private static StorageApi s_storageApi = new StorageApi(
            Configuration.AppKey, Configuration.AppSid, Configuration.ApiBaseUrl + "/v1.1");

        private static bool GetBoolConfigValue(string key, bool defaultValue)
        {
            bool result;
            return bool.TryParse(ConfigurationManager.AppSettings[key], out result) ? result : defaultValue;
        }

        private static T GetEnumConfigValue<T>(string key, T defaultValue) where T : struct, IConvertible
        {
            T result;
            return Enum.TryParse(ConfigurationManager.AppSettings[key], out result) ? result : defaultValue;
        }
    }
}
