***Based on <https://ironpdf.com/examples/http-request-header/>***

This snippet illustrates how to employ HTTP request headers with IronPDF for converting an authenticated webpage into a PDF document. The process begins with the instantiation of `**ChromePdfRenderer**`, a class designed to transform web pages or HTML content into PDF format. Subsequent steps involve configuring HTTP request headers; this is accomplished by populating a dictionary and assigning it to the `HttpRequestHeaders` attribute of the `RenderingOptions`.

In this example, we include an Authorization header with a Bearer token (`test-token-123`)—a standard practice in API authentication.

Following the setup of the headers, the `RenderUrlAsPdf` method is called to retrieve and transform the webpage present at [https://httpbin.org/bearer](https://httpbin.org/bearer) into a PDF. This URL serves as a test API endpoint which employs Bearer token authentication, validating that the header is transmitted properly.

The final step involves saving the generated PDF to "output.pdf" in the present working directory. This technique is particularly useful in creating PDFs from web pages that require authentication, such as confidential reports, interactive dashboards, or content produced via APIs.