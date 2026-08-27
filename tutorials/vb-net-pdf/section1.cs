using IronPdf;
namespace IronPdf.Examples.Tutorial.VbNetPdf
{
    public static class Section1
    {
        public static void Run()
        {
            Dim PDF As New IronPdf.PdfDocument() 
            PDF.SaveAs("output.pdf")
        }
    }
}