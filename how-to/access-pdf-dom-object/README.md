# Interacting with PDF DOM Objects

***Based on <https://ironpdf.com/how-to/access-pdf-dom-object/>***


Interacting with the PDF DOM object involves engaging with the structure of a PDF file much like how one would manipulate the DOM of a webpage. For PDF files, the DOM represents the document’s internal setup, enabling developers to programmatically alter and retrieve various document elements like text, images, annotations, and metadata.

## Example: Accessing DOM Objects

To interact with the PDF's DOM, you need to start by importing the desired PDF and accessing its **Pages** property. You can then choose any page from the document to access its **ObjectModel** property.

Please note, this capability is still under development and has been observed to cause memory leaks, particularly when text objects from the DOM are accessed.

```cs
using IronPdf;  // PDF manipulation namespace
using System.Linq;  // LINQ for easy data querying

// Initialize the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Generate a PDF document from a specific URL
PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");

// Extract DOM Objects from the first page
var objects = pdf.Pages.First().ObjectModel;
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/access-pdf-dom-object/debug.webp" alt="Debug" class="img-responsive add-shadow">
    </div>
</div>

The **ObjectModel** property houses several sub-properties like **ImageObject**, **PathObject**, and **TextObject**. Each of these objects includes details such as the page index, bounding box, scale, and translations of the element, all of which can be modified.

**ImageObject** specifics:
- **Height**: The vertical size of the image.
- **Width**: The horizontal size of the image.
- **ExportBytesAsJpg**: Function to convert the image to a JPG format byte array.

**PathObject** details:
- **FillColor**: The interior color of the path.
- **StrokeColor**: The outline color of the path.
- **Points**: The set of coordinates that outline the path.

**TextObject** attributes:
- **Color**: The color of the text.
- **Contents**: The text content itself.