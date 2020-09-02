using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Model.Requests;

namespace  Aspose.Slides.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeSlidesCloudBase class to have base methods
	///</Summary>

	public abstract class AsposeSlidesCloudBase : ApiController
    {
		protected SlidesApi slidesApi = new SlidesApi(Config.Configuration.AppSID, Config.Configuration.AppKey);
		///<Summary>
		/// Get File extension
		///</Summary>
		protected string GetoutFileExtension(string fileName, string folderName)
        {
			string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
            fileName = sourceFolder + "\\" + fileName;
            return Path.GetExtension(fileName);
        }
		
       
		
    }
}
