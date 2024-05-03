using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
namespace Model_BuiltIn_Validation.Models
{
    public class BookModel
    {
        
        public int? BookId { get; set; }
        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Book name")]
        [StringLength(100,MinimumLength =4,ErrorMessage = "{0} must be given between {2} and {1}. Comeonnnn Parita.")]
        //[RegularExpression("^[a-z][A-Z]$", ErrorMessage = "Given bookname is not valid Paritaa. Comeonnnnn.")]

        public string BookName { get; set; }
        [Required]
        public string Author { get; set; }
        [Range(1,99.999,ErrorMessage = "Price should be between 1 to 100.")]
        public decimal? Price { get; set; }
        [EmailAddress(ErrorMessage = "To enter valid Email.")]
        public string Email { get; set; }

        public String Password { get; set; }
        [Compare("Password", ErrorMessage = "Password doesnot match.")]
        public String cpass { get; set; }
    }
}