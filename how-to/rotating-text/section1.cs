using IronPdf;
namespace IronPdf.Examples.HowTo.RotatingText
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument.FromFile("input.pdf")
              .SetAllPageRotations(IronPdf.PdfPageRotation.Clockwise90)
              .SaveAs("rotated.pdf");
        }
    }
}