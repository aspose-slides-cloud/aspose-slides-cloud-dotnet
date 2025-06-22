# .NET REST API to Process Presentation in Cloud
This repository contains Aspose.slides Cloud SDK for .NET source code. This SDK allows you to [process & manipulate PPT, PPTX, ODP, OTP](https://products.aspose.cloud/slides/net) using Aspose.slides Cloud REST APIs in your .NET applications.

You may want to check out Aspose free [Powerpoint to PDF](https://products.aspose.app/slides/conversion), [Powerpoint to Word](https://products.aspose.app/slides/conversion/ppt-to-word), [Powerpoint to JPG](https://products.aspose.app/slides/conversion/ppt-to-jpg), [Powerpoint to PNG](https://products.aspose.app/slides/conversion/ppt-to-png), [PDF to Powerpoint](https://products.aspose.app/slides/import/pdf-to-powerpoint), [JPG to Powerpoint](https://products.aspose.app/slides/import/jpg-to-ppt), and [PNG to Powerpoint](https://products.aspose.app/slides/import/png-to-ppt) converters because they are live implementations of popular conversion processes.

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
**Other**: PDF, PDF/A

## Save Presentation As

**Fixed Layout:** XPS
**Images:** JPEG, PNG, BMP, TIFF, GIF, SVG
**Web:** HTML/HTML5
**Other:** MPEG4, SWF (export whole presentations)

## Enhancements in Version 25.6

* Added **GetVideoCaptionTracks**, **CreateVideoCaptionTrack**, **DeleteVideoCaptionTracks**, **DeleteVideoCaptionTracks** method.
* Removed deprecated **DeletePictureCroppedAreas** method.
* Added an optional **quality** parameter to **DownloadImage**, **DownloadImageOnline**, **DownloadImages**, **DownloadImagesOnline** method. It applies to jpeg fromat.
* Added **RemoveEmptyLines**, **SlideNumberFormat** and **HandleRepeatedSpaces** properties to **MarkdownExportOptions** class.
* Added **DeletePictureCroppedAreas** and **Resolution** parameters to **PictureFill** class that allow to compress and/or delete cropped aread of picture fill formats.
* Added **Emf** to the list of allowed values for **ExportFormat**, **SlideExportFormat** and **ShapeExportFormat** enumerations. You can now export presentations, slides and shapes to EMF format.
* Added **VolumeValue**, **FadeInDuration**, **FadeOutDuration**, **TrimFromStart** and **TrimFromEnd** properties to **AudioFrame** class.
* Added **SkipJavaScriptLinks** boolean property to **ExportOptions** class.
* Added **DisableFontLigatures** boolean property to **HtmlExportOptions**, **Html5ExportOptions** and **SvgExportOptions** class.
* Added **SlidesLayoutOptions** property and removed **NotesCommentsLayouting** property from **Html5ExportOptions** class.
* Added **RemoveEmptyLines**, **SlideNumberFormat** and **HandleRepeatedSpaces** properties to **MarkdownExportOptions** class.
* Added **SlidesLayoutOptions** property and removed **CommentsPosition**, **CommentsAreaColor**, **CommentsAreaWidth**, **NotesPosition** and **ShowCommentsByNoAuthor** properties from **SwfExportOptions** class.
* Added **RefreshThumbnail** boolean property to **PptxExportOptions** class.

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
using Stream presentation = File.OpenRead("MyPresentation.pptx");
using Stream result = slidesApi.Convert(presentation, ExportFormat.Pdf);
using Stream pdf = File.OpenWrite("MyPresentation.pdf");
result.CopyTo(pdf);
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
