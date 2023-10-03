using System.ComponentModel.DataAnnotations;

namespace MvcDemo.PL.Models.Account
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email.")]
        public string Email { get; set; }
    }
}
