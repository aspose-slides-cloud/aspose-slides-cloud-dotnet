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

## Enhancements in Version 23.4

* Added **CreateTableRow**, **UpdateTableRow** and **DeleteTableRow** methods to add, update and delete table rows.
* Added **UpdateTableCell** method to update table cells.
* Added  **MergeTableCells** and **SplitTableCell** methods to merge &amp; split table cells.
* Added methods to get, add, modify and delete paragraphs & portions within table cells: **GetTableCellParagraph**, **GetTableCellParagraphs**, **GetTableCellPortion**, **GetTableCellPortions**, **CreateTableCellParagraph**, **CreateTableCellPortion**, **UpdateTableCellPortion**, **UpdateTableCellParagraph**, **DeleteTableCellParagraph**,  **DeleteTableCellPortion**.
* New **TextFrameFormat** property in **TableCell** class allows to specify text format for table cells.

## Enhancements in Version 23.3

* Added **options** parameter to **SplitOnline** and **SplitAndSaveOnline** methods. Those options are the same as for other split & convert methods.
* Added **ShowHiddenSlides** boolean property to **ImageExportOptions** class.

## Enhancements in Version 23.2

* New **DownloadShapeFromDto** method allows to convert charts and other shapes from DTO to SVG and other formats without creating and storing presentation files.
* Added **SoundBase64** property to **Hyperlink** class to support getting and setting hyperlink sounds.
* Added **BulletFillFormat** property to **Paragraph** class.
* Added **StopPreviousSound** property to animation **Effect** class.
* Added a number of properties to **TextFrameFormat** that enable formatting shape text: **MarginLeft**, **MarginRight**, **MarginTop**, **MarginBottom**, **WrapText**, **AnchoringType**, **CenterText**, **TextVerticalType**, **AutofitType**, **ColumnCount**, **ColumnSpacing**, **KeepTextFlat**, **RotationAngle**, **DefaultParagraphFormat**.
* Added **Pdf16**, **Pdf17**, **PdfA2b**, **PdfA2a**, **PdfA2u**, **PdfA3a**, **PdfA3b** to the list of allowed values for **PdfExportOptions.Compliance** property.

## Enhancements in Version 23.1

* New **CompressEmbeddedFonts** and **CompressEmbeddedFontsOnline** methods allow to reduce the size taken by embedded fonts by excluding unused characters.

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
Stream pdf = slidesApi.Convert(presentation, ExportFormat.Pdf);
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
