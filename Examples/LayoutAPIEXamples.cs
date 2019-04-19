using System;
using Aspose.Slides.Cloud.Sdk.RequestHandlers;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.LayoutAPI
{
    public class LayoutAPIExamples
    {

        private string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        private string SecretKey = "b125f13bf6b76ed81ee990142d841195";
         private LayoutSlidesApi api;
        public LayoutAPIExamples()
        {
            api = new LayoutSlidesApi(AppSID, SecretKey);
        }


        private GetLayoutSlideRequest createGetLayoutSlideRequest()
        {
            GetLayoutSlideRequest request = new GetLayoutSlideRequest();
            request.Name = "test.pptx";
            return request;
        }

        private GetLayoutSlidesListRequest createGetLayoutSlidesListRequest()
        {
            GetLayoutSlidesListRequest request = new GetLayoutSlidesListRequest();
            request.Name = "test.pptx";

            return request;
        }
        private PostCopyLayoutSlideFromSourcePresentationRequest createPostCopyLayoutSlideFromSourcePresentationRequest()
        {
            PostCopyLayoutSlideFromSourcePresentationRequest request = new PostCopyLayoutSlideFromSourcePresentationRequest();
            request.Name = "test.pptx";
            request.CloneFrom = "test.pptx";
            request.CloneFromPosition = 1;

            return request;
        }

        private PutLayoutSlideRequest createPutLayoutSlideRequest()
        {
            PutLayoutSlideRequest request = new PutLayoutSlideRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            LayoutSlide layoutSlide = new LayoutSlide();
            ResourceUriElement uriElement = new ResourceUriElement();
            ResourceUri uri = new ResourceUri();
            uri.Href = "masterSlides/2";
            uriElement.Uri = uri;
            layoutSlide.MasterSlide = uriElement;
            request.SlideDto = layoutSlide;
            return request;
        }

        public void GetLayoutSlideExample()
        {
            LayoutSlideResponse response = null;
            try
            {
                GetLayoutSlideRequest request = createGetLayoutSlideRequest();
                response = api.GetLayoutSlide(request);
                Console.WriteLine(response);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void GetLayoutSlidesListExample()
        {
            LayoutSlideListResponse response = null;
            try
            {
                GetLayoutSlidesListRequest request = createGetLayoutSlidesListRequest();
                response = api.GetLayoutSlidesList(request);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void PostCopyLayoutSlideFromSourcePresentationExample()
        {
            LayoutSlideResponse response = null; ;
            try
            {
                PostCopyLayoutSlideFromSourcePresentationRequest request = createPostCopyLayoutSlideFromSourcePresentationRequest();
                response = api.PostCopyLayoutSlideFromSourcePresentation(request);
                Console.WriteLine(response);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void PutLayoutSlideExample()
        {
            LayoutSlideResponse response = null;
            try
            {
                PutLayoutSlideRequest request = createPutLayoutSlideRequest();
                response = api.PutLayoutSlide(request);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}