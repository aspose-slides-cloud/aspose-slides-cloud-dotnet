using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    [TestFixture]
    public class BaseTests
    {
        [SetUp]
        public void Init()
        {
            TestUtils.Init();
        }

        protected const string c_folderName = "TempSlidesSDK";
        protected const string c_fileName = "test.pptx";
        protected const string c_password = "password";
    }
}