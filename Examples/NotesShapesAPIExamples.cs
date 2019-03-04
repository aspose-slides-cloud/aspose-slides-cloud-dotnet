using System;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.NotesShapesAPI
{
    public class NotesAPIExamples
    {
        NotesSlideShapesApi api;

        public NotesAPIExamples()
        {
            api = new NotesSlideShapesApi(AppSID, SecretKey);
        }

        string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        string SecretKey = "b125f13bf6b76ed81ee990142d841195";

        private DeleteNotesSlideParagraphRequest createDeleteNotesSlideParagraphRequest()
        {
            DeleteNotesSlideParagraphRequest request = new DeleteNotesSlideParagraphRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.ShapeIndex = 0;
            request.ParagraphIndex = 1;

            return request;
        }

        private DeleteNotesSlideParagraphsRequest createDeleteNotesSlideParagraphsRequest()
        {
            DeleteNotesSlideParagraphsRequest request = new DeleteNotesSlideParagraphsRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.ShapeIndex = 0;
            return request;
        }

        private DeleteNotesSlidePortionsRequest createDeleteNotesSlidePortionsRequest()
        {
            DeleteNotesSlidePortionsRequest request = new DeleteNotesSlidePortionsRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.ShapeIndex = 0;
            return request;
        }

        private DeleteNotesSlideShapeRequest createDeleteNotesSlideShapeRequest()
        {
            DeleteNotesSlideShapeRequest request = new DeleteNotesSlideShapeRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.ShapeIndex = 0;
            return request;
        }

        private DeleteNotesSlideShapesRequest createDeleteNotesSlideShapesRequest()
        {
            DeleteNotesSlideShapesRequest request = new DeleteNotesSlideShapesRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            return request;
        }

        private GetNotesSlideShapeRequest createGetNotesSlideShapeRequest()
        {
            GetNotesSlideShapeRequest request = new GetNotesSlideShapeRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            return request;
        }

        private GetNotesSlideShapeParagraphRequest createGetNotesSlideShapeParagraphRequest()
        {
            GetNotesSlideShapeParagraphRequest request = new GetNotesSlideShapeParagraphRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.ShapeIndex = 0;
            request.ParagraphIndex = 1;

            return request;
        }

        private GetNotesSlideShapeParagraphsRequest createGetNotesSlideShapeParagraphsRequest()
        {
            GetNotesSlideShapeParagraphsRequest request = new GetNotesSlideShapeParagraphsRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.ShapeIndex = 0;
            return request;
        }

        private GetNotesSlideShapePortionRequest createGetNotesSlideShapePortionRequest()
        {
            GetNotesSlideShapePortionRequest request = new GetNotesSlideShapePortionRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.ShapeIndex = 0;
            request.ParagraphIndex = 1;

            return request;
        }

        private GetNotesSlideShapePortionsRequest createGetNotesSlideShapePortionsRequest()
        {
            GetNotesSlideShapePortionsRequest request = new GetNotesSlideShapePortionsRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.ShapeIndex = 0;
            request.ParagraphIndex = 1;
            return request;
        }

        private GetNotesSlideShapeWithFormatRequest createGetNotesSlideShapeWithFormatRequest()
        {
            GetNotesSlideShapeWithFormatRequest request = new GetNotesSlideShapeWithFormatRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.ShapeIndex = 0;
            request.Format = ShapeExportFormat.Jpeg;

            return request;
        }

        private GetNotesSlideShapesRequest createGetNotesSlideShapesRequest()
        {
            GetNotesSlideShapesRequest request = new GetNotesSlideShapesRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;

            return request;
        }

        private PostNotesSlideAddNewPortionRequest createPostNotesSlideAddNewPortionRequest()
        {
            PostNotesSlideAddNewPortionRequest request = new PostNotesSlideAddNewPortionRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.SlideIndex = 1;
            request.ParagraphIndex = 1;
            return request;
        }

        private PostNotesSlideAddNewShapeRequest createPostNotesSlideAddNewShapeRequest()
        {
            PostNotesSlideAddNewShapeRequest request = new PostNotesSlideAddNewShapeRequest();

            request.Name = "test.pptx";
            request.SlideIndex = 1;
            request.Position = 0;
            return request;
        }


        public void deleteNotesSlideParagraphExample()
        {

            ParagraphListResponse response = null;
            try
            {
                DeleteNotesSlideParagraphRequest request = createDeleteNotesSlideParagraphRequest();
                response = api.DeleteNotesSlideParagraph(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void deleteNotesSlideParagraphsExample()
        {
            ParagraphListResponse response = null;
            try
            {
                DeleteNotesSlideParagraphsRequest request = createDeleteNotesSlideParagraphsRequest();
                response = api.DeleteNotesSlideParagraphs(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void deleteNotesSlidePortionsExample()
        {
            PortionListResponse response = null;
            try
            {
                DeleteNotesSlidePortionsRequest request = createDeleteNotesSlidePortionsRequest();
                response = api.DeleteNotesSlidePortions(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void deleteNotesSlideShapeExample()
        {
            ShapeListResponse response = null;
            ;
            try
            {
                DeleteNotesSlideShapeRequest request = createDeleteNotesSlideShapeRequest();
                response = api.DeleteNotesSlideShape(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void deleteNotesSlideShapesExample()
        {
            ShapeListResponse response = null;
            try
            {
                DeleteNotesSlideShapesRequest request = createDeleteNotesSlideShapesRequest();
                response = api.DeleteNotesSlideShapes(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void getNotesSlideShapeExample()
        {
            ShapeResponse response = null;
            try
            {
                GetNotesSlideShapeRequest request = createGetNotesSlideShapeRequest();
                response = api.GetNotesSlideShape(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void getNotesSlideShapeParagraphExample()
        {
            ParagraphResponse response = null;
            try
            {
                GetNotesSlideShapeParagraphRequest request = createGetNotesSlideShapeParagraphRequest();
                response = api.GetNotesSlideShapeParagraph(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void getNotesSlideShapeParagraphsExample()
        {
            ParagraphListResponse response = null;
            try
            {
                GetNotesSlideShapeParagraphsRequest request = createGetNotesSlideShapeParagraphsRequest();
                response = api.GetNotesSlideShapeParagraphs(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void getNotesSlideShapePortionExample()
        {
            PortionResponse response = null;
            try
            {
                GetNotesSlideShapePortionRequest request = createGetNotesSlideShapePortionRequest();
                response = api.GetNotesSlideShapePortion(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void getNotesSlideShapePortionsExample()
        {
            PortionListResponse response = null;
            try
            {
                GetNotesSlideShapePortionsRequest request = createGetNotesSlideShapePortionsRequest();
                response = api.GetNotesSlideShapePortions(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void getNotesSlideShapeWithFormatTest()
        {
            Stream response = null;

            try
            {
                GetNotesSlideShapeWithFormatRequest request = createGetNotesSlideShapeWithFormatRequest();
                response = api.GetNotesSlideShapeWithFormat(request);
                Console.WriteLine(response);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void getNotesSlideShapesTest()
        {
            ShapeListResponse response = null;

            try
            {
                GetNotesSlideShapesRequest request = createGetNotesSlideShapesRequest();
                response = api.GetNotesSlideShapes(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void postNotesSlideAddNewPortionTest()
        {
            PortionResponse response = null;
            try
            {
                PostNotesSlideAddNewPortionRequest request = createPostNotesSlideAddNewPortionRequest();
                response = api.PostNotesSlideAddNewPortion(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void postNotesSlideAddNewShapeTest()
        {
            ShapeResponse response = null; ;
            try
            {
                PostNotesSlideAddNewShapeRequest request = createPostNotesSlideAddNewShapeRequest();
                response = api.PostNotesSlideAddNewShape(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
