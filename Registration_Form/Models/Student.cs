using System.ComponentModel.DataAnnotations;

namespace Registration_Form.Models
{
    public class Student
    {
        [Required(ErrorMessage = "First Name required")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "First Name cannot contain numbers")]
        [StringLength(50)]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Last Name cannot contain numbers")]
        [StringLength(50)]
        public string Lname { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200, ErrorMessage = "Address must be between {2} and {1} characters.", MinimumLength = 2)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, ErrorMessage = "Password must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [Phone(ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "At least one hobby is required.")]
        public bool HobbyReading { get; set; }
        public bool HobbyTravelling { get; set; }
        public bool HobbyCooking { get; set; }
        public bool HobbySports { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Hobby
    {
        Reading,
        Traveling,
        Cooking,
        Sports
    }
}
