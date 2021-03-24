using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using SecondHand.Data;
using SecondHand.Models;
using static Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal.ExternalLoginModel;

namespace SecondHand.Areas.Identity.Pages.Account.Manage
{
    public class EditProductModel : PageModel
    {

        private readonly UserManager<User> _userManager;
        private readonly SecondHandContext _context;
        private readonly IWebHostEnvironment WebHostEnvironment;
        private readonly ILogger<User> _logger;

        public EditProductModel(
           UserManager<User> userManager,
            SecondHandContext context,
            IWebHostEnvironment webHostEnvironment,
            ILogger<User> logger

            )
        {
            _userManager = userManager;
            _context = context;
            WebHostEnvironment = webHostEnvironment;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string StatusMessage { get; set; }
        public Products Product { get; private set; }


        public bool hasProduct { get; set; }

        public class InputModel
        {
            public int productId { get; set; }
            [Required]
            public string productTitle { get; set; }

            [Required]
            public string productDesc { get; set; }


            [Required]
            [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]

            public Double productPrice { get; set; }


            [Required]
            public decimal productDiscount { get; set; }


            [Required]
            public string productSize { get; set; }

            [Required]
            [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]

            public decimal productShippingPrice { get; set; }

            [Required]
            [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]

            public int productStock { get; set; }

            [Required]
            public IFormFile productImage { get; set; }

            public string photoSrc { get; set; }
            public string photoThumb { get; set; }


            public string type { get; set; }


        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id != null)
            {
                this.hasProduct = true;
                var user = await _userManager.GetUserAsync(User);
                var product = await _context.Products
                                .Include(u => u.Users)
                                .Include(p => p.Photos)
                                .Where(m => m.Users.Id.Equals(user.Id) && m.productId == id).FirstOrDefaultAsync();


                ViewData["productName"] = product.productTitle;
                ViewData["productDesc"] = product.productDesc;
                ViewData["productPrice"] = product.productPrice;
                ViewData["productDisc"] = product.productDiscount;
                ViewData["productSize"] = product.productSize;
                ViewData["productStock"] = product.productStock;
                ViewData["productImg"] = product.Photos.ElementAt(0).photoThumb;
                ViewData["productId"] = product.productId;

                this.Product = product;
            }

            return Page();

        }



        public async Task<IActionResult> OnPostAsync()
        {

            var user = await _userManager.GetUserAsync(User);
            var product = await _context.Products
                 .Include(u => u.Users)
                 .Where(m => m.Users.Id.Equals(user.Id) && m.productId == Input.productId).FirstOrDefaultAsync();

            if (product != null)
            {
                    _logger.LogInformation("TYPE BABO:" + Input.type);
                if (Input.type == "Delete") {
                    _context.Remove(product);
                    await _context.SaveChangesAsync();

                    return Redirect("ViewProduct");
                }
                else
                {

                    product.productTitle = Input.productTitle;
                    product.productPrice = Input.productPrice;
                    product.productDiscount = Input.productDiscount;
                    product.productSize = Input.productSize;
                    product.productStock = Input.productStock;

                    try
                    {
                        _context.Update(product);
                        await _context.SaveChangesAsync();
                        return LocalRedirect("/Identity/Account/Manage/ViewProduct");
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ProductsExists(product.productId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }

                }
            }
            return Page();
        }
        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.productId == id);
        }
    }

}