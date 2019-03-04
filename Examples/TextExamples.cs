using System;
using Aspose.Slides.Cloud.Sdk.RequestHandlers;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.TextAPI
{
    public class TextAPIExamples
    {
        TextApi api;
        string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        string SecretKey = "b125f13bf6b76ed81ee990142d841195";

        public TextAPIExamples()
        {
            api = new TextApi(AppSID, SecretKey);
        }


        private GetSlidesPresentationTextItemsRequest createGetSlidesPresentationTextItemsRequest()
        {
            GetSlidesPresentationTextItemsRequest request = new GetSlidesPresentationTextItemsRequest();
            request.Name = "test.pptx";
            request.WithEmpty = true;
            return request;
        }


        private GetSlidesSlideTextItemsRequest createGetSlidesSlideTextItemsRequest()
        {
            GetSlidesSlideTextItemsRequest request = new GetSlidesSlideTextItemsRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 0;
            request.WithEmpty = true;
            return request;
        }


        private PostSlidesPresentationReplaceTextRequest createPostSlidesPresentationReplaceTextRequest()
        {
            PostSlidesPresentationReplaceTextRequest request = new PostSlidesPresentationReplaceTextRequest();
            request.Name = "test.pptx";
            request.OldValue = "hello";
            request.NewValue = "world";
            request.IgnoreCase = true;
            return request;
        }

        private PostSlidesSlideReplaceTextRequest createPostSlidesSlideReplaceTextRequest()
        {
            PostSlidesSlideReplaceTextRequest request = new PostSlidesSlideReplaceTextRequest();
            request.SlideIndex = 0;
            request.Name = "test.pptx";
            request.OldValue = "hello";
            request.NewValue = "world";
            request.IgnoreCase = true;
            return request;
        }

        public void getSlidesPresentationTextItemsTest()
        {
            TextItemsResponse response = null;
            try
            {
                GetSlidesPresentationTextItemsRequest request = createGetSlidesPresentationTextItemsRequest();
                response = api.GetSlidesPresentationTextItems(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }


        public void getSlidesSlideTextItemsTest()
        {
            TextItemsResponse response = null;
            try
            {
                GetSlidesSlideTextItemsRequest request = createGetSlidesSlideTextItemsRequest();
                response = api.GetSlidesSlideTextItems(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        public void postSlidesPresentationReplaceTextTest()
        {
            PresentationStringReplaceResponse response = null;
            try
            {
                PostSlidesPresentationReplaceTextRequest request = createPostSlidesPresentationReplaceTextRequest();
                response = api.PostSlidesPresentationReplaceText(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void postSlidesSlideReplaceTextTest()
        {
            SlideStringReplaceResponse response = null;
            try
            {
                PostSlidesSlideReplaceTextRequest request = createPostSlidesSlideReplaceTextRequest();
                response = api.PostSlidesSlideReplaceText(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
