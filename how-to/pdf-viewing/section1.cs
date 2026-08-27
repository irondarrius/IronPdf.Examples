using IronPdf;
namespace IronPdf.Examples.HowTo.PdfViewing
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.Viewer.Maui.PdfViewer { Source = "document.pdf" };
        }
    }
}