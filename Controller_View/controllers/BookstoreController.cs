using Microsoft.AspNetCore.Mvc;

namespace Controller_View.controllers
{
    public class BookstoreController: Controller
    {
        public IActionResult Index()
        {
            //ViewData["name"] = "Asp.net Core";
            //ViewData["author"] = "Mcgrow Hills";
            //ViewData["price"] = 5000;

            //string[] book_name = { "JAVA", "PHP", "ASP.NET core" };
            //ViewData["bname"] = book_name;

            //ViewData["list1"] = new List<string>()
            //{
            //    "Football","Cricket","Hockey"
            //};

            ViewBag.name = "Ajin";
            ViewBag.author = "BMW";
            ViewBag.price = 5000;

            string[] book_name = { "JAVA", "PHP", "ASP.NET core" };
            ViewBag.bname = book_name;

            ViewBag.list = new List<string>()
            {
                "Football","Cricket","Hockey"
            };

            return View();
        }
    }
}
