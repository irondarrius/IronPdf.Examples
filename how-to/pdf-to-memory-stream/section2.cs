using IronPdf;
namespace IronPdf.Examples.HowTo.PdfToMemoryStream
{
    public static class Section2
    {
        public static void Run()
        {
            return new FileStreamResult(pdfAsStream, "application/pdf")
            {
                FileDownloadName = "download.pdf"
            };
        }
    }
}