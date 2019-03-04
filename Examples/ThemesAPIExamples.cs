using System;
using Aspose.Slides.Cloud.Sdk.RequestHandlers;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk;
using Aspose.Slides.Cloud.Sdk.Model;
using System.IO;
namespace Aspose.Slides.Cloud.Examples.ThemesAPI
{
    public class ThemesAPIExamples
    {
        ThemeApi api;
        string AppSID = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9";
        string SecretKey = "b125f13bf6b76ed81ee990142d841195";

        public ThemesAPIExamples()
        {
            api = new ThemeApi(AppSID, SecretKey);
        }

        private GetSlidesThemeRequest createGetSlidesThemeRequest()
        {
            GetSlidesThemeRequest request = new GetSlidesThemeRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 0;
            return request;
        }


        private GetSlidesThemeFormatSchemeRequest createGetSlidesThemeFormatSchemeRequest()
        {
            GetSlidesThemeFormatSchemeRequest request = new GetSlidesThemeFormatSchemeRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 0;
            return request;
        }



        private GetSlidesThemeFontSchemeRequest createGetSlidesThemeFontSchemeRequest()
        {
            GetSlidesThemeFontSchemeRequest request = new GetSlidesThemeFontSchemeRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 0;
            return request;
        }

        private GetSlidesThemeColorSchemeRequest createGetSlidesThemeColorSchemeRequest()
        {
            GetSlidesThemeColorSchemeRequest request = new GetSlidesThemeColorSchemeRequest();
            request.Name = "test.pptx";
            request.SlideIndex = 0;
            return request;
        }

        public void getSlidesThemeTest()
        {
            ThemeResponse response = null;
            try
            {
                GetSlidesThemeRequest request = createGetSlidesThemeRequest();
                response = api.GetSlidesTheme(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void getSlidesThemeColorSchemeExample()
        {
            ColorSchemeResponse response = null;
            try
            {
                GetSlidesThemeColorSchemeRequest request = createGetSlidesThemeColorSchemeRequest();
                response = api.GetSlidesThemeColorScheme(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void getSlidesThemeFontSchemeExample()
        {
            FontSchemeResponse response = null;
            try
            {
                GetSlidesThemeFontSchemeRequest request = createGetSlidesThemeFontSchemeRequest();
                response = api.GetSlidesThemeFontScheme(request);
                Console.WriteLine(response.Code);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void getSlidesThemeFormatSchemeTest()
        {
            FormatSchemeResponse response = null;
            try
            {
                GetSlidesThemeFormatSchemeRequest request = createGetSlidesThemeFormatSchemeRequest();
                response = api.GetSlidesThemeFormatScheme(request);
                Console.WriteLine(response.Code);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}