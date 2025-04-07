# Exporting PDF to MemoryStream in C# 

***Based on <https://ironpdf.com/how-to/pdf-to-memory-stream/>***


In C# .NET, it is completely feasible to export a PDF to a `MemoryStream` without the need for any file system interaction. This functionality is provided by the `MemoryStream` class located within the `System.IO` namespace.

### Initialize with IronPDF

---

## Save PDF to Memory

A `IronPdf.PdfDocument` can be directly saved to memory using either of the following methods:

- [`IronPdf.PdfDocument.Stream`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) which returns the PDF as a `System.IO.MemoryStream`.
- [`IronPdf.PdfDocument.BinaryData`](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html) which returns the PDF as an array of bytes (`byte[]`).

```cs
using IronPdf;
using System.IO;

var pdfRenderer = new ChromePdfRenderer();

// Creating PDF from URL
PdfDocument document = pdfRenderer.RenderUrlAsPdf("https://ironpdf.com/");

// Retrieving PDF as MemoryStream
MemoryStream memoryStreamPdf = document.Stream;

// Retrieving PDF as ByteArray
byte[] byteArrayPdf = document.BinaryData;
```

## Serve PDF on Web from Memory

To distribute or serve a PDF file over the web, it's essential to transmit it as binary data rather than HTML. Further details can be discovered in this [guide on exporting and saving PDF documents in C#](https://ironpdf.com/how-to/export-save-pdf-csharp/).

Below are brief examples for deploying a PDF with MVC and ASP.NET:

### Serving a PDF in MVC

In the following example, the `FileStreamResult` utilizes the binary data gathered from `IronPDF`, specifying the MIME type as 'application/pdf' and setting a download file name.

```cs
return new FileStreamResult(memoryStreamPdf, "application/pdf")
{
    FileDownloadName = "download.pdf"
};
```

### Serving a PDF in ASP.NET

Just as in the MVC example, this snippet outlines how to configure the response stream using binary data from `IronPDF`, and how to flush this configuration to ensure the client receives the data.

```cs
Response.Clear();
Response.ContentType = "application/octet-stream";
Context.Response.OutputStream.Write(memoryStreamPdf, 0, memoryStreamPdf.Length);
Response.Flush();
```