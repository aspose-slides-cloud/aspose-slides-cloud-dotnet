using System;
using Aspose.Slides.Cloud.Sdk.RequestHandlers;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.DocumentAPI
{
    public class DocumentAPIExamples
    {

        private string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        private string SecretKey = "b125f13bf6b76ed81ee990142d841195";


        private DocumentApi api;
        public DocumentAPIExamples()
        {
            api = new DocumentApi(AppSID, SecretKey);
        }
	private static GetSlidesDocumentRequest createGetSlidesDocumentRequest() {
		GetSlidesDocumentRequest request = new GetSlidesDocumentRequest();
		request.Name="test.pptx";

		return request;
	}

	private static GetSlidesDocumentWithFormatRequest createGetSlidesDocumentWithFormatRequest() {
		GetSlidesDocumentWithFormatRequest request = new GetSlidesDocumentWithFormatRequest();
		request.Name="test.pptx";
		//request.Format=ExportFormat.PNG;
		request.JpegQuality=100;

		return request;
	}

	private static PostSlidesDocumentRequest createPostSlidesDocumentRequest() {
		PostSlidesDocumentRequest request = new PostSlidesDocumentRequest();
		request.Name="test1.pptx";
		request.Data="This is a test";
		request.IsImageDataEmbedded=false;
		return request;
	}

	private static PostSlidesSaveAsRequest createPostSlidesSaveAsRequest() {
		PostSlidesSaveAsRequest request = new PostSlidesSaveAsRequest();
		request.Name="test.pptx";
        request.Format=ExportFormat.Jpeg;

		return request;
	}

	private static PostSlidesSplitRequest createPostSlidesSplitRequest() {
		PostSlidesSplitRequest request = new PostSlidesSplitRequest();
		request.Name="test.pptx";
		request.Format=SlideExportFormat.Jpeg;

		return request;
	}
	private static PutSlidesSlideSizeRequest createPutSlidesSlideSizeRequest() {
        PutSlidesSlideSizeRequest request = new PutSlidesSlideSizeRequest();
        request.Name="test.pptx";
        request.SizeType=SizeType.A4Paper;
        request.ScaleType=ScaleType.DoNotScale;
        return request;
    }
	private static PutSlidesConvertRequest createPutSlidesConvertRequest()  {
		PutSlidesConvertRequest request = new PutSlidesConvertRequest();

		return request;
	}
	private static PutSlidesDocumentFromHtmlRequest createPutSlidesDocumentFromHtmlRequest() {
        PutSlidesDocumentFromHtmlRequest request = new PutSlidesDocumentFromHtmlRequest();
        request.Name="test.pptx";
        request.Html="<html></html>";

        return request;
    }
	public void GetSlidesDocumentRequest() {
		DocumentResponse response = null;
		try {
			DocumentApi api = new DocumentApi(AppSID, SecretKey);
			GetSlidesDocumentRequest request = createGetSlidesDocumentRequest();
			response = api.GetSlidesDocument(request);

		} catch (Exception ex) {
			 Console.WriteLine(ex.Message);
		}

	}

	public void GetSlidesDocumentWithFormatTest() {
		try {
			GetSlidesDocumentWithFormatRequest request = createGetSlidesDocumentWithFormatRequest();
			Stream response = api.GetSlidesDocumentWithFormat(request);
			Console.WriteLine(response);
		} catch (Exception ex) {
			 Console.WriteLine(ex.Message);
		}
	}

	public void PostSlidesDocumentExample()  {
		DocumentResponse response = null;
		try {
			PostSlidesDocumentRequest request = createPostSlidesDocumentRequest();
			response = api.PostSlidesDocument(request);
			Console.WriteLine(response.Code);
		} catch (Exception ex) {
			 Console.WriteLine(ex.Message);
		}

	}

	public void PostSlidesSaveAsExample() {
		
		try {
			PostSlidesSaveAsRequest request = createPostSlidesSaveAsRequest();
			Stream response = api.PostSlidesSaveAs(request);
			Console.WriteLine(response);
		} catch (Exception ex) {
			 Console.WriteLine(ex.Message);
		}

	}

	public void PostSlidesSplitExample() {
		SplitDocumentResponse response = null;
		
		try {
			PostSlidesSplitRequest request = createPostSlidesSplitRequest();
			response = api.PostSlidesSplit(request);
			Console.WriteLine(response.Code);

		} catch (Exception ex) {
			 Console.WriteLine(ex.Message);
		}

	}

	public void PutSlidesConvertExample() {

		try {
			PutSlidesConvertRequest request = createPutSlidesConvertRequest();
			Stream response=api.PutSlidesConvert(request);
			Console.WriteLine(response);
		} catch (Exception ex) {
			 Console.WriteLine(ex.Message);
		}
	}
	
	public void PutSlidesDocumentFromHtmlExample() {
        DocumentResponse response = null;
        try {
            PutSlidesDocumentFromHtmlRequest request = createPutSlidesDocumentFromHtmlRequest();
            response = api.PutSlidesDocumentFromHtml(request);
			Console.WriteLine(response.Code);

        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
	
	public void PutSlidesSlideSizeExample() {
        DocumentResponse response = null;
        try {
            PutSlidesSlideSizeRequest request = createPutSlidesSlideSizeRequest();
            response = api.PutSlidesSlideSize(request);
			Console.WriteLine(response.Code);

        } catch (Exception ex) {
        	 Console.WriteLine(ex.Message);
        }

    }
    }
}
