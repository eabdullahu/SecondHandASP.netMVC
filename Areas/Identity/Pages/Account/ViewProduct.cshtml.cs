using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SecondHand.Data;
using SecondHand.Models;
using static Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal.ExternalLoginModel;

namespace SecondHand.Areas.Identity.Pages.Account.Manage
{
    public class ViewProductModel : PageModel
    {

        private readonly UserManager<User> _userManager;
        private readonly SecondHandContext _context;
        private readonly ILogger<User> _logger;
        public ViewProductModel(
            UserManager<User> userManager,
             SecondHandContext context,
             ILogger<User> logger

             )
        {
            _userManager = userManager;
            _context = context;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string StatusMessage { get; set; }
        public object ViewBag { get; private set; }
        public IEnumerable<Products> Products { get; set; }






            public async Task<IActionResult> OnGet()
        {

            var user = await _userManager.GetUserAsync(User);
            var product = await _context.Products
                            .Include(u => u.Users)
                            .Include(p => p.Photos)
                            .Where(m => m.Users.Id.Equals(user.Id)).ToListAsync();

            
            this.Products = product;

            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            return Page();

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            var products = await _context.Products.FindAsync(id);
            _context.Products.Remove(products);
            await _context.SaveChangesAsync();
            return Page();
        }
    }
}
