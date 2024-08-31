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

## Enhancements in Version 24.8

* Added **StartSplit** and **StartUploadAndSplit** methods to async API.
* Added **ReplacePresentationRegex** and **ReplacePresentationRegexOnline** methods.
* Added **HighlightPresentationText** and **HighlightPresentationRegex** methods.
* Added **OperationError** class; changed **Operation**.**Error** property type from string to **OperationError**.
* Removed **wholeWordsOnly** parameter from **ReplaceShapeRegex** method.

## Enhancements in Version 24.7

* Added **TemplatesPath** property to **Html5ExportOptions** class. It enables using custom templates in conversion to Html5 format.
* Added **GetHtml5Templates** method to retrieve the list of default Html5 templates.
* Added **Xml** to the list of available export formats.
* Added **wholeWordsOnly** parameter to **ReplacePresentationText** and  **ReplacePresentationTextOnline** methods.
* Added **GradientStyle** property to **ExportOptions** class.
* Added **ResterizeUnsupportedFontStyles** property to **PdfExportOptions** class.
* Added **Zip64Mode** property to **PptxExportOptions** class.
* Added **Transparency** property to **Table** and **TableCell** class.
* Removed obsolete **DownloadPortionsAsMathML**, **SavePortionsAsMathML** methods. Use **DownloadMathPortion** and **SaveMathPortion** methods to convert portions to math formats.

## Enhancements in Version 24.6

* Added **HideInk** and **InterpretMaskOpAsOpacity** properties to **PdfExportOptions** class.
* Removed **Enqueued** from the list of allowed values for **Operation.Status** property.

## Enhancements in Version 24.5

* Added **options** parameter to **ImportFromPdf** method. You can specify **options.DetectTables** property to control import behavior.
* Added **Title** property to **Axis** class for charts.
* Added **X**, **Y**, **Width**, **Height**, **Overlay**, **FillFormat**, **EffectFormat** and **LineFormat** properties to **ChartTitle** class.
* Added **HasTitle** property to **Chart** class; removed **HasTitle** property from **ChartTitle** class.

## Enhancements in Version 24.4

* Added **DownloadMathPortion** and **SaveMathPortion** methods to convert math portions to math markup formats (MathML or LaTeX). See [documentation](https://docs.aspose.cloud/slides/export-a-math-formula/) for more info. **DownloadPortionAsMathML** and **SavePortionAsMathML** methods are deprecated and will be removed after 24.6.
* Added **Marker** property to **DataPoint** class.

## Enhancements in Version 24.3

* Added Markdown (**Md**) to the list of allowed export formats.
* Added **DeletePictureCroppedAreas** method to delete cropped areas of pictures.
* Added **SlidesLayoutOptions** property to **PdfExportOptions**, **HtmlExportOptions**, **TiffExportOptions** and **ImageExportOptions** classes. You can use it to specify handout or notes/comments layouting options.
* Added **AnimateTextType** enum property to **Effect** class.
* Added **NotesCommentsLayouting** property to **Html5ExportOptions** class.
* Added **BwConversionMode** property to **TiffExportOptions** class.
* Added **EmbedImages** boolean property to **Html5ExportOptions** class.
* Added **ShowMediaControls** boolean property to **SlideShowProperties** class.
* Added **IsDecorative** boolean property to **ShapeBase** class.


## Enhancements in Version 24.2

* Added **GetCommentAuthors** method to get list of comment authors.

## Enhancements in Version 24.1

* Added **GetAvailableFonts** method to get list of installed system & custom fonts.

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
