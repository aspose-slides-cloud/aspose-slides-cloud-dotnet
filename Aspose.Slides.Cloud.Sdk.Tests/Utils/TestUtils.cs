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

#if NETFRAMEWORK
using System.Configuration;
#else
using Microsoft.Extensions.Configuration;
#endif
using System;
using System.IO;
using System.Text;

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    public static class TestUtils
    {
        public static SlidesApi SlidesApi { get { return s_slidesApi ?? (s_slidesApi = new SlidesApi(Configuration)); } }

        public static Configuration Configuration { get { return s_configuration ?? (s_configuration = GetConfiguration()); } }

        public static Configuration GetConfiguration()
        {
#if NETFRAMEWORK
            return new Configuration
            {
                DebugMode = GetBoolConfigValue("Debug", true),
                ApiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"] ?? "https://api-qa.aspose.cloud",
                AuthBaseUrl = ConfigurationManager.AppSettings["AuthBaseUrl"]
                    ?? ConfigurationManager.AppSettings["BaseUrl"]
                    ?? "https://api-qa.aspose.cloud",
                AppSid = ConfigurationManager.AppSettings["ClientId"],
                AppKey = ConfigurationManager.AppSettings["ClientSecret"]
            };
#else
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("testConfig.json").Build();
            return new Configuration
            {
                DebugMode = GetBoolConfigValue(config, "Debug", true),
                ApiBaseUrl = config["BaseUrl"] ?? "https://api-qa.aspose.cloud",
                AuthBaseUrl = config["AuthBaseUrl"] ?? config["BaseUrl"] ?? "https://api-qa.aspose.cloud",
                AppSid = config["ClientId"],
                AppKey = config["ClientSecret"]
            };
#endif
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
                        SlidesApi.UploadFile(filePath, File.OpenRead(file));
                    }
                    Stream versionFile = new MemoryStream(Encoding.UTF8.GetBytes(c_expectedVersion.ToString()));
                    SlidesApi.UploadFile($"{c_tempTestFolder}/{c_versionFile}", versionFile);
                }
                s_initialized = true;
            }
        }

        public static void Upload(string localPath, string storagePath)
        {
            SlidesApi.CopyFile($"{c_tempTestFolder}/{localPath}", storagePath);
        }

        public static void DeleteFile(string storagePath)
        {
            SlidesApi.DeleteFile(storagePath);
            SlidesApi.DeleteFolder(storagePath);
        }

        public static FileInfo GetLocalFile(string path, string mimeType)
        {
            return new FileInfo
            {
                Name = Path.GetFileName(path), MimeType = mimeType, Content = File.OpenRead(Path.Combine(TestDataPath, path))
            };
        }

        public const string TestDataPath = "../../../../TestData";

        private const int c_expectedVersion = 1;
        private const string c_tempTestFolder = "TempTests";
        private const string c_versionFile = "version.txt";
        private static bool s_initialized;
        private static SlidesApi s_slidesApi;
        private static Configuration s_configuration;

        private static TimeSpan m_timeout = new TimeSpan(0, 1, 0);

#if NETFRAMEWORK
        private static bool GetBoolConfigValue(string key, bool defaultValue)
        {
            bool result;
            return bool.TryParse(ConfigurationManager.AppSettings[key], out result) ? result : defaultValue;
        }
#else
        private static bool GetBoolConfigValue(IConfiguration config, string key, bool defaultValue)
        {
            bool result;
            return bool.TryParse(config[key], out result) ? result : defaultValue;
        }
#endif

        private static bool IsTestDataUpToDate()
        {
            Stream version = SlidesApi.DownloadFile($"{c_tempTestFolder}/{c_versionFile}");
            if (version != null)
            {
                int actualVersion = 0;
                return int.TryParse(new StreamReader(version).ReadToEnd(), out actualVersion) && actualVersion == c_expectedVersion;
            }
            return false;
        }
    }
}
