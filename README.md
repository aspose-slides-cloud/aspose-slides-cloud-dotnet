# .NET REST API to Process Presentation in Cloud
This repository contains Aspose.slides Cloud SDK for .NET source code. This SDK allows you to [process & manipulate PPT, PPTX, ODP, OTP](https://products.aspose.cloud/slides/net) using Aspose.slides Cloud REST APIs in your .NET applications.

## Presentation Processing Features

- Fetch presentation images in any of the supported file formats.
- Copy the layout side or clone the master slide from the source presentation.
- Process slides shapes, slides notes, placeholders, colors & font theme info.
- Programmatically create a presentation from HTML & export it to various formats.
- Merge multiple presentations or split the single presentation into multiple ones.
- Extract and replace text from a specific slide or an entire presentation.

## Read & Write Presentation Formats
**Microsoft PowerPoint:** PPT, PPTX, PPS, PPSX, PPTM, PPSM, POTX, POTM
**OpenOffice:** ODP, OTP, FODP

## Save Presentation As
**Fixed Layout:** PDF, PDF/A, XPS
**Images:** JPEG, PNG, BMP, TIFF, SVG
**Web:** HTML
**Other:** SWF (export whole presentations)

## Enhancements in Version 21.1
* New **PostSlidesDocumentFromPdf** method allows creating presentations or adding slides to it using a PDF file as a source.
* New **GetSlidesSlideProperties**, **GetSlidesProtectionProperties**, **PutSlidesSlideProperties**, **PutSlidesProtectionProperties** allow to get/set presentaion properties like slide size, orientaion, read-only etc.
* **PutSlidesDocumentFromHtml** method is deprecated and will be deleted in 21.4 release. Use **PostSlidesDocumentFromHtml** method instead.
* **PutSlidesSlideSize** method is deprecated and will be deleted in 21.4 release. Use **PutSlidesProtectionProperties** method instead.

## Enhancements in Version 20.12
- Updated the SDK to run with cloud image.
- **HttpRequestTimeout** property is added to SDK configuration. It allows specifying a custom timeout (in seconds) for **HTTP** requests made by the SDK.

## Enhancements in Version 20.10
* Removed ****ShapeType** property from BaseShape class; replaced **GeometryShapeType** with **ShapeType** property for **GeometryShape**.
* Removed redundant **ResourceUriElement** class. All properties of **ResourceUriElement** type are changed to ResourceUri type.

## Enhancements in Version 20.9
* New **GetSections, PutSections, PutSection, PostSection, PostSectionMove, DeleteSection, DeleteSections** methods to add, update and delete presentation sections.
* New **PostslidesHeaderFooter, PostSlideHeaderFooter, GetSlideHeaderFooter, PostNotesSlideHeaderFooter, GetNotesSlideHeaderFooter** methods to manage header/footer settings for slides.
* Replaced Categories for **ParentCategories** & Level properties in **ChartCategory** class to properly support Sunburst & Treeview charts.

## Licensing
All Aspose.Slides Cloud SDKs are licensed under MIT License.

## How to use the SDK?

The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.Slides-Cloud/) (recommended).

### Prerequisites

To use Aspose Slides Cloud SDK you need to register an account with [Aspose Cloud](https://www.aspose.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.aspose.cloud/#/apps). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing).

### Installation

From the command line:

	nuget install Aspose.Slides-Cloud

From Package Manager:

	PM> Install-Package Aspose.Slides-Cloud

### Sample usage

The example code below converts a PowerPoint document to PDF format using Aspose.Slides-Cloud library:
```csharp
SlidesApi slidesApi = new SlidesApi("MyClientId", "MyClientSecret");
Stream presentation = File.OpenRead("MyPresentation.pptx");
PostSlidesConvertRequest convertRequest = new PostSlidesConvertRequest(ExportFormat.Pdf, presentation);
Stream pdf = slidesApi.PostSlidesConvert(convertRequest);
pdf.CopyTo(File.OpenWrite("MyPresentation.pdf"));
```
You can check more [Examples](Examples) of using the SDK.

## Contact Us

Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.aspose.cloud/c/slides).

## Resources
 
[Website](https://www.aspose.cloud/)  
[Product Home](https://products.aspose.cloud/slides/family)  
[API Reference](https://apireference.aspose.cloud/slides/)  
[Documentation](https://docs.aspose.cloud/slides/)  
[Blog](https://blog.aspose.cloud/category/slides/)  
 
## Other languages

We generate our SDKs in different languages so you may check if yours is available in our [list](https://github.com/aspose-slides-cloud).
 
If you don't find your language in the list, feel free to request it from us, or use raw REST API requests as you can find it [here](https://products.aspose.cloud/slides/curl).
