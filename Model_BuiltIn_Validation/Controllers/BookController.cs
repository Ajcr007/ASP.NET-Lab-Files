using Microsoft.AspNetCore.Mvc;
using Model_BuiltIn_Validation.Models;
using System.ComponentModel;
namespace Model_BuiltIn_Validation.Controllers
{
    [Controller]
    public class BookController : Controller
    {
        [Route("/books/{BookId?}/{BookName?}/{Author?}/{Price?}/{Email?}/{Password?}/{cpass?}")]
        public IActionResult book_data(BookModel b1)
        {
            if (b1.BookId.HasValue == false)
            {
                return Content($"Book ID is not available", "text/plain");
            }
            //if (String.IsNullOrEmpty(b1.BookName))
            //{
            //    return BadRequest("Book name not provided.");
            //}
            //return Content($"Book ID is : {b1.BookId} \n book name is : {b1.BookName}", "text/plain");

            if (!ModelState.IsValid)
            {
                List<String> errors = new List<string>();
                foreach (var values in ModelState.Values)
                {
                    foreach (var error in values.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }
                string errormsg = String.Join("\n", errors);
                return BadRequest(errormsg);
            }
            return Content($"Bookid={b1.BookId} \n" + 
                $" Book Name={b1.BookName} \n" + 
                $"Book Author={b1.Author} \n" +
                $"Book Price={b1.Price} \n"+
                $"Email Address={b1.Email} \n" +
                $"Password={b1.Password} \n" +
                $"Password verified={b1.cpass} \n", "text/plain");
        }
    }
}