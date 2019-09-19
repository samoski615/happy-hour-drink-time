﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HappyHourTracker.Data;
using HappyHourTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace HappyHourTracker.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public RegisterModel(

            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }
        public object ViewBag { get; private set; }

        public class InputModel
        {





            //[Required]
            //public string Name { get; set; }

            //[Required]
            //[Display(Name = "Phone Number")]
            //public string PhoneNumber { get; set; }



            [Display(Name = "To create a BAR OWNER ACCOUNT, CLICK BOX BELOW, then click REGISTER!")]
            public bool IsBarOwner { get; set; }


            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            //this is the GET handler
            //ViewBag.Name = new SelectList(_context.Roles.ToList(), "Name", "Name", "-----Select------");
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            //this is the POST handler
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {

                    if (!await _roleManager.RoleExistsAsync(StaticDetails.DrinkConsumer))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(StaticDetails.DrinkConsumer));
                    }
                    if (!await _roleManager.RoleExistsAsync(StaticDetails.BarOwner))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(StaticDetails.BarOwner));
                    }

                    if (Input.IsBarOwner)
                    {
                        await _userManager.AddToRoleAsync(user, StaticDetails.BarOwner);
                        return RedirectToAction("Create", "BarOwners");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, StaticDetails.DrinkConsumer);
                        return RedirectToAction("Create", "DrinkConsumers");
                    }
                    _logger.LogInformation("User created a new account with password.");



                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }

                _logger.LogInformation("User created a new account with password.");


                //ViewBag.Name = new SelectList(_context.Roles.ToList(), "Name", "Name");

                // If we got this far, something failed, redisplay form
            }
                return Page();

            
        }
    }
}
