using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfViewing
{
    public static class Section1
    {
        public static void Run()
        {
            var viewer = new IronPdf.Viewer.Maui.PdfViewer { Source = "document.pdf" };
        }
    }
}