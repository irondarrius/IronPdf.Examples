using IronPdf;
namespace IronPdf.Examples.HowTo.CreateNewPdfs
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.PdfDocument { DefaultPageSize = new IronPdf.PageSize(270,270) }.SaveAs("blankPage.pdf");
        }
    }
}