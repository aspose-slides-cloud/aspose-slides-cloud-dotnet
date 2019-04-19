using System;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.PlaceHolderAPI
{
    public class PlaceHolderAPIExamples
    {
        PlaceholdersApi api;

        public PlaceHolderAPIExamples()
        {
            api = new PlaceholdersApi(AppSID, SecretKey);
        }

        string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        string SecretKey = "b125f13bf6b76ed81ee990142d841195";

        private GetSlidesPlaceholderRequest createGetSlidesPlaceholderRequest()
        {
            GetSlidesPlaceholderRequest request = new GetSlidesPlaceholderRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.PlaceholderIndex = 0;

            return request;
        }

        private GetSlidesPlaceholdersRequest createGetSlidesPlaceholdersRequest()
        {
            GetSlidesPlaceholdersRequest request = new GetSlidesPlaceholdersRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            return request;
        }

        public void getSlidesPlaceholderExample()
        {

            PlaceholderResponse response = null;
            try
            {
                GetSlidesPlaceholderRequest request = createGetSlidesPlaceholderRequest();
                response = api.GetSlidesPlaceholder(request);
                Console.WriteLine(response);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void getSlidesPlaceholdersTest()
        {
            PlaceholdersResponse response = null;
            try
            {
                GetSlidesPlaceholdersRequest request = createGetSlidesPlaceholdersRequest();
                response = api.GetSlidesPlaceholders(request);
                Console.WriteLine(response);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}