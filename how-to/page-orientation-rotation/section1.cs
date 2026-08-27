using IronPdf;
namespace IronPdf.Examples.HowTo.PageOrientationRotation
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument.FromFile("file.pdf")
                .SetAllPageRotations(IronPdf.PdfDocument.PageRotation.Rotate90)
                .SaveAs("rotated.pdf");
        }
    }
}