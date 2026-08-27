using IronPdf;
namespace IronPdf.Examples.HowTo.Ironpdf2021ChromeRenderingEngineEap
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.ChromePdfRenderer.RenderHtmlAsPdf("<h1>Hello, World!</h1>");
        }
    }
}