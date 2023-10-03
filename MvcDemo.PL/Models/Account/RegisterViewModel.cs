using System.ComponentModel.DataAnnotations;

namespace MvcDemo.PL.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The Password field is required.")]
        [MinLength(5,ErrorMessage = "MinimumLength Is 5")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The ConfirmPassword field is required.")]
        [MinLength(5, ErrorMessage = "MinimumLength Is 5")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public bool IsAgree { get; set; }



    }
}
