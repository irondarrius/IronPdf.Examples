using IronPdf;
namespace IronPdf.Examples.HowTo.BlazorTutorial
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.HtmlToPdf.RenderHtmlAsPdf(htmlContent).SaveAs(outputPath);
        }
    }
}