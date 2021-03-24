using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecondHand.Data;
using SecondHand.Models;
using SecondHand.Models.Homepage;

namespace SecondHand.Controllers
{
    public class Wishlist : Controller
    {
        private readonly SecondHandContext _context;
        public Wishlist(SecondHandContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Homepage homepage = new Homepage();
            var cookies = cookieProducts();
            homepage.Hp_Categories = (IEnumerable<Categories>)await _context.Categories.ToListAsync();
            homepage.Hp_Products = (IEnumerable<Products>)await _context.Products.Where(p => cookies.Contains(p.productId)).Include(p => p.Photos).ToListAsync();
            return View(homepage);
        }

        public List<int> cookieProducts() {
            List<int> products = new List<int>();

            if (Request.Cookies.ToList().Count() > 0){
                for(var i = 0; i < Request.Cookies.ToList().Count(); i++){
                    var id = Request.Cookies.ToList().ElementAt(i).Value;
                    int number;
                    bool isParsable = Int32.TryParse(id, out number);
                    if(isParsable) {
                        products.Add(number);
                    }
                }
                return products;
            }
            return null;
        }
    }
}
