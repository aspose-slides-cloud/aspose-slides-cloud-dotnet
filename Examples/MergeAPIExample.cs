using System;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
namespace Aspose.Slides.Cloud.Examples.MergeAPI
{
    public class MergeAPIExamples
    {
        MergeDocumentApi api;

        public MergeAPIExamples()
        {
            api = new MergeDocumentApi(AppSID, SecretKey);
        }

        string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        string SecretKey = "b125f13bf6b76ed81ee990142d841195";


        private PostPresentationMergeRequest createPostPresentationMergeRequest()
        {
            PostPresentationMergeRequest request = new PostPresentationMergeRequest();
            request.Name = "test.pptx";
            return request;
        }


        private PutPresentationMergeRequest createPutPresentationMergeRequest()
        {
            PutPresentationMergeRequest request = new PutPresentationMergeRequest();
            request.Name = "test.pptx";
            return request;
        }

        public void postPresentationMergeExample()
        {
            DocumentResponse response = null;
            try
            {
                PostPresentationMergeRequest request = createPostPresentationMergeRequest();
                response = api.PostPresentationMerge(request);
                Console.WriteLine(response);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void putPresentationMergeExample()
        {
            DocumentResponse response = null;
            try
            {
                PutPresentationMergeRequest request = createPutPresentationMergeRequest();
                response = api.PutPresentationMerge(request);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
