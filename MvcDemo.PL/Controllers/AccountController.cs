using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.DAL.Entities;
using MvcDemo.PL.Helper;
using MvcDemo.PL.Models.Account;

namespace MvcDemo.PL.Controllers
{
    public class AccountController : Controller
    {
        public SignInManager<ApplicationUser> _signInManager { get; }
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        #region Sign Up

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email.Split('@')[0],
                    IsAgree = registerViewModel.IsAgree

                };
                 var result = await _userManager.CreateAsync(user,registerViewModel.Password);

                if (result.Succeeded)
                    return RedirectToAction("SignIn");
                foreach (var error in result.Errors)
                     ModelState.AddModelError(String.Empty, error.Description );
                 

            }
            return View(registerViewModel);

        }
        #endregion


        #region Sign In

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
                if (user is not null)
                {
                    var password = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                    if (password)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password,
                            loginViewModel.RememberMe, false);
                        if (result.Succeeded)
                            return RedirectToAction("Index", "Home");

                        ModelState.AddModelError(String.Empty, "Invalid Password");

                    }

                }

                ModelState.AddModelError(String.Empty, "Invalid Email");

            }

            return View(loginViewModel);
        }

        #endregion

        #region Sign Out

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn");
        }
        #endregion

        #region Forget Password

        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Email);
                if (user is not null)
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var resetPasswordLink = Url.Action("ResetPassword","Account" 
                        , new {Email=forgetPasswordViewModel.Email ,Token = token},Request.Scheme);
                    var email = new Email()
                    {
                        Title = "Reset Password",
                        Body = resetPasswordLink,
                        To = forgetPasswordViewModel.Email

                    };
                    //Method To Send Email
                    //go to your Google Account => Security => 2-Step Verification =>enable it
                    //App Passwords
                    EmailSettings.SendEmail(email);
                    return RedirectToAction("CompleteForgetPassword");

                }
                ModelState.AddModelError(String.Empty, "Invalid Email");


            }
            return View(forgetPasswordViewModel);
        }
        #endregion

        #region Forget Password

        public IActionResult ResetPassword(string email , string token)
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);
                if (user is not null)
                {
                    var result = await _userManager.ResetPasswordAsync(user, resetPasswordViewModel.Token,
                        resetPasswordViewModel.Password);
                    if (result.Succeeded)
                        return RedirectToAction("ResetPasswordDone");
                    foreach (var error in result.Errors)
                        ModelState.AddModelError(String.Empty, error.Description);
                }

                //return RedirectToAction("ResetPassword");
            }

            return View(resetPasswordViewModel);
        }
        #endregion
        public IActionResult ResetPasswordDone()
        {
            return View();

        }
        public IActionResult CompleteForgetPassword()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }


    }
}
