using IronPdf;
namespace IronPdf.Examples.HowTo.AspNetMvcPdfBinary
{
    public static class Section1
    {
        public static void Run()
        {
            /**
             * Serve Existing PDF
             * anchor-serve-existing-pdf-file
             */
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", "attachment;filename=\"FileName.pdf\"");
            
            // Write the PDF file bytes to the response
            Response.BinaryWrite(System.IO.File.ReadAllBytes("MyPdf.pdf"));
            
            // Flush the response buffer and end the response
            Response.Flush();
            Response.End();
        }
    }
}