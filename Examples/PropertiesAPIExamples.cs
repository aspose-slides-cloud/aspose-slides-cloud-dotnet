using System;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.PropertiesAPI
{
    public class PropertiesAPIExamples
    {
        PropertiesApi api;
        string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        string SecretKey = "b125f13bf6b76ed81ee990142d841195";

        public PropertiesAPIExamples()
        {
            api = new PropertiesApi(AppSID, SecretKey);
        }
        private PutSlidesSetDocumentPropertyRequest createPutSlidesSetDocumentPropertyRequest()
        {
            PutSlidesSetDocumentPropertyRequest request = new PutSlidesSetDocumentPropertyRequest();
            request.Name = "test.pptx";
            request.PropertyName = "author";
            DocumentProperty prop = new DocumentProperty();
            prop.Name = "author";
            request.Property = prop;

            return request;
        }
        private DeleteSlidesDocumentPropertyRequest createDeleteSlidesDocumentPropertyRequest()
        {
            DeleteSlidesDocumentPropertyRequest request = new DeleteSlidesDocumentPropertyRequest();
            request.Name = "test.pptx";
            request.PropertyName = "author";
            return request;
        }

        private DeleteSlidesDocumentPropertiesRequest createDeleteSlidesDocumentPropertiesRequest()
        {
            DeleteSlidesDocumentPropertiesRequest request = new DeleteSlidesDocumentPropertiesRequest();
            request.Name = "test.pptx";
            return request;
        }

        public void deleteSlidesDocumentPropertiesExample()
        {

            DocumentPropertiesResponse response = null;
            try
            {
                DeleteSlidesDocumentPropertiesRequest request = createDeleteSlidesDocumentPropertiesRequest();
                response = api.DeleteSlidesDocumentProperties(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private GetSlidesDocumentPropertiesRequest createGetSlidesDocumentPropertiesRequest()
        {
            GetSlidesDocumentPropertiesRequest request = new GetSlidesDocumentPropertiesRequest();
            request.Name = "test.pptx";
            return request;
        }

        public void deleteSlidesDocumentPropertyExample()
        {
            DocumentPropertiesResponse response = null;
            try
            {
                DeleteSlidesDocumentPropertyRequest request = createDeleteSlidesDocumentPropertyRequest();
                response = api.DeleteSlidesDocumentProperty(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private PostSlidesSetDocumentPropertiesRequest createPostSlidesSetDocumentPropertiesRequest()
        {
            PostSlidesSetDocumentPropertiesRequest request = new PostSlidesSetDocumentPropertiesRequest();
            DocumentProperties properties = new DocumentProperties();

            DocumentProperty prop = new DocumentProperty();
            prop.Name = "author";
            properties.List.Add(prop);
            request.Properties=properties;

            return request;
        }

        private GetSlidesDocumentPropertyRequest createGetSlidesDocumentPropertyRequest()
        {
            GetSlidesDocumentPropertyRequest request = new GetSlidesDocumentPropertyRequest();
            request.PropertyName = "author";
            return request;
        }

        public void getSlidesDocumentPropertiesExample()
        {
            DocumentPropertiesResponse response = null;
            try
            {
                GetSlidesDocumentPropertiesRequest request = createGetSlidesDocumentPropertiesRequest();
                response = api.GetSlidesDocumentProperties(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void getSlidesDocumentPropertyTest()
        {
            DocumentPropertyResponse response = null;
            try
            {
                GetSlidesDocumentPropertyRequest request = createGetSlidesDocumentPropertyRequest();
                response = api.GetSlidesDocumentProperty(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        public void postSlidesSetDocumentPropertiesTest()
        {
            DocumentPropertiesResponse response = null;
            try
            {
                PostSlidesSetDocumentPropertiesRequest request = createPostSlidesSetDocumentPropertiesRequest();
                response = api.PostSlidesSetDocumentProperties(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void putSlidesSetDocumentPropertyTest()
        {
            DocumentPropertyResponse response = null;
            try
            {
                PutSlidesSetDocumentPropertyRequest request = createPutSlidesSetDocumentPropertyRequest();
                response = api.PutSlidesSetDocumentProperty(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}