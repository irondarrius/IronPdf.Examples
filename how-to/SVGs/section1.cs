using IronPdf;
namespace IronPdf.Examples.HowTo.SVGs
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer { RenderingOptions = { WaitFor = IronPdf.Rendering.WaitFor.RenderDelay(1000) } }
                .RenderHtmlAsPdf("<img src='https://example.com/logo.svg' style='width:100px;height:100px;'>")
                .SaveAs("svgToPdf.pdf");
        }
    }
}