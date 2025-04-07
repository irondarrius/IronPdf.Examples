# How to Generate New PDF Documents

***Based on <https://ironpdf.com/how-to/create-new-pdfs/>***


Generating a new PDF involves creating a blank PDF file from the ground up by programmatically inserting elements such as text, images, or complex layouts. This can be efficiently handled with C# libraries such as IronPDF, which gives developers the tools to design and format content before outputting as a finalized PDF file.

## Example of Creating an Empty PDF

To kick off, we can look into various methods to instantiate a PDF. The fundamental approach involves using just the width and height dimensions. Employing the **PdfDocument** constructor in this manner provides us with a pristine PDF, all set for further development and utilization.

### Sample Code

```cs
using IronPdf;

PdfDocument pdf = new PdfDocument(270, 270);

pdf.SaveAs("blankPage.pdf");
```

<hr>

## Loading a PDF from a File

To transform or adapt a PDF, you first need to load it as a **PdfDocument** object. Achieve this through the `FromFile` method of the **PdfDocument** class. The versatility of this class also supports loading PDFs via JSON, byte arrays, streams, and URLs.

### Example Code

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

pdf.SaveAs("export.pdf");
```

<hr>

## Converting Other Formats to PDF

Beyond the methods previously described for obtaining a **PdfDocument** object, there's also the capability to convert other formats directly into PDF. The most advanced of these is converting HTML to PDF, which renders HTML files to PDF while preserving all associated content such as JavaScript, images, links, and CSS designed with the Chrome engine. Additional conversions from image files, RTF, Markdown, and XML are possible as well.

<!-- Note: Rendering might appear different than expected from our site; for example, some component backgrounds turned transparent -->

### Conversion Code

```cs
using IronPdf;

// Initialize a new PDF renderer
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.EnableJavaScript = true;
renderer.RenderingOptions.PrintHtmlBackgrounds = true;
renderer.RenderingOptions.PaperFit.UseResponsiveCssRendering(1800);
renderer.RenderingOptions.WaitFor.RenderDelay(5000);
renderer.RenderingOptions.CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print;

// Render a PDF from a URL or local file
var pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");

// Save the rendered PDF
pdf.SaveAs("url.pdf");
```

<!-- Embedded PDF -->

 <!-- PDF rendering output embedded in an iframe -->
<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/custom-paper-size/extendedLeftSide.pdf#view=fit" width="100%" height="400px">
</iframe> <!-- End of iframe embedding -->