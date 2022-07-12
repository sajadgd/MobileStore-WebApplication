using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using MobileStore1.Controllers;
using MobileStore.DataModelLayer.Utilities;
using MobileStore.DataModelLayer1.Entities;

namespace MobileStore1.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        //private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger
/*            IEmailSender emailSender*/)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
/*            _emailSender = emailSender*/;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
            [EmailAddress(ErrorMessage = "ایمیل را به درستی وارد کنید !")]
            [Display(Name = "ایمیل")]
            public string Email { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
            [StringLength(100, ErrorMessage = ErrorMessage.StringLength, MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "گذرواژه")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "تکرار گذرواژه")]
            [Compare("Password", ErrorMessage = ErrorMessage.Compare)]
            public string ConfirmPassword { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequierdMsg)]
            [MaxLength(11, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
            [MinLength(11, ErrorMessage = ErrorMessage.MinLenghtMsg)]
            [Display(Name = "تلفن همراه")]
            public string Mobile { get; set; }
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var Usr = await _userManager.FindByEmailAsync(Input.Email);

                if (Usr != null)
                {
                    ViewData["RegisterError"] = "ایمیل وارد شده قبلا ثبت شده است!!!";
                    return Page();
                }
                else
                {
                    var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, PhoneNumber = Input.Mobile, EmailConfirmed = true, PhoneNumberConfirmed = true };

                    var result = await _userManager.CreateAsync(user, Input.Password);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    }
                }
            }

            ViewData["RegisterError"] = "ثبت نام شما ناموفق بود لطفا دوباره امتحان کنید!!!";
            return Page();
        }
    }
}
