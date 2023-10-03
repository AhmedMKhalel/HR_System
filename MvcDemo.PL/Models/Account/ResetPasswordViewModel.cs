using System.ComponentModel.DataAnnotations;

namespace MvcDemo.PL.Models.Account
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "The Password field is required.")]
        [MinLength(5, ErrorMessage = "MinimumLength Is 5")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The ConfirmPassword field is required.")]
        [MinLength(5, ErrorMessage = "MinimumLength Is 5")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }


    }
}
