using Microsoft.AspNetCore.Mvc;
using controller_JSON.Models;

namespace controller_JSON.Controllers_JSON
{
    [Controller]
    public class MvcController : Controller
    {
        [Route("/employee/Ajin")]

        public ContentResult employee()
            // public JsonResult employee()
        {
            return Content("{\"name\":\"Ajin\"}", "application/json");
        }

        [Route("/empdata")]
        public JsonResult emp()
        {
            Employee e = new Employee()
            {
                Id = 22000216,
                Name = "Ajin",
                Salary = 69000
            };
            return new JsonResult(e);
        }

    }
}