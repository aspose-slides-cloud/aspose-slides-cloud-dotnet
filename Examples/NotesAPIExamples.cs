using System;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.NotesAPI
{
    public class NotesAPIExamples
    {
        string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        string SecretKey = "b125f13bf6b76ed81ee990142d841195";

        NotesSlideApi api;

        public NotesAPIExamples()
        {
            api = new NotesSlideApi(AppSID, SecretKey);
        }



        private DeleteNotesSlideRequest createDeleteNotesSlideRequest()
        {
            DeleteNotesSlideRequest request = new DeleteNotesSlideRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;

            return request;
        }

        private GetNotesSlideRequest createGetNotesSlideRequest()
        {
            GetNotesSlideRequest request = new GetNotesSlideRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            return request;
        }

        private GetNotesSlideWithFormatRequest createGetNotesSlideWithFormatRequest()
        {
            GetNotesSlideWithFormatRequest request = new GetNotesSlideWithFormatRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.Format = NotesSlideExportFormat.Jpeg;

            return request;
        }

        private PostAddNotesSlideRequest createPostAddNotesSlideRequest()
        {
            PostAddNotesSlideRequest request = new PostAddNotesSlideRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;

            NotesSlide slide = new NotesSlide();
            slide.Text = "Hello World";

            request.Dto = slide;

            return request;
        }

        private PutUpdateNotesSlideRequest createPutUpdateNotesSlideRequest()
        {
            PutUpdateNotesSlideRequest request = new PutUpdateNotesSlideRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;

            NotesSlide slide = new NotesSlide();
            slide.Text = "Hello World";

            request.Dto = slide;
            return request;
        }

        public void deleteNotesSlideExample()
        {

            SlideResponse response = null;
            try
            {
                DeleteNotesSlideRequest request = createDeleteNotesSlideRequest();
                response = api.DeleteNotesSlide(request);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void getNotesSlideExample()
        {
            NotesSlideResponse response = null;
            try
            {
                GetNotesSlideRequest request = createGetNotesSlideRequest();
                response = api.GetNotesSlide(request);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void getNotesSlideWithFormatExample()
        {

            Stream response = null;
            try
            {
                GetNotesSlideWithFormatRequest request = createGetNotesSlideWithFormatRequest();
                response = api.GetNotesSlideWithFormat(request);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void postAddNotesSlideExample()
        {
            NotesSlideResponse response = null;
            try
            {
                PostAddNotesSlideRequest request = createPostAddNotesSlideRequest();
                response = api.PostAddNotesSlide(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void putUpdateNotesSlideExample()
        {
            NotesSlideResponse response = null;
            try
            {
                PutUpdateNotesSlideRequest request = createPutUpdateNotesSlideRequest();
                response = api.PutUpdateNotesSlide(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}