using IronPdf;
namespace IronPdf.Examples.HowTo.ViewportZoom
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer { RenderingOptions = { ViewPortWidth = 1280, Zoom = 1.8 } }
                .RenderUrlAsPdf("https://example.com")
                .SaveAs("zoomedViewport.pdf");
        }
    }
}