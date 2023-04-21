using System.ComponentModel.DataAnnotations;

namespace MVC_News.Models.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password is wrong")]
        public string ConfirmPassword { get; set; }
    }
}
