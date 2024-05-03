using Microsoft.AspNetCore.Mvc;
namespace ActionSelector_core_mvc.controllers
{
    [Controller]
    public class Home: Controller
    {
        [ActionName("i1")]
        public string index()
        {
            return "index page";
        }
        [ActionName("Modify")]
        public string Edit()
        {
            return "Hello from updated Method";
        }

        [HttpGet]
        public string Delete()
        {
            return "Hello from Delete method";
        }

        [NonAction]
        public string Update()
        {
            return "Hello from Update method";
        }
    }
}
