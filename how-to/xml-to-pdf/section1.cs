using IronPdf;
namespace IronPdf.Examples.HowTo.XmlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer()
                .RenderHtmlAsPdf(
                    XslCompiledTransform.Load("template.xslt")
                        .Transform(XmlReader.Create("data.xml"), new StringWriter())
                        .ToString()
                )
                .SaveAs("output.pdf");
        }
    }
}