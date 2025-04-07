# Utilizing HTTP Request Headers

***Based on <https://ironpdf.com/how-to/http-request-header/>***


HTTP request headers are vital metadata elements transported from a client (like a web browser or API client) to a server during an HTTP request. These headers offer essential details about the request, encompassing authentication data, content type, user agent, among others.

This capability proves indispensable when converting a URL to a PDF, as it allows you to incorporate specific HTTP header information into the request.

<h3>Getting Started with IronPDF</h3>

---

## Utilizing HTTP Request Headers: A Practical Example

To begin, you need to structure a suitable HTTP request header object before leveraging the **HttpRequestHeaders** property for setting HTTP request headers. This object is then integrated into the URL request dispatched to the server during the conversion process. As a practical illustration, we will demonstrate using [httpbin.org](https://httpbin.org), a utility site that displays header requests.

```cs
using IronPdf;
using System.Collections.Generic;

// Instantiate a PDF renderer
var pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.HttpRequestHeaders = new Dictionary<string, string>
{
    { "Authorization", "Bearer your-example-token-123" }
};

// Convert an authenticated URL to PDF
var generatedPdf = pdfRenderer.RenderUrlAsPdf("https://httpbin.org/bearer");
generatedPdf.SaveAs("saved-output.pdf");
```

### Frequently Used HTTP Request Headers

- **Authorization**: This header sends authentication credentials, such as a Bearer token or Basic authentication.
- **Content-Type**: Specifies the nature of the request body, for example, application/json.
- **Accept**: Determines the anticipated response format like text/html or application/json.
- **User-Agent**: Denotes the client initiating the request, such as a browser or API client.
- **Referer**: Points to the page which referred to the current request.
- **Cookie**: Transmits cookies necessary for session management.