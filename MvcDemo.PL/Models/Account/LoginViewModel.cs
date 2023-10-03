using System.ComponentModel.DataAnnotations;

namespace MvcDemo.PL.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email Is Required")]
        [MinLength(5, ErrorMessage = "MinimumLength Is 5")]
        public string Password { get; set; }

       
        public bool RememberMe { get; set; }



    }
}
