using IronPdf;
namespace IronPdf.Examples.HowTo.CshtmlToPdfMvcCore
{
    public static class Section1
    {
        public static void Run()
        {
            // using IronPdf.Extensions.Mvc.Core
            new IronPdf.ChromePdfRenderer().RenderRazorViewToPdf(HttpContext, "Views/Home/Report.cshtml", model).SaveAs("report.pdf");
        }
    }
}