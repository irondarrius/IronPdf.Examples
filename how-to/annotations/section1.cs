using IronPdf.Annotations;
using IronPdf;
namespace IronPdf.Examples.HowTo.Annotations
{
    public static class Section1
    {
        public static void Run()
        {
            PdfDocument.FromFile("input.pdf")
                .Annotations.Add(new TextAnnotation(0) { Title="Note", Contents="Review this section.", X=50, Y=700 })
                .SaveAs("annotated.pdf");
        }
    }
}