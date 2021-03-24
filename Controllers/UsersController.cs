using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SecondHand.Data;
using SecondHand.Models;
using SecondHand.Models.Homepage;

namespace SecondHand.Controllers
{
    public class UsersController : Controller
    {
        private readonly SecondHandContext _context;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<UsersController> _logger;

        public UsersController(SecondHandContext context, UserManager<User> userManager, ILogger<UsersController> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }

        // GET: Users
        public async Task<IActionResult> Index(string search, string start_date, string end_date, string selectUsersbyRole, int page = 1)
        {
            var TO_SHOW = 20;
            // User Roles
            List<SelectListItem> UserRoles = new List<SelectListItem> {
                new SelectListItem {Text = "All", Value = "All"},
                new SelectListItem {Text = "Super Adimin", Value = "SuperAdmin"},
                new SelectListItem {Text = "Basic", Value = "Basic"},
            };

            ViewData["UserRolesData"] = UserRoles;
            ViewData["UserRoles"] = selectUsersbyRole ;
            ViewData["search"] = search;
            var users = _context.Users.AsQueryable();
            if (String.IsNullOrEmpty(selectUsersbyRole) || selectUsersbyRole.Equals("All")) {
                // Get all users with all 
                 users = (
                        from user in _context.Users
                        join userRole in _context.UserRoles
                             on user.Id equals userRole.UserId
                        join role in _context.Roles
                             on userRole.RoleId equals role.Id select user

                        ).AsQueryable();
            } else if(selectUsersbyRole.Equals("Basic"))
            { 
                users = (
                          from user in _context.Users
                          join userRole in _context.UserRoles
                               on user.Id equals userRole.UserId
                          join role in _context.Roles
                               on userRole.RoleId equals role.Id
                          where role.Name.Equals("Basic")
                          select user).AsQueryable();
            }
            else 
            {
                users = (
                          from user in _context.Users
                          join userRole in _context.UserRoles
                               on user.Id equals userRole.UserId
                          join role in _context.Roles
                               on userRole.RoleId equals role.Id
                          where role.Name.Equals("SuperAdmin")
                          select user).AsQueryable();
            }


            if (!String.IsNullOrEmpty(search))
            {
                users = users.Where(u => u.NormalizedUserName.Contains(search) || u.NormalizedEmail.Contains(search) || u.UserFirstname.ToLower().Contains(search.ToLower()) || u.UserLastname.ToLower().Contains(search.ToLower()));
            }

            if (CheckDate(start_date))
            {

                users = users.Where(u => u.UserRegisterDate >= DateTime.Parse(start_date));
            }

            if (CheckDate(end_date))
            {

                users = users.Where(u => u.UserRegisterDate <= DateTime.Parse(end_date));
            }

            ViewData["totalPage"] = users.Count();
            if (page < 1 || page > (int)Math.Ceiling(Convert.ToDouble(ViewData["totalPage"]) / TO_SHOW))
            {
                page = 1;
            }
            ViewData["pageindex"] = page;
            ViewData["totalPages"] = (int)Math.Ceiling(Convert.ToDouble(ViewData["totalPage"]) / TO_SHOW);
            

            var getFrom = (page - 1) * TO_SHOW;

            _logger.LogInformation("from: " + getFrom + "  to: "+ TO_SHOW);

            users = users.Skip(getFrom).Take(TO_SHOW);

            return View( await users.ToListAsync());
        }
       

        // GET: Users/Create
        public IActionResult Create()
        {
            ViewData["cityId"] = new SelectList(_context.City, "cityId", "cityCode");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,UserFirstname,UserLastname,UserAddress,UserPhoneNumber,UserCity,Password,ConfirmPassword")] InputModel Input)
        {
            ViewData["cityId"] = new SelectList(_context.City, "cityId", "cityName");
            _logger.LogInformation("Valid mo123123");
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Valid modelstate!");
                var user = new User { UserName = Input.Email, Email = Input.Email, UserFirstname = Input.UserFirstname, UserLastname = Input.UserLastname, UserAddress = Input.UserAddress, PhoneNumber = Input.UserPhoneNumber, UserCityId = Input.UserCity };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    await _userManager.AddToRoleAsync(user, Enums.Roles.SuperAdmin.ToString());
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
               
            
            return View();
        }
        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            // GetClaimsAsync retunrs the list of user Claims
            var userClaims = await _userManager.GetClaimsAsync(user);
            // GetRolesAsync returns the list of user Roles
            //var userRoles = await _userManager.GetRolesAsync(user);
            var roles = await _userManager.GetRolesAsync(user);
            string[] userRolesString = new string[1];
            
            foreach (var r in roles) {
                userRolesString[0] = r;
            }

            var model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Firstname = user.UserFirstname,
                Surname = user.UserLastname,
                Role = userRolesString[0],
                Enabled2FA = user.TwoFactorEnabled,
                EnabledStatus = user.EmailConfirmed

                
            };

            return View(model);


        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Firstname,Surname,Email,UserName,Role,password,Enabled2FA,EnabledStatus,CityId")] EditUserViewModel model)
        {

            if ( !_context.Users.Any(a => a.Id == model.Id && a.Email == model.Email) )
            {
                _logger.LogInformation("Not valid for Update!");
                return NotFound();
            }
            
            try
            {
                var updatedUser = await  _userManager.FindByIdAsync(id);
                updatedUser.UserFirstname = model.Firstname;
                updatedUser.UserLastname = model.Surname;

                _context.Update(updatedUser);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                _logger.LogInformation("Update faild!");
                if (!_context.Users.Any(x => x.Id == model.Id && x.Email == model.Email))
                {
                    _logger.LogInformation("Update faild!");
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
          
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.UserCity)
                .FirstOrDefaultAsync(m => m.Id.Equals(id));
            if (user == null)
            {
                return NotFound();
            }

            var model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Firstname = user.UserFirstname,
                Surname = user.UserLastname,
                Enabled2FA = user.TwoFactorEnabled,
                EnabledStatus = user.EmailConfirmed


            };

            return View(model);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var users = await _context.Users.FindAsync(id);
            _context.Users.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public class EditUserViewModel
        {
            public EditUserViewModel()
            {
            }

            public string Id { get; set; }

            [Required]
            public string UserName { get; set; }
           
            public string Firstname { get; set; }
            [Required]
            public string Surname { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            public string password { get; set; }

            public bool Enabled2FA { get; set; }

            public bool EnabledStatus { get; set; }

            public int CityId { get; set; }

            public string Role { get; set; }

        }

        public class InputModel
        {
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

            [Required]
            [Display(Name = "Firstname")]

            public string UserFirstname { get; set; }

            [Required]
            [Display(Name = "Lastname")]

            public string UserLastname { get; set; }

            [Required]
            [Display(Name = "Phone Number")]
            public string UserPhoneNumber { get; set; }

            [Required]
            [Display(Name = "Addres")]

            public string UserAddress { get; set; }


            [Display(Name = "City")]

            public int UserCity { get; set; }

            public City city { get; set; }


        }
        protected bool CheckDate(String date)

        {

            try

            {

                DateTime dt = DateTime.Parse(date);

                return true;

            }
            catch

            {

                return false;

            }

        }

    }
}
