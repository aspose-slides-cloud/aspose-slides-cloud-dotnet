# .NET REST API to Process Presentation in Cloud
This repository contains Aspose.slides Cloud SDK for .NET source code. This SDK allows you to [process & manipulate PPT, PPTX, ODP, OTP](https://products.aspose.cloud/slides/net) using Aspose.slides Cloud REST APIs in your .NET applications.

You may want to check out Aspose free [PPT to PDF](https://products.aspose.app/slides/conversion), [PPT to Word](https://products.aspose.app/slides/conversion/ppt-to-word), and [PPT to JPG](https://products.aspose.app/slides/conversion/ppt-to-jpg) converters because they are live implementations of popular conversion processes.

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

## Enhancements in Version 22.5
* Added **Paragraphs** property to **SmartArtNode** class to enable getting and setting text for SmartArt nodes.
* Added **ImageTransformList** property to **PictureFill** class to enable setting image transform effects. Added **ImageTransformEffect** class and subclasses for different kind of of effects.
* Added **PictureFillFormat** property to **VideoFrame** class to enable setting poster image for video frames.
* Added **SlideIndex** and **ShapeIndex** properties to **ResourceUri** class to simplify retrieveing slide & shape indexes for resources.
* Removed redundant **BoxAndWhiskersSeries**, **WaterfallSeries** and **WaterfallChartDataPoint** classes.

## Enhancements in Version 22.4
* Added **TransitionType** and **SlidesTransitionDuration** properties to **VideoExportOptions** class to enable creation videos with transitions.
* Added **DefaultPortionFormat** property to **Paragraph** class. Added new **PortionFormat** class.
* Added **EmbeddedFileBase64Data** and a number of other properties to **OleObjectFrame** class to enable creation of OLE Object frames.
* Added **AccessPermissions** class to support access permissions for PDF export.
* Added **PictureFillformat** property to **AudioFrame** class.
* Added **RowIndex** and **ColumnIndex** properties to **TableCell** class.
* Moved **Width** and **Height** properties from **ExportOptions** base class to the new **ImageExportOptionsBase class**. This is a superclass for **ImageExportOptions**, **GifExportOptions** and **TiffExportOptions** classes.
* Removed redundant **Shapes** property from **ShapeBase** class. It is only left for **GroupShape** class.

## Enhancements in Version 22.3
* Added **ModernSlideComment** class to support modern comments. Also added **SlideCommentBase** as base class for comments.
* Added optional **shapeIndex** parameter to **CreateComment** and **CreateCommentOnline** methods.
* Added **GetParagraphRectangle**, **GetPortionRectangle** method and new **TextBounds** class to get paragraph or portion bounds.
* Added optional **shapeType** parameter for **GetShapes** method. You can now get list of shapes of a particular type (e.g. charts or tables).
* Added **FontFallbackRules** class and **FontFallbackRules** property to **ExportOptions** class.
* Added **LatinFont**, **EastAsianFont** and **ComplexScriptFont** properties to **Portion** class to enable getting and seting portion font name.
* Added **ChartLinesFormat** class; added **MajorGridLinesFormat** and **MinorGridLinesFormat** properties to Axis class.
* Added **HideLegend** boolean property to **Legend** class.

## Enhancements in Version 22.2
* Added **Mpeg4** to the list of allowed values for **ExportFormat** type. You can now convert presentations to video.
* New **HighlightShapeText** and **HighlightShapeRegex** methods.
* New **DeleteUnusedLayoutSlides** and **DeleteUnusedLayoutSlides** methods.
* New **ZoomFrame** and **ZoomObject** classes with a number of subclasses.
* Added **TextFrameFormat** property to **Shape** class to support WordArt.
* Added **XYSeries** class as a supercalss for **ScatterSeries** and **BubbleSeries** methods.
* Added **None** to the list of allowed values for **TimeUnitType** enum type.
* **Level** property of **Category** class is deprecated and will be removed after v22.4.

## Enhancements in Version 22.1
* New **MathParagraph** property of **Portion** class allows to get and set math formulas. A set of **MathElement** subclasses allows to specify complex mathematical expressions.
* New **DownloadPortionAsMathMl** and **SavePortionAsMathMl** methods allow to export math formulas to MathML format.
* New **HyperlinkClick** and **HyperlinkMouseOver** methods of **ShapeBase** and **Portion** classes enable creation and manipulating hyperlinks for shapes and portions.
* New methods **GetShapeGeometryPath** and **SetShapeGeometryPath** can be used to get or set geometry paths for shapes. You can use lines, arcs and curves to specify custom shape boundaries.
* New **AlignSubshapes** method enables aligning shapes within a shape group.
* New **PlayAcrossSlides** and **RewindAudio** properties are added to **AudioFrame** class.
* Added **InClickSequence** to the list of allowable values for **AudioPlayModePreset** and **AudioPlayModePreset** enum types.

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
