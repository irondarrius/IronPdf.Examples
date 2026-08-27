using IronPdf;
namespace IronPdf.Examples.HowTo.TableOfContents
{
    public static class Section1
    {
        public static void Run()
        {
            new ChromePdfRenderer { RenderingOptions = { CreateOutlineMaps = true, OutlineMapsFormat = TableOfContentsTypes.WithPageNumbers, FirstPageNumber = 1 } }
                .RenderHtmlFileAsPdf("myDocument.html")
                .SaveAs("withToc.pdf");
        }
    }
}