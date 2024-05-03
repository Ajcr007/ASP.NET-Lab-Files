using Microsoft.AspNetCore.Mvc;

namespace view_demo1.controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }
    }
}
