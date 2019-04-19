using System;
using Aspose.Slides.Cloud.Sdk.RequestHandlers;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.MasterSlide
{
    public class MasterSlideAPIExamples
    {

        string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        string SecretKey = "b125f13bf6b76ed81ee990142d841195";


        MasterSlidesApi api;

        public MasterSlideAPIExamples()
        {
            api = new MasterSlidesApi(AppSID, SecretKey);
        }


        private GetMasterSlideRequest createGetMasterSlideRequest()
        {
            GetMasterSlideRequest request = new GetMasterSlideRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            return request;
        }

        private GetMasterSlidesListRequest createGetMasterSlidesListRequest()
        {
            GetMasterSlidesListRequest request = new GetMasterSlidesListRequest();
            request.Name = "test.pptx";
            return request;
        }
        private PostCopyMasterSlideFromSourcePresentationRequest createPostCopyMasterSlideFromSourcePresentationRequest()
        {
            PostCopyMasterSlideFromSourcePresentationRequest request = new PostCopyMasterSlideFromSourcePresentationRequest();
            request.Name = "test.pptx";
            request.CloneFrom = "test.pptx";
            request.CloneFromPosition = 1;
            request.ApplyToAll = true;
            return request;
        }

        public void getMasterSlideExample()
        {

            MasterSlideResponse response = null;
            try
            {
                GetMasterSlideRequest request = createGetMasterSlideRequest();
                response = api.GetMasterSlide(request);
                Console.WriteLine(response);

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }

        public void getMasterSlidesListExample()
        {
            MasterSlideListResponse response = null;
            try
            {
                GetMasterSlidesListRequest request = createGetMasterSlidesListRequest();
                response = api.GetMasterSlidesList(request);
                Console.WriteLine(response);

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }

        }

        public void postCopyMasterSlideFromSourcePresentationExample()
        {
            MasterSlideResponse response = null;
            try
            {
                PostCopyMasterSlideFromSourcePresentationRequest request = createPostCopyMasterSlideFromSourcePresentationRequest();
                response = api.PostCopyMasterSlideFromSourcePresentation(request);
                 Console.WriteLine(response);

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }

        }
    }
}