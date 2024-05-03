using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace MyController.controller
{
    [Controller]
    public class HomeController:Controller
    {
        [Route("Home")]
        [Route("/")]

        public ContentResult index()
        {
            return Content("<h1>Nuvrachana</h1>", "text/html");

            //return new ContentResult
            //{
            //    Content = "<h1>This is my first content type application.</h1>",
            //    ContentType = "text/plain"
            //};
        }
        /*public string index()
        {
            return "This is index action of home controller.";
        }

        [Route("aboutus")]
        public String About_us()
        {
            return "This is my about us page.";
        }

        [Route("contact")]
        public String Contact_us()
        {
            return "This is my contact us page.";
        }

        [Route("/product/{id:int:min(1000):max(9999)}")]
        public String products()
        {
            return "This is my product page.";
        }*/
    }
}
