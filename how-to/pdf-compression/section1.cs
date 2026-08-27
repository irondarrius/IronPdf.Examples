using IronPdf;
namespace IronPdf.Examples.HowTo.PdfCompression
{
    public static class Section1
    {
        public static void Run()
        {
            PdfDocument.FromFile("input.pdf").CompressImages(40).SaveAs("compressed.pdf");
        }
    }
}