using IronPdf;
namespace IronPdf.Examples.HowTo.XamlToPdfMaui
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = new IronPdf.ChromePdfRenderer().RenderContentPageToPdf<MainPage,App>().SaveAs("page.pdf");
        }
    }
}