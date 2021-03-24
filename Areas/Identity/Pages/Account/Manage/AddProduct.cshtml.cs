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
    public class AddProductModel : PageModel
    {

        private readonly UserManager<User> _userManager;
        private readonly SecondHandContext _context;
        private readonly IWebHostEnvironment WebHostEnvironment;
        private readonly ILogger<User> _logger;

        public AddProductModel(
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
            public int productId { get;set; }
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
                ViewData["productId"] = product.productId;

                this.Product = product;
            }

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {

            var user = await _userManager.GetUserAsync(User);
            string fileName = UploadFile(Input.productImage);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

                Products data = new Products()
                {
                    Users = user,
                    productTitle = Input.productTitle,
                    productDesc = Input.productDesc,
                    productQuanitity = Input.productStock,
                    productPrice = Input.productPrice,
                    productShippingPrice = Input.productShippingPrice,
                    productStock = Input.productStock,
                    productSize = Input.productSize

                };

                _context.Add(data);
                await _context.SaveChangesAsync();                
                int lastProductId = _context.Products.Max(item => item.productId);

                ProductPhotos img = new ProductPhotos()
                {
                    productId = lastProductId,
                    photoSrc = fileName,
                    photoThumb = fileName

                };
              
                    _context.Add(img);
                    await _context.SaveChangesAsync();
                    return LocalRedirect("/Identity/Account/Manage/ViewProduct");



            return Page();
        }

        private string UploadFile(IFormFile img)
        {
            string file = null;
            if (img != null)
            {

                string UploadDir = Path.Combine(WebHostEnvironment.WebRootPath, "images/products");
                file = Guid.NewGuid().ToString() + "-" + img.FileName;
                string filePath = Path.Combine(UploadDir, file);
                using (var fileStream = new FileStream(filePath,FileMode.Create))
                {

                    img.CopyTo(fileStream);

                }
            }
            return file;
        
       }
        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.productId == id);
        }
    }
}
