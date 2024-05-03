using Form_Tag_Helper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Form_Tag_Helper.Controllers
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
            return View();
        }
        [HttpPost]
        public string Index(Employee e1)
        {
            return "name=" + e1.Ename + "id=" + e1.Eid + "gender=" + e1.Gender + "Mstatus=" + e1.Mstatus + "description=" + e1.Description;
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
