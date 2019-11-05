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

using Aspose.Slides.Cloud.Sdk.Model.Requests;
using System;
using System.Configuration;
using System.IO;
using System.Text;

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    internal static class TestUtils
    {
        public static SlidesApi SlidesApi { get { return s_slidesApi ?? (s_slidesApi = new SlidesApi(Configuration)); } }

        public static Configuration Configuration
        {
            get
            {

                return s_configuration
                    ?? (s_configuration = new Configuration
                    {
                        DebugMode = GetBoolConfigValue("DebugMode", true),
                        ApiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"] ?? "https://api-qa.aspose.cloud",
                        AuthBaseUrl = ConfigurationManager.AppSettings["AuthBaseUrl"]
                            ?? ConfigurationManager.AppSettings["ApiBaseUrl"]
                            ?? "https://api-qa.aspose.cloud",
                        AppSid = ConfigurationManager.AppSettings["AppSid"],
                        AppKey = ConfigurationManager.AppSettings["AppKey"]
                    });
            }
        }

        public static void Init()
        {
            if (!s_initialized)
            {
                if (!IsTestDataUpToDate())
                {
                    foreach (string file in Directory.EnumerateFiles(TestDataPath))
                    {
                        string filePath = $"{c_tempTestFolder}/{Path.GetFileName(file)}";
                        SlidesApi.UploadFile(new UploadFileRequest { Path = filePath, File = File.OpenRead(file) });
                    }
                    Stream versionFile = new MemoryStream(Encoding.UTF8.GetBytes(c_expectedVersion.ToString()));
                    SlidesApi.UploadFile(new UploadFileRequest { Path = $"{c_tempTestFolder}/{c_versionFile}", File = versionFile });
                }
                s_initialized = true;
            }
        }

        public static void Upload(string localPath, string storagePath)
        {
            SlidesApi.CopyFile(new CopyFileRequest { SrcPath = $"{c_tempTestFolder}/{localPath}", DestPath = storagePath });
        }

        public static void DeleteFile(string storagePath)
        {
            SlidesApi.DeleteFile(new DeleteFileRequest { Path = storagePath });
        }

        public static FileInfo GetLocalFile(string path, string mimeType)
        {
            return new FileInfo
            {
                Name = Path.GetFileName(path), MimeType = mimeType, Content = File.OpenRead(Path.Combine(TestDataPath, path))
            };
        }

        internal const string TestDataPath = "../../../../TestData";

        private const int c_expectedVersion = 1;
        private const string c_tempTestFolder = "TempTests";
        private const string c_versionFile = "version.txt";
        private static bool s_initialized;
        private static SlidesApi s_slidesApi;
        private static Configuration s_configuration;

        private static TimeSpan m_timeout = new TimeSpan(0, 1, 0);

        private static bool GetBoolConfigValue(string key, bool defaultValue)
        {
            bool result;
            return bool.TryParse(ConfigurationManager.AppSettings[key], out result) ? result : defaultValue;
        }

        private static bool IsTestDataUpToDate()
        {
            Stream version = SlidesApi.DownloadFile(new DownloadFileRequest { Path = $"{c_tempTestFolder}/{c_versionFile}" });
            if (version != null)
            {
                int actualVersion = 0;
                return int.TryParse(new StreamReader(version).ReadToEnd(), out actualVersion) && actualVersion == c_expectedVersion;
            }
            return false;
        }
    }
}
