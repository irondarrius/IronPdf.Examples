using IronPdf;
namespace IronPdf.Examples.HowTo.LinearizePdf
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("input.pdf");
            pdf.SaveAsLinearized(pdf.BinaryData, "linearized.pdf");
        }
    }
}