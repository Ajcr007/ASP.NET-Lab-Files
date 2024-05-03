using Microsoft.AspNetCore.Mvc;
namespace Controller_FileResult.controllers
{
    [Controller]
    public class FileController : Controller
    {
        [Route("file3/download")]
        public FileContentResult FileDownload3()
        {
            byte[] b = System.IO.File.ReadAllBytes("D:\\pic.jpg");
            return new FileContentResult(b, "image/jpg");
        }
    }
}
