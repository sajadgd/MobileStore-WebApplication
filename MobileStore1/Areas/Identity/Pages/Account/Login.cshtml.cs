using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MobileStore.DataModelLayer.Utilities;
using MobileStore.DataModelLayer1.Entities;
using MobileStore1.Controllers;

namespace MobileStore1.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<ApplicationUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
            [EmailAddress]
            [Display(Name = "ایمیل")]
            public string Email { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
            [DataType(DataType.Password)]
            [Display(Name = "گذرواژه")]
            public string Password { get; set; }

            [Display(Name = "مرا به خاطر بسپار")]
            public bool RememberMe { get; set; }
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var applicationuser = await _userManager.FindByEmailAsync(Input.Email);

                if (applicationuser == null)
                {
                    ViewData["LoginError"] = "لطفا ایمیل وارد شده را بررسی نمائید!!!";

                    return Page();
                }
                else
                {
                    var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    }

                    else
                    {
                        ViewData["LoginError"] = "ایمیل یا گذرواژه وارد شده اشتباه است لطفا دوباره امتحان کنید!!!";

                        return Page();
                    }
                }
            }

            ViewData["LoginError"] = "اطلاعات را به درستی وارد نمائید!!!";

            return Page();
        }
    }
}
