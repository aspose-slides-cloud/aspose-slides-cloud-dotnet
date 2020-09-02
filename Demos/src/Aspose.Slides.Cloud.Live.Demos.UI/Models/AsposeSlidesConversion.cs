using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.Slides.Cloud.Live.Demos.UI.Models;
using System.Diagnostics;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Model.Requests;

namespace Aspose.Slides.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// Aspose.Slides Cloud API convert method to convert word document file to other format
	///</Summary>
	
	public class AsposeSlidesConversion : AsposeSlidesCloudBase
    {        
        
		///<Summary>
		/// Convert method to convert file to other format
		///</Summary>
		public Response Convert(string fileName, string folderName,   string outputType)
        {
			string fileNamewithOutExtension = Path.GetFileNameWithoutExtension(fileName);
			string outputFileName = fileNamewithOutExtension + "." + outputType;
			ExportFormat exportFormat = new ExportFormat();
			bool foundSaveOption = true;
			
			switch (outputType)
			{
				case "pdf":
					exportFormat = ExportFormat.Pdf;
					break;
				case "ppt":
					exportFormat = ExportFormat.Ppt;
					break;
				case "pot":
					exportFormat = ExportFormat.Pot;
					break;
				case "pps":
					exportFormat = ExportFormat.Pps;
					break;
				case "pptx":
					exportFormat = ExportFormat.Pptx;
					break;					
				case "potx":
					exportFormat = ExportFormat.Potx;
					break;
				case "ppsx":
					exportFormat = ExportFormat.Ppsx;
					break;
				case "pptm":
					exportFormat = ExportFormat.Pptm;
					break;
				case "ppsm":
					exportFormat = ExportFormat.Ppsm;
					break;
				case "potm":
					exportFormat = ExportFormat.Potm;
					break;
				case "odp":
					exportFormat = ExportFormat.Odp;
					break;
				case "otp":
					exportFormat = ExportFormat.Otp;
					break;
				case "tiff":
					exportFormat = ExportFormat.Tiff;
					break;
				case "xps":
					exportFormat = ExportFormat.Xps;
					break;
				case "jpeg":
					exportFormat = ExportFormat.Jpeg;
					break;
				case "png":
					exportFormat = ExportFormat.Png;
					break;
				case "gif":
					exportFormat = ExportFormat.Gif;
					break;
				case "bmp":
					exportFormat = ExportFormat.Bmp;
					break;
				case "svg":
					exportFormat = ExportFormat.Svg;
					break;
				case "swf":
					exportFormat = ExportFormat.Swf;
					break;
				case "html":
					exportFormat = ExportFormat.Html;
					break;
				default:
					foundSaveOption = false;
					break;
			}

			if (slidesApi != null)
			{
				if (foundSaveOption)
				{
					FileStream file = File.OpenRead(System.IO.Path.Combine(Config.Configuration.WorkingDirectory, folderName, fileName));

					
					slidesApi.PutSlidesConvert(new PutSlidesConvertRequest(exportFormat, outputFileName, file, null, null));					
				}

				return new Response
				{
					FileName = outputFileName,
					Status = "OK",
					StatusCode = 200,
				};
			}
			return new Response
			{
				FileName = null,
				Status = "Output type not found",
				StatusCode = 500
			};

		}
		
    }
}
