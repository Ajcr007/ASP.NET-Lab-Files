//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ModelDemo.Model;

namespace ModelDemo.Controllers
{
    public class BookController : Controller
    {
        //https://localhost:7041/book_data/216/Ajin
        [Route("/book_data/{bookid?}/{author?}")]
        public IActionResult book_bind(Book book)
        {
            if (book.BookId.HasValue == false)
            {
                return Content($"Book ID is not available", "text/plain");
            }
            else
            {
                return Content($"Book ID is : {book.BookId} \n book author is : {book.Author}", "text/plain");
            }
        }
    }
}
