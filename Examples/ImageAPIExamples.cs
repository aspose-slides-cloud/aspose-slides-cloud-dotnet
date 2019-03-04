using System;
using Aspose.Slides.Cloud.Sdk.RequestHandlers;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.ImageAPI
{
    public class ImageAPIExamples
    {

        private string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        private string SecretKey = "b125f13bf6b76ed81ee990142d841195";


        private ImagesApi api;
        public ImageAPIExamples()
        {
            api = new ImagesApi(AppSID, SecretKey);
        }

        private GetSlidesImageWithFormatRequest createGetSlidesImageWithFormatRequest()
        {
            GetSlidesImageWithFormatRequest request = new GetSlidesImageWithFormatRequest();
            request.Name = "test.pptx";
            request.Index = 1;
            request.Format = ImageExportFormat.Jpeg;
            return request;
        }
        private GetSlidesImagesRequest createGetSlidesImagesRequest()
        {
            GetSlidesImagesRequest request = new GetSlidesImagesRequest();
            request.Name = "test.pptx";
            return request;
        }

        public void GetSlidesImageWithFormatExample()
        {

            Stream response = null;
            try
            {
                GetSlidesImageWithFormatRequest request = createGetSlidesImageWithFormatRequest();
                response = api.GetSlidesImageWithFormat(request);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetSlidesImagesTest()
        {
            ImagesResponse response = null;
            try
            {
                GetSlidesImagesRequest request = createGetSlidesImagesRequest();
                response = api.GetSlidesImages(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



    }
}
