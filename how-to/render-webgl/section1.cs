using IronPdf.Engines.Chrome;
using IronPdf;
namespace IronPdf.Examples.HowTo.RenderWebgl
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.Installation.SingleProcess = true; IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Hardware;
            new IronPdf.ChromePdfRenderer { RenderingOptions = { WaitFor = IronPdf.Rendering.WaitFor.RenderDelay(5000) } }
                .RenderUrlAsPdf("https://example.com/webgl‑demo")
                .SaveAs("webgl‑output.pdf");
        }
    }
}