using IronPdf;
namespace IronPdf.Examples.HowTo.PixelPerfectHtmlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.ChromePdfRenderer.RenderHtmlAsPdf("<html><body>Hello World</body></html>").SaveAs("output.pdf");
        }
    }
}