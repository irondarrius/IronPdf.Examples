using IronPdf;
namespace IronPdf.Examples.HowTo.PdfImageFlattenCsharp
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument.FromFile("input.pdf").Flatten().SaveAs("flattened.pdf");
        }
    }
}