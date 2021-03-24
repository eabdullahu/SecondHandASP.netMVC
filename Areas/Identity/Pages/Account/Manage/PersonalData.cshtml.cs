
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SecondHand.Models;
using SecondHand.Data;

namespace SecondHand.Areas.Identity.Pages.Account.Manage
{
    public class PersonalDataModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly ILogger<PersonalDataModel> _logger;
        private readonly SignInManager<User> _signInManager;
        private readonly SecondHandContext _context;


        public PersonalDataModel(
            UserManager<User> userManager,
             SignInManager<User> signInManager,
             SecondHandContext context,
            ILogger<PersonalDataModel> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _context = context;
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public object ViewBag { get; private set; }


     

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            ViewData["username"] = user.UserFirstname;
            ViewData["lastname"] = user.UserLastname;
            ViewData["mail"] = user.Email;
            ViewData["address"] = user.UserAddress;
            ViewData["phone"] = user.PhoneNumber;

            return Page();
        }

        public class InputModel
        {
            [Required]
            [Display(Name = "First Name")]
            public string UserFirstname { get; set; }

            [Required]
            [Display(Name = "Last Name")]

            public string UserLastname { get; set; }


            [Required]
            [Display(Name = "Last Name")]

            public string UserName { get; set; }

            [Required]
            public string PhoneNumber { get; set; }

            [Required]
            public string UserAddress { get; set; }

        }
   

        public async Task<IActionResult> OnPostAsync()
        {
        
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
               return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
          
            user.UserFirstname  = this.Input.UserFirstname;
            user.UserLastname = this.Input.UserLastname;
            user.UserAddress = this.Input.UserAddress;
            user.PhoneNumber = this.Input.PhoneNumber;

            await _userManager.UpdateAsync(user);

            ViewData["username"] = user.UserFirstname;
            ViewData["lastname"] = user.UserLastname;
            ViewData["mail"] = user.Email;
            ViewData["address"] = user.UserAddress;
            ViewData["phone"] = user.PhoneNumber;
            TempData["Referrer"] = "SaveRegister";

            return Page();

        }


    }
}