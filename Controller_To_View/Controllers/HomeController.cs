using Controller_To_View.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Controller_To_View.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["data1"] = "View Data Access";
            ViewBag.data2 = "Data accessed by Viewbag";
            TempData["data3"] = "Temp data access";
            TempData.Keep();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
