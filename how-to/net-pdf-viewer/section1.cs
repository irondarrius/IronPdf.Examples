using IronPdf;
namespace IronPdf.Examples.HowTo.NetPdfViewer
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.Viewer.Maui.IronPdfView { Source = IronPdf.Viewer.Maui.PdfViewSource.FromFile("document.pdf") };
        }
    }
}