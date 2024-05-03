using Microsoft.AspNetCore.Mvc;

namespace view_demo1.controllers
{
    public class StudentController: Controller
    {
        public ViewResult Edit()
        {
            return View();
        }
        public ViewResult Delete() 
        { 
            return View(); 
        }
    }
}
